﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_QLDocGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_QLDocGia))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gdf = New System.Windows.Forms.Label()
        Me.ad = New System.Windows.Forms.Label()
        Me.sa = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btn_CapNhap = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Btn_Xoa = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Dtp_NgaySinh = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Dtp_NgayLap = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Btn_Close = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Cb_LoaiDocGia = New System.Windows.Forms.ComboBox()
        Me.Txt_HoVaTen = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_MaDocGia = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_TinhTrangThe = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_NgayHetHan = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_Email = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Txt_DiaChi = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Cb_LoaiDocGiaCapNhap = New System.Windows.Forms.ComboBox()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.Dgv_ListDocGia = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ngay = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.d = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv_ListDocGia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label7.Location = New System.Drawing.Point(659, 434)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 35)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Ngày Lập"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gdf
        '
        Me.gdf.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gdf.ForeColor = System.Drawing.Color.SeaGreen
        Me.gdf.Location = New System.Drawing.Point(156, 642)
        Me.gdf.Name = "gdf"
        Me.gdf.Size = New System.Drawing.Size(143, 28)
        Me.gdf.TabIndex = 45
        Me.gdf.Text = "Email"
        Me.gdf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ad
        '
        Me.ad.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad.ForeColor = System.Drawing.Color.SeaGreen
        Me.ad.Location = New System.Drawing.Point(156, 584)
        Me.ad.Name = "ad"
        Me.ad.Size = New System.Drawing.Size(143, 36)
        Me.ad.TabIndex = 43
        Me.ad.Text = "Địa Chỉ"
        Me.ad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'sa
        '
        Me.sa.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sa.ForeColor = System.Drawing.Color.SeaGreen
        Me.sa.Location = New System.Drawing.Point(156, 534)
        Me.sa.Name = "sa"
        Me.sa.Size = New System.Drawing.Size(164, 36)
        Me.sa.TabIndex = 42
        Me.sa.Text = "Ngày Sinh"
        Me.sa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label
        '
        Me.Label.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label.Location = New System.Drawing.Point(372, 90)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(180, 28)
        Me.Label.TabIndex = 41
        Me.Label.Text = "Loại Độc Giả"
        Me.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label2.Location = New System.Drawing.Point(156, 493)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 28)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "Họ Và Tên"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label1.Location = New System.Drawing.Point(156, 442)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 28)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Mã Độc Giả"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label3.Location = New System.Drawing.Point(659, 581)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(191, 35)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Loại Độc Giả"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label4.Location = New System.Drawing.Point(659, 486)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(228, 35)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Ngày Hết Hạn"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label5.Location = New System.Drawing.Point(659, 533)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 37)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "Tình Trạng Thẻ"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Btn_CapNhap
        '
        Me.Btn_CapNhap.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_CapNhap.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_CapNhap.BorderRadius = 7
        Me.Btn_CapNhap.ButtonText = "CẬP NHẬT"
        Me.Btn_CapNhap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_CapNhap.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_CapNhap.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_CapNhap.Iconimage = CType(resources.GetObject("Btn_CapNhap.Iconimage"), System.Drawing.Image)
        Me.Btn_CapNhap.Iconimage_right = Nothing
        Me.Btn_CapNhap.Iconimage_right_Selected = Nothing
        Me.Btn_CapNhap.Iconimage_Selected = Nothing
        Me.Btn_CapNhap.IconMarginLeft = 0
        Me.Btn_CapNhap.IconMarginRight = 0
        Me.Btn_CapNhap.IconRightVisible = True
        Me.Btn_CapNhap.IconRightZoom = 0R
        Me.Btn_CapNhap.IconVisible = False
        Me.Btn_CapNhap.IconZoom = 90.0R
        Me.Btn_CapNhap.IsTab = False
        Me.Btn_CapNhap.Location = New System.Drawing.Point(378, 702)
        Me.Btn_CapNhap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_CapNhap.Name = "Btn_CapNhap"
        Me.Btn_CapNhap.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_CapNhap.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_CapNhap.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_CapNhap.selected = False
        Me.Btn_CapNhap.Size = New System.Drawing.Size(220, 59)
        Me.Btn_CapNhap.TabIndex = 59
        Me.Btn_CapNhap.Text = "CẬP NHẬT"
        Me.Btn_CapNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_CapNhap.Textcolor = System.Drawing.Color.White
        Me.Btn_CapNhap.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Btn_Xoa
        '
        Me.Btn_Xoa.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.Btn_Xoa.BackColor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btn_Xoa.BorderRadius = 7
        Me.Btn_Xoa.ButtonText = "XÓA"
        Me.Btn_Xoa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Btn_Xoa.DisabledColor = System.Drawing.Color.Gray
        Me.Btn_Xoa.Iconcolor = System.Drawing.Color.Transparent
        Me.Btn_Xoa.Iconimage = CType(resources.GetObject("Btn_Xoa.Iconimage"), System.Drawing.Image)
        Me.Btn_Xoa.Iconimage_right = Nothing
        Me.Btn_Xoa.Iconimage_right_Selected = Nothing
        Me.Btn_Xoa.Iconimage_Selected = Nothing
        Me.Btn_Xoa.IconMarginLeft = 0
        Me.Btn_Xoa.IconMarginRight = 0
        Me.Btn_Xoa.IconRightVisible = True
        Me.Btn_Xoa.IconRightZoom = 0R
        Me.Btn_Xoa.IconVisible = False
        Me.Btn_Xoa.IconZoom = 90.0R
        Me.Btn_Xoa.IsTab = False
        Me.Btn_Xoa.Location = New System.Drawing.Point(668, 702)
        Me.Btn_Xoa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Btn_Xoa.Name = "Btn_Xoa"
        Me.Btn_Xoa.Normalcolor = System.Drawing.Color.SeaGreen
        Me.Btn_Xoa.OnHovercolor = System.Drawing.Color.DarkGreen
        Me.Btn_Xoa.OnHoverTextColor = System.Drawing.Color.White
        Me.Btn_Xoa.selected = False
        Me.Btn_Xoa.Size = New System.Drawing.Size(213, 59)
        Me.Btn_Xoa.TabIndex = 60
        Me.Btn_Xoa.Text = "XÓA"
        Me.Btn_Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.Btn_Xoa.Textcolor = System.Drawing.Color.White
        Me.Btn_Xoa.TextFont = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SeaGreen
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(338, 60)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Quản Lí Độc Giả"
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.Cursor = System.Windows.Forms.Cursors.Default
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 2
        Me.BunifuSeparator1.Location = New System.Drawing.Point(3, 60)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(1395, 16)
        Me.BunifuSeparator1.TabIndex = 77
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Dtp_NgaySinh
        '
        Me.Dtp_NgaySinh.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgaySinh.BorderRadius = 0
        Me.Dtp_NgaySinh.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgaySinh.FormatCustom = Nothing
        Me.Dtp_NgaySinh.Location = New System.Drawing.Point(348, 533)
        Me.Dtp_NgaySinh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dtp_NgaySinh.Name = "Dtp_NgaySinh"
        Me.Dtp_NgaySinh.Size = New System.Drawing.Size(251, 35)
        Me.Dtp_NgaySinh.TabIndex = 5
        Me.Dtp_NgaySinh.Value = New Date(2018, 5, 28, 16, 51, 25, 349)
        '
        'Dtp_NgayLap
        '
        Me.Dtp_NgayLap.BackColor = System.Drawing.Color.SeaGreen
        Me.Dtp_NgayLap.BorderRadius = 0
        Me.Dtp_NgayLap.ForeColor = System.Drawing.Color.White
        Me.Dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_NgayLap.FormatCustom = Nothing
        Me.Dtp_NgayLap.Location = New System.Drawing.Point(890, 434)
        Me.Dtp_NgayLap.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Dtp_NgayLap.Name = "Dtp_NgayLap"
        Me.Dtp_NgayLap.Size = New System.Drawing.Size(251, 35)
        Me.Dtp_NgayLap.TabIndex = 8
        Me.Dtp_NgayLap.Value = New Date(2018, 5, 28, 16, 51, 25, 349)
        '
        'Btn_Close
        '
        Me.Btn_Close.BackColor = System.Drawing.Color.Transparent
        Me.Btn_Close.Image = Global.QLTV_GUI.My.Resources.Resources.btnclose
        Me.Btn_Close.ImageActive = Nothing
        Me.Btn_Close.Location = New System.Drawing.Point(1349, 16)
        Me.Btn_Close.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Btn_Close.Name = "Btn_Close"
        Me.Btn_Close.Size = New System.Drawing.Size(49, 38)
        Me.Btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Btn_Close.TabIndex = 88
        Me.Btn_Close.TabStop = False
        Me.Btn_Close.Zoom = 10
        '
        'Cb_LoaiDocGia
        '
        Me.Cb_LoaiDocGia.DropDownWidth = 269
        Me.Cb_LoaiDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_LoaiDocGia.FormattingEnabled = True
        Me.Cb_LoaiDocGia.IntegralHeight = False
        Me.Cb_LoaiDocGia.ItemHeight = 22
        Me.Cb_LoaiDocGia.Location = New System.Drawing.Point(586, 90)
        Me.Cb_LoaiDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_LoaiDocGia.Name = "Cb_LoaiDocGia"
        Me.Cb_LoaiDocGia.Size = New System.Drawing.Size(251, 30)
        Me.Cb_LoaiDocGia.TabIndex = 1
        '
        'Txt_HoVaTen
        '
        Me.Txt_HoVaTen.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_HoVaTen.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_HoVaTen.Location = New System.Drawing.Point(348, 486)
        Me.Txt_HoVaTen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_HoVaTen.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.Multiline = True
        Me.Txt_HoVaTen.Name = "Txt_HoVaTen"
        Me.Txt_HoVaTen.Size = New System.Drawing.Size(251, 36)
        Me.Txt_HoVaTen.TabIndex = 4
        '
        'Txt_MaDocGia
        '
        Me.Txt_MaDocGia.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_MaDocGia.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_MaDocGia.Location = New System.Drawing.Point(348, 434)
        Me.Txt_MaDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_MaDocGia.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.Multiline = True
        Me.Txt_MaDocGia.Name = "Txt_MaDocGia"
        Me.Txt_MaDocGia.ReadOnly = True
        Me.Txt_MaDocGia.Size = New System.Drawing.Size(251, 36)
        Me.Txt_MaDocGia.TabIndex = 3
        '
        'Txt_TinhTrangThe
        '
        Me.Txt_TinhTrangThe.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_TinhTrangThe.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_TinhTrangThe.Location = New System.Drawing.Point(890, 533)
        Me.Txt_TinhTrangThe.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_TinhTrangThe.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_TinhTrangThe.Multiline = True
        Me.Txt_TinhTrangThe.Name = "Txt_TinhTrangThe"
        Me.Txt_TinhTrangThe.ReadOnly = True
        Me.Txt_TinhTrangThe.Size = New System.Drawing.Size(251, 36)
        Me.Txt_TinhTrangThe.TabIndex = 10
        '
        'Txt_NgayHetHan
        '
        Me.Txt_NgayHetHan.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_NgayHetHan.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_NgayHetHan.Location = New System.Drawing.Point(890, 486)
        Me.Txt_NgayHetHan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_NgayHetHan.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_NgayHetHan.Multiline = True
        Me.Txt_NgayHetHan.Name = "Txt_NgayHetHan"
        Me.Txt_NgayHetHan.ReadOnly = True
        Me.Txt_NgayHetHan.Size = New System.Drawing.Size(251, 36)
        Me.Txt_NgayHetHan.TabIndex = 9
        '
        'Txt_Email
        '
        Me.Txt_Email.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_Email.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_Email.Location = New System.Drawing.Point(348, 635)
        Me.Txt_Email.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_Email.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_Email.Multiline = True
        Me.Txt_Email.Name = "Txt_Email"
        Me.Txt_Email.Size = New System.Drawing.Size(251, 36)
        Me.Txt_Email.TabIndex = 7
        '
        'Txt_DiaChi
        '
        Me.Txt_DiaChi.BorderColor = System.Drawing.Color.SeaGreen
        Me.Txt_DiaChi.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txt_DiaChi.Location = New System.Drawing.Point(348, 584)
        Me.Txt_DiaChi.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Txt_DiaChi.MaximumSize = New System.Drawing.Size(251, 36)
        Me.Txt_DiaChi.Multiline = True
        Me.Txt_DiaChi.Name = "Txt_DiaChi"
        Me.Txt_DiaChi.Size = New System.Drawing.Size(251, 36)
        Me.Txt_DiaChi.TabIndex = 6
        '
        'Cb_LoaiDocGiaCapNhap
        '
        Me.Cb_LoaiDocGiaCapNhap.DropDownWidth = 269
        Me.Cb_LoaiDocGiaCapNhap.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cb_LoaiDocGiaCapNhap.FormattingEnabled = True
        Me.Cb_LoaiDocGiaCapNhap.IntegralHeight = False
        Me.Cb_LoaiDocGiaCapNhap.ItemHeight = 22
        Me.Cb_LoaiDocGiaCapNhap.Location = New System.Drawing.Point(890, 581)
        Me.Cb_LoaiDocGiaCapNhap.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Cb_LoaiDocGiaCapNhap.Name = "Cb_LoaiDocGiaCapNhap"
        Me.Cb_LoaiDocGiaCapNhap.Size = New System.Drawing.Size(251, 30)
        Me.Cb_LoaiDocGiaCapNhap.TabIndex = 140
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 20
        Me.BunifuElipse1.TargetControl = Me
        '
        'Dgv_ListDocGia
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Dgv_ListDocGia.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Dgv_ListDocGia.BackgroundColor = System.Drawing.Color.White
        Me.Dgv_ListDocGia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Dgv_ListDocGia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Dgv_ListDocGia.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Dgv_ListDocGia.ColumnHeadersHeight = 40
        Me.Dgv_ListDocGia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Ngay, Me.Column3, Me.Column4, Me.d, Me.Column5})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Dgv_ListDocGia.DefaultCellStyle = DataGridViewCellStyle3
        Me.Dgv_ListDocGia.DoubleBuffered = True
        Me.Dgv_ListDocGia.EnableHeadersVisualStyles = False
        Me.Dgv_ListDocGia.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.Dgv_ListDocGia.HeaderForeColor = System.Drawing.Color.White
        Me.Dgv_ListDocGia.Location = New System.Drawing.Point(49, 141)
        Me.Dgv_ListDocGia.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Dgv_ListDocGia.Name = "Dgv_ListDocGia"
        Me.Dgv_ListDocGia.ReadOnly = True
        Me.Dgv_ListDocGia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Dgv_ListDocGia.RowHeadersWidth = 20
        Me.Dgv_ListDocGia.RowTemplate.Height = 28
        Me.Dgv_ListDocGia.Size = New System.Drawing.Size(1349, 267)
        Me.Dgv_ListDocGia.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column1.HeaderText = "Mã Độc Giả"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 157
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column2.HeaderText = "Họ Và Tên"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 144
        '
        'Ngay
        '
        Me.Ngay.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Ngay.HeaderText = "Ngày Sinh"
        Me.Ngay.Name = "Ngay"
        Me.Ngay.ReadOnly = True
        Me.Ngay.Width = 138
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column3.HeaderText = "Địa Chỉ"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 113
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column4.HeaderText = "Email"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 95
        '
        'd
        '
        Me.d.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.d.HeaderText = "Ngày Lập"
        Me.d.Name = "d"
        Me.d.ReadOnly = True
        Me.d.Width = 134
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Column5.HeaderText = "Ngày Hết Hạn"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 177
        '
        'Frm_QLDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1438, 794)
        Me.Controls.Add(Me.Dgv_ListDocGia)
        Me.Controls.Add(Me.Cb_LoaiDocGiaCapNhap)
        Me.Controls.Add(Me.Txt_DiaChi)
        Me.Controls.Add(Me.Txt_Email)
        Me.Controls.Add(Me.Txt_NgayHetHan)
        Me.Controls.Add(Me.Txt_TinhTrangThe)
        Me.Controls.Add(Me.Txt_HoVaTen)
        Me.Controls.Add(Me.Txt_MaDocGia)
        Me.Controls.Add(Me.Cb_LoaiDocGia)
        Me.Controls.Add(Me.Btn_Close)
        Me.Controls.Add(Me.Dtp_NgayLap)
        Me.Controls.Add(Me.Dtp_NgaySinh)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Btn_Xoa)
        Me.Controls.Add(Me.Btn_CapNhap)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gdf)
        Me.Controls.Add(Me.ad)
        Me.Controls.Add(Me.sa)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(10, 10)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Frm_QLDocGia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_QLDocGia"
        CType(Me.Btn_Close, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv_ListDocGia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents gdf As Label
    Friend WithEvents ad As Label
    Friend WithEvents sa As Label
    Friend WithEvents Label As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_CapNhap As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Btn_Xoa As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Dtp_NgayLap As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Dtp_NgaySinh As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Btn_Close As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Cb_LoaiDocGia As ComboBox
    Friend WithEvents Txt_HoVaTen As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_MaDocGia As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_TinhTrangThe As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_NgayHetHan As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_Email As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Txt_DiaChi As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents Cb_LoaiDocGiaCapNhap As ComboBox
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents Dgv_ListDocGia As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Ngay As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents d As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
