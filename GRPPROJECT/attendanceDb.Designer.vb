<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attendanceDb
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
        txtStudentId = New TextBox()
        DateTimePicker1 = New DateTimePicker()
        btnRecord = New Button()
        txtLevel = New TextBox()
        Label2 = New Label()
        txtVenue = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        txtCourse = New TextBox()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(60, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(128, 26)
        Label1.TabIndex = 0
        Label1.Text = "Student ID :"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(210, 40)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(300, 31)
        txtStudentId.TabIndex = 1
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(210, 336)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(300, 31)
        DateTimePicker1.TabIndex = 2
        ' 
        ' btnRecord
        ' 
        btnRecord.BackColor = Color.SpringGreen
        btnRecord.Font = New Font("Cambria", 11F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRecord.Location = New Point(276, 417)
        btnRecord.Name = "btnRecord"
        btnRecord.Size = New Size(123, 55)
        btnRecord.TabIndex = 3
        btnRecord.Text = "RECORD"
        btnRecord.UseVisualStyleBackColor = False
        ' 
        ' txtLevel
        ' 
        txtLevel.Location = New Point(210, 116)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(300, 31)
        txtLevel.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(96, 116)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 26)
        Label2.TabIndex = 4
        Label2.Text = "Level :"
        ' 
        ' txtVenue
        ' 
        txtVenue.Location = New Point(210, 265)
        txtVenue.Name = "txtVenue"
        txtVenue.Size = New Size(300, 31)
        txtVenue.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(96, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 26)
        Label3.TabIndex = 6
        Label3.Text = "Venue :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(96, 340)
        Label4.Name = "Label4"
        Label4.Size = New Size(70, 26)
        Label4.TabIndex = 8
        Label4.Text = "Date :"
        ' 
        ' txtCourse
        ' 
        txtCourse.Location = New Point(210, 192)
        txtCourse.Name = "txtCourse"
        txtCourse.Size = New Size(300, 31)
        txtCourse.TabIndex = 10
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(96, 197)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 26)
        Label5.TabIndex = 9
        Label5.Text = "Course :"
        ' 
        ' attendanceDb
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.SteelBlue
        ClientSize = New Size(800, 493)
        Controls.Add(txtCourse)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(txtVenue)
        Controls.Add(Label3)
        Controls.Add(txtLevel)
        Controls.Add(Label2)
        Controls.Add(btnRecord)
        Controls.Add(DateTimePicker1)
        Controls.Add(txtStudentId)
        Controls.Add(Label1)
        MaximizeBox = False
        Name = "attendanceDb"
        Text = "RecordAttendance"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnRecord As Button
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtVenue As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCourse As TextBox
    Friend WithEvents Label5 As Label
End Class
