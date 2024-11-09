<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scoreBoard
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LabelHeadingHighscore = New System.Windows.Forms.Label()
        Me.LabelHeadingUsername = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Moccasin
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1062, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 57)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "Score Board"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(226, 787)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 42)
        Me.Button1.TabIndex = 97
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Image1
        '
        Me.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Image1.Image = Global.Game1.My.Resources.Resources.rocketbg
        Me.Image1.Location = New System.Drawing.Point(227, 78)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(509, 515)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image1.TabIndex = 99
        Me.Image1.TabStop = False
        '
        'Image2
        '
        Me.Image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image2.Image = Global.Game1.My.Resources.Resources.rocket_shadow
        Me.Image2.Location = New System.Drawing.Point(159, 646)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(636, 91)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 98
        Me.Image2.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        '
        'LabelHeadingHighscore
        '
        Me.LabelHeadingHighscore.AutoSize = True
        Me.LabelHeadingHighscore.BackColor = System.Drawing.Color.PapayaWhip
        Me.LabelHeadingHighscore.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeadingHighscore.Location = New System.Drawing.Point(1243, 278)
        Me.LabelHeadingHighscore.Name = "LabelHeadingHighscore"
        Me.LabelHeadingHighscore.Size = New System.Drawing.Size(131, 32)
        Me.LabelHeadingHighscore.TabIndex = 101
        Me.LabelHeadingHighscore.Text = "Highscore"
        Me.LabelHeadingHighscore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHeadingUsername
        '
        Me.LabelHeadingUsername.AutoSize = True
        Me.LabelHeadingUsername.BackColor = System.Drawing.Color.PapayaWhip
        Me.LabelHeadingUsername.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeadingUsername.Location = New System.Drawing.Point(1028, 278)
        Me.LabelHeadingUsername.Name = "LabelHeadingUsername"
        Me.LabelHeadingUsername.Size = New System.Drawing.Size(131, 32)
        Me.LabelHeadingUsername.TabIndex = 102
        Me.LabelHeadingUsername.Text = "Username" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.LabelHeadingUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(1197, 278)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 299)
        Me.Panel3.TabIndex = 103
        '
        'scoreBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.LabelHeadingUsername)
        Me.Controls.Add(Me.LabelHeadingHighscore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "scoreBoard"
        Me.Size = New System.Drawing.Size(1586, 906)
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents Image2 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents LabelHeadingHighscore As System.Windows.Forms.Label
    Friend WithEvents LabelHeadingUsername As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel

End Class
