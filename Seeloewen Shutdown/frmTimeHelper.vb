Public Class frmTimeHelper

    Dim currentPage As Double
    Dim determinedTime As Double
    Dim sizeOfDownload As Double
    Dim internetSpeed As Double
    Dim itemsPerMinute As Double
    Dim itemsNeeded As Double
    Dim totalSize As Double
    Dim driveSpeed As Double
    Dim timeUnit As String

    '-- Event handlers --

    Private Sub frmTimeHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Put all group boxes to the right position and hide most boxes
        gbStep1.Left = 17
        gbStep1.Top = 48
        gbStep1.Show()
        gbStep2AFK.Left = 17
        gbStep2AFK.Top = 48
        gbStep2AFK.Hide()
        gbStep2Download.Left = 17
        gbStep2Download.Top = 48
        gbStep2Download.Hide()
        gbStep2Drive.Left = 17
        gbStep2Drive.Top = 48
        gbStep2Drive.Hide()
        gbStep2Nothing.Left = 17
        gbStep2Nothing.Top = 48
        gbStep2Nothing.Hide()
        gbStep3.Left = 17
        gbStep3.Top = 48
        gbStep3.Hide()

        'Reset page to default
        currentPage = 1
        rbtnDownloadGame.Checked = True
        btnContinue.Text = "Continue"
        btnBack.Text = "Close"

        'Reset variables and textboxes
        determinedTime = 0
        sizeOfDownload = 0
        internetSpeed = 0
        itemsPerMinute = 0
        itemsNeeded = 0
        totalSize = 0
        driveSpeed = 0
        tbSizeOfDownload.Clear()
        tbYourInternetSpeed.Clear()
        tbItemsNeeded.Clear()
        tbItemsPerMinute.Clear()
        tbTotalSize.Clear()
        tbDriveSpeed.Clear()

        'Select default options for comboboxes
        cbxSizeOfDownload.SelectedIndex = 2
        cbxYourInternetSpeed.SelectedIndex = 1
        cbxTotalSize.SelectedIndex = 2
        cbxDriveSpeed.SelectedIndex = 1

        'Load user preferences
        LoadDesign()
        LoadTranslations()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'Check which page user is on and go to the next page
        If currentPage = 1 Then
            Close()
        ElseIf currentPage = 2.1 Then
            gbStep1.Show()
            gbStep2AFK.Hide()
            gbStep2Download.Hide()
            gbStep2Drive.Hide()
            gbStep2Nothing.Hide()
            gbStep3.Hide()
            If frmMain.language = "English" Then
                btnContinue.Text = "Continue"
                btnBack.Text = "Close"
            ElseIf frmMain.language = "German" Then
                btnContinue.Text = "Weiter"
                btnBack.Text = "Schließen"
            End If
            currentPage = 1
        ElseIf currentPage = 2.2 Then
            gbStep1.Show()
            gbStep2AFK.Hide()
            gbStep2Download.Hide()
            gbStep2Drive.Hide()
            gbStep2Nothing.Hide()
            gbStep3.Hide()
            If frmMain.language = "English" Then
                btnContinue.Text = "Continue"
                btnBack.Text = "Close"
            ElseIf frmMain.language = "German" Then
                btnContinue.Text = "Weiter"
                btnBack.Text = "Schließen"
            End If
            currentPage = 1
        ElseIf currentPage = 2.3 Then
            gbStep1.Show()
            gbStep2AFK.Hide()
            gbStep2Download.Hide()
            gbStep2Drive.Hide()
            gbStep2Nothing.Hide()
            gbStep3.Hide()
            If frmMain.language = "English" Then
                btnContinue.Text = "Continue"
                btnBack.Text = "Close"
            ElseIf frmMain.language = "German" Then
                btnContinue.Text = "Weiter"
                btnBack.Text = "Schließen"
            End If
            currentPage = 1
        ElseIf currentPage = 2.4 Then
            gbStep1.Show()
            gbStep2AFK.Hide()
            gbStep2Download.Hide()
            gbStep2Drive.Hide()
            gbStep2Nothing.Hide()
            gbStep3.Hide()
            If frmMain.language = "English" Then
                btnContinue.Text = "Continue"
                btnBack.Text = "Close"
            ElseIf frmMain.language = "German" Then
                btnContinue.Text = "Weiter"
                btnBack.Text = "Schließen"
            End If
            currentPage = 1
        ElseIf currentPage = 3 Then
            If rbtnAFK.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Show()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.1
            ElseIf rbtnCopyFiles.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Show()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.2
            ElseIf rbtnDownloadGame.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Show()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.3
            ElseIf rbtnNothing.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Show()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.4
            End If
        End If
    End Sub

    Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
        'Check which page user is on and go to the next page
        If currentPage = 1 Then
            If rbtnAFK.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Show()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.1
            ElseIf rbtnCopyFiles.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Show()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.2
            ElseIf rbtnDownloadGame.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Show()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Hide()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.3
            ElseIf rbtnNothing.Checked = True Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Show()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Continue"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Weiter"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 2.4
                gbStep3.Hide()
            End If
        ElseIf currentPage = 2.1 Then
            If String.IsNullOrEmpty(tbItemsPerMinute.Text) = False And String.IsNullOrEmpty(lblItemsNeeded.Text) = False Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Show()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Finish"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Beenden"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 3
                CalculateTime()
            Else
                If frmMain.language = "German" Then
                    MsgBox("Du musst die Items pro Minute und benötigten Items angeben!", MsgBoxStyle.Critical, "Fehler")
                ElseIf frmMain.language = "English" Then
                    MsgBox("You need to specify the items per minute and needed items!", MsgBoxStyle.Critical, "Error")
                End If
            End If
        ElseIf currentPage = 2.2 Then
            If String.IsNullOrEmpty(tbTotalSize.Text) = False And String.IsNullOrEmpty(tbDriveSpeed.Text) = False Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Show()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Finish"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Beenden"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 3
                CalculateTime()
            Else
                If frmMain.language = "German" Then
                    MsgBox("Du musst die Gesamtgröße der Dateien und Geschwindigkeit des Speichermediums angeben!", MsgBoxStyle.Critical, "Fehler")
                ElseIf frmMain.language = "English" Then
                    MsgBox("You need to specify the total size and drive speed!", MsgBoxStyle.Critical, "Error")
                End If
            End If
        ElseIf currentPage = 2.3 Then
            If String.IsNullOrEmpty(tbSizeOfDownload.Text) = False And String.IsNullOrEmpty(tbYourInternetSpeed.Text) = False Then
                gbStep1.Hide()
                gbStep2AFK.Hide()
                gbStep2Download.Hide()
                gbStep2Drive.Hide()
                gbStep2Nothing.Hide()
                gbStep3.Show()
                If frmMain.language = "English" Then
                    btnContinue.Text = "Finish"
                    btnBack.Text = "Back"
                ElseIf frmMain.language = "German" Then
                    btnContinue.Text = "Beenden"
                    btnBack.Text = "Zurück"
                End If
                currentPage = 3
                CalculateTime()
            Else
                If frmMain.language = "German" Then
                    MsgBox("Du musst die Downloadgröße und Internetgeschwindigkeit angeben!", MsgBoxStyle.Critical, "Fehler")
                ElseIf frmMain.language = "English" Then
                    MsgBox("You need to specify the download size and internet speed!", MsgBoxStyle.Critical, "Error")
                End If
            End If
        ElseIf currentPage = 2.4 Then
            gbStep1.Hide()
            gbStep2AFK.Hide()
            gbStep2Download.Hide()
            gbStep2Drive.Hide()
            gbStep2Nothing.Hide()
            gbStep3.Show()
            If frmMain.language = "English" Then
                btnContinue.Text = "Finish"
                btnBack.Text = "Back"
            ElseIf frmMain.language = "German" Then
                btnContinue.Text = "Beenden"
                btnBack.Text = "Zurück"
            End If
            currentPage = 3
            CalculateTime()
        ElseIf currentPage = 3 Then
            If cbUseTime.Checked Then
                frmMain.tbTime.Text = determinedTime.ToString
                If timeUnit = "Seconds" Then
                    frmMain.cbxIn.SelectedIndex = 0
                ElseIf timeUnit = "Minutes" Then
                    frmMain.cbxIn.SelectedIndex = 1
                ElseIf timeUnit = "Hours" Then
                    frmMain.cbxIn.SelectedIndex = 2
                End If
            End If
            Close()
        End If
    End Sub

    '-- Only allow certain Keys in textboxes --

    Private Sub tbSizeOfDownload_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbSizeOfDownload.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub tbYourInternetSpeed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbYourInternetSpeed.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub tbItemsPerMinute_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbItemsPerMinute.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub tbItemsNeeded_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbItemsNeeded.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub tbTotalSize_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbTotalSize.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub tbDriveSpeed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbDriveSpeed.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "," Or Asc(e.KeyChar) = 8)
    End Sub

    '-- Custom methods --

    Private Sub CalculateTime()
        If rbtnDownloadGame.Checked = True Then

            'Internet speed in KB/s
            If cbxYourInternetSpeed.SelectedIndex = 0 Then 'KB/s
                internetSpeed = Convert.ToDouble(tbYourInternetSpeed.Text)
            ElseIf cbxYourInternetSpeed.SelectedIndex = 1 Then 'MB/s
                internetSpeed = Convert.ToDouble(tbYourInternetSpeed.Text) * 1000
            ElseIf cbxYourInternetSpeed.SelectedIndex = 2 Then 'GB/s
                internetSpeed = Convert.ToDouble(tbYourInternetSpeed.Text) * 1000000
            ElseIf cbxYourInternetSpeed.SelectedIndex = 3 Then 'TB/s
                internetSpeed = Convert.ToDouble(tbYourInternetSpeed.Text) * 1000000000
            End If

            'Size of download in KB
            If cbxSizeOfDownload.SelectedIndex = 0 Then 'KB
                sizeOfDownload = Convert.ToDouble(tbSizeOfDownload.Text)
            ElseIf cbxSizeOfDownload.SelectedIndex = 1 Then 'MB
                sizeOfDownload = Convert.ToDouble(tbSizeOfDownload.Text) * 1000
            ElseIf cbxSizeOfDownload.SelectedIndex = 2 Then 'GB
                sizeOfDownload = Convert.ToDouble(tbSizeOfDownload.Text) * 1000000
            ElseIf cbxSizeOfDownload.SelectedIndex = 3 Then 'TB
                sizeOfDownload = Convert.ToDouble(tbSizeOfDownload.Text) * 1000000000
            ElseIf cbxSizeOfDownload.SelectedIndex = 4 Then 'PB
                sizeOfDownload = Convert.ToDouble(tbSizeOfDownload.Text) * 1000000000000
            End If

            determinedTime = sizeOfDownload / internetSpeed

        ElseIf rbtnAFK.Checked = True Then

            'Needed items
            itemsNeeded = Convert.ToDouble(tbItemsNeeded.Text)

            'Items per second
            itemsPerMinute = Convert.ToDouble(tbItemsPerMinute.Text) / 60

            determinedTime = itemsNeeded / itemsPerMinute
        ElseIf rbtnCopyFiles.Checked = True Then

            'Total size of files in KB
            If cbxTotalSize.SelectedIndex = 0 Then 'KB
                totalSize = Convert.ToDouble(tbTotalSize.Text)
            ElseIf cbxTotalSize.SelectedIndex = 1 Then 'MB
                totalSize = Convert.ToDouble(tbTotalSize.Text) * 1000
            ElseIf cbxTotalSize.SelectedIndex = 2 Then 'GB
                totalSize = Convert.ToDouble(tbTotalSize.Text) * 1000000
            ElseIf cbxTotalSize.SelectedIndex = 3 Then 'TB
                totalSize = Convert.ToDouble(tbTotalSize.Text) * 1000000000
            ElseIf cbxTotalSize.SelectedIndex = 4 Then 'PB
                totalSize = Convert.ToDouble(tbTotalSize.Text) * 1000000000000
            End If

            'Drive speed in KB/s
            If cbxDriveSpeed.SelectedIndex = 0 Then 'KB/s
                driveSpeed = Convert.ToDouble(tbDriveSpeed.Text)
            ElseIf cbxDriveSpeed.SelectedIndex = 1 Then 'MB/s
                driveSpeed = Convert.ToDouble(tbDriveSpeed.Text) * 1000
            ElseIf cbxDriveSpeed.SelectedIndex = 2 Then 'GB/s
                driveSpeed = Convert.ToDouble(tbDriveSpeed.Text) * 1000000
            ElseIf cbxDriveSpeed.SelectedIndex = 3 Then 'TB/s
                driveSpeed = Convert.ToDouble(tbDriveSpeed.Text) * 1000000000
            End If

            determinedTime = totalSize / driveSpeed
        ElseIf rbtnNothing.Checked = True Then
            determinedTime = 0
        End If

        'Add 2 Minutes to determined time in case there are any file copy speed drops for example
        If rbtnAFK.Checked OrElse rbtnCopyFiles.Checked OrElse rbtnDownloadGame.Checked Then
            determinedTime = determinedTime + 120
        End If

        'Find out the right time unit for the determined time
        Select Case determinedTime
            Case 0
                determinedTime = Math.Round(determinedTime)
                If frmMain.language = "German" Then
                    lblDeterminedTime.Text = "Es konnte keine Zeit bestimmt werden."
                ElseIf frmMain.language = "English" Then
                    lblDeterminedTime.Text = "No time could be determined."
                End If
                cbUseTime.Hide()
                cbUseTime.Checked = False
                timeUnit = "Seconds"
            Case 1 To 59
                determinedTime = Math.Round(determinedTime)
                If frmMain.language = "German" Then
                    lblDeterminedTime.Text = String.Format("Die folgende Zeit wurde bestimmt: {0} Sekunde(n)", determinedTime)

                ElseIf frmMain.language = "English" Then
                    lblDeterminedTime.Text = String.Format("The following time was determined: {0} second(s)", determinedTime)
                End If
                cbUseTime.Show()
                cbUseTime.Checked = True
                timeUnit = "Seconds"
            Case 60 To 3599
                determinedTime = Math.Round(determinedTime / 60)
                If frmMain.language = "German" Then
                    lblDeterminedTime.Text = String.Format("Die folgende Zeit wurde bestimmt: {0} Minute(n)", determinedTime)
                ElseIf frmMain.language = "English" Then
                    lblDeterminedTime.Text = String.Format("The following time was determined: {0} minute(s)", determinedTime)
                End If
                cbUseTime.Show()
                cbUseTime.Checked = True
                timeUnit = "Minutes"
            Case Else
                determinedTime = Math.Round(determinedTime / 3600)
                If frmMain.language = "German" Then
                    lblDeterminedTime.Text = String.Format("Die folgende Zeit wurde bestimmt: {0} Stunde(n)", determinedTime)
                ElseIf frmMain.language = "English" Then
                    lblDeterminedTime.Text = String.Format("The following time was determined: {0} hour(s)", determinedTime)
                End If
                cbUseTime.Show()
                cbUseTime.Checked = True
                timeUnit = "Hours"
        End Select

        'Log the selected time
        If rbtnAFK.Checked = True Then
            frmMain.WriteToLog(String.Format("Determined the time {0} {1} using the inputs: Items per minute: {2} - Needed items: {3} - Extra time: 2 minutes", determinedTime, timeUnit, tbItemsPerMinute.Text, tbItemsNeeded.Text), "Info")
        ElseIf rbtnCopyFiles.Checked = True Then
            frmMain.WriteToLog(String.Format("Determined the time {0} {1} using the inputs: Total size: {2} {3} - Drive speed: {4} {5} - Extra time: 2 minutes", determinedTime, timeUnit, tbTotalSize.Text, cbxTotalSize.Text, tbDriveSpeed.Text, cbxDriveSpeed.Text), "Info")
        ElseIf rbtnDownloadGame.Checked = True Then
            frmMain.WriteToLog(String.Format("Determined the time {0} {1} using the inputs: Size of download: {2} {3} - Internet speed: {4} {5} - Extra time: 2 minutes", determinedTime, timeUnit, tbSizeOfDownload.Text, cbxSizeOfDownload.Text, tbYourInternetSpeed.Text, cbxYourInternetSpeed.Text), "Info")
        ElseIf rbtnNothing.Checked = True Then
            frmMain.WriteToLog("Could not determine a time using the Time Helper Wizard", "Info")
        End If
    End Sub

    Private Sub LoadTranslations()
        'Load strings for the German translation
        If frmMain.language = "German" Then
            Text = "Zeit-Helfer"
            lblHeader.Text = "Welche Zeit sollte ich nutzen?"
            gbStep1.Text = "Schritt 1"
            lblDescStep1.Text = "Willkommen beim Zeit-Helfer-Wizard. Dieser Wizard ist dazu bestimmt, " + vbNewLine + "dir zu helfen, den richtigen Zeitpunkt herauszufinden, an dem du" + vbNewLine + "deinen PC herunterfahren möchtest." + vbNewLine + vbNewLine + "Beginne, indem du auswählst, was deine aktuelle Situation am meisten trifft."
            rbtnDownloadGame.Text = "Ich lade ein Spiel/ein Update herunter"
            rbtnAFK.Text = "Ich bin in einem Spiel AFK"
            rbtnCopyFiles.Text = "Ich kopiere Dateien"
            rbtnNothing.Text = "Nichts auf dieser Liste passt zu meiner aktuellen Situation"
            gbStep2Download.Text = "Schritt 2"
            lblDescStep2Download.Text = "Du hast ausgewählt, dass du ein Spiel oder ein Update herunterlädst." + vbNewLine + "Der richtige Zeitpunkt, deinen Computer herunterzufahren, wäre, wenn der" + vbNewLine + "Download fertig ist. Um die richtige Zeit zu bestimmen, musst du deine" + vbNewLine + "Downloadgeschwindigkeit und die Größe des Downloads angeben."
            lblSizeOfDownload.Text = "Größe des Downloads:"
            lblYourInternetSpeed.Text = "Internetgeschwindigkeit:"
            lblDontKnowSpeed.Text = "Du weißt deine Internetgeschwindigkeit nicht? Suche online und du" + vbNewLine + "findest eine Reihe von Speedtests. Stelle sicher, dass du Bytes pro Sekunde und" + vbNewLine + "nicht Bits pro Sekunde benutzt."
            gbStep2AFK.Text = "Schritt 2"
            lblDescStep2AFK.Text = "Du hast ausgewählt, dass du in einem Game AFK bist. In diesem Fall hängt es" + vbNewLine + "davon ab, warum du AFK bist. Wenn du beispielsweise Items farmst, solltest du" + vbNewLine + "herausfinden, wie viele Items du pro Minute ungefähr bekommst, um die richtige" + vbNewLine + "Zeit herauszufinden, zu der du deinen PC herunterfahren solltest. Wenn du für" + vbNewLine + "etwas AFK bist, das keine lineare Droprate hat (bspw. verschiedene Chancen)," + vbNewLine + "kannst du eigentlich nur raten, wie lange es dauern könnte."
            lblItemsNeeded.Text = "Benötigte Items:"
            lblItemsPerMinute.Text = "Items pro Minute:"
            gbStep2Drive.Text = "Schritt 2"
            lblDescStep2Drive.Text = "Du hast ausgewählt, dass du Dateien oder etwas ähnliches kopierst. Um die" + vbNewLine + "richtige Zeit, zu der du deinen PC herunterfahren solltest, herauszufinden," + vbNewLine + "musst du die Gesamtgröße der Dateien und die Geschwindigkeit deines" + vbNewLine + "Speichermediums angeben."
            lblTotalSize.Text = "Gesamtgröße:"
            lblDriveSpeed.Text = "Geschwindigkeit:"
            lblHowToFindDriveSpeed.Text = "Du kannst du Gesamtgröße und Transfergeschwindigkeit im 'Datei kopieren'" + vbNewLine + "Dialog finden. Manchmal zeigt es auch bereits die verbleibende Zeit an," + vbNewLine + "dann kannst du diese einfach nutzen."
            gbStep2Nothing.Text = "Schritt 2"
            lblDescStep2Nothing.Text = "Wenn nichts auf der Liste zu deiner aktuellen Situation passt, so kann die Software" + vbNewLine + "Leider nicht die richtige Zeit bestimmen. In diesem Fall musst du wohl oder" + vbNewLine + "übel raten oder nach deinem Gefühl gehen."
            gbStep3.Text = "Schritt 3"
            lblDescStep3.Text = "Der Zeit-Helfer-Wizard wurde abgeschlossen!" + vbNewLine + vbNewLine + "Bitte beachte, dass die Zeit nur eine ungefähre Berechnung ist und falsch sein" + vbNewLine + "könnte. Wenn du beispielsweise wichtige Dateien kopierst, solltest du aufpassen," + vbNewLine + "wenn du ein geplantes Herunterfahren nutzt. In jedem Fall ist der Entwickler nicht" + vbNewLine + "verantwortlich für jeglichen Schaden, der entstehen könnte. Außerdem wird" + vbNewLine + "keine Information, die du hier eingegeben hast, zu einem Server gesendet."
            cbUseTime.Text = "Benutze die berechnete Zeit im Hauptfenster"
            btnBack.Text = "Schließen"
            btnContinue.Text = "Weiter"
        End If
    End Sub

    Private Sub LoadDesign()
        'Load design for darkmode
        If frmMain.design = "Dark" Then
            BackColor = Color.FromArgb(41, 41, 41)
            lblHeader.ForeColor = Color.White
            gbStep1.ForeColor = Color.White
            lblDescStep1.ForeColor = Color.White
            rbtnDownloadGame.ForeColor = Color.White
            rbtnAFK.ForeColor = Color.White
            rbtnCopyFiles.ForeColor = Color.White
            rbtnNothing.ForeColor = Color.White
            gbStep2Download.ForeColor = Color.White
            lblDescStep2Download.ForeColor = Color.White
            lblSizeOfDownload.ForeColor = Color.White
            lblYourInternetSpeed.ForeColor = Color.White
            tbSizeOfDownload.ForeColor = Color.White
            tbYourInternetSpeed.ForeColor = Color.White
            tbYourInternetSpeed.BackColor = Color.Gray
            tbSizeOfDownload.BackColor = Color.Gray
            cbxYourInternetSpeed.BackColor = Color.Gray
            cbxYourInternetSpeed.ForeColor = Color.White
            cbxSizeOfDownload.ForeColor = Color.White
            cbxSizeOfDownload.BackColor = Color.Gray
            gbStep2AFK.ForeColor = Color.White
            lblDescStep2AFK.ForeColor = Color.White
            lblItemsNeeded.ForeColor = Color.White
            lblItemsPerMinute.ForeColor = Color.White
            tbItemsNeeded.ForeColor = Color.White
            tbItemsNeeded.BackColor = Color.Gray
            tbItemsPerMinute.ForeColor = Color.White
            tbItemsPerMinute.BackColor = Color.Gray
            gbStep2Drive.ForeColor = Color.White
            lblDescStep2Drive.ForeColor = Color.White
            lblTotalSize.ForeColor = Color.White
            lblDriveSpeed.ForeColor = Color.White
            tbTotalSize.ForeColor = Color.White
            tbTotalSize.BackColor = Color.Gray
            tbDriveSpeed.ForeColor = Color.White
            tbDriveSpeed.BackColor = Color.Gray
            cbxDriveSpeed.ForeColor = Color.White
            cbxDriveSpeed.BackColor = Color.Gray
            cbxTotalSize.ForeColor = Color.White
            cbxTotalSize.BackColor = Color.Gray
            lblDontKnowSpeed.ForeColor = Color.White
            gbStep2Nothing.ForeColor = Color.White
            lblDescStep2Nothing.ForeColor = Color.White
            gbStep3.ForeColor = Color.White
            lblDescStep3.ForeColor = Color.White
            lblDeterminedTime.ForeColor = Color.White
            cbUseTime.ForeColor = Color.White
        End If
    End Sub

    '-- Button animations --

    Private Sub btnBack_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBack.MouseDown
        btnBack.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnBack_MouseEnter(sender As Object, e As EventArgs) Handles btnBack.MouseEnter
        btnBack.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnBack_MouseLeave(sender As Object, e As EventArgs) Handles btnBack.MouseLeave
        btnBack.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnBack_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBack.MouseUp
        btnBack.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnContinue_MouseDown(sender As Object, e As MouseEventArgs) Handles btnContinue.MouseDown
        btnContinue.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnContinue_MouseEnter(sender As Object, e As EventArgs) Handles btnContinue.MouseEnter
        btnContinue.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnContinue_MouseLeave(sender As Object, e As EventArgs) Handles btnContinue.MouseLeave
        btnContinue.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnContinue_MouseUp(sender As Object, e As MouseEventArgs) Handles btnContinue.MouseUp
        btnContinue.BackgroundImage = My.Resources.button
    End Sub
End Class