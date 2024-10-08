Imports System.Data.SqlClient
Public Class gameMainInterface
    Public Property MainForm As main
    Public Property MainForm2 As editGame
    Public Property Username As String
    Dim connectionString As String = conStr
    Private WithEvents missileTimer As New Timer With {.Interval = 10}
    Private WithEvents effectTimer As New Timer With {.Interval = 1000}
    Private WithEvents enemyMovementTimer As New Timer With {.Interval = 10}
    Private missileHit As Boolean = False
    Private t As Double ' Time variable for trajectory calculation
    Private x As Double
    Private y As Double
    Private velocity As Double ' Declare as class-level variable
    Private angle As Double ' Declare as class-level variable
    Private tot As Integer = 0
    Private enemyMoveDistance As Integer = 0 ' Movement distance for enemy objects
    Private enemyDirections As Dictionary(Of PictureBox, Boolean) ' True for down, False for up
    Private enemyAreas As Dictionary(Of PictureBox, Rectangle) ' Reserved areas for enemies
    Private Const MIN_Y As Integer = 23 ' Minimum Y position for enemy movement
    Private Const MAX_Y As Integer = 607 ' Maximum Y position for enemy movement
    Private missileAttemptsRemaining As Integer  ' Changed from tot
    Private objects As PictureBox()
    Private objectSizes As Size()
    Private newObjectList As PictureBox()
    Private newObjectSizes As Size()
    Private names As String()
    Private scores As Integer()
    Private newNames As String()
    Private newScores As Integer()
    Private arr As List(Of PictureBox) = New List(Of PictureBox)()
    Private nImg As Integer
    Private hitObj As Integer = 0
    Private dSize As Integer
    Private moveEn As Boolean
    Private isReload As Boolean
    Private moveSp As Integer
    Public modeS As String
    Public lvlS As Integer
    Public userELvl As Integer
    Public userHLvl As Integer
    Public imagePath As String
    Public missileImg As String
    Public planetAImg As String
    Public planetBImg As String
    Public spaceshipImg As String
    Public Sub New()
        InitializeComponent()
        InitializeGameObjects(2, 20, True, 2, 3, False)
    End Sub

    Public Sub New(ByVal numImages As Integer, ByVal decreaseSize As Integer, ByVal moveEnemies As Boolean, ByVal movementSpeed As Integer, ByVal trials As Integer, ByVal reload As Boolean)
        InitializeComponent()
        InitializeGameObjects(numImages, decreaseSize, moveEnemies, movementSpeed, trials, reload)
    End Sub
    Public Sub New(ByVal mode As String, ByVal lvl As Integer)
        InitializeComponent()
        modeS = mode
        lvlS = lvl
        If mode = "Hard" Then
            If lvl = 1 Then
                nImg = 1
                InitializeGameObjects(1, 0, True, 2, 3, False)
            ElseIf lvl = 2 Then
                nImg = 2
                InitializeGameObjects(2, 0, True, 2, 4, False)
            ElseIf lvl = 3 Then
                nImg = 3
                InitializeGameObjects(3, 30, True, 2, 5, False)
            ElseIf lvl = 4 Then
                nImg = 3
                InitializeGameObjects(3, 40, True, 3, 4, False)
            ElseIf lvl = 5 Then
                nImg = 3
                InitializeGameObjects(3, 60, True, 4, 3, False)
            End If
        ElseIf mode = "Easy" Then
            If lvl = 1 Then
                nImg = 2
                InitializeGameObjects(2, 20, False, 2, 5, False)
            ElseIf lvl = 2 Then
                nImg = 2
                InitializeGameObjects(2, 30, False, 2, 4, False)
            ElseIf lvl = 3 Then
                nImg = 3
                InitializeGameObjects(3, 20, False, 2, 5, False)
            ElseIf lvl = 4 Then
                nImg = 3
                InitializeGameObjects(3, 40, False, 2, 3, False)
            ElseIf lvl = 5 Then
                nImg = 3
                InitializeGameObjects(3, 60, False, 2, 3, False)

            End If
        End If
    End Sub
    Private Sub InitializeGameObjects(ByVal numImages As Integer, ByVal decreaseSize As Integer, ByVal moveEnemies As Boolean, ByVal movementSpeed As Integer, ByVal trials As Integer, ByVal reload As Boolean)
        objects = {Image2, Image3, Image4}
        objectSizes = {Image2.Size, Image3.Size, Image4.Size}
        names = {"Planet A", "Spaceship", "Planet B"}
        scores = {20, 50, 30}
        nImg = numImages
        dSize = decreaseSize
        moveEn = moveEnemies
        moveSp = movementSpeed
        missileAttemptsRemaining = trials
        isReload = reload
    End Sub

    Private Sub gameMainInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        load_interface()
        setPic(Me.nImg, Me.objects, Me.objectSizes, Me.names, Me.scores, Me.dSize, Me.moveEn, Me.moveSp, Me.missileAttemptsRemaining, Me.isReload)
    End Sub
    Private Sub updateLevel()
        If modeS = "Hard" Then
            If userHLvl < lvlS Then
                UpdateData(Username, "Hard_Level", lvlS)
            End If
        ElseIf modeS = "Easy" Then
            If userELvl < lvlS Then
                UpdateData(Username, "Normal_Level", lvlS)
            End If
        End If
    End Sub
    Private Sub nextLevel()
        Label6.Text = "YOU WON THIS GAME!"
        Label6.Visible = True
        Button4.Visible = True
        Button2.Visible = True
        
    End Sub
    Private Sub load_interface()
        UpdateData(Username, "Curr_Mode", modeS)
        UpdateData(Username, "Curr_Lvl", lvlS)
        Label4.Text = modeS + " :"
        Label5.Text = lvlS
        Using connection As New SqlConnection(conStr)
            Try
                connection.Open()
                Dim sql As String = "SELECT * FROM GameData WHERE Username = @Username"
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Username", Username)

                    Using reader As SqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            ' Assign the fetched values to the respective textboxes
                            userELvl = reader.GetInt32(4)
                            userHLvl = reader.GetInt32(5)
                            imagePath = reader.GetString(6)
                            missileImg = reader.GetString(7)
                            planetAImg = reader.GetString(8)
                            planetBImg = reader.GetString(9)
                            spaceshipImg = reader.GetString(10)
                        Else
                            MessageBox.Show("No data found for the user.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Error fetching data: " & ex.Message)
            End Try
        End Using
        If Not String.IsNullOrEmpty(imagePath) Then
            If imagePath = "DarkGray" Then
                Me.BackColor = Color.DarkGray
            ElseIf imagePath = "DimGray" Then
                Me.BackColor = Color.DimGray
            ElseIf imagePath = "DarkSalmon" Then
                Me.BackColor = Color.DarkSalmon
            End If
        End If
        If Not String.IsNullOrEmpty(missileImg) Then
            Select Case missileImg
                Case "m1"
                    Image1.Image = My.Resources.missile2
                Case "m2"
                    Image1.Image = My.Resources.missile1
                Case "m3"
                    Image1.Image = My.Resources.missile3
            End Select

            ' Set other missile images to the same resource as Image1
            missile1.Image = Image1.Image
            missile2.Image = Image1.Image
            missile3.Image = Image1.Image
            missile4.Image = Image1.Image
            missile5.Image = Image1.Image
        End If

        If Not String.IsNullOrEmpty(planetAImg) Then
            Select Case planetAImg
                Case "p1"
                    Image4.Image = My.Resources.enemy_planet
                Case "p2"
                    Image4.Image = My.Resources.planet
                Case "p3"
                    Image4.Image = My.Resources.planet3
            End Select
            Image4.SizeMode = PictureBoxSizeMode.Zoom
            Image4.BackColor = Color.Transparent
        End If
        If Not String.IsNullOrEmpty(planetBImg) Then
            Select Case planetBImg
                Case "p1"
                    Image2.Image = My.Resources.enemy_planet
                Case "p2"
                    Image2.Image = My.Resources.planet
                Case "p3"
                    Image2.Image = My.Resources.planet3
            End Select
            Image2.SizeMode = PictureBoxSizeMode.Zoom
            Image2.BackColor = Color.Transparent

        End If
        If Not String.IsNullOrEmpty(spaceshipImg) Then
            Select Case spaceshipImg
                Case "s1"
                    Image3.Image = My.Resources.rocket
                Case "s2"
                    Image3.Image = My.Resources.enemy
                Case "s3"
                    Image3.Image = My.Resources.spaceship3
            End Select
            Image3.SizeMode = PictureBoxSizeMode.Zoom
            Image3.BackColor = Color.Transparent
        End If
    End Sub
    Private Sub UpdateScore(ByVal fieldName As String, ByVal value As Integer)
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim currentValue As Integer
                Dim sqlSelect As String = "SELECT " + fieldName + " FROM GameData WHERE Username = @Username"
                Using commandSelect As New SqlCommand(sqlSelect, connection)
                    commandSelect.Parameters.AddWithValue("@Username", Username)
                    Dim result = commandSelect.ExecuteScalar()
                    If result IsNot Nothing AndAlso Integer.TryParse(result.ToString(), currentValue) Then
                        currentValue += value
                    Else
                        currentValue = value
                    End If
                End Using
                Dim sqlUpdate As String = "UPDATE GameData SET " + fieldName + " = @Value WHERE Username = @Username"
                Using commandUpdate As New SqlCommand(sqlUpdate, connection)
                    commandUpdate.Parameters.AddWithValue("@Value", currentValue)
                    commandUpdate.Parameters.AddWithValue("@Username", Username)
                    commandUpdate.ExecuteNonQuery()
                End Using

            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub setPic(ByVal numImages As Integer, ByVal objects As PictureBox(), ByVal objectSizes As Size(), ByVal names As String(), ByVal scores As Integer(), ByVal decreaseSize As Integer, ByVal moveEnemies As Boolean, ByVal movementSpeed As Integer, ByVal trials As Integer, ByVal reload As Boolean)
        For i As Integer = 1 To trials
            Dim missiles As PictureBox = TryCast(Me.Controls("missile" & i), PictureBox)
            If missiles IsNot Nothing Then
                missiles.Visible = True
            Else
                MessageBox.Show("Error: Missile" & i & " not found.")
            End If
        Next
        newObjectList = New PictureBox(numImages - 1) {}
        newObjectSizes = New Size(numImages - 1) {}
        newNames = New String(numImages - 1) {}
        newScores = New Integer(numImages - 1) {}
        Array.Copy(objects, newObjectList, numImages)
        Array.Copy(objectSizes, newObjectSizes, numImages)
        Array.Copy(names, newNames, numImages)
        Array.Copy(scores, newScores, numImages)
        loadingManager(numImages, newObjectList, newObjectSizes, newNames, newScores, decreaseSize, moveEnemies, movementSpeed, trials, reload)
    End Sub

    Private Sub loadingManager(ByVal numImages As Integer, ByVal objects As PictureBox(), ByVal objectSizes As Size(), ByVal names As String(), ByVal scores As Integer(), ByVal decreaseSize As Integer, ByVal moveEnemies As Boolean, ByVal movementSpeed As Integer, ByVal trials As Integer, ByVal reload As Boolean)
        Image1.Visible = False
        Image1.Location = New Point(91, 746)
        Label3.Text = ""
        missileAttemptsRemaining = trials
        enemyMoveDistance = movementSpeed
        ' Initialize dictionaries
        enemyAreas = New Dictionary(Of PictureBox, Rectangle)()

        Dim rnd As New Random()
        Dim leftUpperCorner As New Point(318, 30)
        Dim rightLowerCorner As New Point(1870, 712)
        Dim positions As New List(Of Point)
        Dim maxAttempts As Integer = 1000

        For i As Integer = 0 To numImages - 1
            newObjectSizes(i) = New Size(Math.Max(0, newObjectSizes(i).Width - decreaseSize), Math.Max(0, newObjectSizes(i).Height - decreaseSize))
        Next

        ' Apply the adjusted sizes to the PictureBoxes
        For i As Integer = 0 To newObjectList.Length - 1
            newObjectList(i).Size = newObjectSizes(i)
        Next

        enemyAreas = New Dictionary(Of PictureBox, Rectangle)
        For i As Integer = 0 To newObjectList.Length - 1
            If newObjectList(i) IsNot Nothing Then
                Dim attempts As Integer = 0
                Dim location As Point
                Dim currentSize As Size = newObjectSizes(i)
                Dim reservedArea As Rectangle
                Do
                    location = New Point(
                        rnd.Next(leftUpperCorner.X, rightLowerCorner.X - currentSize.Width),
                        rnd.Next(leftUpperCorner.Y, rightLowerCorner.Y - currentSize.Height)
                    )
                    reservedArea = New Rectangle(location, currentSize)
                    attempts += 1
                Loop While positions.Any(Function(p) IsOverlapping(p, reservedArea)) AndAlso attempts < maxAttempts
                If attempts < maxAttempts Then
                    positions.Add(location)
                    newObjectList(i).Location = location
                    enemyAreas(newObjectList(i)) = reservedArea
                Else
                    MessageBox.Show("Failed to place all enemy objects without overlapping.")
                End If
            Else
                MessageBox.Show("Error: Object not initialized.")
            End If
        Next
        enemyDirections = New Dictionary(Of PictureBox, Boolean) From {
          {Image2, True},
          {Image3, True},
          {Image4, True}
      }
        ' Ensure all objects are visible
        For Each enemyObject As PictureBox In newObjectList
            If enemyObject IsNot Nothing Then
                enemyObject.Visible = True
                If reload Then
                    tot = 0
                    MyScore.Text = ""
                    Me.Controls.Add(enemyObject)
                End If
            Else
                MessageBox.Show("Error: One or more objects in newObjectList are not initialized.")
            End If
        Next

        ' Hide the blast images initially
        For j As Integer = 1 To 3
            Dim blastImage As PictureBox = TryCast(Me.Controls("Image5_" & j), PictureBox)
            If blastImage IsNot Nothing Then
                blastImage.Visible = False
            Else
                MessageBox.Show("Error: Blast image Image5_" & j & " not found.")
            End If
        Next
        If moveEnemies Then
            enemyMovementTimer.Start()
        Else
            enemyMovementTimer.Stop()
        End If
    End Sub

    Private Function IsOverlapping(ByVal pos1 As Point, ByVal rect2 As Rectangle) As Boolean
        Dim rect1 As New Rectangle(pos1, rect2.Size)
        Return rect1.IntersectsWith(rect2)
    End Function

    Private Sub Command1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command1.Click
        
        If missileAttemptsRemaining = 0 Then
            Label6.Visible = True
            Button1.Visible = True
            Button2.Visible = True
            Return
        End If
        If missileAttemptsRemaining > 0 Then
            missileTimer.Stop() 'if already running then it'll jus          
            Label3.Text = ""
            RemoveHandler missileTimer.Tick, AddressOf MissileMovementHandler
            If String.IsNullOrWhiteSpace(Text1.Text) Then
                Label3.Text = "Enter Velocity!"
                Text1.Focus()
                Return
            Else
                velocity = Double.Parse(Text1.Text)
            End If
            If String.IsNullOrWhiteSpace(Text2.Text) Then
                Label3.Text = "Enter Angle!"
                Text2.Focus()
                Return
            Else
                angle = Double.Parse(Text2.Text)
            End If

            x = 0
            y = 0
            t = 0

            Image1.Location = New Point(91, 746)
            Image1.Visible = True

            StartMissileTimer()
            Dim missile As PictureBox = TryCast(Me.Controls("missile" & missileAttemptsRemaining), PictureBox)
            missile.Visible = False
            ' Decrease the number of remaining attempts
            missileAttemptsRemaining -= 1
            
        End If
    End Sub


    Private Sub StartMissileTimer()
        
        missileHit = False
        AddHandler missileTimer.Tick, AddressOf MissileMovementHandler
        missileTimer.Start()
    End Sub

    Private Sub MissileMovementHandler(ByVal sender As Object, ByVal e As EventArgs)
        y = velocity * Math.Sin(angle * Math.PI / 180) * t - 4.9 * (t ^ 2)
        x = velocity * Math.Cos(angle * Math.PI / 180) * t

        Dim missileLocation As New Point(91 + CInt(x), 746 - CInt(y))

        If missileLocation.Y > Me.ClientSize.Height OrElse missileLocation.X > Me.ClientSize.Width OrElse missileLocation.Y < 0 OrElse missileLocation.X < 0 Then
            missileTimer.Stop()
            Label3.Text = ("You Missed the Target!")
            
            If missileAttemptsRemaining = 0 Then
                Label6.Visible = True
                Button1.Visible = True
                Button2.Visible = True
            End If
            ResetMissile()
        Else
            Image1.Location = missileLocation
            If CheckMissileCollision(missileLocation, newObjectList, newNames, newScores) Then
                missileTimer.Stop()
                ResetMissile()
            End If
        End If

        t += 0.1
    End Sub

    Private Sub ResetMissile()
        Image1.Visible = False
        Image1.Location = New Point(91, 746)
    End Sub

    Private Function CheckMissileCollision(ByVal missilePos As Point, ByVal objects As PictureBox(), ByVal names As String(), ByVal scores As Integer()) As Boolean
        For i As Integer = 0 To objects.Length - 1
            If objects(i).Visible Then
                Dim enemyRect As Rectangle = enemyAreas(objects(i))
                Dim missileRect As New Rectangle(missilePos, Image1.Size)

                If missileRect.IntersectsWith(enemyRect) Then
                    If missileRect.IntersectsWith(enemyRect) Then
                        If Not missileHit Then
                            missileHit = True
                            objects(i).Visible = False
                            arr.Add(objects(i))
                            Dim rnd As New Random()
                            Dim blastImage As PictureBox = CType(Me.Controls("Image5_" & rnd.Next(1, 4)), PictureBox)
                            blastImage.Location = objects(i).Location
                            blastImage.Visible = True
                            ResetMissile()
                            Dim score As Integer = scores(i)
                            Label3.Text = ("Missile hit " & names(i).ToString())

                            hitObj += 1
                            If hitObj = nImg Then
                                nextLevel()
                                updateLevel()
                            End If
                            tot += scores(i)
                            MyScore.Text = tot
                            UpdateScore("Highscore", scores(i))
                            effectTimer.Start()

                            AddHandler effectTimer.Tick,
                                Sub()
                                    blastImage.Visible = False
                                    effectTimer.Stop()
                                End Sub

                            Me.Controls.Remove(objects(i))
                        End If
                        Return True
                    End If
                End If
            End If
        Next
        Return False
    End Function

    Private Sub reset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command2.Click
        Text1.Clear()
        Text2.Clear()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        enemyMovementTimer.Start()
    End Sub

    Private Sub EnemyMovementHandler(ByVal sender As Object, ByVal e As EventArgs) Handles enemyMovementTimer.Tick
        If enemyDirections Is Nothing Then
            MessageBox.Show("Enemy directions have not been initialized.")
            Return
        End If

        Dim toUpdate As New List(Of PictureBox)(enemyDirections.Keys)

        For Each enemyObject As PictureBox In toUpdate
            If enemyObject.Visible Then
                Dim currentY As Integer = enemyObject.Location.Y
                Dim newY As Integer
                Dim moveDown As Boolean = enemyDirections(enemyObject)

                If moveDown Then
                    newY = currentY + enemyMoveDistance
                    If newY > MAX_Y - enemyObject.Height Then
                        newY = MAX_Y - enemyObject.Height
                        enemyDirections(enemyObject) = False
                    End If
                Else
                    newY = currentY - enemyMoveDistance
                    If newY < MIN_Y Then
                        newY = MIN_Y
                        enemyDirections(enemyObject) = True
                    End If
                End If

                enemyObject.Location = New Point(enemyObject.Location.X, newY)
                enemyAreas(enemyObject) = New Rectangle(enemyObject.Location, enemyObject.Size)
            End If
        Next
    End Sub

    Private Sub pause1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If MainForm IsNot Nothing Then
            MainForm.SetCurrentGameInterface(Me)
            MainForm.LoadUserControl(New pauseBtn(modeS, lvlS))
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMainInterface(modeS, lvlS))
        End If
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMenu)
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MainForm IsNot Nothing Then
            MainForm.LoadUserControl(New gameMenu)
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If lvlS < 5 Then
            If MainForm IsNot Nothing Then
                MainForm.LoadUserControl(New gameMainInterface(modeS, lvlS + 1))
            End If
        ElseIf lvlS = 5 And modeS = "easy" Then
            If MainForm IsNot Nothing Then
                MainForm.LoadUserControl(New gameMainInterface("Hard", 1))
            End If
        ElseIf lvlS = 5 And modeS = "Hard" Then
            Label6.Text = "Congratulations you have completed this game."
            Label6.Visible = True
            Button3.Visible = True

        ElseIf modeS = "Easy" Then
            If userELvl < lvlS Then
                UpdateData(Username, "Normal_Level", lvlS)
            End If
        End If
    End Sub
End Class
