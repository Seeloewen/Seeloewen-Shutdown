Public Class frmUpdateNews

    Private Sub llblChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblChangelog.LinkClicked
        frmChangelog.Show()
    End Sub

    Private Sub btnOK_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOK.MouseUp
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOK.MouseDown
        btnOK.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOK_MouseHover(sender As Object, e As EventArgs) Handles btnOK.MouseHover
        btnOK.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOK_Click_1(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub frmUpdateNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "English" Then
            lblHeader.Text = "Version 1.6.1 - What's new?"
            Text = "Seeloewen Shutdown has been installed!"
            lblUpdaterHeader.Text = "The updater has been removed."
            lblUpdater.Text = "Because of problems which I dont want" + vbNewLine + "to further talk about, the updater has been removed."
            lblImprovementsHeader.Text = "Other improvements have also been made!"
            lblImprovements.Text = "Besides the updater there are also other" + vbNewLine + "improvements, like design changes and bugfixes."
            lblChangelog.Text = "An exact changelog can be found in"
            btnOK.Text = "Got it!"
        End If

        If My.Settings.Design = "Dark" Then
            lblHeader.ForeColor = Color.White
            lblUpdaterHeader.ForeColor = Color.White
            lblUpdater.ForeColor = Color.White
            lblImprovementsHeader.ForeColor = Color.White
            lblImprovements.ForeColor = Color.White
            lblChangelog.ForeColor = Color.White
            BackColor = Color.FromArgb(41, 41, 41)
        End If
    End Sub
End Class