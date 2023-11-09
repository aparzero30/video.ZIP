Imports System.IO
Imports NReco.VideoConverter


Public Class Youtube








    Public Sub DownloadVideo(videoUrl As String, outputDirectory As String, isMP3 As Boolean)
        Try
            ' Define the path to the yt-dlp executable (yt-dlp.exe)
            Dim commandPath As String = Path.Combine(Application.StartupPath, "runner", "yt-dlp.exe")



            ' Create the command with output directory
            Dim command As String = $"--output ""{outputDirectory}\%(title)s.%(ext)s"" {videoUrl}"

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
                    ConvertToMP3(outputDirectory)
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



    Public Sub ConvertToMP3(outputDirectory As String)
        Try
            ' Get the list of video files in the output directory
            Dim videoFiles = Directory.GetFiles(outputDirectory, "*.mp4")

            ' Initialize the video converter
            Dim converter As New FFMpegConverter()

            For Each videoFile In videoFiles
                ' Generate the output MP3 file path by changing the extension
                Dim audioOutputPath As String = Path.ChangeExtension(videoFile, ".mp3")

                ' Convert the video to MP3
                converter.ConvertMedia(videoFile, audioOutputPath, Format.wmv)

                ' Delete the original video file
                File.Delete(videoFile)

                MessageBox.Show("Conversion to MP3 completed.")
            Next
        Catch ex As Exception
            MessageBox.Show("An error occurred during MP3 conversion: " & ex.Message)
            End
        End Try
    End Sub





End Class
