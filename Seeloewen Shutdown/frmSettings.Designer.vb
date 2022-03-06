<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.lblSettings = New System.Windows.Forms.Label()
        Me.gbDefaultSettings = New System.Windows.Forms.GroupBox()
        Me.rbtnRestart = New System.Windows.Forms.RadioButton()
        Me.rbtnShutdown = New System.Windows.Forms.RadioButton()
        Me.cbxDefaultIn = New System.Windows.Forms.ComboBox()
        Me.lblDefaultAction = New System.Windows.Forms.Label()
        Me.tbDefaultTime = New System.Windows.Forms.TextBox()
        Me.lblDefaultTime = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbAppSettings = New System.Windows.Forms.GroupBox()
        Me.cbxDesign = New System.Windows.Forms.ComboBox()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gbDefaultSettings.SuspendLayout()
        Me.gbAppSettings.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSettings
        '
        Me.lblSettings.AutoSize = True
        Me.lblSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSettings.Location = New System.Drawing.Point(13, 18)
        Me.lblSettings.Name = "lblSettings"
        Me.lblSettings.Size = New System.Drawing.Size(155, 25)
        Me.lblSettings.TabIndex = 0
        Me.lblSettings.Text = "Einstellungen"
        '
        'gbDefaultSettings
        '
        Me.gbDefaultSettings.Controls.Add(Me.rbtnRestart)
        Me.gbDefaultSettings.Controls.Add(Me.rbtnShutdown)
        Me.gbDefaultSettings.Controls.Add(Me.cbxDefaultIn)
        Me.gbDefaultSettings.Controls.Add(Me.lblDefaultAction)
        Me.gbDefaultSettings.Controls.Add(Me.tbDefaultTime)
        Me.gbDefaultSettings.Controls.Add(Me.lblDefaultTime)
        Me.gbDefaultSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDefaultSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbDefaultSettings.Location = New System.Drawing.Point(18, 54)
        Me.gbDefaultSettings.Name = "gbDefaultSettings"
        Me.gbDefaultSettings.Size = New System.Drawing.Size(406, 155)
        Me.gbDefaultSettings.TabIndex = 1
        Me.gbDefaultSettings.TabStop = False
        Me.gbDefaultSettings.Text = "Standart-Einstellungen"
        '
        'rbtnRestart
        '
        Me.rbtnRestart.AutoSize = True
        Me.rbtnRestart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnRestart.ForeColor = System.Drawing.Color.Black
        Me.rbtnRestart.Location = New System.Drawing.Point(15, 76)
        Me.rbtnRestart.Name = "rbtnRestart"
        Me.rbtnRestart.Size = New System.Drawing.Size(90, 20)
        Me.rbtnRestart.TabIndex = 12
        Me.rbtnRestart.TabStop = True
        Me.rbtnRestart.Text = "Neustarten"
        Me.rbtnRestart.UseVisualStyleBackColor = True
        '
        'rbtnShutdown
        '
        Me.rbtnShutdown.AutoSize = True
        Me.rbtnShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnShutdown.ForeColor = System.Drawing.Color.Black
        Me.rbtnShutdown.Location = New System.Drawing.Point(15, 50)
        Me.rbtnShutdown.Name = "rbtnShutdown"
        Me.rbtnShutdown.Size = New System.Drawing.Size(113, 20)
        Me.rbtnShutdown.TabIndex = 11
        Me.rbtnShutdown.TabStop = True
        Me.rbtnShutdown.Text = "Herunterfahren"
        Me.rbtnShutdown.UseVisualStyleBackColor = True
        '
        'cbxDefaultIn
        '
        Me.cbxDefaultIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDefaultIn.FormattingEnabled = True
        Me.cbxDefaultIn.Items.AddRange(New Object() {"Sekunde(n)", "Minute(n)", "Stunde(n)"})
        Me.cbxDefaultIn.Location = New System.Drawing.Point(257, 108)
        Me.cbxDefaultIn.Name = "cbxDefaultIn"
        Me.cbxDefaultIn.Size = New System.Drawing.Size(137, 21)
        Me.cbxDefaultIn.TabIndex = 10
        '
        'lblDefaultAction
        '
        Me.lblDefaultAction.AutoSize = True
        Me.lblDefaultAction.ForeColor = System.Drawing.Color.Black
        Me.lblDefaultAction.Location = New System.Drawing.Point(11, 26)
        Me.lblDefaultAction.Name = "lblDefaultAction"
        Me.lblDefaultAction.Size = New System.Drawing.Size(54, 20)
        Me.lblDefaultAction.TabIndex = 7
        Me.lblDefaultAction.Text = "Aktion"
        '
        'tbDefaultTime
        '
        Me.tbDefaultTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDefaultTime.Location = New System.Drawing.Point(129, 108)
        Me.tbDefaultTime.Name = "tbDefaultTime"
        Me.tbDefaultTime.Size = New System.Drawing.Size(122, 20)
        Me.tbDefaultTime.TabIndex = 3
        '
        'lblDefaultTime
        '
        Me.lblDefaultTime.AutoSize = True
        Me.lblDefaultTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDefaultTime.ForeColor = System.Drawing.Color.Black
        Me.lblDefaultTime.Location = New System.Drawing.Point(12, 108)
        Me.lblDefaultTime.Name = "lblDefaultTime"
        Me.lblDefaultTime.Size = New System.Drawing.Size(111, 20)
        Me.lblDefaultTime.TabIndex = 2
        Me.lblDefaultTime.Text = "Ausführen in..."
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
        Me.btnClose.Location = New System.Drawing.Point(319, 18)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(105, 27)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'gbAppSettings
        '
        Me.gbAppSettings.Controls.Add(Me.cbxDesign)
        Me.gbAppSettings.Controls.Add(Me.cbxLanguage)
        Me.gbAppSettings.Controls.Add(Me.lblDesign)
        Me.gbAppSettings.Controls.Add(Me.lblLanguage)
        Me.gbAppSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbAppSettings.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbAppSettings.Location = New System.Drawing.Point(18, 215)
        Me.gbAppSettings.Name = "gbAppSettings"
        Me.gbAppSettings.Size = New System.Drawing.Size(406, 87)
        Me.gbAppSettings.TabIndex = 5
        Me.gbAppSettings.TabStop = False
        Me.gbAppSettings.Text = "App-Einstellungen"
        '
        'cbxDesign
        '
        Me.cbxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxDesign.FormattingEnabled = True
        Me.cbxDesign.Items.AddRange(New Object() {"Hell", "Dunkel"})
        Me.cbxDesign.Location = New System.Drawing.Point(90, 50)
        Me.cbxDesign.Name = "cbxDesign"
        Me.cbxDesign.Size = New System.Drawing.Size(304, 21)
        Me.cbxDesign.TabIndex = 7
        '
        'cbxLanguage
        '
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"Deutsch (German)", "English (English)"})
        Me.cbxLanguage.Location = New System.Drawing.Point(90, 25)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(304, 21)
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
        Me.lblLanguage.Size = New System.Drawing.Size(73, 20)
        Me.lblLanguage.TabIndex = 4
        Me.lblLanguage.Text = "Sprache:"
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
        Me.btnSave.Location = New System.Drawing.Point(208, 18)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(105, 27)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 312)
        Me.Controls.Add(Me.gbAppSettings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gbDefaultSettings)
        Me.Controls.Add(Me.lblSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Einstellungen"
        Me.gbDefaultSettings.ResumeLayout(False)
        Me.gbDefaultSettings.PerformLayout()
        Me.gbAppSettings.ResumeLayout(False)
        Me.gbAppSettings.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSettings As Label
    Friend WithEvents gbDefaultSettings As GroupBox
    Friend WithEvents tbDefaultTime As TextBox
    Friend WithEvents lblDefaultTime As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lblDefaultAction As Label
    Friend WithEvents cbxDefaultIn As ComboBox
    Friend WithEvents rbtnRestart As RadioButton
    Friend WithEvents rbtnShutdown As RadioButton
    Friend WithEvents gbAppSettings As GroupBox
    Friend WithEvents cbxDesign As ComboBox
    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblLanguage As Label
End Class
