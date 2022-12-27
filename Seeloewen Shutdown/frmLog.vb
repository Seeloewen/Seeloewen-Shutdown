Public Class frmLog

    '-- Event handlers --

    Private Sub frmLog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user preferences
        LoadDesign()
        LoadLanguage()

        'Loads log from file
        rtbLog.LoadFile(frmMain.AppData + "/Seeloewen Shutdown/DebugLogTemp")
    End Sub

    Private Sub btnSaveAsFile_Click(sender As Object, e As EventArgs) Handles btnSaveAsFile.Click
        'Show dialog for saving the log
        sfdLog.ShowDialog()
    End Sub

    Private Sub sfdLog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles sfdLog.FileOk
        'Write log to selected file
        My.Computer.FileSystem.WriteAllText(sfdLog.FileName, rtbLog.Text, False)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click 'Clears log in both this window and main window
        'Clear log in both windows
        rtbLog.Clear()
        frmMain.rtbLog.Clear()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close current window
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        'Set design to darkmode if setting is set to dark
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblHeader.ForeColor = Color.White
            rtbLog.BackColor = Color.FromArgb(41, 41, 41)
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements if language is set to German
        If My.Settings.Language = "German" Then
            sfdLog.Title = "Speichere Log als Datei..."
            btnSaveAsFile.Text = "Als Datei speichern"
            btnClear.Text = "Leeren"
            btnClose.Text = "Schließen"
        End If
    End Sub

    '-- Button designs --

    Private Sub btnSaveAsFile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSaveAsFile.MouseDown
        btnSaveAsFile.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSaveAsFile_MouseEnter(sender As Object, e As EventArgs) Handles btnSaveAsFile.MouseEnter
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

    Private Sub btnClear_MouseEnter(sender As Object, e As EventArgs) Handles btnClear.MouseEnter
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

    Private Sub btnClose_MouseEnter(sender As Object, e As EventArgs) Handles btnClose.MouseEnter
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub
End Class