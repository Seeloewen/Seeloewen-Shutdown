Public Class frmFinish
    Private TargetDT As DateTime

    Private Sub btnCancelAction_Click(sender As Object, e As EventArgs) Handles btnCancelAction.Click
        Hide()
        frmMain.Show()
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

        If My.Settings.Design = "Dark" Then
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


        'Set exact point in time

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