<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addResults
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
        btnSubmit = New Button()
        txtStudentId = New TextBox()
        Label2 = New Label()
        txtCourseCode = New TextBox()
        Label3 = New Label()
        txtIAScore = New TextBox()
        Label4 = New Label()
        txtExamScore = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        DateTimePicker1 = New DateTimePicker()
        btnCancel = New Button()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.SpringGreen
        btnSubmit.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSubmit.Location = New Point(136, 441)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(124, 50)
        btnSubmit.TabIndex = 2
        btnSubmit.Text = "SUBMIT"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(210, 47)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(300, 31)
        txtStudentId.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10F)
        Label2.Location = New Point(31, 47)
        Label2.Name = "Label2"
        Label2.Size = New Size(113, 28)
        Label2.TabIndex = 3
        Label2.Text = "Student ID :"
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(210, 119)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(300, 31)
        txtCourseCode.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10F)
        Label3.Location = New Point(14, 121)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 28)
        Label3.TabIndex = 5
        Label3.Text = "Course Code :"
        ' 
        ' txtIAScore
        ' 
        txtIAScore.Location = New Point(210, 186)
        txtIAScore.Name = "txtIAScore"
        txtIAScore.Size = New Size(300, 31)
        txtIAScore.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10F)
        Label4.Location = New Point(49, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 7
        Label4.Text = "IA Score :"
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(210, 254)
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(300, 31)
        txtExamScore.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10F)
        Label5.Location = New Point(22, 254)
        Label5.Name = "Label5"
        Label5.Size = New Size(121, 28)
        Label5.TabIndex = 9
        Label5.Text = "Exam Score :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10F)
        Label6.Location = New Point(30, 319)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 28)
        Label6.TabIndex = 11
        Label6.Text = "Exam Date :"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(210, 319)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 12
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(373, 441)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(121, 50)
        btnCancel.TabIndex = 13
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' addResults
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(667, 551)
        Controls.Add(btnCancel)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label6)
        Controls.Add(txtExamScore)
        Controls.Add(Label5)
        Controls.Add(txtIAScore)
        Controls.Add(Label4)
        Controls.Add(txtCourseCode)
        Controls.Add(Label3)
        Controls.Add(txtStudentId)
        Controls.Add(Label2)
        Controls.Add(btnSubmit)
        MaximizeBox = False
        Name = "addResults"
        Text = "addResults"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIAScore As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnCancel As Button
End Class
