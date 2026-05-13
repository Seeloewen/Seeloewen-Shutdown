<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenameProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRenameProfile))
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.lblSaveProfileAs = New System.Windows.Forms.Label()
        Me.tbRenameProfileTo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
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
        Me.btnCancel.Location = New System.Drawing.Point(226, 68)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 23)
        Me.btnCancel.TabIndex = 23
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseMnemonic = False
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnRename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRename.FlatAppearance.BorderSize = 0
        Me.btnRename.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRename.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.ForeColor = System.Drawing.Color.White
        Me.btnRename.Location = New System.Drawing.Point(104, 68)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(109, 23)
        Me.btnRename.TabIndex = 22
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'lblSaveProfileAs
        '
        Me.lblSaveProfileAs.AutoSize = True
        Me.lblSaveProfileAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSaveProfileAs.Location = New System.Drawing.Point(15, 11)
        Me.lblSaveProfileAs.Name = "lblSaveProfileAs"
        Me.lblSaveProfileAs.Size = New System.Drawing.Size(123, 16)
        Me.lblSaveProfileAs.TabIndex = 20
        Me.lblSaveProfileAs.Text = "Rename Profile to..."
        '
        'tbRenameProfileTo
        '
        Me.tbRenameProfileTo.Location = New System.Drawing.Point(15, 37)
        Me.tbRenameProfileTo.Name = "tbRenameProfileTo"
        Me.tbRenameProfileTo.Size = New System.Drawing.Size(320, 20)
        Me.tbRenameProfileTo.TabIndex = 24
        '
        'frmRenameProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(357, 104)
        Me.Controls.Add(Me.tbRenameProfileTo)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.lblSaveProfileAs)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRenameProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents lblSaveProfileAs As Label
    Friend WithEvents tbRenameProfileTo As TextBox
End Class
