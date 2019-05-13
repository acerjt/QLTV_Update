Public Class NhanVien_DTO
    Private iMaThuThu As Integer
    Private strHoVaTen As String
    Private dateNgaySinh As DateTime
    Private strDiaChi As String
    Private strEmail As String
    Private dateNgayLap As DateTime
    Public Sub New()

    End Sub

    Public Sub New(iMaThuThu As Integer, strHoVaTen As String, dateNgaySinh As DateTime, strDiaChi As String, strEmail As String, dateNgayLap As DateTime)
        Me.iMaThuThu = iMaThuThu
        Me.strHoVaTen = strHoVaTen
        Me.dateNgaySinh = dateNgaySinh
        Me.strDiaChi = strDiaChi
        Me.strEmail = strEmail
        Me.dateNgayLap = dateNgayLap
    End Sub

    Property MaNhanVien() As Integer
        Get
            Return iMaThuThu
        End Get
        Set(ByVal Value As Integer)
            iMaThuThu = Value
        End Set
    End Property

    Property HoVaTen() As String
        Get
            Return strHoVaTen
        End Get
        Set(ByVal Value As String)
            strHoVaTen = Value
        End Set
    End Property


    Property NgaySinh() As DateTime
        Get
            Return dateNgaySinh
        End Get
        Set(ByVal Value As DateTime)
            dateNgaySinh = Value
        End Set
    End Property

    Property DiaChi() As String
        Get
            Return strDiaChi
        End Get
        Set(ByVal Value As String)
            strDiaChi = Value
        End Set
    End Property

    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal Value As String)
            strEmail = Value
        End Set
    End Property

    Property NgayLap() As DateTime
        Get
            Return dateNgayLap
        End Get
        Set(ByVal Value As DateTime)
            dateNgayLap = Value
        End Set
    End Property
End Class
