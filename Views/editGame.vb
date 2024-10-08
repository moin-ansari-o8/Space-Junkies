Public Class editGame
    Public Property MainForm As main
    Public Property Username As String
    Dim gameInterfaceControl As New gameMainInterface()
    Dim editBgControl As editBG ' Make sure this is assigned correctly
    Dim editMissileControl As editMissile
    Dim editPlanetAControl As editPlanetA
    Dim editPlanetBControl As editPlanetB
    Dim editSpaceshipControl As editSpaceship



    Public Sub LoadSetting(ByVal control As UserControl, ByVal panel As Panel)
        If TypeOf control Is editBG Then
            editBgControl = CType(control, editBG)
            CType(control, editBG).MainForm2 = Me
            CType(control, editBG).Username = Me.Username
        ElseIf TypeOf control Is editMissile Then
            editMissileControl = CType(control, editMissile)
            CType(control, editMissile).MainForm2 = Me
            CType(control, editMissile).Username = Me.Username
        ElseIf TypeOf control Is editPlanetA Then
            editPlanetAControl = CType(control, editPlanetA)
            CType(control, editPlanetA).MainForm2 = Me
            CType(control, editPlanetA).Username = Me.Username
        ElseIf TypeOf control Is editPlanetB Then
            editPlanetBControl = CType(control, editPlanetB)
            CType(control, editPlanetB).MainForm2 = Me
            CType(control, editPlanetB).Username = Me.Username
        ElseIf TypeOf control Is editSpaceship Then
            editSpaceshipControl = CType(control, editSpaceship)
            CType(control, editSpaceship).MainForm2 = Me
            CType(control, editSpaceship).Username = Me.Username
        
        End If
        panel.Controls.Clear()
        control.Dock = DockStyle.None
        panel.Controls.Add(control)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        LoadSetting(New editBG, Panel1)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New setting)
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoadSetting(New editMissile, Panel1)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        LoadSetting(New editPlanetB, Panel1)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        LoadSetting(New editPlanetA, Panel1)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        LoadSetting(New editSpaceship, Panel1)
    End Sub

    Private Sub editGame_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadSetting(New editBG, Panel1)
    End Sub

End Class
