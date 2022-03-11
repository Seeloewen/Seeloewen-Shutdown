Imports System.Environment
Imports System.IO

Public Class frmMain
    Dim Version As String = "1.7.0"
    Dim ShutdownTimeType As String
    Dim maxtime As String
    Dim AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ActionRunning As Boolean = False
    Dim GrayBoxNewY As Integer
    Dim PnlActionRunningNewY As Integer
    Dim TargetDT As DateTime
    Dim CountDownFrom As TimeSpan
    Dim TimeDifference As TimeSpan


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Translate all elements and load Language Setting
        If My.Settings.Language = "English" OrElse My.Settings.Language = "German" Then
        Else frmFirstStart.ShowDialog()
        End If

        If My.Settings.Language = "German" Then
            If My.Settings.LastActionDisplay = "Restart" Then
                My.Settings.LastActionDisplay = "Neustarten"
            ElseIf My.Settings.LastActionDisplay = "Shutdown" Then
                My.Settings.LastActionDisplay = "Herunterfahren"
            End If

            lblAction.Text = "Aktion                                        "
            lblTime.Text = "Zeit                                            "
            rbtnShutdown.Text = "Herunterfahren"
            rbtnRestart.Text = "Neustarten"
            rbtnPointInTime.Text = "Zeitpunkt"
            ToolStripMenuItem1.Text = "Einstellungen"
            ToolStripMenuItem2.Text = "Changelog"
            ToolStripMenuItem3.Text = "Über"
            lblSelectedAction.Text = "Gewählte Aktion:"
            lblSelectedTime.Text = "Gewählte Zeit:"
            lblScheduledAction.Text = "Geplante Aktion:"
            lblScheduledTime.Text = "Geplante Zeit:"
            lblTimeRemaining.Text = "Verbleibende Zeit:"
            gbLastAction.Text = "Letzte Aktion"
            lblLastAction.Text = "Aktion:"
            lblLastTime.Text = "Zeit:"
            lblExecutedOn.Text = "Ausgeführt am:"
            cbxIn.Items.Remove("Second(s)")
            cbxIn.Items.Remove("Minute(s)")
            cbxIn.Items.Remove("Hour(s)")
            cbxIn.Items.Add("Sekunde(n)")
            cbxIn.Items.Add("Minute(n)")
            cbxIn.Items.Add("Stunde(n)")
        ElseIf My.Settings.Language = "English" Then
            If My.Settings.LastActionDisplay = "Neustarten" Then
                My.Settings.LastActionDisplay = "Restart"
            ElseIf My.Settings.LastActionDisplay = "Herunterfahren" Then
                My.Settings.LastActionDisplay = "Shutdown"
            End If
        End If
        WriteToLog("Loaded Language from settings: " + My.Settings.Language, "Info")

        'Load Design setting
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
            lblExecutedOn.ForeColor = Color.White
            _ExecutedOn.ForeColor = Color.White
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
        _ExecutedOn.Text = My.Settings.LastDateDisplay
        WriteToLog("Loaded LastDateDisplay from settings: " + My.Settings.LastDateDisplay, "Info")

        'Reset UI elements to default
        If My.Settings.Language = "English" Then
            _SelectedAction.Text = "No action selected"
            _SelectedTime.Text = "No time selected"
        ElseIf My.Settings.Language = "German" Then
            _SelectedAction.Text = "Keine Aktion gewählt"
            _SelectedTime.Text = "Keine Zeit gewählt"
        End If

        rbtnIn.Checked = True
        dtpDate.Enabled = False
        currentDateTime.Enabled = False
        dtpDate.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        dtpSelectedTime.CustomFormat = "dd.MM.yyyy HH:mm:ss"
        tbTime.Text = My.Settings.DefaultTime
        WriteToLog("Reset UI elements to default and loaded DefaultTime from settings: " + My.Settings.DefaultTime, "Info")

        'Show Update News if necessary
        If My.Computer.FileSystem.FileExists(AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version) = False Then
            frmUpdateNews.ShowDialog()
            If My.Computer.FileSystem.DirectoryExists(AppData + "/Seeloewen Shutdown") = False Then
                My.Computer.FileSystem.CreateDirectory(AppData + "/Seeloewen Shutdown")
                WriteToLog("Created directory " + "'" + AppData + "/Seeloewen Shutdown" + "'", "Info")
            End If

            Dim fs As FileStream = File.Create(AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version)
            fs.Close()
            WriteToLog("Created file " + "'" + AppData + "/Seeloewen Shutdown/Show_Update_News_" + Version + "' so the update news don't appear again for this version (" + Version + ")", "Info")
        End If

        'Load DefaultAction setting
        If My.Settings.DefaultAction = "shutdown" Then
            rbtnShutdown.Checked = True
            If My.Settings.Language = "English" Then
                _SelectedAction.Text = "Shutdown"
            ElseIf My.Settings.Language = "German" Then
                _SelectedAction.Text = "Herunterfahren"
            End If
        ElseIf My.Settings.DefaultAction = "restart" Then
            rbtnRestart.Checked = True
            If My.Settings.Language = "English" Then
                _SelectedAction.Text = "Restart"
            ElseIf My.Settings.Language = "German" Then
                _SelectedAction.Text = "Neustarten"
            End If
        End If
        WriteToLog("Loaded DefaultAction from settings: " + My.Settings.DefaultAction, "Info")

        'This comment was made on 22.02.2022 and committed on 22.02.2022 22:22

        'Load DefaultTimeChoice setting
        If My.Settings.DefaultTimeChoice = "minutes" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Minute(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Minute(n)"
            End If
        ElseIf My.Settings.DefaultTimeChoice = "seconds" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Second(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Sekunde(n)"
            End If
        ElseIf My.Settings.DefaultTimeChoice = "hours" Then
            If My.Settings.Language = "English" Then
                cbxIn.SelectedItem = "Hour(s)"
            ElseIf My.Settings.Language = "German" Then
                cbxIn.SelectedItem = "Stunde(n)"
            End If
        End If
        WriteToLog("Loaded DefaultTimeChoice from settings: " + My.Settings.DefaultTimeChoice, "Info")
    End Sub

    Private Sub btnOpenHelp_Click(sender As Object, e As EventArgs)
        frmAbout.Show()
    End Sub

    Private Sub btnStartAction_Click(sender As Object, e As EventArgs) Handles btnStartAction.Click
        If ActionRunning = False Then
            StartAction()

            If My.Settings.Design = "Dark" Then
                btnStartAction.BackColor = Color.FromArgb(25, 25, 25)
            ElseIf My.Settings.Design = "Light" Then
                btnStartAction.BackColor = Color.FromArgb(232, 232, 232)
            End If

        ElseIf ActionRunning = True Then
            RemoveLastAction()
            WriteToLog("Stopped action.", "Info")
            Process.Start("shutdown", "-a")

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

            pbGrayBox.Top = 347
            GrayBoxNewY = 347
            pnlActionRunning.Top = 350
            PnlActionRunningNewY = 350
            tmrGrayBoxAnimationDown.Enabled = True
            tmrPnlActionRunningAnimationDown.Enabled = True
            ActionRunning = False
        End If
    End Sub

    Public Sub WriteToLog(Message As String, Type As String)
        If Type = "Error" Then
            frmLog.rtbLog.SelectionColor = Color.Red
            frmLog.rtbLog.AppendText("[" + DateTime.Now + "] " + "[ERROR] " + Message + vbNewLine)
        ElseIf Type = "Info" Then
            frmLog.rtbLog.SelectionColor = Color.FromArgb(50, 177, 205)
            frmLog.rtbLog.AppendText("[" + DateTime.Now + "] " + "[INFO] " + Message + vbNewLine)
        ElseIf Type = "Warning" Then
            frmLog.rtbLog.SelectionColor = Color.DarkOrange
            frmLog.rtbLog.AppendText("[" + DateTime.Now + "] " + "[WARNING] " + Message + vbNewLine)
        Else
            frmLog.rtbLog.AppendText("--> Critical Log Error: Invalid type received" + vbNewLine)
        End If
    End Sub

    Private Sub RemoveLastAction()
        My.Settings.LastAction = "-"
        My.Settings.LastTime = "-"
        My.Settings.LastDate = "-"
        WriteToLog("Removed 'last Action'.", "Info")
    End Sub

    Private Sub SetLastAction()
        My.Settings.LastAction = _RunningAction.Text
        My.Settings.LastTime = dtpSelectedTime.Value
        My.Settings.LastDate = DateTime.Now
        My.Settings.LastActionDisplay = _RunningAction.Text
        My.Settings.LastTimeDisplay = dtpSelectedTime.Value
        My.Settings.LastDateDisplay = DateTime.Now
    End Sub

    Private Sub CallLastAction()
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
        WriteToLog("Called last action (CountDownFrom: " + CountDownFrom.ToString + ", ShutdownTime.Text: " + Shutdowntime.Text + ", _RunningTime.text: + " + _RunningTime.Text + ")", "Info")
    End Sub

    Private Sub SetupGrayBox()
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

        tmrShutdown.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)
        tmrShutdown.Start()

        WriteToLog("Set gray box up (CountDownFrom: " + CountDownFrom.ToString + ", ShutdownTime.Text: " + Shutdowntime.Text + ", _RunningTime.text: + " + _RunningTime.Text + ")", "Info")
    End Sub

    Private Sub tmrShutdown_Tick(sender As Object, e As EventArgs) Handles tmrShutdown.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            If ts.TotalHours > 24 Then
                _TimeRemaining.Text = ts.ToString("dd\:hh\:mm\:ss")
            Else _TimeRemaining.Text = ts.ToString("hh\:mm\:ss")
            End If
        End If

    End Sub

    Private Sub tbTime_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTime.KeyPress
        Select Case Asc(e.KeyChar)
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

    Private Sub CallShutDown()
        Process.Start("shutdown", Action.Text + " -t " + Shutdowntime.Text)
    End Sub

    Sub Sleep(ByVal sleeptime As Integer)
        Dim Stopwatch As New Stopwatch

        Stopwatch.Start()

        Do Until Stopwatch.ElapsedMilliseconds >= sleeptime
            Application.DoEvents()
        Loop
        Stopwatch.Stop()
        Stopwatch.Reset()
    End Sub

    Private Sub btnOpenSettings_Click(sender As Object, e As EventArgs)
        frmSettings.Show()
    End Sub

    Private Sub GrayBoxAnimationUp(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrGrayBoxAnimationUp.Tick
        If pbGrayBox.Top >= 331 Then
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
        If pnlActionRunning.Top >= 347 Then
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

    Private Sub StartAction()

        'Set action using "in..."
        If rbtnIn.Checked = True Then
            If String.IsNullOrEmpty(tbTime.Text) Then
                If My.Settings.Language = "German" Then
                    MsgBox("Bitte gib eine Zeitangabe an!", MsgBoxStyle.Critical, "Fehler")
                ElseIf My.Settings.Language = "English" Then
                    MsgBox("Please enter a time!", MsgBoxStyle.Critical, "Error")
                End If
            Else
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
                If Shutdowntime.Text > 31535999 Then
                    If My.Settings.Language = "German" Then
                        MsgBox("Die maximale Zeitangabe für " + Quotationmark.Text + ShutdownTimeType + Quotationmark.Text + " beträgt " + maxtime, MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The maximum time for " + Quotationmark.Text + ShutdownTimeType + Quotationmark.Text + " is " + maxtime, MsgBoxStyle.Critical, "Error")
                    End If
                ElseIf Shutdowntime.Text = 0 Then
                    If My.Settings.Language = "German" Then
                        MsgBox("Die Zeitangabe darf nicht Null sein!", MsgBoxStyle.Critical, "Fehler")
                    ElseIf My.Settings.Language = "English" Then
                        MsgBox("The time cannot be zero!", MsgBoxStyle.Critical, "Error")
                    End If
                Else
                    SetupGrayBox()
                    SetLastAction()
                    CallShutDown()
                    WriteToLog("Started action (ShutdownTimeType: " + ShutdownTimeType + ", Shutdowntime: " + Shutdowntime.Text + ", Action: " + Action.Text + ", type: In...)", "Info")
                    btnStartAction.BackColor = Color.FromArgb(232, 232, 232)

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
                End If
            End If
        End If

        'Set action using "Point in Time"
        If rbtnPointInTime.Checked = True Then
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
                WriteToLog("Started action (ShutdownTimetype: " + ShutdownTimeType + ", Shutdowntime: " + Shutdowntime.Text + ", Action: " + Action.Text + ", type: PointInTime)", "Info")
                CallShutDown()
                btnStartAction.BackColor = Color.FromArgb(232, 232, 232)

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
            End If
            End If
    End Sub

    Private Sub btnStartAction_MouseDown(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseDown
        btnStartAction.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnStartAction_MouseHover(sender As Object, e As EventArgs) Handles btnStartAction.MouseHover
        btnStartAction.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnStartAction_MouseLeave(sender As Object, e As EventArgs) Handles btnStartAction.MouseLeave
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnStartAction_MouseUp(sender As Object, e As MouseEventArgs) Handles btnStartAction.MouseUp
        btnStartAction.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnHamburger_Click(sender As Object, e As EventArgs) Handles btnHamburger.Click
        If cmsHamburgerButton.Visible = True Then
            cmsHamburgerButton.Hide()
        Else
            cmsHamburgerButton.Show(btnHamburger, -100, btnHamburger.Top + 30)
        End If
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmSettings.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmAbout.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmChangelog.Show()
    End Sub

    Private Sub btnHamburger_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHamburger.MouseDown
        If My.Settings.Design = "Dark" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click_Dark
        ElseIf My.Settings.Design = "Light" Then
            btnHamburger.BackgroundImage = My.Resources.btnHamburger_Click
        End If
    End Sub

    Private Sub btnHamburger_MouseHover(sender As Object, e As EventArgs) Handles btnHamburger.MouseHover
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
End Class