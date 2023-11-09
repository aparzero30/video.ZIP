Imports System.IO
Imports System.Net

Public Class Form1


    Private filePath As String
    Private url As String
    Private youtube As New Youtube()
    Private videoDetails As New YoutubeResponse()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadPanel.Visible = False
        Me.FormBorderStyle = FormBorderStyle.FixedSingle ' Fixed Single
        Me.MaximizeBox = False
        filePath = Path.Combine(Application.StartupPath, "downloads")
        PathLabel.Text = filePath
        LoadingBox.Visible = False
        Me.Text = "Video.zip"
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UrlInput.TextChanged
        url = UrlInput.Text
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim folderBrowser As New FolderBrowserDialog()
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            filePath = folderBrowser.SelectedPath
            PathLabel.Text = filePath
        End If
    End Sub


    Private Async Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Mp3Button.Click

        Mp3Button.Visible = False
        LoadingBox.Location = Mp3Button.Location
        LoadingBox.Visible = True
        Mp4Button.Enabled = False

        ' Use Task.Run to run the download on a background thread
        Await Task.Run(Sub()
                           youtube.DownloadVideo(url, filePath, True, videoDetails)
                       End Sub)

        LoadingBox.Visible = False
        Mp3Button.Visible = True
        Mp4Button.Enabled = True


    End Sub



    Private Async Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles Mp4Button.Click


        Mp4Button.Visible = False
        LoadingBox.Location = Mp4Button.Location
        LoadingBox.Visible = True
        Mp3Button.Enabled = False



        ' Use Task.Run to run the download on a background thread
        Await Task.Run(Sub()
                           youtube.DownloadVideo(url, filePath, False, videoDetails)
                       End Sub)


        LoadingBox.Visible = False
        Mp4Button.Visible = True
        Mp3Button.Enabled = True





    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click


        videoDetails = youtube.GetLinkDetails(url)

        If videoDetails IsNot Nothing Then



            UrlLabel.ForeColor = Color.Black
            UrlLabel.Text = "VIDEO LINK"
            VideoTitle.Text = videoDetails.title.ToUpper()
            Dim webClient As New WebClient()
            Dim imageData As Byte() = webClient.DownloadData(videoDetails.thumbnail_url)
            Dim memoryStream As New System.IO.MemoryStream(imageData)
            Thumbnail.Image = Image.FromStream(memoryStream)
            DownloadPanel.Visible = True

        Else
            UrlLabel.ForeColor = Color.Red
            UrlLabel.Text = "INVALID URL"
        End If















    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        ' Specify the folder path you want to open


        ' Open the file explorer at the specified folder
        Try
            System.Diagnostics.Process.Start("explorer.exe", filePath)
        Catch ex As Exception
            ' Handle any exceptions that may occur
            MessageBox.Show("Error opening file explorer: " & ex.Message)
        End Try
    End Sub

End Class
