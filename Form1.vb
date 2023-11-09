Imports System.IO

Public Class Form1


    Private filePath As String
    Private url As String
    Private youtube As New Youtube()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DownloadPanel.Visible = False
        filePath = Path.Combine(Application.StartupPath, "downloads")
        PathLabel.Text = filePath
    End Sub







    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles UrlInput.TextChanged
        url = UrlInput.Text
    End Sub







    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim folderBrowser As New FolderBrowserDialog()
        If folderBrowser.ShowDialog() = DialogResult.OK Then
            filePath = folderBrowser.SelectedPath
            PathLabel.Text = filePath
        End If
    End Sub

    Private Sub Mp3Button_Click(sender As Object, e As EventArgs) Handles Mp3Button.Click
        youtube.DownloadVideo(url, filePath, True)
    End Sub

    Private Sub Mp4Button_Click(sender As Object, e As EventArgs) Handles Mp4Button.Click
        youtube.DownloadVideo(url, filePath, False)
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        DownloadPanel.Visible = True
    End Sub
End Class
