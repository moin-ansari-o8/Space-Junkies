Public Class pauseBtn
    Public Property MainForm As main
    Public Property Username As String
    Dim connectionString As String = conStr
    Private t As Double = 0
    Private v As Double = 40 ' Initial velocity (you can adjust this)
    Private a As Double = 90 ' Angle in degrees (90 degrees for upward movement)
    Private modeS As String
    Private lvlS As Integer
    Private Enum MotionState
        Downward
        Upward
    End Enum

    Private currentState As MotionState = MotionState.Downward ' Initial state is downward
    Private downSpeed As Integer = 10 ' Speed for downward motion (pixels per tick)
    Private upSpeed As Integer = 20 ' Speed for upward motion (pixels per tick)
    Private downDistance As Integer = 160 ' Distance to move downward before going up

    Public Sub New(ByVal mode As String, ByVal lvl As Integer)
        InitializeComponent()
        modeS = mode
        lvlS = lvl
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm IsNot Nothing Then
            ' Get the existing gameMainInterface instance
            Dim existingGameInterface As gameMainInterface = MainForm.GetCurrentGameInterface()

            ' Check if the instance exists
            If existingGameInterface IsNot Nothing Then
                ' Reload the existing gameMainInterface instance
                MainForm.LoadUserControl(existingGameInterface)
            Else
                MessageBox.Show("Error: No previous game session found.")
            End If
        End If
    End Sub

 
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        t = 0 ' Reset time
        Image2.Visible = False
        Timer1.Start()
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
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub pauseBtn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Image1.BringToFront()
        Timer1.Interval = 10 ' Adjust the interval as needed (in milliseconds)
        Timer1.Enabled = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm IsNot Nothing Then
            Dim gameInt As New gameMainInterface(modeS, lvlS)
            MainForm.LoadUserControl(gameInt)
        End If
    End Sub
End Class
