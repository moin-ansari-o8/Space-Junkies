Public Class iEasy
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Private Sub iEasy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New easyBtn, MainForm2.pan1)
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class
