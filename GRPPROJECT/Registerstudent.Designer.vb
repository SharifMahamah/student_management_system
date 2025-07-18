<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registerstudent
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
        txtFirstname = New TextBox()
        txtLastName = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        dtpdateofbirth = New DateTimePicker()
        txtPhone = New TextBox()
        Label4 = New Label()
        txtAddress = New TextBox()
        Label5 = New Label()
        txtEmail = New TextBox()
        Label6 = New Label()
        dtpenrollment = New DateTimePicker()
        Label7 = New Label()
        rdoMale = New RadioButton()
        rdoFemale = New RadioButton()
        Label8 = New Label()
        btnSubmit = New Button()
        btnCancel = New Button()
        txtProgrammeId = New TextBox()
        Label9 = New Label()
        txtStudentId = New TextBox()
        Label10 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F)
        Label1.Location = New Point(128, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(115, 28)
        Label1.TabIndex = 0
        Label1.Text = "First Name :"
        ' 
        ' txtFirstname
        ' 
        txtFirstname.Location = New Point(315, 96)
        txtFirstname.Name = "txtFirstname"
        txtFirstname.Size = New Size(270, 31)
        txtFirstname.TabIndex = 1
        ' 
        ' txtLastName
        ' 
        txtLastName.Location = New Point(315, 159)
        txtLastName.Name = "txtLastName"
        txtLastName.Size = New Size(270, 31)
        txtLastName.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(135, 161)
        Label2.Name = "Label2"
        Label2.Size = New Size(112, 28)
        Label2.TabIndex = 2
        Label2.Text = "Last Name :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(139, 215)
        Label3.Name = "Label3"
        Label3.Size = New Size(108, 28)
        Label3.TabIndex = 4
        Label3.Text = "Birth Date :"
        ' 
        ' dtpdateofbirth
        ' 
        dtpdateofbirth.Location = New Point(314, 213)
        dtpdateofbirth.Name = "dtpdateofbirth"
        dtpdateofbirth.Size = New Size(294, 31)
        dtpdateofbirth.TabIndex = 5
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(312, 398)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(270, 31)
        txtPhone.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(173, 400)
        Label4.Name = "Label4"
        Label4.Size = New Size(76, 28)
        Label4.TabIndex = 6
        Label4.Text = "Phone :"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(312, 575)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(270, 31)
        txtAddress.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Times New Roman", 12F)
        Label5.Location = New Point(155, 575)
        Label5.Name = "Label5"
        Label5.Size = New Size(102, 27)
        Label5.TabIndex = 8
        Label5.Text = "Address :"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(312, 337)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(270, 31)
        txtEmail.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(181, 337)
        Label6.Name = "Label6"
        Label6.Size = New Size(68, 28)
        Label6.TabIndex = 10
        Label6.Text = "Email :"
        ' 
        ' dtpenrollment
        ' 
        dtpenrollment.Location = New Point(312, 463)
        dtpenrollment.Name = "dtpenrollment"
        dtpenrollment.Size = New Size(270, 31)
        dtpenrollment.TabIndex = 13
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 10F)
        Label7.Location = New Point(73, 465)
        Label7.Name = "Label7"
        Label7.Size = New Size(162, 28)
        Label7.TabIndex = 12
        Label7.Text = "Enrollment Date :"
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Location = New Point(315, 283)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(75, 29)
        rdoMale.TabIndex = 14
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(412, 283)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(93, 29)
        rdoFemale.TabIndex = 15
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 10F)
        Label8.Location = New Point(163, 283)
        Label8.Name = "Label8"
        Label8.Size = New Size(85, 28)
        Label8.TabIndex = 16
        Label8.Text = "Gender :"
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Lime
        btnSubmit.Font = New Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(173, 664)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(146, 51)
        btnSubmit.TabIndex = 17
        btnSubmit.Text = "Register"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(412, 664)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(146, 51)
        btnCancel.TabIndex = 18
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' txtProgrammeId
        ' 
        txtProgrammeId.Location = New Point(312, 520)
        txtProgrammeId.Name = "txtProgrammeId"
        txtProgrammeId.Size = New Size(270, 31)
        txtProgrammeId.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Times New Roman", 12F)
        Label9.Location = New Point(93, 520)
        Label9.Name = "Label9"
        Label9.Size = New Size(166, 27)
        Label9.TabIndex = 19
        Label9.Text = "Programme ID :"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(315, 39)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(270, 31)
        txtStudentId.TabIndex = 22
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 10F)
        Label10.Location = New Point(135, 41)
        Label10.Name = "Label10"
        Label10.Size = New Size(111, 28)
        Label10.TabIndex = 21
        Label10.Text = "Student Id :"
        ' 
        ' Registerstudent
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(855, 753)
        Controls.Add(txtStudentId)
        Controls.Add(Label10)
        Controls.Add(txtProgrammeId)
        Controls.Add(Label9)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Controls.Add(Label8)
        Controls.Add(rdoFemale)
        Controls.Add(rdoMale)
        Controls.Add(dtpenrollment)
        Controls.Add(Label7)
        Controls.Add(txtEmail)
        Controls.Add(Label6)
        Controls.Add(txtAddress)
        Controls.Add(Label5)
        Controls.Add(txtPhone)
        Controls.Add(Label4)
        Controls.Add(dtpdateofbirth)
        Controls.Add(Label3)
        Controls.Add(txtLastName)
        Controls.Add(Label2)
        Controls.Add(txtFirstname)
        Controls.Add(Label1)
        MaximumSize = New Size(885, 815)
        Name = "Registerstudent"
        Text = "RegisterStudent"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpdateofbirth As DateTimePicker
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents dtpenrollment As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents Label8 As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtProgrammeId As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents Label10 As Label
End Class
