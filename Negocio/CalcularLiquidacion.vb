Imports Datos
Imports Entidades
Public Class CalcularLiquidacion
    Public ReadOnly negocio As New LiquidacionNegocio
    Public ReadOnly dato As New EjercicioActivoDatos
    Public ReadOnly ventas As New DetalleVentasLoteriaDatos
    Public ReadOnly admon As New DetallesAdmonDatos
    Public ReadOnly vendor As New VendedoresDatos
    Public ReadOnly sorteo As New SorteosDatos

    Public Function RecalcularLiquidacion()

        Dim Comprado, Vendido, Premios, PremiosAbonados, Acuotas, JugadoComision, Saldo, Beneficio As Double
        Dim eje As Integer = dato.ObtenerEjercicio
        Comprado = admon.TotalPagadoAdmon(eje)
        Vendido = ventas.LiquidadoEjercicio(eje) * 0.8
        Premios = admon.AbonadoPremiosEjercicio(eje)
        PremiosAbonados = ventas.PremiosAbonadosEjercicio(eje)
        Acuotas = vendor.TotalAcuotasEjercicio(eje)
        JugadoComision = sorteo.JugadoComisionEjercicio(eje)
        Saldo = Vendido - Comprado + JugadoComision
        Beneficio = Saldo + Premios - PremiosAbonados

        Try
            negocio.GuardarLiquidacionEjercicio(eje, Comprado, Vendido, Premios, PremiosAbonados, Acuotas,
                                                  JugadoComision, Saldo, Beneficio)
        Catch ex As Exception
            MsgBox("Error al guardar la liquidación; " & ex.Message)
        End Try

        Return 0
    End Function

End Class
