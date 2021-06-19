Class RegForm
    Private Sub RegForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameText.Clear()
        PasswordText.Clear()
    End Sub

    Private Sub RegButton_Click(sender As Object, e As EventArgs) Handles RegButton.Click
        username = UsernameText.Text
        password = PasswordText.Text

        If username = "" Or password = "" Then
            MsgBox("请输入用户名和密码！")
        Else
            MsgBox("注册成功!")

            UsernameText.Clear()
            PasswordText.Clear()

            LoginForm.Show()
            Me.Hide()
        End If

    End Sub


End Class
