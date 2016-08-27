Public Class Form1

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

  Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    Me.KeyPreview = True
    ShowMenu = My.Settings.ShowMenu

    Me.Text = Application.ProductName
    Me.MinimumSize = New Drawing.Size(300, 100)
    Me.Size = My.Settings.Size

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
  End Sub
End Class
