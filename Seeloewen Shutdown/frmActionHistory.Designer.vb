﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmActionHistory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmActionHistory))
        Me.lvActionHistory = New System.Windows.Forms.ListView()
        Me.chAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chTime = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chStartedOn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lblPastActionsHeader = New System.Windows.Forms.Label()
        Me.lblPastActionsDesc = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvActionHistory
        '
        Me.lvActionHistory.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chAction, Me.chTime, Me.chStartedOn})
        Me.lvActionHistory.HideSelection = False
        Me.lvActionHistory.Location = New System.Drawing.Point(15, 64)
        Me.lvActionHistory.Name = "lvActionHistory"
        Me.lvActionHistory.Size = New System.Drawing.Size(601, 357)
        Me.lvActionHistory.TabIndex = 0
        Me.lvActionHistory.UseCompatibleStateImageBehavior = False
        Me.lvActionHistory.View = System.Windows.Forms.View.Details
        '
        'chAction
        '
        Me.chAction.Text = "Action"
        Me.chAction.Width = 141
        '
        'chTime
        '
        Me.chTime.Text = "Time"
        Me.chTime.Width = 212
        '
        'chStartedOn
        '
        Me.chStartedOn.Text = "Started on"
        Me.chStartedOn.Width = 243
        '
        'lblPastActionsHeader
        '
        Me.lblPastActionsHeader.AutoSize = True
        Me.lblPastActionsHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastActionsHeader.Location = New System.Drawing.Point(7, 9)
        Me.lblPastActionsHeader.Name = "lblPastActionsHeader"
        Me.lblPastActionsHeader.Size = New System.Drawing.Size(156, 25)
        Me.lblPastActionsHeader.TabIndex = 2
        Me.lblPastActionsHeader.Text = "Action history"
        '
        'lblPastActionsDesc
        '
        Me.lblPastActionsDesc.AutoSize = True
        Me.lblPastActionsDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPastActionsDesc.Location = New System.Drawing.Point(12, 38)
        Me.lblPastActionsDesc.Name = "lblPastActionsDesc"
        Me.lblPastActionsDesc.Size = New System.Drawing.Size(143, 16)
        Me.lblPastActionsDesc.TabIndex = 3
        Me.lblPastActionsDesc.Text = "View your past actions."
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.Transparent
        Me.btnClose.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(314, 429)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(302, 29)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Transparent
        Me.btnClear.BackgroundImage = Global.Seeloewen_Shutdown.My.Resources.Resources.button
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(15, 429)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(293, 29)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Cear Action History"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'frmActionHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(625, 468)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblPastActionsDesc)
        Me.Controls.Add(Me.lblPastActionsHeader)
        Me.Controls.Add(Me.lvActionHistory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmActionHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action History"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvActionHistory As ListView
    Friend WithEvents lblPastActionsHeader As Label
    Friend WithEvents lblPastActionsDesc As Label
    Friend WithEvents chAction As ColumnHeader
    Friend WithEvents chTime As ColumnHeader
    Friend WithEvents chStartedOn As ColumnHeader
    Friend WithEvents btnClose As Button
    Friend WithEvents btnClear As Button
End Class
