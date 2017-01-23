Public Class ErrorArk
    Dim score As Integer = 0
    Dim facing as byte = 0 '0 is NE, 1 is SE, 2 is SW, 3 is NW
    
    Sub ResetGUI()
        ' play error sound
        TimerBouncer.Stop()
        imgError.BringToFront()
        imgError.Location = New Size(25, 25)
        button.Location = New Size(131, 87)
        facing = 1
        score = 0
        lblScore.Text = score
        Me.Text = score
    End Sub

    Private Sub button_MouseClick(sender As Object, e As MouseEventArgs) Handles button.MouseClick
        ResetGUI()
    End Sub

    Private Sub ErrorKeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, button.KeyDown
        If e.KeyCode = Keys.Space Then
            ResetGUI()
            TimerBouncer.Start()
        ElseIf e.KeyCode = Keys.Left Then
            button.Location = New Size(button.Location.X - 1, button.Location.Y)
        ElseIf e.KeyCode = Keys.Right Then
            button.Location = New Size(button.Location.X + 1, button.Location.Y)
        End If
    End Sub
    
    Private Sub ErrorKeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress, button.KeyPress
        If e.KeyChar = "{SPACE}" Then
            ResetGUI()
            TimerBouncer.Start()
        ElseIf e.KeyChar = "{LEFT}" Then
            button.Location = New Size(button.Location.X - 1, button.Location.Y)
        ElseIf e.KeyChar = "{RIGHT}" Then
            button.Location = New Size(button.Location.X + 1, button.Location.Y)
        End If
    End Sub

    Private Sub TimerBouncer_Tick(sender As Object, e As EventArgs) Handles TimerBouncer.Tick
        Select Case facing
            Case 0
                imgError.Location = New Size(imgError.Location.X + 1, imgError.Location.Y - 1)
                If Me.Top < 1 Then 'If touching top border Then
                    facing = 1
                ElseIf imgError.Location.X + imgError.Size.Width > Me.Right Then 'ElseIf touching right border Then
                    facing = 2
                End If
            Case 1
                imgError.Location = New Size(imgError.Location.X + 1, imgError.Location.Y + 1)
                'If touching button then
                If imgError.Location.Y + imgError.Size.Height > button.Location.Y Then ' If on same Y value as button Then
                    If imgError.Location.X + imgError.Size.Width > button.Location.X Then ' If on same X value as button Then
                        facing = 0
                    End If
                End If
            Case 2
                imgError.Location = New Size(imgError.Location.X - 1, imgError.Location.Y + 1)
                'If touching button then
                '    facing = 3
                'End If
            Case 3
                imgError.Location = New Size(imgError.Location.X - 1, imgError.Location.Y - 1)
                'If touching top border then
                '    facing = 2
                'ElseIf touching left border then
                '    facing = 0
                'End If
        End Select
    End Sub
End Class