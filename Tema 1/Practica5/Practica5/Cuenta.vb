Public Class Cuenta
    Private _titular As Titular
    Private _cantidad As Double
    Public Event _CantidadNegativa(ByVal cantidad As Double)
    Public Event _SalarioNegativo(ByVal cantidad As Double)
    Public Property Titular() As Titular
        Get
            Return _titular
        End Get
        Set(ByVal titular As Titular)
            _titular = titular
        End Set
    End Property
    Public Property Cantidad() As Double
        Get
            Return _cantidad
        End Get
        Set(ByVal cantidad As Double)
            _cantidad = cantidad
        End Set
    End Property

    Sub New()
        _titular = New Titular
        _cantidad = 0
    End Sub

    Sub New(ByVal titular As Titular, ByVal cantidad As Double)
        _titular = titular
        _cantidad = cantidad
    End Sub

    Public Overrides Function ToString() As String
        Return Titular.ToString() &
            Environment.NewLine &
            "Cantidad : " & Math.Round(Cantidad, 2).ToString()
    End Function

    Private Sub CantidadNegativa(ByVal cantidad As Double) Handles Me._CantidadNegativa
        Console.WriteLine("No puedes introducir una cantidad negativa")
    End Sub

    Private Sub SalarioNegativo(ByVal cantidad As Double) Handles Me._SalarioNegativo
        Console.WriteLine("La cantidad no puede ser inferior a 0")
        Me.Cantidad = cantidad
    End Sub

    Public Sub Ingresar(ByVal cantidadIngresar As Double)

        If cantidadIngresar < 0 Then
            RaiseEvent _CantidadNegativa(Cantidad)
        Else
            Cantidad += cantidadIngresar
            Console.WriteLine("Salario agregado correctamente")
        End If
    End Sub

    Public Sub Retirar(ByVal cantidadRetirar As Double)
        Cantidad -= cantidadRetirar
        If Cantidad < 0 Then
            RaiseEvent _SalarioNegativo(0)
        Else
            Console.WriteLine("Salario retirado correctamente")
        End If
    End Sub


End Class
