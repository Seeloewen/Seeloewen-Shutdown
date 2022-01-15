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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.gbAction = New System.Windows.Forms.GroupBox()
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.rbtnPointInTime = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.cbxIn = New System.Windows.Forms.ComboBox()
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.gbMessage = New System.Windows.Forms.GroupBox()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.cbMessage = New System.Windows.Forms.CheckBox()
        Me.currentDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Action = New System.Windows.Forms.Label()
        Me.Shutdowntime = New System.Windows.Forms.Label()
        Me.Finaloutput = New System.Windows.Forms.Label()
        Me.Quotationmark = New System.Windows.Forms.Label()
        Me.btnOpenSettings = New System.Windows.Forms.Button()
        Me.btnOpenHelp = New System.Windows.Forms.Button()
        Me.btnStartAction = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnHamburger = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.pbGrayBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tmrGrayBoxAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGrayBoxAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.RunningAction = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.lblScheduledAction = New System.Windows.Forms.Label()
        Me.pnlActionRunning = New System.Windows.Forms.Panel()
        Me.tmrPnlActionRunningAnimationUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrPnlActionRunningAnimationDown = New System.Windows.Forms.Timer(Me.components)
        Me.gbMessage.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbGrayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlActionRunning.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(835, 32)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(311, 37)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Seeloewen Shutdown"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblVersion.Location = New System.Drawing.Point(837, 69)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(139, 25)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version 1.6.1"
        '
        'gbAction
        '
        Me.gbAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAction.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbAction.Location = New System.Drawing.Point(842, 109)
        Me.gbAction.Name = "gbAction"
        Me.gbAction.Size = New System.Drawing.Size(322, 86)
        Me.gbAction.TabIndex = 2
        Me.gbAction.TabStop = False
        Me.gbAction.Text = "Aktion"
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
        'gbTime
        '
        Me.gbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbTime.Location = New System.Drawing.Point(842, 202)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Size = New System.Drawing.Size(322, 86)
        Me.gbTime.TabIndex = 3
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Zeit"
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
        Me.cbxIn.Items.AddRange(New Object() {"Sekunde(n)", "Minute(n)", "Stunde(n)"})
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
        'gbMessage
        '
        Me.gbMessage.Controls.Add(Me.tbMessage)
        Me.gbMessage.Controls.Add(Me.cbMessage)
        Me.gbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbMessage.Location = New System.Drawing.Point(842, 294)
        Me.gbMessage.Name = "gbMessage"
        Me.gbMessage.Size = New System.Drawing.Size(322, 105)
        Me.gbMessage.TabIndex = 4
        Me.gbMessage.TabStop = False
        Me.gbMessage.Text = "Nachricht"
        '
        'tbMessage
        '
        Me.tbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMessage.Location = New System.Drawing.Point(15, 53)
        Me.tbMessage.Multiline = True
        Me.tbMessage.Name = "tbMessage"
        Me.tbMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbMessage.Size = New System.Drawing.Size(289, 39)
        Me.tbMessage.TabIndex = 1
        '
        'cbMessage
        '
        Me.cbMessage.AutoSize = True
        Me.cbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbMessage.Location = New System.Drawing.Point(14, 26)
        Me.cbMessage.Name = "cbMessage"
        Me.cbMessage.Size = New System.Drawing.Size(133, 20)
        Me.cbMessage.TabIndex = 0
        Me.cbMessage.Text = "Nachricht anfügen"
        Me.cbMessage.UseVisualStyleBackColor = True
        '
        'currentDateTime
        '
        Me.currentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.currentDateTime.Location = New System.Drawing.Point(802, 750)
        Me.currentDateTime.Name = "currentDateTime"
        Me.currentDateTime.Size = New System.Drawing.Size(200, 20)
        Me.currentDateTime.TabIndex = 8
        '
        'Action
        '
        Me.Action.AutoSize = True
        Me.Action.Location = New System.Drawing.Point(799, 777)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(37, 13)
        Me.Action.TabIndex = 9
        Me.Action.Text = "Action"
        '
        'Shutdowntime
        '
        Me.Shutdowntime.AutoSize = True
        Me.Shutdowntime.Location = New System.Drawing.Point(799, 790)
        Me.Shutdowntime.Name = "Shutdowntime"
        Me.Shutdowntime.Size = New System.Drawing.Size(74, 13)
        Me.Shutdowntime.TabIndex = 10
        Me.Shutdowntime.Text = "Shutdowntime"
        '
        'Finaloutput
        '
        Me.Finaloutput.AutoSize = True
        Me.Finaloutput.Location = New System.Drawing.Point(799, 803)
        Me.Finaloutput.Name = "Finaloutput"
        Me.Finaloutput.Size = New System.Drawing.Size(59, 13)
        Me.Finaloutput.TabIndex = 11
        Me.Finaloutput.Text = "Finaloutput"
        '
        'Quotationmark
        '
        Me.Quotationmark.AutoSize = True
        Me.Quotationmark.Location = New System.Drawing.Point(799, 819)
        Me.Quotationmark.Name = "Quotationmark"
        Me.Quotationmark.Size = New System.Drawing.Size(12, 13)
        Me.Quotationmark.TabIndex = 12
        Me.Quotationmark.Text = """"
        '
        'btnOpenSettings
        '
        Me.btnOpenSettings.BackgroundImage = CType(resources.GetObject("btnOpenSettings.BackgroundImage"), System.Drawing.Image)
        Me.btnOpenSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenSettings.FlatAppearance.BorderSize = 0
        Me.btnOpenSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpenSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpenSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSettings.ForeColor = System.Drawing.Color.White
        Me.btnOpenSettings.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.btnSettings
        Me.btnOpenSettings.Location = New System.Drawing.Point(351, 87)
        Me.btnOpenSettings.Name = "btnOpenSettings"
        Me.btnOpenSettings.Size = New System.Drawing.Size(48, 38)
        Me.btnOpenSettings.TabIndex = 7
        Me.btnOpenSettings.UseVisualStyleBackColor = True
        '
        'btnOpenHelp
        '
        Me.btnOpenHelp.BackColor = System.Drawing.Color.Transparent
        Me.btnOpenHelp.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnOpenHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenHelp.FlatAppearance.BorderSize = 0
        Me.btnOpenHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpenHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpenHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenHelp.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenHelp.ForeColor = System.Drawing.Color.Transparent
        Me.btnOpenHelp.Location = New System.Drawing.Point(297, 87)
        Me.btnOpenHelp.Name = "btnOpenHelp"
        Me.btnOpenHelp.Size = New System.Drawing.Size(48, 38)
        Me.btnOpenHelp.TabIndex = 6
        Me.btnOpenHelp.Text = "?"
        Me.btnOpenHelp.UseVisualStyleBackColor = False
        '
        'btnStartAction
        '
        Me.btnStartAction.BackColor = System.Drawing.Color.White
        Me.btnStartAction.BackgroundImage = CType(resources.GetObject("btnStartAction.BackgroundImage"), System.Drawing.Image)
        Me.btnStartAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStartAction.FlatAppearance.BorderSize = 0
        Me.btnStartAction.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnStartAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStartAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartAction.ForeColor = System.Drawing.Color.White
        Me.btnStartAction.Location = New System.Drawing.Point(433, 364)
        Me.btnStartAction.Name = "btnStartAction"
        Me.btnStartAction.Size = New System.Drawing.Size(166, 58)
        Me.btnStartAction.TabIndex = 5
        Me.btnStartAction.Text = "Start action"
        Me.btnStartAction.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(420, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(191, 238)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Last action"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 159)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "%ExecutedOn%"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(9, 139)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Executed on:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(7, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Restart last action"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "%LastTime%"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(9, 79)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 20)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Time:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(113, 20)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "%LastAction%"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Action:"
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
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.Line
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Location = New System.Drawing.Point(7, 57)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(617, 12)
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpDate)
        Me.Panel2.Controls.Add(Me.rbtnPointInTime)
        Me.Panel2.Controls.Add(Me.cbxIn)
        Me.Panel2.Controls.Add(Me.rbtnIn)
        Me.Panel2.Controls.Add(Me.tbTime)
        Me.Panel2.Location = New System.Drawing.Point(21, 215)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(318, 84)
        Me.Panel2.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 187)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 25)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Time"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtnRestart)
        Me.Panel1.Controls.Add(Me.rbtnShutdown)
        Me.Panel1.Location = New System.Drawing.Point(21, 115)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(141, 58)
        Me.Panel1.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(16, 87)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 25)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Action"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.Icon1
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(24, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(64, 59)
        Me.PictureBox2.TabIndex = 30
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label13.Location = New System.Drawing.Point(449, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 31)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "1.7.0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(94, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(349, 39)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Seeloewen Shutdown"
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
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.Line
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(7, 331)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(617, 10)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'tmrGrayBoxAnimationUp
        '
        Me.tmrGrayBoxAnimationUp.Interval = 1
        '
        'tmrGrayBoxAnimationDown
        '
        Me.tmrGrayBoxAnimationDown.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 363)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Selected action:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 24)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Selected time:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(210, 363)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "%SelectedAction%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(193, 398)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(157, 24)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "%SelectedTime%"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(171, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(155, 24)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "%RunningTime%"
        '
        'RunningAction
        '
        Me.RunningAction.AutoSize = True
        Me.RunningAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.RunningAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RunningAction.Location = New System.Drawing.Point(188, 19)
        Me.RunningAction.Name = "RunningAction"
        Me.RunningAction.Size = New System.Drawing.Size(165, 24)
        Me.RunningAction.TabIndex = 39
        Me.RunningAction.Text = "%RunningAction%"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(3, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(162, 24)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "Scheduled time:"
        '
        'lblScheduledAction
        '
        Me.lblScheduledAction.AutoSize = True
        Me.lblScheduledAction.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.lblScheduledAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduledAction.Location = New System.Drawing.Point(3, 19)
        Me.lblScheduledAction.Name = "lblScheduledAction"
        Me.lblScheduledAction.Size = New System.Drawing.Size(179, 24)
        Me.lblScheduledAction.TabIndex = 37
        Me.lblScheduledAction.Text = "Scheduled action:"
        '
        'pnlActionRunning
        '
        Me.pnlActionRunning.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer), CType(CType(232, Byte), Integer))
        Me.pnlActionRunning.Controls.Add(Me.lblScheduledAction)
        Me.pnlActionRunning.Controls.Add(Me.Label15)
        Me.pnlActionRunning.Controls.Add(Me.Label17)
        Me.pnlActionRunning.Controls.Add(Me.RunningAction)
        Me.pnlActionRunning.Location = New System.Drawing.Point(41, 488)
        Me.pnlActionRunning.Name = "pnlActionRunning"
        Me.pnlActionRunning.Size = New System.Drawing.Size(390, 94)
        Me.pnlActionRunning.TabIndex = 41
        '
        'tmrPnlActionRunningAnimationUp
        '
        Me.tmrPnlActionRunningAnimationUp.Interval = 1
        '
        'tmrPnlActionRunningAnimationDown
        '
        Me.tmrPnlActionRunningAnimationDown.Interval = 1
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(636, 472)
        Me.Controls.Add(Me.pnlActionRunning)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnHamburger)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Quotationmark)
        Me.Controls.Add(Me.Finaloutput)
        Me.Controls.Add(Me.Shutdowntime)
        Me.Controls.Add(Me.Action)
        Me.Controls.Add(Me.currentDateTime)
        Me.Controls.Add(Me.btnOpenSettings)
        Me.Controls.Add(Me.btnOpenHelp)
        Me.Controls.Add(Me.btnStartAction)
        Me.Controls.Add(Me.gbMessage)
        Me.Controls.Add(Me.gbTime)
        Me.Controls.Add(Me.gbAction)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pbGrayBox)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown"
        Me.gbMessage.ResumeLayout(False)
        Me.gbMessage.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbGrayBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlActionRunning.ResumeLayout(False)
        Me.pnlActionRunning.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents gbAction As GroupBox
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents gbTime As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents tbTime As TextBox
    Friend WithEvents gbMessage As GroupBox
    Friend WithEvents tbMessage As TextBox
    Friend WithEvents cbMessage As CheckBox
    Friend WithEvents btnStartAction As Button
    Friend WithEvents btnOpenHelp As Button
    Friend WithEvents btnOpenSettings As Button
    Friend WithEvents currentDateTime As DateTimePicker
    Friend WithEvents Action As Label
    Friend WithEvents Shutdowntime As Label
    Friend WithEvents Finaloutput As Label
    Friend WithEvents Quotationmark As Label
    Friend WithEvents cbxIn As ComboBox
    Friend WithEvents rbtnPointInTime As RadioButton
    Friend WithEvents rbtnIn As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnHamburger As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents pbGrayBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tmrGrayBoxAnimationUp As Timer
    Friend WithEvents tmrGrayBoxAnimationDown As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents RunningAction As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents lblScheduledAction As Label
    Friend WithEvents pnlActionRunning As Panel
    Friend WithEvents tmrPnlActionRunningAnimationUp As Timer
    Friend WithEvents tmrPnlActionRunningAnimationDown As Timer
End Class
