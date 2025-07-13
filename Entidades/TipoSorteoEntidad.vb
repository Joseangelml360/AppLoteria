Imports System.Windows.Forms
Public Class TipoSorteoEntidad
    Public Shared Function TablaTipoSorteo() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Codigo", GetType(Integer))
            tabla.Columns.Add("Tipo", GetType(String))

        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function
End Class
