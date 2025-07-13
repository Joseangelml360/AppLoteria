Imports Datos
Imports Entidades
Public Class CalcularPremiosLoteriaNegocio
    Public ReadOnly sorteo As New SorteosDatos
    Public ReadOnly detalleadmon As New DetallesAdmonDatos

    Public Function CalcularImportePremioSorteo(ejercicio, idsorteo)
        Dim importetotalpremio As Double
        Dim numdecimos As Integer = sorteo.DecimosComprados(idsorteo, ejercicio)

        'Cálculos
        Dim fila As DataRow = sorteo.ImporteDecimo(idsorteo, ejercicio)
        If IsDBNull(fila) Then
            importetotalpremio = 0
        Else
            Dim importedecimo As Double = fila("ImporteDecimo")
            Dim importepapeletapremiada As Double = fila("ImportePremioPapeleta")
            Dim importepapeleta As Double = fila("ImportePapeleta")
            Dim cociente = importepapeletapremiada / (importepapeleta * 0.8)
            importetotalpremio = importedecimo * numdecimos * cociente
        End If

        Return importetotalpremio
    End Function

End Class
