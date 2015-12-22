Public Class Arrays
    Sub btnCrash_Click() Handles btnCrash.Click
        Do Until 0 <> 0
            System.Threading.Thread.Sleep(1000)
        Loop
    End Sub
End Class