Imports System.Windows.Forms

Public Class AdministracionesEntidad

    Public Shared Function TablaAdministraciones() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("Id", GetType(Integer))
            tabla.Columns.Add("NumAdmon", GetType(Integer))
            tabla.Columns.Add("Nombre", GetType(String))
            tabla.Columns.Add("Direccion", GetType(String))
            tabla.Columns.Add("CodPost", GetType(Integer))
            tabla.Columns.Add("Poblacion", GetType(String))
            tabla.Columns.Add("Telefono", GetType(String))
            tabla.Columns.Add("Mail", GetType(String))
            tabla.Columns.Add("Responsable", GetType(String))
            tabla.Columns.Add("Cuenta", GetType(String))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function

End Class
