Imports System.IO

Public Class frmProfileEditor

    Dim ProfileDirectory As String = frmMain.ProfileDirectory
    Dim ProfileList As String()
    Dim ProfileContent As String()
    Dim LoadFromProfile As String
    Dim cbxIn As String
    Dim tbTime As String
    Dim rbtnAction As String
    Dim MsgBoxTextCorruptedProfile As String
    Dim MsgBoxHeaderCorruptedProfile As String


    '-- Event handlers --

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Reset controls back to default state
        cbxProfile.Items.Clear()
        rbtnShutdown.Checked = True
        tbTimeIn.Text = ""
        cbxInTime.SelectedIndex = 0

        'Get profiles and load user settings
        GetFiles(ProfileDirectory)
        LoadDesign()
        LoadLanguage()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save currently loaded profile
        SaveProfile(cbxProfile.SelectedItem)
    End Sub

    Private Sub SaveProfile(Profile As String)
        'Load selected radiobutton into variable
        If rbtnShutdown.Checked Then
            rbtnAction = "Shutdown"
        ElseIf rbtnRestart.Checked Then
            rbtnAction = "Restart"
        End If

        'Load textbox and combobox text into variable
        tbTime = tbTimeIn.Text
        cbxIn = cbxInTime.Text

        'Check if a valid profile is selected and if a profile directory exists. If yes, save and overwrite the profile
        If String.IsNullOrEmpty(Profile) = False Then
            My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory)
            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + Profile + ".txt", rbtnAction + vbNewLine + tbTime + vbNewLine + cbxIn, False)

            if frmmain.Language = "English" Then
                MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
            Elseif frmmain.Language = "German" Then
                MsgBox("Profil wurde überschrieben und gespeichert.", MsgBoxStyle.Information, "Überschrieben und gespeichert.")
            End If
            frmMain.WriteToLog("Saved and overwrote profile " + Profile, "Info")
        Else

            if frmmain.Language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            Elseif frmmain.Language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close the current window
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete the currently selected profile (Deletes the profile file and combobox entry
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DeleteFile(frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + cbxProfile.SelectedItem + ".txt")
            if frmmain.Language = "English" Then
                MsgBox("Profile was deleted.", MsgBoxStyle.Information, "Deleted")
            Elseif frmmain.Language = "German" Then
                MsgBox("Profil wurde gelöscht.", MsgBoxStyle.Information, "Gelöscht")
            End If
            frmMain.WriteToLog("Deleted profile " + cbxProfile.SelectedItem, "Info")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            if frmmain.Language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            Elseif frmmain.Language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        'Begin loading the profile
        InitializeLoadingProfile(cbxProfile.SelectedItem, False)
    End Sub

    '-- Custom methods --

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.ProfileDirectory + Profile + ".txt"
            ProfileContent = File.ReadAllLines(LoadFromProfile)
            ReDim Preserve ProfileContent(3)
            CheckAndConvertProfile(Profile, ShowMessage)
        Else
            if frmmain.Language = "German" Then
                MsgBox("Fehler: Kein Profil ausgewählt. Bitte wähle ein Profil, das geladen werden soll.", MsgBoxStyle.Critical, "Fehler")
            Elseif frmmain.Language = "English" Then
                MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(ProfileContent(0)) OrElse String.IsNullOrEmpty(ProfileContent(1)) OrElse String.IsNullOrEmpty(ProfileContent(2))) Then
            Select Case MsgBox(MsgBoxTextCorruptedProfile, vbQuestion + vbYesNo, MsgBoxHeaderCorruptedProfile)
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(ProfileContent(0)) Then
                        ProfileContent(0) = "Shutdown"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(1)) Then
                        ProfileContent(1) = "10"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(2)) Then
                        ProfileContent(2) = "Minute(s)"
                    End If
                    LoadProfile(Profile, False)
                    SaveProfile(Profile)
                    if frmmain.Language = "English" Then
                        MsgBox("Loaded and updated profile. It should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                    Elseif frmmain.Language = "German" Then
                        MsgBox("Profil wurde geladen und aktualisiert. Es sollte nun korrekt funktionieren!", MsgBoxStyle.Information, "Profil geladen und aktualisiert")
                    End If

                Case Windows.Forms.DialogResult.No
                    if frmmain.Language = "English" Then
                        MsgBox("Cancelled loading profile.", MsgBoxStyle.Exclamation, "Warning")
                    Elseif frmmain.Language = "German" Then
                        MsgBox("Laden des Profils abgebrochen.", MsgBoxStyle.Exclamation, "Warnung")
                    End If

            End Select
        Else
            LoadProfile(Profile, ShowMessage)
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean)
        'Load settings from profile
        rbtnAction = profilecontent(0)
        If rbtnAction = "Shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf rbtnAction = "Restart" Then
            rbtnRestart.Checked = True
        End If

        tbTimeIn.Text = ProfileContent(1)
        cbxIn = ProfileContent(2)

        'Convert combobox selection to current language
        if frmmain.Language = "German" Then
            If cbxIn = "Second(s)" Then
                cbxIn = "Sekunde(n)"
            ElseIf cbxIn = "Minute(s)" Then
                cbxIn = "Minute(n)"
            ElseIf cbxIn = "Hour(s)" Then
                cbxIn = "Stunde(n)"
            End If
        Elseif frmmain.Language = "English" Then
            If cbxIn = "Sekunde(n)" Then
                cbxIn = "Second(s)"
            ElseIf cbxIn = "Minute(n)" Then
                cbxIn = "Minute(s)"
            ElseIf cbxIn = "Stunde(n)" Then
                cbxIn = "Hour(s)"
            End If
        End If

        cbxInTime.SelectedItem = cbxIn

        'If ShowMessage is enabled, it will show a messagebox when loading completes.
        If ShowMessage Then
            if frmmain.Language = "German" Then
                MsgBox("Profil " + Profile + " geladen.", MsgBoxStyle.Information, "Profil geladen")
            ElseIf My.Settings.Language = "Englisch" Then
                MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
            End If
        End If
    End Sub

    Private Sub LoadDesign()
        'Set design to darkmode if setting is set to dark
        if frmmain.Design = "Dark" Then
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
        'Translate elements if language is set to German
        if frmmain.Language = "German" Then
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
            MsgBoxTextCorruptedProfile = "Du versucht ein beschädigtes Profil oder ein Profil von einer älteren Version zu laden. Du musst es aktualisieren, um es zu laden. Normalerweise verlierst du keine Einstellungen. Möchtest du fortfahren?"
            MsgBoxHeaderCorruptedProfile = "Altes oder beschädigtes Profil laden"
        Elseif frmmain.Language = "English" Then
            MsgBoxTextCorruptedProfile = "You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?"
            MsgBoxHeaderCorruptedProfile = "Load old or corrupted profile"
        End If
    End Sub

    Sub GetFiles(Path As String)
        'Get profile files in profile directory and load them into combobox
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
            if frmmain.Language = "English" Then
                MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            Elseif frmmain.Language = "German" Then
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