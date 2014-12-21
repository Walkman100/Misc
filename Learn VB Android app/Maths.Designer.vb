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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Maths))
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtInsertFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInsertTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInsertSeperator = New System.Windows.Forms.TextBox()
        Me.btnInsertGo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInsertStep = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
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
        Me.txtResult1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult1.Location = New System.Drawing.Point(228, 28)
        Me.txtResult1.Name = "txtResult1"
        Me.txtResult1.Size = New System.Drawing.Size(100, 20)
        Me.txtResult1.TabIndex = 4
        '
        'txtResult2
        '
        Me.txtResult2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult2.Location = New System.Drawing.Point(228, 54)
        Me.txtResult2.Name = "txtResult2"
        Me.txtResult2.Size = New System.Drawing.Size(100, 20)
        Me.txtResult2.TabIndex = 5
        '
        'txtResult3
        '
        Me.txtResult3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtResult3.Location = New System.Drawing.Point(228, 81)
        Me.txtResult3.Name = "txtResult3"
        Me.txtResult3.Size = New System.Drawing.Size(100, 20)
        Me.txtResult3.TabIndex = 6
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(12, 9)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(49, 13)
        Me.lblNumber.TabIndex = 7
        Me.lblNumber.Text = "Numbers"
        '
        'lblFactor
        '
        Me.lblFactor.AutoSize = True
        Me.lblFactor.Location = New System.Drawing.Point(120, 9)
        Me.lblFactor.Name = "lblFactor"
        Me.lblFactor.Size = New System.Drawing.Size(37, 13)
        Me.lblFactor.TabIndex = 8
        Me.lblFactor.Text = "Factor"
        '
        'lblResult
        '
        Me.lblResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(227, 9)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(37, 13)
        Me.lblResult.TabIndex = 9
        Me.lblResult.Text = "Result"
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.AutoSize = True
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(253, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 249)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Insert numbers from:"
        '
        'txtInsertFrom
        '
        Me.txtInsertFrom.Location = New System.Drawing.Point(12, 265)
        Me.txtInsertFrom.Name = "txtInsertFrom"
        Me.txtInsertFrom.Size = New System.Drawing.Size(50, 20)
        Me.txtInsertFrom.TabIndex = 20
        Me.txtInsertFrom.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 268)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "to"
        '
        'txtInsertTo
        '
        Me.txtInsertTo.Location = New System.Drawing.Point(90, 265)
        Me.txtInsertTo.Name = "txtInsertTo"
        Me.txtInsertTo.Size = New System.Drawing.Size(50, 20)
        Me.txtInsertTo.TabIndex = 22
        Me.txtInsertTo.Text = "200"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "With Seperator:"
        '
        'txtInsertSeperator
        '
        Me.txtInsertSeperator.Location = New System.Drawing.Point(12, 304)
        Me.txtInsertSeperator.Name = "txtInsertSeperator"
        Me.txtInsertSeperator.Size = New System.Drawing.Size(100, 20)
        Me.txtInsertSeperator.TabIndex = 24
        Me.txtInsertSeperator.Text = "{ENTER}"
        '
        'btnInsertGo
        '
        Me.btnInsertGo.Location = New System.Drawing.Point(118, 302)
        Me.btnInsertGo.Name = "btnInsertGo"
        Me.btnInsertGo.Size = New System.Drawing.Size(113, 23)
        Me.btnInsertGo.TabIndex = 25
        Me.btnInsertGo.Text = "Go"
        Me.btnInsertGo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(146, 268)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Step"
        '
        'txtInsertStep
        '
        Me.txtInsertStep.Location = New System.Drawing.Point(181, 265)
        Me.txtInsertStep.Name = "txtInsertStep"
        Me.txtInsertStep.Size = New System.Drawing.Size(50, 20)
        Me.txtInsertStep.TabIndex = 27
        Me.txtInsertStep.Text = "1"
        '
        'Maths
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(340, 337)
        Me.Controls.Add(Me.txtInsertStep)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnInsertGo)
        Me.Controls.Add(Me.txtInsertSeperator)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInsertTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtInsertFrom)
        Me.Controls.Add(Me.Label1)
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
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Maths"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maths"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInsertFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInsertTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInsertSeperator As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertGo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInsertStep As System.Windows.Forms.TextBox
End Class
