Public Class frmFinish
    Private TargetDT As DateTime


    Private Sub btnCancelAction_Click(sender As Object, e As EventArgs) Handles btnCancelAction.Click
        Hide()
        frmMain.Show()
        Process.Start("shutdown", "-a")
    End Sub

    Private Sub frmFinish_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Settings.Language = "English" Then
            Text = "Notification"
            lblHeader.Text = "Your PC will shutdown soon"
            lblTimeRemaining.Text = "Time remaining:"
            lblZeitpunkt.Text = "Exact time:"

            gbMessage.Text = "Message"

            btnCancelAction.Text = "Cancel action"
        End If

        'Countdown definieren
        Dim CountDownFrom As TimeSpan
        If frmMain.rbtnIn.Checked = True Then
            If frmMain.cbxIn.SelectedItem = "Sekunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text))
            ElseIf frmMain.cbxIn.SelectedItem = "Minute(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 60)
            ElseIf frmMain.cbxIn.SelectedItem = "Stunde(n)" Then
                CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.tbTime.Text) * 3600)
            End If
        ElseIf frmMain.rbtnShutdown.Checked = True Then
            CountDownFrom = TimeSpan.FromSeconds(Convert.ToInt32(frmMain.Shutdowntime.Text))
        End If

        'Genauen Zeitpunkt sehen
        zeitpunkt.Text = frmMain.dtpDate.Text

        'Nachricht laden
        If frmMain.cbMessage.Checked Then
            rtbInfo.Text = frmMain.tbMessage.Text
        Else
            rtbInfo.Text = "Wenn sie die Aktion versehentlich gestartet haben, können sie diese abbrechen!"
        End If

        'Timer initialisieren
        tmrShutdown.Interval = 100
        TargetDT = DateTime.Now.Add(CountDownFrom)

        'Timer starten
        tmrShutdown.Start()
    End Sub

    Private Sub tmrShutdown_Tick(sender As Object, e As EventArgs) Handles tmrShutdown.Tick
        Dim ts As TimeSpan = TargetDT.Subtract(DateTime.Now)
        If ts.TotalMilliseconds > 0 Then
            timeRemaining.Text = ts.ToString("hh\:mm\:ss")
        End If
    End Sub

    Private Sub rtbInfo_TextChanged(sender As Object, e As EventArgs) Handles rtbInfo.TextChanged

    End Sub
End Class