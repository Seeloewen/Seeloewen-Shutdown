<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchProcesses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchProcesses))
        Me.lblProcessSearcherDesc = New System.Windows.Forms.Label()
        Me.gbProcesses = New System.Windows.Forms.GroupBox()
        Me.pnlProcesses = New System.Windows.Forms.Panel()
        Me.lblProcessSearcherHeader = New System.Windows.Forms.Label()
        Me.btnConfirm = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateList = New System.Windows.Forms.Button()
        Me.gbProcesses.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblProcessSearcherDesc
        '
        Me.lblProcessSearcherDesc.AutoSize = True
        Me.lblProcessSearcherDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessSearcherDesc.Location = New System.Drawing.Point(12, 43)
        Me.lblProcessSearcherDesc.Name = "lblProcessSearcherDesc"
        Me.lblProcessSearcherDesc.Size = New System.Drawing.Size(531, 32)
        Me.lblProcessSearcherDesc.TabIndex = 0
        Me.lblProcessSearcherDesc.Text = "The following list contains all currently running processes. You can select proce" &
    "sses and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "confirm to add it to your list. Processes that are already on the lis" &
    "t will not be shown here."
        '
        'gbProcesses
        '
        Me.gbProcesses.Controls.Add(Me.pnlProcesses)
        Me.gbProcesses.Location = New System.Drawing.Point(16, 105)
        Me.gbProcesses.Name = "gbProcesses"
        Me.gbProcesses.Size = New System.Drawing.Size(562, 315)
        Me.gbProcesses.TabIndex = 1
        Me.gbProcesses.TabStop = False
        '
        'pnlProcesses
        '
        Me.pnlProcesses.AutoScroll = True
        Me.pnlProcesses.Location = New System.Drawing.Point(6, 14)
        Me.pnlProcesses.Name = "pnlProcesses"
        Me.pnlProcesses.Size = New System.Drawing.Size(550, 290)
        Me.pnlProcesses.TabIndex = 0
        '
        'lblProcessSearcherHeader
        '
        Me.lblProcessSearcherHeader.AutoSize = True
        Me.lblProcessSearcherHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProcessSearcherHeader.Location = New System.Drawing.Point(11, 9)
        Me.lblProcessSearcherHeader.Name = "lblProcessSearcherHeader"
        Me.lblProcessSearcherHeader.Size = New System.Drawing.Size(199, 25)
        Me.lblProcessSearcherHeader.TabIndex = 3
        Me.lblProcessSearcherHeader.Text = "Process Searcher"
        '
        'btnConfirm
        '
        Me.btnConfirm.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConfirm.FlatAppearance.BorderSize = 0
        Me.btnConfirm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirm.ForeColor = System.Drawing.Color.White
        Me.btnConfirm.Location = New System.Drawing.Point(407, 427)
        Me.btnConfirm.Name = "btnConfirm"
        Me.btnConfirm.Size = New System.Drawing.Size(171, 26)
        Me.btnConfirm.TabIndex = 4
        Me.btnConfirm.Text = "Confirm"
        Me.btnConfirm.UseVisualStyleBackColor = True
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
        Me.btnCancel.Location = New System.Drawing.Point(16, 427)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(171, 26)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdateList
        '
        Me.btnUpdateList.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnUpdateList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateList.FlatAppearance.BorderSize = 0
        Me.btnUpdateList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnUpdateList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnUpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateList.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateList.ForeColor = System.Drawing.Color.White
        Me.btnUpdateList.Location = New System.Drawing.Point(204, 427)
        Me.btnUpdateList.Name = "btnUpdateList"
        Me.btnUpdateList.Size = New System.Drawing.Size(188, 26)
        Me.btnUpdateList.TabIndex = 6
        Me.btnUpdateList.Text = "Update List"
        Me.btnUpdateList.UseVisualStyleBackColor = True
        '
        'frmSearchProcesses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(590, 465)
        Me.Controls.Add(Me.btnUpdateList)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnConfirm)
        Me.Controls.Add(Me.lblProcessSearcherHeader)
        Me.Controls.Add(Me.gbProcesses)
        Me.Controls.Add(Me.lblProcessSearcherDesc)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSearchProcesses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Select from open processes..."
        Me.gbProcesses.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProcessSearcherDesc As Label
    Friend WithEvents gbProcesses As GroupBox
    Friend WithEvents lblProcessSearcherHeader As Label
    Friend WithEvents btnConfirm As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents pnlProcesses As Panel
    Friend WithEvents btnUpdateList As Button
End Class
