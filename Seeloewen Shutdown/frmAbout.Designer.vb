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
        Me.btnChangelog = New System.Windows.Forms.Button()
        Me.llblSeeloewenShutdownGithub = New System.Windows.Forms.LinkLabel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.gbInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(26, 9)
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
        Me.lblInfo.Location = New System.Drawing.Point(71, 42)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(230, 72)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Version 1.6.1 - 23.12.2021" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seeloewen (Louis)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Discord: Seeloewen#5699" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.rtbInfo)
        Me.gbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbInfo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gbInfo.Location = New System.Drawing.Point(22, 131)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(322, 208)
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
        Me.rtbInfo.Location = New System.Drawing.Point(6, 27)
        Me.rtbInfo.Name = "rtbInfo"
        Me.rtbInfo.ReadOnly = True
        Me.rtbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.rtbInfo.Size = New System.Drawing.Size(310, 175)
        Me.rtbInfo.TabIndex = 5
        Me.rtbInfo.Text = resources.GetString("rtbInfo.Text")
        '
        'btnChangelog
        '
        Me.btnChangelog.BackColor = System.Drawing.Color.Transparent
        Me.btnChangelog.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnChangelog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnChangelog.FlatAppearance.BorderSize = 0
        Me.btnChangelog.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnChangelog.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnChangelog.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnChangelog.ForeColor = System.Drawing.Color.White
        Me.btnChangelog.Location = New System.Drawing.Point(22, 383)
        Me.btnChangelog.Name = "btnChangelog"
        Me.btnChangelog.Size = New System.Drawing.Size(156, 29)
        Me.btnChangelog.TabIndex = 6
        Me.btnChangelog.Text = "Changelog"
        Me.btnChangelog.UseVisualStyleBackColor = False
        '
        'llblSeeloewenShutdownGithub
        '
        Me.llblSeeloewenShutdownGithub.AutoSize = True
        Me.llblSeeloewenShutdownGithub.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblSeeloewenShutdownGithub.Location = New System.Drawing.Point(71, 351)
        Me.llblSeeloewenShutdownGithub.Name = "llblSeeloewenShutdownGithub"
        Me.llblSeeloewenShutdownGithub.Size = New System.Drawing.Size(216, 20)
        Me.llblSeeloewenShutdownGithub.TabIndex = 8
        Me.llblSeeloewenShutdownGithub.TabStop = True
        Me.llblSeeloewenShutdownGithub.Text = "Seeloewen Shutdown Github"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.Transparent
        Me.btnClose.Location = New System.Drawing.Point(184, 383)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(160, 29)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'frmAbout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(364, 421)
        Me.Controls.Add(Me.llblSeeloewenShutdownGithub)
        Me.Controls.Add(Me.btnChangelog)
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
    Friend WithEvents btnChangelog As Button
    Friend WithEvents llblSeeloewenShutdownGithub As LinkLabel
End Class
