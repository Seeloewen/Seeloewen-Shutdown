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
            lblImprovementsHeader.Text = "Einige Fehlerbehebungen"
            lblImprovements.Text = "Besonders der Log hatte einige Fehler. Diese und ein paar andere" + vbNewLine + "wurden behoben und die Software sollte nun stabiler sein!"
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