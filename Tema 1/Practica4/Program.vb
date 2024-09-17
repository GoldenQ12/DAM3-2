Imports System
Imports System.Runtime.InteropServices.JavaScript.JSType

Module Program
    Sub Main(args As String())
        'ConceptosBasicos()
        'Condiciones()
        'Bucles()
        Arrays()
    End Sub

    Function Condiciones()
        Punto7()
        Punto8()
        Punto9()
        Punto10IF()
        Punto10Case()
    End Function
    Function ConceptosBasicos()
        Punto1()
        Punto2()
        Punto3()
        Punto4()
        Punto5()
        Punto6()
    End Function

    Function Bucles()
        Punto11()
        Punto12()
        Punto13()
        Punto14()
    End Function

    Function Arrays()
        'Punto15()
        Punto16()
    End Function

    'Comienzo de Conceptos Basicos
    Function Punto1()
        Console.Clear()
        Console.WriteLine("Introduce un numero entero: ")
        Dim num1 As Integer = Int32.Parse(Console.ReadLine()) 'Lee el string de la siguiente linea y lo parsea
        Console.WriteLine("Introduce un numero real (',' para decimal) : ")
        Dim num2 As Double = Double.Parse(Console.ReadLine())
        Console.WriteLine("El resultado es: " + (num1 * num2).ToString())
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto2()
        Console.Clear()
        Console.WriteLine("Introduce el radio del circulo a calcular: ")
        Dim radio As Double = Console.ReadLine()
        Console.WriteLine("El area es " + (Math.Pow(radio, 2)).ToString("F2"))
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto3()
        Console.Clear()
        Console.WriteLine("Introduce el valor de 'A': ")
        Dim a As Integer = Console.ReadLine()
        Console.WriteLine("Introduce el valor de 'B': ")
        Dim b As Integer = Console.ReadLine()
        Console.WriteLine("Introduce el valor de 'C': ")
        Dim c As Integer = Console.ReadLine()
        Dim valor As Double = b ^ 2 - 4 * a * c

        If valor < 0 Then
            Console.WriteLine("No hay raices")
        Else
            Dim x1 As Double = (-b + Math.Sqrt(valor)) / (2 * a)
            Dim x2 As Double = (-b - Math.Sqrt(valor)) / (2 * a)

            If x1 < 0 Then
                Console.WriteLine("x1 no se puede resolver debido a que la raiz es negativa")
            Else
                Console.WriteLine("x1 = " + x1.ToString())
            End If

            If x2 < 0 Then
                Console.WriteLine("x2 no se puede resolver debido a que la raiz es negativa")
            Else
                Console.WriteLine("x2 = " + x2.ToString())
            End If

        End If
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto4()
        Console.Clear()
        Console.WriteLine("Introduce tu nombre: ")
        Dim nombre As String = Console.ReadLine()
        Console.WriteLine("Introduce tu edad")
        Dim edad As Integer = Int32.Parse(Console.ReadLine())
        Console.WriteLine("Te llamas " + nombre + " y tienes " + edad.ToString() + " anios")
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto5()
        Console.Clear()
        Console.WriteLine("Introduce un numero entero: ")
        Dim numero As Integer = Int32.Parse(Console.ReadLine())
        Try
            numero = numero ^ 2
        Catch ex As OverflowException
            Console.WriteLine("Se supero el numero al que puede alcanzar una variable")
        End Try
        Console.WriteLine("El valor de " + numero.ToString() + " al cuadrado es " + Int32.Parse((numero ^ 2)).ToString())
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto6()
        Console.Clear()
        Console.WriteLine("Pendiente por hacer")
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function


    'Comienzo de condiciones
    Function Punto7()
        Console.Clear()
        Console.WriteLine("Introduce un numero: ")
        Dim num As Integer = Int32.Parse(Console.ReadLine())
        If Integer.IsEvenInteger(num) Then
            Console.WriteLine("El numero " + num.ToString() + " es par")
        Else
            Console.WriteLine("El numero " + num.ToString() + " es impar")
        End If
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto8()
        Console.Clear()
        Console.WriteLine("Introduce tu edad: ")
        Dim edad As Integer = Int32.Parse(Console.ReadLine())
        If edad > 18 Then

            Console.WriteLine("Tienes carnet de conducir? (SI || NO )")
            Dim input As String = Console.ReadLine()

            If (input.ToUpper() = "SI") Then
                Console.WriteLine("Tienes carnet de conducir")
            ElseIf (input.ToUpper() = "NO") Then
                Console.WriteLine("No tienes carnet de conducir")
            Else
                Console.WriteLine("No has introducido una opcion valida")
            End If

        Else
            Console.WriteLine("Eres menor de edad")
        End If
    End Function

    Function Punto9()
        Console.Clear()
        Console.WriteLine("Introduce un valor real de doble precision: ")
        Dim num1 As Double = Double.Parse(Console.ReadLine())
        Console.WriteLine("Introduce otro valor: ")
        Dim num2 As Double = Double.Parse((Console.ReadLine()))
        Console.WriteLine("Introduce un ultimo valor: ")
        Dim num3 As Double = Double.Parse(Console.ReadLine())
        Dim min As Double = Math.Min(Math.Min(num1, num2), num3)
        '(Math.Pow(radio, 2)).ToString("F2"))
        Console.WriteLine("El valor mas bajo es " + min.ToString("F2"))
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto10IF()
        Console.Clear()
        Console.WriteLine("Introduce un numero entero: ")
        Dim numero As Double
        Try
            numero = Double.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        If numero < 50 Then
            Console.WriteLine(Math.Pow(numero.ToString("F2"), 2) + " ^ 2 = ")
        ElseIf numero = 25 Or numero = 30 Or numero = 75 Then
            Console.WriteLine(Math.Cbrt(numero.ToString("F2")) + " ^ 2 = ")
        ElseIf numero = 10 Or numero > 100 Or numero < 9 And numero > 2 Or numero < 91 And numero > 76 Then
            Console.WriteLine(numero.ToString() + " / 10 = " + (numero \ 10).ToString())
        Else
            Console.WriteLine("El numero introducido es " + numero.ToString())
        End If
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto10Case()
        Console.Clear()
        Console.WriteLine("Introduce un numero entero: ")
        Dim numero As Double
        Try
            numero = Double.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Select Case numero
            Case numero < 50
                Console.WriteLine(Math.Pow(numero.ToString("F2"), 2) + " ^ 2 = ")
            Case numero = 25 Or numero = 30 Or numero = 75
                Console.WriteLine(Math.Cbrt(numero.ToString("F2")) + " ^ 2 = ")
            Case numero = 10 Or numero > 100 Or numero < 9 And numero > 2 Or numero < 91 And numero > 76
                Console.WriteLine(numero.ToString() + " / 10 = " + (numero \ 10).ToString())
            Case Else
                Console.WriteLine("El numero introducido es " + numero.ToString())
        End Select
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    'Comienzo de Bucles
    Function Punto11()
        Console.Clear()
        Console.WriteLine("Introduce un numero, a ser posible impar: ")
        Dim num As Integer
        num = Int32.Parse(Console.ReadLine())
        Do
            Console.WriteLine("Introduce un numero, a ser posible impar: ")
            num = Int32.Parse(Console.ReadLine())
        Loop Until Integer.IsEvenInteger(num)
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto12()
        Console.Clear()
        Dim n As Integer
        Dim k As Integer
        Dim count As Integer = 0
        Do
            Console.WriteLine("Introduce un numero entero entre 1 y 1000: ")
            n = Int32.Parse(Console.ReadLine())
            Console.WriteLine("Introduce un numero entero entre 1 y 10: ")
            k = Int32.Parse(Console.ReadLine())
        Loop Until n > 1 And n < 1000 Or k > 2 And k < 10

        While n Mod k = 0
            n = n \ k
            count += 1
        End While
        Console.WriteLine("El numero " + n.ToString() + " es divisible por el numero " + k.ToString() + " " + count.ToString() + " veces")
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto13()
        Console.Clear()
        Console.WriteLine("Introduce un numero entero: ")
        Dim numero As Integer = Int32.Parse(Console.ReadLine())
        If numero Mod 1 = 0 And numero Mod numero = 0 Then
            Console.WriteLine("El numero " + numero.ToString() + " es primo")
        Else
            Console.WriteLine("El numero " + numero.ToString() + " no es primo")
        End If
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function
    Function Punto14()
        Console.WriteLine("MasterMind")
    End Function
    Function Punto15()
        Dim array(10) As Integer
        Dim max As Integer
        Dim min As Integer
        For i As Integer = i To 10
            Console.WriteLine("Introduce un numero " + "(" + i.ToString() + ")" + " : ")
            Dim numero As Integer = Int32.Parse(Console.ReadLine())
            array(i) = numero
        Next
        max = array(0)
        min = array(0)
        For i As Integer = i To 10
            If array(i) > max Then
                max = array(i)
            End If
            If array(i) < min Then
                min = array(i)
            End If
        Next

        Console.WriteLine("El numero mayor es " + max.ToString())
        Console.WriteLine("El numero menor es " + min.ToString())
        Console.WriteLine("Pulse una tecla para continuar...")
        Console.ReadKey(True)
    End Function

    Function Punto16()
        Dim array(20) As Integer
        Dim arrayPrimos(20) As Integer
        For i As Integer = 0 To 20
            array(i) = Int((99 * Rnd()) + 1)
            If array(i) Mod 1 = 0 And array(i) Mod array(i) = 0 Then
                arrayPrimos(i) = array(i)
            End If
        Next

        Console.WriteLine("Primos : ")
        Console.WriteLine("")
        For i As Integer = 0 To arrayPrimos.Length - 1
            Console.WriteLine(arrayPrimos(i).ToString())
        Next


    End Function

End Module
