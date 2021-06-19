<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PasswordLable = New System.Windows.Forms.Label()
        Me.UsernameLable = New System.Windows.Forms.Label()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'PasswordLable
        '
        Me.PasswordLable.AutoSize = True
        Me.PasswordLable.Location = New System.Drawing.Point(211, 208)
        Me.PasswordLable.Name = "PasswordLable"
        Me.PasswordLable.Size = New System.Drawing.Size(39, 20)
        Me.PasswordLable.TabIndex = 10
        Me.PasswordLable.Text = "密码"
        '
        'UsernameLable
        '
        Me.UsernameLable.AutoSize = True
        Me.UsernameLable.Location = New System.Drawing.Point(211, 136)
        Me.UsernameLable.Name = "UsernameLable"
        Me.UsernameLable.Size = New System.Drawing.Size(54, 20)
        Me.UsernameLable.TabIndex = 9
        Me.UsernameLable.Text = "用户名"
        '
        'LoginButton
        '
        Me.LoginButton.Location = New System.Drawing.Point(397, 289)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(94, 29)
        Me.LoginButton.TabIndex = 8
        Me.LoginButton.Text = "登录"
        Me.LoginButton.UseVisualStyleBackColor = True
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(319, 201)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(270, 27)
        Me.PasswordText.TabIndex = 7
        '
        'UsernameText
        '
        Me.UsernameText.Location = New System.Drawing.Point(319, 133)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(270, 27)
        Me.UsernameText.TabIndex = 6
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PasswordLable)
        Me.Controls.Add(Me.UsernameLable)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UsernameText)
        Me.Name = "LoginForm"
        Me.Text = "登录"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PasswordLable As Label
    Friend WithEvents UsernameLable As Label
    Friend WithEvents LoginButton As Button
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents UsernameText As TextBox
End Class
