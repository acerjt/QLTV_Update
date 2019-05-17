<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_DoiMatKhau
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_DoiMatKhau))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Txt_UserName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_PassWord = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_Doi = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Txt_NewPassWord = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_Confirm = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Txt_UserName
        '
        Me.Txt_UserName.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UserName.Location = New System.Drawing.Point(311, 87)
        Me.Txt_UserName.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_UserName.Multiline = True
        Me.Txt_UserName.Name = "Txt_UserName"
        Me.Txt_UserName.Size = New System.Drawing.Size(251, 36)
        Me.Txt_UserName.TabIndex = 170
        '
        'Txt_PassWord
        '
        Me.Txt_PassWord.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_PassWord.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PassWord.Location = New System.Drawing.Point(311, 131)
        Me.Txt_PassWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_PassWord.Multiline = True
        Me.Txt_PassWord.Name = "Txt_PassWord"
        Me.Txt_PassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_PassWord.Size = New System.Drawing.Size(251, 36)
        Me.Txt_PassWord.TabIndex = 171
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(61, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 35)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Mật Khẩu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(61, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(202, 35)
        Me.Label7.TabIndex = 168
        Me.Label7.Text = "Tên Tài Khoản"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(11, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 60)
        Me.Label3.TabIndex = 153
        Me.Label3.Text = "Thông tin cá nhân"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(6, 47)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(661, 43)
        Me.BunifuSeparator1.TabIndex = 154
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_Doi
        '
        Me.Btn_Doi.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Doi.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Doi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Doi.BorderRadius = 7
        Me.Btn_Doi.ButtonText = "ĐỔI MẬT KHẨU"
        Me.Btn_Doi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Doi.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Doi.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Doi.Iconimage = CType(resources.GetObject("Btn_Doi.Iconimage"), System.Drawing.Image)
        Me.Btn_Doi.Iconimage_right = Nothing
        Me.Btn_Doi.Iconimage_right_Selected = Nothing
        Me.Btn_Doi.Iconimage_Selected = Nothing
        Me.Btn_Doi.IconMarginLeft = 0
        Me.Btn_Doi.IconMarginRight = 0
        Me.Btn_Doi.IconRightVisible = True
        Me.Btn_Doi.IconRightZoom = 0R
        Me.Btn_Doi.IconVisible = False
        Me.Btn_Doi.IconZoom = 90.0R
        Me.Btn_Doi.IsTab = False
        Me.Btn_Doi.Location = New System.Drawing.Point(179, 312)
        Me.Btn_Doi.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Doi.Name = "Btn_Doi"
        Me.Btn_Doi.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Doi.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Doi.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Doi.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Doi.selected = False
        Me.Btn_Doi.Size = New System.Drawing.Size(288, 59)
        Me.Btn_Doi.TabIndex = 155
        Me.Btn_Doi.Text = "ĐỔI MẬT KHẨU"
        Me.Btn_Doi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Doi.Textcolor = System.Drawing.Color.White
        Me.Btn_Doi.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(619, 17)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 152
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Txt_NewPassWord
        '
        Me.Txt_NewPassWord.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NewPassWord.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NewPassWord.Location = New System.Drawing.Point(311, 178)
        Me.Txt_NewPassWord.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_NewPassWord.Multiline = True
        Me.Txt_NewPassWord.Name = "Txt_NewPassWord"
        Me.Txt_NewPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_NewPassWord.Size = New System.Drawing.Size(251, 36)
        Me.Txt_NewPassWord.TabIndex = 173
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(61, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 35)
        Me.Label1.TabIndex = 172
        Me.Label1.Text = "Mật Khẩu Mới"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_Confirm
        '
        Me.Txt_Confirm.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Confirm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Confirm.Location = New System.Drawing.Point(311, 221)
        Me.Txt_Confirm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Confirm.Multiline = True
        Me.Txt_Confirm.Name = "Txt_Confirm"
        Me.Txt_Confirm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txt_Confirm.Size = New System.Drawing.Size(251, 36)
        Me.Txt_Confirm.TabIndex = 175
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(61, 221)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(229, 35)
        Me.Label4.TabIndex = 174
        Me.Label4.Text = "Nhập Lại Mật Khẩu"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Frm_DoiMatKhau
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 395)
        Me.Controls.Add(Me.Txt_Confirm)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Txt_NewPassWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Txt_UserName)
        Me.Controls.Add(Me.Txt_PassWord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Btn_Doi)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_DoiMatKhau"
        Me.Text = "Frm_DoiMatKhau"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Txt_UserName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_PassWord As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Btn_Doi As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Txt_Confirm As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Txt_NewPassWord As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label1 As Label
End Class
