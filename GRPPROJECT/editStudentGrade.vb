Imports System.Data.SqlClient

Public Class editStudentGrade
    ' Validate if Student ID exists
    Private Function ValidateStudentId(studentId As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(1) FROM Students WHERE Student_id = @StudentID"
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                Try
                    conn.Open()
                    exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return exists
    End Function

    ' Validate if Course Code exists
    Private Function ValidateCourseCode(courseCode As String) As Boolean
        Dim exists As Boolean = False
        Dim query As String = "SELECT COUNT(1) FROM Courses WHERE Course_code = @CourseCode"
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@CourseCode", courseCode)
                Try
                    conn.Open()
                    exists = (Convert.ToInt32(cmd.ExecuteScalar()) > 0)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using

        Return exists
    End Function

    ' === Helper to enable/disable fields ===
    Private Sub SetEditingControlsEnabled(enabled As Boolean)
        txtIAScore.Enabled = enabled
        txtExamScore.Enabled = enabled
        dtpExamDate.Enabled = enabled
        btnUpdate.Enabled = enabled
    End Sub

    ' === Disable on form load ===
    Private Sub editResults_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEditingControlsEnabled(False)
    End Sub

    ' === Load button: Load existing result ===
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim studentId As String = txtStudentId.Text.Trim()
        Dim courseCode As String = txtCourseCode.Text.Trim()

        If Not ValidateStudentId(studentId) Then
            MessageBox.Show("Student ID does not exist.")
            Return
        End If

        If Not ValidateCourseCode(courseCode) Then
            MessageBox.Show("Course Code does not exist.")
            Return
        End If

        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"
        Dim query As String = "SELECT * FROM Results WHERE Student_id = @StudentID AND Course_code = @CourseCode"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                cmd.Parameters.AddWithValue("@CourseCode", courseCode)

                Try
                    conn.Open()
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtIAScore.Text = reader("IA_Score").ToString()
                            txtExamScore.Text = reader("Exam_Score").ToString()
                            dtpExamDate.Value = Convert.ToDateTime(reader("Exam_Date"))

                            SetEditingControlsEnabled(True)
                        Else
                            MessageBox.Show("No result found for this Student ID and Course Code.")
                            SetEditingControlsEnabled(False)
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    ' === Update button: Save changes ===
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim studentId As String = txtStudentId.Text.Trim()
        Dim courseCode As String = txtCourseCode.Text.Trim()
        Dim iaScore As Integer
        Dim examScore As Integer
        Dim examDate As Date = dtpExamDate.Value

        If Not Integer.TryParse(txtIAScore.Text, iaScore) OrElse iaScore < 0 OrElse iaScore > 40 Then
            MessageBox.Show("IA Score must be between 0 and 40.")
            Return
        End If

        If Not Integer.TryParse(txtExamScore.Text, examScore) OrElse examScore < 0 OrElse examScore > 60 Then
            MessageBox.Show("Exam Score must be between 0 and 60.")
            Return
        End If

        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"
        Dim query As String = "UPDATE Results SET IA_Score = @IAScore, Exam_Score = @ExamScore, Exam_Date = @ExamDate WHERE Student_id = @StudentID AND Course_code = @CourseCode"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@IAScore", iaScore)
                cmd.Parameters.AddWithValue("@ExamScore", examScore)
                cmd.Parameters.AddWithValue("@ExamDate", examDate)
                cmd.Parameters.AddWithValue("@StudentID", studentId)
                cmd.Parameters.AddWithValue("@CourseCode", courseCode)

                Try
                    conn.Open()
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Result updated successfully!")
                        ' Reload updated record
                        btnLoad.PerformClick()
                        ' Disable editing again
                        SetEditingControlsEnabled(False)
                    Else
                        MessageBox.Show("Update failed.")
                    End If
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