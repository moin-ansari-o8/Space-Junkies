Public Class easyBtn
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New easyMode, MainForm2.pan1)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New iEasy, MainForm2.pan1)
        End If
    End Sub
End Class
