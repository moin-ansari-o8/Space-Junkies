Public Class gameInfo2
    Public Property MainForm As main
    Public Property Username As String
    Private Sub gameInfo2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Username
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameInfo3)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameInfo1)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameInfo3)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMenu)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New iUsername)
        End If
    End Sub
End Class
