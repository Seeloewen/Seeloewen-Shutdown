Imports System.Net
Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Design = "light" Then
            ComboBox1.Text = "Hell"
        ElseIf My.Settings.Design = "dark" Then
            ComboBox1.Text = "Dunkel"
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
        End If

        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
        End If

        If My.Settings.DefaultTimeChoice = "minutes" Then
            cbxDefaultIn.SelectedItem = "Minute(n)"
        ElseIf My.Settings.DefaultTimeChoice = "hours" Then
            cbxDefaultIn.SelectedItem = "Stunde(n)"
        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then
            cbxDefaultIn.SelectedItem = "Sekunde(n)"
        End If

        tbDefaultMessage.Text = My.Settings.DefaultMessage
        tbDefaultTime.Text = My.Settings.DefaultTime

        If My.Settings.UpdatesOnStartup = True Then
            cbUpdatesOnStartup.Checked = True
        ElseIf My.Settings.UpdatesOnStartup = False Then
            cbUpdatesOnStartup.Checked = False
        End If

        If My.Settings.Language = "English" Then
            cbxLanguage.SelectedItem = "English (English)"
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
            lblLanguage.Text = "Language"
            btnSearchForUpdates.Text = "Search for updates"
            btnStopRunningActions.Text = "Stop running actions"
            btnSave.Text = "Save"
            btnClose.Text = "Close"
        ElseIf My.Settings.Language = "German" Then
            cbxLanguage.SelectedItem = "Deutsch (German)"
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
        ElseIf cbxDefaultIn.SelectedItem = "Minute(n)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Sekunde(n)" Then
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
        If ComboBox1.SelectedItem = "Hell" Then
            My.Settings.Design = "light"
        ElseIf ComboBox1.SelectedItem = "Dunkel" Then
            My.Settings.Design = "dark"
        End If

        'Show a message that confirms that all settings have been saved
        MsgBox("Alle ausgewählten Optionen wurden gespeichert!" + vbNewLine + "Du musst möglicherweise die App neustarten," + vbNewLine + "um manche Einstellungen anzuwenden.", MsgBoxStyle.Information, "Erfolgreich gespeichert!")
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

    Private Sub btnSearchForUpdates_Click(sender As Object, e As EventArgs) Handles btnSearchForUpdates.Click
        Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/newest_version.txt"), HttpWebRequest)
        On Error Resume Next
        request.Accept = "application/vnd.github.v3.raw"
        request.UserAgent = "Seeloewen Shutdown"

        Using response = request.GetResponse()
            Dim encoding = System.Text.ASCIIEncoding.UTF8

            Using reader = New System.IO.StreamReader(response.GetResponseStream(), encoding)
                rtbNewestVersion.Text = reader.ReadToEnd()
            End Using
        End Using

        If rtbCurrentVersion.Text = rtbNewestVersion.Text Then
            MsgBox("Es ist keine neue Version verfügbar.", MsgBoxStyle.Information, "Aktualisierung")
        ElseIf rtbNewestVersion.Text = "Error.NoServerConnection" Then
            MsgBox("Bei der Verbindung zum Server ist ein Fehler aufgetreten.", MsgBoxStyle.Critical, "Aktualisierung")
        Else frmUpdate.ShowDialog()
        End If
    End Sub

    Private Sub btnStopRunningActions_Click(sender As Object, e As EventArgs) Handles btnStopRunningActions.Click
        Process.Start("shutdown", "-a")
        MsgBox("Die laufende Aktion wurde erfolgreich abgebrochen.", MsgBoxStyle.Information, "Laufende Aktion abbrechen")
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
End Class