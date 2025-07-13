Imports Datos
Imports Entidades

Public Class AdministracionesNegocio
    Private ReadOnly datosadmon As New AdmonDatos

    Public Function GetAdmon()
        Return datosadmon.ObtenerAdministraciones()
    End Function

    Public Sub GuardarAdmon(numAdmon As Integer, nombre As String, direccion As String,
                            codPost As Integer, poblacion As String, telefono As String,
                            mail As String, responsable As String, cuenta As String)

        Dim stabla As DataTable = AdministracionesEntidad.TablaAdministraciones
        Dim fila As DataRow = stabla.NewRow

        'fila("Id") = id
        fila("NumAdmon") = numAdmon
        fila("Nombre") = nombre
        fila("Direccion") = direccion
        fila("CodPost") = codPost
        fila("Poblacion") = poblacion
        fila("Telefono") = telefono
        fila("Mail") = mail
        fila("Responsable") = responsable
        fila("Cuenta") = cuenta
        stabla.Rows.Add(fila)
        datosadmon.InsertarAdmon(fila)

    End Sub

    Public Sub ActualizarAdmon(id As Integer, numAdmon As Integer, nombre As String, direccion As String,
                            codPost As Integer, poblacion As String, telefono As String,
                            mail As String, responsable As String, cuenta As String)

        Dim stabla As DataTable = AdministracionesEntidad.TablaAdministraciones
        Dim fila As DataRow = stabla.NewRow

        fila("Id") = id
        fila("NumAdmon") = numAdmon
        fila("Nombre") = nombre
        fila("Direccion") = direccion
        fila("CodPost") = codPost
        fila("Poblacion") = poblacion
        fila("Telefono") = telefono
        fila("Mail") = mail
        fila("Responsable") = responsable
        fila("Cuenta") = cuenta
        stabla.Rows.Add(fila)
        datosadmon.EditarAdmon(fila)
    End Sub

    Public Sub EraseAdmon(codigo As Integer)
        Dim stabla As DataTable = AdministracionesEntidad.TablaAdministraciones
        Dim fila As DataRow = stabla.NewRow
        fila("Id") = codigo
        datosadmon.EliminarAdmon(fila)
    End Sub

    Public Function Nombre(idadmon) As String
        Return datosadmon.GetNombre(idadmon)
    End Function

End Class
