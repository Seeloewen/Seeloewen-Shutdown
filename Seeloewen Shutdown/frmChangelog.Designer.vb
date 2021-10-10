<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangelog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChangelog))
        Me.lblChangelogHeader = New System.Windows.Forms.Label()
        Me.lblChangelogDescription = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rtbChangelog = New System.Windows.Forms.RichTextBox()
        Me.gbChangelog = New System.Windows.Forms.GroupBox()
        Me.rtbchangelogEnglish = New System.Windows.Forms.RichTextBox()
        Me.gbChangelog.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblChangelogHeader
        '
        Me.lblChangelogHeader.AutoSize = True
        Me.lblChangelogHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangelogHeader.Location = New System.Drawing.Point(13, 9)
        Me.lblChangelogHeader.Name = "lblChangelogHeader"
        Me.lblChangelogHeader.Size = New System.Drawing.Size(125, 25)
        Me.lblChangelogHeader.TabIndex = 0
        Me.lblChangelogHeader.Text = "Changelog"
        '
        'lblChangelogDescription
        '
        Me.lblChangelogDescription.AutoSize = True
        Me.lblChangelogDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangelogDescription.Location = New System.Drawing.Point(15, 34)
        Me.lblChangelogDescription.Name = "lblChangelogDescription"
        Me.lblChangelogDescription.Size = New System.Drawing.Size(484, 16)
        Me.lblChangelogDescription.TabIndex = 2
        Me.lblChangelogDescription.Text = "Im Changelog können die Neuigkeiten von Versionen einfach abgerufen werden."
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(396, 382)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(103, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rtbChangelog
        '
        Me.rtbChangelog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbChangelog.Location = New System.Drawing.Point(6, 11)
        Me.rtbChangelog.Name = "rtbChangelog"
        Me.rtbChangelog.Size = New System.Drawing.Size(473, 258)
        Me.rtbChangelog.TabIndex = 5
        Me.rtbChangelog.Text = resources.GetString("rtbChangelog.Text")
        '
        'gbChangelog
        '
        Me.gbChangelog.Controls.Add(Me.rtbChangelog)
        Me.gbChangelog.Location = New System.Drawing.Point(18, 53)
        Me.gbChangelog.Name = "gbChangelog"
        Me.gbChangelog.Size = New System.Drawing.Size(485, 276)
        Me.gbChangelog.TabIndex = 6
        Me.gbChangelog.TabStop = False
        '
        'rtbchangelogEnglish
        '
        Me.rtbchangelogEnglish.Location = New System.Drawing.Point(396, 411)
        Me.rtbchangelogEnglish.Name = "rtbchangelogEnglish"
        Me.rtbchangelogEnglish.Size = New System.Drawing.Size(107, 33)
        Me.rtbchangelogEnglish.TabIndex = 7
        Me.rtbchangelogEnglish.Text = resources.GetString("rtbchangelogEnglish.Text")
        '
        'frmChangelog
        '
        Me.AcceptButton = Me.btnClose
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(518, 343)
        Me.Controls.Add(Me.rtbchangelogEnglish)
        Me.Controls.Add(Me.gbChangelog)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChangelogDescription)
        Me.Controls.Add(Me.lblChangelogHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangelog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Changelog"
        Me.gbChangelog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChangelogHeader As Label
    Friend WithEvents lblChangelogDescription As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents rtbChangelog As RichTextBox
    Friend WithEvents gbChangelog As GroupBox
    Friend WithEvents rtbchangelogEnglish As RichTextBox
End Class
