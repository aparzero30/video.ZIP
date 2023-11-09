Imports NReco.VideoConverter
Imports System.IO

Public Class MusicService
    Public Sub ConvertToMP3(processPath As String, outputBaseDirectory As String, videoDetails As YoutubeResponse)
        Try
            ' Get the list of video files in the process path
            Dim videoFiles = Directory.GetFiles(processPath, "*.mp4")

            ' Check if a folder named with the author_name exists
            Dim authorFolder = Path.Combine(outputBaseDirectory, videoDetails.author_name)

            If Not Directory.Exists(authorFolder) Then
                ' If the folder doesn't exist, create it
                Directory.CreateDirectory(authorFolder)
            End If

            Dim converter As New NReco.VideoConverter.FFMpegConverter()

            For Each videoFile In videoFiles
                ' Generate the output MP3 file path in the author's folder
                Dim audioOutputPath As String = Path.Combine(authorFolder, Path.GetFileNameWithoutExtension(videoFile) & ".mp3")
                converter.ConvertMedia(videoFile, audioOutputPath, "mp3")
                File.Delete(videoFile)
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred during MP3 conversion: " & ex.Message)
            End
        End Try
    End Sub


End Class
