Imports System.Windows.Forms
Public Class SorteosEntidad
    Public Shared Function TablaSorteos() As DataTable

        Dim tabla As DataTable
        Try
            tabla = New DataTable()
            tabla.Columns.Add("IdSorteo", GetType(Integer))
            tabla.Columns.Add("Ejercicio", GetType(Integer))
            tabla.Columns.Add("TipoSorteo", GetType(String))
            tabla.Columns.Add("Fecha", GetType(Date))
            tabla.Columns.Add("IdAdmon", GetType(Integer))
            tabla.Columns.Add("NumeroJugado", GetType(Integer))
            tabla.Columns.Add("ImporteDecimo", GetType(Double))
            tabla.Columns.Add("ImportePapeleta", GetType(Double))
            tabla.Columns.Add("PapeletasImpresas", GetType(Integer))
            tabla.Columns.Add("PapeletasEntregadas", GetType(Integer))
            tabla.Columns.Add("PapeletasDevueltas", GetType(Integer))
            tabla.Columns.Add("LoteriaJugada", GetType(Double))
            tabla.Columns.Add("DecimosJugados", GetType(Integer))
            tabla.Columns.Add("ImporteTotal", GetType(Double))
            tabla.Columns.Add("JuegaEmpresa", GetType(Double))
            tabla.Columns.Add("ImportePremioPapeleta", GetType(Double))
            tabla.Columns.Add("ImportePagado", GetType(Double))
            tabla.Columns.Add("NumeroJugado2", GetType(Integer))
            tabla.Columns.Add("ImportePremioNum1", GetType(Double))
            tabla.Columns.Add("ImportePremioNum2", GetType(Double))
        Catch ex As Exception
            MessageBox.Show("Error al crear la tabla: " & ex.Message)
            Return Nothing
        End Try
        Return tabla

    End Function


End Class
