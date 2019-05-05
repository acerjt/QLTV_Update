Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_Register
    Private LoginBUS As Login_BUS
    Private Sub Frm_Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBUS = New Login_BUS()

    End Sub

    Private Sub Btn_Register_Click(sender As Object, e As EventArgs) Handles Btn_Register.Click
        Dim Login As Login_DTO
        Login = New Login_DTO()
        If (Txt_ConfirmPassWord.Text <> Txt_PassWord.Text) Then
            Frm_Information.m.Text = "Vui lòng xác thực lại mật khẩu."
            Frm_Information.ShowDialog()
            Txt_PassWord.Focus()
            Return
        End If
        Login.Username = Txt_UserName.Text
        Login.Password = Txt_PassWord.Text
        If Txt_Username.Text = My.Settings.AdminUser And Txt_Password.Text = My.Settings.AdminPass Then
            Hide()
            'Dim frm_Main = New Frm_Main()
            'frm_Main.ShowDialog()
            Dim frmRegrister = New Frm_Register()
            frmRegrister.ShowDialog()
        Else
            Dim result As Result
            result = LoginBUS.insert(Login)
            If result.FlagResult = True Then

                Frm_Information.m.Text = "Đã đăng kí tài khoản thành công."
                Frm_Information.ShowDialog()
            Else

                Dim frm_Infor = New Frm_Information()
                Frm_Information.m.Text = "Đăng kí tài khoản không thành công."
                Frm_Information.ShowDialog()
                Return
            End If
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
            Return
        End If


    End Sub
End Class