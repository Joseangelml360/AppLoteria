Imports System.Windows.Forms

Public Class FalleroEntidad
    Public Shared Function TablaFalleros() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("ANO_CEN", GetType(Double))
            tabla.Columns.Add("FALLERO_CODIGO", GetType(Integer))
            tabla.Columns.Add("NOMBRE", GetType(String))
            tabla.Columns.Add("APELLIDOS", GetType(String))
            tabla.Columns.Add("LOTERIA", GetType(Boolean))
            tabla.Columns.Add("TIPFAL", GetType(Integer))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function
End Class
