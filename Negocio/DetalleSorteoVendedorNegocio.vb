Imports Datos
Imports Entidades
Public Class DetalleSorteoVendedorNegocio
    Private ReadOnly dato As New DetallesSorteoVendedorDatos
    Public Function GetDetalleSorteoVendorTodos(ejercicio)
        Return dato.GetDetallesSorteoVendorEjercicio(ejercicio)

    End Function
    Public Function GetdetalleSorteoVendor(ejercicio, idsorteo, idvendor)
        Return dato.GetDetallesSorteoVendor(ejercicio, idsorteo, idvendor)
    End Function

    Public Sub InsertarApunte(IdSorteo As Integer, IdVendedor As Integer, ejercicio As Integer, PapeletasEntregadas As Integer,
                              PapeletasDevueltas As Integer, TotalAdeudado As Double, EntregadoParcial As Double, Saldo As Double)

        Dim tabla As DataTable = DetallesSorteoVendedorEntidad.TablaDetallesSorteoVendedor
        Dim fila As DataRow = tabla.NewRow

        fila("IdSorteo") = IdSorteo
        fila("IdVendedor") = IdVendedor
        fila("ejercicio") = ejercicio
        fila("PapeletasEntregadas") = PapeletasEntregadas
        fila("PapeletasDevueltas") = PapeletasDevueltas
        fila("EntregadoParcial") = EntregadoParcial
        fila("Saldo") = Saldo

        tabla.Rows.Add(fila)

        dato.InsertarApunte(fila)


    End Sub

End Class
