Public Class ErrorArk
    Dim score As Integer = 0
    
    Sub Button_Click(sender As Object, e As EventArgs)
        ThreadBouncer.CancelAsync
        ResetGUI
    End Sub
    
    Sub ResetGUI
        imgError.Location.X = 12
        imgError.Location.Y = 12
        button.Location.X = 131
        button.Location.Y = 87
        score = 0
        lblScore.Text = "0"
        Me.Text = ""
    End Sub
End Class
