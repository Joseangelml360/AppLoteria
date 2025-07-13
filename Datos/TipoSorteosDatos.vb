

Imports MySql.Data.MySqlClient

Public Class TipoSorteosDatos

    Public Property TipoSorteo As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerTipoSorteo()
        Dim stabla As DataTable = Entidades.TipoSorteoEntidad.TablaTipoSorteo()
        conn.Open()
        Dim query As String = "SELECT * FROM tiposorteos"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Codigo") = reader.GetInt32(0)
            fila("Tipo") = reader.GetString(1)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Sub InsertarTipoSorteo(fila As DataRow)
        conn.Open()
        Dim query As String = "INSERT INTO tiposorteos (Codigo, Tipo)
                               VALUES (@codigo, @tipo)"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@codigo", fila("Codigo"))
        cmd.Parameters.AddWithValue("@Tipo", fila("Tipo"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub EditarTipoSorteo(fila As DataRow)

        conn.Open()
        Dim query As String = "UPDATE tiposorteos SET tipo=@tipo                              
                               WHERE Codigo=@codigo"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@codigo", fila("codigo"))
        cmd.Parameters.AddWithValue("@tipo", fila("Tipo"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub EliminarTipoSorteo(fila As DataRow)

        conn.Open()
        Dim query As String = "DELETE FROM tiposorteos WHERE Codigo = @codigo"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@codigo", fila("Codigo"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

End Class
