<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasicCalculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasicCalculator))
        Me.txtInOne = New System.Windows.Forms.TextBox()
        Me.lblOp = New System.Windows.Forms.Label()
        Me.txtInTwo = New System.Windows.Forms.TextBox()
        Me.txtEquals = New System.Windows.Forms.Label()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtInOne
        '
        Me.txtInOne.Location = New System.Drawing.Point(12, 12)
        Me.txtInOne.Name = "txtInOne"
        Me.txtInOne.Size = New System.Drawing.Size(100, 20)
        Me.txtInOne.TabIndex = 0
        '
        'lblOp
        '
        Me.lblOp.AutoSize = True
        Me.lblOp.Location = New System.Drawing.Point(118, 15)
        Me.lblOp.Name = "lblOp"
        Me.lblOp.Size = New System.Drawing.Size(10, 13)
        Me.lblOp.TabIndex = 1
        Me.lblOp.Text = " "
        '
        'txtInTwo
        '
        Me.txtInTwo.Location = New System.Drawing.Point(134, 12)
        Me.txtInTwo.Name = "txtInTwo"
        Me.txtInTwo.Size = New System.Drawing.Size(100, 20)
        Me.txtInTwo.TabIndex = 2
        '
        'txtEquals
        '
        Me.txtEquals.AutoSize = True
        Me.txtEquals.Location = New System.Drawing.Point(240, 15)
        Me.txtEquals.Name = "txtEquals"
        Me.txtEquals.Size = New System.Drawing.Size(13, 13)
        Me.txtEquals.TabIndex = 3
        Me.txtEquals.Text = "="
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(259, 12)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(100, 20)
        Me.txtOutput.TabIndex = 4
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(12, 67)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(75, 23)
        Me.btnDivide.TabIndex = 5
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(93, 67)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(75, 23)
        Me.btnMultiply.TabIndex = 6
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(12, 38)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(93, 38)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(75, 23)
        Me.btnSubtract.TabIndex = 8
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(284, 67)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BasicCalculator
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 105)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.txtEquals)
        Me.Controls.Add(Me.txtInTwo)
        Me.Controls.Add(Me.lblOp)
        Me.Controls.Add(Me.txtInOne)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BasicCalculator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInOne As System.Windows.Forms.TextBox
    Friend WithEvents lblOp As System.Windows.Forms.Label
    Friend WithEvents txtInTwo As System.Windows.Forms.TextBox
    Friend WithEvents txtEquals As System.Windows.Forms.Label
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents btnDivide As System.Windows.Forms.Button
    Friend WithEvents btnMultiply As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSubtract As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
