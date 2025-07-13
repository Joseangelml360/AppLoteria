Imports System.Windows.Forms
Public Class DetallesSorteoVendedorEntidad
    Public Shared Function TablaDetallesSorteoVendedor() As DataTable
        Dim tabla As DataTable
        Try
            tabla = New DataTable
            tabla.Columns.Add("IdSorteo", GetType(Integer))
            tabla.Columns.Add("IdVendedor", GetType(Integer))
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("PapeletasEntregadas", GetType(Integer))
            tabla.Columns.Add("PapeletasDevueltas", GetType(Integer))
            tabla.Columns.Add("TotalAdeudado", GetType(Double))
            tabla.Columns.Add("EntregadoParcial", GetType(Double))
            tabla.Columns.Add("Saldo", GetType(Double))
            tabla.Columns.Add
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function
End Class
