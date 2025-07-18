<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        picboxLogin = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        btnLogin = New Button()
        btnCancel = New Button()
        CheckBoxpassword = New CheckBox()
        CType(picboxLogin, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' picboxLogin
        ' 
        picboxLogin.Location = New Point(12, 76)
        picboxLogin.Name = "picboxLogin"
        picboxLogin.Size = New Size(330, 261)
        picboxLogin.SizeMode = PictureBoxSizeMode.StretchImage
        picboxLogin.TabIndex = 0
        picboxLogin.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(357, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 28)
        Label1.TabIndex = 1
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cambria", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(357, 212)
        Label2.Name = "Label2"
        Label2.Size = New Size(114, 28)
        Label2.TabIndex = 2
        Label2.Text = "Password:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsername.Location = New Point(482, 107)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(246, 36)
        txtUsername.TabIndex = 3
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Cambria", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(482, 209)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(246, 36)
        txtPassword.TabIndex = 4
        txtPassword.UseSystemPasswordChar = True
        ' 
        ' btnLogin
        ' 
        btnLogin.BackColor = Color.Lime
        btnLogin.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnLogin.Location = New Point(384, 340)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(116, 50)
        btnLogin.TabIndex = 5
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' btnCancel
        ' 
        btnCancel.BackColor = Color.Red
        btnCancel.Font = New Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancel.Location = New Point(590, 340)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(117, 50)
        btnCancel.TabIndex = 6
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = False
        ' 
        ' CheckBoxpassword
        ' 
        CheckBoxpassword.AutoSize = True
        CheckBoxpassword.Font = New Font("Sitka Heading", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CheckBoxpassword.Location = New Point(482, 269)
        CheckBoxpassword.Name = "CheckBoxpassword"
        CheckBoxpassword.Size = New Size(154, 30)
        CheckBoxpassword.TabIndex = 7
        CheckBoxpassword.Text = "Show Password"
        CheckBoxpassword.UseVisualStyleBackColor = True
        ' 
        ' LoginForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LightSteelBlue
        ClientSize = New Size(843, 450)
        Controls.Add(CheckBoxpassword)
        Controls.Add(btnCancel)
        Controls.Add(btnLogin)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(picboxLogin)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "LoginForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "LoginForm"
        CType(picboxLogin, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents picboxLogin As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents CheckBoxpassword As CheckBox
End Class
