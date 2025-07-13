Imports MySql.Data.MySqlClient
Public Class VendedoresDatos
    Public Property VendedorEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion

    Public Function GetVendedoresMayor()

        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim numMayores As Integer

        Dim query As String = "SELECT COUNT(*) AS NumMayores FROM vendedores WHERE Comision=1"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            numMayores = Convert.ToInt32(cmd.ExecuteScalar()) ' Ejecuta y devuelve el número de registros
        Catch ex As Exception
            ' Manejo de errores si es necesario
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return numMayores
    End Function

    Public Function GetVendedoresJuvenil()

        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim numJuveniles As Integer

        Dim query As String = "SELECT COUNT(*) AS NumMayores FROM vendedores WHERE Comision=3"
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            numJuveniles = Convert.ToInt32(cmd.ExecuteScalar()) ' Ejecuta y devuelve el número de registros
        Catch ex As Exception
            ' Manejo de errores si es necesario
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return numJuveniles
    End Function

    Public Function GetVendedoresExtra(ejercicio As Integer)

        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim numExtra As Integer

        Dim query As String = "SELECT COUNT(*) AS NumExtra FROM vendedores WHERE CuotaLoteria= 0 
                               AND Ejercicio= " & ejercicio
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            numExtra = Convert.ToInt32(cmd.ExecuteScalar()) ' Ejecuta y devuelve el número de registros
        Catch ex As Exception
            ' Manejo de errores si es necesario
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
        Return numExtra
    End Function
    Public Function ListaVendedores(ejercicio As Integer)

        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim query As String = "SELECT * FROM vendedores WHERE ejercicio=" & ejercicio

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim fila As DataRow = tabla.NewRow()
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
                tabla.Rows.Add(fila)
            End While
            reader.Close()

        Catch ex As Exception
            ' Manejo de errores si es necesario
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return tabla

    End Function

    Public Function GetVendorEjercicio(ejercicio As Integer, codigo As Integer)

        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim query As String = "SELECT * FROM vendedores WHERE ejercicio=" & ejercicio & " AND Codigo= " & codigo

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(query, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim fila As DataRow = tabla.NewRow()
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
                tabla.Rows.Add(fila)
            End While
            reader.Close()

        Catch ex As Exception
            ' Manejo de errores si es necesario
            MsgBox("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try

        Return tabla

    End Function

    Public Sub ActualizarMovimientoVendor(fila As DataRow)
        conn.Open()
        Dim query As String = "UPDATE vendedores SET  Liquidado = @liquidado, ACuota= @acuota, 
                               Saldo=@saldo WHERE Ejercicio=@ejercicio AND Codigo = @codigo"

        Dim cmd As New MySqlCommand(query, conn)

        cmd.Parameters.AddWithValue("@ejercicio", fila("Ejercicio"))
        cmd.Parameters.AddWithValue("@Codigo", fila("Codigo"))
        cmd.Parameters.AddWithValue("@Liquidado", fila("Liquidado"))
        cmd.Parameters.AddWithValue("@ACuota", fila("ACuota"))
        cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))

        cmd.ExecuteNonQuery()
        conn.Close()

    End Sub

    Public Function TotalAcuotasEjercicio(ejercicio)
        Dim tabla As DataTable = Entidades.VendedorEntidad.TablaVendedores
        Dim total As Double
        conn.Open()
        Dim query As String = "SELECT SUM(Acuota) FROM vendedores WHERE ejercicio=" & ejercicio
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
