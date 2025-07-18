
Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Load the background image from a file
        Dim imagePath As String = "C:\Users\HP\OneDrive\Desktop/macos.jpg" ' path to your image

        '  Set the background image of the form
        Me.BackgroundImage = Image.FromFile(imagePath)
        Me.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub RegisterNewStudentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisterNewStudentstripmenu.Click
        Dim registerStudent As New Registerstudent()
        registerStudent.Show(Me)
    End Sub

    Private Sub StudentsListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentsListToolStripMenuItem.Click
        Dim studentList As New studentListForm()
        studentList.Show(Me)
    End Sub

    Private Sub AddNewCourseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewCourseToolStripMenuItem.Click
        Dim newCourse As New addNewCourse()
        newCourse.Show(Me)
    End Sub

    Private Sub ViewCoursesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewCoursesToolStripMenuItem.Click
        Dim course_List As New courseList()
        course_List.Show(Me)
    End Sub

    Private Sub AddStudentResultsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddStudentResultsToolStripMenuItem.Click
        Dim add_Results As New addResults()
        add_Results.Show(Me)
    End Sub

    Private Sub RECToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RECToolStripMenuItem.Click
        Dim attendance As New attendanceDb()
        attendance.Show(Me)
    End Sub

    Private Sub VToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VToolStripMenuItem.Click
        Dim student_Grade As New studentGrade()
        student_Grade.Show(Me)
    End Sub

    Private Sub EditStudentRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentRecordToolStripMenuItem.Click
        Dim editStudent As New EditStudentRecord
        editStudent.Show(Me)
    End Sub

    Private Sub EditStudentGradesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditStudentGradesToolStripMenuItem.Click
        Dim editGrades As New editStudentGrade
        editGrades.Show(Me)

    End Sub
End Class