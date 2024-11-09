Imports System.Data.SqlClient
Public Class gameMenu
    Public Property MainForm As main
    Public Property Username As String
    Public Property ShouldStartTimer As Boolean = False

    Private initialPosition As Integer
    Private destinationY As Integer = 479
    Private downwardMovement As Boolean = False

    Private Sub gameMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Username


        initialPosition = Me.Height
        Image1.Top = initialPosition
        Image1.Left = Image1.Left

        Image2.Visible = False

        If ShouldStartTimer Then
            Timer1.Interval = 10
            Timer1.Start()
        Else
            Image1.Top = destinationY
            Image2.Visible = True
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If Not downwardMovement Then

            If Image1.Top > destinationY - 80 Then
                Image1.Top -= 10
            Else
                downwardMovement = True
            End If
        Else
            ' Move Image1 downward slightly after reaching destination
            If Image1.Top < destinationY + 20 Then ' Adjust the "+ 20" value for how far down you want it to go
                Image1.Top += 5 ' Adjust the speed by changing the value 5
            Else
                Timer1.Stop()
                Image1.Top = destinationY + 20 ' Ensure it lands exactly at the final position
                Image2.Visible = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mode As String = ""
        Dim lvl As Integer
        Dim connectionString As String = conStr
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim sql2 As String = "SELECT * FROM GameData WHERE Username = @Username"
                Using cmd2 As New SqlCommand(sql2, connection)
                    cmd2.Parameters.AddWithValue("@Username", Username)

                    Using reader2 As SqlDataReader = cmd2.ExecuteReader()
                        If reader2.Read() Then

                            mode = reader2.GetString(1)
                            lvl = reader2.GetInt32(2)

                        Else
                        MessageBox.Show("No data found for the user.")
                        End If
                    End Using
                End Using
                If MainForm IsNot Nothing Then
                    MainForm.LoadUserControl(New gameMainInterface(mode, lvl))
                End If
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New levels)
        End If
    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameInfo1)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New iUsername)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New scoreBoard)
        End If
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New setting)
        End If
    End Sub
End Class
