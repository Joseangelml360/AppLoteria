Imports Datos

Public Class SociosNegocio

    Private ReadOnly datos As New CensoFalleroDatos()

    Public Function ObtenerFallerosCenso() As DataTable
        Return datos.ObtenerCensoFalleros()
    End Function

End Class
