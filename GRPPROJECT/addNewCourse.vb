
Imports System.Data.SqlClient

Public Class addNewCourse

    Private db As New dbConnection()
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Retrieve values from textboxes
        Dim courseCode As String = txtCourseCode.Text.Trim()
        Dim courseName As String = txtCourseName.Text.Trim()
        Dim creditsText As String = txtCredits.Text.Trim()
        Dim programmeIdText As String = txtProgrammeId.Text.Trim()

        ' Validate inputs
        If courseCode.Length <> 7 Then
            MessageBox.Show("Course code must be exactly 7 characters long.")
            Exit Sub
        End If

        ' Use IsNumeric to check if credits is a valid number
        If Not IsNumeric(creditsText) Then
            MessageBox.Show("Credits must be a valid number.")
            Exit Sub
        End If

        Dim credits As Integer = CInt(creditsText)
        If credits < 0 Or credits > 3 Then
            MessageBox.Show("Credits must be between 0 and 3.")
            Exit Sub
        End If

        ' Use IsNumeric to check if programmeId is a valid number
        If Not IsNumeric(programmeIdText) Then
            MessageBox.Show("Programme ID must be a valid number.")
            Exit Sub
        End If

        Dim programmeId As Integer = CInt(programmeIdText)
        If programmeId < 100 Or programmeId > 102 Then
            MessageBox.Show("Programme ID must be between 100 and 102.")
            Exit Sub
        End If

        ' SQL query to insert new course
        Dim query As String = "INSERT INTO Courses (course_code, course_name, credits, programme_id) " &
                              "VALUES (@courseCode, @courseName, @credits, @programmeId)"

        ' Create an instance of the dbConnection form
        Dim dbForm As New dbConnection()
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        ' Execute the SQL query
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@courseCode", courseCode)
                cmd.Parameters.AddWithValue("@courseName", courseName)
                cmd.Parameters.AddWithValue("@credits", credits)
                cmd.Parameters.AddWithValue("@programmeId", programmeId)

                ' Open the connection and execute the query
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Course added successfully!")
                Catch ex As SqlException
                    MessageBox.Show("SQL Error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class