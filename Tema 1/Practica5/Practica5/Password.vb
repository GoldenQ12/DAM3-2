
Public Class Password
    Private _longitud As Integer
    Private _contrasena As String

    Public Property Longitud() As Integer
        Get
            Return _longitud
        End Get
        Set(ByVal longitud As Integer)
            _longitud = longitud
        End Set
    End Property

    Public Property Contrasena() As String
        Get
            Return _contrasena
        End Get
        Set(ByVal contrasena As String)
            _contrasena = contrasena
        End Set
    End Property

    Sub New(ByVal longitud As Integer)
        _longitud = longitud
        _contrasena = GenerarContrasena(longitud)
    End Sub

    Sub New()
        _longitud = 8
        _contrasena = ""
    End Sub

    Public Overrides Function ToString() As String
        Return "Contrasena: " & Contrasena.ToString() & " (" & Longitud.ToString & " Caracteres)"
    End Function

    Public Function GenerarContrasena(ByVal longi As Integer) As String
        Dim posiblesCaracteres As String = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNMQWERTYUIOPASDFGHJKLZXCVBNM1234567890"
        Dim rand As New Random()
        Dim pass As String = ""

        For i As Integer = 1 To longi
            Dim index As Integer = rand.Next(0, posiblesCaracteres.Length)
            pass &= posiblesCaracteres(index)
        Next

        Return pass

    End Function

    Public Function EsFuerte(ByVal contrasena As String) As Boolean
        Dim contMayus As Integer
        Dim contMinus As Integer
        Dim contNum As Integer
        Dim passArray = contrasena.ToCharArray()
        For i As Integer = 0 To passArray.Length - 1
            If Char.IsLower(passArray(i)) Then
                contMinus += 1
            ElseIf Char.IsUpper(passArray(i)) Then
                contMayus += 1
            ElseIf Char.IsNumber(passArray(i)) Then
                contNum += 1
            End If
        Next

        If contMayus >= 2 And contMinus >= 1 And contNum >= 5 Then
            Return True
        Else
            Return false
        End If
    End Function

End Class
