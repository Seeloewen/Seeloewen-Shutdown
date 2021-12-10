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
        If My.Settings.Language = "German" Then
            Select Case MsgBox("Möchtest du die Updater-Einstellungen wirklich schließen ohne Änderungen zu speichern?", MsgBoxStyle.YesNo, "Einstellungen verwerfen")
                Case Windows.Forms.DialogResult.Yes
                    Me.Close()
                Case Windows.Forms.DialogResult.No
            End Select
        ElseIf My.Settings.Language = "English" Then
            Select Case MsgBox("Are you sure you want to close updater settings without saving?", MsgBoxStyle.YesNo, "Discard settings")
                Case Windows.Forms.DialogResult.Yes
                    Me.Close()
                Case Windows.Forms.DialogResult.No
            End Select
        End If
    End Sub

    Private Sub btnUseDefaultUpdater_Click(sender As Object, e As EventArgs) Handles btnUseDefaultUpdater.Click
        tbNewestUpdaterLink.Text = "https://github.com/Seeloewen/Seeloewen-Shutdown-Update/blob/main/Latest%20Build/Seeloewen-Shutdown-Update.exe?raw=true"
        If My.Settings.Language = "German" Then
            MsgBox("Der Link des Updaters wurde erfolgreich auf Standard zurückgesetzt.", MsgBoxStyle.Information, "Erfolgreich auf Standart zurückgesetzt")
        ElseIf My.Settings.Language = "English" Then
            MsgBox("The updater link was successfully reset to default.", MsgBoxStyle.Information, "Successfully reset to default")
        End If
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
        If My.Settings.Language = "English" Then
            lblUpdaterSettings.Text = "Updater Settings"
            Text = "Updater Settings"
            rbtnDownloadNewestUpdater.Text = "Automatically download the newest version of the updater:"
            rbtnUseLegacyUpdater.Text = "Use legacy updater (not recommended)"
            rbtnUseCustomUpdater.Text = "Use custom updater:"
            rbtnUseCurrentSettingsForUpdater.Text = "Use current app settings for the updater"
            rbtnCustomSettings.Text = "Custom settings:"
            lblLanguage.Text = "Language"
            cbSearchForBetas.Text = "Also search for beta updates"
            btnUseDefaultUpdater.Text = "Default"
            btnBrowseCustomUpdater.Text = "Browse"
            btnSave.Text = "Save"
            btnCancel.Text = "Cancel"
            cbxDesign.Items.Remove("Dunkel")
            cbxDesign.Items.Remove("Hell")
            cbxDesign.Items.Add("Dark")
            cbxDesign.Items.Add("Light")
            If My.Settings.CustomUpdaterDesign = "Dark" Then
                cbxDesign.SelectedItem = "Dark"
            ElseIf My.Settings.CustomUpdaterDesign = "Light" Then
                cbxDesign.SelectedItem = "Light"
            End If
        ElseIf My.Settings.Language = "German" Then
            If My.Settings.CustomUpdaterDesign = "Dark" Then
                cbxDesign.SelectedItem = "Dunkel"
            ElseIf My.Settings.CustomUpdaterDesign = "Light" Then
                cbxDesign.SelectedItem = "Hell"
            End If
        End If

        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            gbUpdater.ForeColor = Color.White
            gbUpdaterSettings.ForeColor = Color.White
            lblUpdaterSettings.ForeColor = Color.White
            lblLanguage.ForeColor = Color.White
            lblDesign.ForeColor = Color.White
            rbtnDownloadNewestUpdater.ForeColor = Color.White
            rbtnUseLegacyUpdater.ForeColor = Color.White
            rbtnUseCustomUpdater.ForeColor = Color.White
            rbtnUseCurrentSettingsForUpdater.ForeColor = Color.White
            rbtnCustomSettings.ForeColor = Color.White
            cbSearchForBetas.ForeColor = Color.White
            tbCustomUpdater.BackColor = Color.Gray
            tbNewestUpdaterLink.BackColor = Color.Gray
            tbCustomUpdater.ForeColor = Color.White
            tbNewestUpdaterLink.ForeColor = Color.White
        End If

        If My.Settings.CustomUpdaterLanguage = "German" Then
            cbxLanguage.SelectedItem = "Deutsch (German)"
        ElseIf My.Settings.CustomUpdaterLanguage = "English" Then
            cbxLanguage.SelectedItem = "English (English)"
        End If

        If My.Settings.Updater = "Newest" Then
            rbtnDownloadNewestUpdater.Checked = True
            tbNewestUpdaterLink.Enabled = True
            btnUseDefaultUpdater.Enabled = True
        ElseIf My.Settings.Updater = "Legacy" Then
            rbtnUseLegacyUpdater.Checked = True
        ElseIf My.Settings.Updater = "Custom" Then
            rbtnUseCustomUpdater.Checked = True
            tbCustomUpdater.Enabled = True
            btnBrowseCustomUpdater.Enabled = True
        End If

        tbNewestUpdaterLink.Text = My.Settings.NewestUpdaterLink
        tbCustomUpdater.Text = My.Settings.CustomUpdaterPath

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

    Private Sub rbtnUseLegacyUpdater_Click(sender As Object, e As EventArgs) Handles rbtnUseLegacyUpdater.Click
        If My.Settings.Language = "German" Then
            MsgBox("Warnung: Der legacy Updater unterstützt neuere Funktionen wie Changelog-Übersetzungen und Beta-Updates nicht und funktioniert möglicherweise gar nicht.", MsgBoxStyle.Exclamation, "Warnung")
        ElseIf My.Settings.Language = "English" Then
            MsgBox("Warning: The legacy updater does not support newer updater features like changelog translations and beta updates and may not even work at all.", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub btnUseDefaultUpdater_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUseDefaultUpdater.MouseDown
        btnUseDefaultUpdater.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnUseDefaultUpdater_MouseHover(sender As Object, e As EventArgs) Handles btnUseDefaultUpdater.MouseHover
        btnUseDefaultUpdater.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnUseDefaultUpdater_MouseLeave(sender As Object, e As EventArgs) Handles btnUseDefaultUpdater.MouseLeave
        btnUseDefaultUpdater.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnUseDefaultUpdater_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUseDefaultUpdater.MouseUp
        btnUseDefaultUpdater.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnBrowseCustomUpdater_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBrowseCustomUpdater.MouseDown
        btnBrowseCustomUpdater.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnBrowseCustomUpdater_MouseHover(sender As Object, e As EventArgs) Handles btnBrowseCustomUpdater.MouseHover
        btnBrowseCustomUpdater.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnBrowseCustomUpdater_MouseLeave(sender As Object, e As EventArgs) Handles btnBrowseCustomUpdater.MouseLeave
        btnBrowseCustomUpdater.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnBrowseCustomUpdater_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBrowseCustomUpdater.MouseUp
        btnBrowseCustomUpdater.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSave.MouseDown
        btnSave.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSave.MouseUp
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnCancel_MouseHover(sender As Object, e As EventArgs) Handles btnCancel.MouseHover
        btnCancel.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.BackgroundImage = My.Resources.button
    End Sub
End Class