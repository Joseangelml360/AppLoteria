Imports MySql.Data.MySqlClient
Public Class AdmonDatos
    Public Property AdministracionesEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function GetNombre(idadmon)
        Dim stabla As DataTable = Entidades.AdministracionesEntidad.TablaAdministraciones()
        conn.Open()
        Dim nombre As String
        Dim query As String = "SELECT Nombre  FROM administraciones WHERE NumAdmon= " & idadmon
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = stabla.NewRow()
            nombre = reader.GetString(0)
            stabla.Rows.Add(fila)
        Else
            nombre = ""
        End If

        reader.Close()
        conn.Close()
        Return nombre

    End Function
    Public Function ObtenerAdministraciones()
        Dim stabla As DataTable = Entidades.AdministracionesEntidad.TablaAdministraciones()
        conn.Open()
        Dim query As String = "SELECT * FROM administraciones"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("NumAdmon") = reader.GetInt32(1)
            fila("Nombre") = reader.GetString(2)
            fila("Direccion") = reader.GetString(3)
            fila("CodPost") = reader.GetInt32(4)
            fila("Poblacion") = reader.GetString(5)
            fila("Telefono") = reader.GetString(6)
            fila("Mail") = reader.GetString(7)
            fila("Responsable") = reader.GetString(8)
            fila("Cuenta") = reader.GetString(9)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Sub InsertarAdmon(fila As DataRow)
        conn.Open()
        Dim query As String = "INSERT INTO administraciones (NumAdmon, Nombre, Direccion, CodPost, Poblacion,
                               Telefono, Mail, Responsable, Cuenta)
                               VALUES (@NumAdmon, @Nombre, @Direccion, @CodPost, @Poblacion,
                               @Telefono, @Mail, @Responsable, @Cuenta)"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@NumAdmon", fila("NumAdmon"))
        cmd.Parameters.AddWithValue("@Nombre", fila("Nombre"))
        cmd.Parameters.AddWithValue("@Direccion", fila("Direccion"))
        cmd.Parameters.AddWithValue("@CodPost", fila("CodPost"))
        cmd.Parameters.AddWithValue("@Poblacion", fila("Poblacion"))
        cmd.Parameters.AddWithValue("@Telefono", fila("Telefono"))
        cmd.Parameters.AddWithValue("@Mail", fila("Mail"))
        cmd.Parameters.AddWithValue("@Responsable", fila("Responsable"))
        cmd.Parameters.AddWithValue("@Cuenta", fila("Cuenta"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub EditarAdmon(fila As DataRow)

        conn.Open()
        Dim query As String = "UPDATE administraciones SET NumAdmon=@NumAdmon, Nombre=@Nombre, 
                               Direccion=@Direccion, CodPost=@CodPost, Poblacion=@Poblacion, 
                               Telefono=@Telefono, Mail=@Mail, Responsable=@Responsable, Cuenta=@Cuenta                               
                               WHERE Id=@Id"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Id", fila("Id"))
        cmd.Parameters.AddWithValue("@NumAdmon", fila("NumAdmon"))
        cmd.Parameters.AddWithValue("@Nombre", fila("Nombre"))
        cmd.Parameters.AddWithValue("@Direccion", fila("Direccion"))
        cmd.Parameters.AddWithValue("@CodPost", fila("CodPost"))
        cmd.Parameters.AddWithValue("@Poblacion", fila("Poblacion"))
        cmd.Parameters.AddWithValue("@Telefono", fila("Telefono"))
        cmd.Parameters.AddWithValue("@Mail", fila("Mail"))
        cmd.Parameters.AddWithValue("@Responsable", fila("Responsable"))
        cmd.Parameters.AddWithValue("@Cuenta", fila("Cuenta"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub EliminarAdmon(fila As DataRow)

        conn.Open()
        Dim query As String = "DELETE FROM administraciones WHERE Id = @Id"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Id", fila("Id"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

End Class
