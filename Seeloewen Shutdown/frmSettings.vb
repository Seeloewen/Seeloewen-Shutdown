Imports System.Environment
Imports System.IO

Public Class frmSettings

    Dim ClearMsgBoxText As String
    Dim ClearMsgBoxHeader As String
    Dim DisableMsgBoxText As String
    Dim DisableMsgBoxHeader As String
    Dim ProfileDirectory As String = frmMain.ProfileDirectory
    Dim ProfileList As String()
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)

    '-- Event handlers --
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetProfiles(ProfileDirectory)
        LoadSettings()
    End Sub

    Private Sub tbDefaultTime_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSettings()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
    Private Sub btnClearActionHistory_Click(sender As Object, e As EventArgs) Handles btnClearActionHistory.Click
        SetMessageboxLanguage()
        ShowClearHistoryMsgBox()
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        frmLog.Show()
    End Sub

    Private Sub btnOpenProfileManager_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        frmProfileEditor.ShowDialog()
    End Sub
    Private Sub cbEnableActionHistory_CheckedChanged(sender As Object, e As EventArgs) Handles cbEnableActionHistory.CheckedChanged
        'Set messagebox text depending on language
        If My.Settings.Language = "German" Then
            DisableMsgBoxHeader = "Aktionsverlauf deaktivieren"
            DisableMsgBoxText = "Bist du dir sicher, dass du den Aktionsverlauf deaktivieren möchtest? Dadurch wird der aktuelle Verlauf gelöscht."
        ElseIf My.Settings.Language = "English" Then
            DisableMsgBoxHeader = "Disble Action History"
            DisableMsgBoxText = "Are you sure that you want to disable the Action History? This will delete your current history."
        End If

        'Show messagebox to warn user that disabling action history deletes the file
        If cbEnableActionHistory.Checked = False Then
            Select Case MsgBox(DisableMsgBoxText, MsgBoxStyle.YesNo, DisableMsgBoxHeader)
                Case Windows.Forms.DialogResult.No
                    cbEnableActionHistory.Checked = False
            End Select
        End If
    End Sub

    Private Sub cbLoadProfileByDefault_CheckedChanged(sender As Object, e As EventArgs) Handles cbLoadProfileByDefault.CheckedChanged
        If cbLoadProfileByDefault.Checked Then
            cbxDefaultProfile.Enabled = True
        Else
            cbxDefaultProfile.Enabled = False
        End If
    End Sub

    '-- Custom methods --

    Private Sub SaveSettings()
        'Save Language
        If cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.Language = "English"
            Close()
        ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.Language = "German"
            Close()
        End If
        frmMain.WriteToLog("Saved Language to settings: " + My.Settings.Language, "Info")

        'Save Design
        If cbxDesign.SelectedItem = "Light" Then
            My.Settings.Design = "Light"
        ElseIf cbxDesign.SelectedItem = "Hell" Then
            My.Settings.Design = "Light"
        ElseIf cbxDesign.SelectedItem = "Dunkel" Then
            My.Settings.Design = "Dark"
        ElseIf cbxDesign.SelectedItem = "Dark" Then
            My.Settings.Design = "Dark"
        End If
        frmMain.WriteToLog("Saved Design to settings: " + My.Settings.Design, "Info")

        'Save Notifications
        If cbShowNotifications.Checked Then
            My.Settings.ShowNotifications = True
        Else
            My.Settings.ShowNotifications = False
        End If

        'Save Action History
        If cbEnableActionHistory.Checked Then
            My.Settings.EnableActionHistory = True
        Else
            My.Settings.EnableActionHistory = False
            If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/ActionHistory.txt") = False Then
                My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/ActionHistory.txt", "", False)
                frmActionHistory.lvActionHistory.Clear()
                frmMain.WriteToLog("Cleared Action History", "Info")
            End If
        End If

        'Save Default Profile
        If cbLoadProfileByDefault.Checked Then
            My.Settings.LoadProfileByDefault = True
        Else
            My.Settings.LoadProfileByDefault = False
        End If
        My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem

        'Save Minimalistic View
        If cbEnableMinimalisticViewByDefault.Checked Then
            My.Settings.EnableMinimalisticView = True
        Else
            My.Settings.EnableMinimalisticView = False
        End If

        'Show a message that confirms that all settings have been saved
        If My.Settings.Language = "German" Then
            frmMain.ShowNotification("Gespeichert! Du musst die Software möglicherweise neustarten.")
        ElseIf My.Settings.Language = "English" Then
            frmMain.ShowNotification("Saved! You may need to restart the software.")
        End If
        Close()
    End Sub

    Private Sub LoadSettings()
        'Translations
        If My.Settings.Language = "German" Then

            'Initialize comboboxes if language german is selected
            cbxDesign.Items.Add("Hell")
            cbxDesign.Items.Add("Dunkel")
            cbxDesign.Items.Remove("Light")
            cbxDesign.Items.Remove("Dark")
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

        ElseIf My.Settings.Language = "English" Then
            cbxLanguage.SelectedItem = "English (English)"
        End If

        'Design
        If My.Settings.Design = "Light" Then

            'Initialize Design combobox if Darkmode is selected
            If My.Settings.Language = "German" Then
                cbxDesign.SelectedItem = "Hell"
            ElseIf My.Settings.Language = "English" Then
                cbxDesign.SelectedItem = "Light"
            End If

        ElseIf My.Settings.Design = "Dark" Then

            'Initialize Design combobox if Darkmode is selected
            If My.Settings.Language = "German" Then
                cbxDesign.SelectedItem = "Dunkel"
            ElseIf My.Settings.Language = "English" Then
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
        End If

        'Load Notifications
        If My.Settings.ShowNotifications = True Then
            cbShowNotifications.Checked = True
        Else
            cbShowNotifications.Checked = False
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

    Sub Sleep(ByVal sleeptime As Integer)
        Dim Stopw As New Stopwatch

        Stopw.Start()

        Do Until Stopw.ElapsedMilliseconds >= sleeptime
            Application.DoEvents()
        Loop
        Stopw.Stop()
        Stopw.Reset()
    End Sub

    Private Sub SetMessageboxLanguage() 'Change text of the messagebox based on the language
        If My.Settings.Language = "German" Then
            ClearMsgBoxHeader = "Liste leeren"
            ClearMsgBoxText = "Bist du dir sicher, dass du die Liste leeren möchtest?"
        ElseIf My.Settings.Language = "English" Then
            ClearMsgBoxHeader = "Clear list"
            ClearMsgBoxText = "Are you sure that you want to clear the list?"
        End If
    End Sub

    Private Sub ShowClearHistoryMsgBox() 'Show messagebox, clicking "yes" will result in the Action History file being cleared
        Select Case MsgBox(ClearMsgBoxText, MsgBoxStyle.YesNo, ClearMsgBoxHeader)
            Case Windows.Forms.DialogResult.Yes
                frmActionHistory.lvActionHistory.Clear()
                My.Computer.FileSystem.WriteAllText(frmMain.AppData + "/Seeloewen Shutdown/ActionHistory.txt", "", False)
                frmMain.WriteToLog("Cleared Action History", "Info")
        End Select
    End Sub

    Private Sub GetProfiles(Path As String)
        If Path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetProfiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.AppData + "\Seeloewen Shutdown\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
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