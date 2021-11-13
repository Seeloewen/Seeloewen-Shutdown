Public Class frmChangelog
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbChangelog.BackColor = Color.FromArgb(41, 41, 41)
            rtbChangelog.ForeColor = Color.White
            lblChangelogDescription.ForeColor = Color.White
            lblChangelogHeader.ForeColor = Color.White
        End If

        If My.Settings.Language = "English" Then
            lblChangelogDescription.Text = "In the changelog you can easily find news for different versions."
            rtbChangelog.Text = rtbchangelogEnglish.Text
        End If
    End Sub
End Class