﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Startup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnArrays = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnCountsTotals = New System.Windows.Forms.Button()
        Me.btnGitUpdater = New System.Windows.Forms.Button()
        Me.btnList = New System.Windows.Forms.Button()
        Me.btnMaths = New System.Windows.Forms.Button()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.btnVars = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArrays
        '
        Me.btnArrays.Location = New System.Drawing.Point(12, 12)
        Me.btnArrays.Name = "btnArrays"
        Me.btnArrays.Size = New System.Drawing.Size(75, 23)
        Me.btnArrays.TabIndex = 0
        Me.btnArrays.Text = "Arrays"
        Me.btnArrays.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(93, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "BasicCalculator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnCountsTotals
        '
        Me.btnCountsTotals.Location = New System.Drawing.Point(187, 12)
        Me.btnCountsTotals.Name = "btnCountsTotals"
        Me.btnCountsTotals.Size = New System.Drawing.Size(84, 23)
        Me.btnCountsTotals.TabIndex = 2
        Me.btnCountsTotals.Text = "Counts+Totals"
        Me.btnCountsTotals.UseVisualStyleBackColor = True
        '
        'btnGitUpdater
        '
        Me.btnGitUpdater.Location = New System.Drawing.Point(277, 12)
        Me.btnGitUpdater.Name = "btnGitUpdater"
        Me.btnGitUpdater.Size = New System.Drawing.Size(75, 23)
        Me.btnGitUpdater.TabIndex = 3
        Me.btnGitUpdater.Text = "GitUpdater"
        Me.btnGitUpdater.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(358, 12)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(75, 23)
        Me.btnList.TabIndex = 4
        Me.btnList.Text = "ListBox"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnMaths
        '
        Me.btnMaths.Location = New System.Drawing.Point(439, 12)
        Me.btnMaths.Name = "btnMaths"
        Me.btnMaths.Size = New System.Drawing.Size(75, 23)
        Me.btnMaths.TabIndex = 5
        Me.btnMaths.Text = "Maths"
        Me.btnMaths.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(520, 12)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(75, 23)
        Me.btnTest.TabIndex = 6
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnVars
        '
        Me.btnVars.Location = New System.Drawing.Point(601, 12)
        Me.btnVars.Name = "btnVars"
        Me.btnVars.Size = New System.Drawing.Size(75, 23)
        Me.btnVars.TabIndex = 7
        Me.btnVars.Text = "Variables"
        Me.btnVars.UseVisualStyleBackColor = True
        '
        'Startup
        '
        Me.AcceptButton = Me.btnMaths
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 47)
        Me.Controls.Add(Me.btnVars)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.btnMaths)
        Me.Controls.Add(Me.btnList)
        Me.Controls.Add(Me.btnGitUpdater)
        Me.Controls.Add(Me.btnCountsTotals)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnArrays)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Startup"
        Me.Text = "Startup"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnArrays As System.Windows.Forms.Button
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents btnCountsTotals As System.Windows.Forms.Button
    Friend WithEvents btnGitUpdater As System.Windows.Forms.Button
    Friend WithEvents btnList As System.Windows.Forms.Button
    Friend WithEvents btnMaths As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents btnVars As System.Windows.Forms.Button
End Class
