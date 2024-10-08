Public Class editMissile
    Public Property MainForm3 As gameMainInterface
    Public Property MainForm2 As editGame
    Public Property missileImg As String
    Public Property Username As String

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        missileImg = missileImg1
        UpdateData(Username, "missileImg", missileImg)
        updateLabel(Label3, "Missile")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        missileImg = missileImg2
        UpdateData(Username, "missileImg", missileImg)
        updateLabel(Label3, "Missile")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        missileImg = missileImg3
        UpdateData(Username, "missileImg", missileImg)
        updateLabel(Label3, "Missile")
    End Sub
End Class
