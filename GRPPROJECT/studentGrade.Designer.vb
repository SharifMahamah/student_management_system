<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentGrade
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
        DataGridView1 = New DataGridView()
        btnSearch = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(291, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 0
        Label1.Text = "Student ID :"
        ' 
        ' txtStudentId
        ' 
        txtStudentId.Location = New Point(444, 26)
        txtStudentId.Name = "txtStudentId"
        txtStudentId.Size = New Size(225, 31)
        txtStudentId.TabIndex = 1
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 184)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 62
        DataGridView1.Size = New Size(1183, 431)
        DataGridView1.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = Color.Lime
        btnSearch.Font = New Font("Cambria", 11F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(491, 77)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(112, 45)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' studentGrade
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSeaGreen
        ClientSize = New Size(1207, 627)
        Controls.Add(btnSearch)
        Controls.Add(DataGridView1)
        Controls.Add(txtStudentId)
        Controls.Add(Label1)
        Name = "studentGrade"
        Text = "studentGrade"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtStudentId As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnSearch As Button
End Class
