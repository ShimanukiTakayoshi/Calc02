Public Class Form1

  Private Calc As Calc = New Calc

  Private Property ShowMenu As Boolean
    Get
      Return My.Settings.ShowMenu
    End Get
    Set(ByVal value As Boolean)
      My.Settings.ShowMenu = value
      ToolStripMenuItemSettingShowMenu.Checked = value
      MenuStrip1.Visible = value
    End Set
  End Property

  Private Property ShowAdjustedExpression As Boolean
    Get
      Return My.Settings.ShowAdjustedExpression
    End Get
    Set(ByVal value As Boolean)
      My.Settings.ShowAdjustedExpression = value
      ToolStripMenuItemSettingShowAdjustedExpression.Checked = value
    End Set
  End Property

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.KeyPreview = True
    ShowMenu = My.Settings.ShowMenu
    Me.Text = Application.ProductName
    Me.MinimumSize = New Drawing.Size(600, 200)
    Me.Size = My.Settings.Size
    Me.AcceptButton = ButtonExecute

    With SplitContainer1
      .BackColor = Color.Yellow
      .Panel1.BackColor = SystemColors.Control
      .Panel2.BackColor = SystemColors.Control
      .Panel1.Padding = New Padding(6)
      .Panel2.Padding = .Panel1.Padding
    End With

    With TextBoxExpression
      .Multiline = True
      .Dock = DockStyle.Fill
      .Font = My.Settings.Font
      .Select()
    End With

    With FontDialog1
      .AllowVerticalFonts = False
      .ScriptsOnly = True
      .ShowEffects = False
    End With

    SplitContainer1.SplitterDistance = My.Settings.SplitterDistance
    ShowAdjustedExpression = My.Settings.ShowAdjustedExpression

    Me.Location = My.Settings.Location
    If Me.Left < Screen.GetWorkingArea(Me).Left OrElse
       Me.Left >= Screen.GetWorkingArea(Me).Right Then
      Me.Left = 100
    End If
    If Me.Top < Screen.GetWorkingArea(Me).Left OrElse
       Me.Left >= Screen.GetWorkingArea(Me).Right Then
      Me.Left = 100
    End If
  End Sub

  Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
    If e.Alt Then MenuStrip1.Visible = True
  End Sub

  Private Sub ToolStripMenuItemFileExit_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemFileExit.Click
    Application.Exit()
  End Sub

  Private Sub MenuStrip1_MenuDeactivate(sender As Object, e As EventArgs) Handles MenuStrip1.MenuDeactivate
    If Not ShowMenu Then MenuStrip1.Visible = False
  End Sub

  Private Sub ToolStripMenuItemSettingShowMenu_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingShowMenu.Click
    ShowMenu = Not ShowMenu
  End Sub

  Private Sub ToolStripMenuItemHelpReadme_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpReadme.Click
    Dim s = IO.Path.GetDirectoryName(Application.ExecutablePath)
    s = IO.Path.Combine(s, "readme.txt")
    If IO.File.Exists(s) Then
      Process.Start(s)
    Else
      MessageBox.Show(s & "が見つかりません", "エラー")
    End If
  End Sub

  Private Sub ToolStripMenuItemHelpWeb_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpWeb.Click
    Process.Start("http://www.yahoo.co.jp")
  End Sub

  Private Sub ToolStripMenuItemHelpVersion_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemHelpVersion.Click
    Dim s = ""
    s = Application.ProductName & " " & Application.ProductVersion & " (2016/02/22)" + Environment.NewLine
    Dim fileVersionInfo = Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
    Dim copyright = fileVersionInfo.LegalCopyright
    s &= copyright & Environment.NewLine & Environment.NewLine
    s &= "実行ファイル：" & Environment.NewLine & Application.ExecutablePath & Environment.NewLine & "("
    If Environment.Is64BitProcess Then
      s &= "64"
    Else
      s &= "32"
    End If
    s &= "ビット・プロセスとして稼働）" & Environment.NewLine & Environment.NewLine
    Dim c = New Devices.Computer
    s &= "オペレーティングシステム：" &
      Environment.NewLine & c.Info.OSFullName & " " & c.Info.OSVersion & " "
    If Environment.Is64BitOperatingSystem Then
      s &= "64"
    Else
      s &= "32"
    End If
    s &= "ビット"
    MessageBox.Show(s, "バージョン情報")
  End Sub

  Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
    Me.WindowState = FormWindowState.Normal
    My.Settings.Location = Me.Location
    My.Settings.Size = Me.Size
    My.Settings.Font = TextBoxExpression.Font
    My.Settings.SplitterDistance = SplitContainer1.SplitterDistance
  End Sub

  Private Sub ButtonExecute_Click(sender As Object, e As EventArgs) Handles ButtonExecute.Click
    Calc.Expression = TextBoxExpression.Text
    If Calc.Status = Calc.StatusCode.Success Then
      If ShowAdjustedExpression And
      TextBoxExpression.Text <> Calc.expression Then
        TextBoxExpression.Text = Calc.expression
        TextBoxExpression.ForeColor = Color.Red
      End If
      TextBoxResult.Text = CDec(Calc.Answer).ToString
    Else
      MessageBox.Show(Calc.message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)
      TextBoxResult.Clear()
    End If
  End Sub

  Private Sub TextBoxExpression_TextChanged(sender As Object, e As EventArgs) Handles TextBoxExpression.TextChanged
    TextBoxExpression.ForeColor = Color.Black
  End Sub

  Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
    TextBoxExpression.Clear()
  End Sub

  Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
    Me.Close()
  End Sub

  Private Sub ButtonCopy_Click(sender As Object, e As EventArgs) Handles ButtonCopy.Click
    TextBoxExpression.Text = TextBoxResult.Text
  End Sub

  Private Sub ToolStripMenuItemSettingShowAdjustedExpression_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingShowAdjustedExpression.Click
    ShowAdjustedExpression = Not ShowAdjustedExpression
  End Sub

  Protected Overloads Function processdialogkey(keydata As Keys) As Boolean
    Select Case keydata And Keys.KeyCode
      Case Keys.Escape
        TextBoxExpression.Clear()
    End Select
    Return MyBase.ProcessDialogKey(keydata)
  End Function

  Private Sub ToolStripMenuItemEdit_DropDownOpening(sender As Object, e As EventArgs) Handles ToolStripMenuItemEdit.DropDownOpening
    ToolStripMenuItemEditCopy.Enabled = TextBoxResult.Text <> ""
    ToolStripMenuItemEditCopyAll.Enabled = TextBoxExpression.Text <> "" AndAlso TextBoxResult.Text <> ""
    ToolStripMenuItemEditPaste.Enabled = My.Computer.Clipboard.ContainsText AndAlso My.Computer.Clipboard.GetText <> ""
  End Sub

  Private Sub ToolStripMenuItemEditCopy_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditCopy.Click
    Clipboard.SetText(TextBoxResult.Text)
  End Sub

  Private Sub ToolStripMenuItemEditCopyAll_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditCopyAll.Click
    Clipboard.SetText(TextBoxExpression.Text & "=" & TextBoxResult.Text)
  End Sub

  Private Sub ToolStripMenuItemEditPaste_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemEditPaste.Click
    Dim s = My.Computer.Clipboard.GetText
    s = StrConv(s, VbStrConv.Narrow)
    TextBoxExpression.Text = s
  End Sub

  Private Sub ToolStripMenuItemSettingSettingFont_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItemSettingSettingFont.Click
    TextBoxExpression.Font = SetFont(TextBoxExpression.Font)
    TextBoxResult.Font = TextBoxExpression.Font
  End Sub

  Private Function SetFont(target As Font) As Font
    FontDialog1.Font = target
    If FontDialog1.ShowDialog Then target = FontDialog1.Font
    Return target
  End Function

End Class
