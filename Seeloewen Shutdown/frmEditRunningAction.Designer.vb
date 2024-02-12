<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditRunningAction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEditRunningAction))
        Me.lblEditRunningActionDesc = New System.Windows.Forms.Label()
        Me.lblEditRunningActionHeader = New System.Windows.Forms.Label()
        Me.lblAction = New System.Windows.Forms.Label()
        Me.pnlTime = New System.Windows.Forms.Panel()
        Me.cbxRemove = New System.Windows.Forms.ComboBox()
        Me.tbRemove = New System.Windows.Forms.TextBox()
        Me.rbtnRemove = New System.Windows.Forms.RadioButton()
        Me.rbtnAdd = New System.Windows.Forms.RadioButton()
        Me.rbtnPointInTime = New System.Windows.Forms.RadioButton()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cbxAdd = New System.Windows.Forms.ComboBox()
        Me.tbAdd = New System.Windows.Forms.TextBox()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.pnlAction = New System.Windows.Forms.Panel()
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pnlTime.SuspendLayout()
        Me.pnlAction.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblEditRunningActionDesc
        '
        Me.lblEditRunningActionDesc.AutoSize = True
        Me.lblEditRunningActionDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditRunningActionDesc.Location = New System.Drawing.Point(14, 38)
        Me.lblEditRunningActionDesc.Name = "lblEditRunningActionDesc"
        Me.lblEditRunningActionDesc.Size = New System.Drawing.Size(458, 32)
        Me.lblEditRunningActionDesc.TabIndex = 7
        Me.lblEditRunningActionDesc.Text = "Not happy with the current action? You can change the action, add or remove" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "time" &
    " from the timer or set a new point in time."
        '
        'lblEditRunningActionHeader
        '
        Me.lblEditRunningActionHeader.AutoSize = True
        Me.lblEditRunningActionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEditRunningActionHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblEditRunningActionHeader.Name = "lblEditRunningActionHeader"
        Me.lblEditRunningActionHeader.Size = New System.Drawing.Size(220, 25)
        Me.lblEditRunningActionHeader.TabIndex = 6
        Me.lblEditRunningActionHeader.Text = "Edit Running Action"
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(16, 84)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(343, 24)
        Me.lblAction.TabIndex = 55
        Me.lblAction.Text = "Action                                                        "
        '
        'pnlTime
        '
        Me.pnlTime.Controls.Add(Me.cbxRemove)
        Me.pnlTime.Controls.Add(Me.tbRemove)
        Me.pnlTime.Controls.Add(Me.rbtnRemove)
        Me.pnlTime.Controls.Add(Me.rbtnAdd)
        Me.pnlTime.Controls.Add(Me.rbtnPointInTime)
        Me.pnlTime.Controls.Add(Me.dtpDate)
        Me.pnlTime.Controls.Add(Me.cbxAdd)
        Me.pnlTime.Controls.Add(Me.tbAdd)
        Me.pnlTime.Location = New System.Drawing.Point(20, 213)
        Me.pnlTime.Name = "pnlTime"
        Me.pnlTime.Size = New System.Drawing.Size(339, 98)
        Me.pnlTime.TabIndex = 58
        '
        'cbxRemove
        '
        Me.cbxRemove.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxRemove.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxRemove.FormattingEnabled = True
        Me.cbxRemove.Location = New System.Drawing.Point(199, 33)
        Me.cbxRemove.Name = "cbxRemove"
        Me.cbxRemove.Size = New System.Drawing.Size(131, 21)
        Me.cbxRemove.TabIndex = 12
        '
        'tbRemove
        '
        Me.tbRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRemove.Location = New System.Drawing.Point(123, 33)
        Me.tbRemove.Name = "tbRemove"
        Me.tbRemove.Size = New System.Drawing.Size(70, 20)
        Me.tbRemove.TabIndex = 11
        '
        'rbtnRemove
        '
        Me.rbtnRemove.AutoSize = True
        Me.rbtnRemove.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRemove.Location = New System.Drawing.Point(3, 31)
        Me.rbtnRemove.Name = "rbtnRemove"
        Me.rbtnRemove.Size = New System.Drawing.Size(98, 24)
        Me.rbtnRemove.TabIndex = 1
        Me.rbtnRemove.TabStop = True
        Me.rbtnRemove.Text = "Remove..."
        Me.rbtnRemove.UseVisualStyleBackColor = True
        '
        'rbtnAdd
        '
        Me.rbtnAdd.AutoSize = True
        Me.rbtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnAdd.Location = New System.Drawing.Point(3, 5)
        Me.rbtnAdd.Name = "rbtnAdd"
        Me.rbtnAdd.Size = New System.Drawing.Size(68, 24)
        Me.rbtnAdd.TabIndex = 0
        Me.rbtnAdd.TabStop = True
        Me.rbtnAdd.Text = "Add..."
        Me.rbtnAdd.UseVisualStyleBackColor = True
        '
        'rbtnPointInTime
        '
        Me.rbtnPointInTime.AutoSize = True
        Me.rbtnPointInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnPointInTime.ForeColor = System.Drawing.Color.Black
        Me.rbtnPointInTime.Location = New System.Drawing.Point(3, 58)
        Me.rbtnPointInTime.Name = "rbtnPointInTime"
        Me.rbtnPointInTime.Size = New System.Drawing.Size(101, 24)
        Me.rbtnPointInTime.TabIndex = 10
        Me.rbtnPointInTime.TabStop = True
        Me.rbtnPointInTime.Text = "Exact time"
        Me.rbtnPointInTime.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(123, 60)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(207, 22)
        Me.dtpDate.TabIndex = 6
        '
        'cbxAdd
        '
        Me.cbxAdd.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAdd.FormattingEnabled = True
        Me.cbxAdd.Location = New System.Drawing.Point(199, 7)
        Me.cbxAdd.Name = "cbxAdd"
        Me.cbxAdd.Size = New System.Drawing.Size(131, 21)
        Me.cbxAdd.TabIndex = 8
        '
        'tbAdd
        '
        Me.tbAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAdd.Location = New System.Drawing.Point(123, 7)
        Me.tbAdd.Name = "tbAdd"
        Me.tbAdd.Size = New System.Drawing.Size(70, 20)
        Me.tbAdd.TabIndex = 1
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(15, 185)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(347, 25)
        Me.lblTime.TabIndex = 57
        Me.lblTime.Text = "Time                                                "
        '
        'pnlAction
        '
        Me.pnlAction.Controls.Add(Me.rbtnRestart)
        Me.pnlAction.Controls.Add(Me.rbtnShutdown)
        Me.pnlAction.Location = New System.Drawing.Point(17, 111)
        Me.pnlAction.Name = "pnlAction"
        Me.pnlAction.Size = New System.Drawing.Size(141, 58)
        Me.pnlAction.TabIndex = 56
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
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(17, 319)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(157, 25)
        Me.btnCancel.TabIndex = 59
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.CausesValidation = False
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(315, 319)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(157, 25)
        Me.btnSave.TabIndex = 60
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmEditRunningAction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(488, 355)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblAction)
        Me.Controls.Add(Me.pnlTime)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.pnlAction)
        Me.Controls.Add(Me.lblEditRunningActionDesc)
        Me.Controls.Add(Me.lblEditRunningActionHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEditRunningAction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Edit Running Action"
        Me.pnlTime.ResumeLayout(False)
        Me.pnlTime.PerformLayout()
        Me.pnlAction.ResumeLayout(False)
        Me.pnlAction.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblEditRunningActionDesc As Label
    Friend WithEvents lblEditRunningActionHeader As Label
    Friend WithEvents lblAction As Label
    Friend WithEvents pnlTime As Panel
    Friend WithEvents rbtnRemove As RadioButton
    Friend WithEvents rbtnAdd As RadioButton
    Friend WithEvents rbtnPointInTime As RadioButton
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents cbxAdd As ComboBox
    Friend WithEvents tbAdd As TextBox
    Friend WithEvents lblTime As Label
    Friend WithEvents pnlAction As Panel
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents cbxRemove As ComboBox
    Friend WithEvents tbRemove As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
End Class
