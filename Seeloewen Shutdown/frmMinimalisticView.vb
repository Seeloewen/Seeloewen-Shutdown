﻿Public Class frmMinimalisticView

    '-- Event handlers --

    Private Sub frmMinimalisticView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load action
        If frmMain._RunningAction.Text = "Shutdown" Or frmMain._RunningAction.Text = "Herunterfahren" Then
            If frmMain.language = "German" Then
                lblAction.Text = "Ein Herunterfahren wurde geplant!"
            ElseIf frmMain.language = "English" Then
                lblAction.Text = "A shutdown has been scheduled!"
            End If
        ElseIf frmMain._RunningAction.Text = "Restart" Or frmMain._RunningAction.Text = "Neustarten" Then
            If frmMain.language = "German" Then
                lblAction.Text = "Ein Neustart wurde geplant!"
            ElseIf frmMain.language = "English" Then
                lblAction.Text = "A restart has been scheduled!"
            End If
        End If

        'Load time
        lblTime.Text = frmMain._RunningTime.Text

        'Load UI settings
        LoadDesign()
        LoadLanguage()

        'Hide frmMain in case it wasn't hidden when enabling minimalistic view
        frmMain.Hide()
    End Sub

    Private Sub btnSwitchToNormalView_Click(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.Click
        'Close window
        Close()
    End Sub

    '-- Custom methods --

    Private Sub LoadDesign()
        'Set to darkmode if design dark is selected
        If frmMain.design = "Dark" Then
            lblAction.ForeColor = Color.White
            lblScheduledTime.ForeColor = Color.White
            lblTime.ForeColor = Color.White
            lblTimeRemaining.ForeColor = Color.White
            lblTimerShutdown.ForeColor = Color.White
            BackColor = Color.FromArgb(41, 41, 41)
        End If
    End Sub

    Private Sub LoadLanguage()
        'Translate string if language is set to German
        If frmMain.language = "German" Then
            lblScheduledTime.Text = "Geplante Zeit:"
            lblTimeRemaining.Text = "Verbleibende Zeit:"
            Text = "Seeloewen Shutdown - Minimalistische Ansicht"
            btnSwitchToNormalView.Text = "Zur Normalen Ansicht wechseln"
        End If
    End Sub

    '-- Button designs --

    Private Sub btnSwitchToNormalView_MouseDown(sender As Object, e As MouseEventArgs) Handles btnSwitchToNormalView.MouseDown
        btnSwitchToNormalView.BackgroundImage = My.Resources.button_click
    End Sub

    Private Sub btnSwitchToNormalView_MouseEnter(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.MouseEnter
        btnSwitchToNormalView.BackgroundImage = My.Resources.button_hover
    End Sub

    Private Sub btnSwitchToNormalView_MouseLeave(sender As Object, e As EventArgs) Handles btnSwitchToNormalView.MouseLeave
        btnSwitchToNormalView.BackgroundImage = My.Resources.button
    End Sub

    Private Sub btnSwitchToNormalView_MouseUp(sender As Object, e As MouseEventArgs) Handles btnSwitchToNormalView.MouseUp
        btnSwitchToNormalView.BackgroundImage = My.Resources.button
    End Sub

    Private Sub frmMinimalisticView_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMain.Show()
    End Sub
End Class