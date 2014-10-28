Public Class Maths
    Dim InsertFrom As Integer
    Dim InsertTo As Integer
    Dim InsertStep As Integer

    Private Sub txtFactor_TextChanged(sender As Object, e As EventArgs) Handles txtFactor.TextChanged, txtNumber1.TextChanged, txtNumber2.TextChanged, txtNumber3.TextChanged
        txtResult1.Text = txtNumber1.Text / txtFactor.Text
        txtResult2.Text = txtNumber2.Text / txtFactor.Text
        txtResult3.Text = txtNumber3.Text / txtFactor.Text
    End Sub

    Private Sub txtNumber1_Enter(sender As Object, e As EventArgs) Handles txtNumber1.Enter, txtNumber1.Click
        txtNumber1.SelectAll()
    End Sub

    Private Sub txtNumber2_Enter(sender As Object, e As EventArgs) Handles txtNumber2.Enter, txtNumber2.Click
        txtNumber2.SelectAll()
    End Sub

    Private Sub txtNumber3_Enter(sender As Object, e As EventArgs) Handles txtNumber3.Enter, txtNumber3.Click
        txtNumber3.SelectAll()
    End Sub

    Private Sub txtFactor_Enter(sender As Object, e As EventArgs) Handles txtFactor.Enter, txtFactor.Click
        txtFactor.SelectAll()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub Maths_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbConvertType.SelectedIndex = 0
    End Sub

    Dim ConvertNumber As Double
    Dim tmpIn As String
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Select Case cbConvertType.SelectedIndex '02:17:30
            Case 0 ' H:M:S -> S
                ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                ConvertNumber = ConvertNumber * 3600
                tmpIn = txtIn.Text.Remove(0, txtIn.Text.IndexOf(":") + 1)
                tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                ConvertNumber = ConvertNumber + tmpIn * 60
                ConvertNumber = ConvertNumber + txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1)
                txtOut.Text = ConvertNumber
            Case 1 ' H:M:S -> M
                ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                ConvertNumber = ConvertNumber * 60
                tmpIn = txtIn.Text.Remove(0, txtIn.Text.IndexOf(":") + 1)
                tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                ConvertNumber = ConvertNumber + tmpIn
                ConvertNumber = ConvertNumber + (txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1) / 60)
                txtOut.Text = ConvertNumber
            Case 2 ' H:M:S -> H
                ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                tmpIn = txtIn.Text.Remove(0, txtIn.Text.IndexOf(":") + 1)
                tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                ConvertNumber = ConvertNumber + (tmpIn / 60)
                ConvertNumber = ConvertNumber + (txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1) / 3600)
                txtOut.Text = ConvertNumber
            Case 3 ' M:S -> S
                ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                ConvertNumber = ConvertNumber * 60
                ConvertNumber = ConvertNumber + txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1)
                txtOut.Text = ConvertNumber
            Case 4 ' M:S -> M
                ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                ConvertNumber = ConvertNumber + (txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1) / 60)
                txtOut.Text = ConvertNumber
            Case 5 ' M:S -> H
                ConvertNumber = (txtIn.Text.Remove(txtIn.Text.IndexOf(":")) / 60)
                ConvertNumber = ConvertNumber + (txtIn.Text.Remove(0, txtIn.Text.LastIndexOf(":") + 1) / 3600)
                txtOut.Text = ConvertNumber
            Case 6 ' S -> S
                txtOut.Text = txtIn.Text
            Case 7 ' S -> M
                txtOut.Text = txtIn.Text / 60
            Case 8 ' S -> H
                txtOut.Text = txtIn.Text / 3600
        End Select
    End Sub

    Private Sub btnAutoConvert_Click(sender As Object, e As EventArgs) Handles btnAutoConvert.Click
        txtIn.Text = Clipboard.GetText
        btnConvert_Click(Nothing, Nothing)
        Clipboard.SetText(txtOut.Text)
    End Sub

    Private Sub btnInsertGo_Click(sender As Object, e As EventArgs) Handles btnInsertGo.Click
        InsertFrom = txtInsertFrom.Text
        InsertTo = txtInsertTo.Text
        InsertStep = txtInsertStep.Text

        Me.WindowState = FormWindowState.Minimized
        For i = InsertFrom To InsertTo Step InsertStep
            SendKeys.Send(i)
            SendKeys.Send(txtInsertSeperator.Text)
        Next
    End Sub
End Class