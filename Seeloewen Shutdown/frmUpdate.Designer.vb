<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUpdate
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUpdate))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.rtbLatestVersionNews = New System.Windows.Forms.RichTextBox()
        Me.btnIgnore = New System.Windows.Forms.Button()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.pbBackground = New System.Windows.Forms.PictureBox()
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(8, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(233, 20)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Es ist ein Update verfügbar!"
        '
        'rtbLatestVersionNews
        '
        Me.rtbLatestVersionNews.BackColor = System.Drawing.Color.White
        Me.rtbLatestVersionNews.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbLatestVersionNews.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLatestVersionNews.Location = New System.Drawing.Point(12, 33)
        Me.rtbLatestVersionNews.Name = "rtbLatestVersionNews"
        Me.rtbLatestVersionNews.ReadOnly = True
        Me.rtbLatestVersionNews.Size = New System.Drawing.Size(340, 135)
        Me.rtbLatestVersionNews.TabIndex = 4
        Me.rtbLatestVersionNews.Text = ""
        '
        'btnIgnore
        '
        Me.btnIgnore.BackColor = System.Drawing.Color.Transparent
        Me.btnIgnore.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnIgnore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIgnore.FlatAppearance.BorderSize = 0
        Me.btnIgnore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnIgnore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnIgnore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIgnore.ForeColor = System.Drawing.Color.White
        Me.btnIgnore.Location = New System.Drawing.Point(11, 183)
        Me.btnIgnore.Name = "btnIgnore"
        Me.btnIgnore.Size = New System.Drawing.Size(167, 23)
        Me.btnIgnore.TabIndex = 3
        Me.btnIgnore.Text = "Ignorieren"
        Me.btnIgnore.UseVisualStyleBackColor = False
        '
        'btnDownload
        '
        Me.btnDownload.BackColor = System.Drawing.Color.Transparent
        Me.btnDownload.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnDownload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDownload.FlatAppearance.BorderSize = 0
        Me.btnDownload.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnDownload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDownload.ForeColor = System.Drawing.Color.White
        Me.btnDownload.Location = New System.Drawing.Point(184, 183)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(167, 23)
        Me.btnDownload.TabIndex = 2
        Me.btnDownload.Text = "Herunterladen"
        Me.btnDownload.UseVisualStyleBackColor = False
        '
        'pbBackground
        '
        Me.pbBackground.BackColor = System.Drawing.SystemColors.Control
        Me.pbBackground.Location = New System.Drawing.Point(-32, 174)
        Me.pbBackground.Name = "pbBackground"
        Me.pbBackground.Size = New System.Drawing.Size(634, 46)
        Me.pbBackground.TabIndex = 0
        Me.pbBackground.TabStop = False
        '
        'frmUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(363, 214)
        Me.Controls.Add(Me.rtbLatestVersionNews)
        Me.Controls.Add(Me.btnIgnore)
        Me.Controls.Add(Me.btnDownload)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.pbBackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aktualisierung"
        CType(Me.pbBackground, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbBackground As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnIgnore As Button
    Friend WithEvents rtbLatestVersionNews As RichTextBox
End Class
