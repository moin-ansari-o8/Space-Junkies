Imports Game1
Public Class levels
    Public Property MainForm As main
    Public Property Username As String
    Public Sub LoadLevel(ByVal control As UserControl, ByVal panel As Panel)
        If TypeOf control Is iEasy Then
            CType(control, iEasy).MainForm2 = Me
        ElseIf TypeOf control Is iHard Then
            CType(control, iHard).MainForm2 = Me
        ElseIf TypeOf control Is easyMode Then
            CType(control, easyMode).MainForm2 = Me
            CType(control, easyMode).MainForm = Me.MainForm
            CType(control, easyMode).Username = Me.Username
        ElseIf TypeOf control Is hardMode Then
            CType(control, hardMode).MainForm2 = Me
            CType(control, hardMode).MainForm = Me.MainForm
            CType(control, hardMode).Username = Me.Username

        ElseIf TypeOf control Is easyBtn Then
            CType(control, easyBtn).MainForm2 = Me

        ElseIf TypeOf control Is hardBtn Then
            CType(control, hardBtn).MainForm2 = Me
        End If
        panel.Controls.Clear()
        control.Dock = DockStyle.None
        control.Left = (panel.ClientSize.Width - control.Width) / 2
        control.Top = (panel.ClientSize.Height - control.Height) / 2
        panel.Controls.Add(control)
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadLevel(New easyMode, pan1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadLevel(New iEasy, pan1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadLevel(New iHard, pan2)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadLevel(New hardMode, pan1)
    End Sub

    Private Sub levels_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label1.Text = Username
        LoadLevel(New easyBtn, pan1)
        LoadLevel(New hardBtn, pan2)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMenu)
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New iUsername)
        End If
    End Sub

End Class
