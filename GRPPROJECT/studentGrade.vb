Imports System.Data.SqlClient

Public Class studentGrade
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ' Get the student ID from the textbox and trim any spaces
        Dim studentId As Integer
        If Not IsNumeric(txtStudentId.Text) Then
            MessageBox.Show("Please enter a valid numeric Student ID.")
            Return
        Else
            studentId = Convert.ToInt32(txtStudentId.Text.Trim())
        End If

        ' Query to fetch all records from the Results table for the given student ID
        Dim query As String = "SELECT * FROM Results WHERE Student_id = @StudentID"

        ' Create an instance of the dbConnection form
        Dim dbForm As New dbConnection()
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        ' Create a connection and command to execute the query
        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                ' Add parameter to avoid SQL injection
                cmd.Parameters.AddWithValue("@StudentID", studentId)

                ' Create a DataTable to hold the results
                Dim resultsTable As New DataTable()

                Try
                    ' Open the connection
                    conn.Open()

                    ' Create a DataAdapter to execute the query and fill the DataTable
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(resultsTable)
                    End Using

                    ' Check if records were found
                    If resultsTable.Rows.Count > 0 Then
                        ' Bind the results to the DataGridView
                        DataGridView1.DataSource = resultsTable
                    Else
                        MessageBox.Show("No records found for the given Student ID.")
                        DataGridView1.DataSource = Nothing
                    End If

                Catch ex As SqlException
                    MessageBox.Show("SQL Error: " & ex.Message)
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub studentGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class