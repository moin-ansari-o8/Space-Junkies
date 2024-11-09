Imports System.Data.SqlClient

Public Class scoreBoard
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
    Private downDistance As Integer = 120 ' Distance to move downward before going up

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t = 0 ' Reset time
        Image2.Visible = False
        Timer1.Start()
    End Sub

    Private Sub scoreBoard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadScoreBoardData()
        Timer1.Interval = 10 ' Adjust the interval as needed (in milliseconds)
        Timer1.Enabled = False
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

    Private Sub LoadScoreBoardData()
        ' Clear existing labels first to avoid overlapping
        'For Each ctrl As Control In Me.Controls
        '    If TypeOf ctrl Is Label AndAlso ctrl.Tag Is Nothing Then
        '        Me.Controls.Remove(ctrl)
        '    End If
        'Next

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' SQL query to select data in descending order by Highscore
                Dim sql As String = "SELECT Username, Highscore FROM GameData ORDER BY Highscore DESC"
                Using command As New SqlCommand(sql, connection)
                    Dim adapter As New SqlDataAdapter(command)
                    Dim dataTable As New DataTable()
                    adapter.Fill(dataTable)

                    ' Starting position below the heading
                    Dim yOffset As Integer = LabelHeadingUsername.Bottom + 30

                    For Each row As DataRow In dataTable.Rows
                        Dim usernameLabel As New Label With {
                            .Text = row("Username").ToString(),
                            .AutoSize = True,
                            .Font = New Font("Maiandra GD", 16),
                            .Location = New Point(LabelHeadingUsername.Left + 5, yOffset)
                        }

                        Dim highscoreLabel As New Label With {
                            .Text = row("Highscore").ToString(),
                            .AutoSize = True,
                            .Font = New Font("Maiandra GD", 16),
                            .Location = New Point(LabelHeadingHighscore.Left + 20, yOffset)
                        }

                        ' Check if the current row matches the username to highlight
                        If usernameLabel.Text.ToString() = Username Then
                            usernameLabel.BackColor = Color.Yellow ' Highlight color for username
                            highscoreLabel.BackColor = Color.Yellow ' Highlight color for highscore
                        End If

                        ' Add labels to the form
                        Me.Controls.Add(usernameLabel)
                        Me.Controls.Add(highscoreLabel)

                        yOffset += usernameLabel.Height + 5 ' Update the position for the next row
                    Next
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading data: " & ex.Message)
            End Try
        End Using
    End Sub
End Class
