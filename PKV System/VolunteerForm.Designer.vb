<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VolunteerForm
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
        Me.InformationLable = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.选项ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回登录ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.返回注册ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.退出ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllActivitiesList = New System.Windows.Forms.ListBox()
        Me.AddActivityButton = New System.Windows.Forms.Button()
        Me.SelectedActivitiesList = New System.Windows.Forms.ListBox()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.AllActivitiesLabel = New System.Windows.Forms.Label()
        Me.SelectedActivitiesLabel = New System.Windows.Forms.Label()
        Me.SelectedActivitiesTimeLabel = New System.Windows.Forms.Label()
        Me.CustomerActivityLableL = New System.Windows.Forms.LinkLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'InformationLable
        '
        Me.InformationLable.AutoSize = True
        Me.InformationLable.Location = New System.Drawing.Point(72, 62)
        Me.InformationLable.Name = "InformationLable"
        Me.InformationLable.Size = New System.Drawing.Size(0, 20)
        Me.InformationLable.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.选项ToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        '选项ToolStripMenuItem
        '
        Me.选项ToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.返回登录ToolStripMenuItem, Me.返回注册ToolStripMenuItem, Me.退出ToolStripMenuItem})
        Me.选项ToolStripMenuItem.Name = "选项ToolStripMenuItem"
        Me.选项ToolStripMenuItem.Size = New System.Drawing.Size(53, 24)
        Me.选项ToolStripMenuItem.Text = "选项"
        '
        '返回登录ToolStripMenuItem
        '
        Me.返回登录ToolStripMenuItem.Name = "返回登录ToolStripMenuItem"
        Me.返回登录ToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.返回登录ToolStripMenuItem.Text = "返回登录"
        '
        '返回注册ToolStripMenuItem
        '
        Me.返回注册ToolStripMenuItem.Name = "返回注册ToolStripMenuItem"
        Me.返回注册ToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.返回注册ToolStripMenuItem.Text = "返回注册"
        '
        '退出ToolStripMenuItem
        '
        Me.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem"
        Me.退出ToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.退出ToolStripMenuItem.Text = "退出"
        '
        'AllActivitiesList
        '
        Me.AllActivitiesList.FormattingEnabled = True
        Me.AllActivitiesList.ItemHeight = 20
        Me.AllActivitiesList.Location = New System.Drawing.Point(77, 116)
        Me.AllActivitiesList.Name = "AllActivitiesList"
        Me.AllActivitiesList.Size = New System.Drawing.Size(227, 204)
        Me.AllActivitiesList.TabIndex = 3
        '
        'AddActivityButton
        '
        Me.AddActivityButton.Location = New System.Drawing.Point(348, 166)
        Me.AddActivityButton.Name = "AddActivityButton"
        Me.AddActivityButton.Size = New System.Drawing.Size(94, 29)
        Me.AddActivityButton.TabIndex = 4
        Me.AddActivityButton.Text = "选择活动->"
        Me.AddActivityButton.UseVisualStyleBackColor = True
        '
        'SelectedActivitiesList
        '
        Me.SelectedActivitiesList.FormattingEnabled = True
        Me.SelectedActivitiesList.ItemHeight = 20
        Me.SelectedActivitiesList.Location = New System.Drawing.Point(483, 116)
        Me.SelectedActivitiesList.Name = "SelectedActivitiesList"
        Me.SelectedActivitiesList.Size = New System.Drawing.Size(235, 204)
        Me.SelectedActivitiesList.TabIndex = 5
        '
        'CancelButton
        '
        Me.CancelButton.Location = New System.Drawing.Point(348, 238)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(94, 29)
        Me.CancelButton.TabIndex = 6
        Me.CancelButton.Text = "<-取消选择"
        Me.CancelButton.UseVisualStyleBackColor = True
        '
        'AllActivitiesLabel
        '
        Me.AllActivitiesLabel.AutoSize = True
        Me.AllActivitiesLabel.Location = New System.Drawing.Point(138, 93)
        Me.AllActivitiesLabel.Name = "AllActivitiesLabel"
        Me.AllActivitiesLabel.Size = New System.Drawing.Size(105, 20)
        Me.AllActivitiesLabel.TabIndex = 7
        Me.AllActivitiesLabel.Text = "所有活动/用时"
        '
        'SelectedActivitiesLabel
        '
        Me.SelectedActivitiesLabel.AutoSize = True
        Me.SelectedActivitiesLabel.Location = New System.Drawing.Point(538, 93)
        Me.SelectedActivitiesLabel.Name = "SelectedActivitiesLabel"
        Me.SelectedActivitiesLabel.Size = New System.Drawing.Size(120, 20)
        Me.SelectedActivitiesLabel.TabIndex = 8
        Me.SelectedActivitiesLabel.Text = "已选择活动/用时"
        '
        'SelectedActivitiesTimeLabel
        '
        Me.SelectedActivitiesTimeLabel.AutoSize = True
        Me.SelectedActivitiesTimeLabel.Location = New System.Drawing.Point(538, 348)
        Me.SelectedActivitiesTimeLabel.Name = "SelectedActivitiesTimeLabel"
        Me.SelectedActivitiesTimeLabel.Size = New System.Drawing.Size(112, 20)
        Me.SelectedActivitiesTimeLabel.TabIndex = 9
        Me.SelectedActivitiesTimeLabel.Text = "总时长： 0小时"
        '
        'CustomerActivityLableL
        '
        Me.CustomerActivityLableL.AutoSize = True
        Me.CustomerActivityLableL.Location = New System.Drawing.Point(77, 348)
        Me.CustomerActivityLableL.Name = "CustomerActivityLableL"
        Me.CustomerActivityLableL.Size = New System.Drawing.Size(234, 20)
        Me.CustomerActivityLableL.TabIndex = 10
        Me.CustomerActivityLableL.TabStop = True
        Me.CustomerActivityLableL.Text = "没有想要的活动？点此自行上传！"
        '
        'VolunteerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CustomerActivityLableL)
        Me.Controls.Add(Me.SelectedActivitiesTimeLabel)
        Me.Controls.Add(Me.SelectedActivitiesLabel)
        Me.Controls.Add(Me.AllActivitiesLabel)
        Me.Controls.Add(Me.CancelButton)
        Me.Controls.Add(Me.SelectedActivitiesList)
        Me.Controls.Add(Me.AddActivityButton)
        Me.Controls.Add(Me.AllActivitiesList)
        Me.Controls.Add(Me.InformationLable)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "VolunteerForm"
        Me.Text = "报名"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InformationLable As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents 选项ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回登录ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 返回注册ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents 退出ToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllActivitiesList As ListBox
    Friend WithEvents AddActivityButton As Button
    Friend WithEvents SelectedActivitiesList As ListBox
    Friend WithEvents CancelButton As Button
    Friend WithEvents AllActivitiesLabel As Label
    Friend WithEvents SelectedActivitiesLabel As Label
    Friend WithEvents SelectedActivitiesTimeLabel As Label
    Friend WithEvents CustomerActivityLableL As LinkLabel
End Class
