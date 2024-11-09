Public Class iHard
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Private Sub iHard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New hardBtn, MainForm2.pan2)
        End If
    End Sub
End Class
