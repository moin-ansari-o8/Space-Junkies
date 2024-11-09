Imports System.Data.SqlClient
Public Class easyMode
    Public Property MainForm2 As levels
    Public Property MainForm As main
    Public Property Username As String

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm2 IsNot Nothing Then
            MainForm2.LoadLevel(New easyBtn, MainForm2.pan1)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Easy", 1))
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
       If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Easy", 2))
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
       If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Easy", 3))
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
       If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Easy", 4))
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
       If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface("Easy", 5))
        End If
    End Sub


    Private Sub easyMode_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
