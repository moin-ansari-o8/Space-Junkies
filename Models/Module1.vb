Imports System.Data.SqlClient
Module Module1
    Public conStr As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=C:\PROJECT_VB\Game1\Game1\Models\gameData.mdf;Integrated Security=True;User Instance=True"
    'image paths for the setting of the game Interface
    Public bgImg1 As String = "DarkGray"
    Public bgImg2 As String = "DimGray"
    Public bgImg3 As String = "DarkSalmon"
    Public missileImg1 As String = "m1"
    Public missileImg2 As String = "m2"
    Public missileImg3 As String = "m3"
    Public planet1 As String = "p1"
    Public planet2 As String = "p2"
    Public planet3 As String = "p3"
    Public spaceshipImg1 As String = "s1"
    Public spaceshipImg2 As String = "s2"
    Public spaceshipImg3 As String = "s3"
    Public Sub updateLabel(ByVal lbl As Label, ByVal msg As String)
        lbl.Text = msg + " changed successfully..."
        lbl.Visible = True
    End Sub
    Public Sub UpdateData(ByVal Username As String, ByVal fieldName As String, ByVal value As String)
        ' Connection string to your database
        Using connection As New SqlConnection(conStr)
            Try
                connection.Open()

                ' Update SQL query based on fieldName
                Dim sqlUpdate As String = "UPDATE GameData SET " + fieldName + " = @Value WHERE Username = @Username"
                Using commandUpdate As New SqlCommand(sqlUpdate, connection)
                    commandUpdate.Parameters.AddWithValue("@Value", value)
                    commandUpdate.Parameters.AddWithValue("@Username", Username)

                    ' Execute the update command
                    commandUpdate.ExecuteNonQuery()

                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Sub UpdateData(ByVal Username As String, ByVal fieldName As String, ByVal value As Integer)
        ' Connection string to your database
        Using connection As New SqlConnection(conStr)
            Try
                connection.Open()

                ' Update SQL query based on fieldName
                Dim sqlUpdate As String = "UPDATE GameData SET " + fieldName + " = @Value WHERE Username = @Username"
                Using commandUpdate As New SqlCommand(sqlUpdate, connection)
                    commandUpdate.Parameters.AddWithValue("@Value", value)
                    commandUpdate.Parameters.AddWithValue("@Username", Username)

                    ' Execute the update command
                    commandUpdate.ExecuteNonQuery()
                    
                End Using
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            End Try
        End Using
    End Sub
End Module
