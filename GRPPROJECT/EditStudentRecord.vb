Imports System.Data.SqlClient

Public Class EditStudentRecord
    Private db As New dbConnection()

    Private Sub SetEditingControlsEnabled(enabled As Boolean)
        txtFirstName.Enabled = enabled
        txtLastName.Enabled = enabled
        dtpdateofbirth.Enabled = enabled
        rdoMale.Enabled = enabled
        rdoFemale.Enabled = enabled
        txtEmail.Enabled = enabled
        txtPhone.Enabled = enabled
        txtAddress.Enabled = enabled
        dtpenrollment.Enabled = enabled
        txtProgrammeId.Enabled = enabled
        btnUpdate.Enabled = enabled
    End Sub


    ' Load button: Find and display student
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Try
            Dim studentID As String = txtStudentId.Text.Trim()

            If studentID.Length <> 8 OrElse Not IsNumeric(studentID) Then
                MessageBox.Show("Please enter a valid 8-digit Student ID.")
                Return
            End If

            db.OpenConnection()

            Dim query As String = "SELECT * FROM Students WHERE student_id = @studentID"

            Using cmd As New SqlCommand(query, db.GetConnection())
                cmd.Parameters.AddWithValue("@studentID", studentID)

                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        txtFirstName.Text = reader("first_name").ToString()
                        txtLastName.Text = reader("last_name").ToString()
                        dtpdateofbirth.Value = Convert.ToDateTime(reader("Date_of_Birth"))
                        SetEditingControlsEnabled(True)
                        If reader("Gender").ToString() = "M" Then
                            rdoMale.Checked = True
                        Else
                            rdoFemale.Checked = True
                        End If
                        txtEmail.Text = reader("Email").ToString()
                        txtPhone.Text = reader("phone").ToString()
                        txtAddress.Text = reader("address").ToString()
                        dtpenrollment.Value = Convert.ToDateTime(reader("enrollment_date"))
                        txtProgrammeId.Text = reader("Programme_id").ToString()
                    Else
                        MessageBox.Show("Student not found.")
                        ClearFields()
                    End If

                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Error loading student: " & ex.Message)
        Finally
            db.CloseConnection()
        End Try
    End Sub

    ' Update button: Save changes and reload
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim studentID As String = txtStudentId.Text.Trim()
            Dim firstName As String = txtFirstName.Text.Trim()
            Dim lastName As String = txtLastName.Text.Trim()
            Dim dateOfBirth As Date = dtpdateofbirth.Value
            Dim gender As String = If(rdoMale.Checked, "M", "F")
            Dim email As String = txtEmail.Text.Trim()
            Dim phoneNumber As String = txtPhone.Text.Trim()
            Dim address As String = txtAddress.Text.Trim()
            Dim enrollmentDate As Date = dtpenrollment.Value
            Dim programme_id As Integer

            If studentID.Length <> 8 OrElse Not IsNumeric(studentID) Then
                MessageBox.Show("Please enter a valid 8-digit Student ID.")
                Return
            End If

            If Not Integer.TryParse(txtProgrammeId.Text, programme_id) Then
                MessageBox.Show("Invalid Programme ID.")
                Return
            End If

            db.OpenConnection()

            Dim query As String = "UPDATE Students SET first_name = @firstName, last_name = @lastName, Date_of_Birth = @dateOfBirth, Gender = @gender, Email = @Email, phone = @phoneNumber, address = @address, enrollment_date = @enrollmentDate, Programme_id = @programmeID WHERE student_id = @studentID"

            Using cmd As New SqlCommand(query, db.GetConnection())
                cmd.Parameters.AddWithValue("@firstName", firstName)
                cmd.Parameters.AddWithValue("@lastName", lastName)
                cmd.Parameters.AddWithValue("@dateOfBirth", dateOfBirth)
                cmd.Parameters.AddWithValue("@gender", gender)
                cmd.Parameters.AddWithValue("@Email", email)
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber)
                cmd.Parameters.AddWithValue("@address", address)
                cmd.Parameters.AddWithValue("@enrollmentDate", enrollmentDate)
                cmd.Parameters.AddWithValue("@programmeID", programme_id)
                cmd.Parameters.AddWithValue("@studentID", studentID)

                Dim rowsAffected As Integer = cmd.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    MessageBox.Show("Student record updated successfully!")
                    ' Reload to show new data
                    btnLoad.PerformClick()
                    SetEditingControlsEnabled(False)

                Else
                    MessageBox.Show("Update failed. Please check the Student ID.")
                End If
            End Using

        Catch ex As Exception
            MessageBox.Show("Error updating student: " & ex.Message)
        Finally
            db.CloseConnection()
        End Try
    End Sub

    ' Cancel button
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    ' Optional helper to clear form
    Private Sub ClearFields()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtAddress.Clear()
        txtProgrammeId.Clear()
        rdoMale.Checked = False
        rdoFemale.Checked = False
        dtpdateofbirth.Value = Date.Today
        dtpenrollment.Value = Date.Today
    End Sub

    Private Sub EditStudentRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetEditingControlsEnabled(False)
    End Sub
End Class