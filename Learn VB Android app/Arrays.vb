Public Class Arrays
    Sub btnCrash_Click() Handles btnCrash.Click
        Do Until My.Computer.Keyboard.CtrlKeyDown
            System.Threading.Thread.Sleep(100)
        Loop
    End Sub
End Class