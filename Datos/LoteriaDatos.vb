Imports MySql.Data.MySqlClient
Public Class LoteriaDatos
    Public Property VendedorEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()


    Public Function ObtenerVendedoresLoteria()
        Dim stabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        conn.Open()
        Dim query As String = "SELECT * FROM vendedores"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        'If stabla.Rows.Count = 0 Then
        '    MsgBox("No hay vendedores. Deberías importar registros", vbOKOnly, vbObjectError)
        '    Return False
        'End If

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Ejercicio") = reader.GetInt32(0)
            fila("Codigo") = reader.GetInt32(1)
            fila("Nombre") = reader.GetString(2)
            fila("Apellidos") = reader.GetString(3)
            fila("Comision") = reader.GetInt32(4)
            fila("CuotaLoteria") = reader.GetBoolean(5)
            fila("LoteriaAsignada") = reader.GetDouble(6)
            fila("Liquidado") = reader.GetDouble(7)
            fila("ACuota") = reader.GetDouble(8)
            fila("Saldo") = reader.GetDouble(9)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    ' Insertar nuevo fallero
    Public Sub InsertarVendedor(fila As DataRow)

        conn.Open()
        Dim query As String = "INSERT INTO vendedores (Ejercicio, Codigo, Nombre, Apellidos, Comision, CuotaLoteria, 
                                LoteriaAsignada, Liquidado, ACuota, Saldo) 
                                  VALUES (@Ejercicio, @Codigo, @Nombre, @Apellidos, @Comision, @CuotaLoteria, 
                                    @LoteriaAsignada, @Liquidado, @ACuota, @Saldo)"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@Codigo", fila("Codigo"))
        cmd.Parameters.AddWithValue("@Nombre", fila("Nombre"))
        cmd.Parameters.AddWithValue("@Apellidos", fila("Apellidos"))
        cmd.Parameters.AddWithValue("@Comision", fila("Comision"))
        cmd.Parameters.AddWithValue("@CuotaLoteria", fila("CuotaLoteria"))
        cmd.Parameters.AddWithValue("@LoteriaAsignada", fila("LoteriaAsignada"))
        cmd.Parameters.AddWithValue("@ACuota", fila("ACuota"))
        cmd.Parameters.AddWithValue("@Liquidado", fila("Liquidado"))
        cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    ' Editar vendedor existente
    Public Sub EditarVendedor(fila As DataRow)

        conn.Open()
        Dim query As String = "UPDATE vendedores SET  CuotaLoteria = @CuotaLoteria, LoteriaAsignada= @LoteriaAsignada, 
                               Liquidado=@Liquidado, ACuota=@ACuota, Saldo=@Saldo WHERE Codigo = @Codigo"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@CuotaLoteria", fila("CuotaLoteria"))
        cmd.Parameters.AddWithValue("@LoteriaAsignada", fila("LoteriaAsignada"))
        cmd.Parameters.AddWithValue("@Liquidado", fila("Liquidado"))
        cmd.Parameters.AddWithValue("@ACuota", fila("ACuota"))
        cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))
        cmd.Parameters.AddWithValue("@Codigo", fila("Codigo"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub


    ' Editar vendedor desde DetallesVentaLoteria existente
    Public Sub EditarVendedorDetallesVenta(fila As DataRow)

        conn.Open()
        Dim query As String = "UPDATE vendedores SET Liquidado=@Liquidado, ACuota=@ACuota, Saldo=@Saldo 
                                WHERE Codigo = @Codigo AND Ejercicio=@Ejercicio"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@Liquidado", fila("Liquidado"))
        cmd.Parameters.AddWithValue("@ACuota", fila("ACuota"))
        cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))
        cmd.Parameters.AddWithValue("@Codigo", fila("Codigo"))
        cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub


    ' Eliminar fallero
    Public Sub EliminarVendedor(fila As DataRow)

        conn.Open()
        Dim query As String = "DELETE FROM vendedores WHERE Codigo = @Codigo"

        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@Codigo", fila("Codigo"))
        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Sub ImportarNuevosVendedores()
        If conn.State() = ConnectionState.Open Then
            conn.Close()
        End If
        Dim stabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        conn.Open()
        Dim query As String = "INSERT INTO vendedores 
        (Ejercicio, Codigo, Nombre, Apellidos, Comision, CuotaLoteria)
        SELECT ANO_CEN, FALLERO_CODIGO, NOMBRE, APELLIDOS, TIPFAL, LOTERIA FROM fallero
        WHERE fallero.LOTERIA=1 AND fallero.BAJA=0"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()

        conn.Close()
        RellenarImportacion()


    End Sub

    Public Sub RellenarImportacion()

        conn.Open()
        Dim query As String = "UPDATE vendedores SET LoteriaAsignada=0,Liquidado=0,Acuota=0,Saldo=0"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.ExecuteNonQuery()
        conn.Close()

        conn.Open()
        Dim query1 As String = "UPDATE vendedores SET LoteriaAsignada= CASE 
                                                                            WHEN Comision = 1 THEN 750
                                                                            WHEN Comision = 3 THEN 510
                                                                            ELSE 0
                                                                        END"
        Dim cmd1 As New MySqlCommand(query1, conn)
        cmd1.ExecuteNonQuery()
        conn.Close()

        conn.Open()
        Dim query2 As String = "UPDATE vendedores SET Saldo= -(LoteriaAsignada)*0.2"

        Dim cmd2 As New MySqlCommand(query2, conn)
        cmd2.ExecuteNonQuery()
        conn.Close()

    End Sub

End Class
