Public Class frmAbout

    '-- Event handlers --

    Private Sub frmAbout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the user preferences
        LoadDesign()
        LoadLanguage()
    End Sub

    Private Sub llblSeeloewenShutdownGithub_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblSeeloewenShutdownGithub.LinkClicked
        'Open Seeloewen Shutdown Github page in default Webbrowser
        Process.Start("https://github.com/Seeloewen/Seeloewen-Shutdown")
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the current window
        Close()
    End Sub

    Private Sub btnChangelog_Click(sender As Object, e As EventArgs) Handles btnChangelog.Click
        'Open changelog
        frmChangelog.Show()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        'Load darkmode if design dark is selected
        If frmMain.design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            rtbInfo.BackColor = Color.FromArgb(41, 41, 41)
            llblSeeloewenShutdownGithub.ForeColor = Color.Cyan
            llblSeeloewenShutdownGithub.LinkColor = Color.Cyan
            lblHeader.ForeColor = Color.White
            lblInfo.ForeColor = Color.White
            gbInfo.ForeColor = Color.White
            rtbInfo.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate strings if language is set to German
        If frmMain.language = "German" Then
            Text = "Über"
            btnClose.Text = "Schließen"
        End If
    End Sub

    '-- button designs --

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnChangelog_MouseDown(sender As Object, e As MouseEventArgs) Handles btnChangelog.MouseDown
        btnChangelog.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnChangelog_MouseEnter(sender As Object, e As EventArgs) Handles btnChangelog.MouseEnter
        btnChangelog.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnChangelog_MouseUp(sender As Object, e As MouseEventArgs) Handles btnChangelog.MouseUp
        btnChangelog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnChangelog_MouseLeave(sender As Object, e As EventArgs) Handles btnChangelog.MouseLeave
        btnChangelog.BackgroundImage = My.Resources.button
    End Sub
End Class