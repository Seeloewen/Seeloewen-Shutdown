Public Class frmLog

    Private Sub btnSaveAsFile_Click(sender As Object, e As EventArgs) Handles btnSaveAsFile.Click
        sfdLog.ShowDialog()
    End Sub

    Private Sub sfdLog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfdLog.FileOk
        My.Computer.FileSystem.WriteAllText(sfdLog.FileName, rtbLog.Text, False)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rtbLog.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class