Module SudoCMD
    Dim isFirst As Boolean = True
    Dim ProgramToLaunch As String = ""
    Dim args As String = ""

    Dim objShell As Object = CreateObject("Shell.Application")

    Sub Main()
        For Each s As String In My.Application.CommandLineArgs
            If isFirst Then
                ProgramToLaunch = s
                isFirst = False
            Else
                args = args & s
            End If
        Next

        objShell.ShellExecute(ProgramToLaunch, args, "", "runas")

        Do Until 0 <> 0
            End
        Loop
    End Sub

End Module
