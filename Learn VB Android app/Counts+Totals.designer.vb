<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountsTotals
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
        Me.lblInput = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnDoIt = New System.Windows.Forms.Button()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.txtCount = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.lblSmallest = New System.Windows.Forms.Label()
        Me.txtSmallest = New System.Windows.Forms.TextBox()
        Me.lblBiggest = New System.Windows.Forms.Label()
        Me.txtBiggest = New System.Windows.Forms.TextBox()
        Me.btnAverage = New System.Windows.Forms.Button()
        Me.txtAverage = New System.Windows.Forms.TextBox()
        Me.lblAverage = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblInput
        '
        Me.lblInput.Location = New System.Drawing.Point(12, 9)
        Me.lblInput.Name = "lblInput"
        Me.lblInput.Size = New System.Drawing.Size(100, 13)
        Me.lblInput.TabIndex = 0
        Me.lblInput.Text = "Input"
        Me.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtInput
        '
        Me.txtInput.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtInput.Location = New System.Drawing.Point(12, 25)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(100, 20)
        Me.txtInput.TabIndex = 1
        '
        'btnDoIt
        '
        Me.btnDoIt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDoIt.Location = New System.Drawing.Point(27, 51)
        Me.btnDoIt.Name = "btnDoIt"
        Me.btnDoIt.Size = New System.Drawing.Size(75, 23)
        Me.btnDoIt.TabIndex = 2
        Me.btnDoIt.Text = "Do It"
        Me.btnDoIt.UseVisualStyleBackColor = True
        '
        'lblCount
        '
        Me.lblCount.Location = New System.Drawing.Point(178, 9)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(100, 13)
        Me.lblCount.TabIndex = 3
        Me.lblCount.Text = "Count"
        Me.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCount
        '
        Me.txtCount.Location = New System.Drawing.Point(178, 25)
        Me.txtCount.Name = "txtCount"
        Me.txtCount.Size = New System.Drawing.Size(100, 20)
        Me.txtCount.TabIndex = 4
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.Location = New System.Drawing.Point(284, 9)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 13)
        Me.lblTotal.TabIndex = 5
        Me.lblTotal.Text = "Total"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotal.Location = New System.Drawing.Point(284, 25)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 6
        '
        'lblSmallest
        '
        Me.lblSmallest.Location = New System.Drawing.Point(178, 48)
        Me.lblSmallest.Name = "lblSmallest"
        Me.lblSmallest.Size = New System.Drawing.Size(100, 13)
        Me.lblSmallest.TabIndex = 7
        Me.lblSmallest.Text = "Smallest"
        Me.lblSmallest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSmallest
        '
        Me.txtSmallest.Location = New System.Drawing.Point(178, 64)
        Me.txtSmallest.Name = "txtSmallest"
        Me.txtSmallest.Size = New System.Drawing.Size(100, 20)
        Me.txtSmallest.TabIndex = 8
        '
        'lblBiggest
        '
        Me.lblBiggest.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBiggest.Location = New System.Drawing.Point(284, 48)
        Me.lblBiggest.Name = "lblBiggest"
        Me.lblBiggest.Size = New System.Drawing.Size(100, 13)
        Me.lblBiggest.TabIndex = 9
        Me.lblBiggest.Text = "Biggest"
        Me.lblBiggest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBiggest
        '
        Me.txtBiggest.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBiggest.Location = New System.Drawing.Point(284, 64)
        Me.txtBiggest.Multiline = True
        Me.txtBiggest.Name = "txtBiggest"
        Me.txtBiggest.Size = New System.Drawing.Size(100, 20)
        Me.txtBiggest.TabIndex = 10
        '
        'btnAverage
        '
        Me.btnAverage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAverage.Location = New System.Drawing.Point(12, 118)
        Me.btnAverage.Name = "btnAverage"
        Me.btnAverage.Size = New System.Drawing.Size(75, 23)
        Me.btnAverage.TabIndex = 11
        Me.btnAverage.Text = "Average"
        Me.btnAverage.UseVisualStyleBackColor = True
        '
        'txtAverage
        '
        Me.txtAverage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAverage.Location = New System.Drawing.Point(93, 120)
        Me.txtAverage.Name = "txtAverage"
        Me.txtAverage.Size = New System.Drawing.Size(100, 20)
        Me.txtAverage.TabIndex = 12
        '
        'lblAverage
        '
        Me.lblAverage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAverage.Location = New System.Drawing.Point(93, 104)
        Me.lblAverage.Name = "lblAverage"
        Me.lblAverage.Size = New System.Drawing.Size(100, 13)
        Me.lblAverage.TabIndex = 13
        Me.lblAverage.Text = "Average"
        Me.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(309, 118)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 14
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnReset.Location = New System.Drawing.Point(309, 89)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 15
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'CountsTotals
        '
        Me.AcceptButton = Me.btnDoIt
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(396, 153)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblAverage)
        Me.Controls.Add(Me.txtAverage)
        Me.Controls.Add(Me.btnAverage)
        Me.Controls.Add(Me.txtBiggest)
        Me.Controls.Add(Me.lblBiggest)
        Me.Controls.Add(Me.txtSmallest)
        Me.Controls.Add(Me.lblSmallest)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.txtCount)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.btnDoIt)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInput)
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "CountsTotals"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CountsTotals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblInput As System.Windows.Forms.Label
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnDoIt As System.Windows.Forms.Button
    Friend WithEvents lblCount As System.Windows.Forms.Label
    Friend WithEvents txtCount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents lblSmallest As System.Windows.Forms.Label
    Friend WithEvents txtSmallest As System.Windows.Forms.TextBox
    Friend WithEvents lblBiggest As System.Windows.Forms.Label
    Friend WithEvents txtBiggest As System.Windows.Forms.TextBox
    Friend WithEvents btnAverage As System.Windows.Forms.Button
    Friend WithEvents txtAverage As System.Windows.Forms.TextBox
    Friend WithEvents lblAverage As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

End Class
