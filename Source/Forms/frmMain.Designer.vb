<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.rbtnPointInTime = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.cbxIn = New System.Windows.Forms.ComboBox()
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.gbLastAction = New System.Windows.Forms.GroupBox()
        Me.btnShowActionHistory = New System.Windows.Forms.Button()
        Me.lblStartedOnContent = New System.Windows.Forms.Label()
        Me.lblStartedOn = New System.Windows.Forms.Label()
        Me.lblLastTimeContent = New System.Windows.Forms.Label()
        Me.lblLastTime = New System.Windows.Forms.Label()
        Me.lblLastActionContent = New System.Windows.Forms.Label()
        Me.lblLastAction = New System.Windows.Forms.Label()
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.pbLine = New System.Windows.Forms.PictureBox()
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.btnSelectProcesses = New System.Windows.Forms.Button()
        Me.cbDelayWhenProcessRunning = New System.Windows.Forms.CheckBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlAction = New System.Windows.Forms.Panel()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.pbIcon = New System.Windows.Forms.PictureBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pbGrayBox = New System.Windows.Forms.PictureBox()
        Me.pbLine2 = New System.Windows.Forms.PictureBox()
        Me.tmrGrayBoxAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGrayBoxAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.lblSelectedAction = New System.Windows.Forms.Label()
        Me.lblSelectedTime = New System.Windows.Forms.Label()
        Me.lblSelectedActionContent = New System.Windows.Forms.Label()
        Me.lblSelectedTimeContent = New System.Windows.Forms.Label()
        Me.lblRunningTimeContent = New System.Windows.Forms.Label()
        Me.lblRunningActionContent = New System.Windows.Forms.Label()
        Me.lblScheduledTime = New System.Windows.Forms.Label()
        Me.lblScheduledAction = New System.Windows.Forms.Label()
        Me.pnlActionRunning = New System.Windows.Forms.Panel()
        Me.lblTimeRemainingContent = New System.Windows.Forms.Label()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.tmrPnlActionRunningAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPnlActionRunningAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.cmsHamburgerButton = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinimalisticViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangelogToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmrShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartAction = New System.Windows.Forms.Button()
        Me.pbNotification = New System.Windows.Forms.PictureBox()
        Me.pnlNotification = New System.Windows.Forms.Panel()
        Me.lblNotification = New System.Windows.Forms.Label()
        Me.tmrPnlNotificationAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tmrPnlNotificationAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnLoadProfile = New System.Windows.Forms.Button()
        Me.llblTimeHelper = New System.Windows.Forms.LinkLabel()
        Me.tmrCheckRunningProcess = New System.Windows.Forms.Timer(Me.components)
        Me.llblEditRunningAction = New System.Windows.Forms.LinkLabel()
        Me.gbLastAction.SuspendLayout()
        CType(Me.pbLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTime.SuspendLayout()
        Me.pnlAction.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActionRunning.SuspendLayout()
        Me.cmsHamburgerButton.SuspendLayout()
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlNotification.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbtnRestart
        '
        Me.rbtnRestart.AutoSize = True
        Me.rbtnRestart.BackColor = System.Drawing.Color.Transparent
        Me.rbtnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rbtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRestart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnRestart.Location = New System.Drawing.Point(3, 29)
        Me.rbtnRestart.Name = "rbtnRestart"
        Me.rbtnRestart.Size = New System.Drawing.Size(80, 24)
        Me.rbtnRestart.TabIndex = 3
        Me.rbtnRestart.Text = "Restart"
        Me.rbtnRestart.UseVisualStyleBackColor = False
        '
        'rbtnShutdown
        '
        Me.rbtnShutdown.AutoSize = True
        Me.rbtnShutdown.BackColor = System.Drawing.Color.Transparent
        Me.rbtnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShutdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnShutdown.Location = New System.Drawing.Point(3, 3)
        Me.rbtnShutdown.Name = "rbtnShutdown"
        Me.rbtnShutdown.Size = New System.Drawing.Size(99, 24)
        Me.rbtnShutdown.TabIndex = 0
        Me.rbtnShutdown.Text = "Shutdown"
        Me.rbtnShutdown.UseVisualStyleBackColor = False
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(110, 31)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(195, 22)
        Me.dtpDate.TabIndex = 6
        '
        'rbtnPointInTime
        '
        Me.rbtnPointInTime.AutoSize = True
        Me.rbtnPointInTime.BackColor = System.Drawing.Color.Transparent
        Me.rbtnPointInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPointInTime.ForeColor = System.Drawing.Color.Black
        Me.rbtnPointInTime.Location = New System.Drawing.Point(3, 29)
        Me.rbtnPointInTime.Name = "rbtnPointInTime"
        Me.rbtnPointInTime.Size = New System.Drawing.Size(101, 24)
        Me.rbtnPointInTime.TabIndex = 10
        Me.rbtnPointInTime.TabStop = True
        Me.rbtnPointInTime.Text = "Exact time"
        Me.rbtnPointInTime.UseVisualStyleBackColor = False
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.BackColor = System.Drawing.Color.Transparent
        Me.rbtnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIn.ForeColor = System.Drawing.Color.Black
        Me.rbtnIn.Location = New System.Drawing.Point(3, 3)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(53, 24)
        Me.rbtnIn.TabIndex = 9
        Me.rbtnIn.TabStop = True
        Me.rbtnIn.Text = "In..."
        Me.rbtnIn.UseVisualStyleBackColor = False
        '
        'cbxIn
        '
        Me.cbxIn.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIn.FormattingEnabled = True
        Me.cbxIn.Items.AddRange(New Object() {"Second(s)", "Minute(s)", "Hour(s)"})
        Me.cbxIn.Location = New System.Drawing.Point(163, 5)
        Me.cbxIn.Name = "cbxIn"
        Me.cbxIn.Size = New System.Drawing.Size(142, 21)
        Me.cbxIn.TabIndex = 8
        '
        'tbTime
        '
        Me.tbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTime.Location = New System.Drawing.Point(62, 5)
        Me.tbTime.Name = "tbTime"
        Me.tbTime.Size = New System.Drawing.Size(95, 20)
        Me.tbTime.TabIndex = 1
        '
        'gbLastAction
        '
        Me.gbLastAction.Controls.Add(Me.btnShowActionHistory)
        Me.gbLastAction.Controls.Add(Me.lblStartedOnContent)
        Me.gbLastAction.Controls.Add(Me.lblStartedOn)
        Me.gbLastAction.Controls.Add(Me.lblLastTimeContent)
        Me.gbLastAction.Controls.Add(Me.lblLastTime)
        Me.gbLastAction.Controls.Add(Me.lblLastActionContent)
        Me.gbLastAction.Controls.Add(Me.lblLastAction)
        Me.gbLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLastAction.Location = New System.Drawing.Point(420, 75)
        Me.gbLastAction.Name = "gbLastAction"
        Me.gbLastAction.Size = New System.Drawing.Size(191, 272)
        Me.gbLastAction.TabIndex = 36
        Me.gbLastAction.TabStop = False
        Me.gbLastAction.Text = "Last action"
        '
        'btnShowActionHistory
        '
        Me.btnShowActionHistory.BackColor = System.Drawing.Color.Transparent
        Me.btnShowActionHistory.BackgroundImage = CType(resources.GetObject("btnShowActionHistory.BackgroundImage"), System.Drawing.Image)
        Me.btnShowActionHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnShowActionHistory.FlatAppearance.BorderSize = 0
        Me.btnShowActionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnShowActionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnShowActionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnShowActionHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowActionHistory.ForeColor = System.Drawing.Color.White
        Me.btnShowActionHistory.Location = New System.Drawing.Point(13, 232)
        Me.btnShowActionHistory.Name = "btnShowActionHistory"
        Me.btnShowActionHistory.Size = New System.Drawing.Size(162, 23)
        Me.btnShowActionHistory.TabIndex = 7
        Me.btnShowActionHistory.Text = "View history"
        Me.btnShowActionHistory.UseVisualStyleBackColor = False
        '
        'lblStartedOnContent
        '
        Me.lblStartedOnContent.AutoSize = True
        Me.lblStartedOnContent.Location = New System.Drawing.Point(9, 182)
        Me.lblStartedOnContent.Name = "lblStartedOnContent"
        Me.lblStartedOnContent.Size = New System.Drawing.Size(111, 20)
        Me.lblStartedOnContent.TabIndex = 6
        Me.lblStartedOnContent.Text = "%StartedOn%"
        '
        'lblStartedOn
        '
        Me.lblStartedOn.AutoSize = True
        Me.lblStartedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartedOn.Location = New System.Drawing.Point(9, 162)
        Me.lblStartedOn.Name = "lblStartedOn"
        Me.lblStartedOn.Size = New System.Drawing.Size(99, 20)
        Me.lblStartedOn.TabIndex = 5
        Me.lblStartedOn.Text = "Started on:"
        '
        'lblLastTimeContent
        '
        Me.lblLastTimeContent.AutoSize = True
        Me.lblLastTimeContent.Location = New System.Drawing.Point(9, 116)
        Me.lblLastTimeContent.Name = "lblLastTimeContent"
        Me.lblLastTimeContent.Size = New System.Drawing.Size(102, 20)
        Me.lblLastTimeContent.TabIndex = 3
        Me.lblLastTimeContent.Text = "%LastTime%"
        '
        'lblLastTime
        '
        Me.lblLastTime.AutoSize = True
        Me.lblLastTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastTime.Location = New System.Drawing.Point(9, 94)
        Me.lblLastTime.Name = "lblLastTime"
        Me.lblLastTime.Size = New System.Drawing.Size(52, 20)
        Me.lblLastTime.TabIndex = 2
        Me.lblLastTime.Text = "Time:"
        '
        'lblLastActionContent
        '
        Me.lblLastActionContent.AutoSize = True
        Me.lblLastActionContent.Location = New System.Drawing.Point(9, 53)
        Me.lblLastActionContent.Name = "lblLastActionContent"
        Me.lblLastActionContent.Size = New System.Drawing.Size(113, 20)
        Me.lblLastActionContent.TabIndex = 1
        Me.lblLastActionContent.Text = "%LastAction%"
        '
        'lblLastAction
        '
        Me.lblLastAction.AutoSize = True
        Me.lblLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAction.Location = New System.Drawing.Point(9, 33)
        Me.lblLastAction.Name = "lblLastAction"
        Me.lblLastAction.Size = New System.Drawing.Size(65, 20)
        Me.lblLastAction.TabIndex = 0
        Me.lblLastAction.Text = "Action:"
        '
        'btnHamburger
        '
        Me.btnHamburger.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.hamburger
        Me.btnHamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburger.Location = New System.Drawing.Point(560, 13)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(47, 44)
        Me.btnHamburger.TabIndex = 20
        Me.btnHamburger.UseVisualStyleBackColor = True
        '
        'pbLine
        '
        Me.pbLine.BackgroundImage = CType(resources.GetObject("pbLine.BackgroundImage"), System.Drawing.Image)
        Me.pbLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLine.Location = New System.Drawing.Point(3, 58)
        Me.pbLine.Name = "pbLine"
        Me.pbLine.Size = New System.Drawing.Size(617, 12)
        Me.pbLine.TabIndex = 35
        Me.pbLine.TabStop = False
        '
        'pnlTime
        '
        Me.pnlTime.Controls.Add(Me.btnSelectProcesses)
        Me.pnlTime.Controls.Add(Me.cbDelayWhenProcessRunning)
        Me.pnlTime.Controls.Add(Me.dtpDate)
        Me.pnlTime.Controls.Add(Me.rbtnPointInTime)
        Me.pnlTime.Controls.Add(Me.cbxIn)
        Me.pnlTime.Controls.Add(Me.rbtnIn)
        Me.pnlTime.Controls.Add(Me.tbTime)
        Me.pnlTime.Location = New System.Drawing.Point(17, 200)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(318, 111)
        Me.pnlTime.TabIndex = 34
        '
        'btnSelectProcesses
        '
        Me.btnSelectProcesses.BackgroundImage = CType(resources.GetObject("btnSelectProcesses.BackgroundImage"), System.Drawing.Image)
        Me.btnSelectProcesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectProcesses.FlatAppearance.BorderSize = 0
        Me.btnSelectProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSelectProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSelectProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectProcesses.ForeColor = System.Drawing.Color.White
        Me.btnSelectProcesses.Location = New System.Drawing.Point(230, 74)
        Me.btnSelectProcesses.Name = "btnSelectProcesses"
        Me.btnSelectProcesses.Size = New System.Drawing.Size(75, 26)
        Me.btnSelectProcesses.TabIndex = 12
        Me.btnSelectProcesses.Text = "Select"
        Me.btnSelectProcesses.UseVisualStyleBackColor = True
        '
        'cbDelayWhenProcessRunning
        '
        Me.cbDelayWhenProcessRunning.AutoSize = True
        Me.cbDelayWhenProcessRunning.BackColor = System.Drawing.Color.Transparent
        Me.cbDelayWhenProcessRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDelayWhenProcessRunning.Location = New System.Drawing.Point(3, 63)
        Me.cbDelayWhenProcessRunning.Name = "cbDelayWhenProcessRunning"
        Me.cbDelayWhenProcessRunning.Size = New System.Drawing.Size(221, 44)
        Me.cbDelayWhenProcessRunning.TabIndex = 11
        Me.cbDelayWhenProcessRunning.Text = "Delay action when selected" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "processes are running"
        Me.cbDelayWhenProcessRunning.UseVisualStyleBackColor = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(12, 172)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(329, 25)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "Time                                             "
        '
        'pnlAction
        '
        Me.pnlAction.Controls.Add(Me.rbtnRestart)
        Me.pnlAction.Controls.Add(Me.rbtnShutdown)
        Me.pnlAction.Location = New System.Drawing.Point(17, 100)
        Me.pnlAction.Name = "pnlAction"
        Me.pnlAction.Size = New System.Drawing.Size(141, 58)
        Me.pnlAction.TabIndex = 32
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(12, 72)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(330, 25)
        Me.lblAction.TabIndex = 31
        Me.lblAction.Text = "Action                                           "
        '
        'pbIcon
        '
        Me.pbIcon.BackgroundImage = CType(resources.GetObject("pbIcon.BackgroundImage"), System.Drawing.Image)
        Me.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIcon.Location = New System.Drawing.Point(20, 3)
        Me.pbIcon.Name = "pbIcon"
        Me.pbIcon.Size = New System.Drawing.Size(64, 59)
        Me.pbIcon.TabIndex = 30
        Me.pbIcon.TabStop = False
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblVersion.Location = New System.Drawing.Point(445, 23)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(90, 31)
        Me.lblVersion.TabIndex = 22
        Me.lblVersion.Text = "1.10.0"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(90, 18)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(349, 39)
        Me.lblHeader.TabIndex = 21
        Me.lblHeader.Text = "Seeloewen Shutdown"
        '
        'pbGrayBox
        '
        Me.pbGrayBox.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.graybox
        Me.pbGrayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGrayBox.Location = New System.Drawing.Point(9, 353)
        Me.pbGrayBox.Name = "pbGrayBox"
        Me.pbGrayBox.Size = New System.Drawing.Size(620, 133)
        Me.pbGrayBox.TabIndex = 23
        Me.pbGrayBox.TabStop = False
        Me.pbGrayBox.Visible = False
        '
        'pbLine2
        '
        Me.pbLine2.BackgroundImage = CType(resources.GetObject("pbLine2.BackgroundImage"), System.Drawing.Image)
        Me.pbLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLine2.Location = New System.Drawing.Point(7, 353)
        Me.pbLine2.Name = "pbLine2"
        Me.pbLine2.Size = New System.Drawing.Size(617, 10)
        Me.pbLine2.TabIndex = 27
        Me.pbLine2.TabStop = False
        '
        'tmrGrayBoxAnimationUp
        '
        Me.tmrGrayBoxAnimationUp.Interval = 1
        '
        'tmrGrayBoxAnimationDown
        '
        Me.tmrGrayBoxAnimationDown.Interval = 1
        '
        'lblSelectedAction
        '
        Me.lblSelectedAction.AutoSize = True
        Me.lblSelectedAction.BackColor = System.Drawing.Color.White
        Me.lblSelectedAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedAction.Location = New System.Drawing.Point(44, 385)
        Me.lblSelectedAction.Name = "lblSelectedAction"
        Me.lblSelectedAction.Size = New System.Drawing.Size(160, 24)
        Me.lblSelectedAction.TabIndex = 25
        Me.lblSelectedAction.Text = "Selected action:"
        '
        'lblSelectedTime
        '
        Me.lblSelectedTime.AutoSize = True
        Me.lblSelectedTime.BackColor = System.Drawing.Color.White
        Me.lblSelectedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedTime.Location = New System.Drawing.Point(44, 420)
        Me.lblSelectedTime.Name = "lblSelectedTime"
        Me.lblSelectedTime.Size = New System.Drawing.Size(143, 24)
        Me.lblSelectedTime.TabIndex = 26
        Me.lblSelectedTime.Text = "Selected time:"
        '
        'lblSelectedActionContent
        '
        Me.lblSelectedActionContent.AutoSize = True
        Me.lblSelectedActionContent.BackColor = System.Drawing.Color.White
        Me.lblSelectedActionContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedActionContent.Location = New System.Drawing.Point(210, 385)
        Me.lblSelectedActionContent.Name = "lblSelectedActionContent"
        Me.lblSelectedActionContent.Size = New System.Drawing.Size(167, 24)
        Me.lblSelectedActionContent.TabIndex = 28
        Me.lblSelectedActionContent.Text = "%SelectedAction%"
        '
        'lblSelectedTimeContent
        '
        Me.lblSelectedTimeContent.AutoSize = True
        Me.lblSelectedTimeContent.BackColor = System.Drawing.Color.White
        Me.lblSelectedTimeContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectedTimeContent.Location = New System.Drawing.Point(193, 420)
        Me.lblSelectedTimeContent.Name = "lblSelectedTimeContent"
        Me.lblSelectedTimeContent.Size = New System.Drawing.Size(157, 24)
        Me.lblSelectedTimeContent.TabIndex = 29
        Me.lblSelectedTimeContent.Text = "%SelectedTime%"
        '
        'lblRunningTimeContent
        '
        Me.lblRunningTimeContent.AutoSize = True
        Me.lblRunningTimeContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblRunningTimeContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningTimeContent.Location = New System.Drawing.Point(188, 38)
        Me.lblRunningTimeContent.Name = "lblRunningTimeContent"
        Me.lblRunningTimeContent.Size = New System.Drawing.Size(155, 24)
        Me.lblRunningTimeContent.TabIndex = 40
        Me.lblRunningTimeContent.Text = "%RunningTime%"
        '
        'lblRunningActionContent
        '
        Me.lblRunningActionContent.AutoSize = True
        Me.lblRunningActionContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblRunningActionContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunningActionContent.Location = New System.Drawing.Point(188, 11)
        Me.lblRunningActionContent.Name = "lblRunningActionContent"
        Me.lblRunningActionContent.Size = New System.Drawing.Size(165, 24)
        Me.lblRunningActionContent.TabIndex = 39
        Me.lblRunningActionContent.Text = "%RunningAction%"
        '
        'lblScheduledTime
        '
        Me.lblScheduledTime.AutoSize = True
        Me.lblScheduledTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblScheduledTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduledTime.Location = New System.Drawing.Point(3, 38)
        Me.lblScheduledTime.Name = "lblScheduledTime"
        Me.lblScheduledTime.Size = New System.Drawing.Size(162, 24)
        Me.lblScheduledTime.TabIndex = 38
        Me.lblScheduledTime.Text = "Scheduled time:"
        '
        'lblScheduledAction
        '
        Me.lblScheduledAction.AutoSize = True
        Me.lblScheduledAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblScheduledAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduledAction.Location = New System.Drawing.Point(3, 11)
        Me.lblScheduledAction.Name = "lblScheduledAction"
        Me.lblScheduledAction.Size = New System.Drawing.Size(179, 24)
        Me.lblScheduledAction.TabIndex = 37
        Me.lblScheduledAction.Text = "Scheduled action:"
        '
        'pnlActionRunning
        '
        Me.pnlActionRunning.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlActionRunning.Controls.Add(Me.lblTimeRemainingContent)
        Me.pnlActionRunning.Controls.Add(Me.lblTimeRemaining)
        Me.pnlActionRunning.Controls.Add(Me.lblScheduledAction)
        Me.pnlActionRunning.Controls.Add(Me.lblRunningTimeContent)
        Me.pnlActionRunning.Controls.Add(Me.lblScheduledTime)
        Me.pnlActionRunning.Controls.Add(Me.lblRunningActionContent)
        Me.pnlActionRunning.Location = New System.Drawing.Point(44, 529)
        Me.pnlActionRunning.Name = "pnlActionRunning"
        Me.pnlActionRunning.Size = New System.Drawing.Size(379, 100)
        Me.pnlActionRunning.TabIndex = 41
        '
        'lblTimeRemainingContent
        '
        Me.lblTimeRemainingContent.AutoSize = True
        Me.lblTimeRemainingContent.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblTimeRemainingContent.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemainingContent.Location = New System.Drawing.Point(188, 65)
        Me.lblTimeRemainingContent.Name = "lblTimeRemainingContent"
        Me.lblTimeRemainingContent.Size = New System.Drawing.Size(174, 24)
        Me.lblTimeRemainingContent.TabIndex = 42
        Me.lblTimeRemainingContent.Text = "%TimeRemaining%"
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(3, 65)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(162, 24)
        Me.lblTimeRemaining.TabIndex = 41
        Me.lblTimeRemaining.Text = "Time remaining:"
        '
        'tmrPnlActionRunningAnimationUp
        '
        Me.tmrPnlActionRunningAnimationUp.Interval = 1
        '
        'tmrPnlActionRunningAnimationDown
        '
        Me.tmrPnlActionRunningAnimationDown.Interval = 1
        '
        'cmsHamburgerButton
        '
        Me.cmsHamburgerButton.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem, Me.MinimalisticViewToolStripMenuItem, Me.ChangelogToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.cmsHamburgerButton.Name = "cmsHamburgerButton"
        Me.cmsHamburgerButton.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.cmsHamburgerButton.Size = New System.Drawing.Size(200, 108)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Image = CType(resources.GetObject("SettingsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SettingsToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'MinimalisticViewToolStripMenuItem
        '
        Me.MinimalisticViewToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimalisticViewToolStripMenuItem.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.minimalistic_view
        Me.MinimalisticViewToolStripMenuItem.Name = "MinimalisticViewToolStripMenuItem"
        Me.MinimalisticViewToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.MinimalisticViewToolStripMenuItem.Text = "Minimalistic View"
        '
        'ChangelogToolStripMenuItem
        '
        Me.ChangelogToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChangelogToolStripMenuItem.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.update
        Me.ChangelogToolStripMenuItem.Name = "ChangelogToolStripMenuItem"
        Me.ChangelogToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.ChangelogToolStripMenuItem.Text = "Changelog"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutToolStripMenuItem.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.about
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'tmrShutdown
        '
        '
        'btnStartAction
        '
        Me.btnStartAction.BackgroundImage = CType(resources.GetObject("btnStartAction.BackgroundImage"), System.Drawing.Image)
        Me.btnStartAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartAction.FlatAppearance.BorderSize = 0
        Me.btnStartAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartAction.ForeColor = System.Drawing.Color.White
        Me.btnStartAction.Location = New System.Drawing.Point(433, 385)
        Me.btnStartAction.Name = "btnStartAction"
        Me.btnStartAction.Size = New System.Drawing.Size(162, 59)
        Me.btnStartAction.TabIndex = 43
        Me.btnStartAction.Text = "Start action"
        Me.btnStartAction.UseVisualStyleBackColor = True
        '
        'pbNotification
        '
        Me.pbNotification.BackColor = System.Drawing.Color.Transparent
        Me.pbNotification.BackgroundImage = CType(resources.GetObject("pbNotification.BackgroundImage"), System.Drawing.Image)
        Me.pbNotification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbNotification.Location = New System.Drawing.Point(13, 3)
        Me.pbNotification.Name = "pbNotification"
        Me.pbNotification.Size = New System.Drawing.Size(591, 26)
        Me.pbNotification.TabIndex = 45
        Me.pbNotification.TabStop = False
        '
        'pnlNotification
        '
        Me.pnlNotification.BackColor = System.Drawing.Color.Transparent
        Me.pnlNotification.Controls.Add(Me.lblNotification)
        Me.pnlNotification.Controls.Add(Me.pbNotification)
        Me.pnlNotification.Location = New System.Drawing.Point(9, 27)
        Me.pnlNotification.Name = "pnlNotification"
        Me.pnlNotification.Size = New System.Drawing.Size(620, 31)
        Me.pnlNotification.TabIndex = 46
        '
        'lblNotification
        '
        Me.lblNotification.AutoSize = True
        Me.lblNotification.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.lblNotification.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotification.ForeColor = System.Drawing.Color.Black
        Me.lblNotification.Location = New System.Drawing.Point(20, 6)
        Me.lblNotification.Name = "lblNotification"
        Me.lblNotification.Size = New System.Drawing.Size(116, 20)
        Me.lblNotification.TabIndex = 46
        Me.lblNotification.Text = "%Notification%"
        '
        'tmrPnlNotificationAnimationDown
        '
        Me.tmrPnlNotificationAnimationDown.Interval = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pbIcon)
        Me.Panel1.Controls.Add(Me.lblHeader)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.btnHamburger)
        Me.Panel1.Controls.Add(Me.pbLine)
        Me.Panel1.Location = New System.Drawing.Point(3, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 68)
        Me.Panel1.TabIndex = 48
        '
        'tmrPnlNotificationAnimationUp
        '
        Me.tmrPnlNotificationAnimationUp.Interval = 1
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.BackgroundImage = CType(resources.GetObject("btnSaveProfile.BackgroundImage"), System.Drawing.Image)
        Me.btnSaveProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSaveProfile.FlatAppearance.BorderSize = 0
        Me.btnSaveProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSaveProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.ForeColor = System.Drawing.Color.White
        Me.btnSaveProfile.Location = New System.Drawing.Point(17, 317)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(157, 23)
        Me.btnSaveProfile.TabIndex = 49
        Me.btnSaveProfile.Text = "Save profile"
        Me.btnSaveProfile.UseVisualStyleBackColor = True
        '
        'btnLoadProfile
        '
        Me.btnLoadProfile.BackgroundImage = CType(resources.GetObject("btnLoadProfile.BackgroundImage"), System.Drawing.Image)
        Me.btnLoadProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLoadProfile.FlatAppearance.BorderSize = 0
        Me.btnLoadProfile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLoadProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLoadProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLoadProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadProfile.ForeColor = System.Drawing.Color.White
        Me.btnLoadProfile.Location = New System.Drawing.Point(180, 317)
        Me.btnLoadProfile.Name = "btnLoadProfile"
        Me.btnLoadProfile.Size = New System.Drawing.Size(155, 23)
        Me.btnLoadProfile.TabIndex = 50
        Me.btnLoadProfile.Text = "Load profile"
        Me.btnLoadProfile.UseVisualStyleBackColor = True
        '
        'llblTimeHelper
        '
        Me.llblTimeHelper.AutoSize = True
        Me.llblTimeHelper.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblTimeHelper.Location = New System.Drawing.Point(161, 176)
        Me.llblTimeHelper.Name = "llblTimeHelper"
        Me.llblTimeHelper.Size = New System.Drawing.Size(147, 16)
        Me.llblTimeHelper.TabIndex = 53
        Me.llblTimeHelper.TabStop = True
        Me.llblTimeHelper.Text = "What time should I use?"
        '
        'tmrCheckRunningProcess
        '
        Me.tmrCheckRunningProcess.Interval = 1000
        '
        'llblEditRunningAction
        '
        Me.llblEditRunningAction.AutoSize = True
        Me.llblEditRunningAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblEditRunningAction.Location = New System.Drawing.Point(161, 76)
        Me.llblEditRunningAction.Name = "llblEditRunningAction"
        Me.llblEditRunningAction.Size = New System.Drawing.Size(122, 16)
        Me.llblEditRunningAction.TabIndex = 54
        Me.llblEditRunningAction.TabStop = True
        Me.llblEditRunningAction.Text = "Edit Running Action"
        Me.llblEditRunningAction.Visible = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(632, 491)
        Me.Controls.Add(Me.llblTimeHelper)
        Me.Controls.Add(Me.btnLoadProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlNotification)
        Me.Controls.Add(Me.btnStartAction)
        Me.Controls.Add(Me.pnlActionRunning)
        Me.Controls.Add(Me.gbLastAction)
        Me.Controls.Add(Me.pnlTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pnlAction)
        Me.Controls.Add(Me.lblSelectedTimeContent)
        Me.Controls.Add(Me.lblSelectedActionContent)
        Me.Controls.Add(Me.lblSelectedTime)
        Me.Controls.Add(Me.lblSelectedAction)
        Me.Controls.Add(Me.pbGrayBox)
        Me.Controls.Add(Me.pbLine2)
        Me.Controls.Add(Me.llblEditRunningAction)
        Me.Controls.Add(Me.lblAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown"
        Me.gbLastAction.ResumeLayout(False)
        Me.gbLastAction.PerformLayout()
        CType(Me.pbLine, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        Me.pnlAction.ResumeLayout(False)
        Me.pnlAction.PerformLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGrayBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbLine2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActionRunning.ResumeLayout(False)
        Me.pnlActionRunning.PerformLayout()
        Me.cmsHamburgerButton.ResumeLayout(False)
        CType(Me.pbNotification, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlNotification.ResumeLayout(False)
        Me.pnlNotification.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents tbTime As TextBox
    Friend WithEvents cbxIn As ComboBox
    Friend WithEvents rbtnPointInTime As RadioButton
    Friend WithEvents rbtnIn As RadioButton
    Friend WithEvents gbLastAction As GroupBox
    Friend WithEvents lblStartedOnContent As Label
    Friend WithEvents lblStartedOn As Label
    Friend WithEvents lblLastTimeContent As Label
    Friend WithEvents lblLastTime As Label
    Friend WithEvents lblLastActionContent As Label
    Friend WithEvents lblLastAction As Label
    Friend WithEvents btnHamburger As Button
    Friend WithEvents pbLine As PictureBox
    Friend WithEvents pnlTime As Panel
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlAction As Panel
    Friend WithEvents lblAction As Label
    Friend WithEvents pbIcon As PictureBox
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents pbGrayBox As PictureBox
    Friend WithEvents pbLine2 As PictureBox
    Friend WithEvents tmrGrayBoxAnimationUp As Timer
    Friend WithEvents tmrGrayBoxAnimationDown As Timer
    Friend WithEvents lblSelectedAction As Label
    Friend WithEvents lblSelectedTime As Label
    Friend WithEvents lblSelectedActionContent As Label
    Friend WithEvents lblSelectedTimeContent As Label
    Friend WithEvents lblRunningTimeContent As Label
    Friend WithEvents lblRunningActionContent As Label
    Friend WithEvents lblScheduledTime As Label
    Friend WithEvents lblScheduledAction As Label
    Friend WithEvents pnlActionRunning As Panel
    Friend WithEvents tmrPnlActionRunningAnimationUp As Timer
    Friend WithEvents tmrPnlActionRunningAnimationDown As Timer
    Friend WithEvents cmsHamburgerButton As ContextMenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangelogToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblTimeRemainingContent As Label
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents tmrShutdown As Timer
    Friend WithEvents btnStartAction As Button
    Friend WithEvents MinimalisticViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbNotification As PictureBox
    Friend WithEvents pnlNotification As Panel
    Friend WithEvents tmrPnlNotificationAnimationDown As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNotification As Label
    Friend WithEvents tmrPnlNotificationAnimationUp As Timer
    Friend WithEvents btnShowActionHistory As Button
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnLoadProfile As Button
    Friend WithEvents llblTimeHelper As LinkLabel
    Friend WithEvents cbDelayWhenProcessRunning As CheckBox
    Friend WithEvents btnSelectProcesses As Button
    Friend WithEvents tmrCheckRunningProcess As Timer
    Friend WithEvents llblEditRunningAction As LinkLabel
End Class
