Public Class frmUpdateNews

    '-- Event handlers --

    Private Sub frmUpdateNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub llblChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblChangelog.LinkClicked
        frmChangelog.Show()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadLanguage() 'Translate strings if language german is selected
        If My.Settings.Language = "German" Then
            lblHeader.Text = "Version 1.8.0 - Was ist neu?"
            Text = "Seeloewen Shutdown wurde installiert!"
            lblNewsHeader.Text = "Profile und Aktionsverlauf"
            lblNews.Text = "Die Software unterstützt nun das erstellen von Profilen, sodass du einfach" + vbNewLine + "Voreinstellungen speichern und laden kannst. Zusätzlich wurde der" + vbNewLine + "Aktionsverlauf hinzugefügt, damit du deine vergangenen Aktionen im" + vbNewLine + "Auge behalten kannst."
            lblImprovementsHeader.Text = "Viele andere Verbesserungen und Fehlerbehebungen"
            lblImprovements.Text = "Der Darkmode wurde verbessert und viele andere Quality-Of-Live" + vbNewLine + "Verbesserungen wurden vorgenommen. Zusätzlich wurden ein ganzer" + vbNewLine + "Haufen Fehler behoben."
            lblChangelog.Text = "Eine genaue Änderungsliste kann im                           gefunden werden"
            btnOK.Text = "Alles klar!"
        End If
    End Sub

    Private Sub LoadDesign() 'Set to darkmode if design dark is selected
        If My.Settings.Design = "Dark" Then
            lblHeader.ForeColor = Color.White
            lblNewsHeader.ForeColor = Color.White
            lblNews.ForeColor = Color.White
            lblImprovementsHeader.ForeColor = Color.White
            lblImprovements.ForeColor = Color.White
            lblChangelog.ForeColor = Color.White
            BackColor = Color.FromArgb(41, 41, 41)
        End If
    End Sub

    '-- Button designs --

    Private Sub btnOK_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOK.MouseUp
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOK.MouseDown
        btnOK.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOK_MouseEnter(sender As Object, e As EventArgs) Handles btnOK.MouseEnter
        btnOK.BackgroundImage = My.Resources.button_hover
    End Sub
End Class