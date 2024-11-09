Public Class hardBtn
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New iHard, MainForm2.pan2)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New hardMode, MainForm2.pan2)
        End If
    End Sub
End Class
