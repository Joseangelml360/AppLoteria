Imports Datos
Imports Entidades
Public Class LibroDiarioNegocio

    Private ReadOnly libro As New LibroDiarioDatos

    Public Function GetLibroDiario(ejercicio)
        Return libro.ObtenerLibroDiario(ejercicio)
    End Function

    Public Function ObtenerSaldo(ejercicio)
        Return libro.GetDebeHaberLibroDiario(ejercicio)
    End Function

    Public Sub InsertarApunte(ejercicio As Integer, fecha As Date, entradasalida As String, importe As Double,
                              cajabanco As String, concepto As String, debe As Double, haber As Double, saldo As Double)

        Dim tabla As DataTable = LibroDiarioEntidad.TablaLibroDiario
        Dim fila As DataRow = tabla.NewRow
        concepto = Left(concepto, 80)
        fila("Ejercicio") = ejercicio
        fila("Fecha") = fecha
        fila("EntradaSalida") = entradasalida
        fila("Importe") = importe
        fila("CajaBanco") = cajabanco
        fila("Concepto") = concepto
        fila("Debe") = debe
        fila("Haber") = haber
        fila("Saldo") = saldo
        tabla.Rows.Add(fila)

        libro.InsertarApunte(fila)


    End Sub

End Class
