Imports System
Imports System.Runtime.CompilerServices

Module Program
    Sub Main(args As String())
        'Prueba Cuenta
        Dim nombre As String
        Dim dni As String
        Dim fechaNac As String
        Dim edad As Integer
        Try
            Console.WriteLine("Introduce tu Nombre: ")
            nombre = Console.ReadLine()
            Console.WriteLine("Introduce tu DNI: ")
            dni = Console.ReadLine()
            Console.WriteLine("Introduce tu fecha de nacimiento (formato 00-00-0000: ")
            fechaNac = Console.ReadLine()
            Console.WriteLine("Introduce tu edad: ")
            edad = Integer.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("No has introducido un valor valido" & ex.Message)

        End Try


        Dim titular1 As Titular = New Titular(nombre, dni, fechaNac, edad)
        Dim cuenta1 As Cuenta = New Cuenta(titular1, 100)
        cuenta1.Ingresar(23.34)
        Console.WriteLine(cuenta1.ToString())
        cuenta1.Retirar(53.23)
        Console.WriteLine(cuenta1.ToString())

        Console.WriteLine("")

        'Prueba Password
        Dim longi As Integer
        Try
            Console.WriteLine("Introduce la longitud de la contrasena: ")
            longi = Integer.Parse(Console.ReadLine())
        Catch ex As Exception
            Console.WriteLine("Valor incorrecto3")
        End Try
        Dim p1 As Password = New Password(longi)
        Dim fuerte As Boolean = p1.EsFuerte(p1.Contrasena)
        Console.WriteLine(p1.ToString())
        If (fuerte) Then
            Console.WriteLine("La contrasena es fuerte")
        Else
            Console.WriteLine("La contrasena no es fuerte")
        End If
    End Sub
End Module
