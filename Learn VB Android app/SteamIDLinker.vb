Public Class SteamIDLinker
    Private Sub MsgNoGameID()
        MsgBox("Please fill in a Game ID!", MsgBoxStyle.Critical, "No Game ID entered")
        Me.BringToFront()
        cbSteamGameID.SelectAll()
    End Sub

    Private Sub cbSteamGameID_TextChanged(sender As Object, e As EventArgs) Handles cbSteamGameID.TextChanged
        If cbSteamGameID.Text = "Game ID" Or cbSteamGameID.Text = "" Or Len(cbSteamGameID.Text) < 2 Then
            imgLoading.Visible = False
            lblGameName.Text = "Enter a Game ID above"
        Else
            WebBrowserGamePage.Navigate("http://store.steampowered.com/app/" & cbSteamGameID.Text & "/")
            imgLoading.Visible = True
            lblGameName.Text = "      Loading..."
            btnRun.Enabled = True
            btnRunGameID.Enabled = True
            btnInstall.Enabled = True
            imgGameImage.ImageLocation = "http://cdn.akamai.steamstatic.com/steam/apps/" & cbSteamGameID.Text & "/header.jpg"
        End If
    End Sub

    Private Sub WebBrowserGamePage_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowserGamePage.DocumentCompleted
        imgLoading.Visible = False
        If WebBrowserGamePage.Url.ToString = "http://store.steampowered.com/" Then
            lblGameName.Text = "Not found! Please make sure you entered a valid Video ID"
        Else
            lblGameName.Text = WebBrowserGamePage.DocumentTitle
        End If
    End Sub
    
    Private Sub cbSteamGameID_Enter(sender As Object, e As EventArgs) Handles cbSteamGameID.MouseDown
        If cbSteamGameID.Text = "Game ID" Then
            cbSteamGameID.Text = ""
        Else
            cbSteamGameID.SelectAll()
        End If
    End Sub

    Private Sub txtComboVID_Leave(sender As Object, e As EventArgs) Handles cbSteamGameID.Leave
        If cbSteamGameID.Text = "" Then
            cbSteamGameID.Text = "Game ID"
        ElseIf cbSteamGameID.Text <> "Game ID" Then
            If Not cbSteamGameID.Items.Contains(cbSteamGameID.Text) Then
                cbSteamGameID.Items.Add(cbSteamGameID.Text)
            End If
        End If
    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click
        If cbSteamGameID.Text = "Game ID" Or cbSteamGameID.Text = "" Then
            MsgNoGameID()
        Else
            MsgBox("steam://run/" & cbSteamGameID.Text)
        End If
    End Sub

    Private Sub btnRunGameID_Click(sender As Object, e As EventArgs) Handles btnRunGameID.Click
        If cbSteamGameID.Text = "Game ID" Or cbSteamGameID.Text = "" Then
            MsgNoGameID()
        Else
            MsgBox("steam://rungameid/" & cbSteamGameID.Text)
        End If
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        If cbSteamGameID.Text = "Game ID" Or cbSteamGameID.Text = "" Then
            MsgNoGameID()
        Else
            MsgBox("steam://install/" & cbSteamGameID.Text)
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub imgGameImage_Click(sender As Object, e As EventArgs) Handles imgGameImage.Click
        Try
            Process.Start("http://cdn.akamai.steamstatic.com/steam/apps/" & cbSteamGameID.Text & "/header.jpg")
        Catch ex As Exception
            If MsgBox("Unable to launch URL, copy to clipboard instead?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then Clipboard.SetText("http://cdn.akamai.steamstatic.com/steam/apps/" & cbSteamGameID.Text & "/header.jpg")
        End Try
    End Sub
End Class