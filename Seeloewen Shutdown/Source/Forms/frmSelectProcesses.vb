Public Class frmSelectProcesses

    '-- Event Handlers --

    Private Sub btnSelectFromOpenProcesses_Click(sender As Object, e As EventArgs) Handles btnSelectFromOpenProcesses.Click
        'Show open process selector
        frmSearchProcesses.ShowDialog()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check if the process check file exists and write list to it
        If My.Computer.FileSystem.FileExists(frmMain.processCheckFile) Then
            My.Computer.FileSystem.WriteAllText(frmMain.processCheckFile, rtbProcesses.Text, False)
        Else
            If frmMain.language = "English" Then
                MsgBox("The Process Check File does not exist. Please restart your application.", MsgBoxStyle.Critical, "Error")
            ElseIf frmMain.language = "German" Then
                MsgBox("Die Prozess-Prüf-Datei existiert nicht. Bitte starte deine App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
        Close()
    End Sub

    Private Sub frmSelectProcesses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user settings
        LoadDesign()
        LoadLanguage()

        'Load the process list from file
        rtbProcesses.Text = My.Computer.FileSystem.ReadAllText(frmMain.processCheckFile)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close without saving
        Close()
    End Sub

    '-- Custom Methods --

    Private Sub LoadDesign()
        'Change to darkmode if design is set to dark
        If frmMain.design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblProcessSelectionHeader.ForeColor = Color.White
            lblProcessSelectionDesc.ForeColor = Color.White
            gbProcesses.ForeColor = Color.White
            rtbProcesses.BackColor = Color.FromArgb(41, 41, 41)
            rtbProcesses.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements to selected language
        If frmMain.language = "German" Then
            lblProcessSelectionHeader.Text = "Prozesse auswählen"
            lblProcessSelectionDesc.Text = "Die folgende List enthält die Namen von Prozessen. Alle Aktionen werden, wenn aktiviert, verzögert wenn eine der" + vbNewLine + "folgenden Prozesse läuft. Du kannst außerdem den Prozess-Sucher nutzen, um einen der aktuell laufenden" + vbNewLine + "Prozesse zur Liste hinzuzufügen."
            btnSelectFromOpenProcesses.Text = "Von laufenden Prozessen auswählen..."
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
            Text = "Prozesse auswählen"
        End If
    End Sub

    '-- Button Animations --

    Private Sub btnSave_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSave.MouseDown
        btnSave.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSave_MouseEnter(sender As Object, e As EventArgs) Handles btnSave.MouseEnter
        btnSave.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSave.MouseUp
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSelectFromOpenProcesses_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSelectFromOpenProcesses.MouseDown
        btnSelectFromOpenProcesses.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSelectFromOpenProcesses_MouseEnter(sender As Object, e As EventArgs) Handles btnSelectFromOpenProcesses.MouseEnter
        btnSelectFromOpenProcesses.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSelectFromOpenProcesses_MouseLeave(sender As Object, e As EventArgs) Handles btnSelectFromOpenProcesses.MouseLeave
        btnSelectFromOpenProcesses.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSelectFromOpenProcesses_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSelectFromOpenProcesses.MouseUp
        btnSelectFromOpenProcesses.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.BackgroundImage = My.Resources.button
    End Sub
End Class