Public Class hardMode
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Public Property Username As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New hardBtn, MainForm2.pan2)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Hard", 1))
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
         If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Hard", 2))
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Hard", 3))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Hard", 4))
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Hard", 5))
        End If
    End Sub

End Class
