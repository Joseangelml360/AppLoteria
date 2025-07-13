Imports System.Windows.Forms
Public Class LiquidacionEntidad

    Public Shared Function TablaLiquidacion() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("Comprado", GetType(Double))
            tabla.Columns.Add("Vendido", GetType(Double))
            tabla.Columns.Add("Premios", GetType(Double))
            tabla.Columns.Add("AbonoPremios", GetType(Double))
            tabla.Columns.Add("ACuotas", GetType(Double))
            tabla.Columns.Add("JugadoEmpresa", GetType(Double))
            tabla.Columns.Add("Saldo", GetType(Double))
            tabla.Columns.Add("BeneficioEmpresa", GetType(Double))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
