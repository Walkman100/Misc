Public Class TimeConverter

    Private Sub TimeConverter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbConvertType.SelectedIndex = 0
    End Sub

    Dim ConvertNumber As Double
    Dim tmpIn As String
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        statusLabel.Text = "Convert started..."
        Try
            Select Case cbConvertType.SelectedIndex '02:17:30
                Case 0 ' H:M:S -> S
                    ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                    ConvertNumber = ConvertNumber * 3600
                    tmpIn = txtIn.Text.Substring(txtIn.Text.IndexOf(":") + 1)
                    tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                    ConvertNumber = ConvertNumber + tmpIn * 60
                    ConvertNumber = ConvertNumber + txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1)
                    txtOut.Text = ConvertNumber
                Case 1 ' H:M:S -> M
                    ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                    ConvertNumber = ConvertNumber * 60
                    tmpIn = txtIn.Text.Substring(txtIn.Text.IndexOf(":") + 1)
                    tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                    ConvertNumber = ConvertNumber + tmpIn
                    ConvertNumber = ConvertNumber + (txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1) / 60)
                    txtOut.Text = ConvertNumber
                Case 2 ' H:M:S -> H
                    ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                    tmpIn = txtIn.Text.Substring(txtIn.Text.IndexOf(":") + 1)
                    tmpIn = tmpIn.Remove(tmpIn.IndexOf(":"))
                    ConvertNumber = ConvertNumber + (tmpIn / 60)
                    ConvertNumber = ConvertNumber + (txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1) / 3600)
                    txtOut.Text = ConvertNumber
                Case 3 ' M:S -> S
                    ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                    ConvertNumber = ConvertNumber * 60
                    ConvertNumber = ConvertNumber + txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1)
                    txtOut.Text = ConvertNumber
                Case 4 ' M:S -> M
                    ConvertNumber = txtIn.Text.Remove(txtIn.Text.IndexOf(":"))
                    ConvertNumber = ConvertNumber + (txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1) / 60)
                    txtOut.Text = ConvertNumber
                Case 5 ' M:S -> H
                    ConvertNumber = (txtIn.Text.Remove(txtIn.Text.IndexOf(":")) / 60)
                    ConvertNumber = ConvertNumber + (txtIn.Text.Substring(txtIn.Text.LastIndexOf(":") + 1) / 3600)
                    txtOut.Text = ConvertNumber
                Case 6 ' S -> S
                    txtOut.Text = txtIn.Text
                Case 7 ' S -> M
                    txtOut.Text = txtIn.Text / 60
                Case 8 ' S -> H
                    txtOut.Text = txtIn.Text / 3600
            End Select
            statusLabel.Text = "Converted successfully!"
        Catch ex As Exception
            statusLabel.Text = "Error: " & ex.Message
        End Try
        
    End Sub

    Private Sub btnAutoConvert_Click(sender As Object, e As EventArgs) Handles btnAutoConvert.Click
        statusLabel.Text = "Starting autoconvert..."
        Try
            txtIn.Text = Clipboard.GetText
        Catch ex As Exception
            statusLabel.Text = "Error getting clipboard text: " & ex.Message
            Exit Sub
        End Try
        statusLabel.Text = "Got clipboard text successfully"
        btnConvert_Click(Nothing, Nothing)
        If statusLabel.Text = "Converted successfully!" Then
            Try
                statusLabel.Text = "Copying text..."
                Clipboard.SetText(txtOut.Text)
                statusLabel.Text = "Converted text copied successfully!"
            Catch ex As Exception
                statusLabel.Text = "Error copying converted text to clipboard: " & ex.Message
            End Try
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class