Public Class Startup

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        BasicCalculator.Show()
    End Sub

    Private Sub btnCountsTotals_Click(sender As Object, e As EventArgs) Handles btnCountsTotals.Click
        CountsTotals.Show()
    End Sub

    Private Sub btnMaths_Click(sender As Object, e As EventArgs) Handles btnMaths.Click
        Maths.Show()
    End Sub

    Private Sub btnTime_Click(sender As Object, e As EventArgs) Handles btnTime.Click
        TimeConverter.Show()
    End Sub

    Private Sub btnInserter_Click(sender As Object, e As EventArgs) Handles btnInserter.Click
        NumberInserter.Show()
    End Sub

    Private Sub btnSteam_Click(sender As Object, e As EventArgs) Handles btnSteam.Click
        SteamIDLinker.Show()
    End Sub

    Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
        ListBox.Show()
    End Sub

    Private Sub btnVars_Click(sender As Object, e As EventArgs) Handles btnVars.Click
        Variables.Show()
    End Sub

    Private Sub btnArrays_Click(sender As Object, e As EventArgs) Handles btnArrays.Click
        Arrays.Show()
    End Sub

    Private Sub btnGitUpdater_Click(sender As Object, e As EventArgs) Handles btnGitUpdater.Click
        GitUpdater.Show()
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Test.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class