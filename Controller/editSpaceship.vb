Public Class editSpaceship
    Public Property MainForm3 As gameMainInterface
    Public Property MainForm2 As editGame
    Public Property spaceshipImg As String
    Public Property Username As String

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        spaceshipImg = spaceshipImg1
        UpdateData(Username, "spaceshipImg", spaceshipImg)
        updateLabel(Label3, "Enemy Spaceship")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        spaceshipImg = spaceshipImg2
        UpdateData(Username, "spaceshipImg", spaceshipImg)
        updateLabel(Label3, "Enemy Spaceship")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        spaceshipImg = spaceshipImg3
        UpdateData(Username, "spaceshipImg", spaceshipImg)
        updateLabel(Label3, "Enemy Spaceship")
    End Sub

End Class
