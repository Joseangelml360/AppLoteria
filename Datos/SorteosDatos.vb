Imports MySql.Data.MySqlClient

Public Class SorteosDatos
    Public Property SorteosEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerSorteos()
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()
        Dim query As String = "SELECT IdSorteo, Ejercicio, TipoSorteo, Fecha, IdAdmon, NumeroJugado, NumeroJugado2,
                               ImporteDecimo, ImportePapeleta, PapeletasImpresas, PapeletasEntregadas, PapeletasDevueltas,
                               LoteriaJugada, DecimosJugados, ImporteTotal, JuegaEmpresa, ImportePremioPapeleta, ImportePagado,
                               ImportePremioNum1, ImportePremioNum2
                               FROM sorteos"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("IdSorteo") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("TipoSorteo") = reader.GetString(2)
            fila("Fecha") = reader.GetDateTime(3)
            fila("IdAdmon") = reader.GetInt32(4)
            fila("NumeroJugado") = reader.GetInt32(5)
            fila("NumeroJugado2") = reader.GetInt32(6)
            fila("ImporteDecimo") = reader.GetDouble(7)
            fila("ImportePapeleta") = reader.GetDouble(8)
            fila("PapeletasImpresas") = reader.GetInt32(9)
            fila("PapeletasEntregadas") = reader.GetInt32(10)
            fila("PapeletasDevueltas") = reader.GetInt32(11)
            fila("LoteriaJugada") = reader.GetDouble(12)
            fila("DecimosJugados") = reader.GetInt32(13)
            fila("ImporteTotal") = reader.GetDouble(14)
            fila("JuegaEmpresa") = reader.GetDouble(15)
            fila("ImportePremioPapeleta") = reader.GetDouble(16)
            fila("ImportePagado") = reader.GetDouble(17)
            fila("ImportePremioNum1") = reader.GetDouble(18)
            fila("ImportePremioNum2") = reader.GetDouble(19)

            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function

    Public Function GetSorteoEjercicio(ejercicio)
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()
        Dim query As String = "SELECT * FROM sorteos WHERE ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("IdSorteo") = reader.GetInt32(0)
            fila("Ejercicio") = reader.GetInt32(1)
            fila("TipoSorteo") = reader.GetString(2)
            fila("Fecha") = reader.GetDateTime(3)
            fila("IdAdmon") = reader.GetInt32(4)
            fila("NumeroJugado") = reader.GetInt32(5)
            fila("ImporteDecimo") = reader.GetDouble(6)
            fila("ImportePapeleta") = reader.GetDouble(7)
            fila("PapeletasImpresas") = reader.GetInt32(8)
            fila("PapeletasEntregadas") = reader.GetInt32(9)
            fila("PapeletasDevueltas") = reader.GetInt32(10)
            fila("LoteriaJugada") = reader.GetDouble(11)
            fila("DecimosJugados") = reader.GetInt32(12)
            fila("ImporteTotal") = reader.GetDouble(13)
            fila("JuegaEmpresa") = reader.GetDouble(14)
            fila("ImportePremioPapeleta") = reader.GetDouble(15)
            fila("ImportePagado") = reader.GetDouble(16)
            fila("NumeroJugado2") = reader.GetInt32(17)
            fila("ImportePremioNum1") = reader.GetDouble(18)
            fila("ImportePremioNum2") = reader.GetDouble(19)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    Public Sub InsertarSorteo(fila As DataRow)
        conn.Open()
        Dim query As String = "INSERT INTO sorteos (IdSorteo, Ejercicio, TipoSorteo, Fecha, IdAdmon,
                               NumeroJugado, ImporteDecimo, ImportePapeleta, PapeletasImpresas,
                               PapeletasEntregadas,PapeletasDevueltas, LoteriaJugada, DecimosJugados,
                               ImporteTotal, JuegaEmpresa, ImportePremioPapeleta, ImportePagado, NumeroJugado2,
                               ImportePremioNum1, ImportePremioNum2)
                               VALUES (@IdSorteo, @Ejercicio, @TipoSorteo, @Fecha, @IdAdmon, @NumeroJugado,
                               @ImporteDecimo, @ImportePapeleta, @PapeletasImpresas, @PapeletasEntregadas,
                               @PapeletasDevueltas, @LoteriaJugada, @DecimosJugados, @ImporteTotal, @JuegaEmpresa,
                               @ImportePremioPapeleta,@ImportePagado, @NumeroJugado2, @ImportePremioNum1, 
                               @ImportePremioNum2)"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@IdSorteo", fila("IdSorteo"))
        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@TipoSorteo", fila("TipoSorteo"))
        cmd.Parameters.AddWithValue("@Fecha", fila("Fecha"))
        cmd.Parameters.AddWithValue("@IdAdmon", fila("IdAdmon"))
        cmd.Parameters.AddWithValue("@NumeroJugado", fila("NumeroJugado"))
        cmd.Parameters.AddWithValue("@ImporteDecimo", fila("ImporteDecimo"))
        cmd.Parameters.AddWithValue("@ImportePapeleta", fila("ImportePapeleta"))
        cmd.Parameters.AddWithValue("@PapeletasImpresas", fila("PapeletasImpresas"))
        cmd.Parameters.AddWithValue("@PapeletasEntregadas", fila("PapeletasEntregadas"))
        cmd.Parameters.AddWithValue("@PapeletasDevueltas", fila("PapeletasDevueltas"))
        cmd.Parameters.AddWithValue("@LoteriaJugada", fila("LoteriaJugada"))
        cmd.Parameters.AddWithValue("@DecimosJugados", fila("DecimosJugados"))
        cmd.Parameters.AddWithValue("@ImporteTotal", fila("ImporteTotal"))
        cmd.Parameters.AddWithValue("@JuegaEmpresa", fila("JuegaEmpresa"))
        cmd.Parameters.AddWithValue("@ImportePremioPapeleta", fila("ImportePremioPapeleta"))
        cmd.Parameters.AddWithValue("@ImportePagado", fila("ImportePagado"))
        cmd.Parameters.AddWithValue("@NumeroJugado2", fila("NumeroJugado2"))
        cmd.Parameters.AddWithValue("@ImportePremioNum1", fila("ImportePremioNum1"))
        cmd.Parameters.AddWithValue("@ImportePremioNum2", fila("ImportePremioNum2"))
        Try
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar sorteo " & ex.Message)
        End Try

    End Sub

    Public Sub EditarSorteo(fila As DataRow)
        conn.Open()
        Dim query As String = "UPDATE sorteos SET PapeletasEntregadas=@PapeletasEntregadas,
                              PapeletasDevueltas=@PapeletasDevueltas, LoteriaJugada=@LoteriaJugada, 
                              DecimosJugados=@DecimosJugados, ImporteTotal=@ImporteTotal, JuegaEmpresa=@JuegaEmpresa,
                              ImportePremioPapeleta=@ImportePremioPapeleta, NumeroJugado=@NumeroJugado,
                              NumeroJugado2=@NumeroJugado2, ImportepremioNum1=@ImportePremioNum1,
                              ImportePremioNum2=@ImportePremioNum2
                              WHERE IdSorteo=@IdSorteo"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@IdSorteo", fila("IdSorteo"))
        cmd.Parameters.AddWithValue("@PapeletasEntregadas", fila("PapeletasEntregadas"))
        cmd.Parameters.AddWithValue("@PapeletasDevueltas", fila("PapeletasDevueltas"))
        cmd.Parameters.AddWithValue("@LoteriaJugada", fila("LoteriaJugada"))
        cmd.Parameters.AddWithValue("@DecimosJugados", fila("DecimosJugados"))
        cmd.Parameters.AddWithValue("@ImporteTotal", fila("ImporteTotal"))
        cmd.Parameters.AddWithValue("@JuegaEmpresa", fila("JuegaEmpresa"))
        cmd.Parameters.AddWithValue("@ImportePremioPapeleta", fila("ImportePremioPapeleta"))
        'cmd.Parameters.AddWithValue("@ImportePagado", fila("ImportePagado"))
        cmd.Parameters.AddWithValue("@NumeroJugado", fila("NumeroJugado"))
        cmd.Parameters.AddWithValue("@NumeroJugado2", fila("NumeroJugado2"))
        cmd.Parameters.AddWithValue("@ImportePremioNum1", fila("ImportePremioNum1"))
        cmd.Parameters.AddWithValue("@ImportePremioNum2", fila("ImportePremioNum2"))
        Try
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar sorteo " & ex.Message)
            conn.Close()
        End Try

    End Sub

    Public Sub ActualizarPagado(idsorteo, pagado)
        conn.Open()
        Dim query As String = "UPDATE sorteos SET ImportePagado= " & pagado &
                              " WHERE IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Try
            cmd.ExecuteNonQuery()
            conn.Close()
        Catch ex As Exception
            MsgBox("Error al actualizar Importe Pagado en sorteo activo" & ex.Message)
        End Try

    End Sub
    Public Function ImporteTotal(ejercicio, idsorteo)
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT ImporteTotal FROM sorteos WHERE Ejercicio =" & ejercicio &
                               " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImporteTotal") = reader.GetDouble(0)

                total = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If
    End Function

    Public Function ImportePagadoSorteo(ejercicio, idsorteo)
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT ImportePagado FROM sorteos WHERE Ejercicio =" & ejercicio &
                               " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImportePagado") = reader.GetDouble(0)

                total = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If
    End Function

    Public Function ImportePagadoTotal(ejercicio)
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(ImportePagado) FROM sorteos WHERE Ejercicio =" & ejercicio

        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else

                fila("ImportePagado") = reader.GetDouble(0)

                total = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()

                Return total
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If
    End Function
    Public Function ImportePptaPremio(idsorteo, ejercicio)
        Dim importe As Double
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()

        Dim query As String = "SELECT ImportePremioPapeleta FROM sorteos WHERE Ejercicio =" &
                               ejercicio & " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else
                fila("ImportePremioPapeleta") = reader.GetDouble(0)
                importe = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()
                Return importe
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ImporteDecimo(idsorteo, ejercicio)
        Dim importe As Double
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()

        Dim query As String = "SELECT ImporteDecimo, ImportePapeleta, ImportePremioPapeleta, NumeroJugado, 
                               NumeroJugado2, ImportePremioNum1, ImportePremioNum2
                               FROM sorteos WHERE Ejercicio =" & ejercicio & " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else
                fila("ImporteDecimo") = reader.GetDouble(0)
                fila("ImportePapeleta") = reader.GetDouble(1)
                fila("ImportePremioPapeleta") = reader.GetDouble(2)
                fila("NumeroJugado") = reader.GetInt32(3)
                fila("NumeroJugado2") = reader.GetInt32(4)
                fila("ImportePremioNum1") = reader.GetDouble(5)
                fila("ImportePremioNum2") = reader.GetDouble(6)
                'importe = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()
                Return fila
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ImportePapeleta(idsorteo, ejercicio)
        Dim importe As Double
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()

        Dim query As String = "SELECT ImportePapeleta FROM sorteos WHERE Ejercicio =" & ejercicio &
                               " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                importe = 0
                Return importe
            Else
                fila("ImportePapeleta") = reader.GetDouble(0)
                importe = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()
                Return importe
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function DecimosComprados(idsorteo, ejercicio)
        Dim resultado As Double
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()

        Dim query As String = "SELECT DecimosJugados FROM sorteos WHERE Ejercicio =" & ejercicio &
                               " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else
                fila("DecimosJugados") = reader.GetDouble(0)
                resultado = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()
                Return resultado
            End If
        Else
            MsgBox("No hay décimos jugados para este sorteo.")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function ImportePpta(idsorteo, ejercicio)
        Dim importe As Double
        Dim stabla As DataTable = Entidades.SorteosEntidad.TablaSorteos()
        conn.Open()

        Dim query As String = "SELECT ImportePapeleta FROM sorteos WHERE Ejercicio =" &
                               ejercicio & " AND IdSorteo= " & idsorteo
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        If reader.Read Then
            Dim fila As DataRow = stabla.NewRow
            If (IsDBNull(reader(0))) Then
                reader.Close()
                conn.Close()
                Return Nothing
            Else
                fila("ImportePapeleta") = reader.GetDouble(0)
                importe = reader.GetDouble(0)
                stabla.Rows.Add(fila)
                reader.Close()
                conn.Close()
                Return importe
            End If
        Else
            MsgBox("No hay registros de este sorteo, añadir uno.")
            conn.Close()
            Return Nothing
        End If

    End Function

    Public Function JugadoComisionEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.SorteosEntidad.TablaSorteos
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(JuegaEmpresa) FROM sorteos WHERE ejercicio=" & ejercicio
        Dim cmd As New MySqlCommand(query, conn)

        Try
            total = cmd.ExecuteScalar()
        Catch ex As Exception
            total = 0
        End Try

        conn.Close()
        Return total

    End Function

End Class
