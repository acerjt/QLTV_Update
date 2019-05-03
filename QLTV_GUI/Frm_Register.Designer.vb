<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Register
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
        Me.Btn_Register = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Txt_UserName = New System.Windows.Forms.TextBox()
        Me.Txt_PassWord = New System.Windows.Forms.TextBox()
        Me.Txt_ConfirmPassWord = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Btn_Register
        '
        Me.Btn_Register.Location = New System.Drawing.Point(339, 359)
        Me.Btn_Register.Name = "Btn_Register"
        Me.Btn_Register.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Register.TabIndex = 0
        Me.Btn_Register.Text = "Đăng kí"
        Me.Btn_Register.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(99, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Confirm Password"
        '
        'Txt_UserName
        '
        Me.Txt_UserName.Location = New System.Drawing.Point(238, 99)
        Me.Txt_UserName.Name = "Txt_UserName"
        Me.Txt_UserName.Size = New System.Drawing.Size(264, 22)
        Me.Txt_UserName.TabIndex = 4
        '
        'Txt_PassWord
        '
        Me.Txt_PassWord.Location = New System.Drawing.Point(238, 140)
        Me.Txt_PassWord.Name = "Txt_PassWord"
        Me.Txt_PassWord.Size = New System.Drawing.Size(264, 22)
        Me.Txt_PassWord.TabIndex = 5
        Me.Txt_PassWord.UseSystemPasswordChar = True
        '
        'Txt_ConfirmPassWord
        '
        Me.Txt_ConfirmPassWord.Location = New System.Drawing.Point(238, 182)
        Me.Txt_ConfirmPassWord.Name = "Txt_ConfirmPassWord"
        Me.Txt_ConfirmPassWord.Size = New System.Drawing.Size(264, 22)
        Me.Txt_ConfirmPassWord.TabIndex = 6
        Me.Txt_ConfirmPassWord.UseSystemPasswordChar = True
        '
        'Frm_Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Txt_ConfirmPassWord)
        Me.Controls.Add(Me.Txt_PassWord)
        Me.Controls.Add(Me.Txt_UserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Register)
        Me.Name = "Frm_Register"
        Me.Text = "Frm_Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Register As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Txt_UserName As TextBox
    Friend WithEvents Txt_PassWord As TextBox
    Friend WithEvents Txt_ConfirmPassWord As TextBox
End Class
