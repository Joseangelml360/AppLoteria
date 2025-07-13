Imports System.Windows.Forms

Public Class DetalleVentasLoteriaEntidad

    Public Shared Function TablaDetalleVentasLoteria() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Id", GetType(Integer))
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("CodigoVendedor", GetType(Integer))
            tabla.Columns.Add("FechaApunte", GetType(Date))
            tabla.Columns.Add("IdSorteo", GetType(Integer))
            tabla.Columns.Add("TipoSorteo", GetType(String))
            tabla.Columns.Add("ImportePapeleta", GetType(Double))
            tabla.Columns.Add("PapeletasEntregadas", GetType(Integer))
            tabla.Columns.Add("PapeletasDevueltas", GetType(Integer))
            tabla.Columns.Add("Liquidado", GetType(Double))
            tabla.Columns.Add("PapeletasPremiadas", GetType(Integer))
            tabla.Columns.Add("ImportePremiadas", GetType(Double))

        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
