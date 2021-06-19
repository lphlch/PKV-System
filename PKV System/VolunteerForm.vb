Public Class VolunteerForm
    Dim activitiesName(100) As String
    Dim activitiesTime(100) As Integer

    Public Sub VolunteerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InformationLable.Text = "欢迎" & username & "！你的抽签号是" & number

        FileOpen(1, "Activities.txt", OpenMode.Input)
        Dim count As Integer = 0
        Do While Not EOF(1)
            Input(1, activitiesName(count))
            Input(1, activitiesTime(count))
            count += 1
        Loop
        FileClose()

        For i = 0 To count - 1
            AllActivitiesList.Items.Add(activitiesName(i) & " " & activitiesTime(i))
        Next

    End Sub

    Private Sub 返回登录ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回登录ToolStripMenuItem.Click
        RefreshInformation()
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub 返回注册ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 返回注册ToolStripMenuItem.Click
        RefreshInformation()
        RegForm.Show()
        Me.Hide()
    End Sub

    Private Sub 退出ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles 退出ToolStripMenuItem.Click
        End
    End Sub

    Private Sub AddActivityButton_Click(sender As Object, e As EventArgs) Handles AddActivityButton.Click
        Dim selected As Object = AllActivitiesList.SelectedItem
        SelectedActivitiesList.Items.Add(selected)

        CountSelectedTime()

    End Sub

    Private Sub CountSelectedTime()
        Dim sumTime As Integer = 0
        For Each item In SelectedActivitiesList.Items
            Dim strarr() As String = Split(item, " ")
            sumTime = Int(strarr(1)) + sumTime
        Next
        SelectedActivitiesTimeLabel.Text = "总时长：" & CStr(sumTime) & "小时"
    End Sub

    Private Sub CancelButton_Click(sender As Object, e As EventArgs) Handles CancelButton.Click
        Dim selected As Object = SelectedActivitiesList.SelectedItem
        SelectedActivitiesList.Items.Remove(selected)
        CountSelectedTime()
    End Sub

    Private Sub RefreshInformation()
        SelectedActivitiesList.Items.Clear()
        SelectedActivitiesTimeLabel.Text = "总时长：0小时"
    End Sub

    Private Sub CustomerActivityLableL_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles CustomerActivityLableL.LinkClicked
        Dim customAct = InputBox("请输入活动+时长，活动名和时长之间需要有一个空格", "自定义输入", "INPUT_EMPTY")

        If customAct <> "INPUT_EMPTY" Then
            Dim strarr() As String = Split(customAct, " ")

            If strarr.Length <= 1 Then
                MsgBox("输入有误，请重新输入！")
            Else
                Dim Time = Int(strarr(1))

                If Time <= 0 Then
                    MsgBox("输入有误，请重新输入！")
                Else
                    AllActivitiesList.Items.Add(customAct)
                End If

            End If
        End If

    End Sub

End Class