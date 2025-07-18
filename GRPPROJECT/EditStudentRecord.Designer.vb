<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudentRecord
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblDateOfBirth = New Label()
        lblLastName = New Label()
        lblProgrammeId = New Label()
        lblEnrollmentDate = New Label()
        lblPhone = New Label()
        lblGender = New Label()
        lblFIrstName = New Label()
        lblEmail = New Label()
        lblAddress = New Label()
        txtStudentId = New TextBox()
        txtPhone = New TextBox()
        txtLastName = New TextBox()
        txtFirstName = New TextBox()
        txtEmail = New TextBox()
        txtAddress = New TextBox()
        dtpdateofbirth = New DateTimePicker()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        dtpenrollment = New DateTimePicker()
        txtProgrammeId = New TextBox()
        btnLoad = New Button()
        btnUpdate = New Button()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(155, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(100, 25)
        Label1.TabIndex = 0
        Label1.Text = "Student ID:"
        ' 
        ' lblDateOfBirth
        ' 
        lblDateOfBirth.AutoSize = True
        lblDateOfBirth.Font = New Font("Segoe UI", 10F)
        lblDateOfBirth.Location = New Point(76, 241)
        lblDateOfBirth.Name = "lblDateOfBirth"
        lblDateOfBirth.Size = New Size(129, 28)
        lblDateOfBirth.TabIndex = 1
        lblDateOfBirth.Text = "Date Of Birth:"
        ' 
        ' lblLastName
        ' 
        lblLastName.AutoSize = True
        lblLastName.Font = New Font("Segoe UI", 10F)
        lblLastName.Location = New Point(76, 182)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(107, 28)
        lblLastName.TabIndex = 2
        lblLastName.Text = "Last Name:"
        ' 
        ' lblProgrammeId
        ' 
        lblProgrammeId.AutoSize = True
        lblProgrammeId.Font = New Font("Segoe UI", 10F)
        lblProgrammeId.Location = New Point(76, 537)
        lblProgrammeId.Name = "lblProgrammeId"
        lblProgrammeId.Size = New Size(143, 28)
        lblProgrammeId.TabIndex = 3
        lblProgrammeId.Text = "Programme ID:"
        ' 
        ' lblEnrollmentDate
        ' 
        lblEnrollmentDate.AutoSize = True
        lblEnrollmentDate.Font = New Font("Segoe UI", 10F)
        lblEnrollmentDate.Location = New Point(76, 477)
        lblEnrollmentDate.Name = "lblEnrollmentDate"
        lblEnrollmentDate.Size = New Size(157, 28)
        lblEnrollmentDate.TabIndex = 4
        lblEnrollmentDate.Text = "Enrollment Date:"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Font = New Font("Segoe UI", 10F)
        lblPhone.Location = New Point(76, 409)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(71, 28)
        lblPhone.TabIndex = 5
        lblPhone.Text = "Phone:"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Font = New Font("Segoe UI", 10F)
        lblGender.Location = New Point(76, 296)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(80, 28)
        lblGender.TabIndex = 6
        lblGender.Text = "Gender:"
        ' 
        ' lblFIrstName
        ' 
        lblFIrstName.AutoSize = True
        lblFIrstName.Location = New Point(76, 113)
        lblFIrstName.Name = "lblFIrstName"
        lblFIrstName.Size = New Size(101, 25)
        lblFIrstName.TabIndex = 7
        lblFIrstName.Text = "First Name:"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI", 10F)
        lblEmail.Location = New Point(76, 345)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(63, 28)
        lblEmail.TabIndex = 8
        lblEmail.Text = "Email:"
        ' 
        ' lblAddress
        ' 
        lblAddress.AutoSize = True
        lblAddress.Font = New Font("Segoe UI", 10F)
        lblAddress.Location = New Point(76, 590)
        lblAddress.Name = "lblAddress"
        lblAddress.Size = New Size(86, 28)
        lblAddress.TabIndex = 9
        lblAddress.Text = "Address:"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(286, 43)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(192, 31)
        txtStudentId.TabIndex = 10
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(247, 410)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(300, 31)
        txtPhone.TabIndex = 11
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(247, 182)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(300, 31)
        txtLastName.TabIndex = 12
        ' 
        ' txtFirstName
        ' 
        txtFirstName.Location = New Point(247, 125)
        txtFirstName.Name = "txtFirstName"
        txtFirstName.Size = New Size(300, 31)
        txtFirstName.TabIndex = 14
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(247, 349)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(300, 31)
        txtEmail.TabIndex = 17
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(247, 587)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(300, 31)
        txtAddress.TabIndex = 18
        ' 
        ' dtpdateofbirth
        ' 
        dtpdateofbirth.Location = New Point(247, 241)
        dtpdateofbirth.Name = "dtpdateofbirth"
        dtpdateofbirth.Size = New Size(300, 31)
        dtpdateofbirth.TabIndex = 19
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(372, 296)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(93, 29)
        rdoFemale.TabIndex = 20
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(247, 296)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(75, 29)
        rdoMale.TabIndex = 21
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' dtpenrollment
        ' 
        dtpenrollment.Location = New Point(247, 475)
        dtpenrollment.Name = "dtpenrollment"
        dtpenrollment.Size = New Size(300, 31)
        dtpenrollment.TabIndex = 22
        ' 
        ' txtProgrammeId
        ' 
        txtProgrammeId.Location = New Point(247, 532)
        txtProgrammeId.Name = "txtProgrammeId"
        txtProgrammeId.Size = New Size(300, 31)
        txtProgrammeId.TabIndex = 23
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.Navy
        btnLoad.ForeColor = SystemColors.ButtonHighlight
        btnLoad.Location = New Point(597, 29)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(116, 58)
        btnLoad.TabIndex = 24
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.FromArgb(CByte(0), CByte(192), CByte(0))
        btnUpdate.ForeColor = SystemColors.ActiveCaptionText
        btnUpdate.Location = New Point(220, 665)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(116, 60)
        btnUpdate.TabIndex = 25
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.ForeColor = SystemColors.ActiveCaptionText
        btnCancel.Location = New Point(440, 665)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(116, 60)
        btnCancel.TabIndex = 26
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' EditStudentRecord
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(855, 753)
        Controls.Add(btnCancel)
        Controls.Add(btnUpdate)
        Controls.Add(btnLoad)
        Controls.Add(txtProgrammeId)
        Controls.Add(dtpenrollment)
        Controls.Add(rdoMale)
        Controls.Add(rdoFemale)
        Controls.Add(dtpdateofbirth)
        Controls.Add(txtAddress)
        Controls.Add(txtEmail)
        Controls.Add(txtFirstName)
        Controls.Add(txtLastName)
        Controls.Add(txtPhone)
        Controls.Add(txtStudentId)
        Controls.Add(lblAddress)
        Controls.Add(lblEmail)
        Controls.Add(lblFIrstName)
        Controls.Add(lblGender)
        Controls.Add(lblPhone)
        Controls.Add(lblEnrollmentDate)
        Controls.Add(lblProgrammeId)
        Controls.Add(lblLastName)
        Controls.Add(lblDateOfBirth)
        Controls.Add(Label1)
        MaximumSize = New Size(886, 815)
        Name = "EditStudentRecord"
        Text = "EditStudentRecord"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblDateOfBirth As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblProgrammeId As Label
    Friend WithEvents lblEnrollmentDate As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblFIrstName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents dtpdateofbirth As DateTimePicker
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents dtpenrollment As DateTimePicker
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents txtProgrammeId As TextBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnCancel As Button
End Class
