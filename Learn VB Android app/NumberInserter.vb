Public Class NumberInserter
    Dim InsertFrom As Integer
    Dim InsertTo As Integer
    Dim InsertStep As Integer

    Private Sub btnInsertGo_Click(sender As Object, e As EventArgs) Handles btnInsertGo.Click
        InsertFrom = txtInsertFrom.Text
        InsertTo = txtInsertTo.Text
        InsertStep = txtInsertStep.Text

        Me.WindowState = FormWindowState.Minimized
        For i = InsertFrom To InsertTo Step InsertStep
            SendKeys.Send(i)
            SendKeys.Send(txtInsertSeperator.Text)
        Next
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class