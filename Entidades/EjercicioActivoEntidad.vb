Imports System.Windows.Forms
Public Class EjercicioActivoEntidad
    Public Shared Function TablaEjercicioActivo() As DataTable
        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("anoeje", GetType(Integer))
            tabla.Columns.Add("loteriamayor", GetType(Double))
            tabla.Columns.Add("loteriajuvenil", GetType(Double))
            tabla.Columns.Add("ordinariomayor", GetType(Double))
            tabla.Columns.Add("ordinariojuvenil", GetType(Double))
            tabla.Columns.Add("navidadmayor", GetType(Double))
            tabla.Columns.Add("navidadjuvenil", GetType(Double))
            tabla.Columns.Add("infmayor", GetType(Double))
            tabla.Columns.Add("infjuvenil", GetType(Double))

        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla
    End Function
End Class
