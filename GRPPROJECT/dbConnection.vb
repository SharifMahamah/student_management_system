
Imports System.Data.SqlClient
Public Class dbConnection
    ' Define a connection string (adjust as necessary)
    Private connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"
    Private connection As SqlConnection

    ' Method to get the connection object
    Public Function GetConnection() As SqlConnection
        If connection Is Nothing Then
            connection = New SqlConnection(connectionString)
        End If
        Return connection
    End Function

    ' Open the connection
    Public Sub OpenConnection()
        If connection Is Nothing Then
            connection = New SqlConnection(connectionString)
        End If
        If connection.State = ConnectionState.Closed Then
            connection.Open()
        End If
    End Sub

    ' Close the connection
    ' Close the connection
    Public Sub CloseConnection()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub


End Class