Public Class editPlanetB
    Public Property MainForm3 As gameInterface
    Public Property MainForm2 As editGame
    Public Property planetB As String
    Public Property Username As String

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        planetB = planet1
        UpdateData(Username, "planetBImg", planetB)
        updateLabel(Label3, "Planet B")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        planetB = planet2
        UpdateData(Username, "planetBImg", planetB)
        updateLabel(Label3, "Planet B")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        planetB = planet3
        UpdateData(Username, "planetBImg", planetB)
        updateLabel(Label3, "Planet B")
    End Sub
End Class
