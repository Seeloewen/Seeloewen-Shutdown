<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdaterSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdaterSettings))
        Me.lblUpdaterSettings = New System.Windows.Forms.Label()
        Me.rbtnDownloadNewestUpdater = New System.Windows.Forms.RadioButton()
        Me.rbtnUseLegacyUpdater = New System.Windows.Forms.RadioButton()
        Me.rbtnUseCustomUpdater = New System.Windows.Forms.RadioButton()
        Me.tbCustomUpdater = New System.Windows.Forms.TextBox()
        Me.tbNewestUpdaterLink = New System.Windows.Forms.TextBox()
        Me.btnUseDefaultUpdater = New System.Windows.Forms.Button()
        Me.rbtnUseCurrentSettingsForUpdater = New System.Windows.Forms.RadioButton()
        Me.rbtnCustomSettings = New System.Windows.Forms.RadioButton()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.cbxDesign = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnBrowseCustomUpdater = New System.Windows.Forms.Button()
        Me.gbUpdaterSettings = New System.Windows.Forms.GroupBox()
        Me.cbSearchForBetas = New System.Windows.Forms.CheckBox()
        Me.gbUpdater = New System.Windows.Forms.GroupBox()
        Me.ofdCustomUpdater = New System.Windows.Forms.OpenFileDialog()
        Me.gbUpdaterSettings.SuspendLayout()
        Me.gbUpdater.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUpdaterSettings
        '
        Me.lblUpdaterSettings.AutoSize = True
        Me.lblUpdaterSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdaterSettings.Location = New System.Drawing.Point(13, 13)
        Me.lblUpdaterSettings.Name = "lblUpdaterSettings"
        Me.lblUpdaterSettings.Size = New System.Drawing.Size(188, 20)
        Me.lblUpdaterSettings.TabIndex = 0
        Me.lblUpdaterSettings.Text = "Updater Einstellungen"
        '
        'rbtnDownloadNewestUpdater
        '
        Me.rbtnDownloadNewestUpdater.AutoSize = True
        Me.rbtnDownloadNewestUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnDownloadNewestUpdater.Location = New System.Drawing.Point(15, 19)
        Me.rbtnDownloadNewestUpdater.Name = "rbtnDownloadNewestUpdater"
        Me.rbtnDownloadNewestUpdater.Size = New System.Drawing.Size(373, 20)
        Me.rbtnDownloadNewestUpdater.TabIndex = 1
        Me.rbtnDownloadNewestUpdater.TabStop = True
        Me.rbtnDownloadNewestUpdater.Text = "Neueste Version des Updaters automatisch herunterladen:"
        Me.rbtnDownloadNewestUpdater.UseVisualStyleBackColor = True
        '
        'rbtnUseLegacyUpdater
        '
        Me.rbtnUseLegacyUpdater.AutoSize = True
        Me.rbtnUseLegacyUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUseLegacyUpdater.Location = New System.Drawing.Point(15, 71)
        Me.rbtnUseLegacyUpdater.Name = "rbtnUseLegacyUpdater"
        Me.rbtnUseLegacyUpdater.Size = New System.Drawing.Size(296, 20)
        Me.rbtnUseLegacyUpdater.TabIndex = 2
        Me.rbtnUseLegacyUpdater.TabStop = True
        Me.rbtnUseLegacyUpdater.Text = "Legacy-Updater verwenden (nicht empfohlen)"
        Me.rbtnUseLegacyUpdater.UseVisualStyleBackColor = True
        '
        'rbtnUseCustomUpdater
        '
        Me.rbtnUseCustomUpdater.AutoSize = True
        Me.rbtnUseCustomUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUseCustomUpdater.Location = New System.Drawing.Point(15, 97)
        Me.rbtnUseCustomUpdater.Name = "rbtnUseCustomUpdater"
        Me.rbtnUseCustomUpdater.Size = New System.Drawing.Size(263, 20)
        Me.rbtnUseCustomUpdater.TabIndex = 3
        Me.rbtnUseCustomUpdater.TabStop = True
        Me.rbtnUseCustomUpdater.Text = "Benutzerdefinierten Updater verwenden:"
        Me.rbtnUseCustomUpdater.UseVisualStyleBackColor = True
        '
        'tbCustomUpdater
        '
        Me.tbCustomUpdater.Enabled = False
        Me.tbCustomUpdater.Location = New System.Drawing.Point(15, 123)
        Me.tbCustomUpdater.Name = "tbCustomUpdater"
        Me.tbCustomUpdater.Size = New System.Drawing.Size(354, 20)
        Me.tbCustomUpdater.TabIndex = 4
        '
        'tbNewestUpdaterLink
        '
        Me.tbNewestUpdaterLink.Enabled = False
        Me.tbNewestUpdaterLink.Location = New System.Drawing.Point(15, 45)
        Me.tbNewestUpdaterLink.Name = "tbNewestUpdaterLink"
        Me.tbNewestUpdaterLink.Size = New System.Drawing.Size(354, 20)
        Me.tbNewestUpdaterLink.TabIndex = 5
        Me.tbNewestUpdaterLink.Text = "https://github.com/Seeloewen/Seeloewen-Shutdown-Update/blob/main/Latest%20Build/S" &
    "eeloewen-Shutdown-Update.exe?raw=true"
        '
        'btnUseDefaultUpdater
        '
        Me.btnUseDefaultUpdater.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnUseDefaultUpdater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUseDefaultUpdater.Enabled = False
        Me.btnUseDefaultUpdater.FlatAppearance.BorderSize = 0
        Me.btnUseDefaultUpdater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUseDefaultUpdater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUseDefaultUpdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUseDefaultUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUseDefaultUpdater.ForeColor = System.Drawing.Color.White
        Me.btnUseDefaultUpdater.Location = New System.Drawing.Point(375, 43)
        Me.btnUseDefaultUpdater.Name = "btnUseDefaultUpdater"
        Me.btnUseDefaultUpdater.Size = New System.Drawing.Size(93, 23)
        Me.btnUseDefaultUpdater.TabIndex = 6
        Me.btnUseDefaultUpdater.Text = "Standard"
        Me.btnUseDefaultUpdater.UseVisualStyleBackColor = True
        '
        'rbtnUseCurrentSettingsForUpdater
        '
        Me.rbtnUseCurrentSettingsForUpdater.AutoSize = True
        Me.rbtnUseCurrentSettingsForUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnUseCurrentSettingsForUpdater.Location = New System.Drawing.Point(15, 19)
        Me.rbtnUseCurrentSettingsForUpdater.Name = "rbtnUseCurrentSettingsForUpdater"
        Me.rbtnUseCurrentSettingsForUpdater.Size = New System.Drawing.Size(380, 20)
        Me.rbtnUseCurrentSettingsForUpdater.TabIndex = 7
        Me.rbtnUseCurrentSettingsForUpdater.TabStop = True
        Me.rbtnUseCurrentSettingsForUpdater.Text = "Aktuelle Einstellungen der App für den Updater übernehmen"
        Me.rbtnUseCurrentSettingsForUpdater.UseVisualStyleBackColor = True
        '
        'rbtnCustomSettings
        '
        Me.rbtnCustomSettings.AutoSize = True
        Me.rbtnCustomSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtnCustomSettings.Location = New System.Drawing.Point(15, 45)
        Me.rbtnCustomSettings.Name = "rbtnCustomSettings"
        Me.rbtnCustomSettings.Size = New System.Drawing.Size(218, 20)
        Me.rbtnCustomSettings.TabIndex = 8
        Me.rbtnCustomSettings.TabStop = True
        Me.rbtnCustomSettings.Text = "Benutzerdefinierte Einstellungen:"
        Me.rbtnCustomSettings.UseVisualStyleBackColor = True
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Enabled = False
        Me.lblDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesign.Location = New System.Drawing.Point(34, 99)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(50, 16)
        Me.lblDesign.TabIndex = 9
        Me.lblDesign.Text = "Design"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Enabled = False
        Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.Location = New System.Drawing.Point(34, 72)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(58, 16)
        Me.lblLanguage.TabIndex = 10
        Me.lblLanguage.Text = "Sprache"
        '
        'cbxLanguage
        '
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.Enabled = False
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"Deutsch (German)", "English (English)"})
        Me.cbxLanguage.Location = New System.Drawing.Point(99, 71)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(145, 21)
        Me.cbxLanguage.TabIndex = 12
        '
        'cbxDesign
        '
        Me.cbxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDesign.Enabled = False
        Me.cbxDesign.FormattingEnabled = True
        Me.cbxDesign.Items.AddRange(New Object() {"Hell", "Dunkel"})
        Me.cbxDesign.Location = New System.Drawing.Point(99, 98)
        Me.cbxDesign.Name = "cbxDesign"
        Me.cbxDesign.Size = New System.Drawing.Size(145, 21)
        Me.cbxDesign.TabIndex = 13
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(17, 371)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(237, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Speichern"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(260, 371)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(244, 23)
        Me.btnCancel.TabIndex = 15
        Me.btnCancel.Text = "Abbrechen"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnBrowseCustomUpdater
        '
        Me.btnBrowseCustomUpdater.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnBrowseCustomUpdater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBrowseCustomUpdater.Enabled = False
        Me.btnBrowseCustomUpdater.FlatAppearance.BorderSize = 0
        Me.btnBrowseCustomUpdater.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBrowseCustomUpdater.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBrowseCustomUpdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBrowseCustomUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBrowseCustomUpdater.ForeColor = System.Drawing.Color.White
        Me.btnBrowseCustomUpdater.Location = New System.Drawing.Point(375, 121)
        Me.btnBrowseCustomUpdater.Name = "btnBrowseCustomUpdater"
        Me.btnBrowseCustomUpdater.Size = New System.Drawing.Size(95, 23)
        Me.btnBrowseCustomUpdater.TabIndex = 16
        Me.btnBrowseCustomUpdater.Text = "Durchsuchen"
        Me.btnBrowseCustomUpdater.UseVisualStyleBackColor = True
        '
        'gbUpdaterSettings
        '
        Me.gbUpdaterSettings.Controls.Add(Me.cbSearchForBetas)
        Me.gbUpdaterSettings.Controls.Add(Me.rbtnUseCurrentSettingsForUpdater)
        Me.gbUpdaterSettings.Controls.Add(Me.rbtnCustomSettings)
        Me.gbUpdaterSettings.Controls.Add(Me.cbxLanguage)
        Me.gbUpdaterSettings.Controls.Add(Me.cbxDesign)
        Me.gbUpdaterSettings.Controls.Add(Me.lblLanguage)
        Me.gbUpdaterSettings.Controls.Add(Me.lblDesign)
        Me.gbUpdaterSettings.Location = New System.Drawing.Point(17, 199)
        Me.gbUpdaterSettings.Name = "gbUpdaterSettings"
        Me.gbUpdaterSettings.Size = New System.Drawing.Size(487, 166)
        Me.gbUpdaterSettings.TabIndex = 17
        Me.gbUpdaterSettings.TabStop = False
        '
        'cbSearchForBetas
        '
        Me.cbSearchForBetas.AutoSize = True
        Me.cbSearchForBetas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSearchForBetas.Location = New System.Drawing.Point(15, 134)
        Me.cbSearchForBetas.Name = "cbSearchForBetas"
        Me.cbSearchForBetas.Size = New System.Drawing.Size(220, 20)
        Me.cbSearchForBetas.TabIndex = 14
        Me.cbSearchForBetas.Text = "Auch nach Beta Updates suchen"
        Me.cbSearchForBetas.UseVisualStyleBackColor = True
        '
        'gbUpdater
        '
        Me.gbUpdater.Controls.Add(Me.rbtnDownloadNewestUpdater)
        Me.gbUpdater.Controls.Add(Me.rbtnUseLegacyUpdater)
        Me.gbUpdater.Controls.Add(Me.btnBrowseCustomUpdater)
        Me.gbUpdater.Controls.Add(Me.rbtnUseCustomUpdater)
        Me.gbUpdater.Controls.Add(Me.btnUseDefaultUpdater)
        Me.gbUpdater.Controls.Add(Me.tbCustomUpdater)
        Me.gbUpdater.Controls.Add(Me.tbNewestUpdaterLink)
        Me.gbUpdater.Location = New System.Drawing.Point(17, 36)
        Me.gbUpdater.Name = "gbUpdater"
        Me.gbUpdater.Size = New System.Drawing.Size(487, 157)
        Me.gbUpdater.TabIndex = 18
        Me.gbUpdater.TabStop = False
        '
        'ofdCustomUpdater
        '
        Me.ofdCustomUpdater.Filter = "*.exe|"
        Me.ofdCustomUpdater.Title = "Seeloewen Shutdown Update"
        '
        'frmUpdaterSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(519, 405)
        Me.Controls.Add(Me.gbUpdater)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.lblUpdaterSettings)
        Me.Controls.Add(Me.gbUpdaterSettings)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdaterSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Updater Einstellungen"
        Me.gbUpdaterSettings.ResumeLayout(False)
        Me.gbUpdaterSettings.PerformLayout()
        Me.gbUpdater.ResumeLayout(False)
        Me.gbUpdater.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblUpdaterSettings As Label
    Friend WithEvents rbtnDownloadNewestUpdater As RadioButton
    Friend WithEvents rbtnUseLegacyUpdater As RadioButton
    Friend WithEvents rbtnUseCustomUpdater As RadioButton
    Friend WithEvents tbCustomUpdater As TextBox
    Friend WithEvents tbNewestUpdaterLink As TextBox
    Friend WithEvents btnUseDefaultUpdater As Button
    Friend WithEvents rbtnUseCurrentSettingsForUpdater As RadioButton
    Friend WithEvents rbtnCustomSettings As RadioButton
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents cbxDesign As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnBrowseCustomUpdater As Button
    Friend WithEvents gbUpdaterSettings As GroupBox
    Friend WithEvents gbUpdater As GroupBox
    Friend WithEvents cbSearchForBetas As CheckBox
    Friend WithEvents ofdCustomUpdater As OpenFileDialog
End Class
