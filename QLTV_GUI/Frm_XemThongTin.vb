Public Class Frm_XemThongTin
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub



    Private Sub Txt_UserName_TextChanged(sender As Object, e As EventArgs) Handles Txt_UserName.TextChanged

    End Sub

    Private Sub Txt_PassWord_TextChanged(sender As Object, e As EventArgs) Handles Txt_PassWord.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Txt_HoVaTen_TextChanged(sender As Object, e As EventArgs) Handles Txt_HoVaTen.TextChanged

    End Sub

    Private Sub Txt_MaThuThu_TextChanged(sender As Object, e As EventArgs) Handles Txt_MaThuThu.TextChanged

    End Sub

    Private Sub Txt_DiaChi_TextChanged(sender As Object, e As EventArgs) Handles Txt_DiaChi.TextChanged

    End Sub

    Private Sub Txt_Email_TextChanged(sender As Object, e As EventArgs) Handles Txt_Email.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Dtp_NgayLap_onValueChanged(sender As Object, e As EventArgs) Handles Dtp_NgayLap.onValueChanged

    End Sub

    Private Sub Dtp_NgaySinh_onValueChanged(sender As Object, e As EventArgs) Handles Dtp_NgaySinh.onValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

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
        frm_DoiMatKhau.ShowDialog()
    End Sub
End Class