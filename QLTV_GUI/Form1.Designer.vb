<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Btn_Register = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Txt_DiaChi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_Email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtp_NgayLap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Dtp_NgaySinh = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Txt_MaThuThu = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_UserName = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_PassWord = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Txt_ConfirmPassWord = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(18, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(430, 70)
        Me.Label3.TabIndex = 103
        Me.Label3.Text = "Đăng kí tài khoản"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(13, 57)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1287, 54)
        Me.BunifuSeparator1.TabIndex = 106
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Btn_Register
        '
        Me.Btn_Register.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Register.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Register.BorderRadius = 7
        Me.Btn_Register.ButtonText = "TẠO TÀI KHOẢN"
        Me.Btn_Register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Register.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Register.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Register.Iconimage = CType(resources.GetObject("Btn_Register.Iconimage"), System.Drawing.Image)
        Me.Btn_Register.Iconimage_right = Nothing
        Me.Btn_Register.Iconimage_right_Selected = Nothing
        Me.Btn_Register.Iconimage_Selected = Nothing
        Me.Btn_Register.IconMarginLeft = 0
        Me.Btn_Register.IconMarginRight = 0
        Me.Btn_Register.IconRightVisible = True
        Me.Btn_Register.IconRightZoom = 0R
        Me.Btn_Register.IconVisible = False
        Me.Btn_Register.IconZoom = 90.0R
        Me.Btn_Register.IsTab = False
        Me.Btn_Register.Location = New System.Drawing.Point(519, 501)
        Me.Btn_Register.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Register.Name = "Btn_Register"
        Me.Btn_Register.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Register.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Register.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Register.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Register.selected = False
        Me.Btn_Register.Size = New System.Drawing.Size(324, 74)
        Me.Btn_Register.TabIndex = 107
        Me.Btn_Register.Text = "TẠO TÀI KHOẢN"
        Me.Btn_Register.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Register.Textcolor = System.Drawing.Color.White
        Me.Btn_Register.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1245, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 48)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 102
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_DiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DiaChi.Location = New System.Drawing.Point(387, 279)
        Me.Txt_DiaChi.Multiline = True
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(282, 44)
        Me.Txt_DiaChi.TabIndex = 120
        '
        'Txt_Email
        '
        Me.Txt_Email.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(387, 334)
        Me.Txt_Email.Multiline = True
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(282, 44)
        Me.Txt_Email.TabIndex = 121
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label9.Location = New System.Drawing.Point(106, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 44)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Ngày Lập"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(106, 334)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 44)
        Me.Label8.TabIndex = 114
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(106, 279)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 44)
        Me.Label6.TabIndex = 113
        Me.Label6.Text = "Địa Chỉ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(106, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 44)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "Ngày Sinh"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(106, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 44)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "Họ Và Tên"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayLap.BorderRadius = 0
        Me.Dtp_NgayLap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.FormatCustom = Nothing
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(387, 387)
        Me.Dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(282, 44)
        Me.Dtp_NgayLap.TabIndex = 122
        Me.Dtp_NgayLap.Value = New Date(2018, 6, 8, 0, 0, 0, 0)
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgaySinh.BorderRadius = 0
        Me.Dtp_NgaySinh.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgaySinh.FormatCustom = Nothing
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(387, 217)
        Me.Dtp_NgaySinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(282, 44)
        Me.Dtp_NgaySinh.TabIndex = 119
        Me.Dtp_NgaySinh.Value = New Date(2018, 6, 8, 0, 0, 0, 0)
        '
        'Txt_MaThuThu
        '
        Me.Txt_MaThuThu.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaThuThu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaThuThu.Location = New System.Drawing.Point(387, 107)
        Me.Txt_MaThuThu.Multiline = True
        Me.Txt_MaThuThu.Name = "Txt_MaThuThu"
        Me.Txt_MaThuThu.Size = New System.Drawing.Size(282, 44)
        Me.Txt_MaThuThu.TabIndex = 123
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(106, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 44)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Mã Thủ Thư"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(387, 162)
        Me.Txt_HoVaTen.Multiline = True
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(282, 44)
        Me.Txt_HoVaTen.TabIndex = 124
        '
        'Txt_UserName
        '
        Me.Txt_UserName.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_UserName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_UserName.Location = New System.Drawing.Point(977, 107)
        Me.Txt_UserName.Multiline = True
        Me.Txt_UserName.Name = "Txt_UserName"
        Me.Txt_UserName.Size = New System.Drawing.Size(282, 44)
        Me.Txt_UserName.TabIndex = 127
        '
        'Txt_PassWord
        '
        Me.Txt_PassWord.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_PassWord.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_PassWord.Location = New System.Drawing.Point(977, 162)
        Me.Txt_PassWord.Multiline = True
        Me.Txt_PassWord.Name = "Txt_PassWord"
        Me.Txt_PassWord.Size = New System.Drawing.Size(282, 44)
        Me.Txt_PassWord.TabIndex = 128
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(696, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 44)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "Mật Khẩu"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(696, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(227, 44)
        Me.Label7.TabIndex = 125
        Me.Label7.Text = "Tên Tài Khoản"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Txt_ConfirmPassWord
        '
        Me.Txt_ConfirmPassWord.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_ConfirmPassWord.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_ConfirmPassWord.Location = New System.Drawing.Point(977, 222)
        Me.Txt_ConfirmPassWord.Multiline = True
        Me.Txt_ConfirmPassWord.Name = "Txt_ConfirmPassWord"
        Me.Txt_ConfirmPassWord.Size = New System.Drawing.Size(282, 44)
        Me.Txt_ConfirmPassWord.TabIndex = 130
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label10.Location = New System.Drawing.Point(696, 222)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(275, 44)
        Me.Label10.TabIndex = 129
        Me.Label10.Text = "Nhập lại Mật khẩu"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1327, 588)
        Me.Controls.Add(Me.Txt_ConfirmPassWord)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Txt_UserName)
        Me.Controls.Add(Me.Txt_PassWord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Txt_MaThuThu)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Dtp_NgaySinh)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Register)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Btn_Register As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Txt_MaThuThu As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_DiaChi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_Email As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Dtp_NgayLap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Dtp_NgaySinh As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Txt_ConfirmPassWord As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label10 As Label
    Friend WithEvents Txt_UserName As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_PassWord As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
End Class
