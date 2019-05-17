﻿Imports System.Configuration
Imports System.Data.SqlClient
Imports QLTV_DTO
Imports Utility
Public Class TacGia_DAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function buildMaTacGIa(ByRef nextMaTacGia As String) As Result 'ex: 18222229

        nextMaTacGia = String.Empty
        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [MaTacGia] "
        query &= "FROM [tblTacGia] "
        query &= "ORDER BY [MaTacGia] DESC "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    Dim MaTacGiaOnDB As String
                    MaTacGiaOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            MaTacGiaOnDB = reader("MaTacGia")
                        End While
                    End If
                    If (MaTacGiaOnDB <> Nothing And MaTacGiaOnDB.Length >= 1) Then

                        'Dim v = msOnDB
                        'Dim convertDecimal = Convert.ToDecimal(v)
                        'convertDecimal = convertDecimal + 1
                        '' Dim tmp = convertDecimal.ToString()
                        '' tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextMaTacGia = MaTacGiaOnDB + 1
                        System.Console.WriteLine(nextMaTacGia)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động mã tác giả kế tiếp kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function insert(TacGia As TacGia_DTO) As Result

        Dim query As String = String.Empty
        query &= "INSERT INTO [tblTacGia] ([MaTacGia], [TenTacGia])"
        query &= "VALUES (@MaTacGia,@TenTacGia)"

        'get MSHS
        Dim nextMaTacGIa = "1"
        buildMaTacGIa(nextMaTacGIa)
        TacGia.MaTacGia = nextMaTacGIa

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@MaTacGia", TacGia.MaTacGia)
                    .Parameters.AddWithValue("@TenTacGia", TacGia.TenTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm Tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function selectALL(ByRef listTacGia As List(Of TacGia_DTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [MaTacGia], [TenTacGia]"
        query &= " FROM [tblTacGia]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listTacGia.Clear()
                        While reader.Read()
                            listTacGia.Add(New TacGia_DTO(reader("MaTacGia"), reader("TenTacGia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả tác giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(tg As TacGia_DTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblTacGia] SET"
        query &= " [tentacgia] = @tentacgia "
        query &= " WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@tentacgia", tg.TenTacGia)
                    .Parameters.AddWithValue("@matacgia", tg.MaTacGia)

                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Cập nhật Tác Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function delete(MaTacGia As String) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblTacGia] "
        query &= " WHERE "
        query &= " [matacgia] = @matacgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@matacgia", MaTacGia)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Xóa Tác Giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True)  ' thanh cong
    End Function
End Class


