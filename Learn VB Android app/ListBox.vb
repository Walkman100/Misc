Public Class ListBox
    
    Private Sub lstList_DoubleClick(sender As Object, e As EventArgs) Handles lstList.DoubleClick
        lstList.Sorted = True
        lstList.Sorted = False
    End Sub
    
    Private Sub btnFillList_Click(sender As Object, e As EventArgs) Handles btnFillList.Click
        lstList.Items.Add("Jane")
        lstList.Items.Add("Dai")
        lstList.Items.Add("Fred")
    End Sub

    Private Sub btnShowIndex_Click(sender As Object, e As EventArgs) Handles btnShowIndex.Click
        If lstList.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            MsgBox(lstList.SelectedIndex)
        End If
    End Sub

    Private Sub btnMoveNameOut_Click(sender As Object, e As EventArgs) Handles btnMoveNameOut.Click
        If lstList.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            txtOut.Text = lstList.Text
            lstList.Items.RemoveAt(lstList.SelectedIndex)
        End If
    End Sub

    Private Sub btnMoveNameIn_Click(sender As Object, e As EventArgs) Handles btnMoveNameIn.Click
        If txtIn.Text = "" Then
            MsgBox("Nothing to add!")
        Else
            lstList.Items.Add(txtIn.Text)
            txtIn.Text = ""
        End If

    End Sub

    Private Sub btnDeleteItem_Click(sender As Object, e As EventArgs) Handles btnDeleteItem.Click
        If lstList.SelectedIndex = -1 Then
            MsgBox("No item selected")
        Else
            lstList.Items.RemoveAt(lstList.SelectedIndex)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstList.Items.Clear()
    End Sub
    
    Dim selectFile As New OpenFileDialog
    Private Sub btnFile_Click(sender As Object, e As EventArgs) Handles btnFile.Click
        selectFile.Title = "Select a file to load:"
        selectFile.DefaultExt = ".txt"
        selectFile.Filter = "Text files|*.txt; *.text|All Files|*.*"
        selectFile.ReadOnlyChecked = True
        If selectFile.InitialDirectory = "" Then selectFile.InitialDirectory = Application.StartupPath
        If selectFile.ShowDialog() = DialogResult.OK Then
            For Each line As String In File.ReadAllLines(selectFile.FileName)
                lstList.Items.Add(line)
            Next
        End If
    End Sub
    
    Dim saveFile As New SaveFileDialog
    Private Sub btnFile_MouseClick(sender As Object, e As MouseEventArgs) Handles btnFile.MouseDown
        If e.Button = MouseButtons.Right Then
            saveFile.Title = "Select where to save:"
            saveFile.DefaultExt = ".txt"
            saveFile.Filter = "Text files|*.txt; *.text|All Files|*.*"
            saveFile.FileName = selectFile.FileName
            If saveFile.ShowDialog() = DialogResult.OK Then
                File.WriteAllLines(saveFile.FileName, lstList.Items.OfType(Of String)())
            End If
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
