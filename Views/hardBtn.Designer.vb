<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class hardBtn
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Moccasin
        Me.Button4.Font = New System.Drawing.Font("Maiandra GD", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Red
        Me.Button4.Location = New System.Drawing.Point(3, 3)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(405, 411)
        Me.Button4.TabIndex = 1
        Me.Button4.Text = " Hard " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Mode"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Yellow
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(368, 13)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(29, 26)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "i"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'hardBtn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Moccasin
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Name = "hardBtn"
        Me.Size = New System.Drawing.Size(411, 417)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button

End Class
