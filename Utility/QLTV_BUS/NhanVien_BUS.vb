Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class NhanVien_BUS
    Private nvDAL As NhanVien_DAL
    Public Sub New()
        nvDAL = New NhanVien_DAL()
    End Sub
    Public Sub New(connectionString As String)
        nvDAL = New NhanVien_DAL(connectionString)
    End Sub
    Public Function isValidName(nv As NhanVien_DTO) As Boolean

        If (nv.HoVaTen.Length < 1) Then
            Return False
        End If
        Return True
    End Function

    'Public Function isValidAge(dg As DocGia_DTO, qd As QuyDinh_DTO) As Boolean
    '    Dim NamHienTai = DateTime.Now.Year
    '    If ((NamHienTai - dg.NgaySinh.Year) < qd.TuoiToiThieu Or (NamHienTai - dg.NgaySinh.Year) > qd.TuoiToiDa) Then
    '        Return False
    '    End If
    '    Return True
    'End Function




    Public Function insert(nv As NhanVien_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.Insert(nv)
    End Function
    'Public Function update(dg As DocGia_DTO) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return dgDAL.update(dg)
    'End Function
    Public Function delete(MaNhanVien As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return nvDAL.Delete(MaNhanVien)
    End Function

    Public Function loadnhanvien(ByRef MaNhanVien As Integer, ByRef nv As NhanVien_DTO) As Result
        '1. verify data here!!

        Return nvDAL.loadnhanvien(MaNhanVien, nv)
    End Function
    Public Function selectHoVaTen(MaNhanVien As Integer, ByRef nv As NhanVien_DTO) As Result
        Return nvDAL.selectHoVaTen(MaNhanVien, nv)
    End Function
    'Public Function selectAll(ByRef listLoaiDocGia As List(Of DocGia_DTO)) As Result
    '    '1. verify data here!!

    '    '2. insert to DB
    '    Return dgDAL.SelectALL(listLoaiDocGia)
    'End Function
    'Public Function selectALL_ByMaLop(iMaLop As Integer, ByRef listHS As List(Of HocSinhDTO)) As Result
    '        '1. verify data here!!

    '        '2. insert to DB
    '        Return hsDAL.selectALL_ByMaLop(iMaLop, listHS)
    '    End Function




    Public Function buildMaNhanVien(ByRef nextMaDocGia As Integer) As Result
        Return nvDAL.BuildMaNhanVien(nextMaDocGia)
    End Function
End Class
