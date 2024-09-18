Public Class Calculator
    Private _num1 As Integer
    Private _num2 As Integer
    Private _result As Integer
    Private _resultDouble As Double

    Public Property num1() As Integer
        Get
            Return _num1
        End Get
        Set(ByVal num1 As Integer)
            _num1 = num1
        End Set
    End Property

    Public Property num2() As Integer
        Get
            Return _num2
        End Get
        Set(ByVal num2 As Integer)
            _num2 = num2
        End Set
    End Property

    Public Property result() As Integer
        Get
            Return _result
        End Get
        Set(ByVal result As Integer)
            _result = result
        End Set
    End Property

    Public Property resultDouble() As Double
        Get
            Return _resultDouble
        End Get
        Set(ByVal resultDouble As Double)
            _resultDouble = resultDouble
        End Set
    End Property

    Public Sub New()
        Me.num1 = 0
        Me.num2 = 0
        Me.result = 0
    End Sub


    Public Overloads Function Sumar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 + num2
    End Function

    Public Overloads Function Sumar(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 + num2
    End Function
    Public Overloads Function Restar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 - num2
    End Function

    Public Overloads Function Restar(ByVal num1 As Double, ByVal num2 As Double) As Double
        Return num1 - num2
    End Function

    Public Function Multiplicar(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 * num2
    End Function
    Public Function Dividir(ByVal num1 As Integer, ByVal num2 As Integer) As Integer
        Return num1 \ num2
    End Function

    Public Overrides Function ToString() As String
        Return " " & num1.ToString() + "\n " & num2.ToString() + "\n " & result.ToString()
    End Function


End Class
