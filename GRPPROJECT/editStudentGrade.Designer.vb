<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editStudentGrade
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
        lblStudentId = New Label()
        txtStudentId = New TextBox()
        dtpExamDate = New DateTimePicker()
        btnUpdate = New Button()
        lblCourseId = New Label()
        Label3 = New Label()
        lblExamScore = New Label()
        txtExamScore = New TextBox()
        txtIAScore = New TextBox()
        txtCourseCode = New TextBox()
        btnCancel = New Button()
        btnLoad = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' lblStudentId
        ' 
        lblStudentId.AutoSize = True
        lblStudentId.Location = New Point(12, 60)
        lblStudentId.Name = "lblStudentId"
        lblStudentId.Size = New Size(108, 28)
        lblStudentId.TabIndex = 0
        lblStudentId.Text = "Student ID:"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(136, 60)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(179, 34)
        txtStudentId.TabIndex = 1
        ' 
        ' dtpExamDate
        ' 
        dtpExamDate.Location = New Point(349, 304)
        dtpExamDate.Name = "dtpExamDate"
        dtpExamDate.Size = New Size(300, 34)
        dtpExamDate.TabIndex = 2
        ' 
        ' btnUpdate
        ' 
        btnUpdate.BackColor = Color.Lime
        btnUpdate.Location = New Point(236, 411)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(118, 58)
        btnUpdate.TabIndex = 3
        btnUpdate.Text = "Update"
        btnUpdate.UseVisualStyleBackColor = False
        ' 
        ' lblCourseId
        ' 
        lblCourseId.AutoSize = True
        lblCourseId.Location = New Point(364, 63)
        lblCourseId.Name = "lblCourseId"
        lblCourseId.Size = New Size(100, 28)
        lblCourseId.TabIndex = 4
        lblCourseId.Text = "Course ID:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(200, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(88, 28)
        Label3.TabIndex = 5
        Label3.Text = "IA Score:"
        ' 
        ' lblExamScore
        ' 
        lblExamScore.AutoSize = True
        lblExamScore.Location = New Point(200, 233)
        lblExamScore.Name = "lblExamScore"
        lblExamScore.Size = New Size(116, 28)
        lblExamScore.TabIndex = 6
        lblExamScore.Text = "Exam Score:"
        ' 
        ' txtExamScore
        ' 
        txtExamScore.Location = New Point(349, 233)
        txtExamScore.Name = "txtExamScore"
        txtExamScore.Size = New Size(185, 34)
        txtExamScore.TabIndex = 7
        ' 
        ' txtIAScore
        ' 
        txtIAScore.Location = New Point(349, 159)
        txtIAScore.Name = "txtIAScore"
        txtIAScore.Size = New Size(154, 34)
        txtIAScore.TabIndex = 8
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(479, 63)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(175, 34)
        txtCourseCode.TabIndex = 9
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Location = New Point(479, 411)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(118, 58)
        btnCancel.TabIndex = 10
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' btnLoad
        ' 
        btnLoad.BackColor = Color.Blue
        btnLoad.ForeColor = SystemColors.ButtonHighlight
        btnLoad.Location = New Point(705, 60)
        btnLoad.Name = "btnLoad"
        btnLoad.Size = New Size(118, 58)
        btnLoad.TabIndex = 11
        btnLoad.Text = "Load"
        btnLoad.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 309)
        Label1.Name = "Label1"
        Label1.Size = New Size(108, 28)
        Label1.TabIndex = 12
        Label1.Text = "Exam Date:"
        ' 
        ' editStudentGrade
        ' 
        AutoScaleDimensions = New SizeF(11F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(880, 504)
        Controls.Add(Label1)
        Controls.Add(btnLoad)
        Controls.Add(btnCancel)
        Controls.Add(txtCourseCode)
        Controls.Add(txtIAScore)
        Controls.Add(txtExamScore)
        Controls.Add(lblExamScore)
        Controls.Add(Label3)
        Controls.Add(lblCourseId)
        Controls.Add(btnUpdate)
        Controls.Add(dtpExamDate)
        Controls.Add(txtStudentId)
        Controls.Add(lblStudentId)
        Font = New Font("Segoe UI", 10F)
        MaximumSize = New Size(912, 570)
        MdiChildrenMinimizedAnchorBottom = False
        Name = "editStudentGrade"
        Text = "editStudentGrade"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblStudentId As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents dtpExamDate As DateTimePicker
    Friend WithEvents btnUpdate As Button
    Friend WithEvents lblCourseId As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblExamScore As Label
    Friend WithEvents txtExamScore As TextBox
    Friend WithEvents txtIAScore As TextBox
    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents Label1 As Label
End Class
