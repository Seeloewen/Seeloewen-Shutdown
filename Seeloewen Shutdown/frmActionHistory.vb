Imports System.IO

Public Class frmActionHistory

    Dim ClearMsgBoxText As String
    Dim ClearMsgBoxHeader As String

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        If My.Settings.Language = "German" Then
            ClearMsgBoxHeader = "Liste leeren"
            ClearMsgBoxText = "Bist du dir sicher, dass du die Liste leeren möchtest?"
        ElseIf My.Settings.Language = "English" Then
            ClearMsgBoxHeader = "Clear list"
            ClearMsgBoxText = "Are you sure that you want to clear the list?"
        End If

        Select Case MsgBox(ClearMsgBoxText, MsgBoxStyle.YesNo, ClearMsgBoxHeader)
            Case Windows.Forms.DialogResult.Yes
                lvActionHistory.Clear()
                My.Computer.FileSystem.WriteAllText(frmMain.AppData + "/Seeloewen Shutdown/ActionHistory.txt", "", False)
        End Select
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub frmActionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActionHistory()
    End Sub

    Private Sub LoadActionHistory()
        For Each line As String In File.ReadAllLines(frmMain.AppData + "/Seeloewen Shutdown/ActionHistory.txt")
            Dim items As String() = line.Split(";"c)
            Dim lvItem As ListViewItem
            lvItem = New ListViewItem(items)
            lvActionHistory.Items.Add(lvItem)
        Next
    End Sub
End Class