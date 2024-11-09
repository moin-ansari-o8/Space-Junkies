Imports Game1
Public Class main

    Public Property LoggedInUsername As String = Nothing
    Public Property imagePath As String
    Public Property missileImg As String
    Public Property planetAImg As String
    Public Property planetBImg As String
    Public Property spaceshipImg As String
    Public currentGameInterface As gameMainInterface
    Public Sub LoadUserControl(ByVal control As UserControl)

        If TypeOf control Is signIn Then
            CType(control, signIn).MainForm = Me
        ElseIf TypeOf control Is signUp Then
            CType(control, signUp).MainForm = Me
        ElseIf TypeOf control Is gameMainInterface Then
            CType(control, gameMainInterface).MainForm = Me
            CType(control, gameMainInterface).Username = Me.LoggedInUsername
            CType(control, gameMainInterface).imagePath = Me.imagePath
            CType(control, gameMainInterface).missileImg = Me.missileImg
            CType(control, gameMainInterface).planetAImg = Me.planetAImg
            CType(control, gameMainInterface).planetBImg = Me.planetBImg
            CType(control, gameMainInterface).spaceshipImg = Me.spaceshipImg
        ElseIf TypeOf control Is gameMenu Then
            CType(control, gameMenu).MainForm = Me
            CType(control, gameMenu).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is levels Then
            CType(control, levels).MainForm = Me
            CType(control, levels).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is gameInfo3 Then
            CType(control, gameInfo3).MainForm = Me
            CType(control, gameInfo3).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is gameInfo2 Then
            CType(control, gameInfo2).MainForm = Me
            CType(control, gameInfo2).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is gameInfo1 Then
            CType(control, gameInfo1).MainForm = Me
            CType(control, gameInfo1).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is iUsername Then
            CType(control, iUsername).MainForm = Me
            CType(control, iUsername).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is scoreBoard Then
            CType(control, scoreBoard).MainForm = Me
            CType(control, scoreBoard).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is setting Then
            CType(control, setting).MainForm = Me
            CType(control, setting).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is editGame Then
            CType(control, editGame).MainForm = Me
            CType(control, editGame).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is pauseBtn Then
            CType(control, pauseBtn).MainForm = Me
            CType(control, pauseBtn).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is easyMode Then
            CType(control, easyMode).MainForm = Me
            CType(control, easyMode).Username = Me.LoggedInUsername
        ElseIf TypeOf control Is hardMode Then
            CType(control, hardMode).MainForm = Me
            CType(control, hardMode).Username = Me.LoggedInUsername
        End If
        Panel1.Controls.Clear()
        control.Dock = DockStyle.None
        control.Left = (Panel1.ClientSize.Width - control.Width) / 2
        control.Top = (Panel1.ClientSize.Height - control.Height) / 2
        Panel1.Controls.Add(control)
        If Not TypeOf control Is gameMainInterface Then
            AddCloseButtonToPanel()
        End If
    End Sub
    Private Sub AddCloseButtonToPanel()
        Dim closeButton As New Button()
        closeButton.Text = "X"
        closeButton.Font = New Font("Maiandra GD", 12, FontStyle.Bold)
        closeButton.Width = 30
        closeButton.Height = 30
        closeButton.BackColor = Color.Yellow
        closeButton.ForeColor = Color.Black
        closeButton.Left = Panel1.Width - closeButton.Width - 20
        closeButton.Top = 25
        AddHandler closeButton.Click, AddressOf CloseButton_Click
        Panel1.Controls.Add(closeButton)
        closeButton.BringToFront()
    End Sub
    Private Sub CloseButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub
    Public Sub SetCurrentGameInterface(ByVal gameInterface As gameMainInterface)
        currentGameInterface = gameInterface
    End Sub
    Public Function GetCurrentGameInterface() As gameMainInterface
        Return currentGameInterface
    End Function
    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not String.IsNullOrEmpty(My.Settings.rememberedId) 
            LoggedInUsername = My.Settings.rememberedId
            LoadUserControl(New gameMenu())
        Else
            LoadUserControl(New signIn())
        End If

    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
