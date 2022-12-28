Public Class frmUpdateNews

    '-- Event handlers --

    Private Sub frmUpdateNews_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user preferences
        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub llblChangelog_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblChangelog.LinkClicked
        'Show changelog
        frmChangelog.Show()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Close
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadLanguage()
        'Translate strings if language german is selected
        If My.Settings.Language = "German" Then
            lblHeader.Text = "Version 1.8.2 - Was ist neu?"
            Text = "Seeloewen Shutdown wurde installiert!"
            lblNewsHeader.Text = "Allgemeine Verbesserungen"
            lblNews.Text = "Viele Teile der Software, wie das Profilsystem, die Einstellungen und" + vbNewLine + "ein paar Designelemente, wurden überarbeitet oder verbessert, um eine" + vbNewLine + "bessere Benutzererfahrung zu garantieren"
            lblImprovementsHeader.Text = "Ein paar Fehlerbehebungen"
            lblImprovements.Text = "Zusätzlich wurden ein paar Fehler behoben, um sicherzustellen," + vbNewLine + "dass die Software so reibungslos wie möglich läuft." + vbNewLine + "Deine Einstellungen werden beispielsweise nun nicht mehr zurückgesetzt," + vbNewLine + "wenn du die App aktualisierst oder neu installierst."
            lblChangelog.Text = "Eine genaue Änderungsliste kann im                           gefunden werden"
            btnOK.Text = "Alles klar!"
        End If
    End Sub

    Private Sub LoadDesign()
        'Set to darkmode if design dark is selected
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