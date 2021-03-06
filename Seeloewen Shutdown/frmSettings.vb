Imports System.Environment

Public Class frmSettings
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Translations
        If My.Settings.Language = "German" Then

            'Initialize comboboxes if language german is selected
            cbxDefaultIn.Items.Add("Sekunde(n)")
            cbxDefaultIn.Items.Add("Minute(n)")
            cbxDefaultIn.Items.Add("Stunde(n)")
            cbxDefaultIn.Items.Remove("Second(s)")
            cbxDefaultIn.Items.Remove("Minute(s)")
            cbxDefaultIn.Items.Remove("Hour(s)")
            cbxDesign.Items.Add("Hell")
            cbxDesign.Items.Add("Dunkel")
            cbxDesign.Items.Remove("Light")
            cbxDesign.Items.Remove("Dark")
            cbxLanguage.SelectedItem = "Deutsch (German)"

            'Change text to german translation
            Text = "Einstellungen"
            lblSettings.Text = "Einstellungen"
            gbDefaultSettings.Text = "Standart-Einstellungen"
            gbAppSettings.Text = "App-Einstellungen"
            rbtnShutdown.Text = "Herunterfahren"
            rbtnRestart.Text = "Neustarten"
            lblDefaultAction.Text = "Aktion"
            lblDefaultTime.Text = "Ausführen in..."
            lblLanguage.Text = "Sprache:"
            btnSave.Text = "Speichern"
            btnClose.Text = "Schließen"
            cbEnableMinimalisticViewByDefault.Text = "Aktiviere die Minimalistische Ansicht automatisch," + vbNewLine + "wenn du eine Aktion startest."
            cbShowNotifications.Text = "Benachrichtigungen zeigen"
            gbMinimalisticView.Text = "Minimalistische Ansicht-Einstellungen"

        ElseIf My.Settings.Language = "English" Then
            cbxLanguage.SelectedItem = "English (English)"
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
            cbShowNotifications.ForeColor = Color.White
            cbEnableMinimalisticViewByDefault.ForeColor = Color.White
            gbMinimalisticView.ForeColor = Color.White
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

        'Load Notifications
        If My.Settings.ShowNotifications = True Then
            cbShowNotifications.Checked = True
        Else
            cbShowNotifications.Checked = False
        End If

        'Load Minimalistic View
        If My.Settings.EnableMinimalisticView = True Then
            cbEnableMinimalisticViewByDefault.Checked = True
        Else
            cbEnableMinimalisticViewByDefault.Checked = False
        End If
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

        'Save Notifications
        If cbShowNotifications.Checked Then
            My.Settings.ShowNotifications = True
        Else
            My.Settings.ShowNotifications = False
        End If

        'Save Minimalistic View
        If cbEnableMinimalisticViewByDefault.Checked Then
            My.Settings.EnableMinimalisticView = True
        Else
            My.Settings.EnableMinimalisticView = False
        End If

        'Show a message that confirms that all settings have been saved
        If My.Settings.Language = "German" Then
            frmMain.ShowNotification("Gespeichert! Du musst die Software möglicherweise neustarten.")
        ElseIf My.Settings.Language = "English" Then
            frmMain.ShowNotification("Saved! You may need to restart the software.")
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

    Private Sub btnLog_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLog.MouseDown
        btnLog.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnLog_MouseHover(sender As Object, e As EventArgs) Handles btnLog.MouseHover
        btnLog.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnLog_MouseLeave(sender As Object, e As EventArgs) Handles btnLog.MouseLeave
        btnLog.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLog_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLog.MouseUp
        btnLog.BackgroundImage = My.Resources.button
    End Sub
End Class