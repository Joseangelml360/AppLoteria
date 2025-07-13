Imports System.Windows.Forms
Public Class LibroDiarioEntidad

    Public Shared Function TablaLibroDiario() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("IdDiario", GetType(Integer))
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("Fecha", GetType(Date))
            tabla.Columns.Add("EntradaSalida", GetType(String))
            tabla.Columns.Add("Importe", GetType(Double))
            tabla.Columns.Add("CajaBanco", GetType(String))
            tabla.Columns.Add("Concepto", GetType(String))
            tabla.Columns.Add("Debe", GetType(Double))
            tabla.Columns.Add("Haber", GetType(Double))
            tabla.Columns.Add("Saldo", GetType(Double))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function


End Class
