Public Class frmChangelog
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "English" Then
            lblChangelogDescription.Text = "In the changelog you can easily find news for different versions."
        End If
    End Sub
End Class