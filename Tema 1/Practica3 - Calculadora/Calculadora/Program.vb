Imports System

Module Program
    Sub Main(args As String())
        Dim calculator As New Calculator()
        Dim continueCalculating As Boolean = True
        Dim num1 As Integer
        Dim num2 As Integer
        While continueCalculating
            Console.Clear()
            Console.WriteLine("Menú de Calculadora:")
            Console.WriteLine("---------------------")
            Console.WriteLine("1. Sumar")
            Console.WriteLine("2. Restar")
            Console.WriteLine("3. Multiplicar")
            Console.WriteLine("4. Dividir")
            Console.WriteLine("0. Salir")
            Console.Write("Selecciona una opción (0-4): ")

            Dim opc As Integer = Int32.Parse(Console.ReadLine())
            Dim opcSum As Integer
            Dim opcRes As Integer

            Select Case opc
                Case 1
                    Console.Clear()
                    Console.WriteLine("1. Enteros")
                    Console.WriteLine("2. Con Decimales")
                    opcSum = Int32.Parse(Console.ReadLine())
                    Select Case opcSum
                        Case 1
                            Dim numTemp1 As Integer
                            Dim numTemp2 As Integer
                            Try
                                Console.WriteLine("Introduce un numero entero: ")
                                numTemp1 = Int32.Parse(Console.ReadLine())
                                Console.WriteLine("Introduce otro numero entero: ")
                                numTemp2 = Int32.Parse(Console.ReadLine())
                            Catch ex As FormatException
                                Console.WriteLine("Entrada invalida, debes introducir numeros enteros")
                            Catch ex As Exception
                                Console.WriteLine("Error inesperado" & ex.Message)
                            End Try
                            Dim result As Integer = calculator.Sumar(numTemp1, numTemp2)
                            calculator.num1 = numTemp1
                            calculator.num2 = numTemp2
                            calculator.result = result
                            Console.WriteLine(calculator.num1 & " + " & calculator.num2 & " = " & calculator.result)
                            Console.WriteLine("Pulse una tecla para continuar...")
                            Console.ReadKey(True)
                        Case 2
                            Dim numTemp1 As Double
                            Dim numTemp2 As Double
                            Try
                                Console.WriteLine("Introduce un numero doble (decimal): ")
                                numTemp1 = Double.Parse(Console.ReadLine())
                                Console.WriteLine("Introduce un numero doble (decimal): ")
                                numTemp2 = Double.Parse(Console.ReadLine())
                            Catch ex As FormatException
                                Console.WriteLine("Entrada invalida, debes introducir numeros decimales")
                            Catch ex As Exception
                                Console.WriteLine("Error inesperado" & ex.Message)
                            End Try
                            Dim result As Double = calculator.Sumar(numTemp1, numTemp2)
                            calculator.num1 = numTemp1
                            calculator.num2 = numTemp2
                            calculator.resultDouble = result
                            Console.WriteLine(calculator.num1 & " + " & calculator.num2 & " = " & calculator.resultDouble)
                            Console.WriteLine("Pulse una tecla para continuar...")
                            Console.ReadKey(True)
                    End Select
                Case 2
                    Console.Clear()
                    Console.WriteLine("1. Enteros")
                    Console.WriteLine("2. Con Decimales")
                    opcSum = Int32.Parse(Console.ReadLine())
                    Select Case opcRes
                        Case 1
                            Dim numTemp1 As Integer
                            Dim numTemp2 As Integer
                            Try
                                Console.WriteLine("Introduce un numero entero: ")
                                numTemp1 = Int32.Parse(Console.ReadLine())
                                Console.WriteLine("Introduce otro numero entero: ")
                                numTemp2 = Int32.Parse(Console.ReadLine())
                            Catch ex As FormatException
                                Console.WriteLine("Entrada invalida, debes introducir numeros enteros")
                            Catch ex As Exception
                                Console.WriteLine("Error inesperado" & ex.Message)
                            End Try
                            Dim result As Integer = calculator.Restar(numTemp1, numTemp2)
                            calculator.num1 = numTemp1
                            calculator.num2 = numTemp2
                            calculator.result = result
                            Console.WriteLine(calculator.num1 & " - " & calculator.num2 & " = " & calculator.result)
                            Console.WriteLine("Pulse una tecla para continuar...")
                            Console.ReadKey(True)
                        Case 2
                            Dim numTemp1 As Double
                            Dim numTemp2 As Double
                            Try
                                Console.WriteLine("Introduce un numero doble (decimal): ")
                                numTemp1 = Double.Parse(Console.ReadLine())
                                Console.WriteLine("Introduce un numero doble (decimal): ")
                                numTemp2 = Double.Parse(Console.ReadLine())
                            Catch ex As FormatException
                                Console.WriteLine("Entrada invalida, debes introducir numeros decimales")
                            Catch ex As Exception
                                Console.WriteLine("Error inesperado" & ex.Message)
                            End Try
                            Dim result1 As Double = calculator.Restar(numTemp1, numTemp2)
                            calculator.num1 = numTemp1
                            calculator.num2 = numTemp2
                            calculator.resultDouble = result1
                            Console.WriteLine(calculator.num1 & " - " & calculator.num2 & " = " & calculator.resultDouble)
                            Console.WriteLine("Pulse una tecla para continuar...")
                            Console.ReadKey(True)
                    End Select
                Case 3
                    Console.Clear()
                    Dim numTemp1 As Integer
                    Dim numTemp2 As Integer
                    Try
                        Console.WriteLine("Introduce un numero entero: ")
                        numTemp1 = Int32.Parse(Console.ReadLine())
                        Console.WriteLine("Introduce otro numero entero: ")
                        numTemp2 = Int32.Parse(Console.ReadLine())
                    Catch ex As FormatException
                        Console.WriteLine("Entrada invalida, debes introducir numeros enteros")
                    Catch ex As Exception
                        Console.WriteLine("Error inesperado" & ex.Message)
                    End Try
                    Dim result As Integer = calculator.Multiplicar(numTemp1, numTemp2)
                    calculator.num1 = numTemp1
                    calculator.num2 = numTemp2
                    calculator.result = result
                    Console.WriteLine(calculator.num1 & " * " & calculator.num2 & " = " & calculator.result)
                    Console.WriteLine("Pulse una tecla para continuar...")
                    Console.ReadKey(True)
                Case 4
                    Console.Clear()
                    Dim numTemp1 As Integer
                    Dim numTemp2 As Integer
                    Try
                        Console.WriteLine("Introduce un numero entero: ")
                        numTemp1 = Int32.Parse(Console.ReadLine())
                        Console.WriteLine("Introduce otro numero entero: ")
                        numTemp2 = Int32.Parse(Console.ReadLine())
                    Catch ex As FormatException
                        Console.WriteLine("Entrada invalida, debes introducir numeros enteros")
                    Catch ex As Exception
                        Console.WriteLine("Error inesperado" & ex.Message)
                    End Try
                    Dim result As Integer = calculator.Dividir(numTemp1, numTemp2)
                    calculator.num1 = numTemp1
                    calculator.num2 = numTemp2
                    calculator.result = result
                    Console.WriteLine(calculator.num1 & " / " & calculator.num2 & " = " & calculator.result)
                    Console.WriteLine("Pulse una tecla para continuar...")
                    Console.ReadKey(True)
                Case 0
                    Console.Clear()
                    continueCalculating = False
                    Console.WriteLine("Pulse una tecla para continuar...")
                    Console.ReadKey(True)
                Case Else
                    Console.WriteLine("Opcion Invalida")
                    Console.WriteLine("Pulse una tecla para continuar...")
                    Console.ReadKey(True)
            End Select

        End While
    End Sub


End Module
