﻿Imports System.Net
Public Class frmMain
    Dim shutdownart As String
    Dim maxtime As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbMessage.Text = My.Settings.DefaultMessage
        tbTime.Text = My.Settings.DefaultTime

        If My.Settings.EnableDefaultMessage = True Then
            tbMessage.Enabled = True
            cbMessage.Checked = True
        ElseIf My.Settings.EnableDefaultMessage = False Then
            tbMessage.Enabled = False
            cbMessage.Checked = False
        End If

        If My.Settings.DefaultTimeChoice = "minutes" Then
            cbxIn.SelectedItem = "Minute(n)"
        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then
            cbxIn.SelectedItem = "Sekunde(n)"
        ElseIf My.Settings.DefaultTimeChoice = "hours" Then
            cbxIn.SelectedItem = "Stunde(n)"
        End If
        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
        End If

        If My.Settings.UpdatesOnStartup = True Then
            SearchForUpdates()
        End If

        rbtnIn.Checked = True
        dtpDate.Enabled = False
        currentDateTime.Enabled = False

        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
    End Sub

    Private Sub btnOpenHelp_Click(sender As Object, e As EventArgs) Handles btnOpenHelp.Click
        frmAbout.Show()
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        'Anführungszeichen aus Message herausfiltern, da diese zu Problemen führen.
        tbMessage.Text = tbMessage.Text.Replace("""", "/")

        'Action festlegen ohne Nachricht
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) Then
                MsgBox("Bitte gib eine Zeitangabe an!", MsgBoxStyle.Critical, "Fehler")
            Else
                If rbtnShutdown.Checked = True Then
                    Action.Text = "-s"
                    frmFinish.rtbInfo.Text = "Ihr PC wird demnächst heruntergefahren."
                ElseIf rbtnRestart.Checked = True Then
                    Action.Text = "-r"
                    frmFinish.rtbInfo.Text = "Ihr PC wird demnächst neugestartet."
                End If

                'Shutdowntime berechnen und festlegen
                If cbxIn.SelectedItem = "Sekunde(n)" Then
                    Shutdowntime.Text = tbTime.Text
                    shutdownart = "Sekunde(n)"
                    maxtime = "31535999"
                ElseIf cbxIn.SelectedItem = "Minute(n)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    shutdownart = "Minute(n)"
                    maxtime = "525599"
                ElseIf cbxIn.SelectedItem = "Stunde(n)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    shutdownart = "Stunde(n)"
                    maxtime = "8759"
                End If

                'Aktion ausführen
                If Shutdowntime.Text > 31535999 Then
                    MsgBox("Die maximale Zeitangabe für " + Anführungszeichen.Text + shutdownart + Anführungszeichen.Text + " beträgt " + maxtime, MsgBoxStyle.Critical, "Fehler")
                ElseIf Shutdowntime.Text = 0 Then
                    MsgBox("Die Zeitangabe darf nicht Null sein!", MsgBoxStyle.Critical, "Fehler")
                Else
                    If cbMessage.Checked = True Then
                        If String.IsNullOrEmpty(tbMessage.Text) Then
                            MsgBox("Die Nachricht darf nicht leer sein!", MsgBoxStyle.Critical, "Fehler")
                        Else
                            shutdownWithMessage()
                        End If
                    ElseIf cbMessage.Checked = False Then
                        shutdown()
                    End If
                End If
            End If
        End If

        'Aktion mit Nachricht festlegen
        If rbtnZeitpunkt.Checked = True Then
            If rbtnShutdown.Checked Then
                Action.Text = "-s"
                frmFinish.rtbInfo.Text = "Ihr PC wird demnächst heruntergefahren."
            ElseIf rbtnRestart.Checked Then
                Action.Text = "-r"
                frmFinish.rtbInfo.Text = "Ihr PC wird demnächst neugestartet."
            End If

            'Shutdowntime berechnen und festlegen
            currentDateTime.Value = DateTime.Now
            Dim value As DateTime = currentDateTime.Value
            dtpDate.Format = DateTimePickerFormat.Long
            Dim d As DateTime = dtpDate.Value.Date + dtpDate.Value.TimeOfDay
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
            Dim timeSpan As TimeSpan = d - value
            Math.Ceiling(timeSpan.TotalSeconds)
            Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

            'Aktion ausführen
            If Shutdowntime.Text > 31535999 Then
                MsgBox("Der ausgewählte Zeitpunkt darf nicht mehr als 1 Jahr in der Zukunft liegen!", MsgBoxStyle.Critical, "Fehler")
            ElseIf Shutdowntime.Text < 0 Then
                MsgBox("Der ausgewählte Zeitpunkt darf nicht in der Vergangenheit liegen!", MsgBoxStyle.Critical, "Fehler")
            Else
                If cbMessage.Checked Then
                    If String.IsNullOrEmpty(tbMessage.Text) Then
                        MsgBox("Die Nachricht darf nicht leer sein!", MsgBoxStyle.Critical, "Fehler")
                    Else
                        shutdownWithMessage()
                    End If
                Else
                    shutdown()
                End If
            End If
        End If
    End Sub

    Private Sub tbTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTime.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub rbtnZeitpunkt_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnZeitpunkt.CheckedChanged
        tbTime.Enabled = False
        cbxIn.Enabled = False
        dtpDate.Enabled = True
        currentDateTime.Enabled = True
    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        tbTime.Enabled = True
        cbxIn.Enabled = True
    End Sub

    Private Sub shutdown()
        Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text)
        Hide()
        frmFinish.ShowDialog()
    End Sub

    Private Sub shutdownWithMessage()
        Finaloutput.Text = Action.Text + " -t " + Shutdowntime.Text + " -c " + tbMessage.Text
        Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text + " -c " + Anführungszeichen.Text + tbMessage.Text + Anführungszeichen.Text)
        Hide()
        frmFinish.ShowDialog()
    End Sub

    Private Sub cbMessage_Click(sender As Object, e As EventArgs) Handles cbMessage.Click
        Dim flag As Boolean = cbMessage.CheckState = CheckState.Unchecked
        If flag Then
            tbMessage.Enabled = False
        Else
            Dim flag2 As Boolean = cbMessage.CheckState = CheckState.Checked
            If flag2 Then
                tbMessage.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs) Handles btnOpenSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub SearchForUpdates()
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
                frmSettings.rtbNewestVersion.Text = reader.ReadToEnd()
            End Using
        End Using

        If frmSettings.rtbCurrentVersion.Text = frmSettings.rtbNewestVersion.Text Then
        ElseIf frmSettings.rtbNewestVersion.Text = "Error.NoServerConnection" Then
            MsgBox("Bei der Verbindung zum Server ist ein Fehler aufgetreten." + vbNewLine + vbNewLine + "Es konnte nicht automatisch nach Updates gesucht werden.", MsgBoxStyle.Critical, "Aktualisierung")
        Else frmUpdate.ShowDialog()
        End If
    End Sub
End Class