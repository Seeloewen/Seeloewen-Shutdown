﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLog
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLog))
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.btnSaveAsFile = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.rtbLog = New System.Windows.Forms.RichTextBox()
        Me.gbLog = New System.Windows.Forms.GroupBox()
        Me.gbLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(12, 20)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(155, 25)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Einstellungen"
        '
        'btnSaveAsFile
        '
        Me.btnSaveAsFile.Location = New System.Drawing.Point(300, 22)
        Me.btnSaveAsFile.Name = "btnSaveAsFile"
        Me.btnSaveAsFile.Size = New System.Drawing.Size(133, 27)
        Me.btnSaveAsFile.TabIndex = 2
        Me.btnSaveAsFile.Text = "Als Datei speichern"
        Me.btnSaveAsFile.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(439, 22)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(133, 27)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Leeren"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(578, 22)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(133, 27)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Schließen"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'rtbLog
        '
        Me.rtbLog.BackColor = System.Drawing.Color.White
        Me.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.rtbLog.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbLog.Location = New System.Drawing.Point(6, 10)
        Me.rtbLog.Name = "rtbLog"
        Me.rtbLog.Size = New System.Drawing.Size(687, 488)
        Me.rtbLog.TabIndex = 5
        Me.rtbLog.Text = ""
        '
        'gbLog
        '
        Me.gbLog.Controls.Add(Me.rtbLog)
        Me.gbLog.Location = New System.Drawing.Point(12, 61)
        Me.gbLog.Name = "gbLog"
        Me.gbLog.Size = New System.Drawing.Size(699, 504)
        Me.gbLog.TabIndex = 6
        Me.gbLog.TabStop = False
        '
        'frmLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(723, 577)
        Me.Controls.Add(Me.gbLog)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveAsFile)
        Me.Controls.Add(Me.lblHeader)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debug-Log"
        Me.gbLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents btnSaveAsFile As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents rtbLog As RichTextBox
    Friend WithEvents gbLog As GroupBox
End Class
