<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class levels
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.pan1 = New System.Windows.Forms.Panel()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pan2 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Maiandra GD", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Yellow
        Me.Label6.Location = New System.Drawing.Point(726, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 42)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "LEVELS "
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(786, 189)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 475)
        Me.Panel3.TabIndex = 42
        '
        'pan1
        '
        Me.pan1.BackColor = System.Drawing.Color.Silver
        Me.pan1.Location = New System.Drawing.Point(317, 215)
        Me.pan1.Name = "pan1"
        Me.pan1.Size = New System.Drawing.Size(411, 417)
        Me.pan1.TabIndex = 41
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.Yellow
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(206, 132)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(22, 25)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "i"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(234, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Username"
        '
        'pan2
        '
        Me.pan2.BackColor = System.Drawing.Color.Silver
        Me.pan2.Location = New System.Drawing.Point(852, 215)
        Me.pan2.Name = "pan2"
        Me.pan2.Size = New System.Drawing.Size(411, 417)
        Me.pan2.TabIndex = 46
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(219, 688)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 42)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'levels
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkGray
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.pan2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.pan1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "levels"
        Me.Size = New System.Drawing.Size(1586, 906)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pan1 As System.Windows.Forms.Panel
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pan2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
