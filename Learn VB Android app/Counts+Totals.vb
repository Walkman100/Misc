Public Class CountsTotals

    Private Sub btnDoIt_Click(sender As Object, e As EventArgs) Handles btnDoIt.Click
        txtCount.Text = Val(txtCount.Text) + 1
        txtTotal.Text = Val(txtTotal.Text) + Val(txtInput.Text)
        If Val(txtInput.Text) > Val(txtBiggest.Text) Then txtBiggest.Text = txtInput.Text
        If Val(txtInput.Text) < Val(txtSmallest.Text) Then txtSmallest.Text = txtInput.Text
    End Sub

    Private Sub btnAverage_Click(sender As Object, e As EventArgs) Handles btnAverage.Click
        txtAverage.Text = txtTotal.Text / txtCount.Text
    End Sub

    Private Sub LoadCountsTotals(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCount.Text = "0"
        txtTotal.Text = "0"
        txtBiggest.Text = "0"
        txtSmallest.Text = "9999999999"
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtInput.Text = ""
        txtCount.Text = "0"
        txtTotal.Text = "0"
        txtBiggest.Text = "0"
        txtSmallest.Text = "9999999999"
        txtAverage.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

End Class
