<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTimeHelper
	Inherits System.Windows.Forms.Form

	'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

	'Wird vom Windows Form-Designer benötigt.
	Private components As System.ComponentModel.IContainer

	'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
	'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
	'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTimeHelper))
		Me.lblHeader = New System.Windows.Forms.Label()
		Me.gbStep1 = New System.Windows.Forms.GroupBox()
		Me.rbtnNothing = New System.Windows.Forms.RadioButton()
		Me.rbtnCopyFiles = New System.Windows.Forms.RadioButton()
		Me.rbtnAFK = New System.Windows.Forms.RadioButton()
		Me.rbtnDownloadGame = New System.Windows.Forms.RadioButton()
		Me.lblDescStep1 = New System.Windows.Forms.Label()
		Me.btnContinue = New System.Windows.Forms.Button()
		Me.btnBack = New System.Windows.Forms.Button()
		Me.gbStep2Download = New System.Windows.Forms.GroupBox()
		Me.tbSizeOfDownload = New System.Windows.Forms.TextBox()
		Me.lblDontKnowSpeed = New System.Windows.Forms.Label()
		Me.cbxYourInternetSpeed = New System.Windows.Forms.ComboBox()
		Me.cbxSizeOfDownload = New System.Windows.Forms.ComboBox()
		Me.tbYourInternetSpeed = New System.Windows.Forms.TextBox()
		Me.lblYourInternetSpeed = New System.Windows.Forms.Label()
		Me.lblSizeOfDownload = New System.Windows.Forms.Label()
		Me.lblDescStep2Download = New System.Windows.Forms.Label()
		Me.gbStep2AFK = New System.Windows.Forms.GroupBox()
		Me.tbItemsNeeded = New System.Windows.Forms.TextBox()
		Me.lblItemsNeeded = New System.Windows.Forms.Label()
		Me.tbItemsPerMinute = New System.Windows.Forms.TextBox()
		Me.lblItemsPerMinute = New System.Windows.Forms.Label()
		Me.lblDescStep2AFK = New System.Windows.Forms.Label()
		Me.gbStep2Drive = New System.Windows.Forms.GroupBox()
		Me.cbxDriveSpeed = New System.Windows.Forms.ComboBox()
		Me.cbxTotalSize = New System.Windows.Forms.ComboBox()
		Me.tbDriveSpeed = New System.Windows.Forms.TextBox()
		Me.tbTotalSize = New System.Windows.Forms.TextBox()
		Me.lblDriveSpeed = New System.Windows.Forms.Label()
		Me.lblTotalSize = New System.Windows.Forms.Label()
		Me.lblHowToFindDriveSpeed = New System.Windows.Forms.Label()
		Me.lblDescStep2Drive = New System.Windows.Forms.Label()
		Me.gbStep2Nothing = New System.Windows.Forms.GroupBox()
		Me.lblDescStep2Nothing = New System.Windows.Forms.Label()
		Me.gbStep3 = New System.Windows.Forms.GroupBox()
		Me.cbUseTime = New System.Windows.Forms.CheckBox()
		Me.lblDeterminedTime = New System.Windows.Forms.Label()
		Me.lblDescStep3 = New System.Windows.Forms.Label()
		Me.gbStep1.SuspendLayout()
		Me.gbStep2Download.SuspendLayout()
		Me.gbStep2AFK.SuspendLayout()
		Me.gbStep2Drive.SuspendLayout()
		Me.gbStep2Nothing.SuspendLayout()
		Me.gbStep3.SuspendLayout()
		Me.SuspendLayout()
		'
		'lblHeader
		'
		Me.lblHeader.AutoSize = True
		Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblHeader.Location = New System.Drawing.Point(12, 10)
		Me.lblHeader.Name = "lblHeader"
		Me.lblHeader.Size = New System.Drawing.Size(265, 25)
		Me.lblHeader.TabIndex = 0
		Me.lblHeader.Text = "What time should I use?"
		'
		'gbStep1
		'
		Me.gbStep1.Controls.Add(Me.rbtnNothing)
		Me.gbStep1.Controls.Add(Me.rbtnCopyFiles)
		Me.gbStep1.Controls.Add(Me.rbtnAFK)
		Me.gbStep1.Controls.Add(Me.rbtnDownloadGame)
		Me.gbStep1.Controls.Add(Me.lblDescStep1)
		Me.gbStep1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep1.Location = New System.Drawing.Point(17, 48)
		Me.gbStep1.Name = "gbStep1"
		Me.gbStep1.Size = New System.Drawing.Size(520, 247)
		Me.gbStep1.TabIndex = 1
		Me.gbStep1.TabStop = False
		Me.gbStep1.Text = "Step 1"
		'
		'rbtnNothing
		'
		Me.rbtnNothing.AutoSize = True
		Me.rbtnNothing.Location = New System.Drawing.Point(21, 196)
		Me.rbtnNothing.Name = "rbtnNothing"
		Me.rbtnNothing.Size = New System.Drawing.Size(266, 20)
		Me.rbtnNothing.TabIndex = 4
		Me.rbtnNothing.TabStop = True
		Me.rbtnNothing.Text = "Nothing on this list fits my current situation"
		Me.rbtnNothing.UseVisualStyleBackColor = True
		'
		'rbtnCopyFiles
		'
		Me.rbtnCopyFiles.AutoSize = True
		Me.rbtnCopyFiles.Location = New System.Drawing.Point(21, 169)
		Me.rbtnCopyFiles.Name = "rbtnCopyFiles"
		Me.rbtnCopyFiles.Size = New System.Drawing.Size(157, 20)
		Me.rbtnCopyFiles.TabIndex = 3
		Me.rbtnCopyFiles.TabStop = True
		Me.rbtnCopyFiles.Text = "I'm copying some files"
		Me.rbtnCopyFiles.UseVisualStyleBackColor = True
		'
		'rbtnAFK
		'
		Me.rbtnAFK.AutoSize = True
		Me.rbtnAFK.Location = New System.Drawing.Point(21, 142)
		Me.rbtnAFK.Name = "rbtnAFK"
		Me.rbtnAFK.Size = New System.Drawing.Size(176, 20)
		Me.rbtnAFK.TabIndex = 2
		Me.rbtnAFK.TabStop = True
		Me.rbtnAFK.Text = "I'm AFKing in some game"
		Me.rbtnAFK.UseVisualStyleBackColor = True
		'
		'rbtnDownloadGame
		'
		Me.rbtnDownloadGame.AutoSize = True
		Me.rbtnDownloadGame.Checked = True
		Me.rbtnDownloadGame.Location = New System.Drawing.Point(21, 116)
		Me.rbtnDownloadGame.Name = "rbtnDownloadGame"
		Me.rbtnDownloadGame.Size = New System.Drawing.Size(235, 20)
		Me.rbtnDownloadGame.TabIndex = 1
		Me.rbtnDownloadGame.TabStop = True
		Me.rbtnDownloadGame.Text = "I'm downloading a game/an update"
		Me.rbtnDownloadGame.UseVisualStyleBackColor = True
		'
		'lblDescStep1
		'
		Me.lblDescStep1.AutoSize = True
		Me.lblDescStep1.Location = New System.Drawing.Point(18, 28)
		Me.lblDescStep1.Name = "lblDescStep1"
		Me.lblDescStep1.Size = New System.Drawing.Size(444, 64)
		Me.lblDescStep1.TabIndex = 0
		Me.lblDescStep1.Text = "Welcome to the Time Helper Wizard. This Wizard is designed to help you " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "select t" &
	"he right time when you want to shut down your PC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Let's begin by choosing wha" &
	"t fits your current situation the most."
		'
		'btnContinue
		'
		Me.btnContinue.BackColor = System.Drawing.Color.Transparent
		Me.btnContinue.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
		Me.btnContinue.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnContinue.FlatAppearance.BorderSize = 0
		Me.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnContinue.ForeColor = System.Drawing.Color.White
		Me.btnContinue.Location = New System.Drawing.Point(421, 301)
		Me.btnContinue.Name = "btnContinue"
		Me.btnContinue.Size = New System.Drawing.Size(116, 25)
		Me.btnContinue.TabIndex = 5
		Me.btnContinue.Text = "Continue"
		Me.btnContinue.UseVisualStyleBackColor = False
		'
		'btnBack
		'
		Me.btnBack.BackColor = System.Drawing.Color.Transparent
		Me.btnBack.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
		Me.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnBack.FlatAppearance.BorderSize = 0
		Me.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
		Me.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
		Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnBack.ForeColor = System.Drawing.Color.White
		Me.btnBack.Location = New System.Drawing.Point(299, 301)
		Me.btnBack.Name = "btnBack"
		Me.btnBack.Size = New System.Drawing.Size(116, 25)
		Me.btnBack.TabIndex = 6
		Me.btnBack.Text = "Back"
		Me.btnBack.UseVisualStyleBackColor = False
		'
		'gbStep2Download
		'
		Me.gbStep2Download.Controls.Add(Me.tbSizeOfDownload)
		Me.gbStep2Download.Controls.Add(Me.lblDontKnowSpeed)
		Me.gbStep2Download.Controls.Add(Me.cbxYourInternetSpeed)
		Me.gbStep2Download.Controls.Add(Me.cbxSizeOfDownload)
		Me.gbStep2Download.Controls.Add(Me.tbYourInternetSpeed)
		Me.gbStep2Download.Controls.Add(Me.lblYourInternetSpeed)
		Me.gbStep2Download.Controls.Add(Me.lblSizeOfDownload)
		Me.gbStep2Download.Controls.Add(Me.lblDescStep2Download)
		Me.gbStep2Download.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep2Download.Location = New System.Drawing.Point(567, 48)
		Me.gbStep2Download.Name = "gbStep2Download"
		Me.gbStep2Download.Size = New System.Drawing.Size(520, 247)
		Me.gbStep2Download.TabIndex = 7
		Me.gbStep2Download.TabStop = False
		Me.gbStep2Download.Text = "Step 2"
		'
		'tbSizeOfDownload
		'
		Me.tbSizeOfDownload.Location = New System.Drawing.Point(165, 111)
		Me.tbSizeOfDownload.Name = "tbSizeOfDownload"
		Me.tbSizeOfDownload.Size = New System.Drawing.Size(112, 22)
		Me.tbSizeOfDownload.TabIndex = 16
		'
		'lblDontKnowSpeed
		'
		Me.lblDontKnowSpeed.AutoSize = True
		Me.lblDontKnowSpeed.Location = New System.Drawing.Point(18, 178)
		Me.lblDontKnowSpeed.Name = "lblDontKnowSpeed"
		Me.lblDontKnowSpeed.Size = New System.Drawing.Size(451, 32)
		Me.lblDontKnowSpeed.TabIndex = 15
		Me.lblDontKnowSpeed.Text = "Don't know your internet speed? Search online and you'll find plenty" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of speed te" &
	"sts! Make sure to use bytes per second and not bits per second."
		'
		'cbxYourInternetSpeed
		'
		Me.cbxYourInternetSpeed.BackColor = System.Drawing.Color.Gainsboro
		Me.cbxYourInternetSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxYourInternetSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbxYourInternetSpeed.FormattingEnabled = True
		Me.cbxYourInternetSpeed.Items.AddRange(New Object() {"KB/s", "MB/s", "GB/s", "TB/s"})
		Me.cbxYourInternetSpeed.Location = New System.Drawing.Point(283, 140)
		Me.cbxYourInternetSpeed.Name = "cbxYourInternetSpeed"
		Me.cbxYourInternetSpeed.Size = New System.Drawing.Size(66, 24)
		Me.cbxYourInternetSpeed.TabIndex = 11
		'
		'cbxSizeOfDownload
		'
		Me.cbxSizeOfDownload.BackColor = System.Drawing.Color.Gainsboro
		Me.cbxSizeOfDownload.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxSizeOfDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbxSizeOfDownload.FormattingEnabled = True
		Me.cbxSizeOfDownload.Items.AddRange(New Object() {"KB", "MB", "GB", "TB", "PB"})
		Me.cbxSizeOfDownload.Location = New System.Drawing.Point(283, 109)
		Me.cbxSizeOfDownload.Name = "cbxSizeOfDownload"
		Me.cbxSizeOfDownload.Size = New System.Drawing.Size(66, 24)
		Me.cbxSizeOfDownload.TabIndex = 10
		'
		'tbYourInternetSpeed
		'
		Me.tbYourInternetSpeed.Location = New System.Drawing.Point(165, 140)
		Me.tbYourInternetSpeed.Name = "tbYourInternetSpeed"
		Me.tbYourInternetSpeed.Size = New System.Drawing.Size(112, 22)
		Me.tbYourInternetSpeed.TabIndex = 14
		'
		'lblYourInternetSpeed
		'
		Me.lblYourInternetSpeed.AutoSize = True
		Me.lblYourInternetSpeed.Location = New System.Drawing.Point(18, 139)
		Me.lblYourInternetSpeed.Name = "lblYourInternetSpeed"
		Me.lblYourInternetSpeed.Size = New System.Drawing.Size(126, 16)
		Me.lblYourInternetSpeed.TabIndex = 12
		Me.lblYourInternetSpeed.Text = "Your internet speed:"
		'
		'lblSizeOfDownload
		'
		Me.lblSizeOfDownload.AutoSize = True
		Me.lblSizeOfDownload.Location = New System.Drawing.Point(18, 114)
		Me.lblSizeOfDownload.Name = "lblSizeOfDownload"
		Me.lblSizeOfDownload.Size = New System.Drawing.Size(112, 16)
		Me.lblSizeOfDownload.TabIndex = 11
		Me.lblSizeOfDownload.Text = "Size of download:"
		'
		'lblDescStep2Download
		'
		Me.lblDescStep2Download.AutoSize = True
		Me.lblDescStep2Download.Location = New System.Drawing.Point(18, 30)
		Me.lblDescStep2Download.Name = "lblDescStep2Download"
		Me.lblDescStep2Download.Size = New System.Drawing.Size(414, 64)
		Me.lblDescStep2Download.TabIndex = 10
		Me.lblDescStep2Download.Text = resources.GetString("lblDescStep2Download.Text")
		'
		'gbStep2AFK
		'
		Me.gbStep2AFK.Controls.Add(Me.tbItemsNeeded)
		Me.gbStep2AFK.Controls.Add(Me.lblItemsNeeded)
		Me.gbStep2AFK.Controls.Add(Me.tbItemsPerMinute)
		Me.gbStep2AFK.Controls.Add(Me.lblItemsPerMinute)
		Me.gbStep2AFK.Controls.Add(Me.lblDescStep2AFK)
		Me.gbStep2AFK.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep2AFK.Location = New System.Drawing.Point(17, 341)
		Me.gbStep2AFK.Name = "gbStep2AFK"
		Me.gbStep2AFK.Size = New System.Drawing.Size(520, 247)
		Me.gbStep2AFK.TabIndex = 8
		Me.gbStep2AFK.TabStop = False
		Me.gbStep2AFK.Text = "Step 2"
		'
		'tbItemsNeeded
		'
		Me.tbItemsNeeded.Location = New System.Drawing.Point(134, 169)
		Me.tbItemsNeeded.Name = "tbItemsNeeded"
		Me.tbItemsNeeded.Size = New System.Drawing.Size(100, 22)
		Me.tbItemsNeeded.TabIndex = 4
		'
		'lblItemsNeeded
		'
		Me.lblItemsNeeded.AutoSize = True
		Me.lblItemsNeeded.Location = New System.Drawing.Point(21, 169)
		Me.lblItemsNeeded.Name = "lblItemsNeeded"
		Me.lblItemsNeeded.Size = New System.Drawing.Size(92, 16)
		Me.lblItemsNeeded.TabIndex = 3
		Me.lblItemsNeeded.Text = "Items needed:"
		'
		'tbItemsPerMinute
		'
		Me.tbItemsPerMinute.Location = New System.Drawing.Point(134, 139)
		Me.tbItemsPerMinute.Name = "tbItemsPerMinute"
		Me.tbItemsPerMinute.Size = New System.Drawing.Size(100, 22)
		Me.tbItemsPerMinute.TabIndex = 2
		'
		'lblItemsPerMinute
		'
		Me.lblItemsPerMinute.AutoSize = True
		Me.lblItemsPerMinute.Location = New System.Drawing.Point(21, 142)
		Me.lblItemsPerMinute.Name = "lblItemsPerMinute"
		Me.lblItemsPerMinute.Size = New System.Drawing.Size(107, 16)
		Me.lblItemsPerMinute.TabIndex = 1
		Me.lblItemsPerMinute.Text = "Items per minute:"
		'
		'lblDescStep2AFK
		'
		Me.lblDescStep2AFK.AutoSize = True
		Me.lblDescStep2AFK.Location = New System.Drawing.Point(18, 28)
		Me.lblDescStep2AFK.Name = "lblDescStep2AFK"
		Me.lblDescStep2AFK.Size = New System.Drawing.Size(487, 96)
		Me.lblDescStep2AFK.TabIndex = 0
		Me.lblDescStep2AFK.Text = resources.GetString("lblDescStep2AFK.Text")
		'
		'gbStep2Drive
		'
		Me.gbStep2Drive.Controls.Add(Me.cbxDriveSpeed)
		Me.gbStep2Drive.Controls.Add(Me.cbxTotalSize)
		Me.gbStep2Drive.Controls.Add(Me.tbDriveSpeed)
		Me.gbStep2Drive.Controls.Add(Me.tbTotalSize)
		Me.gbStep2Drive.Controls.Add(Me.lblDriveSpeed)
		Me.gbStep2Drive.Controls.Add(Me.lblTotalSize)
		Me.gbStep2Drive.Controls.Add(Me.lblHowToFindDriveSpeed)
		Me.gbStep2Drive.Controls.Add(Me.lblDescStep2Drive)
		Me.gbStep2Drive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep2Drive.Location = New System.Drawing.Point(567, 341)
		Me.gbStep2Drive.Name = "gbStep2Drive"
		Me.gbStep2Drive.Size = New System.Drawing.Size(520, 247)
		Me.gbStep2Drive.TabIndex = 9
		Me.gbStep2Drive.TabStop = False
		Me.gbStep2Drive.Text = "Step 2"
		'
		'cbxDriveSpeed
		'
		Me.cbxDriveSpeed.BackColor = System.Drawing.Color.Gainsboro
		Me.cbxDriveSpeed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxDriveSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbxDriveSpeed.FormattingEnabled = True
		Me.cbxDriveSpeed.Items.AddRange(New Object() {"KB/s", "MB/s", "GB/s", "TB/s"})
		Me.cbxDriveSpeed.Location = New System.Drawing.Point(239, 127)
		Me.cbxDriveSpeed.Name = "cbxDriveSpeed"
		Me.cbxDriveSpeed.Size = New System.Drawing.Size(69, 24)
		Me.cbxDriveSpeed.TabIndex = 7
		'
		'cbxTotalSize
		'
		Me.cbxTotalSize.BackColor = System.Drawing.Color.Gainsboro
		Me.cbxTotalSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cbxTotalSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
		Me.cbxTotalSize.FormattingEnabled = True
		Me.cbxTotalSize.Items.AddRange(New Object() {"KB", "MB", "GB", "TB", "PB"})
		Me.cbxTotalSize.Location = New System.Drawing.Point(239, 98)
		Me.cbxTotalSize.Name = "cbxTotalSize"
		Me.cbxTotalSize.Size = New System.Drawing.Size(69, 24)
		Me.cbxTotalSize.TabIndex = 6
		'
		'tbDriveSpeed
		'
		Me.tbDriveSpeed.Location = New System.Drawing.Point(132, 127)
		Me.tbDriveSpeed.Name = "tbDriveSpeed"
		Me.tbDriveSpeed.Size = New System.Drawing.Size(100, 22)
		Me.tbDriveSpeed.TabIndex = 5
		'
		'tbTotalSize
		'
		Me.tbTotalSize.Location = New System.Drawing.Point(132, 98)
		Me.tbTotalSize.Name = "tbTotalSize"
		Me.tbTotalSize.Size = New System.Drawing.Size(100, 22)
		Me.tbTotalSize.TabIndex = 4
		'
		'lblDriveSpeed
		'
		Me.lblDriveSpeed.AutoSize = True
		Me.lblDriveSpeed.Location = New System.Drawing.Point(24, 130)
		Me.lblDriveSpeed.Name = "lblDriveSpeed"
		Me.lblDriveSpeed.Size = New System.Drawing.Size(84, 16)
		Me.lblDriveSpeed.TabIndex = 3
		Me.lblDriveSpeed.Text = "Drive speed:"
		'
		'lblTotalSize
		'
		Me.lblTotalSize.AutoSize = True
		Me.lblTotalSize.Location = New System.Drawing.Point(24, 104)
		Me.lblTotalSize.Name = "lblTotalSize"
		Me.lblTotalSize.Size = New System.Drawing.Size(68, 16)
		Me.lblTotalSize.TabIndex = 2
		Me.lblTotalSize.Text = "Total size:"
		'
		'lblHowToFindDriveSpeed
		'
		Me.lblHowToFindDriveSpeed.AutoSize = True
		Me.lblHowToFindDriveSpeed.Location = New System.Drawing.Point(21, 172)
		Me.lblHowToFindDriveSpeed.Name = "lblHowToFindDriveSpeed"
		Me.lblHowToFindDriveSpeed.Size = New System.Drawing.Size(463, 48)
		Me.lblHowToFindDriveSpeed.TabIndex = 1
		Me.lblHowToFindDriveSpeed.Text = "You can find the total size and transfer speed of your drive in the file copying " &
	"" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "dialog. Sometimes it also already shows an accurate time remaining, you can" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "j" &
	"ust use that."
		'
		'lblDescStep2Drive
		'
		Me.lblDescStep2Drive.AutoSize = True
		Me.lblDescStep2Drive.Location = New System.Drawing.Point(21, 28)
		Me.lblDescStep2Drive.Name = "lblDescStep2Drive"
		Me.lblDescStep2Drive.Size = New System.Drawing.Size(450, 48)
		Me.lblDescStep2Drive.TabIndex = 0
		Me.lblDescStep2Drive.Text = "You chose that you are copying files or something similar. To determine the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "righ" &
	"t time to turn off your computer, you'll need to specify the total size" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the " &
	"files and the speed of your drive."
		'
		'gbStep2Nothing
		'
		Me.gbStep2Nothing.Controls.Add(Me.lblDescStep2Nothing)
		Me.gbStep2Nothing.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep2Nothing.Location = New System.Drawing.Point(17, 606)
		Me.gbStep2Nothing.Name = "gbStep2Nothing"
		Me.gbStep2Nothing.Size = New System.Drawing.Size(520, 247)
		Me.gbStep2Nothing.TabIndex = 10
		Me.gbStep2Nothing.TabStop = False
		Me.gbStep2Nothing.Text = "Step 2"
		'
		'lblDescStep2Nothing
		'
		Me.lblDescStep2Nothing.AutoSize = True
		Me.lblDescStep2Nothing.Location = New System.Drawing.Point(18, 28)
		Me.lblDescStep2Nothing.Name = "lblDescStep2Nothing"
		Me.lblDescStep2Nothing.Size = New System.Drawing.Size(486, 48)
		Me.lblDescStep2Nothing.TabIndex = 0
		Me.lblDescStep2Nothing.Text = "Unfortunately, if nothing on this list fits your current situation, it's not poss" &
	"ible for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "the software to determine the right time. In that case, you'll just ha" &
	"ve to take a lucky" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "guess."
		'
		'gbStep3
		'
		Me.gbStep3.Controls.Add(Me.cbUseTime)
		Me.gbStep3.Controls.Add(Me.lblDeterminedTime)
		Me.gbStep3.Controls.Add(Me.lblDescStep3)
		Me.gbStep3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.gbStep3.Location = New System.Drawing.Point(567, 606)
		Me.gbStep3.Name = "gbStep3"
		Me.gbStep3.Size = New System.Drawing.Size(520, 247)
		Me.gbStep3.TabIndex = 11
		Me.gbStep3.TabStop = False
		Me.gbStep3.Text = "Step 3"
		'
		'cbUseTime
		'
		Me.cbUseTime.AutoSize = True
		Me.cbUseTime.Location = New System.Drawing.Point(24, 196)
		Me.cbUseTime.Name = "cbUseTime"
		Me.cbUseTime.Size = New System.Drawing.Size(236, 20)
		Me.cbUseTime.TabIndex = 2
		Me.cbUseTime.Text = "Use calculated time in main window"
		Me.cbUseTime.UseVisualStyleBackColor = True
		'
		'lblDeterminedTime
		'
		Me.lblDeterminedTime.AutoSize = True
		Me.lblDeterminedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblDeterminedTime.Location = New System.Drawing.Point(18, 162)
		Me.lblDeterminedTime.Name = "lblDeterminedTime"
		Me.lblDeterminedTime.Size = New System.Drawing.Size(336, 20)
		Me.lblDeterminedTime.TabIndex = 1
		Me.lblDeterminedTime.Text = "The following time was determined: None"
		'
		'lblDescStep3
		'
		Me.lblDescStep3.AutoSize = True
		Me.lblDescStep3.Location = New System.Drawing.Point(21, 28)
		Me.lblDescStep3.Name = "lblDescStep3"
		Me.lblDescStep3.Size = New System.Drawing.Size(473, 112)
		Me.lblDescStep3.TabIndex = 0
		Me.lblDescStep3.Text = resources.GetString("lblDescStep3.Text")
		'
		'frmTimeHelper
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(553, 334)
		Me.Controls.Add(Me.gbStep3)
		Me.Controls.Add(Me.gbStep2Nothing)
		Me.Controls.Add(Me.gbStep2Drive)
		Me.Controls.Add(Me.gbStep2AFK)
		Me.Controls.Add(Me.gbStep2Download)
		Me.Controls.Add(Me.btnBack)
		Me.Controls.Add(Me.btnContinue)
		Me.Controls.Add(Me.gbStep1)
		Me.Controls.Add(Me.lblHeader)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "frmTimeHelper"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Time Helper"
		Me.gbStep1.ResumeLayout(False)
		Me.gbStep1.PerformLayout()
		Me.gbStep2Download.ResumeLayout(False)
		Me.gbStep2Download.PerformLayout()
		Me.gbStep2AFK.ResumeLayout(False)
		Me.gbStep2AFK.PerformLayout()
		Me.gbStep2Drive.ResumeLayout(False)
		Me.gbStep2Drive.PerformLayout()
		Me.gbStep2Nothing.ResumeLayout(False)
		Me.gbStep2Nothing.PerformLayout()
		Me.gbStep3.ResumeLayout(False)
		Me.gbStep3.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents lblHeader As Label
	Friend WithEvents gbStep1 As GroupBox
	Friend WithEvents lblDescStep1 As Label
	Friend WithEvents rbtnCopyFiles As RadioButton
	Friend WithEvents rbtnAFK As RadioButton
	Friend WithEvents rbtnDownloadGame As RadioButton
	Friend WithEvents rbtnNothing As RadioButton
	Friend WithEvents btnContinue As Button
	Friend WithEvents btnBack As Button
	Friend WithEvents gbStep2Download As GroupBox
	Friend WithEvents lblDescStep2Download As Label
	Friend WithEvents gbStep2AFK As GroupBox
	Friend WithEvents gbStep2Drive As GroupBox
	Friend WithEvents lblYourInternetSpeed As Label
	Friend WithEvents lblSizeOfDownload As Label
	Friend WithEvents tbYourInternetSpeed As TextBox
	Friend WithEvents cbxYourInternetSpeed As ComboBox
	Friend WithEvents cbxSizeOfDownload As ComboBox
	Friend WithEvents lblDontKnowSpeed As Label
	Friend WithEvents lblDescStep2AFK As Label
	Friend WithEvents tbItemsNeeded As TextBox
	Friend WithEvents lblItemsNeeded As Label
	Friend WithEvents tbItemsPerMinute As TextBox
	Friend WithEvents lblItemsPerMinute As Label
	Friend WithEvents cbxDriveSpeed As ComboBox
	Friend WithEvents cbxTotalSize As ComboBox
	Friend WithEvents tbDriveSpeed As TextBox
	Friend WithEvents tbTotalSize As TextBox
	Friend WithEvents lblDriveSpeed As Label
	Friend WithEvents lblTotalSize As Label
	Friend WithEvents lblHowToFindDriveSpeed As Label
	Friend WithEvents lblDescStep2Drive As Label
	Friend WithEvents gbStep2Nothing As GroupBox
	Friend WithEvents lblDescStep2Nothing As Label
	Friend WithEvents gbStep3 As GroupBox
	Friend WithEvents lblDescStep3 As Label
	Friend WithEvents lblDeterminedTime As Label
	Friend WithEvents tbSizeOfDownload As TextBox
	Friend WithEvents cbUseTime As CheckBox
End Class
