<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NumberInserter
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtInsertFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInsertTo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInsertSeperator = New System.Windows.Forms.TextBox()
        Me.btnInsertGo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtInsertStep = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Insert numbers from:"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.AutoSize = true
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(199, 62)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'txtInsertFrom
        '
        Me.txtInsertFrom.Location = New System.Drawing.Point(12, 25)
        Me.txtInsertFrom.Name = "txtInsertFrom"
        Me.txtInsertFrom.Size = New System.Drawing.Size(60, 20)
        Me.txtInsertFrom.TabIndex = 20
        Me.txtInsertFrom.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Location = New System.Drawing.Point(78, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "to"
        '
        'txtInsertTo
        '
        Me.txtInsertTo.Location = New System.Drawing.Point(100, 25)
        Me.txtInsertTo.Name = "txtInsertTo"
        Me.txtInsertTo.Size = New System.Drawing.Size(73, 20)
        Me.txtInsertTo.TabIndex = 22
        Me.txtInsertTo.Text = "200"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Location = New System.Drawing.Point(12, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "With Seperator:"
        '
        'txtInsertSeperator
        '
        Me.txtInsertSeperator.Location = New System.Drawing.Point(12, 64)
        Me.txtInsertSeperator.Name = "txtInsertSeperator"
        Me.txtInsertSeperator.Size = New System.Drawing.Size(100, 20)
        Me.txtInsertSeperator.TabIndex = 24
        Me.txtInsertSeperator.Text = "{ENTER}"
        '
        'btnInsertGo
        '
        Me.btnInsertGo.Location = New System.Drawing.Point(118, 62)
        Me.btnInsertGo.Name = "btnInsertGo"
        Me.btnInsertGo.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertGo.TabIndex = 25
        Me.btnInsertGo.Text = "Go"
        Me.btnInsertGo.UseVisualStyleBackColor = true
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Location = New System.Drawing.Point(179, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Step"
        '
        'txtInsertStep
        '
        Me.txtInsertStep.Location = New System.Drawing.Point(214, 25)
        Me.txtInsertStep.Name = "txtInsertStep"
        Me.txtInsertStep.Size = New System.Drawing.Size(60, 20)
        Me.txtInsertStep.TabIndex = 27
        Me.txtInsertStep.Text = "1"
        '
        'NumberInserter
        '
        Me.AcceptButton = Me.btnInsertGo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(286, 97)
        Me.Controls.Add(Me.txtInsertStep)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInsertGo)
        Me.Controls.Add(Me.txtInsertFrom)
        Me.Controls.Add(Me.txtInsertSeperator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInsertTo)
        Me.Name = "NumberInserter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NumberInserter"
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents txtInsertFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInsertTo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInsertSeperator As System.Windows.Forms.TextBox
    Friend WithEvents btnInsertGo As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtInsertStep As System.Windows.Forms.TextBox
End Class
