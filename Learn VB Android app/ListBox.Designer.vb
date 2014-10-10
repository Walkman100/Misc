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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListBox))
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
        Me.SuspendLayout()
        '
        'lstList
        '
        resources.ApplyResources(Me.lstList, "lstList")
        Me.lstList.FormattingEnabled = True
        Me.lstList.Name = "lstList"
        '
        'btnMoveNameOut
        '
        resources.ApplyResources(Me.btnMoveNameOut, "btnMoveNameOut")
        Me.btnMoveNameOut.Name = "btnMoveNameOut"
        Me.btnMoveNameOut.UseVisualStyleBackColor = True
        '
        'btnMoveNameIn
        '
        resources.ApplyResources(Me.btnMoveNameIn, "btnMoveNameIn")
        Me.btnMoveNameIn.Name = "btnMoveNameIn"
        Me.btnMoveNameIn.UseVisualStyleBackColor = True
        '
        'btnFillList
        '
        resources.ApplyResources(Me.btnFillList, "btnFillList")
        Me.btnFillList.Name = "btnFillList"
        Me.btnFillList.UseVisualStyleBackColor = True
        '
        'btnDeleteItem
        '
        resources.ApplyResources(Me.btnDeleteItem, "btnDeleteItem")
        Me.btnDeleteItem.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnDeleteItem.Name = "btnDeleteItem"
        Me.btnDeleteItem.UseVisualStyleBackColor = True
        '
        'btnShowIndex
        '
        resources.ApplyResources(Me.btnShowIndex, "btnShowIndex")
        Me.btnShowIndex.Name = "btnShowIndex"
        Me.btnShowIndex.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        resources.ApplyResources(Me.btnClear, "btnClear")
        Me.btnClear.Name = "btnClear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        resources.ApplyResources(Me.btnExit, "btnExit")
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Name = "btnExit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtIn
        '
        resources.ApplyResources(Me.txtIn, "txtIn")
        Me.txtIn.Name = "txtIn"
        '
        'txtOut
        '
        resources.ApplyResources(Me.txtOut, "txtOut")
        Me.txtOut.Name = "txtOut"
        '
        'lblIn
        '
        resources.ApplyResources(Me.lblIn, "lblIn")
        Me.lblIn.Name = "lblIn"
        '
        'lblOut
        '
        resources.ApplyResources(Me.lblOut, "lblOut")
        Me.lblOut.Name = "lblOut"
        '
        'ListBox
        '
        Me.AcceptButton = Me.btnMoveNameIn
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExit
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
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "ListBox"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
