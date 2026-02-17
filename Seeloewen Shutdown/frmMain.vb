Imports System.Environment
Imports System.IO
Imports System.Xml

Public Class frmMain

    '-- Attributes --

    'General variables
    Dim version As String = "1.10.0"
    Dim verDate As String = "19.02.2024"
    Public settingsVersion As Integer = 1
    Dim loadedSettingsVersion As Integer
    Public logLoadedOnce As Boolean
    Dim actionRunning As Boolean = False
    Public closingResult As String = "Close"
    Dim osVersion As Version = Environment.OSVersion.Version

    'Variables used for settings and profiles
    Dim settingsArray As String()
    Dim profileList As String()
    Public language As String
    Public design As String

    'Variables used for directory and file paths
    Public appData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public profileDirectory As String = String.Format("{0}\Seeloewen Shutdown\Profiles\", appData)
    Public settingsFile As String = String.Format("{0}\Seeloewen Shutdown\Settings.txt", appData)
    Public actionHistoryFile As String = String.Format("{0}\Seeloewen Shutdown\ActionHistory.txt", appData)
    Public processCheckFile As String = String.Format("{0}\Seeloewen Shutdown\ProcessCheck.txt", appData)
    Public debugLogTempFile As String = String.Format("{0}\Seeloewen Shutdown\DebugLogTemp", appData)

    'Variables used for animations and designs
    Dim grayBoxNewY As Integer
    Dim pnlActionRunningNewY As Integer
    Dim pnlNotificationNewY As Integer
    Dim loadErrorMsgText As String
    Dim loadErrorMsgHeader As String

    'Variables used for the timer and action
    Dim shutdownTimeType As String
    Dim maxTime As String
    Dim targetDT As DateTime
    Dim countDownFrom As TimeSpan
    Dim timeDifference As TimeSpan
    Public timeSpan As TimeSpan


    '-- Event Handlers --

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Do all main tasks before actually showing the window
        CreateFilesAndFolders()
        InitializeLoadingSettings()
        WriteToLog(String.Format("Loading Seeloewen Shutdown {0} ({1})", version, verDate), "Info")
        LoadLanguage()
        LoadDesign()
        CheckForOS()
        CheckForRunningAction()
        ResetUIElements()
        InitializeProfiles()
        ShowUpdateNews()
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'If the user wants to close the application while an action is still running, it will show an information
        If actionRunning = True And My.Settings.ShowCloseWarning = True Then
            frmClosing.ShowDialog()
            If closingResult = "Return" Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        'Start or stop action, depending on whether one is already running
        If actionRunning = False Then
            StartAction()
        ElseIf actionRunning = True Then
            StopAction()
        End If
    End Sub

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        'Show menu with different options
        If cmsHamburgerButton.Visible = True Then
            cmsHamburgerButton.Hide()
        Else
            cmsHamburgerButton.Show(btnHamburger, -100, btnHamburger.Top + 30)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        'Show settings window
        frmSettings.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        'Show about window
        frmAbout.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ChangelogToolStripMenuItem.Click
        'Show changelog window
        frmChangelog.Show()
    End Sub

    Private Sub btnShowActionHistory_Click(sender As Object, e As EventArgs) Handles btnShowActionHistory.Click
        'Show action history, if enabled
        If My.Settings.EnableActionHistory = True Then
            frmActionHistory.Show()
        Else
            If language = "English" Then
                MsgBox("Action History is currently disabled. Head to the settings to enable it.", MsgBoxStyle.Critical, "Error")
            ElseIf language = "German" Then
                MsgBox("Der Aktionsverlauf ist aktuell deaktiviert. Gehe in die Einstellungen um ihn zu aktivieren.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub MinimalisticViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinimalisticViewToolStripMenuItem.Click
        'Enable the Minimalistic View and show Minimalistic View window
        EnableMinimalisticView()
    End Sub
    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        'Open profile save dialog, if option "In..." is selected
        If rbtnIn.Checked Then
            frmSaveProfileAs.ShowDialog()
        Else
            If language = "English" Then
                MsgBox("Please choose option 'In...' to save a profile.", MsgBoxStyle.Critical, "Error")
            ElseIf language = "German" Then
                MsgBox("Bitte wähle die Option 'In...' um ein Profil zu speichern.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        'Show load profile dialog
        frmLoadProfileFrom.ShowDialog()
    End Sub


    Private Sub tmrShutdown_Tick(sender As Object, e As EventArgs) Handles tmrShutdown.Tick
        'Update timer that gets displayed. This is not the actual timer for the action, only a reference.
        timeSpan = targetDT.Subtract(DateTime.Now)
        If timeSpan.TotalMilliseconds > 0 Then
            If timeSpan.TotalHours > 24 Then
                _TimeRemaining.Text = timeSpan.ToString("dd\:hh\:mm\:ss")
            Else
                _TimeRemaining.Text = timeSpan.ToString("hh\:mm\:ss")
            End If
        End If
    End Sub

    Private Sub tmrCheckRunningProcess_Tick(sender As Object, e As EventArgs) Handles tmrCheckRunningProcess.Tick
        'Check if an action is running and the delay check is active.
        If actionRunning = True And cbDelayWhenProcessRunning.Checked = True Then
            timeDifference = Convert.ToDateTime(My.Settings.LastTime) - DateTime.Now
            'Check if there's only 11 minutes remaining on the timer
            If timeDifference.TotalMinutes < 11 Then
                'Check for each list on the process check list if it's running and delay if thats the case
                Dim processList As List(Of String) = New List(Of String)(File.ReadAllLines(processCheckFile))
                For Each process As String In processList
                    If IsProcessRunning(process) = True Then
                        'Add 5 minutes to the timer
                        EditRunningAction(My.Settings.LastAction, "Add", "300", False)
                        If language = "English" Then
                            ShowNotification("Because of running processes, the action was delayed!")
                        ElseIf language = "German" Then
                            ShowNotification("Die Aktion wurde aufgrund laufender Prozesse verzögert!")
                        End If
                        Exit For
                    End If
                Next
            End If
        End If
    End Sub

    Private Sub btnSelectProcesses_Click(sender As Object, e As EventArgs) Handles btnSelectProcesses.Click
        'Check if the process check file exists and open file editor
        If My.Computer.FileSystem.FileExists(processCheckFile) Then
            frmSelectProcesses.Show()
        Else
            If language = "English" Then
                MsgBox("The Process Check File does not exist. Please restart your application.", MsgBoxStyle.Critical, "Error")
            ElseIf language = "German" Then
                MsgBox("Die Prozess-Prüf-Datei existiert nicht. Bitte starte deine App neu.", MsgBoxStyle.Critical, "Fehler")
            End If
        End If
    End Sub

    Private Sub llblEditRunningAction_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblEditRunningAction.LinkClicked
        'Show the dialog to edit an action if one is running
        If actionRunning = True Then
            frmEditRunningAction.ShowDialog()
        End If
    End Sub

    Private Sub tbTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTime.KeyPress
        'Makes the textbox only accept numbers
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub rbtnZeitpunkt_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnPointInTime.CheckedChanged
        'Enable controls for option "Exact time" and disable controls for option "In..."
        tbTime.Enabled = False
        cbxIn.Enabled = False
        dtpDate.Enabled = True
        currentDateTime.Enabled = True

        'Display currently selected time down in the graybox
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = String.Format("In {0} {1}", tbTime.Text, cbxIn.Text)
            Else
                If language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        'Disable controls for option "Exact time" and enable controls for option "In..."
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        tbTime.Enabled = True
        cbxIn.Enabled = True

        'Display currently selected time down in the graybox
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = String.Format("In {0} {1}", tbTime.Text, cbxIn.Text)
            Else
                If language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rbtnShutdown_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnShutdown.CheckedChanged
        'Change displayed action depending on the selected option and language
        If rbtnShutdown.Checked = True Then
            If language = "English" Then
                _SelectedAction.Text = "Shutdown"
            ElseIf language = "German" Then
                _SelectedAction.Text = "Herunterfahren"
            End If
        ElseIf rbtnRestart.Checked = True Then
            If language = "English" Then
                _SelectedAction.Text = "Restart"
            ElseIf language = "German" Then
                _SelectedAction.Text = "Neustarten"
            End If
        End If
    End Sub

    Private Sub rbtnRestart_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnRestart.CheckedChanged
        'Change displayed action depending on the selected option and language
        If rbtnShutdown.Checked = True Then
            If language = "English" Then
                _SelectedAction.Text = "Shutdown"
            ElseIf language = "German" Then
                _SelectedAction.Text = "Herunterfahren"
            End If
        ElseIf rbtnRestart.Checked = True Then
            If language = "English" Then
                _SelectedAction.Text = "Restart"
            ElseIf language = "German" Then
                _SelectedAction.Text = "Neustarten"
            End If
        End If
    End Sub

    Private Sub tbTime_TextChanged(sender As Object, e As EventArgs) Handles tbTime.TextChanged
        'Update displayed time if text in textbox "In..." gets changed or point in time gets changed or selection for combobox for "In..." gets changed
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(cbxIn.Text) Then
                cbxIn.SelectedIndex = 1
            End If
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = String.Format("In {0} {1}", tbTime.Text, cbxIn.Text)
            Else
                If language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub cbxIn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxIn.SelectedIndexChanged
        'Update displayed time if text in textbox "In..." gets changed or point in time gets changed or selection for combobox for "In..." gets changed
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = String.Format("In {0} {1}", tbTime.Text, cbxIn.Text)
            Else
                If language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        'Update displayed time if text in textbox "In..." gets changed or point in time gets changed or selection for combobox for "In..." gets changed
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) = False Then
                _SelectedTime.Text = String.Format("In {0} {1}", tbTime.Text, cbxIn.Text)
            Else
                If language = "English" Then
                    _SelectedTime.Text = "No time selected"
                ElseIf language = "German" Then
                    _SelectedTime.Text = "Keine Zeit gewählt"
                End If
            End If
        ElseIf rbtnPointInTime.Checked = True Then
            _SelectedTime.Text = dtpDate.Text
        End If
    End Sub

    Private Sub rtbLog_TextChanged(sender As Object, e As EventArgs) Handles rtbLog.TextChanged
        'Update log file when log gets changed, and load changed file into log window
        rtbLog.SaveFile(debugLogTempFile)
        frmLog.rtbLog.LoadFile(debugLogTempFile)
    End Sub

    Private Sub _TimeRemaining_TextChanged(sender As Object, e As EventArgs) Handles _TimeRemaining.TextChanged
        'Change text in Minimalistic View if time remaining text in main window gets updated
        frmMinimalisticView.lblTimerShutdown.Text = _TimeRemaining.Text
    End Sub

    Private Sub llblTimeHelper_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblTimeHelper.LinkClicked
        'Show Time Helper Wizard dialog
        frmTimeHelper.ShowDialog()
    End Sub

    '-- Custom methods --

    Private Sub InitializeLoadingSettings()
        If My.Computer.FileSystem.FileExists(settingsFile) Then
            Try
                'Try to load settings and determine version
                settingsArray = File.ReadAllLines(settingsFile)
                WriteToLog(String.Format("Found settings version {0}", settingsArray(1).Replace("Version=", "").ToString), "Info")

                'Check if settings version is outdated or newer (or just right)
                ReDim Preserve settingsArray(19)
                CheckAndConvertSettings(settingsFile)
            Catch ex As Exception
                If language = "German" Then
                    MsgBox(String.Format("Beim Laden der Einstellungen ist ein Fehler aufgetreten: {0}", ex.Message), MsgBoxStyle.Critical, "Fehler")
                ElseIf language = "English" Then
                    MsgBox(String.Format("Error when loading settings: {0}", ex.Message), MsgBoxStyle.Critical, "Error")
                End If
                WriteToLog(String.Format("Error when loading settings: {0}", ex.Message), "Error")
            End Try

        Else
            'Show error and create new settings file if none exists
            WriteToLog(String.Format("Could not find settings file. Creating a new one (Version {0}).", settingsVersion.ToString), "Warning")
            My.Computer.FileSystem.WriteAllText(settingsFile, "", False)
            frmSettings.ResetSettings(settingsFile)
        End If

        'Determine what design and language the app should use.
        DetermineDesign()
        DetermineLanguage()
    End Sub

    Function IsProcessRunning(processName As String) As Boolean
        'Get a list of all processes and check if the provided process name is on the list
        Dim processes() As Process = Process.GetProcesses()

        For Each process As Process In processes
            If process.ProcessName.Equals(processName, StringComparison.OrdinalIgnoreCase) Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Sub DetermineDesign()
        'Check which setting is selected
        If My.Settings.Design = "Dark" Then
            design = "Dark"
        ElseIf My.Settings.Design = "Light" Then
            design = "Light"
        ElseIf My.Settings.Design = "System Default" Then
            'Check the registry key for Windows App Design to get current design
            Dim registryKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Themes\Personalize", True)
            If registryKey IsNot Nothing Then
                Dim value As Object = registryKey.GetValue("AppsUseLightTheme")
                If value IsNot Nothing AndAlso TypeOf value Is Integer Then
                    If CInt(value) = 0 Then 'Dark design
                        WriteToLog("Determined dark design based on registry key value", "Info")
                        design = "Dark"
                    Else 'Light design
                        WriteToLog("Determined light design based on registry key value", "Info")
                        design = "Light"
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub DetermineLanguage()
        'Check which setting is selected
        If My.Settings.Language = "English" Then
            language = "English"
        ElseIf My.Settings.Language = "German" Then
            language = "German"
        ElseIf My.Settings.Language = "System Default" Then
            'Check registry key for Windows System Language to get current language
            Dim culture As System.Globalization.CultureInfo = System.Globalization.CultureInfo.InstalledUICulture
            Dim lang As String = culture.TwoLetterISOLanguageName
            If lang = "en" Then
                language = "English"
            ElseIf lang = "de" Then
                language = "German"
            Else
                language = "English"
            End If
        End If
    End Sub
    Public Sub CheckAndConvertSettings(File As String)
        'This checks if the settings file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the settings can get loaded without errors. After loading the settings, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(settingsArray(0)) OrElse String.IsNullOrEmpty(settingsArray(1)) OrElse String.IsNullOrEmpty(settingsArray(2)) OrElse String.IsNullOrEmpty(settingsArray(3)) OrElse String.IsNullOrEmpty(settingsArray(4)) OrElse String.IsNullOrEmpty(settingsArray(5)) OrElse String.IsNullOrEmpty(settingsArray(6)) OrElse String.IsNullOrEmpty(settingsArray(7)) OrElse String.IsNullOrEmpty(settingsArray(8)) OrElse String.IsNullOrEmpty(settingsArray(9)) OrElse String.IsNullOrEmpty(settingsArray(10)) OrElse String.IsNullOrEmpty(settingsArray(11)) OrElse String.IsNullOrEmpty(settingsArray(12)) OrElse String.IsNullOrEmpty(settingsArray(13)) OrElse String.IsNullOrEmpty(settingsArray(14)) OrElse String.IsNullOrEmpty(settingsArray(15)) OrElse String.IsNullOrEmpty(settingsArray(16)) OrElse String.IsNullOrEmpty(settingsArray(17)) OrElse String.IsNullOrEmpty(settingsArray(18))) Then
            Select Case MsgBox("You are trying to load settings from an older/newer version or your settings are corrupted. You need to fix them in order to load them. You usually won't lose any settings. Do you want to continue?", vbQuestion + vbYesNo, "Load old or corrupted profile")
                Case Windows.Forms.DialogResult.Yes
                    WriteToLog("Converting settings to newer version...", "Info")
                    'Change version to the newest one to avoid further detections
                    settingsArray(0) = SettingsFilePreset.Lines(0)
                    'Convert settings if necessary
                    If String.IsNullOrEmpty(settingsArray(1)) Then
                        settingsArray(1) = SettingsFilePreset.Lines(1)
                    End If
                    If String.IsNullOrEmpty(settingsArray(2)) Then
                        settingsArray(2) = SettingsFilePreset.Lines(2)
                    End If
                    If String.IsNullOrEmpty(settingsArray(3)) Then
                        settingsArray(3) = SettingsFilePreset.Lines(3)
                    End If
                    If String.IsNullOrEmpty(settingsArray(4)) Then
                        settingsArray(4) = SettingsFilePreset.Lines(4)
                    End If
                    If String.IsNullOrEmpty(settingsArray(5)) Then
                        settingsArray(5) = SettingsFilePreset.Lines(5)
                    End If
                    If String.IsNullOrEmpty(settingsArray(6)) Then
                        settingsArray(6) = SettingsFilePreset.Lines(6)
                    End If
                    If String.IsNullOrEmpty(settingsArray(7)) Then
                        settingsArray(7) = SettingsFilePreset.Lines(7)
                    End If
                    If String.IsNullOrEmpty(settingsArray(8)) Then
                        settingsArray(8) = SettingsFilePreset.Lines(8)
                    End If
                    If String.IsNullOrEmpty(settingsArray(9)) Then
                        settingsArray(9) = SettingsFilePreset.Lines(9)
                    End If
                    If String.IsNullOrEmpty(settingsArray(10)) Then
                        settingsArray(10) = SettingsFilePreset.Lines(10)
                    End If
                    If String.IsNullOrEmpty(settingsArray(11)) Then
                        settingsArray(11) = SettingsFilePreset.Lines(11)
                    End If
                    If String.IsNullOrEmpty(settingsArray(12)) Then
                        settingsArray(12) = SettingsFilePreset.Lines(12)
                    End If
                    If String.IsNullOrEmpty(settingsArray(13)) Then
                        settingsArray(13) = SettingsFilePreset.Lines(13)
                    End If
                    If String.IsNullOrEmpty(settingsArray(14)) Then
                        settingsArray(14) = SettingsFilePreset.Lines(14)
                    End If
                    If String.IsNullOrEmpty(settingsArray(15)) Then
                        settingsArray(15) = SettingsFilePreset.Lines(15)
                    End If
                    If String.IsNullOrEmpty(settingsArray(16)) Then
                        settingsArray(16) = SettingsFilePreset.Lines(16)
                    End If
                    If String.IsNullOrEmpty(settingsArray(17)) Then
                        settingsArray(17) = SettingsFilePreset.Lines(17)
                    End If
                    If String.IsNullOrEmpty(settingsArray(18)) Then
                        settingsArray(18) = SettingsFilePreset.Lines(18)
                    End If
                    System.IO.File.WriteAllLines(settingsFile, settingsArray)
                    LoadSettings()
                    MsgBox("Loaded and converted settings. They should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                    WriteToLog("Loaded and converted settings.", "Info")
                Case Windows.Forms.DialogResult.No
                    WriteToLog("Ignored settings from newer version. Creating new file, current one will be renamed to settings.old", "Info")
                    My.Computer.FileSystem.RenameFile(settingsFile, "settings.old")
                    My.Computer.FileSystem.WriteAllText(settingsFile, "", False)
                    frmSettings.ResetSettings(settingsFile)
                    LoadSettings()
            End Select
        Else
            LoadSettings()
        End If
    End Sub

    Private Sub LoadSettings()
        Try
            WriteToLog("Loading settings...", "Info")
            'Load App settings
            My.Settings.Language = settingsArray(4).Replace("Language=", "")
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(4)), "Info")
            My.Settings.Design = settingsArray(5).Replace("Design=", "")
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(5)), "Info")
            My.Settings.ShowNotifications = Convert.ToBoolean(settingsArray(6).Replace("ShowNotifications=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(6)), "Info")
            My.Settings.ShowCloseWarning = Convert.ToBoolean(settingsArray(7).Replace("ShowCloseWarning=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(7)), "Info")
            My.Settings.EnableAnimations = Convert.ToBoolean(settingsArray(8).Replace("EnableAnimations=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(8)), "Info")

            'Load Action History settings
            My.Settings.EnableActionHistory = Convert.ToBoolean(settingsArray(11).Replace("EnableActionHistory=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(11)), "Info")

            'Load Profile settings
            My.Settings.LoadProfileByDefault = Convert.ToBoolean(settingsArray(14).Replace("LoadProfileByDefault=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(14)), "Info")
            My.Settings.DefaultProfile = settingsArray(15).Replace("DefaultProfile=", "")
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(15)), "Info")

            'Load Minimalistic View settings
            My.Settings.EnableMinimalisticView = Convert.ToBoolean(settingsArray(18).Replace("EnableMinimalisticView=", ""))
            WriteToLog(String.Format("Loaded setting {0}", settingsArray(18)), "Info")

        Catch ex As Exception

            MsgBox(String.Format("Could not load settings: {0}", ex.Message), MsgBoxStyle.Critical, "Error")
            WriteToLog(String.Format("Could not load settings: {0}", ex.Message), "Error")

            'If loading settings failed, show an option to reset settings
            Select Case MsgBox(loadErrorMsgText, vbCritical + vbYesNo, loadErrorMsgHeader)
                Case Windows.Forms.DialogResult.Yes
                    My.Computer.FileSystem.WriteAllText(settingsFile, "", False)
                    frmSettings.ResetSettings(settingsFile)
                    If language = "English" Then
                        MsgBox("Successfully reset your settings!" + vbNewLine + "The application needs to be restarted to apply changes.", MsgBoxStyle.Information, "Reset settings")
                    ElseIf language = "German" Then
                        MsgBox("Einstellungen wurden erfolgreich zurückgesetzt. Die App muss neugestartet werden, um die Änderungen zu übernehmen.", MsgBoxStyle.Information, "Einstellungen zurückgesetzt")
                    End If
                    WriteToLog("Successfully reset settings!", "Info")
                    Close()
            End Select

        End Try
    End Sub

    Private Sub ResetUIElements()
        'Reset controls to their default state
        rbtnShutdown.Checked = True
        rbtnIn.Checked = True
        If actionRunning = True Then
            tbTime.Enabled = False
            cbxIn.Enabled = False
        Else
            tbTime.Enabled = True
            cbxIn.Enabled = True
        End If
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        cbxIn.SelectedIndex = 1
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"
    End Sub

    Private Sub ShowUpdateNews()
        'Show Update News if necessary
        If My.Computer.FileSystem.FileExists(String.Format("{0}\Seeloewen Shutdown\Show_Update_News_{1}", appData, version)) = False Then
            frmUpdateNews.ShowDialog()
            Dim fs As FileStream = File.Create(String.Format("{0}\Seeloewen Shutdown\Show_Update_News_{1}", appData, version))
            fs.Close()
            WriteToLog(String.Format("Created file '{0}\Seeloewen Shutdown\Show_Update_News_{1}' so the update news don't appear again for this version ({1})", appData, version), "Info")
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate all elements to german
        If language = "German" Then
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
            llblTimeHelper.Text = "Welche Zeit sollte ich nutzen?"
            cbDelayWhenProcessRunning.Text = "Aktion verzögern, wenn" + vbNewLine + "bestimmte Prozesse laufen"
            btnSelectProcesses.Text = "Auswählen"
            llblEditRunningAction.Text = "Laufende Aktion bearbeiten"
            cbxIn.Items.Remove("Second(s)")
            cbxIn.Items.Remove("Minute(s)")
            cbxIn.Items.Remove("Hour(s)")
            cbxIn.Items.Add("Sekunde(n)")
            cbxIn.Items.Add("Minute(n)")
            cbxIn.Items.Add("Stunde(n)")

            _SelectedAction.Text = "Keine Aktion gewählt"
            _SelectedTime.Text = "Keine Zeit gewählt"

            loadErrorMsgHeader = "Fehler"
            loadErrorMsgText = "Beim Laden deiner Einstellungen ist ein Fehler aufgetreten. " + vbNewLine + "Möchtest du deine Einstellungen zurücksetzen? Das behebt vermutlich das Problem."
        ElseIf language = "English" Then
            If My.Settings.LastActionDisplay = "Neustarten" Then
                My.Settings.LastActionDisplay = "Restart"
            ElseIf My.Settings.LastActionDisplay = "Herunterfahren" Then
                My.Settings.LastActionDisplay = "Shutdown"
            End If

            _SelectedAction.Text = "No action selected"
            _SelectedTime.Text = "No time selected"

            loadErrorMsgHeader = "Error"
            loadErrorMsgText = "An error occured while loading your settings. " + vbNewLine + "Do you want to reset your settings? This probably fixes the problem."
        End If
        WriteToLog(String.Format("Loaded Language from settings: {0}", My.Settings.Language), "Info")
    End Sub

    Private Sub LoadDesign()
        'Change design to darkmode if setting is set to dark
        If design = "Dark" Then
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
            llblTimeHelper.LinkColor = Color.Cyan
            cbDelayWhenProcessRunning.ForeColor = Color.White
            llblEditRunningAction.LinkColor = Color.Cyan
        End If

        WriteToLog(String.Format("Loaded Design from settings: {0}", My.Settings.Design), "Info")
    End Sub

    Private Sub CheckForRunningAction()
        'Calculate time difference
        Try
            timeDifference = DateTime.Now - Convert.ToDateTime(My.Settings.LastTime)

            WriteToLog(String.Format("Calculated Time Difference: {0}", timeDifference.ToString), "Info")
        Catch ex As Exception
            WriteToLog(String.Format("Couldn't calculate Time Difference: {0} Please note that this might be expected and isn't necessarily a bad thing.", ex.Message), "Warning")
        End Try

        'Check if action is already running via TotalMilliseconds of TimeDifference
        If timeDifference.TotalMilliseconds < 0 Then
            dtpSelectedTime.Value = Convert.ToDateTime(My.Settings.LastTime)
            SetupGrayBox()
            CallLastAction()
            ScheduleProcessCheck()

            If language = "English" Then
                btnStartAction.Text = "Stop action"
            ElseIf language = "German" Then
                btnStartAction.Text = "Aktion stoppen"
            End If

            'Animate graybox
            pbGrayBox.Top = 550
            grayBoxNewY = 550
            pnlActionRunning.Top = 550
            pnlActionRunningNewY = 550
            pbGrayBox.Show()
            If My.Settings.EnableAnimations = True Then
                tmrGrayBoxAnimationUp.Enabled = True
                tmrPnlActionRunningAnimationUp.Enabled = True
            Else
                pbGrayBox.Top = 353
                pnlActionRunning.Top = 366
            End If
            llblEditRunningAction.Show()

            'Disable input
            rbtnShutdown.Enabled = False
            rbtnRestart.Enabled = False
            rbtnIn.Enabled = False
            rbtnPointInTime.Enabled = False
            tbTime.Enabled = False
            cbxIn.Enabled = False
            dtpDate.Enabled = False
            cbDelayWhenProcessRunning.Enabled = False
            btnSelectProcesses.Enabled = False
            btnLoadProfile.Enabled = False
            llblTimeHelper.Enabled = False

            actionRunning = True
            If design = "Dark" Then
                btnStartAction.BackColor = Color.FromArgb(25, 25, 25)
            ElseIf design = "Light" Then
                btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
            End If
            WriteToLog("Detected that an action is already running. Adjusting elements for action.", "Info")
        End If

        'Load settings that should be displayed in the "Last Action" groupbox
        _LastAction.Text = My.Settings.LastActionDisplay
        WriteToLog(String.Format("Loaded LastActionDisplay from settings: {0}", My.Settings.LastActionDisplay), "Info")
        _LastTime.Text = My.Settings.LastTimeDisplay
        WriteToLog(String.Format("Loaded LastTimeDisplay from settings: {0}", My.Settings.LastTimeDisplay), "Info")
        _StartedOn.Text = My.Settings.LastDateDisplay
        WriteToLog(String.Format("Loaded LastDateDisplay from settings: {0}", My.Settings.LastDateDisplay), "Info")
    End Sub

    Public Sub EditRunningAction(actionNew As String, changeType As String, change As String, showNotification As Boolean)
        'Get new time
        Dim newTime As DateTime
        If changeType = "Add" Then
            newTime = Convert.ToDateTime(My.Settings.LastTime).AddSeconds(Convert.ToInt32(change))
        ElseIf changeType = "Remove" Then
            newTime = Convert.ToDateTime(My.Settings.LastTime).AddSeconds(-Convert.ToInt32(change))
        ElseIf changeType = "PointInTime" Then
            newTime = Convert.ToDateTime(change)
        End If

        'Calculate and set shutdown time
        Dim timeSpan As TimeSpan = newTime - DateTime.Now
        Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

        'Check if new time is valid
        If Shutdowntime.Text > 31535999 Then
            If language = "German" Then
                MsgBox("Der ausgewählte Zeitpunkt darf nicht mehr als 1 Jahr in der Zukunft liegen!", MsgBoxStyle.Critical, "Fehler")
            ElseIf language = "English" Then
                MsgBox("The selected point in time cannot be more than 1 year in the future!", MsgBoxStyle.Critical, "Error")
            End If
        ElseIf Shutdowntime.Text < 0 Then
            If language = "German" Then
                MsgBox("Der ausgewählte Zeitpunkt darf nicht in der Vergangenheit liegen!", MsgBoxStyle.Critical, "Fehler")
            ElseIf language = "English" Then
                MsgBox("The selected point in time cannot be in the past!", MsgBoxStyle.Critical, "Error")
            End If
        Else
            'Set action so software can recognize that an action is running when being restarted
            My.Settings.LastAction = actionNew
            My.Settings.LastTime = newTime

            'Display last action
            My.Settings.LastActionDisplay = actionNew
            My.Settings.LastTimeDisplay = newTime

            'Stop running action
            Process.Start("shutdown", "-a")

            'Set the new action
            If actionNew = "Shutdown" Or actionNew = "Herunterfahren" Then
                Action.Text = "-s"

            ElseIf actionNew = "Restart" Or actionNew = "Neustart" Then
                Action.Text = "-r"
            End If
            _RunningAction.Text = actionNew

            'Display running action time and setup Shutdown timer
            countDownFrom = newTime - DateTime.Now
            _RunningTime.Text = newTime

            'Start Shutdown Timer
            tmrShutdown.Interval = 100
            targetDT = DateTime.Now.Add(countDownFrom)
            tmrShutdown.Start()

            'Start action
            Process.Start("shutdown", String.Format("{0} -t {1}", Action.Text, Shutdowntime.Text)) 'Start the action

            'Show notification if enabled and add log entry
            If showNotification = True Then
                If language = "German" Then
                    Me.ShowNotification("Die laufende Aktion wurde bearbeitet!")
                ElseIf language = "English" Then
                    Me.ShowNotification("The running action was edited!")
                End If
            End If
            WriteToLog(String.Format("Edited the current action (ShutdownTimeType: {0}, Shutdowntime: {1}, Action: {2})", shutdownTimeType, Shutdowntime.Text, Action.Text), "Info")
        End If
    End Sub
    Private Sub CheckForOS()
        'Check if OS is 7, 8 or 8.1
        If (osVersion.Major = 6 And osVersion.Minor = 1) OrElse (osVersion.Major = 6 And osVersion.Minor = 2) OrElse (osVersion.Major = 6 And osVersion.Minor = 3) Then
            If language = "German" Then
                MsgBox("Du benutzt ein Betriebssystem, das von der Software nicht mehr offiziell unterstützt wird. Es kann zu Fehlern oder anderen Problemen kommen und du wirst keinen Support erhalten.", MsgBoxStyle.Exclamation, "Warnung")
            ElseIf language = "English" Then
                MsgBox("You are using an Operating System that is no longer officially supported by the software. Errors and other problems may occur and you will not receive support.", MsgBoxStyle.Exclamation, "Warning")
            End If
        End If
    End Sub

    Private Sub CreateFilesAndFolders()
        'Create Profile directory in Appdata folder
        If My.Computer.FileSystem.DirectoryExists(String.Format("{0}\Seeloewen Shutdown\", appData)) = False Then
            My.Computer.FileSystem.CreateDirectory(String.Format("{0}\Seeloewen Shutdown\", appData))
            WriteToLog(String.Format("Created directory'{0}\Seeloewen Shutdown\'", appData), "Info")
        End If

        'Create ActionHistory file (if enabled)
        If My.Settings.EnableActionHistory = True Then
            If My.Computer.FileSystem.FileExists(actionHistoryFile) = False Then
                My.Computer.FileSystem.WriteAllText(actionHistoryFile, "", False)
                WriteToLog(String.Format("Created file '{0}'", actionHistoryFile), "Info")
            End If
        End If

        'Create ProcessCheck file
        If My.Computer.FileSystem.FileExists(processCheckFile) = False Then
            My.Computer.FileSystem.WriteAllText(processCheckFile, "", False)
            WriteToLog(String.Format("Created file '{0}'", processCheckFile), "Info")
        End If

        'Create Profile directory
        If My.Computer.FileSystem.DirectoryExists(profileDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(profileDirectory)
            WriteToLog(String.Format("Created directory '{0}'", profileDirectory), "Info")
        End If

        'Create Settings file
        If My.Computer.FileSystem.FileExists(settingsFile) = False Then
            My.Computer.FileSystem.WriteAllText(settingsFile, "", False)
            frmSettings.ResetSettings(settingsFile)
            WriteToLog(String.Format("Created file '{0}'", settingsFile), "Info")
        End If
    End Sub

    Public Sub WriteToLog(message As String, type As String)
        'Writes message into log, possible types are "Info", "Warning" and "Error"
        If type = "Error" Then
            rtbLog.SelectionColor = Color.Red
            rtbLog.AppendText(String.Format("[{0}] [ERROR] {1}" + vbNewLine, DateTime.Now, message))
        ElseIf type = "Info" Then
            rtbLog.SelectionColor = Color.FromArgb(50, 177, 205)
            rtbLog.AppendText(String.Format("[{0}] [INFO] {1}" + vbNewLine, DateTime.Now, message))
        ElseIf type = "Warning" Then
            rtbLog.SelectionColor = Color.DarkOrange
            rtbLog.AppendText(String.Format("[{0}] [WARNING] {1}" + vbNewLine, DateTime.Now, message))
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
            Dim lines() As String = IO.File.ReadAllLines(actionHistoryFile)
            Dim length As String = lines.Last.Length.ToString
            Dim fs As New FileStream(actionHistoryFile, FileMode.Open, FileAccess.ReadWrite)

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
                My.Computer.FileSystem.WriteAllText(actionHistoryFile, String.Format("{0};{1};{2}" + vbNewLine, _RunningAction.Text, dtpSelectedTime.Value, DateTime.Now), True)
            Catch ex As Exception
                WriteToLog(String.Format("Couldn't add last action to Action History. {0}", ex.Message), "Error")
            End Try
        End If
    End Sub

    Private Sub CallLastAction()
        'If an action is currently running, it will pull infos from settings to display the last known action
        currentDateTime.Value = DateTime.Now
        dtpSelectedTime.Format = DateTimePickerFormat.Custom
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"

        Dim timeSpan As TimeSpan = dtpSelectedTime.Value.Date + dtpSelectedTime.Value.TimeOfDay - currentDateTime.Value
        Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)
        countDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(Shutdowntime.Text))
        _RunningTime.Text = My.Settings.LastTime

        tmrShutdown.Interval = 100
        targetDT = DateTime.Now.Add(countDownFrom)
        tmrShutdown.Start()

        _RunningAction.Text = My.Settings.LastAction
        WriteToLog(String.Format("Called last action (CountDownFrom: {0}, ShutdownTime.Text: {1}, _RunningTime.text: {2})", countDownFrom, Shutdowntime.Text, _RunningTime.Text), "Info")
    End Sub

    Private Sub SetupGrayBox()
        'Display running action
        If language = "English" Then
            If rbtnShutdown.Checked Then
                _RunningAction.Text = "Shutdown"
            ElseIf rbtnRestart.Checked Then
                _RunningAction.Text = "Restart"
            End If
        ElseIf language = "German" Then
            If rbtnShutdown.Checked Then
                _RunningAction.Text = "Herunterfahren"
            ElseIf rbtnRestart.Checked Then
                _RunningAction.Text = "Neustarten"
            End If
        End If

        'Display running action time and setup Shutdown timer
        If rbtnIn.Checked Then
            If cbxIn.SelectedItem = "Sekunde(n)" OrElse cbxIn.SelectedItem = "Second(s)" Then
                countDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text))
            ElseIf cbxIn.SelectedItem = "Minute(n)" OrElse cbxIn.SelectedItem = "Minute(s)" Then
                countDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 60)
            ElseIf cbxIn.SelectedItem = "Stunde(n)" OrElse cbxIn.SelectedItem = "Hour(s)" Then
                countDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(tbTime.Text) * 3600)
            End If

            dtpSelectedTime.Value = DateTime.Now
            dtpSelectedTime.Value = dtpSelectedTime.Value.AddSeconds(Shutdowntime.Text)
            _RunningTime.Text = dtpSelectedTime.Text
        ElseIf rbtnPointInTime.Checked Then
            dtpSelectedTime.Value = dtpDate.Value
            countDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(Shutdowntime.Text))
            _RunningTime.Text = dtpDate.Text
        End If

        'Start Shutdown Timer
        tmrShutdown.Interval = 100
        targetDT = DateTime.Now.Add(countDownFrom)
        tmrShutdown.Start()

        WriteToLog(String.Format("Set gray box up (CountDownFrom: {0}, Shutdowntime.Text: {1}, _RunningTime.Text: {2})", countDownFrom.ToString, Shutdowntime.Text, _RunningTime.Text), "Info")
    End Sub

    Private Sub ScheduleProcessCheck()
        'Start checking if the processes are running and if a delay needs to be put
        tmrCheckRunningProcess.Start()
    End Sub

    Private Sub StartAction()
        'Set Backcolor of "Start Action" Button
        If design = "Dark" Then
            btnStartAction.BackColor = Color.FromArgb(25, 25, 25)
        ElseIf design = "Light" Then
            btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
        End If

        'Set action using "in..."
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) Then
                If language = "German" Then
                    MsgBox("Bitte gib eine Zeitangabe an!", MsgBoxStyle.Critical, "Fehler")
                ElseIf language = "English" Then
                    MsgBox("Please enter a time!", MsgBoxStyle.Critical, "Error")
                End If
            Else 'Set Shutdown type
                If rbtnShutdown.Checked = True Then
                    Action.Text = "-s"
                ElseIf rbtnRestart.Checked = True Then
                    Action.Text = "-r"
                End If

                'Calculate and set shutdown time
                If cbxIn.SelectedItem = "Sekunde(n)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxTime = "31535999"
                    shutdownTimeType = "Sekunde(n)"
                ElseIf cbxIn.SelectedItem = "Second(s)" Then
                    Shutdowntime.Text = tbTime.Text
                    maxTime = "31535999"
                    shutdownTimeType = "Second(s)"
                ElseIf cbxIn.SelectedItem = "Minute(n)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxTime = "525599"
                    shutdownTimeType = "Minute(n)"
                ElseIf cbxIn.SelectedItem = "Minute(s)" Then
                    Shutdowntime.Text = tbTime.Text * 60
                    maxTime = "525599"
                    shutdownTimeType = "Minute(s)"
                ElseIf cbxIn.SelectedItem = "Stunde(n)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxTime = "8759"
                    shutdownTimeType = "Stunde(n)"
                ElseIf cbxIn.SelectedItem = "Hour(s)" Then
                    Shutdowntime.Text = tbTime.Text * 3600
                    maxTime = "8759"
                    shutdownTimeType = "Hour(s)"
                End If

                'Run action
                If Shutdowntime.Text > 31535999 Then 'Show error if shutdown time is greater than the max number allowed
                    If language = "German" Then
                        MsgBox(String.Format("Die maximale Zeitangabe für '{0}' beträgt {1}", shutdownTimeType, maxTime), MsgBoxStyle.Critical, "Fehler")
                    ElseIf language = "English" Then
                        MsgBox(String.Format("The maximum time for '{1}' is {1}", shutdownTimeType, maxTime), MsgBoxStyle.Critical, "Error")
                    End If
                ElseIf Shutdowntime.Text = 0 Then 'Show error if shutdown time is zero
                    If language = "German" Then
                        MsgBox("Die Zeitangabe darf nicht Null sein!", MsgBoxStyle.Critical, "Fehler")
                    ElseIf language = "English" Then
                        MsgBox("The time cannot be zero!", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    SetupGrayBox()
                    SetLastAction()
                    ScheduleProcessCheck()

                    Process.Start("shutdown", String.Format("{0} -t {1}", Action.Text, Shutdowntime.Text)) 'Start the action

                    If language = "German" Then
                        ShowNotification("Eine Aktion wurde gestartet!")
                    ElseIf language = "English" Then
                        ShowNotification("An action was started!")
                    End If

                    If language = "English" Then
                        btnStartAction.Text = "Stop action"
                    ElseIf language = "German" Then
                        btnStartAction.Text = "Aktion stoppen"
                    End If

                    'Animations for graybox etc.
                    pbGrayBox.Top = 550
                    grayBoxNewY = 550
                    pnlActionRunning.Top = 550
                    pnlActionRunningNewY = 550
                    pbGrayBox.Show()
                    If My.Settings.EnableAnimations = True Then
                        tmrGrayBoxAnimationUp.Enabled = True
                        tmrPnlActionRunningAnimationUp.Enabled = True
                    Else
                        pbGrayBox.Top = 353
                        pnlActionRunning.Top = 366
                    End If
                    actionRunning = True
                    llblEditRunningAction.Show()

                    'Disable input
                    rbtnShutdown.Enabled = False
                    rbtnRestart.Enabled = False
                    rbtnIn.Enabled = False
                    rbtnPointInTime.Enabled = False
                    tbTime.Enabled = False
                    cbxIn.Enabled = False
                    dtpDate.Enabled = False
                    cbDelayWhenProcessRunning.Enabled = False
                    btnSelectProcesses.Enabled = False
                    btnLoadProfile.Enabled = False
                    llblTimeHelper.Enabled = False

                    If My.Settings.EnableMinimalisticView = True Then
                        EnableMinimalisticView()
                    End If

                    WriteToLog(String.Format("Started action (ShutdownTimeType: {0}, Shutdowntime: {1}, Action: {2}, Type: In...)", shutdownTimeType, Shutdowntime.Text, Action.Text), "Info")
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
            dtpDate.Format = DateTimePickerFormat.Custom
            dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
            Dim timeSpan As TimeSpan = dtpDate.Value.Date + dtpDate.Value.TimeOfDay - currentDateTime.Value
            Shutdowntime.Text = Math.Ceiling(timeSpan.TotalSeconds)

            'Run action
            If Shutdowntime.Text > 31535999 Then
                If language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht mehr als 1 Jahr in der Zukunft liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf language = "English" Then
                    MsgBox("The selected point in time cannot be more than 1 year in the future!", MsgBoxStyle.Critical, "Error")
                End If
            ElseIf Shutdowntime.Text < 0 Then
                If language = "German" Then
                    MsgBox("Der ausgewählte Zeitpunkt darf nicht in der Vergangenheit liegen!", MsgBoxStyle.Critical, "Fehler")
                ElseIf language = "English" Then
                    MsgBox("The selected point in time cannot be in the past!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                SetupGrayBox()
                SetLastAction()

                Process.Start("shutdown", String.Format("{0} -t {1}", Action.Text, Shutdowntime.Text)) 'Start the action

                If language = "English" Then
                    btnStartAction.Text = "Stop action"
                ElseIf language = "German" Then
                    btnStartAction.Text = "Aktion stoppen"
                End If

                'Animations for graybox etc.
                pbGrayBox.Top = 550
                grayBoxNewY = 550
                pnlActionRunning.Top = 550
                pnlActionRunningNewY = 550
                pbGrayBox.Show()
                tmrGrayBoxAnimationUp.Enabled = True
                tmrPnlActionRunningAnimationUp.Enabled = True
                actionRunning = True

                'Disable input
                rbtnShutdown.Enabled = False
                rbtnRestart.Enabled = False
                rbtnIn.Enabled = False
                rbtnPointInTime.Enabled = False
                tbTime.Enabled = False
                cbxIn.Enabled = False
                dtpDate.Enabled = False
                cbDelayWhenProcessRunning.Enabled = False
                btnSelectProcesses.Enabled = False
                btnLoadProfile.Enabled = False
                llblTimeHelper.Enabled = False

                If My.Settings.EnableMinimalisticView = True Then
                    EnableMinimalisticView()
                End If

                WriteToLog(String.Format("Started action (ShutdownTimetype: {0}, Shutdowntime: {1}, Action: {2}, Type: PointInTime)", shutdownTimeType, Shutdowntime.Text, Action.Text), "Info")
            End If
        End If
    End Sub

    Private Sub StopAction() 'Stops the running action and hides the graybox
        RemoveLastAction()

        Process.Start("shutdown", "-a") 'Stop running action

        If language = "German" Then
            ShowNotification("Die laufende Aktion wurde abgebrochen!")
        ElseIf language = "English" Then
            ShowNotification("The running action was cancelled!")
        End If

        If design = "Dark" Then
            btnStartAction.BackColor = Color.FromArgb(41, 41, 41)
        ElseIf design = "Light" Then
            btnStartAction.BackColor = Color.White
        End If

        If language = "German" Then
            btnStartAction.Text = "Aktion starten"
        ElseIf language = "English" Then
            btnStartAction.Text = "Start action"
        End If

        'Animations for graybox etc.
        pbGrayBox.Top = 347
        grayBoxNewY = 347
        pnlActionRunning.Top = 350
        pnlActionRunningNewY = 350
        If My.Settings.EnableAnimations = True Then
            tmrGrayBoxAnimationDown.Enabled = True
            tmrPnlActionRunningAnimationDown.Enabled = True
        Else
            pbGrayBox.Top = 500
            pnlActionRunning.Top = 500
        End If
        actionRunning = False
        llblEditRunningAction.Hide()

        'Enable input
        rbtnShutdown.Enabled = True
        rbtnRestart.Enabled = True
        rbtnPointInTime.Enabled = True
        rbtnIn.Enabled = True
        If rbtnIn.Checked = True Then
            tbTime.Enabled = True
            cbxIn.Enabled = True
        ElseIf rbtnPointInTime.Checked = True Then
            dtpDate.Enabled = True
        End If
        cbDelayWhenProcessRunning.Enabled = True
        btnSelectProcesses.Enabled = True
        btnLoadProfile.Enabled = True
        llblTimeHelper.Enabled = True

        WriteToLog("Stopped action.", "Info")
    End Sub

    Public Async Sub ShowNotification(text As String)
        'Shows notification box at the top, String will be the displayed message
        If My.Settings.ShowNotifications = True Then
            tmrPnlNotificationAnimationDown.Enabled = False
            tmrPnlNotificationAnimationUp.Enabled = False
            lblNotification.Text = text
            pnlNotification.Top = 20
            pnlNotificationNewY = 20
            If My.Settings.EnableAnimations = True Then
                tmrPnlNotificationAnimationDown.Enabled = True
            Else
                pnlNotification.Top = 66
                pnlNotificationNewY = 66
                Await Task.Delay(2500)
                pnlNotification.Top = 20
                pnlNotificationNewY = 20
            End If
        End If
    End Sub

    Private Sub EnableMinimalisticView()
        'Shows Minimalistic View window and hides main window
        If actionRunning = True Then
            frmMinimalisticView.Show()
            Hide()
        Else
            If language = "German" Then
                MsgBox("Es läuft aktuell keine Aktion.", MsgBoxStyle.Critical, "Fehler")
            ElseIf language = "English" Then
                MsgBox("There is currently no running action.", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub

    Private Sub InitializeProfiles()
        'Begin initialisation of profiles and load default profile
        If My.Computer.FileSystem.DirectoryExists(profileDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(profileDirectory)
        End If

        GetFiles(profileDirectory)

        WriteToLog("Loading default profile...", "Info")
        If My.Settings.LoadProfileByDefault = True Then
            frmSettings.cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(String.Format("{0}{1}.txt", profileDirectory, My.Settings.DefaultProfile)) Then
                    cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
                    frmLoadProfileFrom.InitializeLoadingProfile(cbxDefaultProfile.SelectedItem, False)
                Else
                    If language = "English" Then
                        MsgBox("Error: Default profile no longer exists. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                    ElseIf language = "German" Then
                        MsgBox("Fehler: Standart-Profil existiert nicht mehr. Die Option wird automatisch deaktiviert.", MsgBoxStyle.Critical, "Fehler")
                    End If
                    WriteToLog("Default profile no longer exists. Option will be disabled automatically.", "Error")
                    frmSettings.cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                If language = "English" Then
                    MsgBox("Error: Could not load default profile as it is empty. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                ElseIf language = "German" Then
                    MsgBox("Fehler: Standart-Profil konnte nicht geladen werden da es leer ist. Die Option wird automatisch deaktiviert.", MsgBoxStyle.Critical, "Fehler")
                End If
                WriteToLog("Error: Could not load default profile as it is empty. Option will be disabled automatically.", "Error")
                frmSettings.cbLoadProfileByDefault.Checked = False
                My.Settings.LoadProfileByDefault = False
            End If
        End If
    End Sub

    Sub GetFiles(path As String)
        'Get all profile files in the profile directory and put them into the combobox. Please note that this combobox is not visible
        WriteToLog("Getting profiles for frmMain.", "Info")
        If path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(path)

        Try
            For Each profile As String In profileList
                If Directory.Exists(profile) Then
                    GetFiles(profile)
                Else
                    profile = profile.Replace(profileDirectory, "").Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(profile)
                End If
            Next
            WriteToLog(String.Format("Found {0} profiles!", cbxDefaultProfile.Items.Count), "Info")
        Catch ex As Exception
            If language = "English" Then
                MsgBox("Error: Could not load profiles. Please restart the application and try again." + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, "Error")
            ElseIf language = "German" Then
                MsgBox("Fehler: Konnte Profile nicht laden. Bitte starte die App neu und versuche es erneut." + vbNewLine + "Ausnahme: " + ex.Message, MsgBoxStyle.Critical, "Fehler")
            End If
            WriteToLog(String.Format("Error: Could not load profiles for frmMain. {0}", ex.Message), "Error")
        End Try
    End Sub

    '-- Animations --

    Private Async Sub PnlNotificationAnimationDown(sender As Object, e As EventArgs) Handles tmrPnlNotificationAnimationDown.Tick
        If pnlNotification.Top <= 66 Then
            pnlNotificationNewY = pnlNotificationNewY + 3
            pnlNotification.Top = pnlNotificationNewY
        Else
            tmrPnlNotificationAnimationDown.Enabled = False
            Await Task.Delay(2500)
            tmrPnlNotificationAnimationUp.Enabled = True
        End If
    End Sub

    Private Sub PnlNotificationAnimationUp(sender As Object, e As EventArgs) Handles tmrPnlNotificationAnimationUp.Tick
        If pnlNotification.Top >= 20 Then
            pnlNotificationNewY = pnlNotificationNewY - 3
            pnlNotification.Top = pnlNotificationNewY
        Else
            tmrPnlNotificationAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub GrayBoxAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationUp.Tick
        If pbGrayBox.Top >= 353 Then
            grayBoxNewY = grayBoxNewY - 10
            pbGrayBox.Top = grayBoxNewY - 10
        Else
            tmrGrayBoxAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub GrayBoxAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationDown.Tick
        If pbGrayBox.Top <= 500 Then
            grayBoxNewY = grayBoxNewY + 10
            pbGrayBox.Top = grayBoxNewY
        Else
            tmrGrayBoxAnimationDown.Enabled = False
            pbGrayBox.Visible = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationUp.Tick
        If pnlActionRunning.Top >= 366 Then
            pnlActionRunningNewY = pnlActionRunningNewY - 10
            pnlActionRunning.Top = pnlActionRunningNewY
        Else
            tmrPnlActionRunningAnimationUp.Enabled = False
        End If
    End Sub

    Private Sub PnlActionRunningAnimationDown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrPnlActionRunningAnimationDown.Tick
        If pnlActionRunning.Top <= 500 Then
            pnlActionRunningNewY = pnlActionRunningNewY + 10
            pnlActionRunning.Top = pnlActionRunningNewY
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
        If design = "Dark" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click_Dark
        ElseIf design = "Light" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click
        End If
    End Sub

    Private Sub btnHamburger_MouseEnter(sender As Object, e As EventArgs) Handles btnHamburger.MouseEnter
        If design = "Dark" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Hover_Dark
        ElseIf design = "Light" Then
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

    Private Sub btnSelectProcesses_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSelectProcesses.MouseDown
        btnSelectProcesses.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSelectProcesses_MouseEnter(sender As Object, e As EventArgs) Handles btnSelectProcesses.MouseEnter
        btnSelectProcesses.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSelectProcesses_MouseLeave(sender As Object, e As EventArgs) Handles btnSelectProcesses.MouseLeave
        btnSelectProcesses.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSelectProcesses_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSelectProcesses.MouseUp
        btnSelectProcesses.BackgroundImage = My.Resources.button
    End Sub
End Class