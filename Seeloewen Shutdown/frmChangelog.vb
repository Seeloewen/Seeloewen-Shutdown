Public Class frmChangelog

    '-- Event handlers --

    Private Sub frmChangelog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDesign()
        LoadLanguage()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbchangelogEnglish.BackColor = Color.FromArgb(41, 41, 41)
            rtbchangelogEnglish.ForeColor = Color.White
            lblChangelogDescription.ForeColor = Color.White
            lblChangelogHeader.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        If My.Settings.Language = "German" Then
            lblChangelogDescription.Text = "Im Changelog können die Neuigkeiten von Versionen einfach abgerufen werden."
            rtbchangelogEnglish.Text = rtbChangelog.Text
        End If
    End Sub
End Class