<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Arrays
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
        Me.btnCrash = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'btnCrash
        '
        Me.btnCrash.Location = New System.Drawing.Point(12, 12)
        Me.btnCrash.Name = "btnCrash"
        Me.btnCrash.Size = New System.Drawing.Size(75, 23)
        Me.btnCrash.TabIndex = 0
        Me.btnCrash.Text = "Crash"
        Me.btnCrash.UseVisualStyleBackColor = true
        '
        'Arrays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 476)
        Me.Controls.Add(Me.btnCrash)
        Me.KeyPreview = true
        Me.Name = "Arrays"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrays"
        Me.ResumeLayout(false)
    End Sub
    Private WithEvents btnCrash As System.Windows.Forms.Button
End Class
