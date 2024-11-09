Imports System.Data.SqlClient

Public Class signIn
    Public Property MainForm As main
    Public Sub PreFillUsername(ByVal username As String)
        txtUsername.Text = username
    End Sub
    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click

        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        If username = "" Or password = "" Then
            lblError.Text = "Username and password cannot be empty."
            txtUsername.Focus()
            Return
        End If

        Dim connectionString As String = conStr
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Dim sql As String = "SELECT * FROM UserInfo WHERE Username = @Username AND Password = @Password"
                Using cmd As New SqlCommand(sql, connection)
                    cmd.Parameters.AddWithValue("@Username", username)
                    cmd.Parameters.AddWithValue("@Password", password)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.HasRows Then
                            reader.Close()
                            If CheckBox1.Checked = True Then
                                My.Settings.rememberedId = username
                                My.Settings.Save()
                            End If
                            If MainForm IsNot Nothing Then
                                MainForm.LoggedInUsername = username
                            End If

                            Dim sql2 As String = "SELECT * FROM GameData WHERE Username = @Username"
                            Using cmd2 As New SqlCommand(sql2, connection)
                                cmd2.Parameters.AddWithValue("@Username", username)

                                Using reader2 As SqlDataReader = cmd2.ExecuteReader()
                                    If reader2.Read() Then
                                        If MainForm IsNot Nothing Then
                                            MainForm.imagePath = reader2.GetString(6)
                                            MainForm.missileImg = reader2.GetString(7)
                                            MainForm.planetAImg = reader2.GetString(8)
                                            MainForm.planetBImg = reader2.GetString(9)
                                            MainForm.spaceshipImg = reader2.GetString(10)
                                        End If
                                        Dim gameMenuControl As New gameMenu
                                        gameMenuControl.ShouldStartTimer = True
                                        MainForm.LoadUserControl(gameMenuControl)
                                    Else
                                        lblError.Text = ("No data found for the user.")
                                    End If
                                End Using
                            End Using
                        Else
                            lblError.Text = "Invalid username or password."
                        End If
                    End Using
                End Using
               
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtPassword.UseSystemPasswordChar = Not txtPassword.UseSystemPasswordChar
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New signUp)
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtPassword.Clear()
        txtUsername.Clear()
        lblError.Text = ""
    End Sub


    Private Sub signIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
    End Sub
End Class
