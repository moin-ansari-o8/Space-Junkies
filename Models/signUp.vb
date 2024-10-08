Imports System.Data.SqlClient
Public Class signUp
    Public Property MainForm As main

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If validateInputs() Then
            If insertData() Then
                If MainForm IsNot Nothing Then
                    MainForm.LoadUserControl(New signIn())
                End If
            Else
                MessageBox.Show("Error Registering User")
            End If
        End If
    End Sub

    Public Function insertData() As Boolean
        Dim username As String = txt1.Text.Trim()
        Dim emailID As String = txt2.Text.Trim()
        Dim password As String = txt3.Text.Trim()
        Dim connectionString As String = conStr
        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()

            Dim command As New SqlCommand() With {
                .Connection = connection
            }

            ' First SQL command
            command.CommandText = "INSERT INTO UserInfo (Username, EmailID, Password) VALUES (@Username, @EmailID, @Password)"
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@EmailID", emailID)
            command.Parameters.AddWithValue("@Password", password)
            command.ExecuteNonQuery()

            ' Clear the parameters for the next command
            command.Parameters.Clear()

            ' Second SQL command
            command.CommandText = "INSERT INTO GameData VALUES (@Username,'Easy',1,0, 0, 0,@bgImg,@missileImg,@planetAImg,@planetBImg,@spaceshipImg)"
            command.Parameters.AddWithValue("@Username", username)
            command.Parameters.AddWithValue("@bgImg", "DarkGray")
            command.Parameters.AddWithValue("@missileImg", "C:\PROJECT_VB\Game1\Game1\Resources\missile.png")
            command.Parameters.AddWithValue("@planetAImg", "C:\PROJECT_VB\Game1\Game1\Resources\enemy planet.png")
            command.Parameters.AddWithValue("@planetBImg", "C:\PROJECT_VB\Game1\Game1\Resources\planet.png")
            command.Parameters.AddWithValue("@spaceshipImg", "C:\PROJECT_VB\Game1\Game1\Resources\enemy.png")
            command.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error registering user: " & ex.Message)
            Return False
        Finally
            connection.Close()
        End Try
        Return True
    End Function

    Public Function IsValidEmail(ByVal email As String) As Boolean
        Return InStr(email, "@") > 0 AndAlso InStr(email, ".") > InStr(email, "@") + 1
    End Function

    Private Function IsUsernameExists(ByVal username As String) As Boolean
        Dim connectionString As String = conStr
        Dim connection As New SqlConnection(connectionString)
        Dim exists As Boolean = False

        Try
            connection.Open()

            Dim command As New SqlCommand("SELECT COUNT(*) FROM UserInfo WHERE Username = @Username", connection)
            command.Parameters.AddWithValue("@Username", username)

            Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
            exists = (count > 0)

        Catch ex As Exception
            MessageBox.Show("Error checking username: " & ex.Message)
        Finally
            connection.Close()
        End Try

        Return exists
    End Function

    Private Function validateInputs() As Boolean
        If String.IsNullOrWhiteSpace(txt1.Text) Then
            lbl1.Text = "Username is required!"
            txt1.Focus()
            Return False
        End If

        If IsUsernameExists(txt1.Text.Trim()) Then
            lbl1.Text = "Username already exists!"
            txt1.Focus()
            Return False
        End If

        If Not IsValidEmail(txt2.Text.Trim()) Then
            labelClear()
            lbl2.Text = "Invalid Email form!"
            txt2.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txt3.Text) Then
            labelClear()
            lbl3.Text = "Password is required!"
            txt3.Focus()
            Return False
        End If

        If txt3.Text.Trim().Length < 8 Then
            labelClear()
            lbl3.Text = "Password must be at least 8 characters long."
            txt3.Focus()
            Return False
        End If

        If (txt3.Text.ToString() <> txt4.Text.ToString()) Then
            labelClear()
            lbl4.Text = "Passwords must be the same!"
            txt4.Focus()
            Return False
        End If

        labelClear()
        Return True
    End Function

    Private Sub textBClear()
        txt1.Clear()
        txt2.Clear()
        txt3.Clear()
        txt4.Clear()
    End Sub

    Private Sub labelClear()
        lbl1.Text = ""
        lbl2.Text = ""
        lbl3.Text = ""
        lbl4.Text = ""
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        textBClear()
        labelClear()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New signIn())
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txt3.UseSystemPasswordChar = Not txt3.UseSystemPasswordChar
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
    End Sub
End Class
