Public Class Calc
  Public Answer As Double
  Public Message As String

  Private ExpressionValue As String
  Public Property Expression As String
    Get
      Return ExpressionValue
    End Get
    Set(value As String)
      ExpressionValue = value
      Status = Calc(ExpressionValue)
    End Set
  End Property

  Private StatusValue As Integer
  Public Property Status As Integer
    Get
      Return StatusValue
    End Get
    Set(value As Integer)
      StatusValue = value
      Message = Message(value)
    End Set
  End Property

  Public Enum StatusCode
    Success
    ErrorParenthesisEmpty
    ErrorParenthesisOrder
    ErrorParenthesisNumber
    ErrorTooMuch
    ErrorIlligalLetter
    Error2Dots
    ErrorNothing
    ErrorEnd
    ErrorBegin
    Error2OPerators
    ErrorDivideByZero
    ErrorParenthesisOperator
    ErrorArrayCalcBreak
    ErrorOthers
  End Enum

  Private Message() = New String() {
    "成功",
    "カッコの並びに問題があります",
    "カッコの数が一致しません",
    "数式が長過ぎます",
    "不正な文字があります",
    "小数点が正しくありません",
    "数式がありません",
    "最後の文字に問題があります",
    "最初の文字に問題があります",
    "演算子が連続しています",
    "ゼロによる除算はできません",
    "カッコまたは演算子に問題があります",
    "計算用配列が壊れました",
    "その他のエラー"}

  Private Function Calc(exp As String) As Integer
    Const arraysize = 100
    Dim array1(arraysize), array3(arraysize), array5(arraysize) As String
    Dim array2(arraysize), array4(arraysize) As Integer
    Dim array1Counter = 0, array3Counter = 0, array5Counter = 0
    Dim calcArray(arraysize) As Double
    Dim c As Char
    Dim s = ""
    Dim i, j As Integer
    Dim setChar As String

    exp = StrConv(exp, VbStrConv.Narrow)
    exp = exp.Replace(" ", "")
    exp = exp.Replace(vbCrLf, "")

    If exp = "" Then Return StatusCode.ErrorNothing
    If exp.Contains("()") Then Return StatusCode.ErrorParenthesisEmpty

    setChar = "*/^)"
    If setChar.Contains(exp.First) Then Return StatusCode.ErrorBegin

    setChar = "+-*/^("
    If setChar.Contains(exp.Last) Then Return StatusCode.ErrorEnd

    setChar = "+-*/^"
    For i = 0 To exp.Length - 3
      If setChar.Contains(exp(i)) Then
        If setChar.Contains(exp(i + 1)) Then
          Return StatusCode.Error2OPerators
        End If
      End If
    Next

    If exp.Contains(")"c) Or exp.Contains("(")c) Then
      j = 0
      For i = 0 To exp.Length - 1
        Select Case exp(i)
          Case "("c
            setChar = "*/^"
            If setChar.Contains(exp(i + 1)) Then Return StatusCode.ErrorParenthesisOperator
            j += 1
          Case ")"c
            setChar = "+-*/^"
            If setChar.Contains(exp(i - 1)) Then Return StatusCode.ErrorParenthesisOperator
            j -= 1
        End Select
        If j < 0 Then Return StatusCode.ErrorParenthesisOrder
      Next
      If j <> 0 Then Return StatusCode.ErrorParenthesisNumber
    End If

    If exp.First = "+"c Or exp.First = "-"c Then exp = "0"c + exp
    exp = exp.Replace("(+", "(0+")
    exp = exp.Replace("(-", "(0-")
    If exp.Contains("("c) Then
      For i = 1 To exp.Length - 1
        If exp(i) = "("c Then
          Select Case exp(i - 1)
            Case "0"c To "9"c, "."
              exp = Left(exp, i) & "*"c & Right(exp, exp.Length - 1)
          End Select
        End If
      Next
    End If

    If exp.Contains(")"c) Then
      For i = 0 To exp.Length - 2
        If exp(i) = ")"c Then
          Select Case exp(i + 1)
            Case "0"c To "9"c, "."c
              exp = Left(exp, i + 1) & "*"c & rigth(exp, exp.Length - i - 1)
          End Select
        End If
      Next
    End If
    ExpressionValue = exp

    For i = 0 To exp.Length - 1
      c = exp(i)
      Select Case c
        Case "0"c To "9"c, "."c
          s &= c
        Case "+", "-"c, "*"c, "/"c, "^"c, "("c, ")"c
          If s <> "" Then
            If array1Counter < arraysize Then
              array1(array1Counter) = s
              array1(array1Counter + 1) = c
              array1Counter += 2
              s = ""
            Else
              Return StatusCode.ErrorTooMuch
            End If
          Else
            If array1Counter < arraysize Then
              array1(array1Counter) = c
              array1Counter += 1
            Else
              Return StatusCode.ErrorTooMuch
            End If
          End If
        Case Else
          Return StatusCode.ErrorIlligalLetter
      End Select
    Next

    If s = "" Then
      array1Counter -= 1
    Else
      array1(array1Counter) = s
    End If

    For i = 0 To array1Counter
      s = array1(i)
      j = s.IndexOf("."c)
      If j > -1 Then
        s = Right(s, s.Length - j - 1)
        If s.IndexOf("."c) > -1 Then Return StatusCode.Error2Dots
      End If
    Next

    For i = 0 To array1Counter
      Select Case array1(i)(0)
        Case "("c
          array2(i) = 1
        Case "+"c, " - c"
          array2(i) = 2
        Case "*"c, "/"c
          array2(i) = 3
        Case "~"c
          array2(i) = 4
        Case Else
          array2(i) = 5
      End Select
    Next

    For i = 0 To array1Counter
      Select Case array1(i)(0)
        Case "("c
          array3Counter += 1
          array3(array3Counter) = array1(i)
          array4(array3Counter) = array2(i)
        Case ")"c
          While (array3(array3Counter) <> "("c)
            array5(array5Counter) = array3(array3Counter)
            array5Counter += 1
            array3Counter -= 1
          End While
          array3Counter -= 1
        Case Else
          While (array3Counter > 0)
            If array2(i) <= array4(array3Counter) Then
              array5(array5Counter) = array3(array3Counter)
              array5Counter += 1
              array3Counter -= 1
            Else
              Exit While
            End If
          End While
          array3Counter += 1
          array3(array3Counter) = array1(i)
          array4(array3Counter) = array2(i)
      End Select
    Next

    While (array3Counter > 0)
      array5(array5Counter) = array3(array3Counter)
      array5Counter += 1
      array3Counter -= 1
    End While

    Try
      j = 0
      setChar = "+-*/^"
      For i = 0 To array5Counter - 1
        If setChar.Contains(array5(i)(0)) Then
          If j < 2 Then Return StatusCode.ErrorArrayCalcBreak
          Select Case array5(i)(0)
            Case "+"c
              calcArray(j - 2) = calcArray(j - 2) + calcArray(j - 1)
            Case "-"c
              calcArray(j - 2) = calcArray(j - 2) - calcArray(j - 1)
            Case "*"c
              calcArray(j - 2) = calcArray(j - 2) * calcArray(j - 1)
            Case "/"c
              If calcArray(j - 1) = 0 Then Return StatusCode.ErrorDivideByZero
              calcArray(j - 2) = calcArray(j - 2) / calcArray(j - 1)
            Case "~"c
              calcArray(j - 2) = Math.Pow(calcArray(j - 2), calcArray(j - 1))
          End Select
          j -= 1
        Else
          calcArray(j) = Double.Parse(array5(i))
          j += 1
        End If
      Next
      Answer = calcArray(0)
      Return StatusCode.Success
    Catch ex As Exception
      Return StatusCode.ErrorOthers
    End Try
  End Function
End Class























