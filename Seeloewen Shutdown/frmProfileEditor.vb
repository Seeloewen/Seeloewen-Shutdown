Imports System.IO

Public Class frmProfileEditor

    Dim ProfileDirectory As String = frmMain.ProfileDirectory
    Dim ProfileList As String()
    Dim LoadFromProfile As String
    Dim cbxIn As String
    Dim tbTime As String
    Dim rbtnAction As String

    '-- Event handlers --

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxProfile.Items.Clear()
        rbtnShutdown.Checked = True
        tbTimeIn.Text = ""
        cbxInTime.SelectedIndex = 0
        GetFiles(ProfileDirectory)
        LoadDesign()
        LoadLanguage()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rbtnShutdown.Checked Then
            rbtnAction = "Shutdown"
        ElseIf rbtnRestart.Checked Then
            rbtnAction = "Restart"
        End If

        tbTime = tbTimeIn.Text
        cbxIn = cbxInTime.Text

        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory)
            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + cbxProfile.Text + ".txt", rbtnAction + vbNewLine + tbTime + vbNewLine + cbxIn, False)

            If My.Settings.Language = "English" Then
                MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Profil wurde überschrieben und gespeichert.", MsgBoxStyle.Information, "Überschrieben und gespeichert.")
            End If
            frmMain.WriteToLog("Saved and overwrote profile " + cbxProfile.Text, "Info")
        Else

            If My.Settings.Language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DeleteFile(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + cbxProfile.SelectedItem + ".txt")
            If My.Settings.Language = "English" Then
                MsgBox("Profile was deleted.", MsgBoxStyle.Information, "Deleted")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Profil wurde gelöscht.", MsgBoxStyle.Information, "Gelöscht")
            End If
            frmMain.WriteToLog("Deleted profile " + cbxProfile.SelectedItem, "Info")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        LoadProfile(cbxProfile.SelectedItem)
    End Sub

    '-- Custom methods --

    Private Sub LoadProfile(Profile)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + Profile + ".txt"
            settings.Text = My.Computer.FileSystem.ReadAllText(LoadFromProfile)

            rbtnAction = settings.Lines(0)
            If rbtnAction = "Shutdown" Then
                rbtnShutdown.Checked = True
            ElseIf rbtnAction = "Restart" Then
                rbtnRestart.Checked = True
            End If

            tbTimeIn.Text = settings.Lines(1)
            cbxIn = settings.Lines(2)

            'Convert combobox selection to current language
            If My.Settings.Language = "German" Then
                If cbxIn = "Second(s)" Then
                    cbxIn = "Sekunde(n)"
                ElseIf cbxIn = "Minute(s)" Then
                    cbxIn = "Minute(n)"
                ElseIf cbxIn = "Hour(s)" Then
                    cbxIn = "Stunde(n)"
                End If
            ElseIf My.Settings.Language = "English" Then
                If cbxIn = "Sekunde(n)" Then
                    cbxIn = "Second(s)"
                ElseIf cbxIn = "Minute(n)" Then
                    cbxIn = "Minute(s)"
                ElseIf cbxIn = "Stunde(n)" Then
                    cbxIn = "Hour(s)"
                End If
            End If

            cbxInTime.SelectedItem = cbxIn
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Kein Profil ausgewählt. Bitte wähle ein Profil aus, das geladen werden soll.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub LoadDesign()
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblHeader.ForeColor = Color.White
            lblChooseProfile.ForeColor = Color.White
            cbxProfile.BackColor = Color.Gray
            cbxProfile.ForeColor = Color.White
            gbEditProfile.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            lblIn.ForeColor = Color.White
            tbTimeIn.ForeColor = Color.White
            tbTimeIn.BackColor = Color.Gray
            cbxInTime.ForeColor = Color.White
            cbxInTime.BackColor = Color.Gray
        End If
    End Sub

    Private Sub LoadLanguage()
        If My.Settings.Language = "German" Then
            cbxInTime.Items.Remove("Second(s)")
            cbxInTime.Items.Remove("Minute(s)")
            cbxInTime.Items.Remove("Hour(s)")
            cbxInTime.Items.Add("Sekunde(n)")
            cbxInTime.Items.Add("Minute(n)")
            cbxInTime.Items.Add("Stunde(n)")
            Text = "Profil-Editor"
            lblHeader.Text = "Profil-Editor"
            lblChooseProfile.Text = "Wähle das Profil aus, das du editieren möchtest:"
            gbEditProfile.Text = "Profil editieren"
            rbtnShutdown.Text = "Herunterfahren"
            rbtnRestart.Text = "Neustarten"
            btnSave.Text = "Speichern"
            btnDelete.Text = "Profil löschen"
            btnClose.Text = "Schließen"
        End If
    End Sub

    Sub GetFiles(Path As String)
        frmMain.WriteToLog("Getting profiles for frmProfileEditor...", "Info")

        If Path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(frmMain.AppData + "\Seeloewen Shutdown\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            If My.Settings.Language = "English" Then
                MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Error: Konnte Profile nicht laden. Bitte versuche es erneut." + vbNewLine + "Ausnahme: " + ex.Message, MsgBoxStyle.Critical, "Fehler")
            End If
            frmMain.WriteToLog("Error: Could not load profiles for frmProfileEditor. " + ex.Message, "Error")
        End Try
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

    Private Sub btnDelete_MouseDown(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseDown
        btnDelete.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnDelete_MouseEnter(sender As Object, e As EventArgs) Handles btnDelete.MouseEnter
        btnDelete.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnDelete_MouseLeave(sender As Object, e As EventArgs) Handles btnDelete.MouseLeave
        btnDelete.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnDelete_MouseUp(sender As Object, e As MouseEventArgs) Handles btnDelete.MouseUp
        btnDelete.BackgroundImage = My.Resources.button
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