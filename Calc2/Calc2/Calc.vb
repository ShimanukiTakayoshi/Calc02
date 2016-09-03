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



  End Function




End Class
