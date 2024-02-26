<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.btnTalk = New System.Windows.Forms.Button()
        Me.txbChat = New System.Windows.Forms.TextBox()
        Me.txbUInput = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileRead = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuChangeVoice = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaleVoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FemaleVoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuChangePic = New System.Windows.Forms.ToolStripMenuItem()
        Me.RechaelDefultPicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DecardPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JOIPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAvivBot = New System.Windows.Forms.ToolStripMenuItem()
        Me.CostomPictureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCustomMusicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbout = New System.Windows.Forms.Button()
        Me.pbxRachel = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.tmrBordom = New System.Windows.Forms.Timer(Me.components)
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.OpenChatBotRechaelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.hr_lbl = New System.Windows.Forms.Label()
        Me.mn_lbl = New System.Windows.Forms.Label()
        Me.sc_lbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tmrCoffee = New System.Windows.Forms.Timer(Me.components)
        Me.btnPrivateExit = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.tmrCigaretteTime = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pbxRachel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnTalk
        '
        Me.btnTalk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnTalk.Location = New System.Drawing.Point(639, 795)
        Me.btnTalk.Name = "btnTalk"
        Me.btnTalk.Size = New System.Drawing.Size(75, 23)
        Me.btnTalk.TabIndex = 1
        Me.btnTalk.Text = "TALK"
        Me.btnTalk.UseVisualStyleBackColor = True
        '
        'txbChat
        '
        Me.txbChat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.txbChat.Location = New System.Drawing.Point(12, 389)
        Me.txbChat.Multiline = True
        Me.txbChat.Name = "txbChat"
        Me.txbChat.ReadOnly = True
        Me.txbChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txbChat.Size = New System.Drawing.Size(601, 334)
        Me.txbChat.TabIndex = 2
        '
        'txbUInput
        '
        Me.txbUInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.txbUInput.Location = New System.Drawing.Point(12, 746)
        Me.txbUInput.Multiline = True
        Me.txbUInput.Name = "txbUInput"
        Me.txbUInput.Size = New System.Drawing.Size(601, 72)
        Me.txbUInput.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.MnuChangeVoice, Me.mnuChangePic, Me.LoadCustomMusicToolStripMenuItem, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(766, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileSave, Me.mnuFileRead})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuFileSave
        '
        Me.mnuFileSave.Name = "mnuFileSave"
        Me.mnuFileSave.Size = New System.Drawing.Size(171, 22)
        Me.mnuFileSave.Text = "Erase conversations"
        '
        'mnuFileRead
        '
        Me.mnuFileRead.Name = "mnuFileRead"
        Me.mnuFileRead.Size = New System.Drawing.Size(171, 22)
        Me.mnuFileRead.Text = "Read Conversation"
        '
        'MnuChangeVoice
        '
        Me.MnuChangeVoice.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MaleVoiceToolStripMenuItem, Me.FemaleVoiceToolStripMenuItem})
        Me.MnuChangeVoice.Name = "MnuChangeVoice"
        Me.MnuChangeVoice.Size = New System.Drawing.Size(84, 20)
        Me.MnuChangeVoice.Text = "Change Voice"
        '
        'MaleVoiceToolStripMenuItem
        '
        Me.MaleVoiceToolStripMenuItem.Name = "MaleVoiceToolStripMenuItem"
        Me.MaleVoiceToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.MaleVoiceToolStripMenuItem.Text = "Male Voice"
        '
        'FemaleVoiceToolStripMenuItem
        '
        Me.FemaleVoiceToolStripMenuItem.Name = "FemaleVoiceToolStripMenuItem"
        Me.FemaleVoiceToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.FemaleVoiceToolStripMenuItem.Text = "Female Voice"
        '
        'mnuChangePic
        '
        Me.mnuChangePic.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechaelDefultPicToolStripMenuItem, Me.DecardPictureToolStripMenuItem, Me.JOIPictureToolStripMenuItem, Me.mnuAvivBot, Me.CostomPictureToolStripMenuItem})
        Me.mnuChangePic.Name = "mnuChangePic"
        Me.mnuChangePic.Size = New System.Drawing.Size(92, 20)
        Me.mnuChangePic.Text = "Change Picture"
        '
        'RechaelDefultPicToolStripMenuItem
        '
        Me.RechaelDefultPicToolStripMenuItem.Name = "RechaelDefultPicToolStripMenuItem"
        Me.RechaelDefultPicToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RechaelDefultPicToolStripMenuItem.Text = "Rechael Defult Picture"
        '
        'DecardPictureToolStripMenuItem
        '
        Me.DecardPictureToolStripMenuItem.Name = "DecardPictureToolStripMenuItem"
        Me.DecardPictureToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DecardPictureToolStripMenuItem.Text = "Deckard Picture"
        '
        'JOIPictureToolStripMenuItem
        '
        Me.JOIPictureToolStripMenuItem.Name = "JOIPictureToolStripMenuItem"
        Me.JOIPictureToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.JOIPictureToolStripMenuItem.Text = "JOI Picture"
        '
        'mnuAvivBot
        '
        Me.mnuAvivBot.Name = "mnuAvivBot"
        Me.mnuAvivBot.Size = New System.Drawing.Size(180, 22)
        Me.mnuAvivBot.Text = "Aviv Picture"
        '
        'CostomPictureToolStripMenuItem
        '
        Me.CostomPictureToolStripMenuItem.Name = "CostomPictureToolStripMenuItem"
        Me.CostomPictureToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CostomPictureToolStripMenuItem.Text = "Custom Picture"
        '
        'LoadCustomMusicToolStripMenuItem
        '
        Me.LoadCustomMusicToolStripMenuItem.Name = "LoadCustomMusicToolStripMenuItem"
        Me.LoadCustomMusicToolStripMenuItem.Size = New System.Drawing.Size(110, 20)
        Me.LoadCustomMusicToolStripMenuItem.Text = "Load Custom Music"
        '
        'mnuHelp
        '
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(40, 20)
        Me.mnuHelp.Text = "Help"
        '
        'btnAbout
        '
        Me.btnAbout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnAbout.Location = New System.Drawing.Point(639, 722)
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(75, 23)
        Me.btnAbout.TabIndex = 5
        Me.btnAbout.Text = "ABOUT"
        Me.btnAbout.UseVisualStyleBackColor = True
        '
        'pbxRachel
        '
        Me.pbxRachel.BackgroundImage = Global.ChatBotRechealDemo.My.Resources.Resources.rechal1
        Me.pbxRachel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pbxRachel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbxRachel.Location = New System.Drawing.Point(178, 27)
        Me.pbxRachel.Name = "pbxRachel"
        Me.pbxRachel.Size = New System.Drawing.Size(228, 345)
        Me.pbxRachel.TabIndex = 0
        Me.pbxRachel.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnExit.Location = New System.Drawing.Point(639, 647)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(444, 27)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(250, 250)
        Me.WebBrowser1.TabIndex = 8
        Me.WebBrowser1.Visible = False
        '
        'tmrBordom
        '
        Me.tmrBordom.Enabled = True
        Me.tmrBordom.Interval = 1000
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "chat bot Rechael A.I."
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenChatBotRechaelToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(194, 48)
        '
        'OpenChatBotRechaelToolStripMenuItem
        '
        Me.OpenChatBotRechaelToolStripMenuItem.Name = "OpenChatBotRechaelToolStripMenuItem"
        Me.OpenChatBotRechaelToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.OpenChatBotRechaelToolStripMenuItem.Text = "Open ChatBot Rechael"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'hr_lbl
        '
        Me.hr_lbl.AutoSize = True
        Me.hr_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.hr_lbl.Location = New System.Drawing.Point(9, 73)
        Me.hr_lbl.Name = "hr_lbl"
        Me.hr_lbl.Size = New System.Drawing.Size(16, 16)
        Me.hr_lbl.TabIndex = 9
        Me.hr_lbl.Text = "0"
        '
        'mn_lbl
        '
        Me.mn_lbl.AutoSize = True
        Me.mn_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.mn_lbl.Location = New System.Drawing.Point(78, 73)
        Me.mn_lbl.Name = "mn_lbl"
        Me.mn_lbl.Size = New System.Drawing.Size(16, 16)
        Me.mn_lbl.TabIndex = 10
        Me.mn_lbl.Text = "0"
        '
        'sc_lbl
        '
        Me.sc_lbl.AutoSize = True
        Me.sc_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.sc_lbl.Location = New System.Drawing.Point(144, 73)
        Me.sc_lbl.Name = "sc_lbl"
        Me.sc_lbl.Size = New System.Drawing.Size(16, 16)
        Me.sc_lbl.TabIndex = 11
        Me.sc_lbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label1.Location = New System.Drawing.Point(47, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(12, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(62, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "time left"
        '
        'tmrCoffee
        '
        Me.tmrCoffee.Interval = 1000
        '
        'btnPrivateExit
        '
        Me.btnPrivateExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(177, Byte))
        Me.btnPrivateExit.Location = New System.Drawing.Point(12, 349)
        Me.btnPrivateExit.Name = "btnPrivateExit"
        Me.btnPrivateExit.Size = New System.Drawing.Size(160, 23)
        Me.btnPrivateExit.TabIndex = 15
        Me.btnPrivateExit.Text = "Private Exit"
        Me.btnPrivateExit.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'tmrCigaretteTime
        '
        Me.tmrCigaretteTime.Interval = 1000
        '
        'frmMain
        '
        Me.AcceptButton = Me.btnTalk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(766, 837)
        Me.Controls.Add(Me.btnPrivateExit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.sc_lbl)
        Me.Controls.Add(Me.mn_lbl)
        Me.Controls.Add(Me.hr_lbl)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAbout)
        Me.Controls.Add(Me.txbUInput)
        Me.Controls.Add(Me.txbChat)
        Me.Controls.Add(Me.btnTalk)
        Me.Controls.Add(Me.pbxRachel)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(772, 869)
        Me.MinimumSize = New System.Drawing.Size(772, 869)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChatBot RECHAEL"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pbxRachel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxRachel As PictureBox
    Friend WithEvents btnTalk As Button
    Friend WithEvents txbChat As TextBox
    Friend WithEvents txbUInput As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MnuChangeVoice As ToolStripMenuItem
    Friend WithEvents btnAbout As Button
    'Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents mnuChangePic As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileSave As ToolStripMenuItem
    Friend WithEvents mnuFileRead As ToolStripMenuItem
    Friend WithEvents btnExit As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents tmrBordom As Timer
    Private WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents OpenChatBotRechaelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents hr_lbl As Label
    Friend WithEvents mn_lbl As Label
    Friend WithEvents sc_lbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tmrCoffee As Timer
    Friend WithEvents btnPrivateExit As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents RechaelDefultPicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DecardPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CostomPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadCustomMusicToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents JOIPictureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaleVoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FemaleVoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAvivBot As ToolStripMenuItem
    Friend WithEvents tmrCigaretteTime As Timer
End Class
