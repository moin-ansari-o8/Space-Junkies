Public Class editPlanetA
    Public Property MainForm3 As gameInterface
    Public Property MainForm2 As editGame
    Public Property planetA As String
    Public Property Username As String
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        planetA = planet1
        UpdateData(Username, "planetAImg", planetA)
        updateLabel(Label3, "Planet A")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        planetA = planet2
        UpdateData(Username, "planetAImg", planetA)
        updateLabel(Label3, "Planet A")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        planetA = planet3
        UpdateData(Username, "planetAImg", planetA)
        updateLabel(Label3, "Planet A")
    End Sub
End Class
