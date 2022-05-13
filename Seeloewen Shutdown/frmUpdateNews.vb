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

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    Private Sub frmUpdateNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "German" Then
            lblHeader.Text = "Version 1.7.1 - Was ist neu?"
            Text = "Seeloewen Shutdown wurde installiert!"
            lblUpdaterHeader.Text = "Ein neues Design"
            lblUpdater.Text = "Die Software besitzt nun ein neues Design, um" + vbNewLine + "sie ansprechender, einfacher zu verstehen und leichter nutzbar" + vbNewLine + "zu machen"
            lblImprovementsHeader.Text = "Minimalistische Ansicht und Benachrichtigungen"
            lblImprovements.Text = "Die neue 'Minimalistische Ansicht' ist nun verfügbar! Es wird nur ein kleiner" + vbNewLine + "Teil der Software gezeigt, wenn dies aktiviert ist. Benachrichtigungen" + vbNewLine + "wurden ebenfalls durch dieses Update hinzugefügt."
            lblChangelog.Text = "Eine genaue Änderungsliste kann im                           gefunden werden"
            btnOK.Text = "Alles klar!"
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