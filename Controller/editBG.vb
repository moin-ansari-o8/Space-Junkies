Imports System.Data.SqlClient
Public Class editBG
    Public Property MainForm3 As gameMainInterface
    Public Property MainForm2 As editGame
    Public Property bgImg As String
    Public Property Username As String
    
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        bgImg = bgImg1
        UpdateData(Username, "bgImg", bgImg)
        updateLabel(Label3, "BackColor")
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        bgImg = bgImg2
        UpdateData(Username, "bgImg", bgImg)
        updateLabel(Label3, "BackColor")
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        bgImg = bgImg3
        UpdateData(Username, "bgImg", bgImg)
        updateLabel(Label3, "BackColor")
    End Sub
End Class
