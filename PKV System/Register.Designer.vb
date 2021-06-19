<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegForm
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
        Me.UsernameText = New System.Windows.Forms.TextBox()
        Me.PasswordText = New System.Windows.Forms.TextBox()
        Me.RegButton = New System.Windows.Forms.Button()
        Me.UsernameLable = New System.Windows.Forms.Label()
        Me.PasswordLable = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UsernameText
        '
        Me.UsernameText.Location = New System.Drawing.Point(281, 156)
        Me.UsernameText.Name = "UsernameText"
        Me.UsernameText.Size = New System.Drawing.Size(270, 27)
        Me.UsernameText.TabIndex = 0
        '
        'PasswordText
        '
        Me.PasswordText.Location = New System.Drawing.Point(281, 224)
        Me.PasswordText.Name = "PasswordText"
        Me.PasswordText.Size = New System.Drawing.Size(270, 27)
        Me.PasswordText.TabIndex = 1
        '
        'RegButton
        '
        Me.RegButton.Location = New System.Drawing.Point(359, 312)
        Me.RegButton.Name = "RegButton"
        Me.RegButton.Size = New System.Drawing.Size(94, 29)
        Me.RegButton.TabIndex = 3
        Me.RegButton.Text = "注册"
        Me.RegButton.UseVisualStyleBackColor = True
        '
        'UsernameLable
        '
        Me.UsernameLable.AutoSize = True
        Me.UsernameLable.Location = New System.Drawing.Point(173, 159)
        Me.UsernameLable.Name = "UsernameLable"
        Me.UsernameLable.Size = New System.Drawing.Size(54, 20)
        Me.UsernameLable.TabIndex = 4
        Me.UsernameLable.Text = "用户名"
        '
        'PasswordLable
        '
        Me.PasswordLable.AutoSize = True
        Me.PasswordLable.Location = New System.Drawing.Point(173, 231)
        Me.PasswordLable.Name = "PasswordLable"
        Me.PasswordLable.Size = New System.Drawing.Size(39, 20)
        Me.PasswordLable.TabIndex = 5
        Me.PasswordLable.Text = "密码"
        '
        'RegForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PasswordLable)
        Me.Controls.Add(Me.UsernameLable)
        Me.Controls.Add(Me.RegButton)
        Me.Controls.Add(Me.PasswordText)
        Me.Controls.Add(Me.UsernameText)
        Me.Name = "RegForm"
        Me.Text = "注册"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UsernameText As TextBox
    Friend WithEvents PasswordText As TextBox
    Friend WithEvents RegButton As Button
    Friend WithEvents UsernameLable As Label
    Friend WithEvents PasswordLable As Label
End Class
