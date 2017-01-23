Public Class Variables
    Dim Num1 As Integer
    Dim Num2 As Integer
    Dim Answer As Integer

    Private Sub btnInput1_Click(sender As Object, e As EventArgs) Handles btnInput1.Click
        Num1 = InputBox("Please type an integer")
    End Sub

    Private Sub btnInput2_Click(sender As Object, e As EventArgs) Handles btnInput2.Click
        Num2 = InputBox("Please type another integer")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Answer = Num1 + Num2
    End Sub

    Private Sub btnShowAnswer_Click(sender As Object, e As EventArgs) Handles btnShowAnswer.Click
        MsgBox("Answer is " & Answer)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class