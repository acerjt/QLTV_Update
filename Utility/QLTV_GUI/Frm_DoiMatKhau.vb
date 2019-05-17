Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility
Public Class Frm_DoiMatKhau
    Private LoginBus As Login_BUS
    Private iNhanVienID As Integer

    Property NhanVienID() As Integer
        Get
            Return iNhanVienID
        End Get
        Set(ByVal Value As Integer)
            iNhanVienID = Value
        End Set
    End Property

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Close()
    End Sub

    Private Sub Btn_Doi_Click(sender As Object, e As EventArgs) Handles Btn_Doi.Click
        Dim Result As Result
        Dim LoginDTO As Login_DTO
        LoginDTO = New Login_DTO()
        Result = LoginBus.checkPassword(NhanVienID(), Txt_PassWord.Text)
        If (Result.FlagResult = False) Then
            Frm_Information.m.Text = "Mật khẩu hiện tại không đúng."
            Frm_Information.ShowDialog()
            System.Console.WriteLine(Result.SystemMessage)
            Return
        End If
        If Txt_NewPassWord.Text <> Txt_Confirm.Text Then
            Frm_Information.m.Text = "Vui lòng xác thực lại mật khẩu."
            Frm_Information.ShowDialog()
            Txt_PassWord.Focus()
            Return
        Else
            LoginDTO.Password = Txt_NewPassWord.Text
            LoginDTO.ID = NhanVienID()
            Result = LoginBus.update(LoginDTO)
            If (Result.FlagResult = False) Then
                Frm_Information.m.Text = "Đổi mật khẩu không thành công."
                Frm_Information.ShowDialog()
                System.Console.WriteLine(Result.SystemMessage)
                Return
            Else
                Frm_Information.m.Text = "Mật khẩu đã được thay đổi."
                Txt_NewPassWord.Text = ""
                Txt_PassWord.Text = ""
                Txt_Confirm.Text = ""
                Frm_Information.ShowDialog()
                System.Console.WriteLine(Result.SystemMessage)
                Return
            End If
        End If

    End Sub

    Private Sub Frm_DoiMatKhau_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBus = New Login_BUS()
    End Sub
End Class