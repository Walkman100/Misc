<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SteamIDLinker
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SteamIDLinker))
        Me.cbSteamGameID = New System.Windows.Forms.ComboBox()
        Me.imgLoading = New System.Windows.Forms.PictureBox()
        Me.lblGameName = New System.Windows.Forms.Label()
        Me.imgGameImage = New System.Windows.Forms.PictureBox()
        Me.btnRun = New System.Windows.Forms.Button()
        Me.btnRunGameID = New System.Windows.Forms.Button()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.WebBrowserGamePage = New System.Windows.Forms.WebBrowser()
        CType(Me.imgLoading, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.imgGameImage, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'cbSteamGameID
        '
        Me.cbSteamGameID.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbSteamGameID.Items.AddRange(New Object() {"60", "220", "440", "620", "730"})
        Me.cbSteamGameID.Location = New System.Drawing.Point(12, 12)
        Me.cbSteamGameID.MaxDropDownItems = 50
        Me.cbSteamGameID.Name = "cbSteamGameID"
        Me.cbSteamGameID.Size = New System.Drawing.Size(461, 21)
        Me.cbSteamGameID.TabIndex = 0
        Me.cbSteamGameID.Text = "Game ID"
        '
        'imgLoading
        '
        Me.imgLoading.Image = CType(resources.GetObject("imgLoading.Image"), System.Drawing.Image)
        Me.imgLoading.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.imgLoading.Location = New System.Drawing.Point(12, 37)
        Me.imgLoading.Name = "imgLoading"
        Me.imgLoading.Size = New System.Drawing.Size(17, 17)
        Me.imgLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.imgLoading.TabIndex = 47
        Me.imgLoading.TabStop = false
        '
        'lblGameName
        '
        Me.lblGameName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGameName.AutoEllipsis = true
        Me.lblGameName.Location = New System.Drawing.Point(12, 40)
        Me.lblGameName.Name = "lblGameName"
        Me.lblGameName.Size = New System.Drawing.Size(461, 14)
        Me.lblGameName.TabIndex = 48
        Me.lblGameName.Text = "Enter a Game ID above"
        '
        'imgGameImage
        '
        Me.imgGameImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.imgGameImage.ImageLocation = ""
        Me.imgGameImage.InitialImage = CType(resources.GetObject("imgGameImage.InitialImage"), System.Drawing.Image)
        Me.imgGameImage.Location = New System.Drawing.Point(12, 89)
        Me.imgGameImage.Name = "imgGameImage"
        Me.imgGameImage.Size = New System.Drawing.Size(460, 215)
        Me.imgGameImage.TabIndex = 0
        Me.imgGameImage.TabStop = false
        '
        'btnRun
        '
        Me.btnRun.Enabled = false
        Me.btnRun.Location = New System.Drawing.Point(12, 60)
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(75, 23)
        Me.btnRun.TabIndex = 49
        Me.btnRun.Text = "Run"
        Me.btnRun.UseVisualStyleBackColor = true
        '
        'btnRunGameID
        '
        Me.btnRunGameID.Enabled = false
        Me.btnRunGameID.Location = New System.Drawing.Point(93, 60)
        Me.btnRunGameID.Name = "btnRunGameID"
        Me.btnRunGameID.Size = New System.Drawing.Size(75, 23)
        Me.btnRunGameID.TabIndex = 50
        Me.btnRunGameID.Text = "RunGameID"
        Me.btnRunGameID.UseVisualStyleBackColor = true
        '
        'btnInstall
        '
        Me.btnInstall.Enabled = false
        Me.btnInstall.Location = New System.Drawing.Point(174, 60)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(75, 23)
        Me.btnInstall.TabIndex = 51
        Me.btnInstall.Text = "Install"
        Me.btnInstall.UseVisualStyleBackColor = true
        '
        'btnClose
        '
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(255, 60)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 52
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = true
        '
        'WebBrowserGamePage
        '
        Me.WebBrowserGamePage.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowserGamePage.Location = New System.Drawing.Point(12, 310)
        Me.WebBrowserGamePage.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowserGamePage.Name = "WebBrowserGamePage"
        Me.WebBrowserGamePage.ScriptErrorsSuppressed = true
        Me.WebBrowserGamePage.Size = New System.Drawing.Size(461, 377)
        Me.WebBrowserGamePage.TabIndex = 53
        '
        'SteamIDLinker
        '
        Me.AcceptButton = Me.btnInstall
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(485, 699)
        Me.Controls.Add(Me.WebBrowserGamePage)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.btnRunGameID)
        Me.Controls.Add(Me.btnRun)
        Me.Controls.Add(Me.cbSteamGameID)
        Me.Controls.Add(Me.imgLoading)
        Me.Controls.Add(Me.lblGameName)
        Me.Controls.Add(Me.imgGameImage)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SteamIDLinker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SteamIDLinker"
        CType(Me.imgLoading, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.imgGameImage, System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
    End Sub
    Friend WithEvents cbSteamGameID As System.Windows.Forms.ComboBox
    Friend WithEvents imgLoading As System.Windows.Forms.PictureBox
    Friend WithEvents lblGameName As System.Windows.Forms.Label
    Friend WithEvents imgGameImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnRun As System.Windows.Forms.Button
    Friend WithEvents btnRunGameID As System.Windows.Forms.Button
    Friend WithEvents btnInstall As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents WebBrowserGamePage As System.Windows.Forms.WebBrowser
End Class
