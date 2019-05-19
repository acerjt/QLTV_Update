Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_XemThongTin
    Private iNhanVienID As Integer
    Private nvBus As NhanVien_BUS

    Property NhanVienID() As Integer
        Get
            Return iNhanVienID
        End Get
        Set(ByVal Value As Integer)
            iNhanVienID = Value
        End Set
    End Property



    Private Sub BunifuSeparator1_Load(sender As Object, e As EventArgs) Handles BunifuSeparator1.Load

    End Sub

    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Đong.Click
        Close()
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Close()
    End Sub

    Private Sub MetroLink1_Click(sender As Object, e As EventArgs) Handles MetroLink1.Click
        Hide()
        Dim frm_DoiMatKhau = New Frm_DoiMatKhau()
        frm_DoiMatKhau.NhanVienID = NhanVienID
        frm_DoiMatKhau.ShowDialog()
        Show()
    End Sub

    Private Sub Frm_XemThongTin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Dim NhanVienDTO As NhanVien_DTO
        NhanVienDTO = New NhanVien_DTO()
        nvBus = New NhanVien_BUS()
        Dim Result As Result
        Result = nvBus.loadnhanvien(NhanVienID(), NhanVienDTO)
        If (Result.FlagResult = True) Then
            Txt_MaThuThu.Text = NhanVienDTO.MaNhanVien
            Txt_HoVaTen.Text = NhanVienDTO.HoVaTen
            Txt_Email.Text = NhanVienDTO.Email
            Txt_DiaChi.Text = NhanVienDTO.DiaChi
            Dtp_NgayLap.Value = NhanVienDTO.NgayLap
            Dtp_NgaySinh.Value = NhanVienDTO.NgaySinh
        End If
        If (NhanVienDTO.MaNhanVien = 1) Then
            PictureBox1.Image = My.Resources.NV_1
        ElseIf (NhanVienDTO.MaNhanVien = 2) Then
            PictureBox1.Image = My.Resources.NV_2
        ElseIf (NhanVienDTO.MaNhanVien = 3) Then
            PictureBox1.Image = My.Resources.NV_3
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class