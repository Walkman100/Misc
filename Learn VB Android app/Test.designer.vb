<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test
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
        Me.cmdHello = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'cmdHello
        '
        Me.cmdHello.Location = New System.Drawing.Point(13, 76)
        Me.cmdHello.Name = "cmdHello"
        Me.cmdHello.Size = New System.Drawing.Size(75, 23)
        Me.cmdHello.TabIndex = 0
        Me.cmdHello.Text = "Click Me!"
        Me.cmdHello.UseVisualStyleBackColor = true
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(197, 227)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "Close"
        Me.cmdExit.UseVisualStyleBackColor = true
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = true
        Me.lblHelloWorld.Location = New System.Drawing.Point(156, 81)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(61, 13)
        Me.lblHelloWorld.TabIndex = 2
        Me.lblHelloWorld.Text = "BeforeClick"
        '
        'Test
        '
        Me.AcceptButton = Me.cmdHello
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdHello)
        Me.Name = "Test"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestSolution"
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents cmdHello As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents lblHelloWorld As System.Windows.Forms.Label

End Class
