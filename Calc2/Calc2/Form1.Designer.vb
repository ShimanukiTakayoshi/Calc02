﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
  Inherits System.Windows.Forms.Form

  'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
  <System.Diagnostics.DebuggerNonUserCode()> _
  Protected Overrides Sub Dispose(ByVal disposing As Boolean)
    Try
      If disposing AndAlso components IsNot Nothing Then
        components.Dispose()
      End If
    Finally
      MyBase.Dispose(disposing)
    End Try
  End Sub

  'Windows フォーム デザイナーで必要です。
  Private components As System.ComponentModel.IContainer

  'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
  'Windows フォーム デザイナーを使用して変更できます。  
  'コード エディターを使って変更しないでください。
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
    Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
    Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
    Me.TextBoxExpression = New System.Windows.Forms.TextBox()
    Me.PanelRightBottom = New System.Windows.Forms.Panel()
    Me.ButtonExit = New System.Windows.Forms.Button()
    Me.ButtonCopy = New System.Windows.Forms.Button()
    Me.ButtonExecute = New System.Windows.Forms.Button()
    Me.ButtonClear = New System.Windows.Forms.Button()
    Me.TextBoxResult = New System.Windows.Forms.TextBox()
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FToolStripMenuItemFile = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemFileExit = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemEdit = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemEditCopy = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemEditCopyAll = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemEditPaste = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSetting = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingShowMenu = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingShowAdjustedExpression = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemSettingSettingFont = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelp = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpReadme = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpWeb = New System.Windows.Forms.ToolStripMenuItem()
    Me.ToolStripMenuItemHelpVersion = New System.Windows.Forms.ToolStripMenuItem()
    Me.FontDialog1 = New System.Windows.Forms.FontDialog()
    Me.ToolStripContainer1.ContentPanel.SuspendLayout()
    Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
    Me.ToolStripContainer1.SuspendLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
    Me.SplitContainer1.Panel1.SuspendLayout()
    Me.SplitContainer1.Panel2.SuspendLayout()
    Me.SplitContainer1.SuspendLayout()
    Me.PanelRightBottom.SuspendLayout()
    Me.MenuStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'ToolStripContainer1
    '
    Me.ToolStripContainer1.BottomToolStripPanelVisible = False
    '
    'ToolStripContainer1.ContentPanel
    '
    Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.SplitContainer1)
    Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(541, 237)
    Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.ToolStripContainer1.LeftToolStripPanelVisible = False
    Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
    Me.ToolStripContainer1.Name = "ToolStripContainer1"
    Me.ToolStripContainer1.RightToolStripPanelVisible = False
    Me.ToolStripContainer1.Size = New System.Drawing.Size(541, 261)
    Me.ToolStripContainer1.TabIndex = 0
    Me.ToolStripContainer1.Text = "ToolStripContainer1"
    '
    'ToolStripContainer1.TopToolStripPanel
    '
    Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
    '
    'SplitContainer1
    '
    Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
    Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
    Me.SplitContainer1.Name = "SplitContainer1"
    '
    'SplitContainer1.Panel1
    '
    Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxExpression)
    '
    'SplitContainer1.Panel2
    '
    Me.SplitContainer1.Panel2.Controls.Add(Me.PanelRightBottom)
    Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxResult)
    Me.SplitContainer1.Size = New System.Drawing.Size(541, 237)
    Me.SplitContainer1.SplitterDistance = 180
    Me.SplitContainer1.TabIndex = 0
    '
    'TextBoxExpression
    '
    Me.TextBoxExpression.Location = New System.Drawing.Point(18, 17)
    Me.TextBoxExpression.Name = "TextBoxExpression"
    Me.TextBoxExpression.Size = New System.Drawing.Size(107, 19)
    Me.TextBoxExpression.TabIndex = 0
    '
    'PanelRightBottom
    '
    Me.PanelRightBottom.Controls.Add(Me.ButtonExit)
    Me.PanelRightBottom.Controls.Add(Me.ButtonCopy)
    Me.PanelRightBottom.Controls.Add(Me.ButtonExecute)
    Me.PanelRightBottom.Controls.Add(Me.ButtonClear)
    Me.PanelRightBottom.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.PanelRightBottom.Location = New System.Drawing.Point(0, 137)
    Me.PanelRightBottom.Name = "PanelRightBottom"
    Me.PanelRightBottom.Size = New System.Drawing.Size(357, 100)
    Me.PanelRightBottom.TabIndex = 1
    '
    'ButtonExit
    '
    Me.ButtonExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonExit.Location = New System.Drawing.Point(252, 52)
    Me.ButtonExit.Name = "ButtonExit"
    Me.ButtonExit.Size = New System.Drawing.Size(71, 25)
    Me.ButtonExit.TabIndex = 3
    Me.ButtonExit.Text = "終了"
    Me.ButtonExit.UseVisualStyleBackColor = True
    '
    'ButtonCopy
    '
    Me.ButtonCopy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonCopy.Location = New System.Drawing.Point(175, 52)
    Me.ButtonCopy.Name = "ButtonCopy"
    Me.ButtonCopy.Size = New System.Drawing.Size(71, 25)
    Me.ButtonCopy.TabIndex = 2
    Me.ButtonCopy.Text = "＜－－"
    Me.ButtonCopy.UseVisualStyleBackColor = True
    '
    'ButtonExecute
    '
    Me.ButtonExecute.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonExecute.Location = New System.Drawing.Point(252, 21)
    Me.ButtonExecute.Name = "ButtonExecute"
    Me.ButtonExecute.Size = New System.Drawing.Size(71, 25)
    Me.ButtonExecute.TabIndex = 1
    Me.ButtonExecute.Text = "計算"
    Me.ButtonExecute.UseVisualStyleBackColor = True
    '
    'ButtonClear
    '
    Me.ButtonClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.ButtonClear.Location = New System.Drawing.Point(175, 21)
    Me.ButtonClear.Name = "ButtonClear"
    Me.ButtonClear.Size = New System.Drawing.Size(71, 25)
    Me.ButtonClear.TabIndex = 0
    Me.ButtonClear.Text = "クリア"
    Me.ButtonClear.UseVisualStyleBackColor = True
    '
    'TextBoxResult
    '
    Me.TextBoxResult.Location = New System.Drawing.Point(22, 17)
    Me.TextBoxResult.Name = "TextBoxResult"
    Me.TextBoxResult.Size = New System.Drawing.Size(100, 19)
    Me.TextBoxResult.TabIndex = 0
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FToolStripMenuItemFile, Me.ToolStripMenuItemEdit, Me.ToolStripMenuItemSetting, Me.ToolStripMenuItemHelp})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FToolStripMenuItemFile
    '
    Me.FToolStripMenuItemFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemFileExit})
    Me.FToolStripMenuItemFile.Name = "FToolStripMenuItemFile"
    Me.FToolStripMenuItemFile.Size = New System.Drawing.Size(66, 20)
    Me.FToolStripMenuItemFile.Text = "ファイル(&F)"
    '
    'ToolStripMenuItemFileExit
    '
    Me.ToolStripMenuItemFileExit.Name = "ToolStripMenuItemFileExit"
    Me.ToolStripMenuItemFileExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
    Me.ToolStripMenuItemFileExit.Size = New System.Drawing.Size(155, 22)
    Me.ToolStripMenuItemFileExit.Text = "終了(&X)"
    '
    'ToolStripMenuItemEdit
    '
    Me.ToolStripMenuItemEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemEditCopy, Me.ToolStripMenuItemEditCopyAll, Me.ToolStripMenuItemEditPaste})
    Me.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit"
    Me.ToolStripMenuItemEdit.Size = New System.Drawing.Size(57, 20)
    Me.ToolStripMenuItemEdit.Text = "編集(&E)"
    '
    'ToolStripMenuItemEditCopy
    '
    Me.ToolStripMenuItemEditCopy.Name = "ToolStripMenuItemEditCopy"
    Me.ToolStripMenuItemEditCopy.Size = New System.Drawing.Size(168, 22)
    Me.ToolStripMenuItemEditCopy.Text = "結果をコピー(&C)"
    '
    'ToolStripMenuItemEditCopyAll
    '
    Me.ToolStripMenuItemEditCopyAll.Name = "ToolStripMenuItemEditCopyAll"
    Me.ToolStripMenuItemEditCopyAll.Size = New System.Drawing.Size(168, 22)
    Me.ToolStripMenuItemEditCopyAll.Text = "式と結果をコピー(&A)"
    '
    'ToolStripMenuItemEditPaste
    '
    Me.ToolStripMenuItemEditPaste.Name = "ToolStripMenuItemEditPaste"
    Me.ToolStripMenuItemEditPaste.Size = New System.Drawing.Size(168, 22)
    Me.ToolStripMenuItemEditPaste.Text = "貼り付け(&V)"
    '
    'ToolStripMenuItemSetting
    '
    Me.ToolStripMenuItemSetting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemSettingShowMenu, Me.ToolStripMenuItemSettingShowAdjustedExpression, Me.ToolStripMenuItemSettingSettingFont})
    Me.ToolStripMenuItemSetting.Name = "ToolStripMenuItemSetting"
    Me.ToolStripMenuItemSetting.Size = New System.Drawing.Size(57, 20)
    Me.ToolStripMenuItemSetting.Text = "設定(&S)"
    '
    'ToolStripMenuItemSettingShowMenu
    '
    Me.ToolStripMenuItemSettingShowMenu.Name = "ToolStripMenuItemSettingShowMenu"
    Me.ToolStripMenuItemSettingShowMenu.Size = New System.Drawing.Size(204, 22)
    Me.ToolStripMenuItemSettingShowMenu.Text = "常にﾒﾆｭｰを表示する(&M)"
    '
    'ToolStripMenuItemSettingShowAdjustedExpression
    '
    Me.ToolStripMenuItemSettingShowAdjustedExpression.Name = "ToolStripMenuItemSettingShowAdjustedExpression"
    Me.ToolStripMenuItemSettingShowAdjustedExpression.Size = New System.Drawing.Size(204, 22)
    Me.ToolStripMenuItemSettingShowAdjustedExpression.Text = "編集された式を表示する(&S)"
    '
    'ToolStripMenuItemSettingSettingFont
    '
    Me.ToolStripMenuItemSettingSettingFont.Name = "ToolStripMenuItemSettingSettingFont"
    Me.ToolStripMenuItemSettingSettingFont.Size = New System.Drawing.Size(204, 22)
    Me.ToolStripMenuItemSettingSettingFont.Text = "フォント(&F)"
    '
    'ToolStripMenuItemHelp
    '
    Me.ToolStripMenuItemHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItemHelpReadme, Me.ToolStripMenuItemHelpWeb, Me.ToolStripMenuItemHelpVersion})
    Me.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp"
    Me.ToolStripMenuItemHelp.Size = New System.Drawing.Size(65, 20)
    Me.ToolStripMenuItemHelp.Text = "ヘルプ(&H)"
    '
    'ToolStripMenuItemHelpReadme
    '
    Me.ToolStripMenuItemHelpReadme.Name = "ToolStripMenuItemHelpReadme"
    Me.ToolStripMenuItemHelpReadme.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpReadme.Text = "ReadMe.txtを表示(&R)"
    '
    'ToolStripMenuItemHelpWeb
    '
    Me.ToolStripMenuItemHelpWeb.Name = "ToolStripMenuItemHelpWeb"
    Me.ToolStripMenuItemHelpWeb.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpWeb.Text = "Webサイトを表示(&W)"
    '
    'ToolStripMenuItemHelpVersion
    '
    Me.ToolStripMenuItemHelpVersion.Name = "ToolStripMenuItemHelpVersion"
    Me.ToolStripMenuItemHelpVersion.Size = New System.Drawing.Size(182, 22)
    Me.ToolStripMenuItemHelpVersion.Text = "バージョン情報(&V)"
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(541, 261)
    Me.Controls.Add(Me.ToolStripContainer1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
    Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
    Me.ToolStripContainer1.ResumeLayout(False)
    Me.ToolStripContainer1.PerformLayout()
    Me.SplitContainer1.Panel1.ResumeLayout(False)
    Me.SplitContainer1.Panel1.PerformLayout()
    Me.SplitContainer1.Panel2.ResumeLayout(False)
    Me.SplitContainer1.Panel2.PerformLayout()
    CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
    Me.SplitContainer1.ResumeLayout(False)
    Me.PanelRightBottom.ResumeLayout(False)
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.ResumeLayout(False)

  End Sub

  Friend WithEvents ToolStripContainer1 As ToolStripContainer
  Friend WithEvents MenuStrip1 As MenuStrip
  Friend WithEvents FToolStripMenuItemFile As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemFileExit As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSetting As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingShowMenu As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelp As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpReadme As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpWeb As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemHelpVersion As ToolStripMenuItem
  Friend WithEvents SplitContainer1 As SplitContainer
  Friend WithEvents TextBoxExpression As TextBox
  Friend WithEvents TextBoxResult As TextBox
  Friend WithEvents PanelRightBottom As Panel
  Friend WithEvents ButtonExit As Button
  Friend WithEvents ButtonCopy As Button
  Friend WithEvents ButtonExecute As Button
  Friend WithEvents ButtonClear As Button
  Friend WithEvents FontDialog1 As FontDialog
  Friend WithEvents ToolStripMenuItemEdit As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemEditCopy As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemEditCopyAll As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemEditPaste As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingShowAdjustedExpression As ToolStripMenuItem
  Friend WithEvents ToolStripMenuItemSettingSettingFont As ToolStripMenuItem
End Class
