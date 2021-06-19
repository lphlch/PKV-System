<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RandomForm
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
        Me.NumberLable = New System.Windows.Forms.Label()
        Me.RandomButton = New System.Windows.Forms.Button()
        Me.EnterButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NumberLable
        '
        Me.NumberLable.AutoSize = True
        Me.NumberLable.Location = New System.Drawing.Point(331, 138)
        Me.NumberLable.Name = "NumberLable"
        Me.NumberLable.Size = New System.Drawing.Size(114, 20)
        Me.NumberLable.TabIndex = 0
        Me.NumberLable.Text = "请点击按钮摇号"
        '
        'RandomButton
        '
        Me.RandomButton.Location = New System.Drawing.Point(341, 258)
        Me.RandomButton.Name = "RandomButton"
        Me.RandomButton.Size = New System.Drawing.Size(94, 29)
        Me.RandomButton.TabIndex = 1
        Me.RandomButton.Text = "点击摇号"
        Me.RandomButton.UseVisualStyleBackColor = True
        '
        'EnterButton
        '
        Me.EnterButton.Location = New System.Drawing.Point(341, 324)
        Me.EnterButton.Name = "EnterButton"
        Me.EnterButton.Size = New System.Drawing.Size(94, 29)
        Me.EnterButton.TabIndex = 2
        Me.EnterButton.Text = "进入报名"
        Me.EnterButton.UseVisualStyleBackColor = True
        '
        'RandomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EnterButton)
        Me.Controls.Add(Me.RandomButton)
        Me.Controls.Add(Me.NumberLable)
        Me.Name = "RandomForm"
        Me.Text = "抽签"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumberLable As Label
    Friend WithEvents RandomButton As Button
    Friend WithEvents EnterButton As Button
End Class
