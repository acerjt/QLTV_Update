Imports QLTV_DAL
Imports QLTV_DTO
Imports Utility

Public Class Login_BUS
    Private loginDAL As Login_DAL
    Public Sub New()
        loginDAL = New Login_DAL
    End Sub
    Public Sub New(connectionString As String)
        loginDAL = New Login_DAL(connectionString)
    End Sub
    Public Function getNextID(ByRef Login As Login_DTO) As Result
        Return loginDAL.getNextID(Login)
    End Function
    Public Function checkUsername(ByRef username As String) As Result
        Return loginDAL.checkUsername(username)
    End Function
    Public Function insert(dg As Login_DTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return loginDAL.Insert(dg)
    End Function

End Class
