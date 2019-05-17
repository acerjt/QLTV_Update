Public Class Login_DTO
    Private strUsername As String
    Private strPassword As String
    Private intID As Integer

    Public Sub New()

    End Sub
    Public Sub New(strUsername As String, strPassword As String, intID As Integer)
        Me.strUsername = strUsername
        Me.strPassword = strPassword
        Me.intID = intID
    End Sub

    Property Username() As String
        Get
            Return strUsername
        End Get
        Set(ByVal Value As String)
            strUsername = Value
        End Set
    End Property

    Property Password() As String
        Get
            Return strPassword
        End Get
        Set(ByVal value As String)
            strPassword = value
        End Set
    End Property
    Property ID() As Integer
        Get
            Return intID
        End Get
        Set(ByVal value As Integer)
            intID = value
        End Set
    End Property
End Class
