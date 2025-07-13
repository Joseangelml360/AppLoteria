Imports MySql.Data.MySqlClient

Public Class DetallesAdmonDatos
    Public Property DetallesAdmonEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerDetallesAdmon()
        Dim stabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        conn.Open()
        Dim query As String = "SELECT * FROM detallesadmon"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("IdAdmon") = reader.GetInt32(1)
            fila("Ejercicio") = reader.GetInt32(2)
            fila("IdSorteo") = reader.GetInt32(3)
            fila("NumJugado") = reader.GetInt32(4)
            fila("NumJugado2") = reader.GetInt32(5)
            fila("Fecha") = reader.GetDateTime(6)
            fila("PagoAbono") = reader.GetString(7)
            fila("Modo") = reader.GetString(8)
            fila("ImportePagado") = reader.GetDouble(9)
            fila("PagoPremios") = reader.GetDouble(10)
            fila("ImporteDecimos") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Sub InsertarDetallesAdmon(fila As DataRow)
        conn.Close()
        conn.Open()
        Dim query As String = "INSERT INTO detallesadmon ( IdAdmon, Ejercicio, IdSorteo, NumJugado, NumJugado2,
                               Fecha, PagoAbono, Modo, ImportePagado, PagoPremios, ImporteDecimos)
                               VALUES (@IdAdmon, @Ejercicio, @IdSorteo, @NumJugado, @NumJugado2,
                               @Fecha, @PagoAbono, @Modo, @ImportePagado, @PagoPremios, @ImporteDecimos)"

        Dim cmd As New MySqlCommand(query, conn)

        'cmd.Parameters.AddWithValue("@Id", fila("Id"))
        cmd.Parameters.AddWithValue("@IdAdmon", fila("IdAdmon"))
        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@IdSorteo", fila("IdSorteo"))
        cmd.Parameters.AddWithValue("@NumJugado", fila("NumJugado"))
        cmd.Parameters.AddWithValue("@NumJugado2", fila("NumJugado2"))
        cmd.Parameters.AddWithValue("@Fecha", fila("Fecha"))
        cmd.Parameters.AddWithValue("@PagoAbono", fila("PagoAbono"))
        cmd.Parameters.AddWithValue("@Modo", fila("Modo"))
        cmd.Parameters.AddWithValue("@ImportePagado", fila("ImportePagado"))
        cmd.Parameters.AddWithValue("@PagoPremios", fila("PagoPremios"))
        cmd.Parameters.AddWithValue("@ImporteDecimos", fila("ImporteDecimos"))


        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function ObtenerTotalDetallesAdmonSorteo(ejercicio)
        Dim stabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        conn.Open()
        Dim query As String = "SELECT Id, IdAdmon, Ejercicio, IdSorteo, NumJugado, Numjugado2, Fecha, PagoAbono,
                               Modo, SUM(ImportePagado), SUM(PagoPremios),ImporteDecimos 
                               FROM detallesadmon
                               WHERE Ejercicio= " & ejercicio & " GROUP BY IdSorteo"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Id") = reader.GetInt32(0)
            fila("IdAdmon") = reader.GetInt32(1)
            fila("Ejercicio") = reader.GetInt32(2)
            fila("IdSorteo") = reader.GetInt32(3)
            fila("NumJugado") = reader.GetInt32(4)
            fila("NumJugado2") = reader.GetInt32(5)
            fila("Fecha") = reader.GetDateTime(6)
            fila("PagoAbono") = reader.GetString(7)
            fila("Modo") = reader.GetString(8)
            fila("ImportePagado") = reader.GetDouble(9)
            fila("PagoPremios") = reader.GetDouble(10)
            fila("ImporteDecimos") = reader.GetDouble(11)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Function TotalPagadoSorteo(idsorteo)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()

        Dim query As String = "SELECT SUM(ImportePagado) FROM detallesadmon WHERE 
                               idsorteo = " & idsorteo & " And PagoAbono = 'P'"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImportePagado") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de pagos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function TotalPagadoAdmon(ejercicio)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(ImportePagado) FROM detallesadmon WHERE Ejercicio= " &
                               ejercicio & " AND PagoAbono= 'P'"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImportePagado") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de pagos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ImporteDecimosSorteo(ejercicio, idsorteo)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT ImporteDecimos FROM detallesadmon WHERE Ejercicio= " &
                               ejercicio & " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImporteDecimos") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de Décimos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ImporteDecimosEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(ImporteDecimos) FROM detallesadmon WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImporteDecimos") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de Décimos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ABonadoPremiosSorteo(ejercicio, idsorteo)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(PagoPremios) FROM detallesadmon WHERE Ejercicio= " &
                               ejercicio & " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("PagoPremios") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de pagos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function AbonadoPremiosEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.DetallesAdmonEntidad.TablaDetallesAdmon
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(PagoPremios) FROM detallesadmon WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read() Then
            Dim fila As DataRow = tabla.NewRow()
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("PagoPremios") = reader.GetInt32(0)

                total = reader.GetInt32(0)
                tabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de Décimos de este sorteo")
            conn.Close()
            Return Nothing
        End If

    End Function

End Class
