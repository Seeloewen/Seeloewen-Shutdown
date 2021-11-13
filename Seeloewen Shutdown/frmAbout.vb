Public Class frmAbout
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub llblDiscord_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://discord.gg/sBUaRxT")
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        frmChangelog.Show()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbInfo.BackColor = Color.FromArgb(41, 41, 41)
            llblSeeloewenShutdownGithub.ForeColor = Color.Cyan
            llblSeeloewenShutdownGithub.LinkColor = Color.Cyan
            lblHeader.ForeColor = Color.White
            lblInfo.ForeColor = Color.White
            gbInfo.ForeColor = Color.White
            rtbInfo.ForeColor = Color.White
        End If

        If My.Settings.Language = "English" Then
            Text = "About..."
            btnClose.Text = "Close"
        End If
    End Sub

    Private Sub llblSeeloewenShutdownGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSeeloewenShutdownGithub.LinkClicked
        Process.Start("https://github.com/Seeloewen/Seeloewen-Shutdown")
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnChangelog_MouseDown(sender As Object, e As MouseEventArgs) Handles btnChangelog.MouseDown
        btnChangelog.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnChangelog_MouseHover(sender As Object, e As EventArgs) Handles btnChangelog.MouseHover
        btnChangelog.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnChangelog_MouseUp(sender As Object, e As MouseEventArgs) Handles btnChangelog.MouseUp
        btnChangelog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnChangelog_MouseLeave(sender As Object, e As EventArgs) Handles btnChangelog.MouseLeave
        btnChangelog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs)

    End Sub
End Class