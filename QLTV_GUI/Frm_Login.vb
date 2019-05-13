Imports QLTV_BUS
Imports QLTV_DTO
Imports Utility

Public Class Frm_Login
    Private LoginBUS As Login_BUS
    Private Sub Frm_Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoginBUS = New Login_BUS()

    End Sub

    Private Sub Btn_Login_Click(sender As Object, e As EventArgs) Handles Btn_Login.Click
        Dim Login As Login_DTO
        Login = New Login_DTO()

        Login.Username = Txt_UserName.Text
        Login.Password = Txt_PassWord.Text
        If Txt_Username.Text = My.Settings.AdminUser And Txt_Password.Text = My.Settings.AdminPass Then
            Hide()
            Dim frmRegrister = New Frm_Register()
            frmRegrister.ShowDialog()
            If (frmRegrister.DialogResult = DialogResult.Cancel) Then
                Show()
            ElseIf (frmRegrister.DialogResult = DialogResult.No) Then
                Return
            End If
        Else
            Dim result As Result
            result = LoginBUS.getNextID(Login)
            If result.FlagResult = True Then

                Hide()
                Dim frmMain = New Frm_Main()
                frmMain.NhanVienID() = Login.ID
                frmMain.ShowDialog()

                If (frmMain.DialogResult = DialogResult.Cancel) Then
                    Application.Exit()
                ElseIf (frmMain.DialogResult = DialogResult.Ok) Then
                    Show()
                    'ElseIf (frmMain.DialogResult = DialogResult.No) Then
                    '    Return
                End If
            Else

                Dim frm_Infor = New Frm_Information()
                Frm_Information.m.Text = "UserName Or PassWord Are Ivalid."
                Frm_Information.ShowDialog()

                'MessageBox.Show("UserName Or PassWord Are Ivalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                System.Console.WriteLine(result.SystemMessage)
                Return
            End If
        End If
    End Sub

    Private Sub Btn_Close_Click(sender As Object, e As EventArgs) Handles Btn_Close.Click
        Me.Close()
    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim frm_Form1 = New Frm_Register()
        frm_Form1.ShowDialog()

    End Sub
End Class