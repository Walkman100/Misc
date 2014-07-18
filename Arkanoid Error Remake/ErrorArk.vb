Public Class ErrorArk
    Dim score As Integer = 0
    Dim facing as byte = 0 '0 is NE, 1 is SE, 2 is SW, 3 is NW
    
    Sub Button_Click(sender As Object, e As EventArgs)
        ' play error sound
        ResetGUI
    End Sub
    
    Sub ResetGUI
        ThreadBouncer.CancelAsync
        imgError.Location.X = 12
        imgError.Location.Y = 12
        button.Location.X = 131
        button.Location.Y = 87
        facing = 1
        score = 0
        lblScore.Text = "0"
        Me.Text = ""
    End Sub
    
    Sub ErrorArk_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = "{SPACE}" Then
            ResetGUI
            ThreadBouncer.RunWorkerAsync
        ElseIf e.KeyChar = "{LEFT}" Then
            button.Location.X = button.Location.X - 1
        ElseIf e.KeyChar = "{RIGHT}" Then
            button.Location.X = button.Location.X + 1
        End If
    End Sub
    
    Sub ThreadBouncer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs)
        Select Case facing
            Case = 0
                imgError.Location.X = imgError.Location.X + 1
                imgError.Location.Y = imgError.Location.Y + 1
                'If touching top border then
                '    facing = 1
                'ElseIf touching right border then
                '    facing = 3
                'End If
            Case = 1
                imgError.Location.X = imgError.Location.X + 1
                imgError.Location.Y = imgError.Location.Y - 1
                'If touching button then
                '    facing = 0
                'End If
            Case = 2
                imgError.Location.X = imgError.Location.X - 1
                imgError.Location.Y = imgError.Location.Y - 1
                'If touching button then
                '    facing = 3
                'End If
            Case = 3
                imgError.Location.X = imgError.Location.X - 1
                imgError.Location.Y = imgError.Location.Y + 1
                'If touching top border then
                '    facing = 2
                'ElseIf touching left border then
                '    facing = 0
                'End If
        End Select
        
    End Sub
End Class
