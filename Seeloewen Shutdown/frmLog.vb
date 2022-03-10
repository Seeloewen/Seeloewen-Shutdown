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

    Private Sub btnSaveAsFile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSaveAsFile.MouseDown
        btnSaveAsFile.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSaveAsFile_MouseHover(sender As Object, e As EventArgs) Handles btnSaveAsFile.MouseHover
        btnSaveAsFile.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSaveAsFile_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveAsFile.MouseLeave
        btnSaveAsFile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSaveAsFile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSaveAsFile.MouseUp
        btnSaveAsFile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClear_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClear.MouseDown
        btnClear.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClear_MouseHover(sender As Object, e As EventArgs) Handles btnClear.MouseHover
        btnClear.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClear_MouseLeave(sender As Object, e As EventArgs) Handles btnClear.MouseLeave
        btnClear.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClear_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClear.MouseUp
        btnClear.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub
End Class