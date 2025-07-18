Imports System.Data.SqlClient

Public Class studentListForm

    ' Function to load students into the DataGridView
    Private Sub LoadStudents()
        ' Create an instance of the dbConnection form
        Dim dbForm As New dbConnection()

        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        ' SQL query to select all student records
        Dim query As String = "SELECT * FROM Students"

        ' Create a new DataTable to hold the data
        Dim dataTable As New DataTable()

        ' Use the connection string returned from dbConnection
        Using conn As New SqlConnection(connectionString)
            ' Create a SQL Command
            Dim cmd As New SqlCommand(query, conn)

            ' Create a Data Adapter to fill the DataTable
            Dim adapter As New SqlDataAdapter(cmd)

            ' Open the connection and fill the DataTable
            Try
                conn.Open()
                adapter.Fill(dataTable)

                ' Bind the DataTable to the DataGridView
                DataGridView1.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub studentListForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStudents()
    End Sub

    ' Call LoadStudents when the form loads



End Class