
Imports Datos
Public Class EjercicioActivoNegocio
    Private ReadOnly datosejercicio As New EjercicioActivoDatos
    Public Function GetEjercicioActivo()
        Return datosejercicio.ObtenerEjercicio()
    End Function

    Public Function GetLoteriaMayores()
        Dim LotMay As Integer = datosejercicio.ObtenerLoteriaMayores()
        Return LotMay
    End Function

    Public Function GetLoteriaJuveniles()
        Dim LotJuv As Integer = datosejercicio.ObtenerLoteriaJuveniles()
        Return LotJuv
    End Function

    Public Function GetOrdinarioMayores()
        Dim OrdMay As Integer = datosejercicio.ObtenerOrdMayor()
        Return OrdMay
    End Function

    Public Function GetOrdinarioJuveniles()
        Dim OrdJuv As Integer = datosejercicio.ObtenerOrdJuvenil()
        Return OrdJuv
    End Function

    Public Function GetNavidadMayores()
        Dim NavMay As Integer = datosejercicio.ObtenerNavMayor()
        Return NavMay
    End Function

    Public Function GetNavidadJuveniles()
        Dim NavJuv As Integer = datosejercicio.ObtenerNavJuvenil()
        Return NavJuv
    End Function

    Public Function GetReyesMayores()
        Dim ReyMay As Integer = datosejercicio.ObtenerReyesMayor()
        Return ReyMay
    End Function

    Public Function GetReyesJuveniles()
        Dim ReyJuv As Integer = datosejercicio.ObtenerReyesJuvenil()
        Return ReyJuv
    End Function
End Class
