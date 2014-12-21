<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.btnTime = New System.Windows.Forms.Button()
        Me.btnInserter = New System.Windows.Forms.Button()
        Me.btnSteam = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnArrays
        '
        Me.btnArrays.Location = New System.Drawing.Point(200, 41)
        Me.btnArrays.Name = "btnArrays"
        Me.btnArrays.Size = New System.Drawing.Size(88, 23)
        Me.btnArrays.TabIndex = 0
        Me.btnArrays.Text = "Arrays"
        Me.btnArrays.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(12, 12)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(88, 23)
        Me.btnCalc.TabIndex = 1
        Me.btnCalc.Text = "BasicCalculator"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnCountsTotals
        '
        Me.btnCountsTotals.Location = New System.Drawing.Point(106, 12)
        Me.btnCountsTotals.Name = "btnCountsTotals"
        Me.btnCountsTotals.Size = New System.Drawing.Size(88, 23)
        Me.btnCountsTotals.TabIndex = 2
        Me.btnCountsTotals.Text = "Counts+Totals"
        Me.btnCountsTotals.UseVisualStyleBackColor = True
        '
        'btnGitUpdater
        '
        Me.btnGitUpdater.Location = New System.Drawing.Point(294, 41)
        Me.btnGitUpdater.Name = "btnGitUpdater"
        Me.btnGitUpdater.Size = New System.Drawing.Size(88, 23)
        Me.btnGitUpdater.TabIndex = 3
        Me.btnGitUpdater.Text = "GitUpdater"
        Me.btnGitUpdater.UseVisualStyleBackColor = True
        '
        'btnList
        '
        Me.btnList.Location = New System.Drawing.Point(12, 41)
        Me.btnList.Name = "btnList"
        Me.btnList.Size = New System.Drawing.Size(88, 23)
        Me.btnList.TabIndex = 4
        Me.btnList.Text = "ListBox"
        Me.btnList.UseVisualStyleBackColor = True
        '
        'btnMaths
        '
        Me.btnMaths.Location = New System.Drawing.Point(200, 12)
        Me.btnMaths.Name = "btnMaths"
        Me.btnMaths.Size = New System.Drawing.Size(88, 23)
        Me.btnMaths.TabIndex = 5
        Me.btnMaths.Text = "Maths"
        Me.btnMaths.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(388, 41)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(88, 23)
        Me.btnTest.TabIndex = 6
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'btnVars
        '
        Me.btnVars.Location = New System.Drawing.Point(106, 41)
        Me.btnVars.Name = "btnVars"
        Me.btnVars.Size = New System.Drawing.Size(88, 23)
        Me.btnVars.TabIndex = 7
        Me.btnVars.Text = "Variables"
        Me.btnVars.UseVisualStyleBackColor = True
        '
        'btnTime
        '
        Me.btnTime.Location = New System.Drawing.Point(294, 12)
        Me.btnTime.Name = "btnTime"
        Me.btnTime.Size = New System.Drawing.Size(88, 23)
        Me.btnTime.TabIndex = 8
        Me.btnTime.Text = "TimeConverter"
        Me.btnTime.UseVisualStyleBackColor = True
        '
        'btnInserter
        '
        Me.btnInserter.Location = New System.Drawing.Point(388, 12)
        Me.btnInserter.Name = "btnInserter"
        Me.btnInserter.Size = New System.Drawing.Size(88, 23)
        Me.btnInserter.TabIndex = 9
        Me.btnInserter.Text = "NumberInserter"
        Me.btnInserter.UseVisualStyleBackColor = True
        '
        'btnSteam
        '
        Me.btnSteam.Location = New System.Drawing.Point(482, 12)
        Me.btnSteam.Name = "btnSteam"
        Me.btnSteam.Size = New System.Drawing.Size(88, 23)
        Me.btnSteam.TabIndex = 10
        Me.btnSteam.Text = "SteamIDLinker"
        Me.btnSteam.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(482, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Startup
        '
        Me.AcceptButton = Me.btnMaths
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 78)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSteam)
        Me.Controls.Add(Me.btnInserter)
        Me.Controls.Add(Me.btnTime)
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
    Friend WithEvents btnTime As System.Windows.Forms.Button
    Friend WithEvents btnInserter As System.Windows.Forms.Button
    Friend WithEvents btnSteam As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
