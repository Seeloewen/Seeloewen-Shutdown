Imports System.IO

Public Class frmActionHistory

    Dim ClearMsgBoxText As String
    Dim ClearMsgBoxHeader As String

    Private Sub frmActionHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadActionHistory()
        EnableDarkmode()
        ChangeLanguageToGerman()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        SetMessageboxLanguage()
        ShowClearHistoryMsgBox()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub EnableDarkmode() 'Change to darkmode if design is set to dark
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblPastActionsDesc.ForeColor = Color.White
            lblPastActionsHeader.ForeColor = Color.White
            lvActionHistory.BackColor = Color.FromArgb(41, 41, 41)
            lvActionHistory.ForeColor = Color.White
        End If
    End Sub

    Private Sub ChangeLanguageToGerman() 'Translate elements to german if language is set to german
        If My.Settings.Language = "German" Then
            lblPastActionsHeader.Text = "Aktionsverlauf"
            lblPastActionsDesc.Text = "Betrachte deine vergangenen Aktionen."
            lvActionHistory.Columns(0).Text = "Aktion"
            lvActionHistory.Columns(1).Text = "Zeit"
            lvActionHistory.Columns(2).Text = "Ausgeführt am"
            btnClear.Text = "Aktionsverlauf leeren"
            btnClose.Text = "Schließen"
            Text = "Aktionsverlauf"
        End If
    End Sub

    Private Sub SetMessageboxLanguage() 'Change text of the messagebox based on the language
        If My.Settings.Language = "German" Then
            ClearMsgBoxHeader = "Liste leeren"
            ClearMsgBoxText = "Bist du dir sicher, dass du die Liste leeren möchtest?"
        ElseIf My.Settings.Language = "English" Then
            ClearMsgBoxHeader = "Clear list"
            ClearMsgBoxText = "Are you sure that you want to clear the list?"
        End If
    End Sub

    Private Sub ShowClearHistoryMsgBox() 'Show messagebox, clicking "yes" will result in the Action History file being cleared
        Select Case MsgBox(ClearMsgBoxText, MsgBoxStyle.YesNo, ClearMsgBoxHeader)
            Case Windows.Forms.DialogResult.Yes
                lvActionHistory.Clear()
                My.Computer.FileSystem.WriteAllText(frmMain.AppData + "/Seeloewen Shutdown/ActionHistory.txt", "", False)
        End Select
    End Sub

    Private Sub LoadActionHistory() 'Adds all lines in the file into the listview
        For Each line As String In File.ReadAllLines(frmMain.AppData + "/Seeloewen Shutdown/ActionHistory.txt")
            Dim items As String() = line.Split(";"c)
            Dim lvItem As ListViewItem
            lvItem = New ListViewItem(items)
            lvActionHistory.Items.Add(lvItem)
        Next
    End Sub

    'Button animations
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