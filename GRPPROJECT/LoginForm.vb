

Imports System.Data.SqlClient

Public Class LoginForm


    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        picboxLogin.ImageLocation = "C:\Users\HP\source\repos\STUDENT_MANAGEMENT_SYSTEM\GRPPROJECT\myImages/User-Profile.png"
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxpassword.CheckedChanged
        If CheckBoxpassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
            'Show user password
        Else
            txtPassword.UseSystemPasswordChar = True
            'hide password
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        ' 1. Get the input values from the textboxes
        Dim adminID As String = txtUsername.Text
        Dim password As String = txtPassword.Text

        ' 2. Define your connection string (replace with your actual details)
        Dim connectionString As String = "Server=DESKTOP-82839AS;Database=StudentEvalSystem;Integrated Security=True;"

        ' 3. Create the SQL query to check if the student ID and password match
        Dim query As String = "SELECT COUNT(*) FROM Admin WHERE Admin_id = @admin_id AND Password = @password"

        ' 4. Create the SQL connection and command
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                ' 5. Add the parameters to the SQL query to prevent SQL injection
                command.Parameters.AddWithValue("@admin_id", adminID)
                command.Parameters.AddWithValue("@password", password)

                Try

                    connection.Open()

                    ' 7. Execute the query and get the result (count of matching rows)
                    Dim result As Integer = Convert.ToInt32(command.ExecuteScalar())

                    ' 8. Check if the credentials are valid (if result is 1, login successful)
                    If result > 0 Then


                        ' Redirect to another form upon successful login
                        Dim Mainform As New MainForm ' 
                        Mainform.Show() ' Show the new form
                        Me.Hide() ' Hide the login form (optional, you can close it if needed)

                    Else
                        ' 10. Show a message box for invalid login
                        MessageBox.Show("Wrong username or password.")
                    End If

                Catch ex As Exception
                    ' 11. Handle any errors that occur during the database operation
                    MessageBox.Show("An error occurred: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub
End Class