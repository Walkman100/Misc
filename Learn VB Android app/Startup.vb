Public Class Startup

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim newfrm = New BasicCalculator
        newfrm.Show()
    End Sub

    Private Sub btnCountsTotals_Click(sender As Object, e As EventArgs) Handles btnCountsTotals.Click
        Dim newfrm = New CountsTotals
        newfrm.Show()
    End Sub

    Private Sub btnMaths_Click(sender As Object, e As EventArgs) Handles btnMaths.Click
        Dim newfrm = New Maths
        newfrm.Show()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        Dim newfrm = New TimeConverter
        newfrm.Show()
    End Sub

    Private Sub btnInserter_Click(sender As Object, e As EventArgs) Handles btnInserter.Click
        Dim newfrm = New NumberInserter
        newfrm.Show()
    End Sub

    Private Sub btnSteam_Click(sender As Object, e As EventArgs) Handles btnSteam.Click
        Dim newfrm = New SteamIDLinker
        newfrm.Show()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        Dim newfrm = New ListBox
        newfrm.Show()
    End Sub

    Private Sub btnVars_Click(sender As Object, e As EventArgs) Handles btnVars.Click
        Dim newfrm = New Variables
        newfrm.Show()
    End Sub

    Private Sub btnArrays_Click(sender As Object, e As EventArgs) Handles btnArrays.Click
        Dim newfrm = New Arrays
        newfrm.Show()
    End Sub

    Private Sub btnGitUpdater_Click(sender As Object, e As EventArgs) Handles btnGitUpdater.Click
        Dim newfrm = New GitUpdater
        newfrm.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim newfrm = New Test
        newfrm.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class