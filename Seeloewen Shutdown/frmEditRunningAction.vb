Public Class frmEditRunningAction

    '-- Event Handlers --

    Private Sub frmEditRunningAction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user settings
        LoadDesign()
        LoadLanguage()

        'Get default settings
        rbtnShutdown.Checked = True
        rbtnAdd.Checked = True
        For Each item As String In frmMain.cbxIn.Items
            cbxAdd.Items.Add(item)
            cbxRemove.Items.Add(item)
        Next
        cbxAdd.SelectedIndex = 1
        cbxRemove.SelectedIndex = 1
        tbAdd.Clear()
        tbRemove.Clear()
        dtpDate.Value = DateTime.Now
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
    End Sub

    Private Sub rbtnAdd_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnAdd.CheckedChanged
        'Toggle the controls
        If rbtnAdd.Checked = True Then
            tbAdd.Enabled = True
            tbRemove.Enabled = False
            cbxAdd.Enabled = True
            cbxRemove.Enabled = False
            dtpDate.Enabled = False
        ElseIf rbtnRemove.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = True
            cbxAdd.Enabled = False
            cbxRemove.Enabled = True
            dtpDate.Enabled = False
        ElseIf rbtnPointInTime.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = False
            cbxAdd.Enabled = False
            cbxRemove.Enabled = False
            dtpDate.Enabled = True
        End If
    End Sub

    Private Sub rbtnRemove_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRemove.CheckedChanged
        'Toggle the controls
        If rbtnAdd.Checked = True Then
            tbAdd.Enabled = True
            tbRemove.Enabled = False
            cbxAdd.Enabled = True
            cbxRemove.Enabled = False
            dtpDate.Enabled = False
        ElseIf rbtnRemove.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = True
            cbxAdd.Enabled = False
            cbxRemove.Enabled = True
            dtpDate.Enabled = False
        ElseIf rbtnPointInTime.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = False
            cbxAdd.Enabled = False
            cbxRemove.Enabled = False
            dtpDate.Enabled = True
        End If
    End Sub

    Private Sub rbtnPointInTime_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPointInTime.CheckedChanged
        'Toggle the controls
        If rbtnAdd.Checked = True Then
            tbAdd.Enabled = True
            tbRemove.Enabled = False
            cbxAdd.Enabled = True
            cbxRemove.Enabled = False
            dtpDate.Enabled = False
        ElseIf rbtnRemove.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = True
            cbxAdd.Enabled = False
            cbxRemove.Enabled = True
            dtpDate.Enabled = False
        ElseIf rbtnPointInTime.Checked = True Then
            tbAdd.Enabled = False
            tbRemove.Enabled = False
            cbxAdd.Enabled = False
            cbxRemove.Enabled = False
            dtpDate.Enabled = True
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Set action
        Dim action As String = "Shutdown"
        If rbtnShutdown.Checked = True Then
            If frmMain.Language = "English" Then
                action = "Shutdown"
            ElseIf frmMain.Language = "German" Then
                action = "Herunterfahren"
            End If
        ElseIf rbtnRestart.Checked = True Then
            If frmMain.Language = "English" Then
                action = "Restart"
            ElseIf frmMain.Language = "German" Then
                action = "Neustart"
            End If
        End If

        'Set change type
        Dim changeType As String = "Add"
        If rbtnAdd.Checked = True Then
            changeType = "Add"
        ElseIf rbtnRemove.Checked = True Then
            changeType = "Remove"
        ElseIf rbtnPointInTime.Checked = True Then
            changeType = "PointInTime"
        End If

        'Set change time
        Dim change As String = 0
        If rbtnAdd.Checked = True Then
            If cbxAdd.SelectedIndex = 0 Then
                change = Convert.ToInt32(tbAdd.Text).ToString
            ElseIf cbxAdd.SelectedIndex = 1 Then
                change = (Convert.ToInt32(tbAdd.Text) * 60).ToString
            ElseIf cbxAdd.SelectedIndex = 2 Then
                change = (Convert.ToInt32(tbAdd.Text) * 3600).ToString
            End If
        ElseIf rbtnRemove.Checked = True Then
            If cbxRemove.SelectedIndex = 0 Then
                change = Convert.ToInt32(tbRemove.Text)
            ElseIf cbxRemove.SelectedIndex = 1 Then
                change = (Convert.ToInt32(tbRemove.Text) * 60).ToString
            ElseIf cbxRemove.SelectedIndex = 2 Then
                change = (Convert.ToInt32(tbRemove.Text) * 3600).ToString
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            change = dtpDate.Value.ToString()
        End If

        'Edit the running action and show confirmation
        Close()
        frmMain.EditRunningAction(action, changeType, change, True)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close without changing anything
        Close()
    End Sub

    Private Sub tbAdd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAdd.KeyPress
        'Makes the textbox only accept numbers
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub tbRemove_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRemove.KeyPress
        'Makes the textbox only accept numbers
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub
    '-- Custom Methods --
    Private Sub LoadDesign()
        'Change to darkmode if design is set to dark
        If frmMain.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblEditRunningActionHeader.ForeColor = Color.White
            lblEditRunningActionDesc.ForeColor = Color.White
            lblAction.ForeColor = Color.White
            lblTime.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            rbtnAdd.ForeColor = Color.White
            rbtnRemove.ForeColor = Color.White
            rbtnPointInTime.ForeColor = Color.White
            tbAdd.ForeColor = Color.White
            tbRemove.ForeColor = Color.White
            cbxAdd.ForeColor = Color.White
            cbxRemove.ForeColor = Color.White
            tbRemove.BackColor = Color.Gray
            tbAdd.BackColor = Color.Gray
            cbxRemove.BackColor = Color.Gray
            cbxAdd.BackColor = Color.Gray
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements to selected language
        If frmMain.Language = "German" Then
            lblEditRunningActionHeader.Text = "Laufende Aktion bearbeiten"
            lblEditRunningActionDesc.Text = "Nicht zufrieden mit der aktuellen Aktion? Hier kannst du die Aktion ändern, Zeit" + vbNewLine + "hinzufügen oder entfernen oder einen neuen Zeitpunkt festlegen."
            btnCancel.Text = "Abbrechen"
            btnSave.Text = "Speichern"
            Text = "Laufende Aktion bearbeiten"
            lblAction.Text = "Aktion                                                        "
            lblTime.Text = "Zeit                                                "
            rbtnShutdown.Text = "Herunterfahren"
            rbtnRestart.Text = "Neustarten"
            rbtnAdd.Text = "Hinzufügen..."
            rbtnRemove.Text = "Entfernen..."
            rbtnPointInTime.Text = "Zeitpunkt"
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