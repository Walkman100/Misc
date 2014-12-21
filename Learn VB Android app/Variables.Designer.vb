<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Variables
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
        Me.btnInput1 = New System.Windows.Forms.Button()
        Me.btnInput2 = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnShowAnswer = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnInput1
        '
        Me.btnInput1.Location = New System.Drawing.Point(12, 12)
        Me.btnInput1.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnInput1.Name = "btnInput1"
        Me.btnInput1.Size = New System.Drawing.Size(100, 50)
        Me.btnInput1.TabIndex = 0
        Me.btnInput1.Text = "Input Number One"
        Me.btnInput1.UseVisualStyleBackColor = True
        '
        'btnInput2
        '
        Me.btnInput2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnInput2.Location = New System.Drawing.Point(118, 12)
        Me.btnInput2.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnInput2.Name = "btnInput2"
        Me.btnInput2.Size = New System.Drawing.Size(100, 50)
        Me.btnInput2.TabIndex = 1
        Me.btnInput2.Text = "Input Number Two"
        Me.btnInput2.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.Location = New System.Drawing.Point(12, 68)
        Me.btnAdd.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 50)
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnShowAnswer
        '
        Me.btnShowAnswer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowAnswer.Location = New System.Drawing.Point(118, 68)
        Me.btnShowAnswer.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnShowAnswer.Name = "btnShowAnswer"
        Me.btnShowAnswer.Size = New System.Drawing.Size(100, 50)
        Me.btnShowAnswer.TabIndex = 3
        Me.btnShowAnswer.Text = "Show Answer"
        Me.btnShowAnswer.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(224, 68)
        Me.btnExit.MinimumSize = New System.Drawing.Size(100, 30)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 50)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Variables
        '
        Me.AcceptButton = Me.btnShowAnswer
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(337, 130)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnShowAnswer)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnInput2)
        Me.Controls.Add(Me.btnInput1)
        Me.HelpButton = True
        Me.Name = "Variables"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Variables"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnInput1 As System.Windows.Forms.Button
    Friend WithEvents btnInput2 As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnShowAnswer As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
