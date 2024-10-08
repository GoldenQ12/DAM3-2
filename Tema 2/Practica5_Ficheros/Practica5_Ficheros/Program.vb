Imports System
Imports System.IO
Imports Practica5_Ficheros.Practica5

Module Program
    Sub Main(args As String())
        Dim opcion As Integer
        Dim ficheroAbierto As Boolean = False
        Dim articulos As CFichero = Nothing

        Do
            Console.WriteLine("1. Nuevo fichero")
            Console.WriteLine("2. Abrir fichero")
            Console.WriteLine("3. Añadir registro")
            Console.WriteLine("4. Modificar registro")
            Console.WriteLine("5. Eliminar registro")
            Console.WriteLine("6. Visualizar registros")
            Console.WriteLine("7. Salir")
            Console.Write("Opción elegida: ")
            opcion = Convert.ToInt32(Console.ReadLine())

            Select Case opcion
                Case 1
                    ' Nuevo fichero
                    If Not ficheroAbierto Then
                        Console.Write("Introduce el nombre del nuevo fichero: ")
                        Dim nombreFichero As String = Console.ReadLine()
                        While File.Exists(nombreFichero)
                            Console.WriteLine("El fichero ya existe. Introduce un nombre diferente.")
                            nombreFichero = Console.ReadLine()
                        End While
                        articulos = New CFichero(nombreFichero)
                        ficheroAbierto = True
                    Else
                        Console.WriteLine("Ya hay un fichero abierto. Ciérralo antes de crear uno nuevo.")
                    End If

                Case 2
                    ' Abrir fichero
                    If Not ficheroAbierto Then
                        Console.Write("Introduce el nombre del fichero a abrir: ")
                        Dim nombreFichero As String = Console.ReadLine()
                        While Not File.Exists(nombreFichero)
                            Console.WriteLine("El fichero no existe. Introduce un nombre válido.")
                            nombreFichero = Console.ReadLine()
                        End While
                        articulos = New CFichero(nombreFichero)
                        ficheroAbierto = True
                    Else
                        Console.WriteLine("Ya hay un fichero abierto.")
                    End If

                Case 3
                    ' Añadir registro
                    If ficheroAbierto Then
                        Console.Write("Introduce la referencia: ")
                        Dim referencia As String = Console.ReadLine()
                        Console.Write("Introduce el precio: ")
                        Dim precio As Double = Convert.ToDouble(Console.ReadLine())
                        articulos.AniadirReg(New CRegistro(referencia, precio))
                    Else
                        Console.WriteLine("No hay ningún fichero abierto.")
                    End If

                Case 4
                    ' Modificar registro
                    If ficheroAbierto Then
                        Console.Write("Introduce la posición del registro a modificar: ")
                        Dim pos As Integer = Convert.ToInt32(Console.ReadLine())
                        If pos < 0 OrElse pos >= articulos.LongitudFich() / CFichero.iTamanioReg Then
                            Console.WriteLine("Posición no válida.")
                        Else
                            Console.Write("Introduce la nueva referencia: ")
                            Dim nuevaReferencia As String = Console.ReadLine()
                            Console.Write("Introduce el nuevo precio: ")
                            Dim nuevoPrecio As Double = Convert.ToDouble(Console.ReadLine())
                            articulos.ModificarReg(pos, New CRegistro(nuevaReferencia, nuevoPrecio))
                        End If
                    Else
                        Console.WriteLine("No hay ningún fichero abierto.")
                    End If

                Case 5
                    ' Eliminar registro
                    If ficheroAbierto Then
                        Console.Write("Introduce la referencia del registro a eliminar: ")
                        Dim referencia As String = Console.ReadLine()
                        articulos.EliminarReg(referencia)
                    Else
                        Console.WriteLine("No hay ningún fichero abierto.")
                    End If

                Case 6
                    ' Visualizar registros
                    If ficheroAbierto Then
                        Try
                            Dim numRegistros As Long = articulos.LongitudFich() \ CFichero.iTamanioReg
                            If numRegistros = 0 Then
                                Console.WriteLine("No hay registros para mostrar.")
                            Else
                                For i As Integer = 0 To numRegistros - 1
                                    Dim registro As CRegistro = articulos.LeerReg(i)
                                    Console.WriteLine("Registro " & (i + 1).ToString())
                                    Console.WriteLine("Referencia: " & registro.ObtenerReferencia())
                                    Console.WriteLine("Precio: " & registro.ObtenerPrecio())
                                    Console.WriteLine("-------------------------------")
                                Next
                            End If
                        Catch ex As Exception
                            Console.WriteLine("Error al leer los registros: " & ex.Message)
                        End Try
                    Else
                        Console.WriteLine("No hay ningún fichero abierto.")
                    End If

                Case 7
                    ' Salir
                    If ficheroAbierto Then
                        articulos.CerrarFich()
                    End If
                    Exit Do

                Case Else
                    Console.WriteLine("Opción no válida.")
            End Select

        Loop
    End Sub
End Module
