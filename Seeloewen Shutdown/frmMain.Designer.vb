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
        Me.currentDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Action = New System.Windows.Forms.Label()
        Me.Shutdowntime = New System.Windows.Forms.Label()
        Me.Finaloutput = New System.Windows.Forms.Label()
        Me.Quotationmark = New System.Windows.Forms.Label()
        Me.gbLastAction = New System.Windows.Forms.GroupBox()
        Me._ExecutedOn = New System.Windows.Forms.Label()
        Me.lblExecutedOn = New System.Windows.Forms.Label()
        Me._LastTime = New System.Windows.Forms.Label()
        Me.lblLastTime = New System.Windows.Forms.Label()
        Me._LastAction = New System.Windows.Forms.Label()
        Me.lblLastAction = New System.Windows.Forms.Label()
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.pbLine = New System.Windows.Forms.PictureBox()
        Me.pnlTime = New System.Windows.Forms.Panel()
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
        Me._SelectedAction = New System.Windows.Forms.Label()
        Me._SelectedTime = New System.Windows.Forms.Label()
        Me._RunningTime = New System.Windows.Forms.Label()
        Me._RunningAction = New System.Windows.Forms.Label()
        Me.lblScheduledTime = New System.Windows.Forms.Label()
        Me.lblScheduledAction = New System.Windows.Forms.Label()
        Me.pnlActionRunning = New System.Windows.Forms.Panel()
        Me._TimeRemaining = New System.Windows.Forms.Label()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.tmrPnlActionRunningAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPnlActionRunningAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.cmsHamburgerButton = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpSelectedTime = New System.Windows.Forms.DateTimePicker()
        Me.tmrShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartAction = New System.Windows.Forms.Button()
        Me.gbLastAction.SuspendLayout()
        CType(Me.pbLine, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlTime.SuspendLayout()
        Me.pnlAction.SuspendLayout()
        CType(Me.pbIcon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbLine2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActionRunning.SuspendLayout()
        Me.cmsHamburgerButton.SuspendLayout()
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
        Me.rbtnRestart.TabStop = True
        Me.rbtnRestart.Text = "Restart"
        Me.rbtnRestart.UseVisualStyleBackColor = False
        '
        'rbtnShutdown
        '
        Me.rbtnShutdown.AutoSize = True
        Me.rbtnShutdown.Checked = True
        Me.rbtnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShutdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnShutdown.Location = New System.Drawing.Point(3, 3)
        Me.rbtnShutdown.Name = "rbtnShutdown"
        Me.rbtnShutdown.Size = New System.Drawing.Size(99, 24)
        Me.rbtnShutdown.TabIndex = 0
        Me.rbtnShutdown.TabStop = True
        Me.rbtnShutdown.Text = "Shutdown"
        Me.rbtnShutdown.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(110, 31)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(185, 22)
        Me.dtpDate.TabIndex = 6
        '
        'rbtnPointInTime
        '
        Me.rbtnPointInTime.AutoSize = True
        Me.rbtnPointInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPointInTime.ForeColor = System.Drawing.Color.Black
        Me.rbtnPointInTime.Location = New System.Drawing.Point(3, 29)
        Me.rbtnPointInTime.Name = "rbtnPointInTime"
        Me.rbtnPointInTime.Size = New System.Drawing.Size(101, 24)
        Me.rbtnPointInTime.TabIndex = 10
        Me.rbtnPointInTime.TabStop = True
        Me.rbtnPointInTime.Text = "Exact time"
        Me.rbtnPointInTime.UseVisualStyleBackColor = True
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIn.ForeColor = System.Drawing.Color.Black
        Me.rbtnIn.Location = New System.Drawing.Point(3, 3)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(53, 24)
        Me.rbtnIn.TabIndex = 9
        Me.rbtnIn.TabStop = True
        Me.rbtnIn.Text = "In..."
        Me.rbtnIn.UseVisualStyleBackColor = True
        '
        'cbxIn
        '
        Me.cbxIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxIn.FormattingEnabled = True
        Me.cbxIn.Items.AddRange(New Object() {"Second(s)", "Minute(s)", "Hour(s)"})
        Me.cbxIn.Location = New System.Drawing.Point(163, 5)
        Me.cbxIn.Name = "cbxIn"
        Me.cbxIn.Size = New System.Drawing.Size(132, 21)
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
        'currentDateTime
        '
        Me.currentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.currentDateTime.Location = New System.Drawing.Point(707, 100)
        Me.currentDateTime.Name = "currentDateTime"
        Me.currentDateTime.Size = New System.Drawing.Size(200, 20)
        Me.currentDateTime.TabIndex = 8
        '
        'Action
        '
        Me.Action.AutoSize = True
        Me.Action.Location = New System.Drawing.Point(704, 127)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(37, 13)
        Me.Action.TabIndex = 9
        Me.Action.Text = "Action"
        '
        'Shutdowntime
        '
        Me.Shutdowntime.AutoSize = True
        Me.Shutdowntime.Location = New System.Drawing.Point(704, 140)
        Me.Shutdowntime.Name = "Shutdowntime"
        Me.Shutdowntime.Size = New System.Drawing.Size(74, 13)
        Me.Shutdowntime.TabIndex = 10
        Me.Shutdowntime.Text = "Shutdowntime"
        '
        'Finaloutput
        '
        Me.Finaloutput.AutoSize = True
        Me.Finaloutput.Location = New System.Drawing.Point(704, 153)
        Me.Finaloutput.Name = "Finaloutput"
        Me.Finaloutput.Size = New System.Drawing.Size(59, 13)
        Me.Finaloutput.TabIndex = 11
        Me.Finaloutput.Text = "Finaloutput"
        '
        'Quotationmark
        '
        Me.Quotationmark.AutoSize = True
        Me.Quotationmark.Location = New System.Drawing.Point(704, 169)
        Me.Quotationmark.Name = "Quotationmark"
        Me.Quotationmark.Size = New System.Drawing.Size(12, 13)
        Me.Quotationmark.TabIndex = 12
        Me.Quotationmark.Text = """"
        '
        'gbLastAction
        '
        Me.gbLastAction.Controls.Add(Me._ExecutedOn)
        Me.gbLastAction.Controls.Add(Me.lblExecutedOn)
        Me.gbLastAction.Controls.Add(Me._LastTime)
        Me.gbLastAction.Controls.Add(Me.lblLastTime)
        Me.gbLastAction.Controls.Add(Me._LastAction)
        Me.gbLastAction.Controls.Add(Me.lblLastAction)
        Me.gbLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbLastAction.Location = New System.Drawing.Point(420, 75)
        Me.gbLastAction.Name = "gbLastAction"
        Me.gbLastAction.Size = New System.Drawing.Size(191, 238)
        Me.gbLastAction.TabIndex = 36
        Me.gbLastAction.TabStop = False
        Me.gbLastAction.Text = "Last action"
        '
        '_ExecutedOn
        '
        Me._ExecutedOn.AutoSize = True
        Me._ExecutedOn.Location = New System.Drawing.Point(9, 189)
        Me._ExecutedOn.Name = "_ExecutedOn"
        Me._ExecutedOn.Size = New System.Drawing.Size(125, 20)
        Me._ExecutedOn.TabIndex = 6
        Me._ExecutedOn.Text = "%ExecutedOn%"
        '
        'lblExecutedOn
        '
        Me.lblExecutedOn.AutoSize = True
        Me.lblExecutedOn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExecutedOn.Location = New System.Drawing.Point(9, 169)
        Me.lblExecutedOn.Name = "lblExecutedOn"
        Me.lblExecutedOn.Size = New System.Drawing.Size(114, 20)
        Me.lblExecutedOn.TabIndex = 5
        Me.lblExecutedOn.Text = "Executed on:"
        '
        '_LastTime
        '
        Me._LastTime.AutoSize = True
        Me._LastTime.Location = New System.Drawing.Point(9, 116)
        Me._LastTime.Name = "_LastTime"
        Me._LastTime.Size = New System.Drawing.Size(102, 20)
        Me._LastTime.TabIndex = 3
        Me._LastTime.Text = "%LastTime%"
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
        '_LastAction
        '
        Me._LastAction.AutoSize = True
        Me._LastAction.Location = New System.Drawing.Point(9, 49)
        Me._LastAction.Name = "_LastAction"
        Me._LastAction.Size = New System.Drawing.Size(113, 20)
        Me._LastAction.TabIndex = 1
        Me._LastAction.Text = "%LastAction%"
        '
        'lblLastAction
        '
        Me.lblLastAction.AutoSize = True
        Me.lblLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastAction.Location = New System.Drawing.Point(9, 29)
        Me.lblLastAction.Name = "lblLastAction"
        Me.lblLastAction.Size = New System.Drawing.Size(65, 20)
        Me.lblLastAction.TabIndex = 0
        Me.lblLastAction.Text = "Action:"
        '
        'btnHamburger
        '
        Me.btnHamburger.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.btnHamburger
        Me.btnHamburger.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHamburger.FlatAppearance.BorderSize = 0
        Me.btnHamburger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnHamburger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHamburger.Location = New System.Drawing.Point(564, 12)
        Me.btnHamburger.Name = "btnHamburger"
        Me.btnHamburger.Size = New System.Drawing.Size(47, 44)
        Me.btnHamburger.TabIndex = 20
        Me.btnHamburger.UseVisualStyleBackColor = True
        '
        'pbLine
        '
        Me.pbLine.BackgroundImage = CType(resources.GetObject("pbLine.BackgroundImage"), System.Drawing.Image)
        Me.pbLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLine.Location = New System.Drawing.Point(7, 57)
        Me.pbLine.Name = "pbLine"
        Me.pbLine.Size = New System.Drawing.Size(617, 12)
        Me.pbLine.TabIndex = 35
        Me.pbLine.TabStop = False
        '
        'pnlTime
        '
        Me.pnlTime.Controls.Add(Me.dtpDate)
        Me.pnlTime.Controls.Add(Me.rbtnPointInTime)
        Me.pnlTime.Controls.Add(Me.cbxIn)
        Me.pnlTime.Controls.Add(Me.rbtnIn)
        Me.pnlTime.Controls.Add(Me.tbTime)
        Me.pnlTime.Location = New System.Drawing.Point(21, 215)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(318, 84)
        Me.pnlTime.TabIndex = 34
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(16, 187)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(311, 25)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "Time                                          "
        '
        'pnlAction
        '
        Me.pnlAction.Controls.Add(Me.rbtnRestart)
        Me.pnlAction.Controls.Add(Me.rbtnShutdown)
        Me.pnlAction.Location = New System.Drawing.Point(21, 115)
        Me.pnlAction.Name = "pnlAction"
        Me.pnlAction.Size = New System.Drawing.Size(141, 58)
        Me.pnlAction.TabIndex = 32
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(16, 87)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(312, 25)
        Me.lblAction.TabIndex = 31
        Me.lblAction.Text = "Action                                        "
        '
        'pbIcon
        '
        Me.pbIcon.BackgroundImage = CType(resources.GetObject("pbIcon.BackgroundImage"), System.Drawing.Image)
        Me.pbIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbIcon.Location = New System.Drawing.Point(24, 2)
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
        Me.lblVersion.Location = New System.Drawing.Point(449, 23)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(75, 31)
        Me.lblVersion.TabIndex = 22
        Me.lblVersion.Text = "1.7.0"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(94, 17)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(349, 39)
        Me.lblHeader.TabIndex = 21
        Me.lblHeader.Text = "Seeloewen Shutdown"
        '
        'pbGrayBox
        '
        Me.pbGrayBox.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.grayBox
        Me.pbGrayBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbGrayBox.Location = New System.Drawing.Point(12, 331)
        Me.pbGrayBox.Name = "pbGrayBox"
        Me.pbGrayBox.Size = New System.Drawing.Size(617, 133)
        Me.pbGrayBox.TabIndex = 23
        Me.pbGrayBox.TabStop = False
        Me.pbGrayBox.Visible = False
        '
        'pbLine2
        '
        Me.pbLine2.BackgroundImage = CType(resources.GetObject("pbLine2.BackgroundImage"), System.Drawing.Image)
        Me.pbLine2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbLine2.Location = New System.Drawing.Point(7, 331)
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
        Me.lblSelectedAction.Location = New System.Drawing.Point(44, 363)
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
        Me.lblSelectedTime.Location = New System.Drawing.Point(44, 398)
        Me.lblSelectedTime.Name = "lblSelectedTime"
        Me.lblSelectedTime.Size = New System.Drawing.Size(143, 24)
        Me.lblSelectedTime.TabIndex = 26
        Me.lblSelectedTime.Text = "Selected time:"
        '
        '_SelectedAction
        '
        Me._SelectedAction.AutoSize = True
        Me._SelectedAction.BackColor = System.Drawing.Color.White
        Me._SelectedAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SelectedAction.Location = New System.Drawing.Point(210, 363)
        Me._SelectedAction.Name = "_SelectedAction"
        Me._SelectedAction.Size = New System.Drawing.Size(167, 24)
        Me._SelectedAction.TabIndex = 28
        Me._SelectedAction.Text = "%SelectedAction%"
        '
        '_SelectedTime
        '
        Me._SelectedTime.AutoSize = True
        Me._SelectedTime.BackColor = System.Drawing.Color.White
        Me._SelectedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._SelectedTime.Location = New System.Drawing.Point(193, 398)
        Me._SelectedTime.Name = "_SelectedTime"
        Me._SelectedTime.Size = New System.Drawing.Size(157, 24)
        Me._SelectedTime.TabIndex = 29
        Me._SelectedTime.Text = "%SelectedTime%"
        '
        '_RunningTime
        '
        Me._RunningTime.AutoSize = True
        Me._RunningTime.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me._RunningTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._RunningTime.Location = New System.Drawing.Point(188, 38)
        Me._RunningTime.Name = "_RunningTime"
        Me._RunningTime.Size = New System.Drawing.Size(155, 24)
        Me._RunningTime.TabIndex = 40
        Me._RunningTime.Text = "%RunningTime%"
        '
        '_RunningAction
        '
        Me._RunningAction.AutoSize = True
        Me._RunningAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me._RunningAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._RunningAction.Location = New System.Drawing.Point(188, 11)
        Me._RunningAction.Name = "_RunningAction"
        Me._RunningAction.Size = New System.Drawing.Size(165, 24)
        Me._RunningAction.TabIndex = 39
        Me._RunningAction.Text = "%RunningAction%"
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
        Me.pnlActionRunning.Controls.Add(Me._TimeRemaining)
        Me.pnlActionRunning.Controls.Add(Me.lblTimeRemaining)
        Me.pnlActionRunning.Controls.Add(Me.lblScheduledAction)
        Me.pnlActionRunning.Controls.Add(Me._RunningTime)
        Me.pnlActionRunning.Controls.Add(Me.lblScheduledTime)
        Me.pnlActionRunning.Controls.Add(Me._RunningAction)
        Me.pnlActionRunning.Location = New System.Drawing.Point(41, 492)
        Me.pnlActionRunning.Name = "pnlActionRunning"
        Me.pnlActionRunning.Size = New System.Drawing.Size(390, 100)
        Me.pnlActionRunning.TabIndex = 41
        '
        '_TimeRemaining
        '
        Me._TimeRemaining.AutoSize = True
        Me._TimeRemaining.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me._TimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._TimeRemaining.Location = New System.Drawing.Point(188, 65)
        Me._TimeRemaining.Name = "_TimeRemaining"
        Me._TimeRemaining.Size = New System.Drawing.Size(174, 24)
        Me._TimeRemaining.TabIndex = 42
        Me._TimeRemaining.Text = "%TimeRemaining%"
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
        Me.cmsHamburgerButton.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.cmsHamburgerButton.Name = "cmsHamburgerButton"
        Me.cmsHamburgerButton.Size = New System.Drawing.Size(153, 82)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem1.Image = CType(resources.GetObject("ToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem1.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(152, 26)
        Me.ToolStripMenuItem1.Text = "Settings"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem2.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.Update
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(152, 26)
        Me.ToolStripMenuItem2.Text = "Changelog"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripMenuItem3.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.About
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(152, 26)
        Me.ToolStripMenuItem3.Text = "About"
        '
        'dtpSelectedTime
        '
        Me.dtpSelectedTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpSelectedTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpSelectedTime.Location = New System.Drawing.Point(214, 656)
        Me.dtpSelectedTime.Name = "dtpSelectedTime"
        Me.dtpSelectedTime.Size = New System.Drawing.Size(185, 22)
        Me.dtpSelectedTime.TabIndex = 42
        '
        'tmrShutdown
        '
        '
        'btnStartAction
        '
        Me.btnStartAction.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnStartAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartAction.FlatAppearance.BorderSize = 0
        Me.btnStartAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartAction.ForeColor = System.Drawing.Color.White
        Me.btnStartAction.Location = New System.Drawing.Point(433, 363)
        Me.btnStartAction.Name = "btnStartAction"
        Me.btnStartAction.Size = New System.Drawing.Size(162, 59)
        Me.btnStartAction.TabIndex = 43
        Me.btnStartAction.Text = "Start Action"
        Me.btnStartAction.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(634, 467)
        Me.Controls.Add(Me.btnStartAction)
        Me.Controls.Add(Me.dtpSelectedTime)
        Me.Controls.Add(Me.pnlActionRunning)
        Me.Controls.Add(Me.pbLine)
        Me.Controls.Add(Me.pbIcon)
        Me.Controls.Add(Me.gbLastAction)
        Me.Controls.Add(Me.btnHamburger)
        Me.Controls.Add(Me.pnlTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pnlAction)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me._SelectedTime)
        Me.Controls.Add(Me._SelectedAction)
        Me.Controls.Add(Me.lblSelectedTime)
        Me.Controls.Add(Me.lblSelectedAction)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.Quotationmark)
        Me.Controls.Add(Me.Finaloutput)
        Me.Controls.Add(Me.Shutdowntime)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.currentDateTime)
        Me.Controls.Add(Me.pbGrayBox)
        Me.Controls.Add(Me.pbLine2)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents tbTime As TextBox
    Friend WithEvents currentDateTime As DateTimePicker
    Friend WithEvents Action As Label
    Friend WithEvents Shutdowntime As Label
    Friend WithEvents Finaloutput As Label
    Friend WithEvents Quotationmark As Label
    Friend WithEvents cbxIn As ComboBox
    Friend WithEvents rbtnPointInTime As RadioButton
    Friend WithEvents rbtnIn As RadioButton
    Friend WithEvents gbLastAction As GroupBox
    Friend WithEvents _ExecutedOn As Label
    Friend WithEvents lblExecutedOn As Label
    Friend WithEvents _LastTime As Label
    Friend WithEvents lblLastTime As Label
    Friend WithEvents _LastAction As Label
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
    Friend WithEvents _SelectedAction As Label
    Friend WithEvents _SelectedTime As Label
    Friend WithEvents _RunningTime As Label
    Friend WithEvents _RunningAction As Label
    Friend WithEvents lblScheduledTime As Label
    Friend WithEvents lblScheduledAction As Label
    Friend WithEvents pnlActionRunning As Panel
    Friend WithEvents tmrPnlActionRunningAnimationUp As Timer
    Friend WithEvents tmrPnlActionRunningAnimationDown As Timer
    Friend WithEvents cmsHamburgerButton As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents dtpSelectedTime As DateTimePicker
    Friend WithEvents _TimeRemaining As Label
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents tmrShutdown As Timer
    Friend WithEvents btnStartAction As Button
End Class
