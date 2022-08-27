Imports System.IO

Public Class frmLoadProfileFrom

    Dim ProfileList As String()
    Dim LoadFromProfile As String
    Dim rbtnAction As String
    Dim tbTime As String
    Dim cbxIn As String

    '-- Event handlers --

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
            cbxProfiles.Items.Clear()
            GetFiles(frmMain.ProfileDirectory)
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Profil Verzeichnis existiert nicht. Bitte starte die App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If

        LoadLanguage()
        LoadDesign()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadProfile(cbxProfiles.SelectedItem, True)
    End Sub

    '-- Custom methods --

    Public Sub LoadProfile(Profile, ShowMessage)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\Seeloewen Shutdown\Profiles\" + Profile + ".txt"
            settings.Text = My.Computer.FileSystem.ReadAllText(LoadFromProfile)

            rbtnAction = settings.Lines(0)
            If rbtnAction = "Shutdown" Then
                frmMain.rbtnShutdown.Checked = True
            ElseIf rbtnAction = "Restart" Then
                frmMain.rbtnRestart.Checked = True
            End If

            frmMain.tbTime.Text = settings.Lines(1)
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

            frmMain.cbxIn.SelectedItem = cbxIn

            If ShowMessage Then
                If My.Settings.Language = "English" Then
                    MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
                ElseIf My.Settings.Language = "German" Then
                    MsgBox("Profil " + Profile + " geladen.", MsgBoxStyle.Information, "Profil geladen")
                End If
            End If

            frmMain.WriteToLog("Loaded profile " + Profile, "Info")
            Close()
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Kein Profil ausgewählt. Bitte wähle ein Profil aus, das geladen werden soll.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Sub GetFiles(Path As String)
        frmMain.WriteToLog("Getting profiles for frmLoadProfileFrom...", "Info")

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
                    cbxProfiles.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            If My.Settings.Language = "English" Then
                MsgBox("Error: Could not load profiles. Please restart the application and try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Konnte Profile nicht laden. Bitte starte die App neu und versuche es erneut." + vbNewLine + "Ausnahme: " + ex.Message, MsgBoxStyle.Critical, "Fehler")
            End If
            frmMain.WriteToLog("Error: Could not load profiles for frmLoadProfileFrom. " + ex.Message, "Error")
        End Try
    End Sub

    Private Sub LoadDesign()
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblLoadProfileFrom.ForeColor = Color.White
            cbxProfiles.BackColor = Color.Gray
            cbxProfiles.ForeColor = Color.White
        End If
    End Sub

    Private Sub LoadLanguage()
        If My.Settings.Language = "German" Then
            Text = "Profil laden von..."
            lblLoadProfileFrom.Text = "Profil laden von..."
            btnLoad.Text = "Laden"
            btnCancel.Text = "Abbrechen"
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