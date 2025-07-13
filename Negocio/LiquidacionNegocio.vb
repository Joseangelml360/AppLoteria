Imports Datos
Imports Entidades

Public Class LiquidacionNegocio
    Private datosliquidacion As New LiquidacionDatos

    Public Function GetLiquidacion()
        Return datosliquidacion.ObtenerLiquidacion
    End Function

    Public Function GetLiquidacionFilter(ejercicio As Integer)
        Return datosliquidacion.GetLiquidacionFilter(ejercicio)
    End Function

    Public Sub GuardarLiquidacionEjercicio(eje As Integer, comprado As Double, vendido As Double,
                                           premios As Double, abonopremios As Double, acuotas As Double,
                                           jugadoempresa As Double, saldo As Double, beneficio As Double)

        Dim tabla As DataTable = LiquidacionEntidad.TablaLiquidacion
        Dim fila As DataRow = tabla.NewRow
        fila("Ejercicio") = eje
        fila("Comprado") = comprado
        fila("Vendido") = vendido
        fila("Premios") = premios
        fila("AbonoPremios") = abonopremios
        fila("Acuotas") = acuotas
        fila("JugadoEmpresa") = jugadoempresa
        fila("Saldo") = saldo
        fila("BeneficioEmpresa") = beneficio
        tabla.Rows.Add(fila)

        datosliquidacion.InsertarLiquidacionEjercicio(fila, eje)

    End Sub

End Class
