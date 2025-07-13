Imports MySql.Data.MySqlClient

Public Class CensoFalleroDatos
    Public Property FalleroEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetDbCensosConexion

    Public Function ObtenerCensoFalleros()
        Dim stabla As DataTable = Entidades.FalleroEntidad.TablaFalleros()
        conn.Open()
        'Dim query As String = "SELECT ANO_CEN,FALLERO_CODIGO, NOMBRE, APELLIDOS, LOTERIA, TIPFAL FROM fallero WHERE BAJA=0 AND LOTERIA=0"
        Dim query As String = "SELECT ANO_CEN,FALLERO_CODIGO, NOMBRE, APELLIDOS, LOTERIA, TIPFAL FROM dbcensos.fallero 
                               WHERE FALLERO_CODIGO NOT IN (SELECT Codigo FROM dbcensos.vendedores) AND BAJA=0"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("ANO_CEN") = reader.GetDouble(0)
            fila("FALLERO_CODIGO") = reader.GetInt32(1)
            fila("NOMBRE") = reader.GetString(2)
            fila("APELLIDOS") = reader.GetString(3)
            fila("LOTERIA") = reader.GetBoolean(4)
            fila("TIPFAL") = reader.GetInt32(5)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    Public Function ImportarCensoFalleros()
        Dim stabla As DataTable = Entidades.FalleroEntidad.TablaFalleros()
        conn.Open()
        Dim query As String = "SELECT ANO_CEN,FALLERO_CODIGO, NOMBRE, APELLIDOS, LOTERIA, TIPFAL FROM fallero WHERE BAJA=0 AND LOTERIA=1"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("ANO_CEN") = reader.GetDouble(0)
            fila("FALLERO_CODIGO") = reader.GetInt32(1)
            fila("NOMBRE") = reader.GetString(2)
            fila("APELLIDOS") = reader.GetString(3)
            fila("LOTERIA") = reader.GetByte(4)
            fila("TIPFAL") = reader.GetInt32(5)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function
End Class
