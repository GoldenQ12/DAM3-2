Imports System
Imports System.ComponentModel.Design
Imports System.Runtime.CompilerServices

Module Program
    Sub Main(args As String())

        Dim opc As Integer
        Dim num1 As Integer
        Dim num2 As Integer

        Do
            MostrarMenu()
            opc = Convert.ToInt32(Console.ReadLine())

            Select Case opc
                Case 1
                    Console.Clear()
                    Console.WriteLine("Introduce un numero: ")
                    num1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Introduce otro numero: ")
                    num2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine(SumarEnteros(num1, num2).ToString())
                    Console.WriteLine(SumarDobles(num1, num2).ToString())
                Case 2
                    Console.Clear()
                    Console.WriteLine("Introduce un numero: ")
                    num1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Introduce otro numero: ")
                    num2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine(RestarEnteros(num1, num2).ToString())
                    Console.WriteLine(RestarDobles(num1, num2).ToString())
                Case 3
                    Console.Clear()
                    Console.WriteLine("Introduce un numero: ")
                    num1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Introduce otro numero: ")
                    num2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine(Multiplicar(num1, num2).ToString())
                Case 4
                    Console.Clear()
                    Console.WriteLine("Introduce un numero: ")
                    num1 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine("Introduce otro numero: ")
                    num2 = Convert.ToDouble(Console.ReadLine())
                    Console.WriteLine(Dividir(num1, num2).ToString())
            End Select
        Loop While opc <> 0

        Console.WriteLine("Adios :)")


    End Sub

    Sub MostrarMenu()
        Console.WriteLine("1- Sumar ")
        Console.WriteLine("2- Restar ")
        Console.WriteLine("3- Multiplicar ")
        Console.WriteLine("4- Dividir ")
        Console.WriteLine("0- Salir ")
        Console.WriteLine("Seleccione una opcion: ")
    End Sub

    Function SumarEnteros(num1 As Integer, num2 As Integer) As Integer
        If (CheckType(num1, num2) = 1) Then
            Dim resultado As Integer = num1 + num2
            Return resultado
        Else
            Return -1
        End If
    End Function

    Function SumarDobles(num1 As Double, num2 As Double) As Double
        Dim resultado As Double = num1 + num2
        If (CheckType(num1, num2) = 0) Then
            resultado = num1 + num2
            Return resultado
        Else
            Return -1
        End If
    End Function

    Function RestarEnteros(num1 As Integer, num2 As Integer) As Integer
        If (CheckType(num1, num2) = 1) Then
            Dim resultado As Integer = num1 - num2
            Return resultado
        Else
            Return -1
        End If
    End Function

    Function RestarDobles(num1 As Double, num2 As Double) As Double
        Dim resultado As Double = num1 - num2
        If (CheckType(num1, num2) = 0) Then
            resultado = num1 + num2
            Return resultado
        Else
            Return -1
        End If
    End Function

    Function Multiplicar(num1 As Integer, num2 As Integer) As Integer
        Dim resultado As Integer = num1 * num2
        Return resultado
    End Function

    Function Dividir(num1 As Integer, num2 As Integer) As Integer
        Dim resultado As Integer = num1 \ num2
        Return resultado
    End Function



    Function CheckType(num1, num2) As Integer
        If (TypeOf num1 Is Integer And TypeOf num2 Is Integer) Then
            Return 1
        ElseIf (TypeOf num1 Is Double And TypeOf num2 Is Double) Then
            Return 0
        Else
            Return -1
        End If
    End Function


End Module
