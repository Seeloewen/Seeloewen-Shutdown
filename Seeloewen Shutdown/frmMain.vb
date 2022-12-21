Imports System.Environment
Imports System.IO

Public Class frmMain

    'General variables
    Dim Version As String = "1.8.1"
    Dim VerDate As String = "06.09.2022"
    Public SettingsVersion As Integer = 1
    Dim LoadedSettingsVersion As Integer
    Public LogLoadedOnce As Boolean
    Dim ActionRunning As Boolean = False
    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public ClosingResult As String = "Close"

    'Variables used for settings and profiles
    Dim SettingsArray As String()
    Dim ProfileList As String()
    Public ProfileDirectory As String = AppData + "\Seeloewen Shutdown\Profiles\"

    'Variables used for animations and designs
    Dim GrayBoxNewY As Integer
    Dim PnlActionRunningNewY As Integer
    Dim PnlNotificationNewY As Integer
    Dim LoadErrorMsgText As String
    Dim LoadErrorMsgHeader As String

    'Variables used for the timer and action
    Dim ShutdownTimeType As String
    Dim maxtime As String
    Dim TargetDT As DateTime
    Dim CountDownFrom As TimeSpan
    Dim TimeDifference As TimeSpan
    Public ts As TimeSpan


    '-- Event Handlers --

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateFiles()
        InitializeLoadingSettings()
        WriteToLog("Loading Seeloewen Shutdown " + Version + " (" + VerDate + ")", "Info")
        LoadLanguage()
        LoadDesign()
        CheckForRunningAction()
        ResetUIElements()
        InitializeProfiles()
        ShowUpdateNews()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If the user wants to close the application while an action is still running, it will show an information
        If ActionRunning = True And My.Settings.ShowCloseWarning = True Then
            frmClosing.ShowDialog()
            If ClosingResult = "Return" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        If ActionRunning = False Then
            StartAction()
        ElseIf ActionRunning = True Then
            StopAction()
        End If
    End Sub

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click 'Shows menu with different options
        If cmsHamburgerButton.Visible = True Then
            cmsHamburgerButton.Hide()
        Else
            cmsHamburgerButton.Show(btnHamburger, -100, btnHamburger.Top + 30)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        frmSettings.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        frmChangelog.Show()
    End Sub

    Private Sub tmrShutdown_Tick(sender As Object, e As EventArgs) Handles tmrShutdown.Tick 'Timer for shutdown (Only for reference, not the actual timer)
        ts = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            If ts.TotalHours > 24 Then
                _TimeRemaining.Text = ts.ToString("dd\:hh\:mm\:ss")
            Else _TimeRemaining.Text = ts.ToString("hh\:mm\:ss")
            End If
        End If

    End Sub

    Private Sub tbTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTime.KeyPress
        Select Case Asc(e.KeyChar) 'Only accepts numbers
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub rbtnZeitpunkt_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPointInTime.CheckedChanged
        tbTime.Enabled = False
        cbxIn.Enabled = False
        dtpDate.Enabled = True
        currentDateTime.Enabled = True

        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                If My.Settings.Language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf My.Settings.Language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        tbTime.Enabled = True
        cbxIn.Enabled = True

        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                If My.Settings.Language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf My.Settings.Language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rbtnShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnShutdown.CheckedChanged
        If rbtnShutdown.Checked = True Then
            _SelectedAction.Text = "Shutdown"
        ElseIf rbtnRestart.Checked = True Then
            _SelectedAction.Text = "Restart"
        End If
    End Sub

    Private Sub rbtnRestart_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRestart.CheckedChanged
        If rbtnShutdown.Checked = True Then
            If My.Settings.Language = "English" Then
                _SelectedAction.Text = "Shutdown"
            ElseIf My.Settings.Language = "German" Then
                _SelectedAction.Text = "Herunterfahren"
            End If
        ElseIf rbtnRestart.Checked = True Then
            If My.Settings.Language = "English" Then
                _SelectedAction.Text = "Restart"
            ElseIf My.Settings.Language = "German" Then
                _SelectedAction.Text = "Neustarten"
            End If
        End If
    End Sub

    Private Sub tbTime_TextChanged(sender As Object, e As EventArgs) Handles tbTime.TextChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(cbxIn.Text) Then
                cbxIn.SelectedIndex = 1
            End If
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                If My.Settings.Language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf My.Settings.Language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub cbxIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIn.SelectedIndexChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                If My.Settings.Language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf My.Settings.Language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = "In " + tbTime.Text + " " + cbxIn.Text
            Else
                If My.Settings.Language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf My.Settings.Language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rtbLog_TextChanged(sender As Object, e As EventArgs) Handles rtbLog.TextChanged
        rtbLog.SaveFile(AppData + "/Seeloewen Shutdown/DebugLogTemp")
        frmLog.rtbLog.LoadFile(AppData + "/Seeloewen Shutdown/DebugLogTemp")
    End Sub

    Private Sub btnOpenHelp_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub MinimalisticViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimalisticViewToolStripMenuItem.Click
        EnableMinimalisticView()
    End Sub

    Private Sub _TimeRemaining_TextChanged(sender As Object, e As EventArgs) Handles _TimeRemaining.TextChanged
        frmMinimalisticView.lblTimerShutdown.Text = _TimeRemaining.Text
    End Sub

    Private Sub btnShowActionHistory_Click(sender As Object, e As EventArgs) Handles btnShowActionHistory.Click
        If My.Settings.EnableActionHistory = True Then
            frmActionHistory.Show()
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Action History is currently disabled. Head to the settings to enable it.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Der Aktionsverlauf ist aktuell deaktiviert. Gehe in die Einstellungen um ihn zu aktivieren.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs)
        frmSettings.Show()
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        If rbtnIn.Checked Then
            frmSaveProfileAs.ShowDialog()
        Else
            If My.Settings.Language = "English" Then
                MsgBox("Please choose option 'In...' to save a profile.", MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Bitte wähle die Option 'In...' um ein Profil zu speichern.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        frmLoadProfileFrom.ShowDialog()
    End Sub

    '-- Custom methods --

    Private Sub InitializeLoadingSettings()
        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/Settings.txt") Then
            'Load settings and determine version
            SettingsArray = File.ReadAllLines(AppData + "/Seeloewen Shutdown/Settings.txt")
            LoadedSettingsVersion = SettingsArray(1).Replace("Version=", "")
            WriteToLog("Found settings version " + LoadedSettingsVersion.ToString, "Info")

            'Check if settings version is outdated or newer (or just right)
            If LoadedSettingsVersion < SettingsVersion Then

                'Load settings from older version. You can either select to import the settings into the new version or overwrite them.
                Select Case MsgBox("Your settings from a previous version were found." + vbNewLine + "Do you want to try to import them?" + vbNewLine + " This will overwrite your current settings.", vbQuestion + vbYesNo, "Found older settings")
                    Case Windows.Forms.DialogResult.Yes
                        WriteToLog("Importing settings from older version. Please note that due to version differences not everything might be imported.", "Warning")
                        LoadSettings()
                        MsgBox("Finished Importing settings. Please note that not everything might have been imported due to the settings file being an older version.", MsgBoxStyle.Information, "Import older settings")
                        WriteToLog("Finished importing settings from older version.", "Info")
                    Case Windows.Forms.DialogResult.No
                        WriteToLog("Ignored settings from previous version. Creating new file, current one will be renamed to settings.old", "Info")
                        My.Computer.FileSystem.RenameFile(AppData + "/Seeloewen Shutdown/Settings.txt", "settings.old")
                        My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/Settings.txt", "", False)
                        frmSettings.ResetSettings(AppData + "/Seeloewen Shutdown/Settings.txt")
                End Select

            ElseIf LoadedSettingsVersion > SettingsVersion Then

                'Load settings from newer version. You can either select to import the settings into the new version or overwrite them.
                Select Case MsgBox("The settings file that was detected belongs to a newer version of the Random Item Giver Updater." + vbNewLine + "Loading it can cause issues. Do you still want to load it?", vbQuestion + vbYesNo, "Found newer settings")
                    Case Windows.Forms.DialogResult.Yes
                        WriteToLog("Importing settings from newer version. Please note that due to version differences this can issues.", "Warning")
                        LoadSettings()
                        MsgBox("Finished Importing settings. Please note that not everything might work correctly.", MsgBoxStyle.Information, "Imported newer settings")
                        WriteToLog("Finished importing settings from newer version.", "Info")
                    Case Windows.Forms.DialogResult.No
                        WriteToLog("Ignored settings from newer version. Creating new file, current one will be renamed to settings.old", "Info")
                        My.Computer.FileSystem.RenameFile(AppData + "/Seeloewen Shutdown/Settings.txt", "settings.old")
                        My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/Settings.txt", "", False)
                        frmSettings.ResetSettings(AppData + "/Seeloewen Shutdown/Settings.txt")
                End Select

            Else

                'Just load settings
                WriteToLog("Loading settings...", "Info")
                LoadSettings()

            End If

        Else
            'Show error and create new settings file if none exists
            WriteToLog("Could not find settings file. Creating a new one (Version " + SettingsVersion.ToString + ").", "Warning")
            My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/Settings.txt", "", False)
            frmSettings.ResetSettings(AppData + "/Seeloewen Shutdown/Settings.txt")
        End If
    End Sub

    Private Sub LoadSettings()

        If My.Settings.Language = "English" Then
            LoadErrorMsgHeader = "Error"
            LoadErrorMsgText = "An error occured while loading your settings. " + vbNewLine + "Do you want to reset your settings? This probably fixes the problem."
        ElseIf My.Settings.Language = "German" Then
            LoadErrorMsgHeader = "Fehler"
            LoadErrorMsgText = "Beim Laden deiner Einstellungen ist ein Fehler aufgetreten. " + vbNewLine + "Möchtest du deine Einstellungen zurücksetzen? Das behebt vermutlich das Problem."
        End If
        Try

            'Load App settings
            My.Settings.Language = SettingsArray(4).Replace("Language=", "")
            WriteToLog("Loaded setting " + SettingsArray(4), "Info")
            My.Settings.Design = SettingsArray(5).Replace("Design=", "")
            WriteToLog("Loaded setting " + SettingsArray(5), "Info")
            My.Settings.ShowNotifications = Convert.ToBoolean(SettingsArray(6).Replace("ShowNotifications=", ""))
            WriteToLog("Loaded setting " + SettingsArray(6), "Info")
            My.Settings.ShowCloseWarning = Convert.ToBoolean(SettingsArray(7).Replace("ShowCloseWarning=", ""))
            WriteToLog("Loaded setting " + SettingsArray(7), "Info")

            'Load Action History settings
            My.Settings.EnableActionHistory = Convert.ToBoolean(SettingsArray(10).Replace("EnableActionHistory=", ""))
            WriteToLog("Loaded setting " + SettingsArray(10), "Info")

            'Load Profile settings
            My.Settings.LoadProfileByDefault = Convert.ToBoolean(SettingsArray(13).Replace("LoadProfileByDefault=", ""))
            WriteToLog("Loaded setting " + SettingsArray(13), "Info")
            My.Settings.DefaultProfile = SettingsArray(14).Replace("DefaultProfile=", "")
            WriteToLog("Loaded setting " + SettingsArray(14), "Info")

            'Load Minimalistic View settings
            My.Settings.EnableMinimalisticView = Convert.ToBoolean(SettingsArray(17).Replace("EnableMinimalisticView=", ""))
            WriteToLog("Loaded setting " + SettingsArray(17), "Info")

        Catch ex As Exception

            MsgBox("Could not load settings: " + ex.Message, MsgBoxStyle.Critical, "Error")
            WriteToLog("Could not load settings: " + ex.Message, "Error")

            'If loading settings failed, show an option to reset settings
            Select Case MsgBox(LoadErrorMsgText, vbCritical + vbYesNo, LoadErrorMsgHeader)
                Case Windows.Forms.DialogResult.Yes
                    My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/Settings.txt", "", False)
                    frmSettings.ResetSettings(AppData + "/Seeloewen Shutdown/Settings.txt")
                    If My.Settings.Language = "English" Then
                        MsgBox("Successfully reset your settings!" + vbNewLine + "The application needs to be restarted to apply changes.", MsgBoxStyle.Information, "Reset settings")
                    ElseIf My.Settings.Language = "German" Then
                        MsgBox("Einstellungen wurden erfolgreich zurückgesetzt. Die App muss neugestartet werden, um die Änderungen zu übernehmen.", MsgBoxStyle.Information, "Einstellungen zurückgesetzt")
                    End If
                    WriteToLog("Successfully reset settings!", "Info")
                    Close()
            End Select

        End Try
    End Sub

    Private Sub ResetUIElements()
        rbtnIn.Checked = True
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"
    End Sub

    Private Sub ShowUpdateNews()
        'Show Update News if necessary
        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version) = False Then
            frmUpdateNews.ShowDialog()
            Dim fs As FileStream = File.Create(AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version)
            fs.Close()
            WriteToLog("Created file " + "'" + AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version + "' so the update news don't appear again for this version (" + Version + ")", "Info")
        End If
    End Sub

    Private Sub LoadLanguage()
        'Show language selection dialog if no language is specified
        If (My.Settings.Language = "English" OrElse My.Settings.Language = "German") = False Then
            frmFirstStart.ShowDialog()
        End If

        'Translate all elements to german
        If My.Settings.Language = "German" Then
            If My.Settings.LastActionDisplay = "Restart" Then
                My.Settings.LastActionDisplay = "Neustarten"
            ElseIf My.Settings.LastActionDisplay = "Shutdown" Then
                My.Settings.LastActionDisplay = "Herunterfahren"
            End If
            btnSaveProfile.Text = "Profil speichern"
            btnLoadProfile.Text = "Profil laden"
            lblAction.Text = "Aktion                                           "
            lblTime.Text = "Zeit                                               "
            btnShowActionHistory.Text = "Verlauf anzeigen"
            btnStartAction.Text = "Aktion starten"
            rbtnShutdown.Text = "Herunterfahren"
            rbtnRestart.Text = "Neustarten"
            rbtnPointInTime.Text = "Zeitpunkt"
            SettingsToolStripMenuItem.Text = "Einstellungen"
            ChangelogToolStripMenuItem.Text = "Changelog"
            AboutToolStripMenuItem.Text = "Über"
            MinimalisticViewToolStripMenuItem.Text = "Minimalistische Ansicht"
            lblSelectedAction.Text = "Gewählte Aktion:"
            lblSelectedTime.Text = "Gewählte Zeit:"
            lblScheduledAction.Text = "Geplante Aktion:"
            lblScheduledTime.Text = "Geplante Zeit:"
            lblTimeRemaining.Text = "Verbleibende Zeit:"
            gbLastAction.Text = "Letzte Aktion"
            lblLastAction.Text = "Aktion:"
            lblLastTime.Text = "Zeit:"
            lblStartedOn.Text = "Gestartet am:"
            cbxIn.Items.Remove("Second(s)")
            cbxIn.Items.Remove("Minute(s)")
            cbxIn.Items.Remove("Hour(s)")
            cbxIn.Items.Add("Sekunde(n)")
            cbxIn.Items.Add("Minute(n)")
            cbxIn.Items.Add("Stunde(n)")

            _SelectedAction.Text = "Keine Aktion gewählt"
            _SelectedTime.Text = "Keine Zeit gewählt"

        ElseIf My.Settings.Language = "English" Then
            If My.Settings.LastActionDisplay = "Neustarten" Then
                My.Settings.LastActionDisplay = "Restart"
            ElseIf My.Settings.LastActionDisplay = "Herunterfahren" Then
                My.Settings.LastActionDisplay = "Shutdown"
            End If

            _SelectedAction.Text = "No action selected"
            _SelectedTime.Text = "No time selected"
        End If

        WriteToLog("Loaded Language from settings: " + My.Settings.Language, "Info")
    End Sub

    Private Sub LoadDesign() 'Change design to darkmode if setting is set to dark
        If My.Settings.Design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblHeader.ForeColor = Color.White
            lblVersion.ForeColor = Color.White
            rbtnIn.ForeColor = Color.White
            rbtnShutdown.ForeColor = Color.White
            rbtnRestart.ForeColor = Color.White
            rbtnPointInTime.ForeColor = Color.White
            tbTime.BackColor = Color.Gray
            tbTime.ForeColor = Color.White
            cbxIn.ForeColor = Color.White
            cbxIn.BackColor = Color.Gray
            cmsHamburgerButton.BackColor = Color.Gray
            cmsHamburgerButton.ForeColor = Color.White
            lblSelectedAction.BackColor = Color.FromArgb(41, 41, 41)
            lblSelectedTime.BackColor = Color.FromArgb(41, 41, 41)
            btnStartAction.BackColor = Color.FromArgb(41, 41, 41)
            _SelectedAction.BackColor = Color.FromArgb(41, 41, 41)
            _SelectedTime.BackColor = Color.FromArgb(41, 41, 41)
            lblSelectedAction.ForeColor = Color.White
            lblSelectedTime.ForeColor = Color.White
            _SelectedAction.ForeColor = Color.White
            _SelectedTime.ForeColor = Color.White
            lblAction.ForeColor = Color.White
            lblTime.ForeColor = Color.White
            gbLastAction.ForeColor = Color.White
            lblLastAction.ForeColor = Color.White
            _LastAction.ForeColor = Color.White
            lblLastTime.ForeColor = Color.White
            _LastTime.ForeColor = Color.White
            lblStartedOn.ForeColor = Color.White
            _StartedOn.ForeColor = Color.White
            lblScheduledAction.BackColor = Color.FromArgb(25, 25, 25)
            lblScheduledTime.BackColor = Color.FromArgb(25, 25, 25)
            lblTimeRemaining.BackColor = Color.FromArgb(25, 25, 25)
            _RunningAction.BackColor = Color.FromArgb(25, 25, 25)
            _RunningTime.BackColor = Color.FromArgb(25, 25, 25)
            _TimeRemaining.BackColor = Color.FromArgb(25, 25, 25)
            lblScheduledAction.ForeColor = Color.White
            lblScheduledTime.ForeColor = Color.White
            lblTimeRemaining.ForeColor = Color.White
            _RunningAction.ForeColor = Color.White
            _RunningTime.ForeColor = Color.White
            _TimeRemaining.ForeColor = Color.White
            pbGrayBox.BackgroundImage = My.Resources.grayBox_dark
            pbLine.BackgroundImage = My.Resources.Line_Dark
            pbIcon.BackgroundImage = My.Resources.Icon_Dark
            pbLine2.BackgroundImage = My.Resources.Line_Dark
            pnlActionRunning.BackColor = Color.FromArgb(25, 25, 25)
        End If

        WriteToLog("Loaded Design from settings: " + My.Settings.Design, "Info")
    End Sub

    Private Sub CheckForRunningAction()
        'Calculate time difference
        Try
            TimeDifference = DateTime.Now - Convert.ToDateTime(My.Settings.LastTime)
            WriteToLog("Calculated Time Difference: " + TimeDifference.ToString, "Info")
        Catch ex As Exception
            WriteToLog("Couldn't calculate Time Difference: " + ex.Message + " Please note that this might be expected and isn't necessarily a bad thing.", "Warning")
        End Try

        'Check if action is already running via TotalMilliseconds of TimeDifference
        If TimeDifference.TotalMilliseconds < 0 Then
            dtpSelectedTime.Value = Convert.ToDateTime(My.Settings.LastTime)
            SetupGrayBox()
            CallLastAction()

            If My.Settings.Language = "English" Then
                btnStartAction.Text = "Stop action"
            ElseIf My.Settings.Language = "German" Then
                btnStartAction.Text = "Aktion stoppen"
            End If

            pbGrayBox.Top = 550
            GrayBoxNewY = 550
            pnlActionRunning.Top = 550
            PnlActionRunningNewY = 550
            pbGrayBox.Show()
            tmrGrayBoxAnimationUp.Enabled = True
            tmrPnlActionRunningAnimationUp.Enabled = True
            ActionRunning = True
            If My.Settings.Design = "Dark" Then
                btnStartAction.BackColor = Color.FromArgb(25, 25, 25)
            ElseIf My.Settings.Design = "Light" Then
                btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
            End If
            WriteToLog("Detected that an action is already running. Adjusting elements for action.", "Info")
        End If

        'Load settings that should be displayed in the "Last Action" groupbox
        _LastAction.Text = My.Settings.LastActionDisplay
        WriteToLog("Loaded LastActionDisplay from settings: " + My.Settings.LastActionDisplay, "Info")
        _LastTime.Text = My.Settings.LastTimeDisplay
        WriteToLog("Loaded LastTimeDisplay from settings: " + My.Settings.LastTimeDisplay, "Info")
        _StartedOn.Text = My.Settings.LastDateDisplay
        WriteToLog("Loaded LastDateDisplay from settings: " + My.Settings.LastDateDisplay, "Info")
    End Sub

    Private Sub CreateFiles()
        'Create Profile Directory in Appdata folder
        If My.Computer.FileSystem.DirectoryExists(AppData + "/Seeloewen Shutdown") = False Then
            My.Computer.FileSystem.CreateDirectory(AppData + "/Seeloewen Shutdown")
            WriteToLog("Created directory " + "'" + AppData + "/Seeloewen Shutdown" + "'", "Info")
        End If

        'Create ActionHistory file (if enabled)
        If My.Settings.EnableActionHistory = True Then
            If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/ActionHistory.txt") = False Then
                My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/ActionHistory.txt", "", False)
                WriteToLog("Created directory " + "'" + AppData + "/Seeloewen Shutdown/ActionHistory.txt" + "'", "Info")
            End If
        End If

        'Create Profile Directory
        If My.Computer.FileSystem.DirectoryExists(AppData + "/Seeloewen Shutdown/Profiles") = False Then
            My.Computer.FileSystem.CreateDirectory(AppData + "/Seeloewen Shutdown/Profiles")
            WriteToLog("Created directory " + "'" + AppData + "/Seeloewen Shutdown/Profiles" + "'", "Info")
        End If
    End Sub

    Public Sub WriteToLog(Message As String, Type As String) 'Writes message into log, possible types are "Info", "Warning" and "Error"
        If Type = "Error" Then
            rtbLog.SelectionColor = Color.Red
            rtbLog.AppendText("[" + DateTime.Now + "] " + "[ERROR] " + Message + vbNewLine)
        ElseIf Type = "Info" Then
            rtbLog.SelectionColor = Color.FromArgb(50, 177, 205)
            rtbLog.AppendText("[" + DateTime.Now + "] " + "[INFO] " + Message + vbNewLine)
        ElseIf Type = "Warning" Then
            rtbLog.SelectionColor = Color.DarkOrange
            rtbLog.AppendText("[" + DateTime.Now + "] " + "[WARNING] " + Message + vbNewLine)
        Else
            rtbLog.SelectionColor = Color.Red
            rtbLog.AppendText("--> Critical Log Error: Invalid type received" + vbNewLine)
        End If
    End Sub

    Private Sub RemoveLastAction() 'Runs if last action gets cancelled manually
        'Remove last action so software does not detect a running action
        My.Settings.LastAction = "-"
        My.Settings.LastTime = "-"
        My.Settings.LastDate = "-"
        WriteToLog("Removed last Action.", "Info")

        'Remove last line from Action History file (basically remove last action)
        If My.Settings.EnableActionHistory Then
            Dim file As String = AppData + "/Seeloewen Shutdown/ActionHistory.txt"
            Dim lines() As String = IO.File.ReadAllLines(file)
            Dim length As String = lines.Last.Length.ToString
            Dim fs As New FileStream(file, FileMode.Open, FileAccess.ReadWrite)

            fs.SetLength(fs.Length - length - 2)
            fs.Close()
        End If
    End Sub

    Private Sub SetLastAction()
        'Set action so software can recognize that an action is running when being restarted
        My.Settings.LastAction = _RunningAction.Text
        My.Settings.LastTime = dtpSelectedTime.Value
        My.Settings.LastDate = DateTime.Now

        'Display last action
        My.Settings.LastActionDisplay = _RunningAction.Text
        My.Settings.LastTimeDisplay = dtpSelectedTime.Value
        My.Settings.LastDateDisplay = DateTime.Now

        'Add action to Action History file
        If My.Settings.EnableActionHistory Then
            Try
                My.Computer.FileSystem.WriteAllText(AppData + "/Seeloewen Shutdown/ActionHistory.txt", _RunningAction.Text + ";" + dtpSelectedTime.Value + ";" + DateTime.Now.ToString + vbNewLine, True)
            Catch ex As Exception
                WriteToLog("Couldn't add last action to Action History. " + ex.Message, "Error")
            End Try
        End If
    End Sub

    Private Sub CallLastAction() 'If an action is currently running, it will pull infos from settings to display the last known action
        currentDateTime.Value = DateTime.Now
        Dim value As DateTime = currentDateTime.Value
        dtpSelectedTime.Format = DateTimePickerFormat.Long
        Dim d As DateTime = dtpSelectedTime.Value.Date + dtpSelectedTime.Value.TimeOfDay
        dtpSelectedTime.Format = DateTimePickerFormat.Custom
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        Dim timeSpan As TimeSpan = d - value
        Math.Ceiling(timeSpan.TotalSeconds)
        Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

        CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(Shutdowntime.Text))
        _RunningTime.Text = My.Settings.LastTime

        tmrShutdown.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrShutdown.Start()

        _RunningAction.Text = My.Settings.LastAction
        WriteToLog("Called last action (CountDownFrom: " + CountDownFrom.ToString + ", ShutdownTime.Text: " + Shutdowntime.Text + ", _RunningTime.text: + " + _RunningTime.Text + ")", "Info")
    End Sub

    Private Sub SetupGrayBox()
        'Display running action
        If My.Settings.Language = "English" Then
            If rbtnShutdown.Checked Then
                _RunningAction.Text = "Shutdown"
            ElseIf rbtnRestart.Checked Then
                _RunningAction.Text = "Restart"
            End If
        ElseIf My.Settings.Language = "German" Then
            If rbtnShutdown.Checked Then
                _RunningAction.Text = "Herunterfahren"
            ElseIf rbtnRestart.Checked Then
                _RunningAction.Text = "Neustarten"
            End If
        End If

        'Display running action time and setup Shutdown timer
        If rbtnIn.Checked Then
            If cbxIn.SelectedItem = "Sekunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text))
            ElseIf cbxIn.SelectedItem = "Second(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text))
            ElseIf cbxIn.SelectedItem = "Minute(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 60)
            ElseIf cbxIn.SelectedItem = "Minute(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 60)
            ElseIf cbxIn.SelectedItem = "Stunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 3600)
            ElseIf cbxIn.SelectedItem = "Hour(s)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 3600)
            End If

            dtpSelectedTime.Value = DateTime.Now
            dtpSelectedTime.Value = dtpSelectedTime.Value.AddSeconds(Shutdowntime.Text)
            _RunningTime.Text = dtpSelectedTime.Text
        ElseIf rbtnPointInTime.Checked Then
            CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(Shutdowntime.Text))
            _RunningTime.Text = dtpDate.Text
        End If

        'Start Shutdown Timer
        tmrShutdown.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrShutdown.Start()

        WriteToLog("Set gray box up (CountDownFrom: " + CountDownFrom.ToString + ", Shutdowntime.Text: " + Shutdowntime.Text + ", _RunningTime.Text: " + _RunningTime.Text + ")", "Info")
    End Sub

    Sub Sleep(sleeptime As Integer) 'Pauses the thread for x milliseconds, sleeptime is the amount of milliseconds - Warning: Causes App to freeze!
        Dim Stopwatch As New Stopwatch

        Stopwatch.Start()

        Do Until Stopwatch.ElapsedMilliseconds >= sleeptime
            Application.DoEvents()
        Loop

        Stopwatch.Stop()
        Stopwatch.Reset()
    End Sub

    Private Sub StartAction()
        'Set Backcolor of "Start Action" Button
        If My.Settings.Design = "Dark" Then
            btnStartAction.BackColor = Color.FromArgb(25, 25, 25)
        ElseIf My.Settings.Design = "Light" Then
            btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
        End If

        'Set action using "in..."
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) Then
                If My.Settings.Language = "German" Then
                    MsgBox("Bitte gib eine Zeitangabe an!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("Please enter a time!", MsgBoxStyle.Critical, "Error")
                End If
            Else 'Set Shutdown type
                If rbtnShutdown.Checked = True Then
                    Action.Text = "-s"
                ElseIf rbtnRestart.Checked = True Then
                    Action.Text = "-r"
                End If

                'calculate and set shutdown time
                If cbxIn.SelectedItem = "Sekunde(n)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxtime = "31535999"
                    ShutdownTimeType = "Sekunde(n)"
                ElseIf cbxIn.SelectedItem = "Second(s)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxtime = "31535999"
                    ShutdownTimeType = "Second(s)"
                ElseIf cbxIn.SelectedItem = "Minute(n)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxtime = "525599"
                    ShutdownTimeType = "Minute(n)"
                ElseIf cbxIn.SelectedItem = "Minute(s)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxtime = "525599"
                    ShutdownTimeType = "Minute(s)"
                ElseIf cbxIn.SelectedItem = "Stunde(n)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxtime = "8759"
                    ShutdownTimeType = "Stunde(n)"
                ElseIf cbxIn.SelectedItem = "Hour(s)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxtime = "8759"
                    ShutdownTimeType = "Hour(s)"
                End If

                'Run action
                If Shutdowntime.Text > 31535999 Then 'Show error if shutdown time is greater than the max number allowed
                    If My.Settings.Language = "German" Then
                        MsgBox("Die maximale Zeitangabe für " + Quotationmark.Text + ShutdownTimeType + Quotationmark.Text + " beträgt " + maxtime, MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The maximum time for " + Quotationmark.Text + ShutdownTimeType + Quotationmark.Text + " is " + maxtime, MsgBoxStyle.Critical, "Error")
                    End If
                ElseIf Shutdowntime.Text = 0 Then 'Show error if shutdown time is zero
                    If My.Settings.Language = "German" Then
                        MsgBox("Die Zeitangabe darf nicht Null sein!", MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The time cannot be zero!", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    SetupGrayBox()
                    SetLastAction()

                    Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text) 'Start the action

                    If My.Settings.Language = "German" Then
                        ShowNotification("Eine Aktion wurde gestartet!")
                    ElseIf My.Settings.Language = "English" Then
                        ShowNotification("An Action was started!")
                    End If

                    If My.Settings.Language = "English" Then
                        btnStartAction.Text = "Stop action"
                    ElseIf My.Settings.Language = "German" Then
                        btnStartAction.Text = "Aktion stoppen"
                    End If

                    'Animations for graybox etc.
                    pbGrayBox.Top = 550
                    GrayBoxNewY = 550
                    pnlActionRunning.Top = 550
                    PnlActionRunningNewY = 550
                    pbGrayBox.Show()
                    tmrGrayBoxAnimationUp.Enabled = True
                    tmrPnlActionRunningAnimationUp.Enabled = True
                    ActionRunning = True

                    If My.Settings.EnableMinimalisticView = True Then
                        EnableMinimalisticView()
                    End If

                    WriteToLog("Started action (ShutdownTimeType: " + ShutdownTimeType + ", Shutdowntime: " + Shutdowntime.Text + ", Action: " + Action.Text + ", type: In...)", "Info")
                End If
            End If

        ElseIf rbtnPointInTime.Checked = True Then 'Set action using "Point in Time"

            If rbtnShutdown.Checked Then
                Action.Text = "-s"
            ElseIf rbtnRestart.Checked Then
                Action.Text = "-r"
            End If

            'Calculate and set shutdown time
            currentDateTime.Value = DateTime.Now
            Dim value As DateTime = currentDateTime.Value
            dtpDate.Format = DateTimePickerFormat.Long
            Dim d As DateTime = dtpDate.Value.Date + dtpDate.Value.TimeOfDay
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
            Dim timeSpan As TimeSpan = d - value
            Math.Ceiling(timeSpan.TotalSeconds)
            Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

            'Run action
            If Shutdowntime.Text > 31535999 Then
                If My.Settings.Language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht mehr als 1 Jahr in der Zukunft liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("The selected point in time cannot be more than 1 year in the future!", MsgBoxStyle.Critical, "Error")
                End If
            ElseIf Shutdowntime.Text < 0 Then
                If My.Settings.Language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht in der Vergangenheit liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("The selected point in time cannot be in the past!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                SetupGrayBox()
                SetLastAction()

                Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text) 'Start the action

                If My.Settings.Language = "English" Then
                    btnStartAction.Text = "Stop action"
                ElseIf My.Settings.Language = "German" Then
                    btnStartAction.Text = "Aktion stoppen"
                End If

                'Animations for graybox etc.
                pbGrayBox.Top = 550
                GrayBoxNewY = 550
                pnlActionRunning.Top = 550
                PnlActionRunningNewY = 550
                pbGrayBox.Show()
                tmrGrayBoxAnimationUp.Enabled = True
                tmrPnlActionRunningAnimationUp.Enabled = True
                ActionRunning = True

                If My.Settings.EnableMinimalisticView = True Then
                    EnableMinimalisticView()
                End If

                WriteToLog("Started action (ShutdownTimetype: " + ShutdownTimeType + ", Shutdowntime: " + Shutdowntime.Text + ", Action: " + Action.Text + ", type: PointInTime)", "Info")
            End If
        End If
    End Sub

    Private Sub StopAction() 'Stops the running action and hides the graybox
        RemoveLastAction()

        Process.Start("shutdown", "-a") 'Stop running action

        If My.Settings.Language = "German" Then
            ShowNotification("Die laufende Aktion wurde abgebrochen!")
        ElseIf My.Settings.Language = "English" Then
            ShowNotification("The running action was cancelled!")
        End If

        If My.Settings.Design = "Dark" Then
            btnStartAction.BackColor = Color.FromArgb(41, 41, 41)
        ElseIf My.Settings.Design = "Light" Then
            btnStartAction.BackColor = Color.White
        End If

        If My.Settings.Language = "German" Then
            btnStartAction.Text = "Aktion starten"
        ElseIf My.Settings.Language = "English" Then
            btnStartAction.Text = "Start action"
        End If

        'Animations for graybox etc.
        pbGrayBox.Top = 347
        GrayBoxNewY = 347
        pnlActionRunning.Top = 350
        PnlActionRunningNewY = 350
        tmrGrayBoxAnimationDown.Enabled = True
        tmrPnlActionRunningAnimationDown.Enabled = True
        ActionRunning = False

        WriteToLog("Stopped action.", "Info")
    End Sub

    Public Sub ShowNotification(Text As String) 'Shows notification box at the top, String will be the displayed message
        If My.Settings.ShowNotifications = True Then
            tmrPnlNotificationAnimationDown.Enabled = False
            tmrPnlNotificationAnimationUp.Enabled = False
            lblNotification.Text = Text
            pnlNotification.Top = 20
            PnlNotificationNewY = 20
            tmrPnlNotificationAnimationDown.Enabled = True
        End If
    End Sub

    Private Sub EnableMinimalisticView() 'Shows Minimalistic View window and hides main window
        If ActionRunning Then
            frmMinimalisticView.Show()
            Hide()
        Else
            If My.Settings.Language = "German" Then
                MsgBox("Es läuft aktuell keine Aktion.", MsgBoxStyle.Critical, "Fehler")
            ElseIf My.Settings.Language = "English" Then
                MsgBox("There is currently no running action.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub InitializeProfiles()
        If My.Computer.FileSystem.DirectoryExists(ProfileDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(ProfileDirectory)
        End If

        GetFiles(ProfileDirectory)

        WriteToLog("Loading default profile...", "Info")
        If My.Settings.LoadProfileByDefault = True Then
            frmSettings.cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(AppData + "\Seeloewen Shutdown\Profiles\" + My.Settings.DefaultProfile + ".txt") Then
                    cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
                    frmLoadProfileFrom.LoadProfile(cbxDefaultProfile.SelectedItem, False)
                Else
                    If My.Settings.Language = "English" Then
                        MsgBox("Error: Default profile no longer exists. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                    ElseIf My.Settings.Language = "German" Then
                        MsgBox("Fehler: Standart-Profil existiert nicht mehr. Die Option wird automatisch deaktiviert.", MsgBoxStyle.Critical, "Fehler")
                    End If
                    WriteToLog("Default profile no longer exists. Option will be disabled automatically.", "Error")
                    frmSettings.cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                If My.Settings.Language = "English" Then
                    MsgBox("Error: Could not load default profile as it is empty. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                ElseIf My.Settings.Language = "German" Then
                    MsgBox("Fehler: Standart-Profil konnte nicht geladen werden da es leer ist. Die Option wird automatisch deaktiviert.", MsgBoxStyle.Critical, "Fehler")
                End If
                WriteToLog("Error: Could not load default profile as it is empty. Option will be disabled automatically.", "Error")
                frmSettings.cbLoadProfileByDefault.Checked = False
                My.Settings.LoadProfileByDefault = False
            End If
        End If
    End Sub

    Sub GetFiles(Path As String)
        WriteToLog("Getting profiles for frmMain...", "Info")
        If Path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(AppData + "\Seeloewen Shutdown\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
            WriteToLog("Found " + cbxDefaultProfile.Items.Count.ToString + " profiles!", "Info")
        Catch ex As Exception
            If My.Settings.Language = "English" Then
                MsgBox("Error: Could not load profiles. Please restart the application and try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            ElseIf My.Settings.Language = "German" Then
                MsgBox("Fehler: Konnte Profile nicht laden. Bitte starte die App neu und versuche es erneut." + vbNewLine + "Ausnahme: " + ex.Message, MsgBoxStyle.Critical, "Fehler")
            End If
            WriteToLog("Error: Could not load profiles for frmMain. " + ex.Message, "Error")
        End Try
    End Sub

    '-- Animations --

    Private Sub PnlNotificationAnimationDown(sender As Object, e As EventArgs) Handles tmrPnlNotificationAnimationDown.Tick
        If pnlNotification.Top <= 66 Then
            PnlNotificationNewY = PnlNotificationNewY + 3
            pnlNotification.Top = PnlNotificationNewY
        Else
            tmrPnlNotificationAnimationDown.Enabled = False
            Sleep(2500)
            tmrPnlNotificationAnimationUp.Enabled = True
        End If
    End Sub

    Private Sub PnlNotificationAnimationUp(sender As Object, e As EventArgs) Handles tmrPnlNotificationAnimationUp.Tick
        If pnlNotification.Top >= 20 Then
            PnlNotificationNewY = PnlNotificationNewY - 3
            pnlNotification.Top = PnlNotificationNewY
        Else
            tmrPnlNotificationAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub GrayBoxAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationUp.Tick
        If pbGrayBox.Top >= 353 Then
            GrayBoxNewY = GrayBoxNewY - 10
            pbGrayBox.Top = GrayBoxNewY - 10
        Else
            tmrGrayBoxAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub GrayBoxAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationDown.Tick
        If pbGrayBox.Top <= 500 Then
            GrayBoxNewY = GrayBoxNewY + 10
            pbGrayBox.Top = GrayBoxNewY
        Else
            tmrGrayBoxAnimationDown.Enabled = False
            pbGrayBox.Visible = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationUp.Tick
        If pnlActionRunning.Top >= 366 Then
            PnlActionRunningNewY = PnlActionRunningNewY - 10
            pnlActionRunning.Top = PnlActionRunningNewY
        Else
            tmrPnlActionRunningAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationDown.Tick
        If pnlActionRunning.Top <= 500 Then
            PnlActionRunningNewY = PnlActionRunningNewY + 10
            pnlActionRunning.Top = PnlActionRunningNewY
        Else
            tmrPnlActionRunningAnimationDown.Enabled = False
        End If
    End Sub

    '-- Button designs --

    Private Sub btnStartAction_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseDown
        btnStartAction.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnStartAction_MouseEnter(sender As Object, e As EventArgs) Handles btnStartAction.MouseEnter
        btnStartAction.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnStartAction_MouseLeave(sender As Object, e As EventArgs) Handles btnStartAction.MouseLeave
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStartAction_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseUp
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnShowActionHistory_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShowActionHistory.MouseDown
        btnShowActionHistory.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnShowActionHistory_MouseEnter(sender As Object, e As EventArgs) Handles btnShowActionHistory.MouseEnter
        btnShowActionHistory.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnShowActionHistory_MouseLeave(sender As Object, e As EventArgs) Handles btnShowActionHistory.MouseLeave
        btnShowActionHistory.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnShowActionHistory_MouseUp(sender As Object, e As MouseEventArgs) Handles btnShowActionHistory.MouseUp
        btnShowActionHistory.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnHamburger_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHamburger.MouseDown
        If My.Settings.Design = "Dark" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click_Dark
        ElseIf My.Settings.Design = "Light" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click
        End If
    End Sub

    Private Sub btnHamburger_MouseEnter(sender As Object, e As EventArgs) Handles btnHamburger.MouseEnter
        If My.Settings.Design = "Dark" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Hover_Dark
        ElseIf My.Settings.Design = "Light" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Hover
        End If
    End Sub

    Private Sub btnHamburger_MouseLeave(sender As Object, e As EventArgs) Handles btnHamburger.MouseLeave
        btnHamburger.BackgroundImage = My.Resources.btnHamburger
    End Sub

    Private Sub btnHamburger_MouseUp(sender As Object, e As MouseEventArgs) Handles btnHamburger.MouseUp
        btnHamburger.BackgroundImage = My.Resources.btnHamburger
    End Sub

    Private Sub btnSaveProfile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSaveProfile.MouseDown
        btnSaveProfile.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSaveProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnSaveProfile.MouseEnter
        btnSaveProfile.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSaveProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnSaveProfile.MouseLeave
        btnSaveProfile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSaveProfile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSaveProfile.MouseUp
        btnSaveProfile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLoadProfile_MouseDown(sender As Object, e As MouseEventArgs) Handles btnLoadProfile.MouseDown
        btnLoadProfile.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnLoadProfile_MouseEnter(sender As Object, e As EventArgs) Handles btnLoadProfile.MouseEnter
        btnLoadProfile.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnLoadProfile_MouseLeave(sender As Object, e As EventArgs) Handles btnLoadProfile.MouseLeave
        btnLoadProfile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnLoadProfile_MouseUp(sender As Object, e As MouseEventArgs) Handles btnLoadProfile.MouseUp
        btnLoadProfile.BackgroundImage = My.Resources.button
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        cmsHamburgerButton.Dispose()
    End Sub
End Class