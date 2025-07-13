Imports MySql.Data.MySqlClient

Public Class DetalleVentasLoteriaDatos

    Public Property DetalleVentasLoteriaEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerDetalleVentasLoteria()
        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT * FROM detallesventaloteria"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("CodigoVendedor") = reader.GetInt32(2)
            fila("FechaApunte") = reader.GetDateTime(3)
            fila("IdSorteo") = reader.GetInt32(4)
            fila("TipoSorteo") = reader.GetString(5)
            fila("ImportePapeleta") = reader.GetDouble(6)
            fila("PapeletasEntregadas") = reader.GetInt32(7)
            fila("PapeletasDevueltas") = reader.GetInt32(8)
            fila("Liquidado") = reader.GetDouble(9)
            fila("PapeletasPremiadas") = reader.GetInt32(10)
            fila("ImportePremiadas") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Function ObtenerDetalleVentasLoteriaSorteo(ejercicio, idsorteo)
        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT * FROM detallesventaloteria WHERE Ejercicio=" & ejercicio &
                              " AND IdSorteo= " & idsorteo


        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("CodigoVendedor") = reader.GetInt32(2)
            fila("FechaApunte") = reader.GetDateTime(3)
            fila("IdSorteo") = reader.GetInt32(4)
            fila("TipoSorteo") = reader.GetString(5)
            fila("ImportePapeleta") = reader.GetDouble(6)
            fila("PapeletasEntregadas") = reader.GetInt32(7)
            fila("PapeletasDevueltas") = reader.GetInt32(8)
            fila("Liquidado") = reader.GetDouble(9)
            fila("PapeletasPremiadas") = reader.GetInt32(10)
            fila("ImportePremiadas") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Function ObtenerTotalesVentasLoteriaSorteo(ejercicio, idsorteo)
        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT Id, Ejercicio, CodigoVendedor, FechaApunte, IdSorteo, TipoSorteo,
                               ImportePapeleta, SUM(PapeletasEntregadas), SUM(PapeletasDevueltas),
                               SUM(Liquidado), SUM(PapeletasPremiadas), SUM(ImportePremiadas)
                               FROM detallesventaloteria WHERE Ejercicio=" & ejercicio &
                              " AND IdSorteo= " & idsorteo & " GROUP BY CodigoVendedor"


        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("CodigoVendedor") = reader.GetInt32(2)
            fila("FechaApunte") = reader.GetDateTime(3)
            fila("IdSorteo") = reader.GetInt32(4)
            fila("TipoSorteo") = reader.GetString(5)
            fila("ImportePapeleta") = reader.GetDouble(6)
            fila("PapeletasEntregadas") = reader.GetInt32(7)
            fila("PapeletasDevueltas") = reader.GetInt32(8)
            fila("Liquidado") = reader.GetDouble(9)
            fila("PapeletasPremiadas") = reader.GetInt32(10)
            fila("ImportePremiadas") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function
    Public Function ObtenerDetalleVentasLoteriaVendedor(ejercicio, codigo, idsorteo)
        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT * FROM detallesventaloteria WHERE Ejercicio=" & ejercicio &
                               " AND CodigoVendedor= " & codigo & " AND IdSorteo= " & idsorteo & ";"

        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("CodigoVendedor") = reader.GetInt32(2)
            fila("FechaApunte") = reader.GetDateTime(3)
            fila("IdSorteo") = reader.GetInt32(4)
            fila("TipoSorteo") = reader.GetString(5)
            fila("ImportePapeleta") = reader.GetDouble(6)
            fila("PapeletasEntregadas") = reader.GetInt32(7)
            fila("PapeletasDevueltas") = reader.GetInt32(8)
            fila("Liquidado") = reader.GetDouble(9)
            fila("PapeletasPremiadas") = reader.GetInt32(10)
            fila("ImportePremiadas") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Function GetResumenSorteoVendor(IdSorteo, CodigoVendedor, Ejercicio)

        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT SUM(PapeletasEntregadas), SUM(PapeletasDevueltas), SUM(Liquidado),
                               SUM(PapeletasPremiadas) 
                               FROM detallesventaloteria 
                               WHERE IdSorteo= " & IdSorteo & " AND CodigoVendedor= " & CodigoVendedor &
                               " AND Ejercicio= " & Ejercicio

        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = stabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing

            Else
                fila("PapeletasEntregadas") = reader.GetInt32(0)
                fila("PapeletasDevueltas") = reader.GetInt32(1)
                fila("Liquidado") = reader.GetDecimal(2)
                fila("PapeletasPremiadas") = reader.GetInt32(3)
                stabla.Rows.Add(fila)

                reader.Close()
                conn.Close()
                Return fila
            End If
        Else
            MsgBox("No hay datos")
            conn.Close()
            Return -1
        End If

    End Function

    Public Function GetResumenSorteo(IdSorteo, Ejercicio)

        Dim stabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria()
        conn.Open()
        Dim query As String = "SELECT SUM(PapeletasEntregadas), SUM(PapeletasDevueltas), 
                               SUM(Liquidado), ImportePapeleta FROM detallesventaloteria 
                               WHERE IdSorteo= " & IdSorteo & " AND Ejercicio= " & Ejercicio

        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = stabla.NewRow()
            If (IsDBNull(reader(0))) Then
                fila("PapeletasEntregadas") = 0
                fila("PapeletasDevueltas") = 0
                fila("Liquidado") = 0
                fila("ImportePapeleta") = 0
                stabla.Rows.Add(fila)

                reader.Close()
                conn.Close()
                Return fila
            Else
                fila("PapeletasEntregadas") = reader.GetInt32(0)
                fila("PapeletasDevueltas") = reader.GetInt32(1)
                fila("Liquidado") = reader.GetDecimal(2)
                fila("ImportePapeleta") = reader.GetDouble(3)
                stabla.Rows.Add(fila)

                reader.Close()
                conn.Close()
                Return fila
            End If
        Else
            MsgBox("No hay datos")
            conn.Close()
            Return -1
        End If

    End Function

    Public Sub InsertarDetalleVentasLoteria(fila As DataRow)
        conn.Open()
        Dim query As String = "INSERT INTO detallesventaloteria (Ejercicio, CodigoVendedor, FechaApunte, 
                               IdSorteo, TipoSorteo, ImportePapeleta, PapeletasEntregadas, PapeletasDevueltas,
                               Liquidado, PapeletasPremiadas, ImportePremiadas)
                               VALUES (@Ejercicio, @CodigoVendedor, @FechaApunte, @IdSorteo, @TipoSorteo,
                               @ImportePapeleta, @PapeletasEntregadas, @PapeletasDevueltas, @Liquidado, 
                               @PapeletasPremiadas, @ImportePremiadas)"

        Dim cmd As New MySqlCommand(query, conn)


        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@CodigoVendedor", fila("CodigoVendedor"))
        cmd.Parameters.AddWithValue("@FechaApunte", fila("FechaApunte"))
        cmd.Parameters.AddWithValue("@IdSorteo", fila("IdSorteo"))
        cmd.Parameters.AddWithValue("@TipoSorteo", fila("TipoSorteo"))
        cmd.Parameters.AddWithValue("@ImportePapeleta", fila("ImportePapeleta"))
        cmd.Parameters.AddWithValue("@PapeletasEntregadas", fila("PapeletasEntregadas"))
        cmd.Parameters.AddWithValue("@PapeletasDevueltas", fila("PapeletasDevueltas"))
        cmd.Parameters.AddWithValue("@Liquidado", fila("Liquidado"))
        cmd.Parameters.AddWithValue("@PapeletasPremiadas", fila("PapeletasPremiadas"))
        cmd.Parameters.AddWithValue("@ImportePremiadas", fila("ImportePremiadas"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub


    Public Sub EliminarDetalleVentasLoteria(fila As DataRow)

        conn.Open()
        Dim query As String = "DELETE FROM detallesventaloteria WHERE Id = @Id"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Id", fila("Id"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function PremiosAbonados(idsorteo, ejercicio)
        Dim tabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria

        Dim importe As Double
        conn.Open()
        Dim query As String = "SELECT SUM(ImportePremiadas) FROM detallesventaloteria 
                               WHERE IdSorteo= " & idsorteo & " AND Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)

        Try
            importe = cmd.ExecuteScalar()
        Catch ex As Exception
            importe = 0
        End Try

        conn.Close()
        Return importe

    End Function

    Public Function PremiosAbonadosEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria

        Dim importe As Double
        conn.Open()
        Dim query As String = "SELECT SUM(ImportePremiadas) FROM detallesventaloteria 
                               WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)

        Try
            importe = cmd.ExecuteScalar()
        Catch ex As Exception
            importe = 0
        End Try

        conn.Close()
        Return importe

    End Function

    Public Function LiquidadoEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.DetalleVentasLoteriaEntidad.TablaDetalleVentasLoteria

        Dim importe As Double
        conn.Open()
        Dim query As String = "SELECT SUM(Liquidado) FROM detallesventaloteria 
                               WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)

        Try
            importe = cmd.ExecuteScalar()
        Catch ex As Exception
            importe = 0
        End Try

        conn.Close()
        Return importe

    End Function


End Class
