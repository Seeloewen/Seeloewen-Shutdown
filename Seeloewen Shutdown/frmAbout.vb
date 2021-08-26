Public Class frmAbout
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub llblDiscord_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Process.Start("https://discord.gg/sBUaRxT")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        frmHilfe.Show()
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        frmChangelog.Show()
    End Sub
End Class