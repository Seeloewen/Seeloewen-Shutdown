<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbAppSettings = New System.Windows.Forms.GroupBox()
        Me.cbShowCloseWarning = New System.Windows.Forms.CheckBox()
        Me.cbShowNotifications = New System.Windows.Forms.CheckBox()
        Me.cbxDesign = New System.Windows.Forms.ComboBox()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnLog = New System.Windows.Forms.Button()
        Me.gbMinimalisticView = New System.Windows.Forms.GroupBox()
        Me.cbEnableMinimalisticViewByDefault = New System.Windows.Forms.CheckBox()
        Me.gbActionHistory = New System.Windows.Forms.GroupBox()
        Me.cbEnableActionHistory = New System.Windows.Forms.CheckBox()
        Me.btnClearActionHistory = New System.Windows.Forms.Button()
        Me.gbProfiles = New System.Windows.Forms.GroupBox()
        Me.cbxDefaultProfile = New System.Windows.Forms.ComboBox()
        Me.cbLoadProfileByDefault = New System.Windows.Forms.CheckBox()
        Me.btnOpenProfileEditor = New System.Windows.Forms.Button()
        Me.cbEnableAnimations = New System.Windows.Forms.CheckBox()
        Me.gbAppSettings.SuspendLayout()
        Me.gbMinimalisticView.SuspendLayout()
        Me.gbActionHistory.SuspendLayout()
        Me.gbProfiles.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(13, 18)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(98, 25)
        Me.lblSettings.TabIndex = 0
        Me.lblSettings.Text = "Settings"
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
        Me.btnClose.Location = New System.Drawing.Point(296, 576)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(128, 27)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbAppSettings
        '
        Me.gbAppSettings.Controls.Add(Me.cbEnableAnimations)
        Me.gbAppSettings.Controls.Add(Me.cbShowCloseWarning)
        Me.gbAppSettings.Controls.Add(Me.cbShowNotifications)
        Me.gbAppSettings.Controls.Add(Me.cbxDesign)
        Me.gbAppSettings.Controls.Add(Me.cbxLanguage)
        Me.gbAppSettings.Controls.Add(Me.lblDesign)
        Me.gbAppSettings.Controls.Add(Me.lblLanguage)
        Me.gbAppSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAppSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbAppSettings.Location = New System.Drawing.Point(18, 57)
        Me.gbAppSettings.Name = "gbAppSettings"
        Me.gbAppSettings.Size = New System.Drawing.Size(406, 186)
        Me.gbAppSettings.TabIndex = 5
        Me.gbAppSettings.TabStop = False
        Me.gbAppSettings.Text = "App settings"
        '
        'cbShowCloseWarning
        '
        Me.cbShowCloseWarning.AutoSize = True
        Me.cbShowCloseWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowCloseWarning.ForeColor = System.Drawing.Color.Black
        Me.cbShowCloseWarning.Location = New System.Drawing.Point(15, 105)
        Me.cbShowCloseWarning.Name = "cbShowCloseWarning"
        Me.cbShowCloseWarning.Size = New System.Drawing.Size(379, 40)
        Me.cbShowCloseWarning.TabIndex = 9
        Me.cbShowCloseWarning.Text = "Show a warning when closing the app while an action " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "is running"
        Me.cbShowCloseWarning.UseVisualStyleBackColor = True
        '
        'cbShowNotifications
        '
        Me.cbShowNotifications.AutoSize = True
        Me.cbShowNotifications.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbShowNotifications.ForeColor = System.Drawing.Color.Black
        Me.cbShowNotifications.Location = New System.Drawing.Point(15, 80)
        Me.cbShowNotifications.Name = "cbShowNotifications"
        Me.cbShowNotifications.Size = New System.Drawing.Size(148, 22)
        Me.cbShowNotifications.TabIndex = 8
        Me.cbShowNotifications.Text = "Show notifications"
        Me.cbShowNotifications.UseVisualStyleBackColor = True
        '
        'cbxDesign
        '
        Me.cbxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDesign.FormattingEnabled = True
        Me.cbxDesign.Items.AddRange(New Object() {"Light", "Dark"})
        Me.cbxDesign.Location = New System.Drawing.Point(96, 50)
        Me.cbxDesign.Name = "cbxDesign"
        Me.cbxDesign.Size = New System.Drawing.Size(298, 21)
        Me.cbxDesign.TabIndex = 7
        '
        'cbxLanguage
        '
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"Deutsch (German)", "English (English)"})
        Me.cbxLanguage.Location = New System.Drawing.Point(96, 25)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(298, 21)
        Me.cbxLanguage.TabIndex = 6
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblDesign.Location = New System.Drawing.Point(11, 50)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(63, 20)
        Me.lblDesign.TabIndex = 5
        Me.lblDesign.Text = "Design:"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblLanguage.Location = New System.Drawing.Point(11, 26)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(85, 20)
        Me.lblLanguage.TabIndex = 4
        Me.lblLanguage.Text = "Language:"
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
        Me.btnSave.Location = New System.Drawing.Point(18, 576)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(128, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnLog
        '
        Me.btnLog.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLog.FlatAppearance.BorderSize = 0
        Me.btnLog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLog.ForeColor = System.Drawing.Color.White
        Me.btnLog.Location = New System.Drawing.Point(158, 576)
        Me.btnLog.Name = "btnLog"
        Me.btnLog.Size = New System.Drawing.Size(128, 27)
        Me.btnLog.TabIndex = 6
        Me.btnLog.Text = "Debug-Log"
        Me.btnLog.UseVisualStyleBackColor = True
        '
        'gbMinimalisticView
        '
        Me.gbMinimalisticView.Controls.Add(Me.cbEnableMinimalisticViewByDefault)
        Me.gbMinimalisticView.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMinimalisticView.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbMinimalisticView.Location = New System.Drawing.Point(18, 482)
        Me.gbMinimalisticView.Name = "gbMinimalisticView"
        Me.gbMinimalisticView.Size = New System.Drawing.Size(406, 79)
        Me.gbMinimalisticView.TabIndex = 7
        Me.gbMinimalisticView.TabStop = False
        Me.gbMinimalisticView.Text = "Minimalistic View"
        '
        'cbEnableMinimalisticViewByDefault
        '
        Me.cbEnableMinimalisticViewByDefault.AutoSize = True
        Me.cbEnableMinimalisticViewByDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnableMinimalisticViewByDefault.ForeColor = System.Drawing.Color.Black
        Me.cbEnableMinimalisticViewByDefault.Location = New System.Drawing.Point(15, 26)
        Me.cbEnableMinimalisticViewByDefault.Name = "cbEnableMinimalisticViewByDefault"
        Me.cbEnableMinimalisticViewByDefault.Size = New System.Drawing.Size(378, 40)
        Me.cbEnableMinimalisticViewByDefault.TabIndex = 0
        Me.cbEnableMinimalisticViewByDefault.Text = "Enable Minimalistic View automatically when you start" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "an action"
        Me.cbEnableMinimalisticViewByDefault.UseVisualStyleBackColor = True
        '
        'gbActionHistory
        '
        Me.gbActionHistory.Controls.Add(Me.cbEnableActionHistory)
        Me.gbActionHistory.Controls.Add(Me.btnClearActionHistory)
        Me.gbActionHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbActionHistory.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbActionHistory.Location = New System.Drawing.Point(18, 249)
        Me.gbActionHistory.Name = "gbActionHistory"
        Me.gbActionHistory.Size = New System.Drawing.Size(406, 86)
        Me.gbActionHistory.TabIndex = 8
        Me.gbActionHistory.TabStop = False
        Me.gbActionHistory.Text = "Action History"
        '
        'cbEnableActionHistory
        '
        Me.cbEnableActionHistory.AutoSize = True
        Me.cbEnableActionHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnableActionHistory.ForeColor = System.Drawing.Color.Black
        Me.cbEnableActionHistory.Location = New System.Drawing.Point(16, 56)
        Me.cbEnableActionHistory.Name = "cbEnableActionHistory"
        Me.cbEnableActionHistory.Size = New System.Drawing.Size(154, 20)
        Me.cbEnableActionHistory.TabIndex = 1
        Me.cbEnableActionHistory.Text = "Enable Action History"
        Me.cbEnableActionHistory.UseVisualStyleBackColor = True
        '
        'btnClearActionHistory
        '
        Me.btnClearActionHistory.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnClearActionHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClearActionHistory.FlatAppearance.BorderSize = 0
        Me.btnClearActionHistory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClearActionHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClearActionHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClearActionHistory.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClearActionHistory.ForeColor = System.Drawing.Color.White
        Me.btnClearActionHistory.Location = New System.Drawing.Point(16, 26)
        Me.btnClearActionHistory.Name = "btnClearActionHistory"
        Me.btnClearActionHistory.Size = New System.Drawing.Size(206, 23)
        Me.btnClearActionHistory.TabIndex = 0
        Me.btnClearActionHistory.Text = "Clear Action History"
        Me.btnClearActionHistory.UseVisualStyleBackColor = True
        '
        'gbProfiles
        '
        Me.gbProfiles.Controls.Add(Me.cbxDefaultProfile)
        Me.gbProfiles.Controls.Add(Me.cbLoadProfileByDefault)
        Me.gbProfiles.Controls.Add(Me.btnOpenProfileEditor)
        Me.gbProfiles.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProfiles.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbProfiles.Location = New System.Drawing.Point(18, 341)
        Me.gbProfiles.Name = "gbProfiles"
        Me.gbProfiles.Size = New System.Drawing.Size(406, 132)
        Me.gbProfiles.TabIndex = 9
        Me.gbProfiles.TabStop = False
        Me.gbProfiles.Text = "Profiles"
        '
        'cbxDefaultProfile
        '
        Me.cbxDefaultProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDefaultProfile.FormattingEnabled = True
        Me.cbxDefaultProfile.Location = New System.Drawing.Point(16, 90)
        Me.cbxDefaultProfile.Name = "cbxDefaultProfile"
        Me.cbxDefaultProfile.Size = New System.Drawing.Size(252, 24)
        Me.cbxDefaultProfile.TabIndex = 2
        '
        'cbLoadProfileByDefault
        '
        Me.cbLoadProfileByDefault.AutoSize = True
        Me.cbLoadProfileByDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoadProfileByDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cbLoadProfileByDefault.Location = New System.Drawing.Point(16, 63)
        Me.cbLoadProfileByDefault.Name = "cbLoadProfileByDefault"
        Me.cbLoadProfileByDefault.Size = New System.Drawing.Size(158, 20)
        Me.cbLoadProfileByDefault.TabIndex = 1
        Me.cbLoadProfileByDefault.Text = "Load profile by default"
        Me.cbLoadProfileByDefault.UseVisualStyleBackColor = True
        '
        'btnOpenProfileEditor
        '
        Me.btnOpenProfileEditor.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnOpenProfileEditor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOpenProfileEditor.FlatAppearance.BorderSize = 0
        Me.btnOpenProfileEditor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOpenProfileEditor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOpenProfileEditor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOpenProfileEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenProfileEditor.ForeColor = System.Drawing.Color.White
        Me.btnOpenProfileEditor.Location = New System.Drawing.Point(15, 25)
        Me.btnOpenProfileEditor.Name = "btnOpenProfileEditor"
        Me.btnOpenProfileEditor.Size = New System.Drawing.Size(207, 23)
        Me.btnOpenProfileEditor.TabIndex = 0
        Me.btnOpenProfileEditor.Text = "Open the Profile Editor"
        Me.btnOpenProfileEditor.UseVisualStyleBackColor = True
        '
        'cbEnableAnimations
        '
        Me.cbEnableAnimations.AutoSize = True
        Me.cbEnableAnimations.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEnableAnimations.ForeColor = System.Drawing.Color.Black
        Me.cbEnableAnimations.Location = New System.Drawing.Point(15, 151)
        Me.cbEnableAnimations.Name = "cbEnableAnimations"
        Me.cbEnableAnimations.Size = New System.Drawing.Size(149, 22)
        Me.cbEnableAnimations.TabIndex = 10
        Me.cbEnableAnimations.Text = "Enable Animations"
        Me.cbEnableAnimations.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 619)
        Me.Controls.Add(Me.gbProfiles)
        Me.Controls.Add(Me.gbActionHistory)
        Me.Controls.Add(Me.gbMinimalisticView)
        Me.Controls.Add(Me.btnLog)
        Me.Controls.Add(Me.gbAppSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.gbAppSettings.ResumeLayout(False)
        Me.gbAppSettings.PerformLayout()
        Me.gbMinimalisticView.ResumeLayout(False)
        Me.gbMinimalisticView.PerformLayout()
        Me.gbActionHistory.ResumeLayout(False)
        Me.gbActionHistory.PerformLayout()
        Me.gbProfiles.ResumeLayout(False)
        Me.gbProfiles.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSettings As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents gbAppSettings As GroupBox
    Friend WithEvents cbxDesign As ComboBox
    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents btnLog As Button
    Friend WithEvents cbShowNotifications As CheckBox
    Friend WithEvents gbMinimalisticView As GroupBox
    Friend WithEvents cbEnableMinimalisticViewByDefault As CheckBox
    Friend WithEvents gbActionHistory As GroupBox
    Friend WithEvents gbProfiles As GroupBox
    Friend WithEvents btnOpenProfileEditor As Button
    Friend WithEvents cbEnableActionHistory As CheckBox
    Friend WithEvents btnClearActionHistory As Button
    Friend WithEvents cbxDefaultProfile As ComboBox
    Friend WithEvents cbLoadProfileByDefault As CheckBox
    Friend WithEvents cbShowCloseWarning As CheckBox
    Friend WithEvents cbEnableAnimations As CheckBox
End Class
