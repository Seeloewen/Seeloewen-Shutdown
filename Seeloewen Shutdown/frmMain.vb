Imports System.Net
Public Class frmMain
    Dim shutdownart As String
    Dim maxtime As String

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbMessage.Text = My.Settings.DefaultMessage
        tbTime.Text = My.Settings.DefaultTime

        If My.Settings.Design = "dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblHeader.ForeColor = Color.White
            lblVersion.ForeColor = Color.White
            rbtnIn.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            rbtnPointInTime.ForeColor = Color.White
            cbMessage.ForeColor = Color.White
            gbAction.ForeColor = Color.White
            gbTime.ForeColor = Color.White
            gbMessage.ForeColor = Color.White
            tbMessage.BackColor = Color.Gray
            tbMessage.ForeColor = Color.White
            tbTime.BackColor = Color.Gray
            tbTime.ForeColor = Color.White
        End If

        If My.Settings.EnableDefaultMessage = True Then
            tbMessage.Enabled = True
            cbMessage.Checked = True
        ElseIf My.Settings.EnableDefaultMessage = False Then
            tbMessage.Enabled = False
            cbMessage.Checked = False
        End If

        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
        End If


        rbtnIn.Checked = True
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"

        'Translate all elements
        If My.Settings.Language = "English" Then
            gbAction.Text = "Action"
            gbMessage.Text = "Message"
            gbTime.Text = "Time"
            rbtnShutdown.Text = "Shutdown"
            rbtnRestart.Text = "Restart"
            rbtnPointInTime.Text = "Exact time"
            cbMessage.Text = "Attach message"
            btnStartAction.Text = "Start action"
            cbxIn.Items.Remove("Sekunde(n)")
            cbxIn.Items.Remove("Minute(n)")
            cbxIn.Items.Remove("Stunde(n)")
            cbxIn.Items.Add("Second(s)")
            cbxIn.Items.Add("Minute(s)")
            cbxIn.Items.Add("Hour(s)")
        ElseIf My.Settings.Language = "German" Then
        Else frmFirstStart.ShowDialog()
        End If

        If My.Settings.DefaultTimeChoice = "minutes" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Minute(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Minute(n)"
            End If
        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Second(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Sekunde(n)"
            End If
        ElseIf My.Settings.DefaultTimeChoice = "hours" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Hour(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Stunde(n)"
            End If
        End If

        SearchForUpdates()
    End Sub

    Private Sub btnOpenHelp_Click(sender As Object, e As EventArgs) Handles btnOpenHelp.Click
        frmAbout.Show()
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        'Filter quotationmarks out of the message
        tbMessage.Text = tbMessage.Text.Replace("""", "/")

        'Set action using "in..."
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) Then
                If My.Settings.Language = "German" Then
                    MsgBox("Bitte gib eine Zeitangabe an!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("Please enter a time!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                If rbtnShutdown.Checked = True Then
                    Action.Text = "-s"
                ElseIf rbtnRestart.Checked = True Then
                    Action.Text = "-r"
                End If

                'calculate and set shutdown time
                If cbxIn.SelectedItem = "Sekunde(n)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxtime = "31535999"
                    shutdownart = "Sekunde(n)"
                ElseIf cbxIn.SelectedItem = "Second(s)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxtime = "31535999"
                    shutdownart = "Second(s)"
                ElseIf cbxIn.SelectedItem = "Minute(n)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxtime = "525599"
                    shutdownart = "Minute(n)"
                ElseIf cbxIn.SelectedItem = "Minute(s)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxtime = "525599"
                    shutdownart = "Minute(s)"
                ElseIf cbxIn.SelectedItem = "Stunde(n)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxtime = "8759"
                    shutdownart = "Stunde(n)"
                ElseIf cbxIn.SelectedItem = "Hour(s)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxtime = "8759"
                    shutdownart = "Hour(s)"
                End If

                'Run action
                If Shutdowntime.Text > 31535999 Then
                    If My.Settings.Language = "German" Then
                        MsgBox("Die maximale Zeitangabe für " + Quotationmark.Text + shutdownart + Quotationmark.Text + " beträgt " + maxtime, MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The maximum time for " + Quotationmark.Text + shutdownart + Quotationmark.Text + " is " + maxtime, MsgBoxStyle.Critical, "Error")
                    End If
                ElseIf Shutdowntime.Text = 0 Then
                    If My.Settings.Language = "German" Then
                        MsgBox("Die Zeitangabe darf nicht Null sein!", MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The time cannot be zero!", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    If cbMessage.Checked = True Then
                        If String.IsNullOrEmpty(tbMessage.Text) Then
                            If My.Settings.Language = "German" Then
                                MsgBox("Die Nachricht darf nicht leer sein!", MsgBoxStyle.Critical, "Fehler")
                            ElseIf My.Settings.Language = "English" Then
                                MsgBox("The message cannot be empty!", MsgBoxStyle.Critical, "Error")
                            End If
                        Else
                            shutdownWithMessage()
                        End If
                    ElseIf cbMessage.Checked = False Then
                        shutdown()
                    End If
                End If
            End If
        End If

        'Set action using "Point in Time"
        If rbtnPointInTime.Checked = True Then
            If rbtnShutdown.Checked Then
                Action.Text = "-s"
            ElseIf rbtnRestart.Checked Then
                Action.Text = "-r"
            End If

            'Calculate and set shutdown time
            currentDateTime.Value = DateTime.Now
            Dim value As DateTime = currentDateTime.Value
            dtpDate.Format = DateTimePickerFormat.Long
            Dim d As DateTime = dtpDate.Value.Date + dtpDate.Value.TimeOfDay
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
            Dim timeSpan As TimeSpan = d - value
            Math.Ceiling(timeSpan.TotalSeconds)
            Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

            'Run action
            If Shutdowntime.Text > 31535999 Then
                If My.Settings.Language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht mehr als 1 Jahr in der Zukunft liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("The selected point in time cannot be more than 1 year in the future!", MsgBoxStyle.Critical, "Error")
                End If
            ElseIf Shutdowntime.Text < 0 Then
                If My.Settings.Language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht in der Vergangenheit liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("The selected point in time cannot be in the past!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                If cbMessage.Checked Then
                    If String.IsNullOrEmpty(tbMessage.Text) Then
                        If My.Settings.Language = "German" Then
                            MsgBox("Die Nachricht darf nicht leer sein!", MsgBoxStyle.Critical, "Fehler")
                        ElseIf My.Settings.Language = "English" Then
                            MsgBox("The message cannot be empty!", MsgBoxStyle.Critical, "Error")
                        End If
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

    Private Sub rbtnZeitpunkt_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPointInTime.CheckedChanged
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
        Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text + " -c " + Quotationmark.Text + tbMessage.Text + Quotationmark.Text)
        Hide()
        frmFinish.ShowDialog()
    End Sub

    Private Sub cbMessage_Click(sender As Object, e As EventArgs) Handles cbMessage.Click
        If cbMessage.Checked = False Then
            tbMessage.Enabled = False
        ElseIf cbMessage.Checked = True Then
            tbMessage.Enabled = True
        End If
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs) Handles btnOpenSettings.Click
        frmSettings.Show()
    End Sub

    Private Sub SearchForUpdates()
        Dim request = CType(WebRequest.Create("https://raw.githubusercontent.com/Seeloewen/Seeloewen-Shutdown/main/newest_version.txt"), HttpWebRequest)
        On Error Resume Next
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
            If My.Settings.Language = "German" Then
                MsgBox("Bei der Verbindung zum Server ist ein Fehler aufgetreten." + vbNewLine + vbNewLine + "Es konnte nicht automatisch nach Updates gesucht werden.", MsgBoxStyle.Critical, "Aktualisierung")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("An error occured while connecting to the server." + vbNewLine + vbNewLine + "Unable to search for updates automatically.", MsgBoxStyle.Critical, "Update")
            End If
        Else frmUpdate.ShowDialog()
        End If
    End Sub

    Private Sub btnOpenHelp_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpenHelp.MouseDown
        btnOpenHelp.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOpenHelp_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenHelp.MouseUp
        btnOpenHelp.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOpenHelp_MouseHover(sender As Object, e As EventArgs) Handles btnOpenHelp.MouseHover
        btnOpenHelp.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOpenHelp_MouseLeave(sender As Object, e As EventArgs) Handles btnOpenHelp.MouseLeave
        btnOpenHelp.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOpenSettings_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOpenSettings.MouseDown
        btnOpenSettings.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOpenSettings_MouseHover(sender As Object, e As EventArgs) Handles btnOpenSettings.MouseHover
        btnOpenSettings.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOpenSettings_MouseLeave(sender As Object, e As EventArgs) Handles btnOpenSettings.MouseLeave
        btnOpenSettings.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOpenSettings_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOpenSettings.MouseUp
        btnOpenSettings.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStartAction_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseDown
        btnStartAction.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnStartAction_MouseHover(sender As Object, e As EventArgs) Handles btnStartAction.MouseHover
        btnStartAction.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnStartAction_MouseLeave(sender As Object, e As EventArgs) Handles btnStartAction.MouseLeave
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStartAction_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseUp
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub
End Class