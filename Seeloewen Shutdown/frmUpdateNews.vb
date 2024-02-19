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
        If frmMain.language = "German" Then
            lblHeader.Text = "Version 1.10.0 - Was ist neu?"
            Text = "Seeloewen Shutdown wurde installiert!"
            lblNewsHeader.Text = "Mehrere neue Funktionen"
            lblNews.Text = "Diese Version fügt die Möglichkeit, seine Aktion nach dem Starten des " + vbNewLine + "Timers nochmal zu ändern, hinzu. Außerdem kann man die Aktion ver-" + vbNewLine + "zögern, wenn Prozesse laufen, oder Profile umbenennen."
            lblImprovementsHeader.Text = "Einige Fehlerbehebungen"
            lblImprovements.Text = "Viele nervige Bugs wurden behoben, besonders bezüglich des" + vbNewLine + "Aktionsverlauf-Fensters"
            lblChangelog.Text = "Eine genaue Änderungsliste kann im                           gefunden werden"
            btnOK.Text = "Alles klar!"
        End If
    End Sub

    Private Sub LoadDesign()
        'Set to darkmode if design dark is selected
        If frmMain.design = "Dark" Then
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