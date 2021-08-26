Public Class frmHilfe
    Private Sub btnFrmMain_Click(sender As Object, e As EventArgs) Handles btnFrmMain.Click
        pbHelp.Image = My.Resources.frmMain
        gbHelp.Text = "Hauptfenster"
    End Sub

    Private Sub btnFrmSettings_Click(sender As Object, e As EventArgs) Handles btnFrmSettings.Click
        pbHelp.Image = My.Resources.frmSettings
        gbHelp.Text = "Einstellungen"
    End Sub

    Private Sub btnFrmInformation_Click(sender As Object, e As EventArgs) Handles btnFrmInformation.Click
        pbHelp.Image = My.Resources.frmAbout
        gbHelp.Text = "Informationen"
    End Sub

    Private Sub btnFrmFinish_Click(sender As Object, e As EventArgs) Handles btnFrmFinish.Click
        pbHelp.Image = My.Resources.frmFinish
        gbHelp.Text = "Mitteilung"
    End Sub

    Private Sub btnFrmUpdate_Click(sender As Object, e As EventArgs) Handles btnFrmUpdate.Click
        pbHelp.Image = My.Resources.frmUpdate
        gbHelp.Text = "Update"
    End Sub

    Private Sub btnFrmChangelog_Click(sender As Object, e As EventArgs) Handles btnFrmChangelog.Click
        pbHelp.Image = My.Resources.frmChangelog
        gbHelp.Text = "Changelog"
    End Sub
End Class