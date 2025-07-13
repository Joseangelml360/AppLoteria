Imports System.Windows.Forms
Public Class DetallesAdmonEntidad

    Public Shared Function TablaDetallesAdmon() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Id", GetType(Integer))
            tabla.Columns.Add("IdAdmon", GetType(Integer))
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("IdSorteo", GetType(Integer))
            tabla.Columns.Add("NumJugado", GetType(Integer))
            tabla.Columns.Add("NumJugado2", GetType(Integer))
            tabla.Columns.Add("Fecha", GetType(Date))
            tabla.Columns.Add("PagoAbono", GetType(String))
            tabla.Columns.Add("Modo", GetType(String))
            tabla.Columns.Add("ImportePagado", GetType(Double))
            tabla.Columns.Add("PagoPremios", GetType(Double))
            tabla.Columns.Add("ImporteDecimos", GetType(Double))

        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
