Imports System.Environment
Imports System.IO

Public Class frmSettings

    '-- Attributes --

    Dim clearMsgBoxText As String
    Dim clearMsgBoxHeader As String
    Dim disableMsgBoxText As String
    Dim disableMsgBoxHeader As String
    Dim profileDirectory As String = frmMain.profileDirectory
    Dim profileList As String()
    Dim settingsArray As String()
    Dim appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public showMessage As Boolean = True

    '-- Event handlers --
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get profiles and load user preferences
        GetProfiles(profileDirectory)
        LoadSettings()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check if settings file exists. If not, create one.
        If My.Computer.FileSystem.FileExists(frmMain.settingsFile) Then
            SaveSettings(frmMain.settingsFile)
        Else
            My.Computer.FileSystem.WriteAllText(frmMain.settingsFile, "", False)
            SaveSettings(frmMain.settingsFile)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close current window
        Close()
    End Sub
    Private Sub btnClearActionHistory_Click(sender As Object, e As EventArgs) Handles btnClearActionHistory.Click
        'Clear the action history
        SetMessageboxLanguage()
        ShowClearHistoryMsgBox()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        'Show the log
        frmLog.Show()
    End Sub

    Private Sub btnOpenProfileManager_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        'Show the profile editor
        frmProfileEditor.ShowDialog()
    End Sub
    Private Sub cbEnableActionHistory_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnableActionHistory.CheckedChanged
        'Set messagebox text depending on language
        If frmMain.language = "German" Then
            disableMsgBoxHeader = "Aktionsverlauf deaktivieren"
            disableMsgBoxText = "Bist du dir sicher, dass du den Aktionsverlauf deaktivieren möchtest? Dadurch wird der aktuelle Verlauf gelöscht."
        ElseIf frmMain.language = "English" Then
            disableMsgBoxHeader = "Disble Action History"
            disableMsgBoxText = "Are you sure that you want to disable the Action History? This will delete your current history."
        End If

        'Show messagebox to warn user that disabling action history deletes the file
        If cbEnableActionHistory.Checked = False Then
            Select Case MsgBox(disableMsgBoxText, vbQuestion + vbYesNo, disableMsgBoxHeader)
                Case Windows.Forms.DialogResult.No
                    cbEnableActionHistory.Checked = True
            End Select
        End If
    End Sub

    Private Sub cbLoadProfileByDefault_CheckedChanged(sender As Object, e As EventArgs) Handles cbLoadProfileByDefault.CheckedChanged
        'Toggle default profile combobox
        If cbLoadProfileByDefault.Checked Then
            cbxDefaultProfile.Enabled = True
        Else
            cbxDefaultProfile.Enabled = False
        End If
    End Sub

    '-- Custom methods --

    Public Sub SaveSettings(path As String)
        'Save the settings into the settings array
        Try
            frmMain.WriteToLog("Saving settings...", "Info")
            ResetSettings(path)

            'Load settings into array
            settingsArray = frmMain.SettingsFilePreset.Lines

            'Set current version number in settings file
            settingsArray(1) = String.Format("Version={0}", frmMain.settingsVersion.ToString)
            frmMain.WriteToLog(String.Format("Set new version number to {0}", frmMain.settingsVersion.ToString), "Info")

            'Save App Settings
            If cbxLanguage.SelectedItem = "English (English)" Then
                My.Settings.Language = "English"
            ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
                My.Settings.Language = "German"
            ElseIf cbxLanguage.SelectedItem = "System Default" Then
                My.Settings.Language = "System Default"
            ElseIf cbxLanguage.SelectedItem = "Systemstandard" Then
                My.Settings.Language = "System Default"
            End If
            settingsArray(4) = String.Format("Language={0}", My.Settings.Language)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(4)), "Info")
            frmMain.DetermineLanguage()

            If cbxDesign.SelectedItem = "Light" Then
                My.Settings.Design = "Light"
            ElseIf cbxDesign.SelectedItem = "Hell" Then
                My.Settings.Design = "Light"
            ElseIf cbxDesign.SelectedItem = "Dunkel" Then
                My.Settings.Design = "Dark"
            ElseIf cbxDesign.SelectedItem = "Dark" Then
                My.Settings.Design = "Dark"
            ElseIf cbxDesign.SelectedItem = "System Default" Then
                My.Settings.Design = "System Default"
            ElseIf cbxDesign.SelectedItem = "Systemstandard" Then
                My.Settings.Design = "System Default"
            End If
            settingsArray(5) = String.Format("Design={0}", My.Settings.Design)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(5)), "Info")
            frmMain.DetermineDesign()

            If cbShowNotifications.Checked Then
                My.Settings.ShowNotifications = True
            Else
                My.Settings.ShowNotifications = False
            End If
            settingsArray(6) = String.Format("ShowNotifications={0}", My.Settings.ShowNotifications.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(6)), "Info")

            If cbShowCloseWarning.Checked Then
                My.Settings.ShowCloseWarning = True
            Else
                My.Settings.ShowCloseWarning = False
            End If
            settingsArray(7) = String.Format("ShowCloseWarning={0}", My.Settings.ShowCloseWarning.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(7)), "Info")

            If cbEnableAnimations.Checked Then
                My.Settings.EnableAnimations = True
            Else
                My.Settings.EnableAnimations = False
            End If
            settingsArray(8) = String.Format("EnableAnimations={0}", My.Settings.EnableAnimations.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(8)), "Info")

            'Save Action History settings
            If cbEnableActionHistory.Checked Then
                My.Settings.EnableActionHistory = True
            Else
                My.Settings.EnableActionHistory = False
                If My.Computer.FileSystem.FileExists(frmMain.actionHistoryFile) = False Then
                    My.Computer.FileSystem.WriteAllText(frmMain.actionHistoryFile, "", False)
                    frmActionHistory.lvActionHistory.Clear()
                    frmMain.WriteToLog("Cleared Action History", "Info")
                End If
            End If
            settingsArray(11) = String.Format("EnableActionHistory={0}", My.Settings.EnableActionHistory.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(11)), "Info")

            'Save Default Profile settings
            If cbLoadProfileByDefault.Checked Then
                My.Settings.LoadProfileByDefault = True
            Else
                My.Settings.LoadProfileByDefault = False
            End If
            settingsArray(14) = String.Format("LoadProfileByDefault={0}", My.Settings.LoadProfileByDefault.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(14)), "Info")

            My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem
            settingsArray(15) = String.Format("DefaultProfile={0}", My.Settings.DefaultProfile)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(15)), "Info")

            'Save Minimalistic View settings
            If cbEnableMinimalisticViewByDefault.Checked Then
                My.Settings.EnableMinimalisticView = True
            Else
                My.Settings.EnableMinimalisticView = False
            End If
            settingsArray(18) = String.Format("EnableMinimalisticView={0}", My.Settings.EnableMinimalisticView.ToString)
            frmMain.WriteToLog(String.Format("Saved setting {0}", settingsArray(18)), "Info")

            File.WriteAllLines(path, settingsArray)

            'Show a message that confirms that all settings have been saved
            If showMessage = True Then
                If frmMain.language = "German" Then
                    frmMain.ShowNotification("Gespeichert! Du musst die Software möglicherweise neustarten.")
                ElseIf frmMain.language = "English" Then
                    frmMain.ShowNotification("Saved! You may need to restart the software.")
                End If
            End If
            showMessage = True

            Close()
        Catch ex As Exception
            If frmMain.language = "German" Then
                MsgBox(String.Format("Speichern der Einstellungen ist fehlgeschlagen. {0}", ex.Message, MsgBoxStyle.Critical, "Fehler"))
            ElseIf frmMain.language = "English" Then
                MsgBox(String.Format("Saving settings failed. {0}", ex.Message, MsgBoxStyle.Critical, "Error"))
            End If

            frmMain.WriteToLog(String.Format("Saving settings failed: {0}", ex.Message), "Error")
        End Try
    End Sub

    Public Sub ResetSettings(path)
        'Reset settings to default and write to file.
        settingsArray = frmMain.SettingsFilePreset.Lines
        File.WriteAllLines(path, settingsArray)
    End Sub

    Private Sub LoadSettings()
        'Translations
        If frmMain.language = "German" Then

            'Initialize comboboxes if language german is selected
            cbxDesign.Items.Add("Hell")
            cbxDesign.Items.Add("Dunkel")
            cbxDesign.Items.Remove("Light")
            cbxDesign.Items.Remove("Dark")
            cbxDesign.Items.Remove("System Default")
            cbxDesign.Items.Add("Systemstandard")
            cbxLanguage.Items.Remove("System Default")
            cbxLanguage.Items.Add("Systemstandard")
            cbxLanguage.SelectedItem = "Deutsch (German)"

            'Change text to german translation
            Text = "Einstellungen"
            lblSettings.Text = "Einstellungen"
            gbAppSettings.Text = "App-Einstellungen"
            lblLanguage.Text = "Sprache:"
            btnSave.Text = "Speichern"
            btnClose.Text = "Schließen"
            cbEnableMinimalisticViewByDefault.Text = "Aktiviere die Minimalistische Ansicht automatisch," + vbNewLine + "wenn du eine Aktion startest."
            cbShowNotifications.Text = "Benachrichtigungen zeigen"
            gbMinimalisticView.Text = "Minimalistische Ansicht-Einstellungen"
            gbActionHistory.Text = "Aktionsverlauf"
            btnClearActionHistory.Text = "Aktionsverlauf leeren"
            cbEnableActionHistory.Text = "Aktionsverlauf aktivieren"
            gbProfiles.Text = "Profile"
            btnOpenProfileEditor.Text = "Profil-Editor öffnen"
            cbLoadProfileByDefault.Text = "Profil standartmäßig laden"
            cbShowCloseWarning.Text = "Warnung anzeigen, wenn App bei laufender Aktion " + vbNewLine + "geschlossen wird"
            cbEnableAnimations.Text = "Animationen aktivieren"
        ElseIf frmMain.language = "English" Then
            cbxLanguage.SelectedItem = "English (English)"
        End If

        If My.Settings.Language = "System Default" Then
            If frmMain.language = "German" Then
                cbxLanguage.SelectedItem = "Systemstandard"
            ElseIf frmMain.language = "English" Then
                cbxLanguage.SelectedItem = "System Default"
            End If
        End If

        'Design
        If frmMain.design = "Light" Then

            'Initialize Design combobox if Darkmode is selected
            If frmMain.language = "German" Then
                cbxDesign.SelectedItem = "Hell"
            ElseIf frmMain.language = "English" Then
                cbxDesign.SelectedItem = "Light"
            End If

        ElseIf frmMain.design = "Dark" Then

            'Initialize Design combobox if Darkmode is selected
            If frmMain.language = "German" Then
                cbxDesign.SelectedItem = "Dunkel"
            ElseIf frmMain.language = "English" Then
                cbxDesign.SelectedItem = "Dark"
            End If

            'Change window to Darkmode
            BackColor = Color.FromArgb(41, 41, 41)
            lblSettings.ForeColor = Color.White
            lblLanguage.ForeColor = Color.White
            lblDesign.ForeColor = Color.White
            gbAppSettings.ForeColor = Color.White
            cbShowNotifications.ForeColor = Color.White
            cbEnableMinimalisticViewByDefault.ForeColor = Color.White
            gbMinimalisticView.ForeColor = Color.White
            gbActionHistory.ForeColor = Color.White
            cbEnableActionHistory.ForeColor = Color.White
            gbProfiles.ForeColor = Color.White
            cbLoadProfileByDefault.ForeColor = Color.White
            cbxLanguage.ForeColor = Color.White
            cbxLanguage.BackColor = Color.Gray
            cbxDesign.ForeColor = Color.White
            cbxDesign.BackColor = Color.Gray
            cbxDefaultProfile.ForeColor = Color.White
            cbxDefaultProfile.BackColor = Color.Gray
            cbShowCloseWarning.ForeColor = Color.White
            cbEnableAnimations.ForeColor = Color.White
        End If

        If My.Settings.Design = "System Default" Then
            If frmMain.language = "German" Then
                cbxDesign.SelectedItem = "Systemstandard"
            ElseIf frmMain.language = "English" Then
                cbxDesign.SelectedItem = "System Default"
            End If
        End If

        'Load Notifications
        If My.Settings.ShowNotifications = True Then
            cbShowNotifications.Checked = True
        Else
            cbShowNotifications.Checked = False
        End If

        'Load Close Warning
        If My.Settings.ShowCloseWarning = True Then
            cbShowCloseWarning.Checked = True
        Else
            cbShowCloseWarning.Checked = False
        End If

        'Load Animations
        If My.Settings.EnableAnimations = True Then
            cbEnableAnimations.Checked = True
        Else
            cbEnableAnimations.Checked = False
        End If

        'Load Action History
        If My.Settings.EnableActionHistory = True Then
            cbEnableActionHistory.Checked = True
        Else
            cbEnableActionHistory.Checked = False
        End If

        'Load Default Profile
        If My.Settings.LoadProfileByDefault = True Then
            cbLoadProfileByDefault.Checked = True
        Else
            cbLoadProfileByDefault.Checked = False
        End If
        cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile

        'Load Minimalistic View
        If My.Settings.EnableMinimalisticView = True Then
            cbEnableMinimalisticViewByDefault.Checked = True
        Else
            cbEnableMinimalisticViewByDefault.Checked = False
        End If
    End Sub

    Private Sub SetMessageboxLanguage()
        'Change text of the messagebox based on the language
        If frmMain.language = "German" Then
            clearMsgBoxHeader = "Liste leeren"
            clearMsgBoxText = "Bist du dir sicher, dass du die Liste leeren möchtest?"
        ElseIf frmMain.language = "English" Then
            clearMsgBoxHeader = "Clear list"
            clearMsgBoxText = "Are you sure that you want to clear the list?"
        End If
    End Sub

    Private Sub ShowClearHistoryMsgBox()
        'Show messagebox, clicking "yes" will result in the Action History file being cleared
        Select Case MsgBox(clearMsgBoxText, vbQuestion + vbYesNo, clearMsgBoxHeader)
            Case Windows.Forms.DialogResult.Yes
                frmActionHistory.lvActionHistory.Clear()
                My.Computer.FileSystem.WriteAllText(frmMain.actionHistoryFile, "", False)
                frmMain.WriteToLog("Cleared Action History", "Info")
        End Select
    End Sub

    Private Sub GetProfiles(path As String)
        'Get all profile files in the profile directory and load them into the combobox
        If path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(path)

        Try
            For Each Profile As String In profileList
                If Directory.Exists(Profile) Then
                    GetProfiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.profileDirectory, "").Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    '-- Button designs --

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSave.MouseDown
        btnSave.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSave.MouseUp
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLog_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLog.MouseDown
        btnLog.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnLog_MouseEnter(sender As Object, e As EventArgs) Handles btnLog.MouseEnter
        btnLog.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnLog_MouseLeave(sender As Object, e As EventArgs) Handles btnLog.MouseLeave
        btnLog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLog_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLog.MouseUp
        btnLog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClearActionHistory_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClearActionHistory.MouseDown
        btnClearActionHistory.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClearActionHistory_MouseEnter(sender As Object, e As EventArgs) Handles btnClearActionHistory.MouseEnter
        btnClearActionHistory.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClearActionHistory_MouseLeave(sender As Object, e As EventArgs) Handles btnClearActionHistory.MouseLeave
        btnClearActionHistory.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClearActionHistory_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClearActionHistory.MouseUp
        btnClearActionHistory.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOpenProfileEditor_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpenProfileEditor.MouseDown
        btnOpenProfileEditor.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOpenProfileEditor_MouseEnter(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.MouseEnter
        btnOpenProfileEditor.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOpenProfileEditor_MouseLeave(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.MouseLeave
        btnOpenProfileEditor.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOpenProfileEditor_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenProfileEditor.MouseUp
        btnOpenProfileEditor.BackgroundImage = My.Resources.button
    End Sub
End Class