﻿Imports System.IO

Public Class frmActionHistory

    Dim ClearMsgBoxText As String
    Dim ClearMsgBoxHeader As String

    '-- Event handlers --

    Private Sub frmActionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user preferences and action history
        LoadActionHistory()
        LoadDesign()
        LoadLanguage()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Show messagebox that allows user to confirm clear
        ShowClearHistoryMsgBox()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close current window
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        'Change to darkmode if design is set to dark
        If frmMain.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblPastActionsDesc.ForeColor = Color.White
            lblPastActionsHeader.ForeColor = Color.White
            lvActionHistory.BackColor = Color.FromArgb(41, 41, 41)
            lvActionHistory.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements to selected language
        If frmMain.Language = "German" Then
            lblPastActionsHeader.Text = "Aktionsverlauf"
            lblPastActionsDesc.Text = "Betrachte deine vergangenen Aktionen."
            lvActionHistory.Columns(0).Text = "Aktion"
            lvActionHistory.Columns(1).Text = "Zeit"
            lvActionHistory.Columns(2).Text = "Gestartet am"
            btnClear.Text = "Aktionsverlauf leeren"
            btnClose.Text = "Schließen"
            Text = "Aktionsverlauf"
            ClearMsgBoxHeader = "Liste leeren"
            ClearMsgBoxText = "Bist du dir sicher, dass du die Liste leeren möchtest?"
        ElseIf frmMain.Language = "English" Then
            ClearMsgBoxHeader = "Clear list"
            ClearMsgBoxText = "Are you sure that you want to clear the list?"
        End If
    End Sub

    Private Sub ShowClearHistoryMsgBox()
        'Show messagebox, clicking "yes" will result in the Action History file being cleared
        Select Case MsgBox(ClearMsgBoxText, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, ClearMsgBoxHeader)
            Case Windows.Forms.DialogResult.Yes
                lvActionHistory.Clear()
                My.Computer.FileSystem.WriteAllText(frmMain.ActionHistoryFile, "", False)
                frmMain.WriteToLog("Cleared Action History", "Info")
        End Select
    End Sub

    Private Sub LoadActionHistory()
        'Adds all lines in the file into the listview
        For Each line As String In File.ReadAllLines(frmMain.ActionHistoryFile)
            Dim items As String() = line.Split(";"c)
            Dim lvItem As ListViewItem
            lvItem = New ListViewItem(items)
            lvActionHistory.Items.Add(lvItem)
        Next
    End Sub

    '-- Button designs --

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