Imports System.Environment
Imports System.IO

Public Class frmMain
    Dim shutdownart As String
    Dim maxtime As String
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ActionRunning As Boolean = False
    Dim GrayBoxNewY As Integer
    Dim PnlActionRunningNewY As Integer

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _SelectedAction.Text = "No action selected"
        _SelectedTime.Text = "No time selected"

        tbMessage.Text = My.Settings.DefaultMessage
        tbTime.Text = My.Settings.DefaultTime

        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/Show_Update_News_1.6.1") = False Then
            frmUpdateNews.ShowDialog()
            Dim fs As FileStream = File.Create(AppData + "/Seeloewen Shutdown/Show_Update_News_1.6.1")
            fs.Close()
        End If

        If My.Settings.Design = "Dark" Then
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
            _SelectedAction.Text = "Shutdown"
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
            _SelectedAction.Text = "Restart"
        End If


        rbtnIn.Checked = True
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"

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

        'This comment was made on 22.02.2022 and committed on 22.02.2022 22:22

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
    End Sub

    Private Sub btnOpenHelp_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        If ActionRunning = False Then
            btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
            btnStartAction.Text = "Stop action"
            pbGrayBox.Top = 550
            GrayBoxNewY = 550
            pnlActionRunning.Top = 550
            PnlActionRunningNewY = 550
            pbGrayBox.Show()
            tmrGrayBoxAnimationUp.Enabled = True
            tmrPnlActionRunningAnimationUp.Enabled = True
            ActionRunning = True
        ElseIf ActionRunning = True Then
            btnStartAction.BackColor = Color.White
            btnStartAction.Text = "Start action"
            pbGrayBox.Top = 347
            GrayBoxNewY = 347
            pnlActionRunning.Top = 350
            PnlActionRunningNewY = 350
            tmrGrayBoxAnimationDown.Enabled = True
            tmrPnlActionRunningAnimationDown.Enabled = True
            ActionRunning = False
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

        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                _SelectedTime.Text = "No time selected"
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        tbTime.Enabled = True
        cbxIn.Enabled = True

        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                _SelectedTime.Text = "No time selected"
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
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

    Sub Sleep(ByVal sleeptime As Integer)
        Dim Stopwatch As New Stopwatch

        Stopwatch.Start()

        Do Until Stopwatch.ElapsedMilliseconds >= sleeptime
            Application.DoEvents()
        Loop
        Stopwatch.Stop()
        Stopwatch.Reset()
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs)
        frmSettings.Show()
    End Sub

    Private Sub GrayBoxAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationUp.Tick
        If pbGrayBox.Top >= 331 Then
            GrayBoxNewY = GrayBoxNewY - 10
            pbGrayBox.Top = GrayBoxNewY - 10
        Else
            tmrGrayBoxAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub GrayBoxAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationDown.Tick
        If pbGrayBox.Top <= 500 Then
            GrayBoxNewY = GrayBoxNewY + 10
            pbGrayBox.Top = GrayBoxNewY
        Else
            tmrGrayBoxAnimationDown.Enabled = False
            pbGrayBox.Visible = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationUp.Tick
        If pnlActionRunning.Top >= 347 Then
            PnlActionRunningNewY = PnlActionRunningNewY - 10
            pnlActionRunning.Top = PnlActionRunningNewY
        Else
            tmrPnlActionRunningAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationDown.Tick
        If pnlActionRunning.Top <= 500 Then
            PnlActionRunningNewY = PnlActionRunningNewY + 10
            pnlActionRunning.Top = PnlActionRunningNewY
        Else
            tmrPnlActionRunningAnimationDown.Enabled = False
        End If
    End Sub

    Private Sub StartAction()
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

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        If cmsHamburgerButton.Visible = True Then
            cmsHamburgerButton.Hide()
        Else
            cmsHamburgerButton.Show(btnHamburger, -100, btnHamburger.Top + 30)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmSettings.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmAbout.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmChangelog.Show()
    End Sub

    Private Sub btnHamburger_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHamburger.MouseDown
        btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click
    End Sub

    Private Sub btnHamburger_MouseHover(sender As Object, e As EventArgs) Handles btnHamburger.MouseHover
        btnHamburger.BackgroundImage = My.Resources.btnHamburger_Hover
    End Sub

    Private Sub btnHamburger_MouseLeave(sender As Object, e As EventArgs) Handles btnHamburger.MouseLeave
        btnHamburger.BackgroundImage = My.Resources.btnHamburger
    End Sub

    Private Sub btnHamburger_MouseUp(sender As Object, e As MouseEventArgs) Handles btnHamburger.MouseUp
        btnHamburger.BackgroundImage = My.Resources.btnHamburger
    End Sub

    Private Sub rbtnShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnShutdown.CheckedChanged
        If rbtnShutdown.Checked = True Then
            _SelectedAction.Text = "Shutdown"
        ElseIf rbtnRestart.Checked = True Then
            _SelectedAction.Text = "Restart"
        End If
    End Sub

    Private Sub rbtnRestart_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRestart.CheckedChanged

    End Sub

    Private Sub tbTime_TextChanged(sender As Object, e As EventArgs) Handles tbTime.TextChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                _SelectedTime.Text = "No time selected"
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub cbxIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIn.SelectedIndexChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                _SelectedTime.Text = "No time selected"
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                _SelectedTime.Text = "No time selected"
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub
End Class