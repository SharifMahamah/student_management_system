Imports System.Data.SqlClient
Public Class Registerstudent

    Private db As New dbConnection()


    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
        'Only numbers'
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True

        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            ' Step 1: Get values from form controls
            Dim studentID As String = txtStudentId.Text.Trim()
            Dim firstName As String = txtFirstname.Text.Trim()
            Dim lastName As String = txtLastName.Text.Trim()
            Dim dateOfBirth As Date = dtpdateofbirth.Value
            Dim gender As String = If(rdoMale.Checked, "M", "F") ' "M" for Male, "F" for Female
            Dim email As String = txtEmail.Text.Trim()
            Dim phoneNumber As String = txtPhone.Text.Trim()
            Dim address As String = txtAddress.Text.Trim()
            Dim enrollmentDate As Date = dtpenrollment.Value
            Dim programme_id As Integer

            '  Validate the student_id (must be 8 digits)
            If studentID.Length <> 8 OrElse Not IsNumeric(studentID) Then
                MessageBox.Show("Please enter a valid 8-digit Student ID.")
                Return
            End If


            ' Step 2: Validate the programme_id
            If Not Integer.TryParse(txtProgrammeId.Text, programme_id) Then
                MessageBox.Show("Please enter a valid Programme ID number.")
                Return
            End If

            If programme_id < 100 OrElse programme_id > 102 Then
                MessageBox.Show("Programme ID must be between 100 and 102.")
                Return
            End If
            'Open the database connection
            db.OpenConnection()

            '  Define the SQL query to insert the data
            Dim query As String = "INSERT INTO Students (student_id, first_name, last_name, Date_of_Birth, Gender, Email, phone, address, enrollment_date, Programme_id) " &
                                  "VALUES (@studentID,@firstName, @lastName, @dateOfBirth, @gender, @Email, @phoneNumber, @address, @enrollmentDate, @programmeID)"
            ' Create the SqlCommand and assign parameters
            Using cmd As New SqlCommand(query, db.GetConnection())
                ' Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@studentID", studentID)
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@enrollmentDate", enrollmentDate)
                cmd.Parameters.AddWithValue("@programmeID", programme_id)
                ' Step 6: Execute the query
                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                ' Check if insert query worked
                If rowsAffected > 0 Then

                    MessageBox.Show("Student record added successfully!")
                Else

                    MessageBox.Show("No record was added. Please try again.")
                End If

                ' Step 7: Inform the user that the data has been successfully inserted
                MessageBox.Show("Student record added successfully!")
            End Using
        Catch ex As Exception
            ' Handle any errors that occur during insertion
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            ' Step 8: Close the database connection
            db.CloseConnection()
        End Try






    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


End Class