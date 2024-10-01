Imports System.IO
Imports Microsoft.Win32

Public Class CFichero
    Implements IOperaciones


    'Atributtes
    Private _pFS As FileStream
    Private _pBW As BinaryWriter
    Private _pBR As BinaryReader
    Private _sFicheroActual As String
    Private _iNregs As Integer
    Private _iTamanioReg As Integer
    Private _bBorrar As Boolean
    Private _posEliminar As Integer

    Public Sub New(fichero As String)
        sFicheroActual = fichero
        iTamanioReg = 0  ' Tamaño de cada registro (ajustar según el caso)
        pFS = New FileStream(sFicheroActual, FileMode.OpenOrCreate, FileAccess.ReadWrite)
        pBW = New BinaryWriter(pFS)
        pBR = New BinaryReader(pFS)
        iNregs = 0 ' Calcula el número de registros
        bBorrar = False
    End Sub

    'SettersAndGetters
    Public Property pFS() As FileStream
        Get
            Return _pFS
        End Get
        Set(ByVal pFS As FileStream)
            _pFS = pFS
        End Set
    End Property

    Public Property pBW() As BinaryWriter
        Get
            Return _pBW
        End Get
        Set(ByVal pBW As BinaryWriter)
            _pBW = pBW
        End Set
    End Property

    Public Property pBR() As BinaryReader
        Get
            Return _pBR
        End Get
        Set(ByVal pBR As BinaryReader)
            _pBR = pBR
        End Set
    End Property

    Public Property sFicheroActual() As String
        Get
            Return _sFicheroActual
        End Get
        Set(ByVal sFicheroActual As String)
            _sFicheroActual = sFicheroActual
        End Set
    End Property

    Public Property iNregs() As Integer
        Get
            Return _iNregs
        End Get
        Set(ByVal iNregs As Integer)
            _iNregs = iNregs
        End Set
    End Property

    Public Property iTamanioReg() As Integer
        Get
            Return _iTamanioReg
        End Get
        Set(ByVal iTamanioReg As Integer)
            _iTamanioReg = iTamanioReg
        End Set
    End Property

    Public Property bBorrar() As Boolean
        Get
            Return _bBorrar
        End Get
        Set(ByVal bBorrar As Boolean)
            _bBorrar = bBorrar
        End Set
    End Property

    Public Property posEliminar() As Integer
        Get
            Return _posEliminar
        End Get
        Set(ByVal posEliminar As Integer)
            _posEliminar = posEliminar
        End Set
    End Property

    'Methods & Functions
    Public Sub CerrarFichero() Implements IOperaciones.CerrarFichero
        Try
            pFS.Close()
            pBW.Close()
            pBR.Close()
        Catch ex As Exception
            Console.WriteLine("Error inesperado: " & ex.Message)
        End Try

    End Sub

    Public Function LongitudFichero() As Long Implements IOperaciones.LongitudFichero
        Return pFS.Length
    End Function

    Public Sub ModificarRegistro(posicion As Integer, nuevaReferencia As String, nuevoPrecio As Double) Implements IOperaciones.ModificarRegistro
        Try
            If posicion >= 0 And posicion <= iNregs Then
                pFS.Seek(posicion * iTamanioReg, SeekOrigin.Begin)
                pBW.Write(nuevaReferencia)
                pBW.Write(nuevoPrecio)
            End If
        Catch ex As Exception
            Console.WriteLine("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Public Sub AniadirRegistro(ByVal nuevaReferencia As String, ByVal nuevoPrecio As Double) Implements IOperaciones.AniadirRegistro
        Try
            pFS.Seek(0, SeekOrigin.End)
            pBW.Write(nuevaReferencia)
            pBW.Write(nuevoPrecio)
            iNregs += 1
        Catch ex As Exception
            Console.Write("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Public Sub LeerRegistro(ByVal posicion As Integer) Implements IOperaciones.LeerRegistro
        Try
            pFS.Seek(posicion * iTamanioReg, SeekOrigin.Begin)
            Console.WriteLine("Referencia: " & pBR.ReadString())
            Console.WriteLine("Precio: " & pBR.ReadDouble())
        Catch ex As Exception
            Console.Write("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Public Sub BuscarRegistro(ByVal referenciaABuscar As String) Implements IOperaciones.BuscarRegistro
        Try
            pFS.Seek(0, SeekOrigin.End)
            If pBR.ReadString().Equals(referenciaABuscar) Then
                Console.WriteLine("Referencia del registro a buscar: " & pBR.ReadString())
                Console.WriteLine("Precio del registro a buscar: " & pBR.ReadDouble())
            End If
        Catch ex As Exception
            Console.WriteLine("Error inesperado: " & ex.Message)
        End Try
    End Sub

    Public Function EliminarRegistro(ByVal posicion As Integer) As Integer Implements IOperaciones.EliminarRegistro
        Try
            If posicion >= 0 And posicion <= iTamanioReg Then
                bBorrar = True
                posEliminar = posicion
            End If
        Catch ex As Exception
            Console.WriteLine("Error inesperado:  " & ex.Message)
        End Try
    End Function

    Public Function HayRegsEliminados() As Boolean Implements IOperaciones.HayRegsEliminados
        Return bBorrar
    End Function

    Public Sub ActualizarFichero() Implements IOperaciones.ActualizarFichero
        Try
            If bBorrar = True Then
                ModificarRegistro(posEliminar, "", 0)
            End If
        Catch ex As Exception
            Console.WriteLine("Error inesperado: " & ex.Message)
        End Try
    End Sub


End Class
