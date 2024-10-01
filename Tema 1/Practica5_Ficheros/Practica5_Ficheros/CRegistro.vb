Imports System.Transactions

Public Class CRegistro
    Inherits CFichero

    Private _referencia As String
    Private _precio As Double

    Public Property Referencia() As String
        Get
            Return _referencia
        End Get
        Set(ByVal referencia As String)
            _referencia = referencia
        End Set
    End Property

    Public Property Precio() As Double
        Get
            Return _precio
        End Get
        Set(ByVal precio As Double)
            _precio = precio
        End Set
    End Property

    Sub New()
        MyBase.New("")
        _referencia = ""
        _precio = 0.00
    End Sub

    Sub New(ByVal referencia As String, ByVal precio As Double)
        MyBase.New("")
        _referencia = referencia
        _precio = precio
    End Sub

    Public Overrides Function ToString() As String
        Return "Referencia:  " & Referencia & Environment.NewLine() &
            "Precio: " & Precio
    End Function

End Class
