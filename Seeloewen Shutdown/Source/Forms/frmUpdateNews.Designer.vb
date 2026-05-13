<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdateNews
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdateNews))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.pbImprovements = New System.Windows.Forms.PictureBox()
        Me.lblNewsHeader = New System.Windows.Forms.Label()
        Me.lblNews = New System.Windows.Forms.Label()
        Me.lblChangelog = New System.Windows.Forms.Label()
        Me.llblChangelog = New System.Windows.Forms.LinkLabel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblImprovements = New System.Windows.Forms.Label()
        Me.lblImprovementsHeader = New System.Windows.Forms.Label()
        Me.lblStar = New System.Windows.Forms.Label()
        CType(Me.pbImprovements, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(346, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Version 1.10.0 - What's new?"
        '
        'pbImprovements
        '
        Me.pbImprovements.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.Update
        Me.pbImprovements.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbImprovements.Location = New System.Drawing.Point(18, 172)
        Me.pbImprovements.Name = "pbImprovements"
        Me.pbImprovements.Size = New System.Drawing.Size(53, 54)
        Me.pbImprovements.TabIndex = 1
        Me.pbImprovements.TabStop = False
        '
        'lblNewsHeader
        '
        Me.lblNewsHeader.AutoSize = True
        Me.lblNewsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNewsHeader.Location = New System.Drawing.Point(80, 56)
        Me.lblNewsHeader.Name = "lblNewsHeader"
        Me.lblNewsHeader.Size = New System.Drawing.Size(194, 25)
        Me.lblNewsHeader.TabIndex = 2
        Me.lblNewsHeader.Text = "Many new features"
        '
        'lblNews
        '
        Me.lblNews.AutoSize = True
        Me.lblNews.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNews.Location = New System.Drawing.Point(81, 81)
        Me.lblNews.Name = "lblNews"
        Me.lblNews.Size = New System.Drawing.Size(494, 60)
        Me.lblNews.TabIndex = 3
        Me.lblNews.Text = "This version adds the option to edit your timer after starting an action." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Additi" &
    "onally, you can delay actions if processes are running and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "rename profiles."
        '
        'lblChangelog
        '
        Me.lblChangelog.AutoSize = True
        Me.lblChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangelog.Location = New System.Drawing.Point(15, 261)
        Me.lblChangelog.Name = "lblChangelog"
        Me.lblChangelog.Size = New System.Drawing.Size(218, 16)
        Me.lblChangelog.TabIndex = 7
        Me.lblChangelog.Text = "An exact changelog can be found in" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'llblChangelog
        '
        Me.llblChangelog.AutoSize = True
        Me.llblChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llblChangelog.LinkColor = System.Drawing.Color.Cyan
        Me.llblChangelog.Location = New System.Drawing.Point(240, 261)
        Me.llblChangelog.Name = "llblChangelog"
        Me.llblChangelog.Size = New System.Drawing.Size(73, 16)
        Me.llblChangelog.TabIndex = 8
        Me.llblChangelog.TabStop = True
        Me.llblChangelog.Text = "Changelog"
        '
        'btnOK
        '
        Me.btnOK.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOK.FlatAppearance.BorderSize = 0
        Me.btnOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.ForeColor = System.Drawing.Color.White
        Me.btnOK.Location = New System.Drawing.Point(476, 253)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(117, 28)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "Got it!"
        Me.btnOK.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblImprovements
        '
        Me.lblImprovements.AutoSize = True
        Me.lblImprovements.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprovements.Location = New System.Drawing.Point(81, 191)
        Me.lblImprovements.Name = "lblImprovements"
        Me.lblImprovements.Size = New System.Drawing.Size(486, 40)
        Me.lblImprovements.TabIndex = 12
        Me.lblImprovements.Text = "A bunch of annoying bugs have been fixed, especially related to the " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Action Hist" &
    "ory window."
        '
        'lblImprovementsHeader
        '
        Me.lblImprovementsHeader.AutoSize = True
        Me.lblImprovementsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprovementsHeader.Location = New System.Drawing.Point(80, 166)
        Me.lblImprovementsHeader.Name = "lblImprovementsHeader"
        Me.lblImprovementsHeader.Size = New System.Drawing.Size(178, 25)
        Me.lblImprovementsHeader.TabIndex = 11
        Me.lblImprovementsHeader.Text = "Several bug fixes"
        '
        'lblStar
        '
        Me.lblStar.AutoSize = True
        Me.lblStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStar.Location = New System.Drawing.Point(-8, 56)
        Me.lblStar.Name = "lblStar"
        Me.lblStar.Size = New System.Drawing.Size(116, 152)
        Me.lblStar.TabIndex = 10
        Me.lblStar.Text = "*"
        '
        'frmUpdateNews
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(613, 296)
        Me.Controls.Add(Me.lblImprovements)
        Me.Controls.Add(Me.lblImprovementsHeader)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.llblChangelog)
        Me.Controls.Add(Me.lblNews)
        Me.Controls.Add(Me.lblNewsHeader)
        Me.Controls.Add(Me.pbImprovements)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.lblChangelog)
        Me.Controls.Add(Me.lblStar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdateNews"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown has been installed!"
        CType(Me.pbImprovements, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents pbImprovements As PictureBox
    Friend WithEvents lblNewsHeader As Label
    Friend WithEvents lblNews As Label
    Friend WithEvents lblChangelog As Label
    Friend WithEvents llblChangelog As LinkLabel
    Friend WithEvents btnOK As Button
    Friend WithEvents lblImprovements As Label
    Friend WithEvents lblImprovementsHeader As Label
    Friend WithEvents lblStar As Label
End Class
