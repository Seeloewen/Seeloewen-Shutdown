Public Class frmSearchProcesses

    '-- Attributes --

    Dim processCheckboxes As List(Of CheckBox) = New List(Of CheckBox)

    '-- Event Handlers --

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close the window without adding anything
        Close()
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        'Add all selected checkboxes to the list
        For Each checkbox As CheckBox In processCheckboxes
            If checkbox.Checked = True Then
                frmSelectProcesses.rtbProcesses.AppendText(checkbox.Text + vbNewLine)
            End If
        Next
        Close()
    End Sub

    Private Sub frmSearchProcesses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user settings
        LoadDesign()
        LoadLanguage()

        'Get all the currently running processes
        GetProcesses()
    End Sub

    Private Sub btnUpdateList_Click(sender As Object, e As EventArgs) Handles btnUpdateList.Click
        'Get all the currently running processes
        If frmMain.Language = "English" Then
            btnUpdateList.Text = "Updating..."
        ElseIf frmMain.Language = "German" Then
            btnUpdateList.Text = "Aktualisiere..."
        End If
        btnUpdateList.Enabled = False
        GetProcesses()
        If frmMain.Language = "English" Then
            btnUpdateList.Text = "Update List"
        ElseIf frmMain.Language = "German" Then
            btnUpdateList.Text = "Liste aktualisieren"
        End If
        btnUpdateList.Enabled = True
    End Sub

    '-- Custom Methods --
    Private Sub LoadDesign()
        'Change to darkmode if design is set to dark
        If frmMain.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblProcessSearcherHeader.ForeColor = Color.White
            lblProcessSearcherDesc.ForeColor = Color.White
            gbProcesses.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements to selected language
        If frmMain.Language = "German" Then
            lblProcessSearcherHeader.Text = "Prozess-Sucher"
            lblProcessSearcherDesc.Text = "Die folgende Liste enthält alle aktuell laufenden Prozesse. Du kannst Prozesse auswählen" + vbNewLine + "und bestätigen, um sie deiner Liste hinzuzufügen. Prozesse, die bereits auf der Liste sind," + vbNewLine + "werden hier nicht angezeigt."
            btnCancel.Text = "Abbrechen"
            btnUpdateList.Text = "Liste aktualisieren"
            btnConfirm.Text = "Bestätigen"
            Text = "Von laufenden Prozessen auswählen..."
        End If
    End Sub

    Private Sub GetProcesses()
        'Clear previous content
        processCheckboxes.Clear()
        pnlProcesses.Controls.Clear()

        'Get a list of all processes and add a checkbox for each process
        Dim processes() As Process = Process.GetProcesses()
        For Each process As Process In processes
            'Check if the process is already added to the list
            Dim isAdded As Boolean = False
            For Each line As String In frmSelectProcesses.rtbProcesses.Lines
                If line = process.ProcessName Then
                    isAdded = True
                End If
            Next
            If isAdded = False Then
                processCheckboxes.Add(New CheckBox() With {.Text = process.ProcessName, .Width = 500})
            End If
        Next

        'List the checkboxes in the groupbox and update their y-pos accordingly
        Dim yPos As Integer = 0
        For Each checkbox As CheckBox In processCheckboxes
            pnlProcesses.Controls.Add(checkbox)
            checkbox.Location = New Point(10, yPos)
            yPos = yPos + 20
        Next
    End Sub

    Private Sub btnConfirm_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConfirm.MouseDown
        btnConfirm.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnConfirm_MouseEnter(sender As Object, e As EventArgs) Handles btnConfirm.MouseEnter
        btnConfirm.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnConfirm_MouseLeave(sender As Object, e As EventArgs) Handles btnConfirm.MouseLeave
        btnConfirm.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnConfirm_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConfirm.MouseUp
        btnConfirm.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnUpdateList_MouseUp(sender As Object, e As MouseEventArgs) Handles btnUpdateList.MouseUp
        btnUpdateList.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnUpdateList_MouseLeave(sender As Object, e As EventArgs) Handles btnUpdateList.MouseLeave
        btnUpdateList.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnUpdateList_MouseEnter(sender As Object, e As EventArgs) Handles btnUpdateList.MouseEnter
        btnUpdateList.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnUpdateList_MouseDown(sender As Object, e As MouseEventArgs) Handles btnUpdateList.MouseDown
        btnUpdateList.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.BackgroundImage = My.Resources.button_click
    End Sub
End Class