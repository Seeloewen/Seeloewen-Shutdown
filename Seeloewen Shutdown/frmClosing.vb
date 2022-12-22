Public Class frmClosing

    '-- Event handlers --
    Private Sub frmClosing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If no action gets chosen, it will default to "close"
        frmMain.ClosingResult = "Close"

        'Load settings
        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the main window and exit the application
        If cbDontShowAgain.Checked = True Then
            My.Settings.ShowCloseWarning = False
        Else
            My.Settings.ShowCloseWarning = True
        End If
        frmSettings.Visible = False
        frmSettings.Show()
        frmSettings.ShowMessage = False
        frmSettings.SaveSettings(frmMain.SettingsFile)
        frmSettings.Close()
        frmMain.ClosingResult = "Close"
        Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Close this window and return to the main window
        If cbDontShowAgain.Checked = True Then
            My.Settings.ShowCloseWarning = False
        Else
            My.Settings.ShowCloseWarning = True
        End If
        frmSettings.Visible = False
        frmSettings.Show()
        frmSettings.ShowMessage = False
        frmSettings.SaveSettings(frmMain.SettingsFile)
        frmSettings.Close()
        frmMain.ClosingResult = "Return"
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadLanguage()
        If My.Settings.Language = "German" Then
            lblHeader.Text = "Bitte beachte..."
            lblDescription.Text = "Die aktuell ausgeführte Aktion läuft weiter, wenn du" + vbNewLine + "die App schließt. Um die Aktion abzubrechen," + vbNewLine + "kehre ins Hauptmenü zurück und klicke auf 'Aktion stoppen'"
            btnReturn.Text = "Zurück"
            btnClose.Text = "App schließen"
            cbDontShowAgain.Text = "Nicht erneut anzeigen"
        End If
    End Sub

    Private Sub LoadDesign()
        If My.Settings.Design = "Dark" Then
            lblHeader.ForeColor = Color.White
            lblDescription.ForeColor = Color.White
            cbDontShowAgain.ForeColor = Color.White
            BackColor = Color.FromArgb(41, 41, 41)
            pbButtonBackground.BackColor = Color.FromArgb(27, 27, 27)
        End If
    End Sub

    '-- Button designs --

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnReturn_MouseDown(sender As Object, e As MouseEventArgs) Handles btnReturn.MouseDown
        btnReturn.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnReturn_MouseEnter(sender As Object, e As EventArgs) Handles btnReturn.MouseEnter
        btnReturn.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnReturn_MouseLeave(sender As Object, e As EventArgs) Handles btnReturn.MouseLeave
        btnReturn.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnReturn_MouseUp(sender As Object, e As MouseEventArgs) Handles btnReturn.MouseUp
        btnReturn.BackgroundImage = My.Resources.button_click
    End Sub
End Class