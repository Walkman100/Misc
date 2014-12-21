Public Class BasicCalculator

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtOutput.Text = Val(txtInOne.Text) + Val(txtInTwo.Text)
        lblOp.Text = "+"
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        txtOutput.Text = Val(txtInOne.Text) - Val(txtInTwo.Text)
        lblOp.Text = "-"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        txtOutput.Text = Val(txtInOne.Text) / Val(txtInTwo.Text)
        lblOp.Text = "/"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtOutput.Text = Val(txtInOne.Text) * Val(txtInTwo.Text)
        lblOp.Text = "*"
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
