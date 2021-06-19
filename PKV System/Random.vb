Public Class RandomForm

    Private Sub RandomButton_Click(sender As Object, e As EventArgs) Handles RandomButton.Click
        number = Rnd() * 100 Mod 100
        NumberLable.Text = "您抽中的号码是：" & number
    End Sub

    Private Sub RandomForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()
    End Sub

    Private Sub EnterButton_Click(sender As Object, e As EventArgs) Handles EnterButton.Click
        If NumberLable.Text = "请点击按钮摇号" Then
            MsgBox("请先摇号！")
        Else

            NumberLable.Text = "请点击按钮摇号"
            VolunteerForm.InformationLable.Text = "欢迎" & username & "！你的抽签号是" & number
            VolunteerForm.Show()
            Me.Hide()
        End If

    End Sub

End Class