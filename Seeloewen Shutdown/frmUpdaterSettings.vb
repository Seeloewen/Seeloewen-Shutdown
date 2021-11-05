Public Class frmUpdaterSettings
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Save Settings

        'Close
        Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Show Dialog, that clicking "Cancel" doesn't save options
        Select Case MsgBox("Möchtest du die Updater-Einstellungen wirklich schließen ohne Änderungen zu speichern?", MsgBoxStyle.YesNo, "Einstellungen verwerfen")
            Case Windows.Forms.DialogResult.Yes
                Me.Close()
            Case Windows.Forms.DialogResult.No
        End Select
    End Sub

    Private Sub btnUseDefaultUpdater_Click(sender As Object, e As EventArgs) Handles btnUseDefaultUpdater.Click
        tbNewestUpdaterLink.Text = "https://github.com/Seeloewen/Seeloewen-Shutdown-Update/blob/main/Latest%20Build/Seeloewen-Shutdown-Update.exe?raw=true"
    End Sub
End Class