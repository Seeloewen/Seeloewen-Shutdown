Imports System.Environment
Imports System.IO
Imports System.Net
Public Class frmSettings
    Dim currentversion As String = "1.6.0"
    Dim newestversion As String
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Translations
        If My.Settings.Language = "English" Then

            'Initialize comboboxes if language English is selected
            cbxDefaultIn.Items.Remove("Sekunde(n)")
            cbxDefaultIn.Items.Remove("Minute(n)")
            cbxDefaultIn.Items.Remove("Stunde(n)")
            cbxDefaultIn.Items.Add("Second(s)")
            cbxDefaultIn.Items.Add("Minute(s)")
            cbxDefaultIn.Items.Add("Hour(s)")
            cbxDesign.Items.Remove("Hell")
            cbxDesign.Items.Remove("Dunkel")
            cbxDesign.Items.Add("Light")
            cbxDesign.Items.Add("Dark")
            cbxLanguage.SelectedItem = "English (English)"

            'Change text to english translation
            Text = "Settings"
            lblSettings.Text = "Settings"
            gbDefaultSettings.Text = "Default settings"
            gbRunningAction.Text = "Running action"
            gbAppSettings.Text = "App settings"
            rbtnShutdown.Text = "Shutdown"
            rbtnRestart.Text = "Restart"
            cbUpdatesOnStartup.Text = "Search for updates when the app starts"
            lblDefaultAction.Text = "Action"
            lblDefaultTime.Text = "Execute in..."
            lblDefaultMessage.Text = "Message"
            lblRunningAction.Text = "If an action is already running, you can cancel it" + vbNewLine + "here, if you want to."
            lblLanguage.Text = "Language:"
            btnSearchForUpdates.Text = "Search for updates"
            btnStopRunningActions.Text = "Cancel running action"
            btnSave.Text = "Save"
            btnClose.Text = "Close"
            btnUpdaterSettings.Text = "Updater settings"

        ElseIf My.Settings.Language = "German" Then
            cbxLanguage.SelectedItem = "Deutsch (German)"
        End If

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
            lblDefaultAction.ForeColor = Color.White
            lblDefaultTime.ForeColor = Color.White
            lblDefaultMessage.ForeColor = Color.White
            lblRunningAction.ForeColor = Color.White
            lblLanguage.ForeColor = Color.White
            lblDesign.ForeColor = Color.White
            gbDefaultSettings.ForeColor = Color.White
            gbAppSettings.ForeColor = Color.White
            gbRunningAction.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            cbUpdatesOnStartup.ForeColor = Color.White
            tbDefaultMessage.BackColor = Color.Gray
            tbDefaultTime.BackColor = Color.Gray
            tbDefaultMessage.ForeColor = Color.White
            tbDefaultTime.ForeColor = Color.White
        End If

        'Load default settings from settings
        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
        End If

        If My.Settings.DefaultTimeChoice = "minutes" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Minute(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Minute(n)"
            End If

        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Second(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Sekunde(n)"
            End If

        ElseIf My.Settings.DefaultTimeChoice = "hours" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Hour(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Stunde(n)"
            End If

        End If

        tbDefaultMessage.Text = My.Settings.DefaultMessage
        tbDefaultTime.Text = My.Settings.DefaultTime

        If My.Settings.UpdatesOnStartup = True Then
            cbUpdatesOnStartup.Checked = True
        ElseIf My.Settings.UpdatesOnStartup = False Then
            cbUpdatesOnStartup.Checked = False
        End If
    End Sub

    Private Sub tbDefaultTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDefaultTime.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check which action was selected for DefaultAction.
        If rbtnRestart.Checked = True Then
            My.Settings.DefaultAction = "restart"
        ElseIf rbtnShutdown.Checked = True Then
            My.Settings.DefaultAction = "shutdown"
        End If

        'Check if the DefaultMessage is activated and save text.
        If String.IsNullOrEmpty(tbDefaultMessage.Text) Then
            My.Settings.DefaultMessage = ""
            My.Settings.EnableDefaultMessage = False
        Else
            My.Settings.DefaultMessage = tbDefaultMessage.Text
            My.Settings.EnableDefaultMessage = True
        End If

        'Check which option is selected for DefaultTimeChoice.
        If cbxDefaultIn.SelectedItem = "Stunde(n)" Then
            My.Settings.DefaultTimeChoice = "hours"
        ElseIf cbxDefaultIn.SelectedItem = "Hour(s)" Then
            My.Settings.DefaultTimeChoice = "hours"
        ElseIf cbxDefaultIn.SelectedItem = "Minute(n)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Minute(s)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Sekunde(n)" Then
            My.Settings.DefaultTimeChoice = "seconds"
        ElseIf cbxDefaultIn.SelectedItem = "Second(s)" Then
            My.Settings.DefaultTimeChoice = "seconds"
        End If

        'Check which option is selected for UpdatesOnStartup.
        If cbUpdatesOnStartup.Checked = True Then
            My.Settings.UpdatesOnStartup = True
        ElseIf cbUpdatesOnStartup.Checked = False Then
            My.Settings.UpdatesOnStartup = False
        End If

        'Save DefaultTime
        My.Settings.DefaultTime = tbDefaultTime.Text

        'Save Language
        If cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.Language = "English"
            Close()
        ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.Language = "German"
            Close()
        End If

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

        'Show a message that confirms that all settings have been saved
        If My.Settings.Language = "German" Then
            MsgBox("Alle ausgewählten Optionen wurden gespeichert!" + vbNewLine + "Du musst möglicherweise die App neustarten," + vbNewLine + "um manche Einstellungen anzuwenden.", MsgBoxStyle.Information, "Erfolgreich gespeichert!")
        ElseIf My.Settings.Language = "English" Then
            MsgBox("All settings have been saved." + vbNewLine + "You may need to restart the application" + vbNewLine + "to apply some settings.", MsgBoxStyle.Information, "Saved successfully!")
        End If
        Me.Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
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

    Private Async Sub btnSearchForUpdates_Click(sender As Object, e As EventArgs) Handles btnSearchForUpdates.Click
        'Kill updater process if it's already running
        Try
            For Each process As Process In Process.GetProcesses
                If process.ProcessName = "Seeloewen-Shutdown-Update.exe" Then
                    process.Kill()
                End If
            Next
        Catch exception As Exception
            MessageBox.Show(exception.Message)
        End Try

        'Get updateinfo.txt ready for the updater
        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/updateinfo.txt") Then
            My.Computer.FileSystem.DeleteFile(AppData + "/Seeloewen Shutdown/updateinfo.txt")
        End If
        File.Create(AppData + "/Seeloewen Shutdown/updateinfo.txt").Dispose()

        'Write settings to updateinfo.txt
        settingsforupdater.Clear()
        settingsforupdater.AppendText(currentversion + vbNewLine)

        If My.Settings.UpdaterSettings = "Current" Then
            settingsforupdater.AppendText(My.Settings.Language + vbNewLine)
            settingsforupdater.AppendText(My.Settings.Design + vbNewLine)
        ElseIf My.Settings.UpdaterSettings = "Custom" Then
            settingsforupdater.AppendText(My.Settings.CustomUpdaterLanguage + vbNewLine)
            settingsforupdater.AppendText(My.Settings.CustomUpdaterDesign + vbNewLine)
        End If

        settingsforupdater.AppendText(My.Settings.UpdaterBranch)

        My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/updateinfo.txt", settingsforupdater.Text, False)

        'Delete updater if it already exists
        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/Seeloewen-Shutdown-Update.exe") Then
            My.Computer.FileSystem.DeleteFile(AppData + "/Seeloewen Shutdown/Seeloewen-Shutdown-Update.exe")
        End If

        '(Download and) start new updater
        If My.Settings.Updater = "Newest" Then
            Await Task.Run(Sub() DownloadUpdater())
            Process.Start(AppData + "/Seeloewen Shutdown/Seeloewen-Shutdown-Update.exe")
        ElseIf My.Settings.Updater = "Legacy" Then
            LegacyUpdater()
        ElseIf My.Settings.Updater = "Custom" Then
            Process.Start(My.Settings.CustomUpdaterPath)
        End If
    End Sub

    Private Sub SearchForUpdates()
        Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/newest_version.txt"), HttpWebRequest)
        On Error Resume Next
        request.Accept = "application/vnd.github.v3.raw"
        request.UserAgent = "Seeloewen Shutdown"

        Using response = request.GetResponse()
            Dim encoding = System.Text.ASCIIEncoding.UTF8

            Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                newestversion = reader.ReadToEnd()
            End Using
        End Using
    End Sub

    Private Async Sub LegacyUpdater()
        If My.Settings.Language = "German" Then
            btnSearchForUpdates.Text = "Suche nach Updates..."
        ElseIf My.Settings.Language = "English" Then
            btnSearchForUpdates.Text = "Searching for updates..."
        End If

        btnSearchForUpdates.Enabled = False

        Await Task.Run(Sub() SearchForUpdates())
        rtbNewestVersion.Text = newestversion

        If rtbCurrentVersion.Text = rtbNewestVersion.Text Then
            If My.Settings.Language = "German" Then
                MsgBox("Es ist keine neue Version verfügbar.", MsgBoxStyle.Information, "Aktualisierung")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("No new version is available.", MsgBoxStyle.Information, "Update")
            End If
        ElseIf rtbNewestVersion.Text = "Error.NoServerConnection" Then
            If My.Settings.Language = "German" Then
                MsgBox("Bei der Verbindung zum Server ist ein Fehler aufgetreten.", MsgBoxStyle.Critical, "Aktualisierung")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("An error occured while connecting to the server.", MsgBoxStyle.Critical, "Update")
            End If
        Else frmUpdate.ShowDialog()
        End If

        If My.Settings.Language = "German" Then
            btnSearchForUpdates.Text = "Nach Aktualisierungen suchen"
        ElseIf My.Settings.Language = "English" Then
            btnSearchForUpdates.Text = "Search for updates"
        End If

        btnSearchForUpdates.Enabled = True
    End Sub

    Private Sub btnStopRunningActions_Click(sender As Object, e As EventArgs) Handles btnStopRunningActions.Click
        Process.Start("shutdown", "-a")

        If My.Settings.Language = "German" Then
            MsgBox("Die laufende Aktion wurde erfolgreich abgebrochen.", MsgBoxStyle.Information, "Laufende Aktion abbrechen")
        ElseIf My.Settings.Language = "English" Then
            MsgBox("The running action was successfully cancelled.", MsgBoxStyle.Information, "Cancel running action")
        End If
    End Sub

    Public Sub DownloadUpdater()
        'Download newest updater
        Dim wc As New WebClient()
        wc.DownloadFile(My.Settings.NewestUpdaterLink, AppData + "/Seeloewen Shutdown/Seeloewen-Shutdown-Update.exe")
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
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

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSave.MouseUp
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStopRunningActions_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStopRunningActions.MouseDown
        btnStopRunningActions.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnStopRunningActions_MouseHover(sender As Object, e As EventArgs) Handles btnStopRunningActions.MouseHover
        btnStopRunningActions.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnStopRunningActions_MouseLeave(sender As Object, e As EventArgs) Handles btnStopRunningActions.MouseLeave
        btnStopRunningActions.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStopRunningActions_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStopRunningActions.MouseUp
        btnStopRunningActions.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSearchForUpdates_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSearchForUpdates.MouseDown
        btnSearchForUpdates.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSearchForUpdates_MouseHover(sender As Object, e As EventArgs) Handles btnSearchForUpdates.MouseHover
        btnSearchForUpdates.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSearchForUpdates_MouseLeave(sender As Object, e As EventArgs) Handles btnSearchForUpdates.MouseLeave
        btnSearchForUpdates.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSearchForUpdates_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSearchForUpdates.MouseUp
        btnSearchForUpdates.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnNewUpdaterSettings_Click(sender As Object, e As EventArgs) Handles btnUpdaterSettings.Click
        frmUpdaterSettings.ShowDialog()
    End Sub

    Private Sub btnNewUpdaterSettings_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUpdaterSettings.MouseDown
        btnUpdaterSettings.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnNewUpdaterSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdaterSettings.MouseLeave
        btnUpdaterSettings.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnNewUpdaterSettings_MouseHover(sender As Object, e As EventArgs) Handles btnUpdaterSettings.MouseHover
        btnUpdaterSettings.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnNewUpdaterSettings_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUpdaterSettings.MouseUp
        btnUpdaterSettings.BackgroundImage = My.Resources.button
    End Sub
End Class