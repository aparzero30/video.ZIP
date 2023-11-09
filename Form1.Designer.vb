<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(Form1))
        UrlInput = New TextBox()
        Panel1 = New Panel()
        UrlLabel = New Label()
        PathLabel = New Label()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Thumbnail = New PictureBox()
        VideoTitle = New Label()
        DownloadPanel = New Panel()
        LoadingBox = New PictureBox()
        Mp4Button = New PictureBox()
        Mp3Button = New PictureBox()
        Label7 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Thumbnail, ComponentModel.ISupportInitialize).BeginInit()
        DownloadPanel.SuspendLayout()
        CType(LoadingBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(Mp4Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Mp3Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UrlInput
        ' 
        UrlInput.BorderStyle = BorderStyle.None
        UrlInput.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        UrlInput.Location = New Point(10, 11)
        UrlInput.Name = "UrlInput"
        UrlInput.Size = New Size(411, 22)
        UrlInput.TabIndex = 4
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(UrlInput)
        Panel1.Location = New Point(11, 47)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(435, 45)
        Panel1.TabIndex = 12
        ' 
        ' UrlLabel
        ' 
        UrlLabel.AutoSize = True
        UrlLabel.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        UrlLabel.Location = New Point(22, 41)
        UrlLabel.MaximumSize = New Size(361, 0)
        UrlLabel.Name = "UrlLabel"
        UrlLabel.Size = New Size(73, 15)
        UrlLabel.TabIndex = 13
        UrlLabel.Text = "VIDEO LINK"
        ' 
        ' PathLabel
        ' 
        PathLabel.AutoSize = True
        PathLabel.Location = New Point(60, 102)
        PathLabel.MaximumSize = New Size(370, 0)
        PathLabel.Name = "PathLabel"
        PathLabel.Size = New Size(41, 15)
        PathLabel.TabIndex = 1
        PathLabel.Text = "Label1"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.Black
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(446, 47)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Padding = New Padding(10)
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("OpenSymbol", 15F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(370, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 19
        Label1.Text = "DOWNLOAD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(382, 86)
        Label3.MaximumSize = New Size(361, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 21
        Label3.Text = "MP3"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(435, 86)
        Label4.MaximumSize = New Size(361, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 22
        Label4.Text = "MP4"
        ' 
        ' Thumbnail
        ' 
        Thumbnail.BackColor = Color.White
        Thumbnail.Cursor = Cursors.Hand
        Thumbnail.Image = CType(resources.GetObject("Thumbnail.Image"), Image)
        Thumbnail.Location = New Point(7, 14)
        Thumbnail.Name = "Thumbnail"
        Thumbnail.Size = New Size(120, 120)
        Thumbnail.SizeMode = PictureBoxSizeMode.StretchImage
        Thumbnail.TabIndex = 23
        Thumbnail.TabStop = False
        ' 
        ' VideoTitle
        ' 
        VideoTitle.AutoSize = True
        VideoTitle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        VideoTitle.Location = New Point(133, 16)
        VideoTitle.MaximumSize = New Size(236, 0)
        VideoTitle.Name = "VideoTitle"
        VideoTitle.Size = New Size(64, 15)
        VideoTitle.TabIndex = 24
        VideoTitle.Text = "VideoTitle"
        ' 
        ' DownloadPanel
        ' 
        DownloadPanel.BorderStyle = BorderStyle.FixedSingle
        DownloadPanel.Controls.Add(LoadingBox)
        DownloadPanel.Controls.Add(Mp4Button)
        DownloadPanel.Controls.Add(Mp3Button)
        DownloadPanel.Controls.Add(Label7)
        DownloadPanel.Controls.Add(VideoTitle)
        DownloadPanel.Controls.Add(Thumbnail)
        DownloadPanel.Controls.Add(Label4)
        DownloadPanel.Controls.Add(Label3)
        DownloadPanel.Controls.Add(Label1)
        DownloadPanel.Location = New Point(10, 149)
        DownloadPanel.Name = "DownloadPanel"
        DownloadPanel.Size = New Size(481, 167)
        DownloadPanel.TabIndex = 15
        ' 
        ' LoadingBox
        ' 
        LoadingBox.BackColor = Color.Black
        LoadingBox.Cursor = Cursors.Hand
        LoadingBox.Image = CType(resources.GetObject("LoadingBox.Image"), Image)
        LoadingBox.Location = New Point(324, 38)
        LoadingBox.Name = "LoadingBox"
        LoadingBox.Padding = New Padding(10)
        LoadingBox.Size = New Size(45, 45)
        LoadingBox.SizeMode = PictureBoxSizeMode.StretchImage
        LoadingBox.TabIndex = 28
        LoadingBox.TabStop = False
        ' 
        ' Mp4Button
        ' 
        Mp4Button.BackColor = Color.Black
        Mp4Button.Cursor = Cursors.Hand
        Mp4Button.Image = CType(resources.GetObject("Mp4Button.Image"), Image)
        Mp4Button.Location = New Point(426, 38)
        Mp4Button.Name = "Mp4Button"
        Mp4Button.Padding = New Padding(10)
        Mp4Button.Size = New Size(45, 45)
        Mp4Button.SizeMode = PictureBoxSizeMode.StretchImage
        Mp4Button.TabIndex = 27
        Mp4Button.TabStop = False
        ' 
        ' Mp3Button
        ' 
        Mp3Button.BackColor = Color.Black
        Mp3Button.Cursor = Cursors.Hand
        Mp3Button.Image = CType(resources.GetObject("Mp3Button.Image"), Image)
        Mp3Button.Location = New Point(375, 38)
        Mp3Button.Name = "Mp3Button"
        Mp3Button.Padding = New Padding(10)
        Mp3Button.Size = New Size(45, 45)
        Mp3Button.SizeMode = PictureBoxSizeMode.StretchImage
        Mp3Button.TabIndex = 17
        Mp3Button.TabStop = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Cursor = Cursors.Hand
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(344, 140)
        Label7.MaximumSize = New Size(361, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(125, 15)
        Label7.TabIndex = 26
        Label7.Text = "SHOW DOWNLOADS"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = Color.Black
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(10, 98)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Padding = New Padding(10)
        PictureBox3.Size = New Size(45, 45)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(499, 333)
        Controls.Add(PictureBox3)
        Controls.Add(DownloadPanel)
        Controls.Add(PictureBox1)
        Controls.Add(UrlLabel)
        Controls.Add(Panel1)
        Controls.Add(PathLabel)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Thumbnail, ComponentModel.ISupportInitialize).EndInit()
        DownloadPanel.ResumeLayout(False)
        DownloadPanel.PerformLayout()
        CType(LoadingBox, ComponentModel.ISupportInitialize).EndInit()
        CType(Mp4Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Mp3Button, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UrlInput As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents UrlLabel As Label
    Friend WithEvents PathLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Thumbnail As PictureBox
    Friend WithEvents VideoTitle As Label
    Friend WithEvents DownloadPanel As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Mp3Button As PictureBox
    Friend WithEvents Mp4Button As PictureBox
    Friend WithEvents LoadingBox As PictureBox
End Class
