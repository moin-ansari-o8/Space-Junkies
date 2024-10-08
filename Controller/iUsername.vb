Imports System.Data.SqlClient
Public Class iUsername
    Public Property MainForm As main
    Public Property Username As String
    Dim connectionString As String = conStr
    Private t As Double = 0
    Private v As Double = 40 ' Initial velocity (you can adjust this)
    Private a As Double = 90 ' Angle in degrees (90 degrees for upward movement)

    Private Enum MotionState
        Downward
        Upward
    End Enum

    Private currentState As MotionState = MotionState.Downward ' Initial state is downward
    Private downSpeed As Integer = 10 ' Speed for downward motion (pixels per tick)
    Private upSpeed As Integer = 20 ' Speed for upward motion (pixels per tick)
    Private downDistance As Integer = 160 ' Distance to move downward before going up


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t = 0 ' Reset time
        Image2.Visible = False
        Timer1.Start()
    End Sub
    Private Sub load_data()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to fetch data based on the username
                Dim sql As String = "SELECT Highscore, Normal_Level, Hard_Level FROM GameData WHERE Username = @Username"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Username", Username)

                    ' Execute the query and read the data
                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Assign the fetched values to the respective textboxes
                            TextBox1.Text = reader("Highscore").ToString()
                            TextBox2.Text = reader("Normal_Level").ToString()
                            TextBox3.Text = reader("Hard_Level").ToString()
                        Else
                            MessageBox.Show("No data found for the user.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub iUsername_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_data()
        Image1.BringToFront()
        Timer1.Interval = 10 ' Adjust the interval as needed (in milliseconds)
        Timer1.Enabled = False
        'OriginalTopPosition = Image1.Top
        Dim hello As New Label With {
        .Text = "Hello there!,",
        .AutoSize = True,
        .Font = New Font("Maiandra GD", 28.75, FontStyle.Bold),
        .Location = New Point(904, 105)
    }
        Dim usr As New Label With {
            .Text = Username,
            .AutoSize = True,
            .Font = New Font("Maiandra GD", 28, FontStyle.Bold),
            .Location = New Point(1140, 107),
            .ForeColor = Color.Blue
        }

        Controls.Add(hello)
        Controls.Add(usr)

    End Sub
    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If currentState = MotionState.Downward Then
            ' Move the PictureBox downwards at downSpeed
            Image1.Top += downSpeed

            ' Check if the image has moved down enough
            If Image1.Top >= downDistance Then ' Move down by 50 pixels (adjust as needed)
                Timer1.Stop()
                'Timer2.Interval = 1000 ' Pause for 1 second before moving up
                Timer2.Start() ' Start the second timer for 1-second delay
            End If
        ElseIf currentState = MotionState.Upward Then
            ' Move the PictureBox upwards at upSpeed
            Image1.Top -= upSpeed

            ' Stop the timer if the PictureBox has moved completely out of the view
            If Image1.Bottom <= 0 Then
                Timer1.Stop()
                Timer2.Interval = 1000 ' Set the delay to 2 seconds before loading the next UserControl
                Timer2.Start() ' Start the second timer for 2-second delay
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        Timer2.Stop() ' Stop the delay timer

        If currentState = MotionState.Downward Then
            ' Change state to upward motion
            currentState = MotionState.Upward
            Timer1.Start() ' Resume the timer to start upward motion
        Else
            ' Load the next UserControl
            If MainForm IsNot Nothing Then
                Dim gameMenuControl As New gameMenu
                gameMenuControl.ShouldStartTimer = True
                MainForm.LoadUserControl(gameMenuControl)
            End If
        End If
    End Sub

    Private Sub UpdateData(ByVal fieldName As String, ByVal value As Integer, ByVal textBox As TextBox)
        ' Connection string to your database
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Update SQL query based on fieldName
                Dim sqlUpdate As String = "UPDATE GameInfo SET " + fieldName + " = @Value WHERE Username = @Username"
                Using commandUpdate As New SqlCommand(sqlUpdate, connection)
                    commandUpdate.Parameters.AddWithValue("@Value", value)
                    commandUpdate.Parameters.AddWithValue("@Username", Username)

                    ' Execute the update command
                    Dim rowsAffected As Integer = commandUpdate.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        ' Update successful
                        'MessageBox.Show($"{fieldName} updated to {value}.")
                        ' Clear the TextBox
                        load_data()
                    Else
                        MessageBox.Show("No data found to update.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        UpdateData("Highscore", 0, TextBox1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        UpdateData("Normal_Level", 1, TextBox2)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        UpdateData("Hard_Level", 1, TextBox2)
    End Sub
End Class
