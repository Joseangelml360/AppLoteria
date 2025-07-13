Imports MySql.Data.MySqlClient

Public Class DetallesSorteoVendedorDatos
    Public Property DetallesSorteoVendedorEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function GetDetallesSorteoVendorEjercicio(ejercicio)
        Dim stabla As DataTable = Entidades.DetallesSorteoVendedorEntidad.TablaDetallesSorteoVendedor
        conn.Open()
        Dim query As String = "SELECT * FROM detallesorteovendedor WHERE Ejercicio= " & ejercicio
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("IdSorteo") = reader.GetInt32(0)
            fila("IdVendedor") = reader.GetInt32(1)
            fila("Ejercicio") = reader.GetInt32(2)
            fila("PapeletasEntregadas") = reader.GetDouble(4)
            fila("PapeletasDevueltas") = reader.GetString(5)
            fila("TotalAdeudado") = reader.GetString(6)
            fila("EntregadoParcial") = reader.GetDouble(7)
            fila("Saldo") = reader.GetDouble(8)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function
    Public Function GetDetallesSorteoVendor(ejercicio, idsorteo, idvendor)
        Dim stabla As DataTable = Entidades.DetallesSorteoVendedorEntidad.TablaDetallesSorteoVendedor
        conn.Open()
        Dim query As String = "SELECT * FROM detallesorteovendedor WHERE Ejercicio= " & ejercicio & "IdSorteo= " &
                                idsorteo & "IdVendedor= " & idvendor
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("IdSorteo") = reader.GetInt32(0)
            fila("IdVendedor") = reader.GetInt32(1)
            fila("Ejercicio") = reader.GetInt32(2)
            fila("PapeletasEntregadas") = reader.GetDouble(4)
            fila("PapeletasDevueltas") = reader.GetString(5)
            fila("TotalAdeudado") = reader.GetString(6)
            fila("EntregadoParcial") = reader.GetDouble(7)
            fila("Saldo") = reader.GetDouble(8)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    Public Sub InsertarApunte(fila As DataRow)

        Try
            conn.Open()
            Dim query As String = "INSERT INTO detallesorteovendedor (IdSorteo, IdVendedor, Ejercicio, PapeletasEntregadas,
                                PapeletasDevueltas, TotalAdeudado, EntregadoParcial, Saldo)
                                VALUES(@IdSorteo, @IdVendedor, @Ejercicio, @PapeletasEntregadas,
                                @PapeletasDevueltas, @TotalAdeudado, @EntregadoParcial, @Saldo)"

            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@IdSorteo", fila("IdSorteo"))
            cmd.Parameters.AddWithValue("@IdVendedor", fila("IdVendedor"))
            cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
            cmd.Parameters.AddWithValue("@PapeletasEntregadas", fila("PapeletasEntregadas"))
            cmd.Parameters.AddWithValue("@PapeletasDevueltas", fila("PapeletasDevueltas"))
            cmd.Parameters.AddWithValue("@TotalAdeudado", fila("TotalAdeudado"))
            cmd.Parameters.AddWithValue("@EntregadoParcial", fila("EntregadoParcial"))
            cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se ha guardado el registro. Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub

    Public Sub ActualizarDetalleSorteoVendor(fila As DataRow)

        Try
            conn.Open()
            Dim query As String = "UPDATE detallesorteovendedor SET  PapeletasEntregadas = @PapeletasEntregadas, 
                                   PapeletasDevueltas= @PapeletasDevueltas, TotalAdeudado=@TotalAdeudado,
                                   EntregadoParcial=@EntregadoParcial, Saldo=@saldo 
                                   WHERE Ejercicio=@ejercicio AND IdVendedor = @IdVendedor"

            Dim cmd As New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@PapeletasEntregadas", fila("PapeletasEntregadas"))
            cmd.Parameters.AddWithValue("@PapeletasDevueltas", fila("PapeletasDevueltas"))
            cmd.Parameters.AddWithValue("@TotalAdeudado", fila("TotalAdeudado"))
            cmd.Parameters.AddWithValue("@EntregadoParcial", fila("EntregadoParcial"))
            cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No se ha guardado el registro. Error: " & ex.Message)
        Finally
            conn.Close()
        End Try



    End Sub

End Class
