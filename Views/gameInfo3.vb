Public Class gameInfo3
    Public Property MainForm As main
    Public Property Username As String
    Private Sub gameInfo3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label5.Text = Username
        Dim aye As New Label With {
            .Text = "Ay Captain " & Username & "!",
            .AutoSize = True,
            .Font = New Font("Maiandra GD", 20, FontStyle.Bold),
            .Location = New Point(30, 110)
        }
        Dim ready As New Label With {
           .Text = "Are You Ready to Play?",
           .AutoSize = True,
           .Font = New Font("Maiandra GD", 20, FontStyle.Bold),
           .Location = New Point(30, 150)
       }
        pan2.Controls.Add(aye)
        pan2.Controls.Add(ready)
    End Sub

    Private Sub pan2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pan2.Paint

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMenu)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New levels)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameInfo2)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New iUsername)
        End If
    End Sub
End Class
