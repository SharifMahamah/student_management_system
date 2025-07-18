Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class attendanceDb
    Private Sub attendanceDb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnRecord_Click(sender As Object, e As EventArgs) Handles btnRecord.Click
        Dim StudentId As Integer = txtStudentId.Text.Trim()
        Dim Level = txtLevel.Text.Trim()
        Dim Venue = txtVenue.Text.Trim()
        Dim StrDate = DateTimePicker1.Value
        Dim Course As String = txtCourse.Text.Trim()




        Dim query = "Insert into attendancedb values(@StudentId,@Level,@Venue,@Date,@Course)"

        Using con = New SqlConnection("Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;")

            Using cnn = New SqlCommand(query, con)

                cnn.Parameters.AddWithValue("@StudentId", StudentId)
                cnn.Parameters.AddWithValue("@Level", Level)

                cnn.Parameters.AddWithValue("@Venue", Venue)
                cnn.Parameters.AddWithValue("@Date", StrDate)
                cnn.Parameters.AddWithValue("@Course", Course)

                con.Open()


                cnn.ExecuteNonQuery()

                con.Close()


                MessageBox.Show("Record Saved Successfully")



            End Using

        End Using
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtLevel.TextChanged

    End Sub
End Class