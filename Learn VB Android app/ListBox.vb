﻿Public Class ListBox

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

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class