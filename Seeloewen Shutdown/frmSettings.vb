Imports System.Net
Public Class frmSettings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub tbDefaultTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDefaultTime.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Überprüfen, welche Option für "Aktion" ausgewählt wurde.
        If rbtnRestart.Checked = True Then
            My.Settings.DefaultAction = "restart"
        ElseIf rbtnShutdown.Checked = True Then
            My.Settings.DefaultAction = "shutdown"
        End If

        'Überprüfen, was die Standart-Nachricht und ob sie aktiviert ist.
        If String.IsNullOrEmpty(tbDefaultMessage.Text) Then
            My.Settings.DefaultMessage = ""
            My.Settings.EnableDefaultMessage = False
        Else
            My.Settings.DefaultMessage = tbDefaultMessage.Text
            My.Settings.EnableDefaultMessage = True
        End If

        'Überprüfen, welche Option für "Time" ausgewählt wurde und Zeitangabe speichern.
        If cbxDefaultIn.SelectedItem = "Stunde(n)" Then
            My.Settings.DefaultTimeChoice = "hours"
        ElseIf cbxDefaultIn.SelectedItem = "Minute(n)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Sekunde(n)" Then
            My.Settings.DefaultTimeChoice = "seconds"
        End If

        'Überprüfen, welche Option für "UpdatesOnStartup" ausgewählt wurde und Auswahl speichern.
        If cbUpdatesOnStartup.Checked = True Then
            My.Settings.UpdatesOnStartup = True
        ElseIf cbUpdatesOnStartup.Checked = False Then
            My.Settings.UpdatesOnStartup = False
        End If

        'DefaultTime speichern.
        My.Settings.DefaultTime = tbDefaultTime.Text

        'Mitteilen, dass alle Optionen gespeichert wurden.
        MsgBox("Alle ausgewählten Optionen wurden gespeichert!", MsgBoxStyle.Information, "Erfolgreich gespeichert!")
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
        Dim githubToken = My.Settings.GithubToken
        On Error Resume Next
        Dim request = CType(WebRequest.Create("https://api.github.com/repos/Seeloewen/Seeloewen-Shutdown/contents/newest_version.txt"), HttpWebRequest)
        On Error Resume Next
        request.Headers.Add(HttpRequestHeader.Authorization, String.Concat("token ", githubToken))
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
End Class