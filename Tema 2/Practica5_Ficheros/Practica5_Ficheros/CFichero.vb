Imports System.IO

Public Class Practica5


    Public Class CFichero
        Private pFS As FileStream
        Private pBW As BinaryWriter
        Private pBR As BinaryReader
        Public sFicheroActual As String
        Public Const iTamanioReg As Integer = 108

        Public Sub New(ByVal nombreFichero As String)
            sFicheroActual = nombreFichero
            pFS = New FileStream(sFicheroActual, FileMode.OpenOrCreate, FileAccess.ReadWrite)
            pBW = New BinaryWriter(pFS)
            pBR = New BinaryReader(pFS)
        End Sub

        Public Sub CerrarFich()
            pBW?.Close()
            pBR?.Close()
            pFS?.Close()
        End Sub

        Public Function LongitudFich() As Long
            Return pFS.Length
        End Function

        Public Sub ModificarReg(ByVal pos As Integer, ByVal registro As CRegistro)
            If pos * iTamanioReg >= pFS.Length Then
                Throw New IndexOutOfRangeException("La posición está fuera del rango.")
            End If

            pFS.Seek(pos * iTamanioReg, SeekOrigin.Begin)
            Dim referenciaFija As String = registro.ObtenerReferencia().PadRight(100).Substring(0, 100)
            pBW.Write(referenciaFija)
            pBW.Write(registro.ObtenerPrecio())
        End Sub

        Public Sub AniadirReg(ByVal registro As CRegistro)
            pFS.Seek(pFS.Length, SeekOrigin.Begin)
            Dim referenciaFija As String = registro.ObtenerReferencia().PadRight(100).Substring(0, 100)
            pBW.Write(referenciaFija)
            pBW.Write(registro.ObtenerPrecio())
            pBW.Flush()
        End Sub

        Public Function LeerReg(ByVal pos As Integer) As CRegistro
            If pos * iTamanioReg >= pFS.Length Then
                Throw New IndexOutOfRangeException("La posición está fuera del rango.")
            End If

            pFS.Seek(pos * iTamanioReg, SeekOrigin.Begin)
            Dim referencia As String = pBR.ReadString().TrimEnd(Chr(0))
            Dim precio As Double = pBR.ReadDouble()
            Return New CRegistro(referencia, precio)
        End Function

        Public Sub EliminarReg(ByVal referencia As String)
            Dim encontrado As Boolean = False
            For i As Integer = 0 To (LongitudFich() \ iTamanioReg) - 1
                Dim reg As CRegistro = LeerReg(i)
                If reg.ObtenerReferencia().Trim() = referencia Then
                    ModificarReg(i, New CRegistro("ELIMINADO", 0))
                    encontrado = True
                    Exit For
                End If
            Next
            If Not encontrado Then
                Console.WriteLine("Registro no encontrado.")
            End If
        End Sub
    End Class

End Class