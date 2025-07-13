Imports MySql.Data.MySqlClient
Public Class LibroDiarioDatos
    Public Property LibroDiarioEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerLibroDiario(ejercicio)
        Dim stabla As DataTable = Entidades.LibroDiarioEntidad.TablaLibroDiario
        conn.Open()
        Dim query As String = "SELECT * FROM librodiario WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("IdDiario") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("Fecha") = reader.GetDateTime(2)
            fila("EntradaSalida") = reader.GetString(3)
            fila("Importe") = reader.GetDouble(4)
            fila("CajaBanco") = reader.GetString(5)
            fila("Concepto") = reader.GetString(6)
            fila("Debe") = reader.GetDouble(7)
            fila("Haber") = reader.GetDouble(8)
            fila("Saldo") = reader.GetDouble(9)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    Public Sub InsertarApunte(fila As DataRow)
        conn.Open()
        Dim query As String = "INSERT INTO librodiario (Ejercicio, Fecha, EntradaSalida, Importe, CajaBanco, Concepto,
                              Debe, Haber, Saldo)
                                VALUES(@Ejercicio, @Fecha, @EntradaSalida, @Importe, @CajaBanco, @Concepto,
                              @Debe, @Haber, @Saldo)"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@Fecha", fila("Fecha"))
        cmd.Parameters.AddWithValue("@EntradaSalida", fila("EntradaSalida"))
        cmd.Parameters.AddWithValue("@Importe", fila("Importe"))
        cmd.Parameters.AddWithValue("@CajaBanco", fila("CajaBanco"))
        cmd.Parameters.AddWithValue("@Concepto", fila("Concepto"))
        cmd.Parameters.AddWithValue("@Debe", fila("Debe"))
        cmd.Parameters.AddWithValue("@Haber", fila("Haber"))
        cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function GetDebeHaberLibroDiario(ejercicio)
        Dim tabla As DataTable = Entidades.LibroDiarioEntidad.TablaLibroDiario
        Dim sumadebehaber As Double

        conn.Open()
        Dim query As String = "SELECT SUM(Haber)-SUM(Debe) AS sumadebehaber FROM librodiario WHERE Ejercicio= " & ejercicio

        Try
            Dim cmd As New MySqlCommand(query, conn)
            sumadebehaber = Convert.ToDouble(cmd.ExecuteScalar()) ' Ejecuta y devuelve la operación solicitada
        Catch ex As Exception
            ' Manejo de errores 
            sumadebehaber = 0
            'MsgBox("Todavía no hay apuntes en el libro de Caja: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return sumadebehaber
    End Function
End Class
