<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMinimalisticView
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMinimalisticView))
        Me.lblAction = New System.Windows.Forms.Label()
        Me.lblTimerShutdown = New System.Windows.Forms.Label()
        Me.tmrShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.btnSwitchToNormalView = New System.Windows.Forms.Button()
        Me.lblScheduledTime = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAction
        '
        Me.lblAction.AutoSize = True
        Me.lblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAction.Location = New System.Drawing.Point(13, 13)
        Me.lblAction.Name = "lblAction"
        Me.lblAction.Size = New System.Drawing.Size(291, 24)
        Me.lblAction.TabIndex = 0
        Me.lblAction.Text = "A %action% has been scheduled!"
        '
        'lblTimerShutdown
        '
        Me.lblTimerShutdown.AutoSize = True
        Me.lblTimerShutdown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimerShutdown.Location = New System.Drawing.Point(149, 78)
        Me.lblTimerShutdown.Name = "lblTimerShutdown"
        Me.lblTimerShutdown.Size = New System.Drawing.Size(76, 20)
        Me.lblTimerShutdown.TabIndex = 1
        Me.lblTimerShutdown.Text = "%Timer%"
        '
        'tmrShutdown
        '
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(13, 78)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(120, 20)
        Me.lblTimeRemaining.TabIndex = 2
        Me.lblTimeRemaining.Text = "Time remaining:"
        '
        'btnSwitchToNormalView
        '
        Me.btnSwitchToNormalView.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSwitchToNormalView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSwitchToNormalView.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btnSwitchToNormalView.FlatAppearance.BorderSize = 0
        Me.btnSwitchToNormalView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSwitchToNormalView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSwitchToNormalView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSwitchToNormalView.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSwitchToNormalView.ForeColor = System.Drawing.Color.White
        Me.btnSwitchToNormalView.Location = New System.Drawing.Point(93, 116)
        Me.btnSwitchToNormalView.Name = "btnSwitchToNormalView"
        Me.btnSwitchToNormalView.Size = New System.Drawing.Size(241, 28)
        Me.btnSwitchToNormalView.TabIndex = 3
        Me.btnSwitchToNormalView.Text = "Switch to Normal View"
        Me.btnSwitchToNormalView.UseVisualStyleBackColor = True
        '
        'lblScheduledTime
        '
        Me.lblScheduledTime.AutoSize = True
        Me.lblScheduledTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScheduledTime.Location = New System.Drawing.Point(13, 50)
        Me.lblScheduledTime.Name = "lblScheduledTime"
        Me.lblScheduledTime.Size = New System.Drawing.Size(123, 20)
        Me.lblScheduledTime.TabIndex = 4
        Me.lblScheduledTime.Text = "Scheduled time:"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(149, 50)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(143, 20)
        Me.lblTime.TabIndex = 5
        Me.lblTime.Text = "%ShutdownTime%"
        '
        'frmMinimalisticView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(425, 156)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblScheduledTime)
        Me.Controls.Add(Me.btnSwitchToNormalView)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.lblTimerShutdown)
        Me.Controls.Add(Me.lblAction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmMinimalisticView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown - Minimalistic View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAction As Label
    Friend WithEvents lblTimerShutdown As Label
    Friend WithEvents tmrShutdown As Timer
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents btnSwitchToNormalView As Button
    Friend WithEvents lblScheduledTime As Label
    Friend WithEvents lblTime As Label
End Class
