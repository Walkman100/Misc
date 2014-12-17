Public Class Sudo
    Dim isFirst As Boolean = True
    Dim ProgramToLaunch As String = ""
    Dim args As String = ""

    Dim objShell As Object = CreateObject("Shell.Application")

    Private Sub Sudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Application.Exit()
            End
        Loop
    End Sub
End Class
