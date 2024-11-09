Imports System.Data.SqlClient
Public Class setting
    Public Property MainForm As main
    Public Property Username As String
    Private connectionString As String = conStr
    Private t As Double
    Private v As Double
    Private a As Double
    Private Enum MotionState
        Downward
        Upward
    End Enum

    Private currentState As MotionState
    Private downSpeed As Integer
    Private upSpeed As Integer
    Private downDistance As Integer
    Private shouldLoadSignIn As Boolean = False
    Private shouldLoadGameMenu As Boolean = False

    Private Sub setting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label3.Text = Username
        Image1.BringToFront()
        Timer1.Interval = 10
        hideLogOut()
        hideSwitch()
        t = 0
        v = 40
        a = 90
        currentState = MotionState.Downward
        downSpeed = 10
        upSpeed = 20
        downDistance = 120
    End Sub

    Private Sub showSwitch()
        FlowLayoutPanel1.Visible = True
        Label1.Visible = True
    End Sub

    Private Sub hideSwitch()
        FlowLayoutPanel1.Visible = False
        Label1.Visible = False
    End Sub

    Private Sub showLogOut()
        Label2.Visible = True
    End Sub

    Private Sub hideLogOut()
        Label2.Visible = False
    End Sub

    Private Sub LoadUserButtons()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim sql As String = "SELECT Username FROM GameData"
                Using command As New SqlCommand(sql, connection)
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim username As String = reader("Username").ToString()
                        Dim btn As New Button With {
                            .Text = username,
                            .AutoSize = True,
                            .MinimumSize = New Size(166, 34),
                            .Font = New Font("Maiandra GD", 17)
                        }
                        AddHandler btn.Click, AddressOf UsernameButton_Click
                        FlowLayoutPanel1.Controls.Add(btn)
                    End While
                End Using
            Catch ex As Exception
                MessageBox.Show("Error loading usernames: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UsernameButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        My.Settings.rememberedId = String.Empty
        My.Settings.Save()
        Dim clickedButton As Button = CType(sender, Button)
        If MainForm IsNot Nothing Then
            Dim signIn As New signIn
            signIn.PreFillUsername(clickedButton.Text)
            MainForm.LoadUserControl(signIn)
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        t = 0
        Image2.Visible = False
        shouldLoadGameMenu = True
        shouldLoadSignIn = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer1.Tick
        If currentState = MotionState.Downward Then
            Image1.Top += downSpeed
            If Image1.Top >= downDistance Then
                Timer1.Stop()
                Timer2.Start()
            End If
        ElseIf currentState = MotionState.Upward Then
            Image1.Top -= upSpeed
            If Image1.Bottom <= 0 Then
                Timer1.Stop()
                Timer2.Interval = 1000
                Timer2.Start()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles Timer2.Tick
        Timer2.Stop()

        If currentState = MotionState.Downward Then
            currentState = MotionState.Upward
            Timer1.Start()
        Else

            If shouldLoadSignIn AndAlso MainForm IsNot Nothing Then
                Dim signIn As New signIn

                MainForm.LoadUserControl(signIn)
            End If


            If shouldLoadGameMenu AndAlso MainForm IsNot Nothing Then
                Dim gameMenuControl As New gameMenu
                gameMenuControl.ShouldStartTimer = True
                MainForm.LoadUserControl(gameMenuControl)
            End If
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        t = 0
        FlowLayoutPanel1.Controls.Clear()
        LoadUserButtons()
        showSwitch()
        Image2.Visible = False
        shouldLoadSignIn = False
        shouldLoadGameMenu = False
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        t = 0
        showLogOut()
        Image2.Visible = False
        shouldLoadSignIn = True
        shouldLoadGameMenu = False
        My.Settings.rememberedId = String.Empty
        My.Settings.Save()
        Timer1.Start()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New iUsername)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New editGame)
        End If
    End Sub
End Class
