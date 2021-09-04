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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.gbAction = New System.Windows.Forms.GroupBox()
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.gbTime = New System.Windows.Forms.GroupBox()
        Me.rbtnZeitpunkt = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.cbxIn = New System.Windows.Forms.ComboBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.tbTime = New System.Windows.Forms.TextBox()
        Me.gbMessage = New System.Windows.Forms.GroupBox()
        Me.tbMessage = New System.Windows.Forms.TextBox()
        Me.cbMessage = New System.Windows.Forms.CheckBox()
        Me.btnStartAction = New System.Windows.Forms.Button()
        Me.btnOpenHelp = New System.Windows.Forms.Button()
        Me.currentDateTime = New System.Windows.Forms.DateTimePicker()
        Me.Action = New System.Windows.Forms.Label()
        Me.Shutdowntime = New System.Windows.Forms.Label()
        Me.Finaloutput = New System.Windows.Forms.Label()
        Me.Anführungszeichen = New System.Windows.Forms.Label()
        Me.btnOpenSettings = New System.Windows.Forms.Button()
        Me.gbAction.SuspendLayout()
        Me.gbTime.SuspendLayout()
        Me.gbMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Tai Le", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
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
        Me.lblVersion.Location = New System.Drawing.Point(14, 46)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(202, 25)
        Me.lblVersion.TabIndex = 1
        Me.lblVersion.Text = "Version 1.5.0-Beta1"
        '
        'gbAction
        '
        Me.gbAction.Controls.Add(Me.rbtnRestart)
        Me.gbAction.Controls.Add(Me.rbtnShutdown)
        Me.gbAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAction.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbAction.Location = New System.Drawing.Point(19, 86)
        Me.gbAction.Name = "gbAction"
        Me.gbAction.Size = New System.Drawing.Size(322, 86)
        Me.gbAction.TabIndex = 2
        Me.gbAction.TabStop = False
        Me.gbAction.Text = "Aktion"
        '
        'rbtnRestart
        '
        Me.rbtnRestart.AutoSize = True
        Me.rbtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRestart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnRestart.Location = New System.Drawing.Point(15, 51)
        Me.rbtnRestart.Name = "rbtnRestart"
        Me.rbtnRestart.Size = New System.Drawing.Size(91, 20)
        Me.rbtnRestart.TabIndex = 3
        Me.rbtnRestart.TabStop = True
        Me.rbtnRestart.Text = "Neustarten"
        Me.rbtnRestart.UseVisualStyleBackColor = True
        '
        'rbtnShutdown
        '
        Me.rbtnShutdown.AutoSize = True
        Me.rbtnShutdown.Checked = True
        Me.rbtnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShutdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnShutdown.Location = New System.Drawing.Point(15, 25)
        Me.rbtnShutdown.Name = "rbtnShutdown"
        Me.rbtnShutdown.Size = New System.Drawing.Size(114, 20)
        Me.rbtnShutdown.TabIndex = 0
        Me.rbtnShutdown.TabStop = True
        Me.rbtnShutdown.Text = "Herunterfahren"
        Me.rbtnShutdown.UseVisualStyleBackColor = True
        '
        'gbTime
        '
        Me.gbTime.Controls.Add(Me.rbtnZeitpunkt)
        Me.gbTime.Controls.Add(Me.rbtnIn)
        Me.gbTime.Controls.Add(Me.cbxIn)
        Me.gbTime.Controls.Add(Me.dtpDate)
        Me.gbTime.Controls.Add(Me.tbTime)
        Me.gbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbTime.Location = New System.Drawing.Point(19, 179)
        Me.gbTime.Name = "gbTime"
        Me.gbTime.Size = New System.Drawing.Size(322, 86)
        Me.gbTime.TabIndex = 3
        Me.gbTime.TabStop = False
        Me.gbTime.Text = "Zeit"
        '
        'rbtnZeitpunkt
        '
        Me.rbtnZeitpunkt.AutoSize = True
        Me.rbtnZeitpunkt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnZeitpunkt.ForeColor = System.Drawing.Color.Black
        Me.rbtnZeitpunkt.Location = New System.Drawing.Point(14, 49)
        Me.rbtnZeitpunkt.Name = "rbtnZeitpunkt"
        Me.rbtnZeitpunkt.Size = New System.Drawing.Size(80, 20)
        Me.rbtnZeitpunkt.TabIndex = 10
        Me.rbtnZeitpunkt.TabStop = True
        Me.rbtnZeitpunkt.Text = "Zeitpunkt"
        Me.rbtnZeitpunkt.UseVisualStyleBackColor = True
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnIn.ForeColor = System.Drawing.Color.Black
        Me.rbtnIn.Location = New System.Drawing.Point(14, 23)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(45, 20)
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
        Me.cbxIn.Location = New System.Drawing.Point(167, 22)
        Me.cbxIn.Name = "cbxIn"
        Me.cbxIn.Size = New System.Drawing.Size(137, 21)
        Me.cbxIn.TabIndex = 8
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(111, 49)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(193, 22)
        Me.dtpDate.TabIndex = 6
        '
        'tbTime
        '
        Me.tbTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTime.Location = New System.Drawing.Point(66, 22)
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
        Me.gbMessage.Location = New System.Drawing.Point(19, 271)
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
        Me.cbMessage.Size = New System.Drawing.Size(134, 20)
        Me.cbMessage.TabIndex = 0
        Me.cbMessage.Text = "Nachricht anfügen"
        Me.cbMessage.UseVisualStyleBackColor = True
        '
        'btnStartAction
        '
        Me.btnStartAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartAction.Location = New System.Drawing.Point(19, 382)
        Me.btnStartAction.Name = "btnStartAction"
        Me.btnStartAction.Size = New System.Drawing.Size(214, 38)
        Me.btnStartAction.TabIndex = 5
        Me.btnStartAction.Text = "Aktion starten"
        Me.btnStartAction.UseVisualStyleBackColor = True
        '
        'btnOpenHelp
        '
        Me.btnOpenHelp.Font = New System.Drawing.Font("Microsoft YaHei", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenHelp.Location = New System.Drawing.Point(239, 382)
        Me.btnOpenHelp.Name = "btnOpenHelp"
        Me.btnOpenHelp.Size = New System.Drawing.Size(48, 38)
        Me.btnOpenHelp.TabIndex = 6
        Me.btnOpenHelp.Text = "?"
        Me.btnOpenHelp.UseVisualStyleBackColor = True
        '
        'currentDateTime
        '
        Me.currentDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.currentDateTime.Location = New System.Drawing.Point(496, 19)
        Me.currentDateTime.Name = "currentDateTime"
        Me.currentDateTime.Size = New System.Drawing.Size(200, 20)
        Me.currentDateTime.TabIndex = 8
        '
        'Action
        '
        Me.Action.AutoSize = True
        Me.Action.Location = New System.Drawing.Point(493, 46)
        Me.Action.Name = "Action"
        Me.Action.Size = New System.Drawing.Size(37, 13)
        Me.Action.TabIndex = 9
        Me.Action.Text = "Action"
        '
        'Shutdowntime
        '
        Me.Shutdowntime.AutoSize = True
        Me.Shutdowntime.Location = New System.Drawing.Point(493, 59)
        Me.Shutdowntime.Name = "Shutdowntime"
        Me.Shutdowntime.Size = New System.Drawing.Size(74, 13)
        Me.Shutdowntime.TabIndex = 10
        Me.Shutdowntime.Text = "Shutdowntime"
        '
        'Finaloutput
        '
        Me.Finaloutput.AutoSize = True
        Me.Finaloutput.Location = New System.Drawing.Point(493, 72)
        Me.Finaloutput.Name = "Finaloutput"
        Me.Finaloutput.Size = New System.Drawing.Size(59, 13)
        Me.Finaloutput.TabIndex = 11
        Me.Finaloutput.Text = "Finaloutput"
        '
        'Anführungszeichen
        '
        Me.Anführungszeichen.AutoSize = True
        Me.Anführungszeichen.Location = New System.Drawing.Point(493, 85)
        Me.Anführungszeichen.Name = "Anführungszeichen"
        Me.Anführungszeichen.Size = New System.Drawing.Size(12, 13)
        Me.Anführungszeichen.TabIndex = 12
        Me.Anführungszeichen.Text = """"
        '
        'btnOpenSettings
        '
        Me.btnOpenSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenSettings.Image = CType(resources.GetObject("btnOpenSettings.Image"), System.Drawing.Image)
        Me.btnOpenSettings.Location = New System.Drawing.Point(293, 382)
        Me.btnOpenSettings.Name = "btnOpenSettings"
        Me.btnOpenSettings.Size = New System.Drawing.Size(48, 38)
        Me.btnOpenSettings.TabIndex = 7
        Me.btnOpenSettings.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(360, 431)
        Me.Controls.Add(Me.Anführungszeichen)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown"
        Me.gbAction.ResumeLayout(False)
        Me.gbAction.PerformLayout()
        Me.gbTime.ResumeLayout(False)
        Me.gbTime.PerformLayout()
        Me.gbMessage.ResumeLayout(False)
        Me.gbMessage.PerformLayout()
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
    Friend WithEvents Anführungszeichen As Label
    Friend WithEvents cbxIn As ComboBox
    Friend WithEvents rbtnZeitpunkt As RadioButton
    Friend WithEvents rbtnIn As RadioButton
End Class
