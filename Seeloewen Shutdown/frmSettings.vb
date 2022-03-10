Imports System.Environment
Imports System.IO
Imports System.Net
Public Class frmSettings
    Dim currentversion As String = "1.6.0"
    Dim newestversion As String
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Translations
        If My.Settings.Language = "English" Then

            'Initialize comboboxes if language English is selected
            cbxDefaultIn.Items.Remove("Sekunde(n)")
            cbxDefaultIn.Items.Remove("Minute(n)")
            cbxDefaultIn.Items.Remove("Stunde(n)")
            cbxDefaultIn.Items.Add("Second(s)")
            cbxDefaultIn.Items.Add("Minute(s)")
            cbxDefaultIn.Items.Add("Hour(s)")
            cbxDesign.Items.Remove("Hell")
            cbxDesign.Items.Remove("Dunkel")
            cbxDesign.Items.Add("Light")
            cbxDesign.Items.Add("Dark")
            cbxLanguage.SelectedItem = "English (English)"

            'Change text to english translation
            Text = "Settings"
            lblSettings.Text = "Settings"
            gbDefaultSettings.Text = "Default settings"
            gbAppSettings.Text = "App settings"
            rbtnShutdown.Text = "Shutdown"
            rbtnRestart.Text = "Restart"
            lblDefaultAction.Text = "Action"
            lblDefaultTime.Text = "Execute in..."
            lblLanguage.Text = "Language:"
            btnSave.Text = "Save"
            btnClose.Text = "Close"

        ElseIf My.Settings.Language = "German" Then
            cbxLanguage.SelectedItem = "Deutsch (German)"
        End If

        If My.Settings.Design = "Light" Then

            'Initialize Design combobox if Darkmode is selected
            If My.Settings.Language = "German" Then
                cbxDesign.SelectedItem = "Hell"
            ElseIf My.Settings.Language = "English" Then
                cbxDesign.SelectedItem = "Light"
            End If

        ElseIf My.Settings.Design = "Dark" Then

            'Initialize Design combobox if Darkmode is selected
            If My.Settings.Language = "German" Then
                cbxDesign.SelectedItem = "Dunkel"
            ElseIf My.Settings.Language = "English" Then
                cbxDesign.SelectedItem = "Dark"
            End If

            'Change window to Darkmode
            BackColor = Color.FromArgb(41, 41, 41)
            lblSettings.ForeColor = Color.White
            lblDefaultAction.ForeColor = Color.White
            lblDefaultTime.ForeColor = Color.White
            lblLanguage.ForeColor = Color.White
            lblDesign.ForeColor = Color.White
            gbDefaultSettings.ForeColor = Color.White
            gbAppSettings.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            tbDefaultTime.BackColor = Color.Gray
            tbDefaultTime.ForeColor = Color.White
        End If

        'Load default settings from settings
        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
        End If

        If My.Settings.DefaultTimeChoice = "minutes" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Minute(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Minute(n)"
            End If

        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Second(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Sekunde(n)"
            End If

        ElseIf My.Settings.DefaultTimeChoice = "hours" Then

            If My.Settings.Language = "English" Then
                cbxDefaultIn.SelectedItem = "Hour(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxDefaultIn.SelectedItem = "Stunde(n)"
            End If

        End If

        tbDefaultTime.Text = My.Settings.DefaultTime
    End Sub

    Private Sub tbDefaultTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDefaultTime.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Check which action was selected for DefaultAction.
        If rbtnRestart.Checked = True Then
            My.Settings.DefaultAction = "restart"
        ElseIf rbtnShutdown.Checked = True Then
            My.Settings.DefaultAction = "shutdown"
        End If
        frmMain.WriteToLog("Saved DefaultAction to settings: " + My.Settings.DefaultAction, "Info")

        'Check which option is selected for DefaultTimeChoice.
        If cbxDefaultIn.SelectedItem = "Stunde(n)" Then
            My.Settings.DefaultTimeChoice = "hours"
        ElseIf cbxDefaultIn.SelectedItem = "Hour(s)" Then
            My.Settings.DefaultTimeChoice = "hours"
        ElseIf cbxDefaultIn.SelectedItem = "Minute(n)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Minute(s)" Then
            My.Settings.DefaultTimeChoice = "minutes"
        ElseIf cbxDefaultIn.SelectedItem = "Sekunde(n)" Then
            My.Settings.DefaultTimeChoice = "seconds"
        ElseIf cbxDefaultIn.SelectedItem = "Second(s)" Then
            My.Settings.DefaultTimeChoice = "seconds"
        End If
        frmMain.WriteToLog("Saved DefaultTimeChoice to settings: " + My.Settings.DefaultTimeChoice, "Info")

        'Save DefaultTime
        My.Settings.DefaultTime = tbDefaultTime.Text
        frmMain.WriteToLog("Saved DefaultTime to settings: " + My.Settings.DefaultTime, "Info")

        'Save Language
        If cbxLanguage.SelectedItem = "English (English)" Then
            My.Settings.Language = "English"
            Close()
        ElseIf cbxLanguage.SelectedItem = "Deutsch (German)" Then
            My.Settings.Language = "German"
            Close()
        End If
        frmMain.WriteToLog("Saved Language to settings: " + My.Settings.Language, "Info")

        'Save Design
        If cbxDesign.SelectedItem = "Light" Then
            My.Settings.Design = "Light"
        ElseIf cbxDesign.SelectedItem = "Hell" Then
            My.Settings.Design = "Light"
        ElseIf cbxDesign.SelectedItem = "Dunkel" Then
            My.Settings.Design = "Dark"
        ElseIf cbxDesign.SelectedItem = "Dark" Then
            My.Settings.Design = "Dark"
        End If
        frmMain.WriteToLog("Saved Design to settings: " + My.Settings.Design, "Info")

        'Show a message that confirms that all settings have been saved
        If My.Settings.Language = "German" Then
            MsgBox("Alle ausgewählten Optionen wurden gespeichert!" + vbNewLine + "Du musst möglicherweise die App neustarten," + vbNewLine + "um manche Einstellungen anzuwenden.", MsgBoxStyle.Information, "Erfolgreich gespeichert!")
        ElseIf My.Settings.Language = "English" Then
            MsgBox("All settings have been saved." + vbNewLine + "You may need to restart the application" + vbNewLine + "to apply some settings.", MsgBoxStyle.Information, "Saved successfully!")
        End If
        Close()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Sub Sleep(ByVal sleeptime As Integer)
        Dim Stopw As New Stopwatch

        Stopw.Start()

        Do Until Stopw.ElapsedMilliseconds >= sleeptime
            Application.DoEvents()
        Loop
        Stopw.Stop()
        Stopw.Reset()
    End Sub

    Private Sub btnClose_MouseDown(sender As Object, e As MouseEventArgs) Handles btnClose.MouseDown
        btnClose.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnClose_MouseUp(sender As Object, e As MouseEventArgs) Handles btnClose.MouseUp
        btnClose.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSave.MouseDown
        btnSave.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSave_MouseHover(sender As Object, e As EventArgs) Handles btnSave.MouseHover
        btnSave.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSave_MouseLeave(sender As Object, e As EventArgs) Handles btnSave.MouseLeave
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSave_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSave.MouseUp
        btnSave.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        frmLog.Show()
    End Sub
End Class