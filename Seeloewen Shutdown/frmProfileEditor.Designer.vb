﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileEditor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProfileEditor))
        Me.btnClose = New System.Windows.Forms.Button()
        Me.lblChooseProfile = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbxProfile = New System.Windows.Forms.ComboBox()
        Me.gbEditProfile = New System.Windows.Forms.GroupBox()
        Me.cbDelayWhenProcessRunning = New System.Windows.Forms.CheckBox()
        Me.lblIn = New System.Windows.Forms.Label()
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.cbxInTime = New System.Windows.Forms.ComboBox()
        Me.tbTimeIn = New System.Windows.Forms.TextBox()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.gbEditProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(299, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 23)
        Me.btnClose.TabIndex = 17
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'lblChooseProfile
        '
        Me.lblChooseProfile.AutoSize = True
        Me.lblChooseProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseProfile.Location = New System.Drawing.Point(9, 41)
        Me.lblChooseProfile.Name = "lblChooseProfile"
        Me.lblChooseProfile.Size = New System.Drawing.Size(212, 16)
        Me.lblChooseProfile.TabIndex = 16
        Me.lblChooseProfile.Text = "Choose the profile you want to edit:"
        '
        'btnDelete
        '
        Me.btnDelete.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDelete.FlatAppearance.BorderSize = 0
        Me.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.Location = New System.Drawing.Point(155, 260)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(14, 260)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(125, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbxProfile
        '
        Me.cbxProfile.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxProfile.FormattingEnabled = True
        Me.cbxProfile.Location = New System.Drawing.Point(12, 60)
        Me.cbxProfile.Name = "cbxProfile"
        Me.cbxProfile.Size = New System.Drawing.Size(257, 21)
        Me.cbxProfile.TabIndex = 13
        '
        'gbEditProfile
        '
        Me.gbEditProfile.Controls.Add(Me.cbDelayWhenProcessRunning)
        Me.gbEditProfile.Controls.Add(Me.lblIn)
        Me.gbEditProfile.Controls.Add(Me.rbtnRestart)
        Me.gbEditProfile.Controls.Add(Me.rbtnShutdown)
        Me.gbEditProfile.Controls.Add(Me.cbxInTime)
        Me.gbEditProfile.Controls.Add(Me.tbTimeIn)
        Me.gbEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEditProfile.Location = New System.Drawing.Point(14, 95)
        Me.gbEditProfile.Name = "gbEditProfile"
        Me.gbEditProfile.Size = New System.Drawing.Size(411, 155)
        Me.gbEditProfile.TabIndex = 12
        Me.gbEditProfile.TabStop = False
        Me.gbEditProfile.Text = "Edit profile"
        '
        'cbDelayWhenProcessRunning
        '
        Me.cbDelayWhenProcessRunning.AutoSize = True
        Me.cbDelayWhenProcessRunning.BackColor = System.Drawing.Color.Transparent
        Me.cbDelayWhenProcessRunning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDelayWhenProcessRunning.Location = New System.Drawing.Point(18, 124)
        Me.cbDelayWhenProcessRunning.Name = "cbDelayWhenProcessRunning"
        Me.cbDelayWhenProcessRunning.Size = New System.Drawing.Size(326, 20)
        Me.cbDelayWhenProcessRunning.TabIndex = 13
        Me.cbDelayWhenProcessRunning.Text = "Delay action when selected processes are running"
        Me.cbDelayWhenProcessRunning.UseVisualStyleBackColor = False
        '
        'lblIn
        '
        Me.lblIn.AutoSize = True
        Me.lblIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIn.Location = New System.Drawing.Point(14, 91)
        Me.lblIn.Name = "lblIn"
        Me.lblIn.Size = New System.Drawing.Size(35, 20)
        Me.lblIn.TabIndex = 12
        Me.lblIn.Text = "In..."
        '
        'rbtnRestart
        '
        Me.rbtnRestart.AutoSize = True
        Me.rbtnRestart.BackColor = System.Drawing.Color.Transparent
        Me.rbtnRestart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.rbtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRestart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnRestart.Location = New System.Drawing.Point(18, 57)
        Me.rbtnRestart.Name = "rbtnRestart"
        Me.rbtnRestart.Size = New System.Drawing.Size(68, 20)
        Me.rbtnRestart.TabIndex = 3
        Me.rbtnRestart.TabStop = True
        Me.rbtnRestart.Text = "Restart"
        Me.rbtnRestart.UseVisualStyleBackColor = False
        '
        'rbtnShutdown
        '
        Me.rbtnShutdown.AutoSize = True
        Me.rbtnShutdown.Checked = True
        Me.rbtnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShutdown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.rbtnShutdown.Location = New System.Drawing.Point(18, 31)
        Me.rbtnShutdown.Name = "rbtnShutdown"
        Me.rbtnShutdown.Size = New System.Drawing.Size(83, 20)
        Me.rbtnShutdown.TabIndex = 0
        Me.rbtnShutdown.TabStop = True
        Me.rbtnShutdown.Text = "Shutdown"
        Me.rbtnShutdown.UseVisualStyleBackColor = True
        '
        'cbxInTime
        '
        Me.cbxInTime.BackColor = System.Drawing.Color.Gainsboro
        Me.cbxInTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxInTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbxInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxInTime.FormattingEnabled = True
        Me.cbxInTime.Items.AddRange(New Object() {"Second(s)", "Minute(s)", "Hour(s)"})
        Me.cbxInTime.Location = New System.Drawing.Point(178, 89)
        Me.cbxInTime.Name = "cbxInTime"
        Me.cbxInTime.Size = New System.Drawing.Size(144, 24)
        Me.cbxInTime.TabIndex = 11
        '
        'tbTimeIn
        '
        Me.tbTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTimeIn.Location = New System.Drawing.Point(55, 89)
        Me.tbTimeIn.Name = "tbTimeIn"
        Me.tbTimeIn.Size = New System.Drawing.Size(117, 22)
        Me.tbTimeIn.TabIndex = 10
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(60, 432)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(100, 96)
        Me.settings.TabIndex = 18
        Me.settings.Text = ""
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(7, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(149, 25)
        Me.lblHeader.TabIndex = 20
        Me.lblHeader.Text = "Profile Editor"
        '
        'btnRename
        '
        Me.btnRename.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRename.FlatAppearance.BorderSize = 0
        Me.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.White
        Me.btnRename.Location = New System.Drawing.Point(284, 58)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(141, 23)
        Me.btnRename.TabIndex = 21
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'frmProfileEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(437, 294)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChooseProfile)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxProfile)
        Me.Controls.Add(Me.gbEditProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfileEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Editor"
        Me.gbEditProfile.ResumeLayout(False)
        Me.gbEditProfile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClose As Button
    Friend WithEvents lblChooseProfile As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbxProfile As ComboBox
    Friend WithEvents gbEditProfile As GroupBox
    Friend WithEvents settings As RichTextBox
    Friend WithEvents cbxInTime As ComboBox
    Friend WithEvents tbTimeIn As TextBox
    Friend WithEvents lblIn As Label
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents lblHeader As Label
    Friend WithEvents cbDelayWhenProcessRunning As CheckBox
    Friend WithEvents btnRename As Button
End Class
