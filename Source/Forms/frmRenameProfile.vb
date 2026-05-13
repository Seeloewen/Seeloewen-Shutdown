Imports System.IO

Public Class frmRenameProfile

    '-- Attributes --

    Private profile As String

    '-- Event Handlers --

    Private Sub frmRenameProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load the design and language
        LoadDesign()
        LoadLanguage()

        'Clear previous content
        tbRenameProfileTo.Clear()
    End Sub

    Public Overloads Sub ShowDialog(profile As String)
        'Set the profile and show the window
        Me.profile = profile
        ShowDialog()
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        'Rename the profile that was (hopefully) passed along when the window was opened
        RenameProfile()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close the window
        Close()
    End Sub


    '-- Custom Methods --

    Public Sub RenameProfile()
        'Check if a profile is loaded and if it exists, then rename the profile file and reload the profile files in the main window
        If File.Exists(String.Format("{0}{1}.txt", frmMain.profileDirectory, profile)) Then
            If String.IsNullOrEmpty(tbRenameProfileTo.Text) = False Then
                My.Computer.FileSystem.RenameFile(String.Format("{0}{1}.txt", frmMain.profileDirectory, profile), String.Format("{0}.txt", tbRenameProfileTo.Text))
                If frmMain.language = "German" Then
                    MsgBox(String.Format("Das Profil '{0}' wurde erfolgreich zu '{1}' umbenannt!", profile, tbRenameProfileTo.Text), MsgBoxStyle.Information, "Profil umbenannt")
                ElseIf frmMain.language = "English" Then
                    MsgBox(String.Format("The profile '{0}' was successfully renamed to '{1}'!", profile, tbRenameProfileTo.Text), MsgBoxStyle.Information, "Renamed profile")
                End If
                frmMain.WriteToLog(String.Format("The profile '{0}' was successfully renamed to '{1}'!", profile, tbRenameProfileTo.Text), "Info")
                frmProfileEditor.GetFiles(frmMain.profileDirectory)
                frmProfileEditor.cbxProfile.Text = tbRenameProfileTo.Text
                Close()
            Else
                If frmMain.language = "English" Then
                    MsgBox("Please enter a new name for the profile.", MsgBoxStyle.Critical, "Error")
                ElseIf frmMain.language = "German" Then
                    MsgBox("Bitte gib einen neuen Namen für das Profil an.", MsgBoxStyle.Critical, "Fehler")
                End If
            End If
        Else
            If frmMain.language = "English" Then
                MsgBox("The selected profile was not found. Make sure the profile that you want to rename exists!", MsgBoxStyle.Critical, "Error")
            ElseIf frmMain.language = "German" Then
                MsgBox("Das ausgewählte Profil wurde nicht gefunden. Bitte versichere, dass das Profil, das du umbenennen möchtest, existiert.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Public Sub LoadDesign()
        'Load dark mode
        If frmMain.design = "Dark" Then
            lblSaveProfileAs.ForeColor = Color.White
            tbRenameProfileTo.ForeColor = Color.White
            tbRenameProfileTo.BackColor = Color.DimGray
            BackColor = Color.FromArgb(50, 50, 50)
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate elements if language is set to German
        If frmMain.language = "German" Then
            lblSaveProfileAs.Text = "Profil umbenennen zu..."
            Text = "Profil umbenennen"
            btnCancel.Text = "Abbrechen"
            btnRename.Text = "Umbenennen"
        End If
    End Sub

    '-- Button Animations --

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

    Private Sub btnRename_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRename.MouseDown
        btnRename.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnRename_MouseEnter(sender As Object, e As EventArgs) Handles btnRename.MouseEnter
        btnRename.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnRename_MouseLeave(sender As Object, e As EventArgs) Handles btnRename.MouseLeave
        btnRename.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnRename_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRename.MouseUp
        btnRename.BackgroundImage = My.Resources.button
    End Sub
End Class