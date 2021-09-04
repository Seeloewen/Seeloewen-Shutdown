<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFirstStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFirstStart))
        Me.lblSelectLanguage = New System.Windows.Forms.Label()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelectLanguage
        '
        Me.lblSelectLanguage.AutoSize = True
        Me.lblSelectLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectLanguage.Location = New System.Drawing.Point(13, 13)
        Me.lblSelectLanguage.Name = "lblSelectLanguage"
        Me.lblSelectLanguage.Size = New System.Drawing.Size(284, 16)
        Me.lblSelectLanguage.TabIndex = 0
        Me.lblSelectLanguage.Text = "Please select a language before you continue."
        '
        'cbxLanguage
        '
        Me.cbxLanguage.AutoCompleteCustomSource.AddRange(New String() {"Deutsch (German)", "English (English)"})
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"Deutsch (German)", "English (English)"})
        Me.cbxLanguage.Location = New System.Drawing.Point(16, 33)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(281, 21)
        Me.cbxLanguage.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(96, 69)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(115, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmFirstStart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(310, 104)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.cbxLanguage)
        Me.Controls.Add(Me.lblSelectLanguage)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmFirstStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seeloewen Shutdown"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelectLanguage As Label
    Friend WithEvents cbxLanguage As ComboBox
    Friend WithEvents btnOK As Button
End Class
