<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Maths
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
        Me.txtNumber1 = New System.Windows.Forms.TextBox()
        Me.txtNumber2 = New System.Windows.Forms.TextBox()
        Me.txtNumber3 = New System.Windows.Forms.TextBox()
        Me.txtFactor = New System.Windows.Forms.TextBox()
        Me.txtResult1 = New System.Windows.Forms.TextBox()
        Me.txtResult2 = New System.Windows.Forms.TextBox()
        Me.txtResult3 = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblFactor = New System.Windows.Forms.Label()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'txtNumber1
        '
        Me.txtNumber1.Location = New System.Drawing.Point(13, 28)
        Me.txtNumber1.Name = "txtNumber1"
        Me.txtNumber1.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber1.TabIndex = 0
        '
        'txtNumber2
        '
        Me.txtNumber2.Location = New System.Drawing.Point(12, 54)
        Me.txtNumber2.Name = "txtNumber2"
        Me.txtNumber2.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber2.TabIndex = 1
        '
        'txtNumber3
        '
        Me.txtNumber3.Location = New System.Drawing.Point(13, 81)
        Me.txtNumber3.Name = "txtNumber3"
        Me.txtNumber3.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber3.TabIndex = 2
        '
        'txtFactor
        '
        Me.txtFactor.Location = New System.Drawing.Point(120, 28)
        Me.txtFactor.Name = "txtFactor"
        Me.txtFactor.Size = New System.Drawing.Size(100, 20)
        Me.txtFactor.TabIndex = 3
        '
        'txtResult1
        '
        Me.txtResult1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtResult1.Location = New System.Drawing.Point(228, 28)
        Me.txtResult1.Name = "txtResult1"
        Me.txtResult1.Size = New System.Drawing.Size(100, 20)
        Me.txtResult1.TabIndex = 4
        '
        'txtResult2
        '
        Me.txtResult2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtResult2.Location = New System.Drawing.Point(228, 54)
        Me.txtResult2.Name = "txtResult2"
        Me.txtResult2.Size = New System.Drawing.Size(100, 20)
        Me.txtResult2.TabIndex = 5
        '
        'txtResult3
        '
        Me.txtResult3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtResult3.Location = New System.Drawing.Point(228, 81)
        Me.txtResult3.Name = "txtResult3"
        Me.txtResult3.Size = New System.Drawing.Size(100, 20)
        Me.txtResult3.TabIndex = 6
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = true
        Me.lblNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(49, 13)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Numbers"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = true
        Me.lblFactor.Location = New System.Drawing.Point(120, 9)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 8
        Me.lblFactor.Text = "Factor"
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblResult.AutoSize = true
        Me.lblResult.Location = New System.Drawing.Point(227, 9)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Result"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = true
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(253, 108)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'Maths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 143)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.lblFactor)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtResult3)
        Me.Controls.Add(Me.txtResult2)
        Me.Controls.Add(Me.txtResult1)
        Me.Controls.Add(Me.txtFactor)
        Me.Controls.Add(Me.txtNumber3)
        Me.Controls.Add(Me.txtNumber2)
        Me.Controls.Add(Me.txtNumber1)
        Me.HelpButton = true
        Me.Name = "Maths"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths"
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents txtNumber1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNumber3 As System.Windows.Forms.TextBox
    Friend WithEvents txtFactor As System.Windows.Forms.TextBox
    Friend WithEvents txtResult1 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult3 As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblFactor As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
End Class
