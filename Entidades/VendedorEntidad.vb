Imports System.Windows.Forms
Public Class VendedorEntidad

    Public Shared Function TablaVendedores() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("Codigo", GetType(Integer))
            tabla.Columns.Add("Nombre", GetType(String))
            tabla.Columns.Add("Apellidos", GetType(String))
            tabla.Columns.Add("Comision", GetType(Integer))
            tabla.Columns.Add("CuotaLoteria", GetType(Boolean))
            tabla.Columns.Add("LoteriaAsignada", GetType(Double))
            tabla.Columns.Add("Liquidado", GetType(Double))
            tabla.Columns.Add("Acuota", GetType(Double))
            tabla.Columns.Add("Saldo", GetType(Double))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
