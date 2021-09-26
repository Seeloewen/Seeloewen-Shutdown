<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinish
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinish))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnCancelAction = New System.Windows.Forms.Button()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.lblTimeRemaining = New System.Windows.Forms.Label()
        Me.timeRemaining = New System.Windows.Forms.Label()
        Me.tmrShutdown = New System.Windows.Forms.Timer(Me.components)
        Me.lblPointInTime = New System.Windows.Forms.Label()
        Me.pointintime = New System.Windows.Forms.Label()
        Me.gbMessage = New System.Windows.Forms.GroupBox()
        Me.gbMessage.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(21, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(398, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Ihr PC wird demnächst heruntergefahren"
        '
        'btnCancelAction
        '
        Me.btnCancelAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelAction.Location = New System.Drawing.Point(26, 182)
        Me.btnCancelAction.Name = "btnCancelAction"
        Me.btnCancelAction.Size = New System.Drawing.Size(393, 28)
        Me.btnCancelAction.TabIndex = 2
        Me.btnCancelAction.Text = "Aktion abbrechen"
        Me.btnCancelAction.UseVisualStyleBackColor = True
        '
        'rtbInfo
        '
        Me.rtbInfo.BackColor = System.Drawing.Color.White
        Me.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtbInfo.DetectUrls = False
        Me.rtbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInfo.ForeColor = System.Drawing.Color.Black
        Me.rtbInfo.Location = New System.Drawing.Point(12, 25)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.ReadOnly = True
        Me.rtbInfo.Size = New System.Drawing.Size(375, 42)
        Me.rtbInfo.TabIndex = 3
        Me.rtbInfo.Text = "Wenn sie die Aktion versehentlich gestartet haben, können sie diese abbrechen!"
        '
        'lblTimeRemaining
        '
        Me.lblTimeRemaining.AutoSize = True
        Me.lblTimeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTimeRemaining.Location = New System.Drawing.Point(22, 43)
        Me.lblTimeRemaining.Name = "lblTimeRemaining"
        Me.lblTimeRemaining.Size = New System.Drawing.Size(138, 20)
        Me.lblTimeRemaining.TabIndex = 4
        Me.lblTimeRemaining.Text = "Verbleibende Zeit:"
        '
        'timeRemaining
        '
        Me.timeRemaining.AutoSize = True
        Me.timeRemaining.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timeRemaining.Location = New System.Drawing.Point(166, 43)
        Me.timeRemaining.Name = "timeRemaining"
        Me.timeRemaining.Size = New System.Drawing.Size(143, 20)
        Me.timeRemaining.TabIndex = 5
        Me.timeRemaining.Text = "%timeRemaining%"
        '
        'tmrShutdown
        '
        '
        'lblPointInTime
        '
        Me.lblPointInTime.AutoSize = True
        Me.lblPointInTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPointInTime.Location = New System.Drawing.Point(22, 63)
        Me.lblPointInTime.Name = "lblPointInTime"
        Me.lblPointInTime.Size = New System.Drawing.Size(147, 20)
        Me.lblPointInTime.TabIndex = 6
        Me.lblPointInTime.Text = "Genauer Zeitpunkt:"
        '
        'pointintime
        '
        Me.pointintime.AutoSize = True
        Me.pointintime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pointintime.Location = New System.Drawing.Point(166, 63)
        Me.pointintime.Name = "pointintime"
        Me.pointintime.Size = New System.Drawing.Size(102, 20)
        Me.pointintime.TabIndex = 7
        Me.pointintime.Text = "%zeitpunkt%"
        '
        'gbMessage
        '
        Me.gbMessage.Controls.Add(Me.rtbInfo)
        Me.gbMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMessage.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbMessage.Location = New System.Drawing.Point(26, 95)
        Me.gbMessage.Name = "gbMessage"
        Me.gbMessage.Size = New System.Drawing.Size(393, 79)
        Me.gbMessage.TabIndex = 8
        Me.gbMessage.TabStop = False
        Me.gbMessage.Text = "Nachricht"
        '
        'frmFinish
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(443, 222)
        Me.Controls.Add(Me.gbMessage)
        Me.Controls.Add(Me.pointintime)
        Me.Controls.Add(Me.lblPointInTime)
        Me.Controls.Add(Me.timeRemaining)
        Me.Controls.Add(Me.lblTimeRemaining)
        Me.Controls.Add(Me.btnCancelAction)
        Me.Controls.Add(Me.lblHeader)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFinish"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mitteilung"
        Me.gbMessage.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnCancelAction As Button
    Friend WithEvents rtbInfo As RichTextBox
    Friend WithEvents lblTimeRemaining As Label
    Friend WithEvents timeRemaining As Label
    Friend WithEvents tmrShutdown As Timer
    Friend WithEvents lblPointInTime As Label
    Friend WithEvents pointintime As Label
    Friend WithEvents gbMessage As GroupBox
End Class
