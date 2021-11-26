Public Class frmUpdaterSettings
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save Settings
        If rbtnDownloadNewestUpdater.Checked = True Then
            My.Settings.Updater = "Newest"
        ElseIf rbtnUseLegacyUpdater.Checked = True Then
            My.Settings.Updater = "Legacy"
        ElseIf rbtnUseCustomUpdater.Checked = True Then
            My.Settings.Updater = "Custom"
        End If

        If rbtnCustomSettings.Checked = True Then
            My.Settings.UpdaterSettings = "Custom"
        ElseIf rbtnUseCurrentSettingsForUpdater.Checked = True Then
            My.Settings.UpdaterSettings = "Current"
        End If

        My.Settings.CustomUpdaterPath = tbCustomUpdater.Text
        My.Settings.NewestUpdaterLink = tbNewestUpdaterLink.Text

        If cbxDesign.SelectedItem = "Hell" Then
            My.Settings.CustomUpdaterDesign = "Light"
        ElseIf cbxDesign.SelectedItem = "Light" Then
            My.Settings.CustomUpdaterDesign = "Light"
        ElseIf cbxDesign.SelectedItem = "Dunkel" Then
            My.Settings.CustomUpdaterDesign = "Dark"
        ElseIf cbxDesign.SelectedItem = "Dark" Then
            My.Settings.CustomUpdaterDesign = "Dark"
        End If

        If cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.CustomUpdaterLanguage = "German"
        ElseIf cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.CustomUpdaterLanguage = "English"
        End If

        If cbSearchForBetas.Checked = True Then
            My.Settings.UpdaterBranch = "Beta"
        ElseIf cbSearchForBetas.Checked = False Then
            My.Settings.UpdaterBranch = "Release"
        End If

        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Show Dialog, that clicking "Cancel" doesn't save options
        Select Case MsgBox("Möchtest du die Updater-Einstellungen wirklich schließen ohne Änderungen zu speichern?", MsgBoxStyle.YesNo, "Einstellungen verwerfen")
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No
        End Select
    End Sub

    Private Sub btnUseDefaultUpdater_Click(sender As Object, e As EventArgs) Handles btnUseDefaultUpdater.Click
        tbNewestUpdaterLink.Text = "https://github.com/Seeloewen/Seeloewen-Shutdown-Update/blob/main/Latest%20Build/Seeloewen-Shutdown-Update.exe?raw=true"
        MsgBox("Der Link des Updaters wurde erfolgreich auf Standart zurückgesetzt.", MsgBoxStyle.Information, "Erfolgreich auf Standart zurückgesetzt")
    End Sub

    Private Sub rbtnUseCustomUpdater_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnUseCustomUpdater.CheckedChanged
        If rbtnUseCustomUpdater.Checked = True Then
            tbCustomUpdater.Enabled = True
            btnBrowseCustomUpdater.Enabled = True
        ElseIf rbtnUseCustomUpdater.Checked = False Then
            tbCustomUpdater.Enabled = False
            btnBrowseCustomUpdater.Enabled = False
        End If
    End Sub

    Private Sub rbtnDownloadNewestUpdater_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnDownloadNewestUpdater.CheckedChanged
        If rbtnDownloadNewestUpdater.Checked = True Then
            tbNewestUpdaterLink.Enabled = True
            btnUseDefaultUpdater.Enabled = True
        ElseIf rbtnDownloadNewestUpdater.Checked = False Then
            tbNewestUpdaterLink.Enabled = False
            btnUseDefaultUpdater.Enabled = False
        End If
    End Sub

    Private Sub rbtnCustomSettings_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnCustomSettings.CheckedChanged
        If rbtnCustomSettings.Checked = True Then
            lblDesign.Enabled = True
            lblLanguage.Enabled = True
            cbxDesign.Enabled = True
            cbxLanguage.Enabled = True
        ElseIf rbtnCustomSettings.Checked = False Then
            lblDesign.Enabled = False
            lblLanguage.Enabled = False
            cbxDesign.Enabled = False
            cbxLanguage.Enabled = False
        End If
    End Sub

    Private Sub frmUpdaterSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Updater = "Newest" Then
            rbtnDownloadNewestUpdater.Checked = True
            tbNewestUpdaterLink.Text = My.Settings.NewestUpdaterLink
            tbNewestUpdaterLink.Enabled = True
            btnUseDefaultUpdater.Enabled = True
        ElseIf My.Settings.Updater = "Legacy" Then
            rbtnUseLegacyUpdater.Checked = True
        ElseIf My.Settings.Updater = "Custom" Then
            rbtnUseCustomUpdater.Checked = True
            tbCustomUpdater.Text = My.Settings.CustomUpdaterPath
            tbCustomUpdater.Enabled = True
            btnBrowseCustomUpdater.Enabled = True
        End If

        If My.Settings.UpdaterSettings = "Current" Then
            rbtnUseCurrentSettingsForUpdater.Checked = True
        ElseIf My.Settings.UpdaterSettings = "Custom" Then
            rbtnCustomSettings.Checked = True
            lblLanguage.Enabled = True
            lblDesign.Enabled = True
            cbxDesign.Enabled = True
            cbxLanguage.Enabled = True
        End If

        If My.Settings.UpdaterBranch = "Release" Then
            cbSearchForBetas.Checked = False
        ElseIf My.Settings.UpdaterBranch = "Beta" Then
            cbSearchForBetas.Checked = True
        End If
    End Sub

    Private Sub btnBrowseCustomUpdater_Click(sender As Object, e As EventArgs) Handles btnBrowseCustomUpdater.Click
        If ofdCustomUpdater.ShowDialog = Windows.Forms.DialogResult.OK Then
            ofdCustomUpdater.InitialDirectory = "C:\"
            tbCustomUpdater.Text = ofdCustomUpdater.FileName
        End If
    End Sub
End Class