Public Class LoginForm

    Private Sub RegButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        Dim curUsername, curPassword As String
        curUsername = UsernameText.Text
        curPassword = PasswordText.Text

        If curUsername = "" Or curPassword = "" Then
            MsgBox("请输入用户名和密码！")
        ElseIf curUsername <> username Or curPassword <> password Then
            MsgBox("用户名或密码错误！")
        Else
            MsgBox("登录成功!")

            UsernameText.Clear()
            PasswordText.Clear()

            RandomForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UsernameText.Clear()
        PasswordText.Clear()
    End Sub

End Class