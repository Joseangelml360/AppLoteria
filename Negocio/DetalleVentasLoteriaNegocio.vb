Imports Datos
Imports Entidades

Public Class DetalleVentasLoteriaNegocio
    Private ReadOnly datosdetalleventasloteria As New DetalleVentasLoteriaDatos

    Public Function GetDetallesVentaLoteria()
        Return datosdetalleventasloteria.ObtenerDetalleVentasLoteria()
    End Function

    Public Function GetDetallesVentaLoteriaSorteo(ejercicio, idsorteo)
        'Return datosdetalleventasloteria.ObtenerDetalleVentasLoteriaSorteo(ejercicio, idsorteo)
        Return datosdetalleventasloteria.ObtenerTotalesVentasLoteriaSorteo(ejercicio, idsorteo)
    End Function

    Public Function GetDetallesVentaLoteriaVendor(ejercicio, codigo, idsorteo)
        Return datosdetalleventasloteria.ObtenerDetalleVentasLoteriaVendedor(ejercicio, codigo, idsorteo)
    End Function

    Public Function ObtenerResumenSorteoVendor(idsorteo, codigovendor, ejercicio)
        Return datosdetalleventasloteria.GetResumenSorteoVendor(idsorteo, codigovendor, ejercicio)
    End Function

    Public Function ObtenerResumenSorteo(idsorteo, ejercicio)
        Return datosdetalleventasloteria.GetResumenSorteo(idsorteo, ejercicio)
    End Function

    Public Function ObtenerImportePremios(idsorteo, ejercicio)
        Return datosdetalleventasloteria.PremiosAbonados(idsorteo, ejercicio)
    End Function

    Public Sub GuardarDetalleVentasLoteria(Id, Ejercicio, CodigoVendedor, FechaApunte, IdSorteo, TipoSorteo, ImportePpta,
                                                 PptasEntregadas, PptasDevueltas, liquidado, PapeletasPremiadas, ImportePremiadas)

        Dim stabla As DataTable = DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria
        Dim fila As DataRow = stabla.NewRow

        fila("Id") = Id
        fila("Ejercicio") = Ejercicio
        fila("CodigoVendedor") = CodigoVendedor
        fila("FechaApunte") = FechaApunte
        fila("IdSorteo") = IdSorteo
        fila("TipoSorteo") = TipoSorteo
        fila("ImportePapeleta") = ImportePpta
        fila("PapeletasEntregadas") = PptasEntregadas
        fila("PapeletasDevueltas") = PptasDevueltas
        fila("Liquidado") = liquidado
        fila("PapeletasPremiadas") = PapeletasPremiadas
        fila("ImportePremiadas") = ImportePremiadas

        stabla.Rows.Add(fila)
        datosdetalleventasloteria.InsertarDetalleVentasLoteria(fila)

    End Sub

End Class
