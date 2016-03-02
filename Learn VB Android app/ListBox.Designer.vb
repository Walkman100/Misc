<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListBox
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
        Me.lstList = New System.Windows.Forms.ListBox()
        Me.btnMoveNameOut = New System.Windows.Forms.Button()
        Me.btnMoveNameIn = New System.Windows.Forms.Button()
        Me.btnFillList = New System.Windows.Forms.Button()
        Me.btnDeleteItem = New System.Windows.Forms.Button()
        Me.btnShowIndex = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtIn = New System.Windows.Forms.TextBox()
        Me.txtOut = New System.Windows.Forms.TextBox()
        Me.lblIn = New System.Windows.Forms.Label()
        Me.lblOut = New System.Windows.Forms.Label()
        Me.btnFile = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'lstList
        '
        Me.lstList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
                        Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lstList.FormattingEnabled = true
        Me.lstList.Location = New System.Drawing.Point(12, 12)
        Me.lstList.Name = "lstList"
        Me.lstList.Size = New System.Drawing.Size(120, 95)
        Me.lstList.TabIndex = 0
        '
        'btnMoveNameOut
        '
        Me.btnMoveNameOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveNameOut.Location = New System.Drawing.Point(138, 12)
        Me.btnMoveNameOut.Name = "btnMoveNameOut"
        Me.btnMoveNameOut.Size = New System.Drawing.Size(120, 40)
        Me.btnMoveNameOut.TabIndex = 1
        Me.btnMoveNameOut.Text = "Move Name Out"
        Me.btnMoveNameOut.UseVisualStyleBackColor = true
        '
        'btnMoveNameIn
        '
        Me.btnMoveNameIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnMoveNameIn.Location = New System.Drawing.Point(138, 67)
        Me.btnMoveNameIn.Name = "btnMoveNameIn"
        Me.btnMoveNameIn.Size = New System.Drawing.Size(120, 40)
        Me.btnMoveNameIn.TabIndex = 2
        Me.btnMoveNameIn.Text = "Move Name In"
        Me.btnMoveNameIn.UseVisualStyleBackColor = true
        '
        'btnFillList
        '
        Me.btnFillList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnFillList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnFillList.Location = New System.Drawing.Point(12, 113)
        Me.btnFillList.Name = "btnFillList"
        Me.btnFillList.Size = New System.Drawing.Size(120, 40)
        Me.btnFillList.TabIndex = 3
        Me.btnFillList.Text = "Fill This List"
        Me.btnFillList.UseVisualStyleBackColor = true
        '
        'btnDeleteItem
        '
        Me.btnDeleteItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnDeleteItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeleteItem.Location = New System.Drawing.Point(138, 113)
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.Size = New System.Drawing.Size(120, 40)
        Me.btnDeleteItem.TabIndex = 4
        Me.btnDeleteItem.Text = "Delete Item"
        Me.btnDeleteItem.UseVisualStyleBackColor = true
        '
        'btnShowIndex
        '
        Me.btnShowIndex.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
                        Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnShowIndex.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnShowIndex.Location = New System.Drawing.Point(12, 159)
        Me.btnShowIndex.Name = "btnShowIndex"
        Me.btnShowIndex.Size = New System.Drawing.Size(120, 40)
        Me.btnShowIndex.TabIndex = 5
        Me.btnShowIndex.Text = "Show List Index"
        Me.btnShowIndex.UseVisualStyleBackColor = true
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnClear.Location = New System.Drawing.Point(138, 159)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear List"
        Me.btnClear.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(264, 159)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(120, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Close"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'txtIn
        '
        Me.txtIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtIn.Location = New System.Drawing.Point(264, 87)
        Me.txtIn.Name = "txtIn"
        Me.txtIn.Size = New System.Drawing.Size(120, 20)
        Me.txtIn.TabIndex = 8
        '
        'txtOut
        '
        Me.txtOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.txtOut.Location = New System.Drawing.Point(264, 32)
        Me.txtOut.Name = "txtOut"
        Me.txtOut.Size = New System.Drawing.Size(120, 20)
        Me.txtOut.TabIndex = 9
        '
        'lblIn
        '
        Me.lblIn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblIn.Location = New System.Drawing.Point(264, 67)
        Me.lblIn.Name = "lblIn"
        Me.lblIn.Size = New System.Drawing.Size(120, 17)
        Me.lblIn.TabIndex = 10
        Me.lblIn.Text = "Name In"
        Me.lblIn.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'lblOut
        '
        Me.lblOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.lblOut.Location = New System.Drawing.Point(264, 12)
        Me.lblOut.Name = "lblOut"
        Me.lblOut.Size = New System.Drawing.Size(120, 17)
        Me.lblOut.TabIndex = 11
        Me.lblOut.Text = "Name Out"
        Me.lblOut.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'btnFile
        '
        Me.btnFile.Location = New System.Drawing.Point(264, 113)
        Me.btnFile.Name = "btnFile"
        Me.btnFile.Size = New System.Drawing.Size(120, 40)
        Me.btnFile.TabIndex = 12
        Me.btnFile.Text = "Load from file..."
        Me.btnFile.UseVisualStyleBackColor = true
        '
        'ListBox
        '
        Me.AcceptButton = Me.btnMoveNameIn
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(396, 212)
        Me.Controls.Add(Me.btnFile)
        Me.Controls.Add(Me.lblOut)
        Me.Controls.Add(Me.lblIn)
        Me.Controls.Add(Me.txtOut)
        Me.Controls.Add(Me.txtIn)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnShowIndex)
        Me.Controls.Add(Me.btnDeleteItem)
        Me.Controls.Add(Me.btnFillList)
        Me.Controls.Add(Me.btnMoveNameIn)
        Me.Controls.Add(Me.btnMoveNameOut)
        Me.Controls.Add(Me.lstList)
        Me.HelpButton = true
        Me.KeyPreview = true
        Me.Name = "ListBox"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List Box"
        Me.ResumeLayout(false)
        Me.PerformLayout
    End Sub
    Friend WithEvents btnFile As System.Windows.Forms.Button
    Friend WithEvents lstList As System.Windows.Forms.ListBox
    Friend WithEvents btnMoveNameOut As System.Windows.Forms.Button
    Friend WithEvents btnMoveNameIn As System.Windows.Forms.Button
    Friend WithEvents btnFillList As System.Windows.Forms.Button
    Friend WithEvents btnDeleteItem As System.Windows.Forms.Button
    Friend WithEvents btnShowIndex As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtIn As System.Windows.Forms.TextBox
    Friend WithEvents txtOut As System.Windows.Forms.TextBox
    Friend WithEvents lblIn As System.Windows.Forms.Label
    Friend WithEvents lblOut As System.Windows.Forms.Label

End Class
