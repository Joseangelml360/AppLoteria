Imports Datos
Imports Entidades

Public Class DetallesAdmonNegocio
    Private ReadOnly datosdetallesadmon As New DetallesAdmonDatos
    Public Function GetDetallesAdmon()
        Return datosdetallesadmon.ObtenerDetallesAdmon()
    End Function

    Public Sub GuardarDetallesAdmon(idAdmon As Integer, ejercicio As Integer,
                                    idSorteo As Integer, numJugado As Integer, numjugado2 As Integer, fecha As Date,
                                    pagoAbono As String, modo As String, importe As Double,
                                    pagoPremios As Double, importedecimos As Double)

        Dim stabla As DataTable = DetallesAdmonEntidad.TablaDetallesAdmon
        Dim fila As DataRow = stabla.NewRow

        'fila("Id") = id
        fila("IdAdmon") = idAdmon
        fila("Ejercicio") = ejercicio
        fila("IdSorteo") = idSorteo
        fila("NumJugado") = numJugado
        fila("NumJugado2") = numjugado2
        fila("Fecha") = fecha
        fila("PagoAbono") = pagoAbono
        fila("Modo") = modo
        fila("ImportePagado") = importe
        fila("PagoPremios") = pagoPremios
        fila("ImporteDecimos") = importedecimos
        stabla.Rows.Add(fila)
        datosdetallesadmon.InsertarDetallesAdmon(fila)

    End Sub

    Public Function GetTotalDetallesAdmonSorteo(ejercicio)
        Return datosdetallesadmon.ObtenerTotalDetallesAdmonSorteo(ejercicio)
    End Function

    Public Function GetTotalPagadoSorteo(idsorteo)
        Return datosdetallesadmon.TotalPagadoSorteo(idsorteo)
    End Function

    Public Function GetTotalPagadoAdmon(ejercicio)
        Return datosdetallesadmon.TotalPagadoAdmon(ejercicio)
    End Function

    Public Function GetImporteDecimos(ejercicio, idsorteo)
        Return datosdetallesadmon.ImporteDecimosSorteo(ejercicio, idsorteo)
    End Function

    Public Function GetImporteDecimosEjercicio(ejercicio)
        Return datosdetallesadmon.ImporteDecimosEjercicio(ejercicio)
    End Function

    Public Function GetPremiosabonadoEjercicio(ejercicio)
        Return datosdetallesadmon.AbonadoPremiosEjercicio(ejercicio)
    End Function

    Public Function GetPremiosAbonadoSorteo(ejercicio, idsorteo)
        Return datosdetallesadmon.ABonadoPremiosSorteo(ejercicio, idsorteo)
    End Function

End Class
