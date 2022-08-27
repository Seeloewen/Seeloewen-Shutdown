Public Class frmSaveProfileAs

    Dim SaveMsgBoxHeader As String
    Dim SaveMsgBoxText As String
    Dim rbtnAction As String
    Dim tbTime As String
    Dim cbxIn As String

    '-- Method handlers --

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSaveProfileAs.Clear()
        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If frmMain.rbtnShutdown.Checked Then
            rbtnAction = "Shutdown"
        ElseIf frmMain.rbtnRestart.Checked Then
            rbtnAction = "Restart"
        End If

        tbTime = frmMain.tbTime.Text
        cbxIn = frmMain.cbxIn.Text

        If My.Settings.Language = "English" Then
            SaveMsgBoxHeader = "Profile already exists"
            SaveMsgBoxText = "A profile with this name already exists. Do you want to overwrite it?"
        ElseIf My.Settings.Language = "German" Then
            SaveMsgBoxHeader = "Profil existiert bereits"
            SaveMsgBoxText = "Ein Profil mit diesem Namen existiert bereits. Möchtest du es überschreiben?"
        End If

        If String.IsNullOrEmpty(tbSaveProfileAs.Text) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
                If My.Computer.FileSystem.FileExists(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + tbSaveProfileAs.Text + ".txt") Then
                    Select Case MessageBox.Show(SaveMsgBoxText, SaveMsgBoxHeader, MessageBoxButtons.YesNo)
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + tbSaveProfileAs.Text + ".txt", rbtnAction + vbNewLine + tbTime + vbNewLine + cbxIn, False)
                            If My.Settings.Language = "English" Then
                                MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                            ElseIf My.Settings.Language = "German" Then
                                MsgBox("Profil wurde übershrieben und gespeichert.", MsgBoxStyle.Information, "Überschrieben und gespeichert")
                            End If
                            frmMain.WriteToLog("Saved and overwrote profile " + tbSaveProfileAs.Text, "Info")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            If My.Settings.Language = "English" Then
                                MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                            ElseIf My.Settings.Language = "German" Then
                                MsgBox("Profil wurde nicht überschrieben. Bitte wähle einen anderen Profilnamen.", MsgBoxStyle.Exclamation, "Profil nicht überschrieben.")
                            End If
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + tbSaveProfileAs.Text + ".txt", rbtnAction + vbNewLine + tbTime + vbNewLine + cbxIn, False)
                    If My.Settings.Language = "English" Then
                        MsgBox("Profile was saved.", MsgBoxStyle.Information, "Saved")
                    ElseIf My.Settings.Language = "German" Then
                        MsgBox("Profil wurde gespeichert.", MsgBoxStyle.Information, "Gespeichert")
                    End If
                    frmMain.WriteToLog("Saved new profile " + tbSaveProfileAs.Text, "Info")
                    Close()
                End If
            Else
                If My.Settings.Language = "English" Then
                    MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
                ElseIf My.Settings.Language = "German" Then
                    MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
                End If
            End If
                Else
            If My.Settings.Language = "English" Then
                MsgBox("Error: Profile name is empty. Please enter a profile name.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Profilname ist leer. Bitte gib einen Profilnamen ein.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblSaveProfileAs.ForeColor = Color.White
            tbSaveProfileAs.BackColor = Color.Gray
            tbSaveProfileAs.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        If My.Settings.Language = "German" Then
            Text = "Profil speichern als..."
            lblSaveProfileAs.Text = "Profil speichern als..."
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
        End If
    End Sub

    '-- Button designs --

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