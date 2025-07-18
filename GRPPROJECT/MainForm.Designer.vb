<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        MenuStrip1 = New MenuStrip()
        STUDENTToolStripMenuItem = New ToolStripMenuItem()
        RegisterNewStudentstripmenu = New ToolStripMenuItem()
        StudentsListToolStripMenuItem = New ToolStripMenuItem()
        EditStudentRecordToolStripMenuItem = New ToolStripMenuItem()
        COURSEToolStripMenuItem = New ToolStripMenuItem()
        AddNewCourseToolStripMenuItem = New ToolStripMenuItem()
        ViewCoursesToolStripMenuItem = New ToolStripMenuItem()
        SCOREToolStripMenuItem = New ToolStripMenuItem()
        AddStudentResultsToolStripMenuItem = New ToolStripMenuItem()
        VToolStripMenuItem = New ToolStripMenuItem()
        ATTENDANCEToolStripMenuItem = New ToolStripMenuItem()
        RECToolStripMenuItem = New ToolStripMenuItem()
        EditStudentGradesToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(24, 24)
        MenuStrip1.Items.AddRange(New ToolStripItem() {STUDENTToolStripMenuItem, COURSEToolStripMenuItem, SCOREToolStripMenuItem, ATTENDANCEToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(914, 33)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' STUDENTToolStripMenuItem
        ' 
        STUDENTToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RegisterNewStudentstripmenu, StudentsListToolStripMenuItem, EditStudentRecordToolStripMenuItem})
        STUDENTToolStripMenuItem.Name = "STUDENTToolStripMenuItem"
        STUDENTToolStripMenuItem.Size = New Size(103, 29)
        STUDENTToolStripMenuItem.Text = "STUDENT"
        ' 
        ' RegisterNewStudentstripmenu
        ' 
        RegisterNewStudentstripmenu.Name = "RegisterNewStudentstripmenu"
        RegisterNewStudentstripmenu.Size = New Size(283, 34)
        RegisterNewStudentstripmenu.Text = "Register New Student"
        ' 
        ' StudentsListToolStripMenuItem
        ' 
        StudentsListToolStripMenuItem.Name = "StudentsListToolStripMenuItem"
        StudentsListToolStripMenuItem.Size = New Size(283, 34)
        StudentsListToolStripMenuItem.Text = "Student List"
        ' 
        ' EditStudentRecordToolStripMenuItem
        ' 
        EditStudentRecordToolStripMenuItem.Name = "EditStudentRecordToolStripMenuItem"
        EditStudentRecordToolStripMenuItem.Size = New Size(283, 34)
        EditStudentRecordToolStripMenuItem.Text = "Edit Student Record"
        ' 
        ' COURSEToolStripMenuItem
        ' 
        COURSEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddNewCourseToolStripMenuItem, ViewCoursesToolStripMenuItem})
        COURSEToolStripMenuItem.Name = "COURSEToolStripMenuItem"
        COURSEToolStripMenuItem.Size = New Size(95, 29)
        COURSEToolStripMenuItem.Text = "COURSE"
        ' 
        ' AddNewCourseToolStripMenuItem
        ' 
        AddNewCourseToolStripMenuItem.Name = "AddNewCourseToolStripMenuItem"
        AddNewCourseToolStripMenuItem.Size = New Size(248, 34)
        AddNewCourseToolStripMenuItem.Text = "Add New Course"
        ' 
        ' ViewCoursesToolStripMenuItem
        ' 
        ViewCoursesToolStripMenuItem.Name = "ViewCoursesToolStripMenuItem"
        ViewCoursesToolStripMenuItem.Size = New Size(248, 34)
        ViewCoursesToolStripMenuItem.Text = "View Courses"
        ' 
        ' SCOREToolStripMenuItem
        ' 
        SCOREToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AddStudentResultsToolStripMenuItem, VToolStripMenuItem, EditStudentGradesToolStripMenuItem})
        SCOREToolStripMenuItem.Name = "SCOREToolStripMenuItem"
        SCOREToolStripMenuItem.Size = New Size(96, 29)
        SCOREToolStripMenuItem.Text = "RESULTS"
        ' 
        ' AddStudentResultsToolStripMenuItem
        ' 
        AddStudentResultsToolStripMenuItem.Name = "AddStudentResultsToolStripMenuItem"
        AddStudentResultsToolStripMenuItem.Size = New Size(277, 34)
        AddStudentResultsToolStripMenuItem.Text = "Add Student Results"
        ' 
        ' VToolStripMenuItem
        ' 
        VToolStripMenuItem.Name = "VToolStripMenuItem"
        VToolStripMenuItem.Size = New Size(277, 34)
        VToolStripMenuItem.Text = "View Student Grades"
        ' 
        ' ATTENDANCEToolStripMenuItem
        ' 
        ATTENDANCEToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RECToolStripMenuItem})
        ATTENDANCEToolStripMenuItem.Name = "ATTENDANCEToolStripMenuItem"
        ATTENDANCEToolStripMenuItem.Size = New Size(137, 29)
        ATTENDANCEToolStripMenuItem.Text = "ATTENDANCE"
        ' 
        ' RECToolStripMenuItem
        ' 
        RECToolStripMenuItem.Name = "RECToolStripMenuItem"
        RECToolStripMenuItem.Size = New Size(330, 34)
        RECToolStripMenuItem.Text = "Record Student Attendance"
        ' 
        ' EditStudentGradesToolStripMenuItem
        ' 
        EditStudentGradesToolStripMenuItem.Name = "EditStudentGradesToolStripMenuItem"
        EditStudentGradesToolStripMenuItem.Size = New Size(277, 34)
        EditStudentGradesToolStripMenuItem.Text = "Edit Student Grades"
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(914, 635)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Text = "MainForm"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents STUDENTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents COURSEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SCOREToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisterNewStudentstripmenu As ToolStripMenuItem
    Friend WithEvents StudentsListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewCourseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewCoursesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddStudentResultsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ATTENDANCEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditStudentRecordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditStudentGradesToolStripMenuItem As ToolStripMenuItem
End Class
