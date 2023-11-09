Imports System.IO
Imports System.Net.Http
Imports AngleSharp.Media
Imports Newtonsoft.Json
Imports NReco.VideoConverter
Imports YoutubeExplode

Public Class Youtube




    Private musicService As New MusicService()



    Public Sub DownloadVideo(videoUrl As String, outputDirectory As String, isMP3 As Boolean, videoDetails As YoutubeResponse)






        Try
            ' Define the path to the yt-dlp executable (yt-dlp.exe)
            Dim commandPath As String = Path.Combine(Application.StartupPath, "runner", "yt-dlp.exe")
            Dim processPath As String = Path.Combine(Application.StartupPath, "proc")












            If Not isMP3 Then

                Dim authorFolder = Path.Combine(outputDirectory, videoDetails.author_name)
                If Not Directory.Exists(authorFolder) Then
                    Directory.CreateDirectory(authorFolder)
                End If
                processPath = authorFolder
            End If










            ' Create the command with output directory
            Dim command As String = $"--output ""{processPath}\%(title)s.%(ext)s"" {videoUrl}"

            ' Create a ProcessStartInfo to specify the executable and arguments
            Dim psi As New ProcessStartInfo()
            psi.FileName = commandPath
            psi.Arguments = command

            ' Redirect the standard output and standard error
            psi.RedirectStandardOutput = True
            psi.RedirectStandardError = True
            psi.UseShellExecute = False
            psi.CreateNoWindow = True

            ' Set the working directory to the output directory
            psi.WorkingDirectory = outputDirectory

            ' Create and start the process
            Dim process As New Process()
            process.StartInfo = psi
            process.Start()

            ' Read the output and error streams (optional)
            Dim output As String = process.StandardOutput.ReadToEnd()
            Dim errorOutput As String = process.StandardError.ReadToEnd()

            ' Wait for the process to exit
            process.WaitForExit()

            ' You can check the process exit code to see if it was successful
            If process.ExitCode = 0 Then
                ' MessageBox.Show("Download completed successfully.", output)
                'if isMP3 true convert the download video to mp3 then delete t
                If isMP3 Then
                    ' ConvertToMP3(outputDirectory)
                    musicService.ConvertToMP3(processPath, outputDirectory, videoDetails)
                Else
                    MessageBox.Show("Download Complete")
                End If

            Else
                MessageBox.Show("Download failed. Error: " & errorOutput)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub




    Public Function GetLinkDetails(url As String) As YoutubeResponse

        Dim apiUrl As String = $"https://www.youtube.com/oembed?url={url}&format=json"

        Using client As New HttpClient()
            ' Make the GET request
            Dim response = client.GetStringAsync(apiUrl) ' Note: Using .Result for simplicity. In a real-world scenario, consider using async/await.

            ' Parse the JSON response

            Dim responseData As New YoutubeResponse()

            Try
                responseData = JsonConvert.DeserializeObject(Of YoutubeResponse)(response.Result)
            Catch ex As Exception
                Return Nothing
            End Try


            Return responseData
        End Using
    End Function





















End Class
