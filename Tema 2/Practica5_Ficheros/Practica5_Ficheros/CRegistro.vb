Public Class CRegistro
    Public Property Referencia As String
    Public Property Precio As Double

    Public Sub New()
        Referencia = ""
        Precio = 0.0
    End Sub

    Public Sub New(ByVal ref As String, ByVal prec As Double)
        Referencia = ref
        Precio = prec
    End Sub

    Public Function ObtenerReferencia() As String
        Return Referencia
    End Function

    Public Function ObtenerPrecio() As Double
        Return Precio
    End Function

    Public Sub AsignarReferencia(ByVal nuevaReferencia As String)
        Referencia = nuevaReferencia
    End Sub

    Public Sub AsignarPrecio(ByVal nuevoPrecio As Double)
        Precio = nuevoPrecio
    End Sub
End Class