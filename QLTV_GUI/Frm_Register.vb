Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_Register
    Private LoginBUS As Login_BUS
    Private NhanvienBUS As NhanVien_BUS
    Private Sub Frm_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBUS = New Login_BUS()
        NhanvienBUS = New NhanVien_BUS()
        Dim nextNhanVien = "1"
        Dim Result As Result
        Result = NhanvienBUS.buildMaNhanVien(nextNhanVien)
        If (Result.FlagResult = False) Then
            Frm_Information.m.Text = "Lấy tự động Mã Độc Giả không thành công."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(Result.SystemMessage)
            Me.Close()
            Return
        End If
        Txt_MaThuThu.Text = nextNhanVien
    End Sub

    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Register.Click

        Dim Login As Login_DTO
        Login = New Login_DTO()
        Dim Nhanvien As NhanVien_DTO
        Nhanvien = New NhanVien_DTO()
        If (Txt_ConfirmPassWord.Text <> Txt_PassWord.Text) Then
            Frm_Information.m.Text = "Vui lòng xác thực lại mật khẩu."
            Frm_Information.ShowDialog()
            Txt_PassWord.Focus()
            Return
        End If
        Login.Username = Txt_UserName.Text
        Login.Password = Txt_PassWord.Text
        Login.ID = Txt_MaThuThu.Text
        Nhanvien.MaNhanVien = Txt_MaThuThu.Text
        Nhanvien.HoVaTen = Txt_HoVaTen.Text
        Nhanvien.NgaySinh = Dtp_NgaySinh.Value
        Nhanvien.DiaChi = Txt_DiaChi.Text
        Nhanvien.Email = Txt_Email.Text
        Nhanvien.NgayLap = Dtp_NgayLap.Value
        Dim Result As Result
        Result = NhanvienBUS.insert(Nhanvien)
        If Result.FlagResult = False Then
            Dim frm_Infor = New Frm_Information()
            Frm_Information.m.Text = "Đăng kí tài khoản không thành công."
            Frm_Information.ShowDialog()
            Return
        End If
        Result = LoginBUS.insert(Login)
        If result.FlagResult = True Then

            Frm_Information.m.Text = "Đã đăng kí tài khoản thành công."
            Dim Manhanvien As Integer
            Result = NhanvienBUS.buildMaNhanVien(Manhanvien)
            Txt_MaThuThu.Text = Manhanvien
            Txt_UserName.Text = ""
            Txt_PassWord.Text = ""
            Txt_HoVaTen.Text = ""
            Txt_DiaChi.Text = ""
            Txt_Email.Text = ""
            Txt_ConfirmPassWord.Text = ""
            Frm_Information.ShowDialog()
        Else
            Result = NhanvienBUS.delete(Nhanvien.MaNhanVien)
            Dim frm_Infor = New Frm_Information()
            Frm_Information.m.Text = "Đăng kí tài khoản không thành công."

            Frm_Information.ShowDialog()
            Return
        End If
    End Sub

    Private Sub Frm_Register_TextChanged(sender As Object, e As EventArgs) Handles Txt_UserName.TextChanged
        Dim UserName As String
        Dim result As Result
        If Txt_UserName.Text <> "" Then
            UserName = Txt_UserName.Text
        End If
        result = LoginBUS.checkUsername(UserName)
        If result.FlagResult = True Then

            Frm_Information.m.Text = "UserName đã có người đăng kí."
            Frm_Information.ShowDialog()
            Txt_UserName.Text = ""
            Return
        End If


    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Dim frm_Close = New Frm_Close()
        frm_Close.ShowDialog()
        If (frm_Close.DialogResult = DialogResult.OK) Then
            DialogResult = DialogResult.Cancel
            Me.Close()
        End If

    End Sub
End Class