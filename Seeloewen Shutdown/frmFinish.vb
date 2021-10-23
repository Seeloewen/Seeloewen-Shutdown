Public Class frmFinish
    Private TargetDT As DateTime

    Private Sub btnCancelAction_Click(sender As Object, e As EventArgs) Handles btnCancelAction.Click
        Hide()
        frmMain.Show()
        Process.Start("shutdown", "-a")
    End Sub

    Private Sub frmFinish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "English" Then
            Text = "Notification"
            lblHeader.Text = "Your PC will shutdown soon"
            lblTimeRemaining.Text = "Time remaining:"
            lblPointInTime.Text = "Exact time:"
            gbMessage.Text = "Message"
            btnCancelAction.Text = "Cancel action"
        End If

        If My.Settings.Design = "dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbInfo.BackColor = Color.FromArgb(41, 41, 41)
            rtbInfo.ForeColor = Color.White
            lblHeader.ForeColor = Color.White
            lblTimeRemaining.ForeColor = Color.White
            lblPointInTime.ForeColor = Color.White
            timeRemaining.ForeColor = Color.White
            pointintime.ForeColor = Color.White
            gbMessage.ForeColor = Color.White
        End If

        'Define countdown
        Dim CountDownFrom As TimeSpan
        If frmMain.rbtnIn.Checked = True Then
            If frmMain.cbxIn.SelectedItem = "Sekunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text))
            ElseIf frmMain.cbxIn.SelectedItem = "Second(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text))
            ElseIf frmMain.cbxIn.SelectedItem = "Minute(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 60)
            ElseIf frmMain.cbxIn.SelectedItem = "Minute(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 60)
            ElseIf frmMain.cbxIn.SelectedItem = "Stunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 3600)
            ElseIf frmMain.cbxIn.SelectedItem = "Hour(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 3600)
            End If
        ElseIf frmMain.rbtnShutdown.Checked = True Then
            CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.Shutdowntime.Text))
        End If

        'Set exact point in time
        If frmMain.rbtnIn.Checked = True Then
            frmMain.dtpDate.Value = DateTime.Now
            frmMain.dtpDate.Value = frmMain.dtpDate.Value.AddSeconds(frmMain.Shutdowntime.Text)
            pointintime.Text = frmMain.dtpDate.Text
        ElseIf frmMain.rbtnPointInTime.Checked = True Then
            pointintime.Text = frmMain.dtpDate.Text
        End If

        'Load message
        If frmMain.cbMessage.Checked Then
            rtbInfo.Text = frmMain.tbMessage.Text
        Else
            If My.Settings.Language = "German" Then
                rtbInfo.Text = "Wenn sie die Aktion versehentlich gestartet haben, können sie diese abbrechen!"
            ElseIf My.Settings.Language = "English" Then
                rtbInfo.Text = "If you've started this action by accident you can cancel it!"
            End If
        End If

        'Initialize timer
        tmrShutdown.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)

        'Start timer
        tmrShutdown.Start()
    End Sub

    Private Sub tmrShutdown_Tick(sender As Object, e As EventArgs) Handles tmrShutdown.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            If ts.TotalHours > 24 Then
                timeRemaining.Text = ts.ToString("dd\:hh\:mm\:ss")
            Else timeRemaining.Text = ts.ToString("hh\:mm\:ss")
            End If
        End If
    End Sub

    Private Sub btnCancelAction_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancelAction.MouseDown
        btnCancelAction.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnCancelAction_MouseHover(sender As Object, e As EventArgs) Handles btnCancelAction.MouseHover
        btnCancelAction.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnCancelAction_MouseLeave(sender As Object, e As EventArgs) Handles btnCancelAction.MouseLeave
        btnCancelAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancelAction_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancelAction.MouseUp
        btnCancelAction.BackgroundImage = My.Resources.button
    End Sub
End Class