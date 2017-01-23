<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class SudoGUI
    Inherits System.Windows.Forms.Form
    Dim isFirst As Boolean = True
    Dim ProgramToLaunch As String = ""
    Dim args As String = ""

    Private Sub Sudo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For Each s As String In My.Application.CommandLineArgs
            If isFirst Then
                ProgramToLaunch = s
                isFirst = False
            Else
                args = args & " " & s
            End If
        Next

        CreateObject("Shell.Application").ShellExecute(ProgramToLaunch, args, "", "runas")

        Do Until 0 <> 0
            Application.Exit()
            End
        Loop
    End Sub
    
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Private components As System.ComponentModel.IContainer
    Private Sub InitializeComponent()
        Me.SuspendLayout
        'SudoGUI
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1, 1)
        Me.ControlBox = false
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.ShowIcon = false
        Me.ShowInTaskbar = false
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(false)
    End Sub
End Class
