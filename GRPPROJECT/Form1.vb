Imports System.Data.SqlClient

Public Class Form1



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 1. Define the connection string
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        ' 2. Create a SqlConnection object
        Using connection As New SqlConnection(connectionString)
            Try
                ' 3. Open the connection
                connection.Open()
                MessageBox.Show("Connection successful!")

                ' 4. Example query to select data from a table
                Dim query As String = "SELECT * FROM Students"

                ' 5. Create a SqlCommand object
                Dim command As New SqlCommand(query, connection)

                ' 6. Execute the query and retrieve the results
                Dim reader As SqlDataReader = command.ExecuteReader()

                ' 7. Read and process the data
                While reader.Read()
                    ' Example: Show the data in a MessageBox
                    MessageBox.Show(reader("Student_id").ToString())
                End While

                ' 8. Close the reader
                reader.Close()

            Catch ex As Exception
                ' 9. Handle any errors
                MessageBox.Show("An error occurred: " & ex.Message)
            End Try
        End Using
    End Sub
End Class