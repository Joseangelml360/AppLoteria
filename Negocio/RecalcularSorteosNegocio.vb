Imports Datos
Imports Entidades
Public Class RecalcularSorteosNegocio
    Public ReadOnly datosventas As New DetalleVentasLoteriaDatos
    Public ReadOnly datossorteo As New SorteosDatos
    Public ReadOnly detallesadmon As New DetallesAdmonDatos

    Public Function RecalcularTodosSorteos(ejercicio As Integer) As (Double, Double, Double)
        'Recuperar sorteos activos del ejercicicio, añadir los IdSorteo a una lista.
        'Recorrer la lista y  para cada fila de detallesVendor obtener suma de entregadas, devueltas,
        'para ese id y ejercicio.
        'Con esos datos actualizar el sorteo con el valor obtenido de sumas anterior y recalcular el
        'resto de campos afectados, incluido decimos e importes total y loteria jugada.

        Dim tblSorteos As DataTable = datossorteo.GetSorteoEjercicio(ejercicio)
        Dim importetotal, importepagado, saldo As Double
        Dim id, n As Integer

        Try
            For Each fila As DataRow In tblSorteos.Rows
                n += 1
                id = CInt(fila("IdSorteo").ToString)
                importetotal += Convert.ToDouble(fila("ImporteTotal").ToString)
                importepagado += fila("ImportePagado")
            Next
        Catch ex As Exception
            MsgBox("Recalcular todos los sorteos" & ex.Message)
        End Try

        If n > 1 Then
            saldo = importepagado - importetotal
        Else
            importetotal = 0
            importepagado = 0
            saldo = 0
        End If


        Return (importetotal, importepagado, saldo)
    End Function

    Public Function CalcularSorteo(idsorteo, ejercicio) As (Double, Double, Double)
        Dim entregadas, devueltas As Integer
        Dim deuda, liquidado, saldo, importepapeleta, importepagado As Double

        Dim fila As DataRow = datosventas.GetResumenSorteo(idsorteo, ejercicio)

        If fila IsNot Nothing Then
            entregadas = fila("PapeletasEntregadas")
            devueltas = fila("PapeletasDevueltas")
            liquidado = fila("Liquidado") * 0.8
            importepapeleta = fila("ImportePapeleta")

        End If

        deuda = datossorteo.ImporteTotal(ejercicio, idsorteo)
        importepagado = datossorteo.ImportePagadoSorteo(ejercicio, idsorteo)
        saldo = importepagado - deuda



        Return (deuda, importepagado, saldo)

    End Function

    Public Sub ActualizarSorteo(idsorteo, ejercicio)
        Dim entregadas, devueltas, pptasaventa, pptastotales, pptasempresa, numdecimos, Num1, Num2 As Integer
        Dim liquidado, importepapeleta, importetotal, loteriajugada, juegaempresa, importedecimo,
            importepptapremio, Premio1, Premio2 As Double

        ' Extraer sumas de detalles venta loteria
        Dim fila As DataRow = datosventas.GetResumenSorteo(idsorteo, ejercicio)
        If fila IsNot Nothing Then
            entregadas = fila("PapeletasEntregadas")
            devueltas = fila("PapeletasDevueltas")
            liquidado = fila("Liquidado") * 0.8
            importepapeleta = fila("ImportePapeleta")
        Else
            MsgBox("No se encontraron datos de venta para este sorteo")
            Exit Sub
        End If

        'Extraer valores fijos del sorteo=IdSorteo
        'Dim importedecimo = datossorteo.ImporteDecimo(idsorteo, ejercicio)
        'Dim importepptapremio = datossorteo.ImportePptaPremio(idsorteo, ejercicio)
        Dim row As DataRow = datossorteo.ImporteDecimo(idsorteo, ejercicio)
        importedecimo = row("ImporteDecimo")
        Num1 = row("NumeroJugado")
        Num2 = row("NumeroJugado2")
        Premio1 = row("ImportePremioNum1")
        Premio2 = row("ImportePremioNum2")
        importepptapremio = Premio1 + Premio2

        'Calcular nuevos valores para actualizar sorteo
        pptasaventa = entregadas - devueltas
        numdecimos = Math.Ceiling(pptasaventa * importepapeleta * 0.8 / importedecimo)
        importetotal = numdecimos * importedecimo
        If importepapeleta = 0 Then
            pptastotales = 0
        Else
            pptastotales = importetotal / (importepapeleta * 0.8)
        End If

        pptasempresa = pptastotales - pptasaventa
        juegaempresa = Math.Round(pptasempresa * importepapeleta * 0.8, 2)
        loteriajugada = pptastotales * importepapeleta

        'Update idsorteo

        Try
            Dim tabla As DataTable = SorteosEntidad.TablaSorteos()
            Dim fila2 As DataRow = tabla.NewRow

            fila2("IdSorteo") = idsorteo
            fila2("PapeletasEntregadas") = entregadas
            fila2("PapeletasDevueltas") = devueltas
            fila2("LoteriaJugada") = loteriajugada
            fila2("DecimosJugados") = numdecimos
            fila2("ImporteTotal") = importetotal
            fila2("JuegaEmpresa") = juegaempresa
            fila2("ImportePremioPapeleta") = importepptapremio
            fila2("NumeroJugado") = Num1
            fila2("NumeroJugado2") = Num2
            fila2("ImportePremioNum1") = Premio1
            fila2("ImportePremioNum2") = Premio2
            tabla.Rows.Add(fila2)

            datossorteo.EditarSorteo(fila2)
        Catch ex As Exception
            MsgBox("Error al actualizar sorteos desde detalles venta de loteria: " & ex.Message)
        End Try
    End Sub

End Class
