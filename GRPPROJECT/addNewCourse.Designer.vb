<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addNewCourse
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
        txtCourseCode = New TextBox()
        btnAdd = New Button()
        Label2 = New Label()
        txtCourseName = New TextBox()
        txtCredits = New TextBox()
        txtProgrammeId = New TextBox()
        btnCancel = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtCourseCode
        ' 
        txtCourseCode.Location = New Point(391, 52)
        txtCourseCode.Name = "txtCourseCode"
        txtCourseCode.Size = New Size(198, 31)
        txtCourseCode.TabIndex = 0
        ' 
        ' btnAdd
        ' 
        btnAdd.BackColor = Color.SpringGreen
        btnAdd.Font = New Font("Candara", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(250, 380)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(131, 52)
        btnAdd.TabIndex = 3
        btnAdd.Text = "ADD"
        btnAdd.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(168, 132)
        Label2.Name = "Label2"
        Label2.Size = New Size(148, 26)
        Label2.TabIndex = 5
        Label2.Text = "Course Name :"
        ' 
        ' txtCourseName
        ' 
        txtCourseName.Location = New Point(391, 130)
        txtCourseName.Name = "txtCourseName"
        txtCourseName.Size = New Size(198, 31)
        txtCourseName.TabIndex = 4
        ' 
        ' txtCredits
        ' 
        txtCredits.Location = New Point(391, 207)
        txtCredits.Name = "txtCredits"
        txtCredits.Size = New Size(198, 31)
        txtCredits.TabIndex = 6
        ' 
        ' txtProgrammeId
        ' 
        txtProgrammeId.Location = New Point(391, 288)
        txtProgrammeId.Name = "txtProgrammeId"
        txtProgrammeId.Size = New Size(198, 31)
        txtProgrammeId.TabIndex = 8
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Candara", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(546, 380)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(130, 52)
        btnCancel.TabIndex = 10
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(176, 57)
        Label1.Name = "Label1"
        Label1.Size = New Size(140, 26)
        Label1.TabIndex = 11
        Label1.Text = "Course Code :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(227, 209)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 26)
        Label3.TabIndex = 12
        Label3.Text = "Credits :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 11F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(154, 288)
        Label4.Name = "Label4"
        Label4.Size = New Size(162, 26)
        Label4.TabIndex = 13
        Label4.Text = "Programme ID :"
        ' 
        ' addNewCourse
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(920, 497)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(btnCancel)
        Controls.Add(txtProgrammeId)
        Controls.Add(txtCredits)
        Controls.Add(Label2)
        Controls.Add(txtCourseName)
        Controls.Add(btnAdd)
        Controls.Add(txtCourseCode)
        MaximizeBox = False
        Name = "addNewCourse"
        Text = "addNewCourse"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCourseCode As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCourseName As TextBox
    Friend WithEvents txtCredits As TextBox
    Friend WithEvents txtProgrammeId As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
