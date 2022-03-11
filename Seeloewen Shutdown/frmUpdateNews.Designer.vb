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
        Me.pbUpdate = New System.Windows.Forms.PictureBox()
        Me.lblUpdaterHeader = New System.Windows.Forms.Label()
        Me.lblUpdater = New System.Windows.Forms.Label()
        Me.lblChangelog = New System.Windows.Forms.Label()
        Me.llblChangelog = New System.Windows.Forms.LinkLabel()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblImprovements = New System.Windows.Forms.Label()
        Me.lblImprovementsHeader = New System.Windows.Forms.Label()
        Me.lblStar = New System.Windows.Forms.Label()
        CType(Me.pbUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(13, 13)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(332, 29)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Version 1.7.0 - What's new?"
        '
        'pbUpdate
        '
        Me.pbUpdate.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.Update
        Me.pbUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbUpdate.Location = New System.Drawing.Point(17, 79)
        Me.pbUpdate.Name = "pbUpdate"
        Me.pbUpdate.Size = New System.Drawing.Size(53, 54)
        Me.pbUpdate.TabIndex = 1
        Me.pbUpdate.TabStop = False
        '
        'lblUpdaterHeader
        '
        Me.lblUpdaterHeader.AutoSize = True
        Me.lblUpdaterHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdaterHeader.Location = New System.Drawing.Point(76, 69)
        Me.lblUpdaterHeader.Name = "lblUpdaterHeader"
        Me.lblUpdaterHeader.Size = New System.Drawing.Size(141, 25)
        Me.lblUpdaterHeader.TabIndex = 2
        Me.lblUpdaterHeader.Text = "A new design"
        '
        'lblUpdater
        '
        Me.lblUpdater.AutoSize = True
        Me.lblUpdater.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUpdater.Location = New System.Drawing.Point(77, 94)
        Me.lblUpdater.Name = "lblUpdater"
        Me.lblUpdater.Size = New System.Drawing.Size(484, 40)
        Me.lblUpdater.TabIndex = 3
        Me.lblUpdater.Text = "The software now features a new design to make it more appealing " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and easier und" &
    "erstandable and improve usability." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblChangelog
        '
        Me.lblChangelog.AutoSize = True
        Me.lblChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChangelog.Location = New System.Drawing.Point(15, 303)
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
        Me.llblChangelog.Location = New System.Drawing.Point(240, 303)
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
        Me.btnOK.Location = New System.Drawing.Point(488, 295)
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
        Me.lblImprovements.Location = New System.Drawing.Point(76, 196)
        Me.lblImprovements.Name = "lblImprovements"
        Me.lblImprovements.Size = New System.Drawing.Size(516, 60)
        Me.lblImprovements.TabIndex = 12
        Me.lblImprovements.Text = "The software is now much more stable due to bug fixes. There are also " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "some new " &
    "features like auto detection for running actions. In addition to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "that the mess" &
    "age feature was removed."
        '
        'lblImprovementsHeader
        '
        Me.lblImprovementsHeader.AutoSize = True
        Me.lblImprovementsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblImprovementsHeader.Location = New System.Drawing.Point(75, 171)
        Me.lblImprovementsHeader.Name = "lblImprovementsHeader"
        Me.lblImprovementsHeader.Size = New System.Drawing.Size(359, 25)
        Me.lblImprovementsHeader.TabIndex = 11
        Me.lblImprovementsHeader.Text = "Several bug fixes and other features" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblStar
        '
        Me.lblStar.AutoSize = True
        Me.lblStar.Font = New System.Drawing.Font("Microsoft Sans Serif", 99.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblStar.Location = New System.Drawing.Point(-9, 171)
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
        Me.ClientSize = New System.Drawing.Size(617, 334)
        Me.Controls.Add(Me.lblImprovements)
        Me.Controls.Add(Me.lblImprovementsHeader)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.llblChangelog)
        Me.Controls.Add(Me.lblUpdater)
        Me.Controls.Add(Me.lblUpdaterHeader)
        Me.Controls.Add(Me.pbUpdate)
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
        CType(Me.pbUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents pbUpdate As PictureBox
    Friend WithEvents lblUpdaterHeader As Label
    Friend WithEvents lblUpdater As Label
    Friend WithEvents lblChangelog As Label
    Friend WithEvents llblChangelog As LinkLabel
    Friend WithEvents btnOK As Button
    Friend WithEvents lblImprovements As Label
    Friend WithEvents lblImprovementsHeader As Label
    Friend WithEvents lblStar As Label
End Class
