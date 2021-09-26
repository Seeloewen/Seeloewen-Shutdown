<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAbout))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.rtbInfo = New System.Windows.Forms.RichTextBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnChangelog = New System.Windows.Forms.Button()
        Me.lblDiscord = New System.Windows.Forms.Label()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(21, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(312, 33)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Seeloewen Shutdown"
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblInfo.Location = New System.Drawing.Point(38, 42)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(279, 48)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Version 1.5.0-Beta2 - 27.09.2021" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seeloewen (Louis)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.rtbInfo)
        Me.gbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbInfo.Location = New System.Drawing.Point(17, 107)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(322, 195)
        Me.gbInfo.TabIndex = 2
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "GNU General Public License"
        '
        'rtbInfo
        '
        Me.rtbInfo.BackColor = System.Drawing.Color.White
        Me.rtbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.rtbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbInfo.Location = New System.Drawing.Point(6, 25)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.ReadOnly = True
        Me.rtbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbInfo.Size = New System.Drawing.Size(310, 162)
        Me.rtbInfo.TabIndex = 5
        Me.rtbInfo.Text = resources.GetString("rtbInfo.Text")
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(237, 337)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(102, 29)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Location = New System.Drawing.Point(17, 337)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(106, 29)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Hilfe"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnChangelog
        '
        Me.btnChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangelog.Location = New System.Drawing.Point(129, 337)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.Size = New System.Drawing.Size(102, 29)
        Me.btnChangelog.TabIndex = 6
        Me.btnChangelog.Text = "Changelog"
        Me.btnChangelog.UseVisualStyleBackColor = True
        '
        'lblDiscord
        '
        Me.lblDiscord.AutoSize = True
        Me.lblDiscord.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscord.Location = New System.Drawing.Point(87, 305)
        Me.lblDiscord.Name = "lblDiscord"
        Me.lblDiscord.Size = New System.Drawing.Size(195, 20)
        Me.lblDiscord.TabIndex = 7
        Me.lblDiscord.Text = "Discord: Seeloewen#5699"
        '
        'frmAbout
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(356, 378)
        Me.Controls.Add(Me.lblDiscord)
        Me.Controls.Add(Me.btnChangelog)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAbout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Über..."
        Me.gbInfo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents btnClose As Button
    Friend WithEvents rtbInfo As RichTextBox
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnChangelog As Button
    Friend WithEvents lblDiscord As Label
End Class
