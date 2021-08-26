<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHilfe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHilfe))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblShowHelpFor = New System.Windows.Forms.Label()
        Me.btnFrmMain = New System.Windows.Forms.Button()
        Me.btnFrmInformation = New System.Windows.Forms.Button()
        Me.btnFrmSettings = New System.Windows.Forms.Button()
        Me.gbHelp = New System.Windows.Forms.GroupBox()
        Me.pbHelp = New System.Windows.Forms.PictureBox()
        Me.btnFrmFinish = New System.Windows.Forms.Button()
        Me.btnFrmUpdate = New System.Windows.Forms.Button()
        Me.btnFrmChangelog = New System.Windows.Forms.Button()
        Me.gbHelp.SuspendLayout()
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(324, 25)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Hilfe zu Seeloewen Shutdown"
        '
        'lblShowHelpFor
        '
        Me.lblShowHelpFor.AutoSize = True
        Me.lblShowHelpFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShowHelpFor.Location = New System.Drawing.Point(14, 50)
        Me.lblShowHelpFor.Name = "lblShowHelpFor"
        Me.lblShowHelpFor.Size = New System.Drawing.Size(137, 20)
        Me.lblShowHelpFor.TabIndex = 1
        Me.lblShowHelpFor.Text = "Hilfe anzeigen für:"
        '
        'btnFrmMain
        '
        Me.btnFrmMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmMain.Location = New System.Drawing.Point(157, 50)
        Me.btnFrmMain.Name = "btnFrmMain"
        Me.btnFrmMain.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmMain.TabIndex = 2
        Me.btnFrmMain.Text = "Hauptfenster"
        Me.btnFrmMain.UseVisualStyleBackColor = True
        '
        'btnFrmInformation
        '
        Me.btnFrmInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmInformation.Location = New System.Drawing.Point(365, 50)
        Me.btnFrmInformation.Name = "btnFrmInformation"
        Me.btnFrmInformation.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmInformation.TabIndex = 3
        Me.btnFrmInformation.Text = "Informationen"
        Me.btnFrmInformation.UseVisualStyleBackColor = True
        '
        'btnFrmSettings
        '
        Me.btnFrmSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmSettings.Location = New System.Drawing.Point(261, 50)
        Me.btnFrmSettings.Name = "btnFrmSettings"
        Me.btnFrmSettings.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmSettings.TabIndex = 4
        Me.btnFrmSettings.Text = "Einstellungen"
        Me.btnFrmSettings.UseVisualStyleBackColor = True
        '
        'gbHelp
        '
        Me.gbHelp.Controls.Add(Me.pbHelp)
        Me.gbHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbHelp.Location = New System.Drawing.Point(18, 79)
        Me.gbHelp.Name = "gbHelp"
        Me.gbHelp.Size = New System.Drawing.Size(897, 530)
        Me.gbHelp.TabIndex = 5
        Me.gbHelp.TabStop = False
        Me.gbHelp.Text = "Hauptfenster"
        '
        'pbHelp
        '
        Me.pbHelp.Image = Global.Seeloewen_Shutdown.My.Resources.Resources.frmMain
        Me.pbHelp.Location = New System.Drawing.Point(15, 26)
        Me.pbHelp.Name = "pbHelp"
        Me.pbHelp.Size = New System.Drawing.Size(866, 491)
        Me.pbHelp.TabIndex = 0
        Me.pbHelp.TabStop = False
        '
        'btnFrmFinish
        '
        Me.btnFrmFinish.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmFinish.Location = New System.Drawing.Point(469, 50)
        Me.btnFrmFinish.Name = "btnFrmFinish"
        Me.btnFrmFinish.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmFinish.TabIndex = 7
        Me.btnFrmFinish.Text = "Mitteilung"
        Me.btnFrmFinish.UseVisualStyleBackColor = True
        '
        'btnFrmUpdate
        '
        Me.btnFrmUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmUpdate.Location = New System.Drawing.Point(573, 50)
        Me.btnFrmUpdate.Name = "btnFrmUpdate"
        Me.btnFrmUpdate.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmUpdate.TabIndex = 9
        Me.btnFrmUpdate.Text = "Update"
        Me.btnFrmUpdate.UseVisualStyleBackColor = True
        '
        'btnFrmChangelog
        '
        Me.btnFrmChangelog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFrmChangelog.Location = New System.Drawing.Point(677, 50)
        Me.btnFrmChangelog.Name = "btnFrmChangelog"
        Me.btnFrmChangelog.Size = New System.Drawing.Size(98, 23)
        Me.btnFrmChangelog.TabIndex = 10
        Me.btnFrmChangelog.Text = "Changelog"
        Me.btnFrmChangelog.UseVisualStyleBackColor = True
        '
        'frmHilfe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 624)
        Me.Controls.Add(Me.btnFrmChangelog)
        Me.Controls.Add(Me.btnFrmUpdate)
        Me.Controls.Add(Me.btnFrmFinish)
        Me.Controls.Add(Me.gbHelp)
        Me.Controls.Add(Me.btnFrmSettings)
        Me.Controls.Add(Me.btnFrmInformation)
        Me.Controls.Add(Me.btnFrmMain)
        Me.Controls.Add(Me.lblShowHelpFor)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHilfe"
        Me.Text = "Hilfe"
        Me.gbHelp.ResumeLayout(False)
        CType(Me.pbHelp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblShowHelpFor As Label
    Friend WithEvents btnFrmMain As Button
    Friend WithEvents btnFrmInformation As Button
    Friend WithEvents btnFrmSettings As Button
    Friend WithEvents gbHelp As GroupBox
    Friend WithEvents pbHelp As PictureBox
    Friend WithEvents btnFrmFinish As Button
    Friend WithEvents btnFrmUpdate As Button
    Friend WithEvents btnFrmChangelog As Button
End Class
