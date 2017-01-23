<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeConverter
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
        Me.lblIn = New System.Windows.Forms.Label()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.cbConvertType = New System.Windows.Forms.ComboBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnAutoConvert = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.statusStrip = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.statusStrip.SuspendLayout
        Me.SuspendLayout
        '
        'lblIn
        '
        Me.lblIn.AutoSize = true
        Me.lblIn.Location = New System.Drawing.Point(12, 9)
        Me.lblIn.Name = "lblIn"
        Me.lblIn.Size = New System.Drawing.Size(34, 13)
        Me.lblIn.TabIndex = 13
        Me.lblIn.Text = "Input:"
        '
        'txtIn
        '
        Me.txtIn.Location = New System.Drawing.Point(12, 25)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(100, 20)
        Me.txtIn.TabIndex = 11
        '
        'txtOut
        '
        Me.txtOut.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOut.Location = New System.Drawing.Point(228, 25)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(137, 20)
        Me.txtOut.TabIndex = 12
        '
        'lblOut
        '
        Me.lblOut.AutoSize = true
        Me.lblOut.Location = New System.Drawing.Point(227, 9)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(42, 13)
        Me.lblOut.TabIndex = 14
        Me.lblOut.Text = "Output:"
        '
        'cbConvertType
        '
        Me.cbConvertType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbConvertType.FormattingEnabled = true
        Me.cbConvertType.Items.AddRange(New Object() {"H:M:S -> S", "H:M:S -> M", "H:M:S -> H", "M:S -> S", "M:S -> M", "M:S -> H", "S -> S", "S -> M", "S -> H"})
        Me.cbConvertType.Location = New System.Drawing.Point(118, 25)
        Me.cbConvertType.Name = "cbConvertType"
        Me.cbConvertType.Size = New System.Drawing.Size(104, 21)
        Me.cbConvertType.TabIndex = 16
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(210, 50)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 17
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = true
        '
        'btnAutoConvert
        '
        Me.btnAutoConvert.AutoSize = true
        Me.btnAutoConvert.Location = New System.Drawing.Point(12, 50)
        Me.btnAutoConvert.Name = "btnAutoConvert"
        Me.btnAutoConvert.Size = New System.Drawing.Size(192, 23)
        Me.btnAutoConvert.TabIndex = 18
        Me.btnAutoConvert.Text = "Get clipboard text, convert then copy"
        Me.btnAutoConvert.UseVisualStyleBackColor = true
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(291, 50)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 19
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'statusStrip
        '
        Me.statusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.statusStrip.Location = New System.Drawing.Point(0, 76)
        Me.statusStrip.Name = "statusStrip"
        Me.statusStrip.Size = New System.Drawing.Size(377, 22)
        Me.statusStrip.TabIndex = 20
        Me.statusStrip.Text = "statusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(43, 17)
        Me.statusLabel.Text = "Ready"
        '
        'TimeConverter
        '
        Me.AcceptButton = Me.btnConvert
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(377, 98)
        Me.Controls.Add(Me.statusStrip)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblIn)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.cbConvertType)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnAutoConvert)
        Me.Name = "TimeConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TimeConverter"
        Me.statusStrip.ResumeLayout(false)
        Me.statusStrip.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Private statusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private statusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents lblIn As System.Windows.Forms.Label
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents lblOut As System.Windows.Forms.Label
    Friend WithEvents cbConvertType As System.Windows.Forms.ComboBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnAutoConvert As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
