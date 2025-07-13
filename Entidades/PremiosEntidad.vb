Imports System.Windows.Forms
Public Class PremiosEntidad

    Public Shared Function TablaPremios() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("IdSorteo", GetType(Integer))
            tabla.Columns.Add("FechaSorteo", GetType(Date))
            tabla.Columns.Add("TipoSorteo", GetType(String))
            tabla.Columns.Add("NumJugado", GetType(Integer))
            tabla.Columns.Add("TotalPremio", GetType(Double))
            tabla.Columns.Add("Pagado", GetType(Double))
            tabla.Columns.Add("Saldo", GetType(Double))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
