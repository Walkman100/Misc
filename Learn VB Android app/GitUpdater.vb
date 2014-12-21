Imports System
Imports System.IO

Public Class GitUpdater
    
    Dim usrProfile As String = Environment.GetEnvironmentVariable("USERPROFILE")
    Dim Dir As String = usrProfile & "\Documents\GitHub"
    
    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    
    Sub BtnPopulate_Click(sender As Object, e As EventArgs)
        For Each Repo As String In Directory.GetDirectories(Dir)
            lstDirs.Items.Add(Repo)
        Next
    End Sub
End Class