Imports System.IO

Public Class frmLoadProfileFrom

    '-- Attributes --

    Dim profileList As String()
    Dim profileContent As String()
    Dim loadFromProfile As String
    Dim rbtnAction As String
    Dim tbTime As String
    Dim cbxIn As String
    Dim cbDelayAction As String
    Dim msgBoxTextCorruptedProfile As String
    Dim msgBoxHeaderCorruptedProfile As String

    '-- Event handlers --

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load user preferences
        LoadLanguage()
        LoadDesign()

        'If profile directory exists, get all available profiles and delete existing entries
        If My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory) Then
            cbxProfiles.Items.Clear()
            GetFiles(frmMain.profileDirectory)
        Else
            If frmMain.language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            ElseIf frmMain.language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close current window
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Beginn loading the profile
        InitializeLoadingProfile(cbxProfiles.SelectedItem, True)
    End Sub

    '-- Custom methods --
    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean)
        'Load radiobutton selection
        rbtnAction = profileContent(0)
        If rbtnAction = "Shutdown" Then
            frmMain.rbtnShutdown.Checked = True
        ElseIf rbtnAction = "Restart" Then
            frmMain.rbtnRestart.Checked = True
        End If

        'Load text for textbox
        frmMain.tbTime.Text = profileContent(1)

        'Convert combobox selection to current language
        cbxIn = profileContent(2)
        If frmMain.language = "German" Then
            If cbxIn = "Second(s)" Then
                cbxIn = "Sekunde(n)"
            ElseIf cbxIn = "Minute(s)" Then
                cbxIn = "Minute(n)"
            ElseIf cbxIn = "Hour(s)" Then
                cbxIn = "Stunde(n)"
            End If
        ElseIf frmMain.language = "English" Then
            If cbxIn = "Sekunde(n)" Then
                cbxIn = "Second(s)"
            ElseIf cbxIn = "Minute(n)" Then
                cbxIn = "Minute(s)"
            ElseIf cbxIn = "Stunde(n)" Then
                cbxIn = "Hour(s)"
            End If
        End If

        'Load combobox selection
        frmMain.cbxIn.SelectedItem = cbxIn

        'Load checkbox
        cbDelayAction = profileContent(3)
        If cbDelayAction = True Then
            frmMain.cbDelayWhenProcessRunning.Checked = True
        Else
            frmMain.cbDelayWhenProcessRunning.Checked = False
        End If

        'If ShowMessage is enabled, it will show a messagebox when loading completes.
        If ShowMessage = True Then
            If frmMain.language = "English" Then
                MsgBox(String.Format("Loaded profile {0}.", Profile), MsgBoxStyle.Information, "Loaded profile")
            ElseIf frmMain.language = "German" Then
                MsgBox(String.Format("Profil {0} geladen.", Profile), MsgBoxStyle.Information, "Profil geladen")
            End If
        End If
    End Sub

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(Profile) = False Then
            profileContent = File.ReadAllLines(String.Format("{0}{1}.txt", frmMain.profileDirectory, Profile))
            ReDim Preserve profileContent(4)
            CheckAndConvertProfile(Profile, ShowMessage)
            Close()
        Else
            If frmMain.language = "German" Then
                MsgBox("Fehler: Kein Profil ausgewählt. Bitte wähle ein Profil, das geladen werden soll.", MsgBoxStyle.Critical, "Error")
            ElseIf frmMain.language = "English" Then
                MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        'If the method is called before the localisations are loaded, load them
        LoadLanguage()

        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old profile file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If String.IsNullOrEmpty(profileContent(0)) OrElse String.IsNullOrEmpty(profileContent(1)) OrElse String.IsNullOrEmpty(profileContent(2)) OrElse String.IsNullOrEmpty(profileContent(3)) Then
            Select Case MsgBox(msgBoxTextCorruptedProfile, vbQuestion + vbYesNo, msgBoxHeaderCorruptedProfile)
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(profileContent(0)) Then
                        profileContent(0) = "Shutdown"
                    End If
                    If String.IsNullOrEmpty(profileContent(1)) Then
                        profileContent(1) = "10"
                    End If
                    If String.IsNullOrEmpty(profileContent(2)) Then
                        profileContent(2) = "Minute(s)"
                    End If
                    If String.IsNullOrEmpty(profileContent(3)) Then
                        profileContent(3) = "False"
                    End If

                    LoadProfile(Profile, False)
                    frmSaveProfileAs.UpdateProfile(Profile)

                    If frmMain.language = "English" Then
                        MsgBox("Loaded and updated profile. It should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                    ElseIf frmMain.language = "German" Then
                        MsgBox("Profil wurde geladen und aktualisiert. Es sollte nun korrekt funktionieren!", MsgBoxStyle.Information, "Profil geladen und aktualisiert")
                    End If

                    frmMain.WriteToLog("Loaded and updated profile " + Profile, "Info")
                Case Windows.Forms.DialogResult.No
                    If frmMain.language = "English" Then
                        MsgBox("Cancelled loading profile.", MsgBoxStyle.Exclamation, "Warning")
                    ElseIf frmMain.language = "German" Then
                        MsgBox("Laden des Profils abgebrochen.", MsgBoxStyle.Exclamation, "Warning")
                    End If
            End Select
        Else
            LoadProfile(Profile, ShowMessage)
            frmMain.WriteToLog(String.Format("Loaded profile {0}", Profile), "Info")
        End If
    End Sub


    Sub GetFiles(Path As String)
        'Get all profiles that exist in the folder and add them to the combobox
        frmMain.WriteToLog("Getting profiles for frmLoadProfileFrom...", "Info")

        If Path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In profileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(String.Format("{0}\Seeloewen Shutdown\Profiles\", frmMain.appData), "").Replace(".txt", "")
                    cbxProfiles.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            If frmMain.language = "English" Then
                MsgBox("Error: Could not load profiles. Please restart the application and try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            ElseIf frmMain.language = "German" Then
                MsgBox("Fehler: Konnte Profile nicht laden. Bitte starte die App neu und versuche es erneut." + vbNewLine + "Ausnahme: " + ex.Message, MsgBoxStyle.Critical, "Fehler")
            End If
            frmMain.WriteToLog(String.Format("Error: Could not load profiles for frmLoadProfileFrom. {0}", ex.Message), "Error")
        End Try
    End Sub

    Private Sub LoadDesign()
        'Set design to darkmode if setting is set to dark
        If frmMain.design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblLoadProfileFrom.ForeColor = Color.White
            cbxProfiles.BackColor = Color.Gray
            cbxProfiles.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements to the selected language
        If frmMain.language = "German" Then
            Text = "Profil laden von..."
            lblLoadProfileFrom.Text = "Profil laden von..."
            btnLoad.Text = "Laden"
            btnCancel.Text = "Abbrechen"
            msgBoxTextCorruptedProfile = "Du versucht ein beschädigtes Profil oder ein Profil von einer älteren Version zu laden. Du musst es aktualisieren, um es zu laden. Normalerweise verlierst du keine Einstellungen. Möchtest du fortfahren?"
            msgBoxHeaderCorruptedProfile = "Altes oder beschädigtes Profil laden"
        ElseIf frmMain.language = "English" Then
            msgBoxTextCorruptedProfile = "You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?"
            msgBoxHeaderCorruptedProfile = "Load old or corrupted profile"
        End If
    End Sub

    '-- Button designs --

    Private Sub btnLoad_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLoad.MouseDown
        btnLoad.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnLoad_MouseEnter(sender As Object, e As EventArgs) Handles btnLoad.MouseEnter
        btnLoad.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnLoad_MouseLeave(sender As Object, e As EventArgs) Handles btnLoad.MouseLeave
        btnLoad.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLoad_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLoad.MouseUp
        btnLoad.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseDown(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseDown
        btnCancel.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnCancel_MouseLeave(sender As Object, e As EventArgs) Handles btnCancel.MouseLeave
        btnCancel.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnCancel_MouseEnter(sender As Object, e As EventArgs) Handles btnCancel.MouseEnter
        btnCancel.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnCancel_MouseUp(sender As Object, e As MouseEventArgs) Handles btnCancel.MouseUp
        btnCancel.BackgroundImage = My.Resources.button
    End Sub
End Class