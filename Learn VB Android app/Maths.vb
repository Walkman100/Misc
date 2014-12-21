﻿Public Class Maths
    Dim InsertFrom As Integer
    Dim InsertTo As Integer
    Dim InsertStep As Integer

    Private Sub txtFactor_TextChanged(sender As Object, e As EventArgs) Handles txtFactor.TextChanged, txtNumber1.TextChanged, txtNumber2.TextChanged, txtNumber3.TextChanged
        txtResult1.Text = txtNumber1.Text / txtFactor.Text
        txtResult2.Text = txtNumber2.Text / txtFactor.Text
        txtResult3.Text = txtNumber3.Text / txtFactor.Text
    End Sub

    Private Sub txtNumber1_Enter(sender As Object, e As EventArgs) Handles txtNumber1.Enter, txtNumber1.Click
        txtNumber1.SelectAll()
    End Sub

    Private Sub txtNumber2_Enter(sender As Object, e As EventArgs) Handles txtNumber2.Enter, txtNumber2.Click
        txtNumber2.SelectAll()
    End Sub

    Private Sub txtNumber3_Enter(sender As Object, e As EventArgs) Handles txtNumber3.Enter, txtNumber3.Click
        txtNumber3.SelectAll()
    End Sub

    Private Sub txtFactor_Enter(sender As Object, e As EventArgs) Handles txtFactor.Enter, txtFactor.Click
        txtFactor.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

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
End Class