Public Class ErrorArk
    Dim score As Integer = 0
    Dim facing as byte = 0 '0 is NE, 1 is SE, 2 is SW, 3 is NW
    
    Sub ResetGUI()
        ThreadBouncer.CancelAsync()
        imgError.Location = New Size(12, 12)
        button.Location = New Size(131, 87)
        facing = 1
        score = 0
        lblScore.Text = "0"
        Me.Text = ""
    End Sub

    Sub Button_Click(sender As Object, e As EventArgs) Handles button.Click
        ' play error sound
        ResetGUI()
        ThreadBouncer.RunWorkerAsync()
    End Sub

    Private Sub ErrorArk_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        ResetGUI()
        ThreadBouncer.RunWorkerAsync()
    End Sub

    Private Sub ErrorArk_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            Button_Click(Nothing, Nothing)
        ElseIf e.KeyCode = Keys.Left Then
            button.Location = New Size(button.Location.X - 1, button.Location.Y)
        ElseIf e.KeyCode = Keys.Right Then
            button.Location = New Size(button.Location.X + 1, button.Location.Y)
        End If
    End Sub
    
    Sub ErrorArk_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = "{SPACE}" Then
            Button_Click(Nothing, Nothing)
        ElseIf e.KeyChar = "{LEFT}" Then
            button.Location = New Size(button.Location.X - 1, button.Location.Y)
        ElseIf e.KeyChar = "{RIGHT}" Then
            button.Location = New Size(button.Location.X + 1, button.Location.Y)
        End If
    End Sub
    
    Sub ThreadBouncer_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles ThreadBouncer.DoWork
        Select Case facing
            Case 0
                imgError.Location = New Size(imgError.Location.X + 1, imgError.Location.Y + 1)
                'If touching top border then
                '    facing = 1
                'ElseIf touching right border then
                '    facing = 3
                'End If
            Case 1
                imgError.Location = New Size(imgError.Location.X + 1, imgError.Location.Y - 1)
                'If touching button then
                '    facing = 0
                'End If
            Case 2
                imgError.Location = New Size(imgError.Location.X - 1, imgError.Location.Y - 1)
                'If touching button then
                '    facing = 3
                'End If
            Case 3
                imgError.Location = New Size(imgError.Location.X - 1, imgError.Location.Y + 1)
                'If touching top border then
                '    facing = 2
                'ElseIf touching left border then
                '    facing = 0
                'End If
        End Select

    End Sub
End Class
