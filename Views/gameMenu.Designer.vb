<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gameMenu
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Image1 = New System.Windows.Forms.PictureBox()
        Me.Image2 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(47, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(469, 774)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(207, 91)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "SCORE BOARD"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Yellow
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(19, 22)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(22, 25)
        Me.Button6.TabIndex = 1
        Me.Button6.Text = "i"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(646, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(207, 91)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Yellow
        Me.Button2.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(983, 616)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(207, 91)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "LEVELS"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Yellow
        Me.Button4.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button4.Location = New System.Drawing.Point(1152, 774)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(207, 91)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "HELP"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.Yellow
        Me.Button5.Font = New System.Drawing.Font("Maiandra GD", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button5.Location = New System.Drawing.Point(808, 774)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(207, 91)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "SETTING"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Game1.My.Resources.Resources.gameLogo
        Me.PictureBox2.Location = New System.Drawing.Point(314, 22)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1298, 734)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Image1
        '
        Me.Image1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Image1.Image = Global.Game1.My.Resources.Resources.rocketbg
        Me.Image1.Location = New System.Drawing.Point(29, 479)
        Me.Image1.Name = "Image1"
        Me.Image1.Size = New System.Drawing.Size(417, 397)
        Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Image1.TabIndex = 86
        Me.Image1.TabStop = False
        '
        'Image2
        '
        Me.Image2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Image2.Image = Global.Game1.My.Resources.Resources.rocket_shadow
        Me.Image2.Location = New System.Drawing.Point(29, 906)
        Me.Image2.Name = "Image2"
        Me.Image2.Size = New System.Drawing.Size(417, 64)
        Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image2.TabIndex = 85
        Me.Image2.TabStop = False
        '
        'Timer1
        '
        '
        'gameMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Controls.Add(Me.Image1)
        Me.Controls.Add(Me.Image2)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "gameMenu"
        Me.Size = New System.Drawing.Size(1826, 1008)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Image2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Image1 As System.Windows.Forms.PictureBox
    Friend WithEvents Image2 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer

End Class
