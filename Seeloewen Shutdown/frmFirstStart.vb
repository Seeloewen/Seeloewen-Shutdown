Public Class frmFirstStart
    Private Sub frmFirstStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxLanguage.SelectedItem = "English (English)"
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.Language = "English"
            Close()
        ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.Language = "German"
            Close()
        Else msgbox("Please pick a Language!")
        End If
    End Sub

    Private Sub btnOK_MouseDown(sender As Object, e As MouseEventArgs) Handles btnOK.MouseDown
        btnOK.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnOK_MouseHover(sender As Object, e As EventArgs) Handles btnOK.MouseHover
        btnOK.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnOK_MouseLeave(sender As Object, e As EventArgs) Handles btnOK.MouseLeave
        btnOK.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnOK_MouseUp(sender As Object, e As MouseEventArgs) Handles btnOK.MouseUp
        btnOK.BackgroundImage = My.Resources.button
    End Sub
End Class