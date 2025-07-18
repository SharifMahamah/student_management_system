Imports System.Data.SqlClient

Public Class addResults

    'VALIDATING WHERE STUDENT_ID EXISTS
    Private Function ValidateStudentId(studentId As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(1) FROM Students WHERE Student_id = @StudentID"

        ' Create an instance of dbConnection form
        Dim dbForm As New dbConnection()
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentId)

                Try
                    conn.Open()
                    exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                Catch ex As SqlException
                    MessageBox.Show("SQL Error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return exists
    End Function

    'VALIDATING WHETHERE COURSE_CODE EXISTS
    Private Function ValidateCourseCode(courseCode As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(1) FROM Courses WHERE Course_code = @CourseCode"

        ' Create an instance of dbConnection form
        Dim dbForm As New dbConnection()
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"


        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CourseCode", courseCode)

                Try
                    conn.Open()
                    exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                Catch ex As SqlException
                    MessageBox.Show("SQL Error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return exists
    End Function


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Get values from textboxes and datetimepicker

        Dim studentId As String = txtStudentId.Text.Trim()
        Dim courseCode As String = txtCourseCode.Text.Trim()
        Dim iaScore As Integer
        Dim examScore As Integer
        Dim examDate As Date = DateTimePicker1.Value



        ' Validate IA_Score (numeric and between 0 and 40)
        If Not Integer.TryParse(txtIAScore.Text, iaScore) OrElse iaScore < 0 OrElse iaScore > 40 Then
            MessageBox.Show("IA Score must be a number between 0 and 40.")
            Return
        End If

        ' Validate Exam_Score (numeric and between 0 and 60)
        If Not Integer.TryParse(txtExamScore.Text, examScore) OrElse examScore < 0 OrElse examScore > 60 Then
            MessageBox.Show("Exam Score must be a number between 0 and 60.")
            Return
        End If

        ' Validate Student_id and Course_code exist in the database
        If Not ValidateStudentId(txtStudentId.Text.Trim()) Then
            MessageBox.Show("Student ID does not exist.")
            Return
        End If

        If Not ValidateCourseCode(courseCode) Then
            MessageBox.Show("Course Code does not exist.")
            Return
        End If

        ' SQL query to insert the result into the database
        Dim query As String = "INSERT INTO Results ( Student_id, Course_code, IA_Score, Exam_Score, Exam_Date) " &
                              "VALUES ( @StudentID, @CourseCode, @IAScore, @ExamScore, @ExamDate)"

        ' Create a connection instance using your centralized dbConnection form
        Dim dbForm As New dbConnection()
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                cmd.Parameters.AddWithValue("@CourseCode", courseCode)
                cmd.Parameters.AddWithValue("@IAScore", iaScore)
                cmd.Parameters.AddWithValue("@ExamScore", examScore)
                cmd.Parameters.AddWithValue("@ExamDate", examDate)

                ' Try to open the connection and execute the command
                Try
                    conn.Open()
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("Result added successfully!")
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