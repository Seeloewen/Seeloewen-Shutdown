<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelectProcesses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelectProcesses))
        Me.lblProcessSelectionDesc = New System.Windows.Forms.Label()
        Me.lblProcessSelectionHeader = New System.Windows.Forms.Label()
        Me.rtbProcesses = New System.Windows.Forms.RichTextBox()
        Me.gbProcesses = New System.Windows.Forms.GroupBox()
        Me.btnSelectFromOpenProcesses = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.gbProcesses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProcessSelectionDesc
        '
        Me.lblProcessSelectionDesc.AutoSize = True
        Me.lblProcessSelectionDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessSelectionDesc.Location = New System.Drawing.Point(14, 38)
        Me.lblProcessSelectionDesc.Name = "lblProcessSelectionDesc"
        Me.lblProcessSelectionDesc.Size = New System.Drawing.Size(627, 48)
        Me.lblProcessSelectionDesc.TabIndex = 5
        Me.lblProcessSelectionDesc.Text = resources.GetString("lblProcessSelectionDesc.Text")
        '
        'lblProcessSelectionHeader
        '
        Me.lblProcessSelectionHeader.AutoSize = True
        Me.lblProcessSelectionHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessSelectionHeader.Location = New System.Drawing.Point(12, 9)
        Me.lblProcessSelectionHeader.Name = "lblProcessSelectionHeader"
        Me.lblProcessSelectionHeader.Size = New System.Drawing.Size(195, 25)
        Me.lblProcessSelectionHeader.TabIndex = 4
        Me.lblProcessSelectionHeader.Text = "Select Processes"
        '
        'rtbProcesses
        '
        Me.rtbProcesses.BackColor = System.Drawing.Color.White
        Me.rtbProcesses.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbProcesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbProcesses.Location = New System.Drawing.Point(6, 11)
        Me.rtbProcesses.Name = "rtbProcesses"
        Me.rtbProcesses.Size = New System.Drawing.Size(651, 308)
        Me.rtbProcesses.TabIndex = 6
        Me.rtbProcesses.Text = ""
        '
        'gbProcesses
        '
        Me.gbProcesses.Controls.Add(Me.rtbProcesses)
        Me.gbProcesses.Location = New System.Drawing.Point(17, 98)
        Me.gbProcesses.Name = "gbProcesses"
        Me.gbProcesses.Size = New System.Drawing.Size(663, 325)
        Me.gbProcesses.TabIndex = 7
        Me.gbProcesses.TabStop = False
        '
        'btnSelectFromOpenProcesses
        '
        Me.btnSelectFromOpenProcesses.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSelectFromOpenProcesses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSelectFromOpenProcesses.FlatAppearance.BorderSize = 0
        Me.btnSelectFromOpenProcesses.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSelectFromOpenProcesses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSelectFromOpenProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelectFromOpenProcesses.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectFromOpenProcesses.ForeColor = System.Drawing.Color.White
        Me.btnSelectFromOpenProcesses.Location = New System.Drawing.Point(217, 432)
        Me.btnSelectFromOpenProcesses.Name = "btnSelectFromOpenProcesses"
        Me.btnSelectFromOpenProcesses.Size = New System.Drawing.Size(257, 31)
        Me.btnSelectFromOpenProcesses.TabIndex = 8
        Me.btnSelectFromOpenProcesses.Text = "Select from open processes..."
        Me.btnSelectFromOpenProcesses.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(490, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(190, 31)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(17, 432)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(185, 31)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmSelectProcesses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(692, 475)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSelectFromOpenProcesses)
        Me.Controls.Add(Me.gbProcesses)
        Me.Controls.Add(Me.lblProcessSelectionDesc)
        Me.Controls.Add(Me.lblProcessSelectionHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSelectProcesses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select Processes"
        Me.gbProcesses.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProcessSelectionDesc As Label
    Friend WithEvents lblProcessSelectionHeader As Label
    Friend WithEvents rtbProcesses As RichTextBox
    Friend WithEvents gbProcesses As GroupBox
    Friend WithEvents btnSelectFromOpenProcesses As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
End Class
