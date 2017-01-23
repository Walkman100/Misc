Public Class Test


    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmdHello_Click(sender As Object, e As EventArgs) Handles cmdHello.Click
        lblHelloWorld.Text = "AfterClick!"
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class
