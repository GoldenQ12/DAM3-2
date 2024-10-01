Public Interface IOperaciones
    Sub CerrarFichero()
    Function LongitudFichero() As Long
    Sub ModificarRegistro(ByVal posicion As Integer, ByVal nuevaReferencia As String, ByVal nuevoPrecio As Double)
    Sub AniadirRegistro(nuevaReferencia As String, nuevoPrecio As Double)
    Sub LeerRegistro(ByVal posicion As Integer) 'ToString
    Sub BuscarRegistro(ByVal referenciaABuscar As String)
    Function EliminarRegistro(ByVal posicion As Integer) As Integer
    Function HayRegsEliminados() As Boolean
    Sub ActualizarFichero()

End Interface
