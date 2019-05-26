Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_XemThongTin
    Private iNhanVienID As Integer
    Private nvBus As NhanVien_BUS
    Private NhanVienDTO As NhanVien_DTO
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
        Dim ImageFilePath As String
        ' ImageFilePath = "//Resources//NV_" + NhanVienDTO.MaNhanVien.ToString + ".jpg"
        ImageFilePath = "C:\Users\DungNgoc\Desktop\QLTV(1)\QLTV_Update\QLTV_GUI\Resources\NV_" + NhanVienDTO.MaNhanVien.ToString + ".jpg"

        PictureBox1.Image = Image.FromFile(ImageFilePath)
        'If (NhanVienDTO.MaNhanVien = 1) Then
        '    PictureBox1.Image = My.Resources.NV_1
        'ElseIf (NhanVienDTO.MaNhanVien = 2) Then
        '    PictureBox1.Image = My.Resources.NV_2
        'ElseIf (NhanVienDTO.MaNhanVien = 3) Then
        '    PictureBox1.Image = My.Resources.NV_3
        'End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        ' Test result.
        If result = Windows.Forms.DialogResult.OK Then

            ' Get the file name.
            Dim path As String = OpenFileDialog1.FileName
            Try
                ' Read in text.
                PictureBox1.Image.Dispose()
                PictureBox1.Image = Image.FromFile(path)
                Dim bmp1 As Bitmap
                bmp1 = New Bitmap(PictureBox1.Image)
                If (System.IO.File.Exists("C:\Users\DungNgoc\Desktop\QLTV(1)\QLTV_GUI\Resources\NV_" + NhanVienDTO.MaNhanVien.ToString + ".jpg")) Then
                    System.IO.File.Delete("C:\Users\DungNgoc\Desktop\QLTV(1)\QLTV_Update\QLTV_GUI\Resources\NV_" + NhanVienDTO.MaNhanVien.ToString + ".jpg")
                End If
                bmp1.Save("C:\Users\DungNgoc\Desktop\QLTV(1)\QLTV_Update\QLTV_GUI\Resources\NV_" + NhanVienDTO.MaNhanVien.ToString + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
                bmp1.Dispose()
            Catch ex As Exception

                ' Report an error.
                Me.Text = "Error"

            End Try
        End If
    End Sub
End Class