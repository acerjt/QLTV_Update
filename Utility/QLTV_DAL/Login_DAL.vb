Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility

Public Class Login_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub

    Public Function getNextID(ByRef Login As Login_DTO) As Result


        Dim query As String = String.Empty
        query &= " SELECT *  "
        query &= " FROM [tblLogin] "
        query &= " WHERE [username] =@username "
        query &= " AND [password] =@password "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", Login.Username)
                    .Parameters.AddWithValue("@password", Login.PassWord)
                End With
                Try
                    conn.Open()
                    Dim adapter As New SqlDataAdapter(comm)
                    Dim table As New DataTable()
                    Dim reader As SqlDataReader
                    adapter.Fill(table)
                    If (table.Rows.Count() <= 0) Then
                        Return New Result(False)
                    Else
                        reader = comm.ExecuteReader()
                        reader.Read()
                        Login.ID = reader("manhanvien")
                        Return New Result(True)
                    End If
                    ' new ID = current ID + 1

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ID kế tiếp của Mã Báo Cáo Thống Kê Mượn Sách Theo Thể Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function checkUsername(ByRef username As String) As Result


        Dim query As String = String.Empty
        query &= " SELECT *  "
        query &= " FROM [tblLogin] "
        query &= " WHERE [username] =@username "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", username)
                End With
                Try
                    conn.Open()
                    Dim adapter As New SqlDataAdapter(comm)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If (table.Rows.Count() <= 0) Then
                        Return New Result(False)
                    Else
                        Return New Result(True)
                    End If
                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ID kế tiếp của Mã Báo Cáo Thống Kê Mượn Sách Theo Thể Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function checkPassword(manhanvien As Integer, ByRef password As String) As Result


        Dim query As String = String.Empty
        query &= " SELECT *  "
        query &= " FROM [tblLogin] "
        query &= " WHERE [manhanvien] =@manhanvien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@manhanvien", manhanvien)
                End With
                Try
                    conn.Open()
                    Dim adapter As New SqlDataAdapter(comm)
                    Dim table As New DataTable()
                    adapter.Fill(table)
                    If (table.Rows.Count() <= 0) Then
                        Return New Result(False)
                    Else
                        Dim reader As SqlDataReader
                        reader = comm.ExecuteReader()
                        reader.Read()
                        If password = reader("password") Then
                            Return New Result(True)
                        Else
                            Return New Result(False)
                        End If
                    End If

                Catch ex As Exception
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy ID kế tiếp của Mã Báo Cáo Thống Kê Mượn Sách Theo Thể Loại không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(Login As Login_DTO) As Result
        Dim query As String = String.Empty
        query &= " UPDATE [tblLogin] SET"
        query &= " [password] = @password "

        'query &= " ,[tinhtrangthe]=@tinhtrangthe"
        'query &= " ,[sosachdamuon]=@sosachdamuon"

        query &= " WHERE "
        query &= " [manhanvien] = @manhanvien "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@password", Login.Password)
                    .Parameters.AddWithValue("@manhanvien", Login.ID)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thay đổi mật khẩu không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong

    End Function
    Public Function Insert(lg As Login_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblLogin] ([username], [password],[manhanvien])"
        query &= "VALUES (@username,@password,@manhanvien)"

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@username", lg.Username)
                    .Parameters.AddWithValue("@password", lg.Password)
                    .Parameters.AddWithValue("@manhanvien", lg.ID)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Đã đăng kí tài khoản không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(dg As DocGia_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblDocGia] SET"
        query &= " [hovaten] = @hovaten "
        query &= " ,[maloaidocgia] = @maloaidocgia "
        query &= " ,[ngaysinh] = @ngaysinh "
        query &= " ,[diachi] = @diachi "
        query &= " ,[email] = @email "
        query &= " ,[ngaylap] = @ngaylap "
        query &= " ,[ngayhethan]=@ngayhethan"
        'query &= " ,[tinhtrangthe]=@tinhtrangthe"
        'query &= " ,[sosachdamuon]=@sosachdamuon"

        query &= " WHERE "
        query &= " [madocgia] = @madocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@hovaten", dg.HoVaTen)
                    .Parameters.AddWithValue("@maloaidocgia", dg.LoaiDocGia)
                    .Parameters.AddWithValue("@ngaysinh", dg.NgaySinh)
                    .Parameters.AddWithValue("@diachi", dg.DiaChi)
                    .Parameters.AddWithValue("@email", dg.Email)
                    .Parameters.AddWithValue("@ngaylap", dg.NgayLap)
                    .Parameters.AddWithValue("@madocgia", dg.MaDocGia)
                    .Parameters.AddWithValue("@ngayhethan", dg.NgayHetHan)
                    '.Parameters.AddWithValue("@tinhtrangthe", dg.TinhTrangThe)
                    '.Parameters.AddWithValue("@sosachdamuon", dg.SoSachDangMuon)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Độc Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
