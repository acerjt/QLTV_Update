<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_XemThongTin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_XemThongTin))
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaThuThu = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_DiaChi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_Email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Dtp_NgayLap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Dtp_NgaySinh = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MetroLink1 = New MetroFramework.Controls.MetroLink()
        Me.Btn_Đong = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(565, 156)
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.ReadOnly = True
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(282, 35)
        Me.Txt_HoVaTen.TabIndex = 146
        '
        'Txt_MaThuThu
        '
        Me.Txt_MaThuThu.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaThuThu.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaThuThu.Location = New System.Drawing.Point(565, 104)
        Me.Txt_MaThuThu.Name = "Txt_MaThuThu"
        Me.Txt_MaThuThu.ReadOnly = True
        Me.Txt_MaThuThu.Size = New System.Drawing.Size(282, 35)
        Me.Txt_MaThuThu.TabIndex = 145
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_DiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DiaChi.Location = New System.Drawing.Point(565, 267)
        Me.Txt_DiaChi.Multiline = True
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(282, 42)
        Me.Txt_DiaChi.TabIndex = 142
        '
        'Txt_Email
        '
        Me.Txt_Email.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(565, 319)
        Me.Txt_Email.Multiline = True
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(282, 42)
        Me.Txt_Email.TabIndex = 143
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label9.Location = New System.Drawing.Point(284, 370)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(161, 42)
        Me.Label9.TabIndex = 140
        Me.Label9.Text = "Ngày Lập"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label8.Location = New System.Drawing.Point(284, 319)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 42)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Email"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(284, 267)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(161, 42)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "Địa Chỉ"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(284, 208)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(161, 42)
        Me.Label5.TabIndex = 137
        Me.Label5.Text = "Ngày Sinh"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(284, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(189, 42)
        Me.Label4.TabIndex = 136
        Me.Label4.Text = "Họ Và Tên"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayLap.BorderRadius = 0
        Me.Dtp_NgayLap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgayLap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.FormatCustom = Nothing
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(565, 370)
        Me.Dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(282, 42)
        Me.Dtp_NgayLap.TabIndex = 144
        Me.Dtp_NgayLap.Value = New Date(2019, 5, 5, 0, 0, 0, 0)
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgaySinh.BorderRadius = 0
        Me.Dtp_NgaySinh.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dtp_NgaySinh.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgaySinh.FormatCustom = Nothing
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(565, 208)
        Me.Dtp_NgaySinh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(282, 42)
        Me.Dtp_NgaySinh.TabIndex = 141
        Me.Dtp_NgaySinh.Value = New Date(2019, 5, 5, 0, 0, 0, 0)
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(284, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 42)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Mã Thủ Thư"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(-12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(441, 70)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Thông tin cá nhân"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(-17, 56)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(961, 51)
        Me.BunifuSeparator1.TabIndex = 133
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(46, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(174, 191)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 152
        Me.PictureBox1.TabStop = False
        '
        'MetroLink1
        '
        Me.MetroLink1.BackColor = System.Drawing.Color.Red
        Me.MetroLink1.FontSize = MetroFramework.MetroLinkSize.Tall
        Me.MetroLink1.ForeColor = System.Drawing.Color.Red
        Me.MetroLink1.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.MetroLink1.Location = New System.Drawing.Point(290, 426)
        Me.MetroLink1.Name = "MetroLink1"
        Me.MetroLink1.Size = New System.Drawing.Size(585, 47)
        Me.MetroLink1.TabIndex = 151
        Me.MetroLink1.Text = "Mật khẩu có giá trị 100 ngày. Hãy đổi mật khẩu mới."
        Me.MetroLink1.UseSelectable = True
        '
        'Btn_Đong
        '
        Me.Btn_Đong.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Đong.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Đong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Đong.BorderRadius = 7
        Me.Btn_Đong.ButtonText = "ĐÓNG"
        Me.Btn_Đong.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Đong.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Đong.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Đong.Iconimage = CType(resources.GetObject("Btn_Đong.Iconimage"), System.Drawing.Image)
        Me.Btn_Đong.Iconimage_right = Nothing
        Me.Btn_Đong.Iconimage_right_Selected = Nothing
        Me.Btn_Đong.Iconimage_Selected = Nothing
        Me.Btn_Đong.IconMarginLeft = 0
        Me.Btn_Đong.IconMarginRight = 0
        Me.Btn_Đong.IconRightVisible = True
        Me.Btn_Đong.IconRightZoom = 0R
        Me.Btn_Đong.IconVisible = False
        Me.Btn_Đong.IconZoom = 90.0R
        Me.Btn_Đong.IsTab = False
        Me.Btn_Đong.Location = New System.Drawing.Point(351, 481)
        Me.Btn_Đong.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Btn_Đong.Name = "Btn_Đong"
        Me.Btn_Đong.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Đong.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Đong.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Đong.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Btn_Đong.selected = False
        Me.Btn_Đong.Size = New System.Drawing.Size(324, 70)
        Me.Btn_Đong.TabIndex = 134
        Me.Btn_Đong.Text = "ĐÓNG"
        Me.Btn_Đong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Đong.Textcolor = System.Drawing.Color.White
        Me.Btn_Đong.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(889, 12)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(55, 46)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 131
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Frm_XemThongTin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1013, 565)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MetroLink1)
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
        Me.Controls.Add(Me.Btn_Đong)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Frm_XemThongTin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_XemThongTin"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
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
    Friend WithEvents Btn_Đong As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents MetroLink1 As MetroFramework.Controls.MetroLink
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
