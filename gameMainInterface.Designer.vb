<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameMainInterface
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gameMainInterface))
        Me.Command2 = New System.Windows.Forms.Button()
        Me.MyScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Command1 = New System.Windows.Forms.Button()
        Me.Text2 = New System.Windows.Forms.TextBox()
        Me.Text1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scr = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Image4 = New System.Windows.Forms.PictureBox()
        Me.Image5_3 = New System.Windows.Forms.PictureBox()
        Me.Image5_2 = New System.Windows.Forms.PictureBox()
        Me.Image5_1 = New System.Windows.Forms.PictureBox()
        Me.Image3 = New System.Windows.Forms.PictureBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.MainRocket = New System.Windows.Forms.PictureBox()
        Me.missile1 = New System.Windows.Forms.PictureBox()
        Me.missile2 = New System.Windows.Forms.PictureBox()
        Me.missile3 = New System.Windows.Forms.PictureBox()
        Me.missile4 = New System.Windows.Forms.PictureBox()
        Me.missile5 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image5_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image5_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image5_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MainRocket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.missile5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Command2
        '
        Me.Command2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Command2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Command2.Location = New System.Drawing.Point(1096, 945)
        Me.Command2.Name = "Command2"
        Me.Command2.Size = New System.Drawing.Size(88, 36)
        Me.Command2.TabIndex = 56
        Me.Command2.Text = "Reset"
        Me.Command2.UseVisualStyleBackColor = False
        '
        'MyScore
        '
        Me.MyScore.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyScore.AutoSize = True
        Me.MyScore.BackColor = System.Drawing.Color.MidnightBlue
        Me.MyScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.MyScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MyScore.ForeColor = System.Drawing.Color.Yellow
        Me.MyScore.Location = New System.Drawing.Point(1362, 917)
        Me.MyScore.MaximumSize = New System.Drawing.Size(150, 25)
        Me.MyScore.MinimumSize = New System.Drawing.Size(150, 25)
        Me.MyScore.Name = "MyScore"
        Me.MyScore.Size = New System.Drawing.Size(150, 25)
        Me.MyScore.TabIndex = 55
        Me.MyScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.DimGray
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(1262, 888)
        Me.Label3.MaximumSize = New System.Drawing.Size(250, 25)
        Me.Label3.MinimumSize = New System.Drawing.Size(250, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(250, 25)
        Me.Label3.TabIndex = 54
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Command1
        '
        Me.Command1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Command1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Command1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.Location = New System.Drawing.Point(998, 945)
        Me.Command1.Name = "Command1"
        Me.Command1.Size = New System.Drawing.Size(92, 36)
        Me.Command1.TabIndex = 53
        Me.Command1.Text = "Launch"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'Text2
        '
        Me.Text2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text2.BackColor = System.Drawing.SystemColors.MenuText
        Me.Text2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text2.ForeColor = System.Drawing.SystemColors.Info
        Me.Text2.Location = New System.Drawing.Point(1105, 900)
        Me.Text2.MaximumSize = New System.Drawing.Size(50, 25)
        Me.Text2.MinimumSize = New System.Drawing.Size(50, 25)
        Me.Text2.Name = "Text2"
        Me.Text2.Size = New System.Drawing.Size(50, 21)
        Me.Text2.TabIndex = 52
        Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Text1
        '
        Me.Text1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Text1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Text1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Text1.ForeColor = System.Drawing.SystemColors.Info
        Me.Text1.Location = New System.Drawing.Point(1105, 871)
        Me.Text1.MaximumSize = New System.Drawing.Size(50, 25)
        Me.Text1.MinimumSize = New System.Drawing.Size(50, 25)
        Me.Text1.Name = "Text1"
        Me.Text1.Size = New System.Drawing.Size(50, 21)
        Me.Text1.TabIndex = 51
        Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Yellow
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1018, 899)
        Me.Label2.MaximumSize = New System.Drawing.Size(90, 25)
        Me.Label2.MinimumSize = New System.Drawing.Size(90, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Angle "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'scr
        '
        Me.scr.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.scr.AutoSize = True
        Me.scr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.scr.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scr.Location = New System.Drawing.Point(1262, 917)
        Me.scr.MaximumSize = New System.Drawing.Size(100, 25)
        Me.scr.MinimumSize = New System.Drawing.Size(100, 25)
        Me.scr.Name = "scr"
        Me.scr.Size = New System.Drawing.Size(100, 25)
        Me.scr.TabIndex = 49
        Me.scr.Text = "Your Score :"
        Me.scr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Yellow
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(1018, 869)
        Me.Label1.MaximumSize = New System.Drawing.Size(90, 25)
        Me.Label1.MinimumSize = New System.Drawing.Size(90, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Velocity "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Game1.My.Resources.Resources.playPause
        Me.PictureBox1.Location = New System.Drawing.Point(1835, 945)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 46)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'Image4
        '
        Me.Image4.BackColor = System.Drawing.Color.Transparent
        Me.Image4.Image = CType(resources.GetObject("Image4.Image"), System.Drawing.Image)
        Me.Image4.Location = New System.Drawing.Point(218, 196)
        Me.Image4.Name = "Image4"
        Me.Image4.Size = New System.Drawing.Size(96, 110)
        Me.Image4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image4.TabIndex = 64
        Me.Image4.TabStop = False
        Me.Image4.Visible = False
        '
        'Image5_3
        '
        Me.Image5_3.BackColor = System.Drawing.Color.Transparent
        Me.Image5_3.Image = Global.Game1.My.Resources.Resources.explosion3
        Me.Image5_3.Location = New System.Drawing.Point(326, 312)
        Me.Image5_3.Name = "Image5_3"
        Me.Image5_3.Size = New System.Drawing.Size(80, 77)
        Me.Image5_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image5_3.TabIndex = 63
        Me.Image5_3.TabStop = False
        Me.Image5_3.Visible = False
        '
        'Image5_2
        '
        Me.Image5_2.BackColor = System.Drawing.Color.Transparent
        Me.Image5_2.Image = Global.Game1.My.Resources.Resources.explosion2
        Me.Image5_2.Location = New System.Drawing.Point(242, 312)
        Me.Image5_2.Name = "Image5_2"
        Me.Image5_2.Size = New System.Drawing.Size(80, 77)
        Me.Image5_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image5_2.TabIndex = 62
        Me.Image5_2.TabStop = False
        Me.Image5_2.Visible = False
        '
        'Image5_1
        '
        Me.Image5_1.BackColor = System.Drawing.Color.Transparent
        Me.Image5_1.Image = Global.Game1.My.Resources.Resources.explosion1
        Me.Image5_1.Location = New System.Drawing.Point(156, 312)
        Me.Image5_1.Name = "Image5_1"
        Me.Image5_1.Size = New System.Drawing.Size(80, 77)
        Me.Image5_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image5_1.TabIndex = 61
        Me.Image5_1.TabStop = False
        Me.Image5_1.Visible = False
        '
        'Image3
        '
        Me.Image3.BackColor = System.Drawing.Color.Transparent
        Me.Image3.Image = Global.Game1.My.Resources.Resources.enemy
        Me.Image3.Location = New System.Drawing.Point(102, 196)
        Me.Image3.Name = "Image3"
        Me.Image3.Size = New System.Drawing.Size(110, 110)
        Me.Image3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image3.TabIndex = 60
        Me.Image3.TabStop = False
        Me.Image3.Visible = False
        '
        'Image1
        '
        Me.Image1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Image1.BackColor = System.Drawing.Color.Transparent
        Me.Image1.Image = Global.Game1.My.Resources.Resources.missile
        Me.Image1.Location = New System.Drawing.Point(91, 746)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(58, 53)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image1.TabIndex = 59
        Me.Image1.TabStop = False
        Me.Image1.Visible = False
        '
        'Image2
        '
        Me.Image2.BackColor = System.Drawing.Color.Transparent
        Me.Image2.Image = Global.Game1.My.Resources.Resources.planet
        Me.Image2.Location = New System.Drawing.Point(317, 196)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(135, 110)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 58
        Me.Image2.TabStop = False
        Me.Image2.Visible = False
        '
        'MainRocket
        '
        Me.MainRocket.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MainRocket.BackColor = System.Drawing.Color.Transparent
        Me.MainRocket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MainRocket.Image = Global.Game1.My.Resources.Resources.rocketbg
        Me.MainRocket.ImageLocation = ""
        Me.MainRocket.Location = New System.Drawing.Point(22, 746)
        Me.MainRocket.Name = "MainRocket"
        Me.MainRocket.Size = New System.Drawing.Size(200, 245)
        Me.MainRocket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MainRocket.TabIndex = 57
        Me.MainRocket.TabStop = False
        '
        'missile1
        '
        Me.missile1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.missile1.BackColor = System.Drawing.Color.Transparent
        Me.missile1.Image = Global.Game1.My.Resources.Resources.missile
        Me.missile1.Location = New System.Drawing.Point(228, 938)
        Me.missile1.Name = "missile1"
        Me.missile1.Size = New System.Drawing.Size(40, 53)
        Me.missile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.missile1.TabIndex = 67
        Me.missile1.TabStop = False
        Me.missile1.Visible = False
        '
        'missile2
        '
        Me.missile2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.missile2.BackColor = System.Drawing.Color.Transparent
        Me.missile2.Image = Global.Game1.My.Resources.Resources.missile
        Me.missile2.Location = New System.Drawing.Point(274, 938)
        Me.missile2.Name = "missile2"
        Me.missile2.Size = New System.Drawing.Size(40, 53)
        Me.missile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.missile2.TabIndex = 68
        Me.missile2.TabStop = False
        Me.missile2.Visible = False
        '
        'missile3
        '
        Me.missile3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.missile3.BackColor = System.Drawing.Color.Transparent
        Me.missile3.Image = Global.Game1.My.Resources.Resources.missile
        Me.missile3.Location = New System.Drawing.Point(320, 938)
        Me.missile3.Name = "missile3"
        Me.missile3.Size = New System.Drawing.Size(40, 53)
        Me.missile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.missile3.TabIndex = 69
        Me.missile3.TabStop = False
        Me.missile3.Visible = False
        '
        'missile4
        '
        Me.missile4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.missile4.BackColor = System.Drawing.Color.Transparent
        Me.missile4.Image = Global.Game1.My.Resources.Resources.missile
        Me.missile4.Location = New System.Drawing.Point(366, 938)
        Me.missile4.Name = "missile4"
        Me.missile4.Size = New System.Drawing.Size(40, 53)
        Me.missile4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.missile4.TabIndex = 70
        Me.missile4.TabStop = False
        Me.missile4.Visible = False
        '
        'missile5
        '
        Me.missile5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.missile5.BackColor = System.Drawing.Color.Transparent
        Me.missile5.Image = Global.Game1.My.Resources.Resources.missile
        Me.missile5.Location = New System.Drawing.Point(412, 938)
        Me.missile5.Name = "missile5"
        Me.missile5.Size = New System.Drawing.Size(40, 53)
        Me.missile5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.missile5.TabIndex = 71
        Me.missile5.TabStop = False
        Me.missile5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(811, 356)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(412, 57)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "No Missiles Left!!!"
        Me.Label6.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(669, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 63)
        Me.Button1.TabIndex = 75
        Me.Button1.Text = "Restart Game"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(790, 611)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 63)
        Me.Button2.TabIndex = 76
        Me.Button2.Text = "Exit Game"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(1145, 569)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 63)
        Me.Button3.TabIndex = 77
        Me.Button3.Text = "Open Menu"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Button4.Font = New System.Drawing.Font("Maiandra GD", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(1155, 464)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 63)
        Me.Button4.TabIndex = 78
        Me.Button4.Text = "Next Level"
        Me.Button4.UseVisualStyleBackColor = False
        Me.Button4.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(86, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 25)
        Me.Label4.TabIndex = 72
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Maiandra GD", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(159, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 25)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Label5"
        '
        'gameMainInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.missile5)
        Me.Controls.Add(Me.missile4)
        Me.Controls.Add(Me.missile3)
        Me.Controls.Add(Me.missile2)
        Me.Controls.Add(Me.missile1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Image4)
        Me.Controls.Add(Me.Image5_3)
        Me.Controls.Add(Me.Image5_2)
        Me.Controls.Add(Me.Image5_1)
        Me.Controls.Add(Me.Image3)
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.MainRocket)
        Me.Controls.Add(Me.Command2)
        Me.Controls.Add(Me.MyScore)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.Text2)
        Me.Controls.Add(Me.Text1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.scr)
        Me.Controls.Add(Me.Label1)
        Me.Name = "gameMainInterface"
        Me.Size = New System.Drawing.Size(1910, 1010)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image5_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image5_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image5_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MainRocket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.missile5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Image5_3 As System.Windows.Forms.PictureBox
    Friend WithEvents Image5_2 As System.Windows.Forms.PictureBox
    Friend WithEvents Image5_1 As System.Windows.Forms.PictureBox
    Friend WithEvents Image3 As System.Windows.Forms.PictureBox
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents Image2 As System.Windows.Forms.PictureBox
    Friend WithEvents MainRocket As System.Windows.Forms.PictureBox
    Friend WithEvents Command2 As System.Windows.Forms.Button
    Friend WithEvents MyScore As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Command1 As System.Windows.Forms.Button
    Friend WithEvents Text2 As System.Windows.Forms.TextBox
    Friend WithEvents Text1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents scr As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Image4 As System.Windows.Forms.PictureBox
    Friend WithEvents timer As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents missile1 As System.Windows.Forms.PictureBox
    Friend WithEvents missile2 As System.Windows.Forms.PictureBox
    Friend WithEvents missile3 As System.Windows.Forms.PictureBox
    Friend WithEvents missile4 As System.Windows.Forms.PictureBox
    Friend WithEvents missile5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
