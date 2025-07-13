Imports MySql.Data.MySqlClient
Public Class EjercicioActivoDatos
    Public Property EjercicioActivoEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetDbCensosConexion()

    Public Function ObtenerEjercicio()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT anoeje FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("anoeje") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerLoteriaMayores()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT loteriamayor FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("loteriamayor") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerLoteriaJuveniles()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT loteriajuvenil FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("loteriajuvenil") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerOrdMayor()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT ordinariomayor FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("ordinariomayor") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerOrdJuvenil()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT ordinariojuvenil FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("ordinariojuvenil") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerNavMayor()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT navidadmayor FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("navidadmayor") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerNavJuvenil()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT navidadjuvenil FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("navidadjuvenil") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerReyesMayor()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT infmayor FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("infmayor") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function

    Public Function ObtenerReyesJuvenil()
        Dim stabla As DataTable = Entidades.EjercicioActivoEntidad.TablaEjercicioActivo()
        Dim dato As Integer
        conn.Open()
        Dim query As String = "SELECT infjuvenil FROM ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("infjuvenil") = reader.GetInt32(0)

            dato = reader.GetInt32(0)
            stabla.Rows.Add(fila)
        End While
        reader.Close()
        conn.Close()

        Return dato
    End Function
End Class
