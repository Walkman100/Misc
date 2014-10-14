<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorArk
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
        Me.components = New System.ComponentModel.Container()
        Me.button = New System.Windows.Forms.Button()
        Me.imgError = New System.Windows.Forms.PictureBox()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.TimerBouncer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button
        '
        Me.button.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.button.Location = New System.Drawing.Point(131, 87)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(75, 23)
        Me.button.TabIndex = 0
        Me.button.TabStop = False
        Me.button.Text = "OK"
        Me.button.UseVisualStyleBackColor = True
        Me.button.UseWaitCursor = True
        '
        'imgError
        '
        Me.imgError.Image = Global.ErrorArk.My.Resources.Resources._100x100_broken_image
        Me.imgError.Location = New System.Drawing.Point(12, 12)
        Me.imgError.Name = "imgError"
        Me.imgError.Size = New System.Drawing.Size(50, 50)
        Me.imgError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgError.TabIndex = 1
        Me.imgError.TabStop = False
        Me.imgError.UseWaitCursor = True
        '
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.Location = New System.Drawing.Point(68, 29)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(204, 13)
        Me.lblError.TabIndex = 2
        Me.lblError.Text = "memory.dll: all alloc attempts failed for size"
        Me.lblError.UseWaitCursor = True
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(271, 30)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(14, 13)
        Me.lblScore.TabIndex = 3
        Me.lblScore.Text = "0"
        Me.lblScore.UseWaitCursor = True
        '
        'TimerBouncer
        '
        '
        'ErrorArk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 122)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.imgError)
        Me.Controls.Add(Me.button)
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorArk"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.UseWaitCursor = True
        CType(Me.imgError, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblScore As System.Windows.Forms.Label
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents imgError As System.Windows.Forms.PictureBox
    Friend WithEvents button As System.Windows.Forms.Button
    Friend WithEvents TimerBouncer As System.Windows.Forms.Timer

End Class
