Public Class frmSaveProfileAs

    Dim SaveMsgBoxHeader As String
    Dim SaveMsgBoxText As String
    Dim rbtnAction As String
    Dim tbTime As String
    Dim cbxIn As String

    '-- Method handlers --

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear already existing text
        tbSaveProfileAs.Clear()

        'Load user preferences
        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Load selected radiobutton into variable
        If frmMain.rbtnShutdown.Checked Then
            rbtnAction = "Shutdown"
        ElseIf frmMain.rbtnRestart.Checked Then
            rbtnAction = "Restart"
        End If

        'Load textbox and combobox text into variable
        tbTime = frmMain.tbTime.Text
        cbxIn = frmMain.cbxIn.Text

        'Save profile if the profile directory exists. If the profile already exists, give user option to overwrite it.
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
        'Close the current window
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        'Set design to darkmode if setting is set to dark
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblSaveProfileAs.ForeColor = Color.White
            tbSaveProfileAs.BackColor = Color.Gray
            tbSaveProfileAs.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements if language is set to German
        If My.Settings.Language = "German" Then
            Text = "Profil speichern als..."
            lblSaveProfileAs.Text = "Profil speichern als..."
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
            SaveMsgBoxHeader = "Profil existiert bereits"
            SaveMsgBoxText = "Ein Profil mit diesem Namen existiert bereits. Möchtest du es überschreiben?"
        ElseIf My.Settings.Language = "English" Then
            SaveMsgBoxHeader = "Profile already exists"
            SaveMsgBoxText = "A profile with this name already exists. Do you want to overwrite it?"
        End If
    End Sub

    Public Sub UpdateProfile(ProfileName)
        'Save profile settings into variables. If no text is given, a placeholder will be inserted
        If frmMain.rbtnShutdown.Checked Then
            rbtnAction = "Shutdown"
        ElseIf frmMain.rbtnRestart.Checked Then
            rbtnAction = "Restart"
        End If
        If String.IsNullOrEmpty(frmMain.tbTime.Text) = False Then
            tbTime = frmMain.tbTime.Text
        Else
            tbTime = "10"
        End If
        If String.IsNullOrEmpty(frmMain.cbxIn.Text) = False Then
            cbxIn = frmMain.cbxIn.Text
        Else
            cbxIn = "Minute(s)"
        End If

        'Update the selected profile. This will save and overwrite the selected profile without showing any warning or message. Used if a profile is old or corrupted.
        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
                My.Computer.FileSystem.WriteAllText(frmMain.ProfileDirectory + ProfileName + ".txt", rbtnAction + vbNewLine + tbTime + vbNewLine + cbxIn, False)
            Else
                If My.Settings.Language = "German" Then
                    MsgBox("Fehler: Profil konnte nicht aktualisiert werden. Profilverzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("Error: Couldn't update profile. Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
                End If
            End If
        Else
            If My.Settings.Language = "German" Then
                MsgBox("Fehler: Profil konnte nicht aktualisiert werden, da der Name leer ist.", MsgBoxStyle.Critical, "Fehler")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("Error: Couldn't update profile as the name is empty.", MsgBoxStyle.Critical, "Error")
            End If

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