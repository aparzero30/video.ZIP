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
        Label5 = New Label()
        PathLabel = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Mp4Button = New PictureBox()
        Label4 = New Label()
        Mp3Button = New PictureBox()
        Thumbnail = New PictureBox()
        VideoTitle = New Label()
        DownloadPanel = New Panel()
        PictureBox3 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(Mp4Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Mp3Button, ComponentModel.ISupportInitialize).BeginInit()
        CType(Thumbnail, ComponentModel.ISupportInitialize).BeginInit()
        DownloadPanel.SuspendLayout()
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
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label5.Location = New Point(22, 41)
        Label5.MaximumSize = New Size(361, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(73, 15)
        Label5.TabIndex = 13
        Label5.Text = "VIDEO LINK"
        ' 
        ' PathLabel
        ' 
        PathLabel.AutoSize = True
        PathLabel.Location = New Point(73, 101)
        PathLabel.MaximumSize = New Size(370, 0)
        PathLabel.Name = "PathLabel"
        PathLabel.Size = New Size(41, 15)
        PathLabel.TabIndex = 1
        PathLabel.Text = "Label1"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(10, 101)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(57, 50)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Cursor = Cursors.Hand
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(446, 46)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(45, 45)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 14
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("OpenSymbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(133, 70)
        Label2.Name = "Label2"
        Label2.Size = New Size(42, 27)
        Label2.TabIndex = 20
        Label2.Text = "AS"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("OpenSymbol", 20.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(133, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(143, 27)
        Label1.TabIndex = 19
        Label1.Text = "DOWNLOAD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(353, 112)
        Label3.MaximumSize = New Size(361, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(32, 15)
        Label3.TabIndex = 21
        Label3.Text = "MP3"
        ' 
        ' Mp4Button
        ' 
        Mp4Button.Cursor = Cursors.Hand
        Mp4Button.Image = CType(resources.GetObject("Mp4Button.Image"), Image)
        Mp4Button.Location = New Point(408, 43)
        Mp4Button.Name = "Mp4Button"
        Mp4Button.Size = New Size(68, 64)
        Mp4Button.SizeMode = PictureBoxSizeMode.StretchImage
        Mp4Button.TabIndex = 18
        Mp4Button.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(431, 110)
        Label4.MaximumSize = New Size(361, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(32, 15)
        Label4.TabIndex = 22
        Label4.Text = "MP4"
        ' 
        ' Mp3Button
        ' 
        Mp3Button.Cursor = Cursors.Hand
        Mp3Button.Image = CType(resources.GetObject("Mp3Button.Image"), Image)
        Mp3Button.Location = New Point(334, 43)
        Mp3Button.Name = "Mp3Button"
        Mp3Button.Size = New Size(68, 64)
        Mp3Button.SizeMode = PictureBoxSizeMode.StretchImage
        Mp3Button.TabIndex = 17
        Mp3Button.TabStop = False
        ' 
        ' Thumbnail
        ' 
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
        VideoTitle.Location = New Point(134, 14)
        VideoTitle.MaximumSize = New Size(350, 0)
        VideoTitle.Name = "VideoTitle"
        VideoTitle.Size = New Size(59, 15)
        VideoTitle.TabIndex = 24
        VideoTitle.Text = "VideoTitle"
        ' 
        ' DownloadPanel
        ' 
        DownloadPanel.BorderStyle = BorderStyle.FixedSingle
        DownloadPanel.Controls.Add(Label7)
        DownloadPanel.Controls.Add(Label6)
        DownloadPanel.Controls.Add(PictureBox3)
        DownloadPanel.Controls.Add(VideoTitle)
        DownloadPanel.Controls.Add(Thumbnail)
        DownloadPanel.Controls.Add(Mp3Button)
        DownloadPanel.Controls.Add(Label4)
        DownloadPanel.Controls.Add(Mp4Button)
        DownloadPanel.Controls.Add(Label3)
        DownloadPanel.Controls.Add(Label1)
        DownloadPanel.Controls.Add(Label2)
        DownloadPanel.Location = New Point(10, 157)
        DownloadPanel.Name = "DownloadPanel"
        DownloadPanel.Size = New Size(481, 208)
        DownloadPanel.TabIndex = 15
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Cursor = Cursors.Hand
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(424, 153)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 16
        PictureBox3.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(334, 175)
        Label6.MaximumSize = New Size(361, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(85, 15)
        Label6.TabIndex = 25
        Label6.Text = "DOWNLOADS"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label7.Location = New Point(374, 158)
        Label7.MaximumSize = New Size(361, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(44, 15)
        Label7.TabIndex = 26
        Label7.Text = "SHOW"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(499, 377)
        Controls.Add(DownloadPanel)
        Controls.Add(PictureBox1)
        Controls.Add(Label5)
        Controls.Add(Panel1)
        Controls.Add(PictureBox2)
        Controls.Add(PathLabel)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(Mp4Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Mp3Button, ComponentModel.ISupportInitialize).EndInit()
        CType(Thumbnail, ComponentModel.ISupportInitialize).EndInit()
        DownloadPanel.ResumeLayout(False)
        DownloadPanel.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents UrlInput As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents PathLabel As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Mp4Button As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Mp3Button As PictureBox
    Friend WithEvents Thumbnail As PictureBox
    Friend WithEvents VideoTitle As Label
    Friend WithEvents DownloadPanel As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
