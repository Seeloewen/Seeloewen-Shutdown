Public Class frmAbout
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub llblDiscord_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://discord.gg/sBUaRxT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        frmHilfe.Show()
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        frmChangelog.Show()
    End Sub

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "English" Then
            Text = "About..."

            btnHelp.Text = "Help"
            btnClose.Text = "Close"
        End If
    End Sub
End Class