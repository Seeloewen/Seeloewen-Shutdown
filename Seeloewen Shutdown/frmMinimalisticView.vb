Public Class frmMinimalisticView

    Private Sub frmMinimalisticView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load action
        If frmMain._RunningAction.Text = "Shutdown" Or frmMain._RunningAction.Text = "Herunterfahren" Then
            If My.Settings.Language = "German" Then
                lblAction.Text = "Ein Herunterfahren wurde geplant!"
            ElseIf My.Settings.Language = "English" Then
                lblAction.Text = "A shutdown has been scheduled!"
            End If
        ElseIf frmMain._RunningAction.Text = "Restart" Or frmMain._RunningAction.Text = "Neustarten" Then
            If My.Settings.Language = "German" Then
                lblAction.Text = "Ein Neustart wurde geplant!"
            ElseIf My.Settings.Language = "English" Then
                lblAction.Text = "A restart has been scheduled!"
            End If
        End If

        'Load time
        lblTime.Text = frmMain._RunningTime.Text

        'Load design
        If My.Settings.Design = "Dark" Then
            lblAction.ForeColor = Color.White
            lblScheduledTime.ForeColor = Color.White
            lblTime.ForeColor = Color.White
            lblTimeRemaining.ForeColor = Color.White
            lblTimerShutdown.ForeColor = Color.White
            BackColor = Color.FromArgb(41, 41, 41)
        End If

        'Load language
        If My.Settings.Language = "German" Then
            lblScheduledTime.Text = "Geplante Zeit:"
            lblTimeRemaining.Text = "Verbleibende Zeit:"
            Text = "Seeloewen Shutdown - Minimalistische Ansicht"
            btnSwitchToNormalView.Text = "Zur Normalen Ansicht wechseln"
        End If

        'Hide frmMain in case it wasn't hidden when enabling minimalistic view
        frmMain.Hide()
    End Sub

    Private Sub btnSwitchToNormalView_Click(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.Click
        Close()
    End Sub

    Private Sub btnSwitchToNormalView_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSwitchToNormalView.MouseDown
        btnSwitchToNormalView.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSwitchToNormalView_MouseHover(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.MouseHover
        btnSwitchToNormalView.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSwitchToNormalView_MouseLeave(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.MouseLeave
        btnSwitchToNormalView.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSwitchToNormalView_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSwitchToNormalView.MouseUp
        btnSwitchToNormalView.BackgroundImage = My.Resources.button
    End Sub

    Private Sub frmMinimalisticView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub
End Class