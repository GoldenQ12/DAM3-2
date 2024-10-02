Public Class Titular
    Private _dni As String
    Private _nombre As String
    Private _fechaNac As String
    Private _edad As Integer

    Public Property Dni() As String
        Get
            Return _dni
        End Get
        Set(ByVal dni As String)
            _dni = dni
        End Set
    End Property
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal nombre As String)
            _nombre = nombre
        End Set
    End Property
    Public Property FechaNac() As String
        Get
            Return _fechaNac
        End Get
        Set(ByVal fechaNac As String)
            _fechaNac = fechaNac
        End Set
    End Property
    Public Property Edad() As String
        Get
            Return _edad
        End Get
        Set(ByVal edad As String)
            _edad = edad
        End Set
    End Property

    Sub New()
        _nombre = ""
        _dni = "00000000A"
        _fechaNac = "00/00/0000"
        _edad = 0
    End Sub

    Sub New(ByVal nombre As String, ByVal dni As String, ByVal fechaNac As String, ByVal edad As Integer)
        _nombre = nombre
        _dni = dni
        If String.IsNullOrEmpty(fechaNac) Then
            _fechaNac = "00/00/0000"
        Else
            _fechaNac = fechaNac
        End If
        _edad = edad
    End Sub

    Public Overrides Function ToString() As String
        Return Environment.NewLine & "Nombre: " & Nombre &
       Environment.NewLine & "DNI: " & Dni &
       Environment.NewLine & "Fecha de Nacimiento: " & FechaNac &
       Environment.NewLine & "Edad: " & Edad.ToString()
    End Function
End Class
