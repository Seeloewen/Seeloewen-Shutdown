Public Class frmFirstStart

    '-- Event handlers --

    Private Sub frmFirstStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Selects English by default
        cbxLanguage.SelectedItem = "English (English)"

        If frmMain.Language = "German" Then
            MsgBox("Du hast irgendwie ein Legacy-Fenster gefunden, welches nicht mehr von der Software genutzt wird. Sei vorsichtig, da Probleme auftreten können.", MsgBoxStyle.Exclamation, "Warnung")

        ElseIf frmMain.Language = "English" Then
            MsgBox("You have somehow opened a legacy window that is no longer used by the software. Be careful as issues can occur.", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'Saves settings and closes this window
        If cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.Language = "English"
            Close()
        ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.Language = "German"
            Close()
        Else MsgBox("Please pick a Language!")
        End If
    End Sub

    '-- Button designs --

    Private Sub btnOK_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOK.MouseDown
        btnOK.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOK_MouseEnter(sender As Object, e As EventArgs) Handles btnOK.MouseEnter
        btnOK.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOK.MouseUp
        btnOK.BackgroundImage = My.Resources.button
    End Sub
End Class