Imports Datos
Imports Entidades
Public Class SorteosNegocio
    Private ReadOnly datosorteos As New SorteosDatos

    Public Function GetSorteos()
        Return datosorteos.ObtenerSorteos
    End Function

    Public Function GetSorteoEjeActivo(ejercicio As Integer)
        'Dim eje As Integer = ejercicio
        Return datosorteos.GetSorteoEjercicio(ejercicio)
    End Function

    Public Function GetImporteTotal(ejercicio As Integer, idsorteo As Integer)
        Return datosorteos.ImporteTotal(ejercicio, idsorteo)
    End Function

    Public Function GetImportePagadoSorteo(ejercicio As Integer, idsorteo As Integer)
        Return datosorteos.ImportePagadoSorteo(ejercicio, idsorteo)
    End Function

    Public Function GetImportePagadoTotal(ejercicio)
        Return datosorteos.ImportePagadoTotal(ejercicio)
    End Function


    Public Sub GuardarSorteo(IdSorteo As Integer, Ejercicio As Integer, TipoSorteo As String, Fecha As DateTime,
                             IdAdmon As Integer, NumeroJugado As Integer, ImporteDecimo As Double,
                             ImportePapeleta As Double, PapeletasImpresas As Integer, PapeletasEntregadas As Integer,
                             PapeletasDevueltas As Integer, LoteriaJugada As Double, DecimosJugados As Integer,
                             ImporteTotal As Double, JuegaEmpresa As Double, ImportepremioPapeleta As Double,
                             ImportePagado As Double, NumeroJugado2 As Integer, ImportePremioNum1 As Double,
                             ImportePremioNum2 As Double)

        Dim tabla As DataTable = SorteosEntidad.TablaSorteos()
        Dim fila As DataRow = tabla.NewRow

        fila("IdSorteo") = IdSorteo
        fila("Ejercicio") = Ejercicio
        fila("TipoSorteo") = TipoSorteo
        fila("Fecha") = Fecha
        fila("IdAdmon") = IdAdmon
        fila("NumeroJugado") = NumeroJugado
        fila("ImporteDecimo") = ImporteDecimo
        fila("ImportePapeleta") = ImportePapeleta
        fila("PapeletasImpresas") = PapeletasImpresas
        fila("PapeletasEntregadas") = PapeletasEntregadas
        fila("PapeletasDevueltas") = PapeletasDevueltas
        fila("LoteriaJugada") = LoteriaJugada
        fila("DecimosJugados") = DecimosJugados
        fila("ImporteTotal") = ImporteTotal
        fila("JuegaEmpresa") = JuegaEmpresa
        fila("ImportePremioPapeleta") = ImportepremioPapeleta
        fila("ImportePagado") = ImportePagado
        fila("NumeroJugado2") = NumeroJugado2
        fila("ImportePremioNum1") = ImportePremioNum1
        fila("ImportePremioNum2") = ImportePremioNum2
        tabla.Rows.Add(fila)

        datosorteos.InsertarSorteo(fila)

    End Sub

    Public Sub ActualizarSorteo(IdSorteo, PapeletasEntregadas, PapeletasDevueltas, LoteriaJugada, DecimosJugados,
                                ImporteTotal, JuegaEmpresa, ImportePremioPapeleta, ImportePagado, NumJugado1,
                                NumJugado2, ImportePremioNum1, ImportePremioNum2)

        Dim tabla As DataTable = SorteosEntidad.TablaSorteos()
        Dim fila As DataRow = tabla.NewRow

        fila("IdSorteo") = IdSorteo
        fila("PapeletasEntregadas") = PapeletasEntregadas
        fila("PapeletasDevueltas") = PapeletasDevueltas
        fila("LoteriaJugada") = LoteriaJugada
        fila("DecimosJugados") = DecimosJugados
        fila("ImporteTotal") = ImporteTotal
        fila("JuegaEmpresa") = JuegaEmpresa
        fila("ImportePremioPapeleta") = ImportePremioPapeleta
        fila("ImportePagado") = ImportePagado
        fila("NumeroJugado") = NumJugado1
        fila("NumeroJugado2") = NumJugado2
        fila("ImportePremioNum1") = ImportePremioNum1
        fila("ImportePremioNum2") = ImportePremioNum2
        tabla.Rows.Add(fila)

        datosorteos.EditarSorteo(fila)
    End Sub

    Public Sub UpdateImportePagado(idsorteo, pagado)
        datosorteos.ActualizarPagado(idsorteo, pagado)
    End Sub
End Class
