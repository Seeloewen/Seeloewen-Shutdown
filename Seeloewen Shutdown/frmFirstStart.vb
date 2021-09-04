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
End Class