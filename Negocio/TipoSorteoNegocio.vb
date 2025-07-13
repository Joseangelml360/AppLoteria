Imports Datos
Imports Entidades

Public Class TipoSorteoNegocio
    Private ReadOnly datostiposorteo As New TipoSorteosDatos
    Public Function GetTipoSorteo()
        Return datostiposorteo.ObtenerTipoSorteo()
    End Function

    Public Sub GuardarTipoSorteo(codigo As Integer, tipo As String)

        Dim stabla As DataTable = TipoSorteoEntidad.TablaTipoSorteo
        Dim fila As DataRow = stabla.NewRow

        fila("Codigo") = codigo
        fila("Tipo") = tipo

        stabla.Rows.Add(fila)
        datostiposorteo.InsertarTipoSorteo(fila)

    End Sub

    Public Sub ActualizarTipoSorteo(codigo As Integer, tipo As String)

        Dim stabla As DataTable = TipoSorteoEntidad.TablaTipoSorteo
        Dim fila As DataRow = stabla.NewRow

        fila("Codigo") = codigo
        fila("Tipo") = tipo

        stabla.Rows.Add(fila)
        datostiposorteo.EditarTipoSorteo(fila)
    End Sub

    Public Sub EraseTipoSorteo(codigo As Integer)
        Dim stabla As DataTable = TipoSorteoEntidad.TablaTipoSorteo
        Dim fila As DataRow = stabla.NewRow
        fila("Codigo") = codigo
        datostiposorteo.EliminarTipoSorteo(fila)
    End Sub

End Class
