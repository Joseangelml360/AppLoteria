Imports MySql.Data.MySqlClient

Public Class LiquidacionDatos
    Public Property LiquidacionEntidad As Object
    ReadOnly conn As MySqlConnection = ConexionDatos.GetLoteriaConexion()

    Public Function ObtenerLiquidacion()
        Dim stabla As DataTable = Entidades.LiquidacionEntidad.TablaLiquidacion()

        conn.Open()
        Dim query As String = "SELECT * FROM liquidacion"
        Dim cmd As New MySqlCommand(query, conn)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Ejercicio") = reader.GetInt32(0)
            fila("Comprado") = reader.GetDouble(1)
            fila("Vendido") = reader.GetDouble(2)
            fila("Premios") = reader.GetDouble(3)
            fila("AbonoPremios") = reader.GetDouble(4)
            fila("ACuotas") = reader.GetDouble(5)
            fila("JugadoEmpresa") = reader.GetDouble(6)
            fila("Saldo") = reader.GetDouble(7)
            fila("BeneficioEmpresa") = reader.GetDouble(8)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla

    End Function

    Public Sub InsertarLiquidacionEjercicio(fila As DataRow, ejercicio As Integer)

        conn.Open()

        Dim queryborrar As String = "DELETE FROM liquidacion WHERE Ejercicio= " & ejercicio
        Dim command As New MySqlCommand(queryborrar, conn)

        command.ExecuteNonQuery()
        conn.Close()

        conn.Open()

        Dim query As String = " INSERT INTO liquidacion (Ejercicio, Comprado, Vendido, Premios, AbonoPremios, Acuotas, 
                                JugadoEmpresa, Saldo, BeneficioEmpresa) 
                                VALUES(@Ejercicio, @Comprado, @Vendido, @Premios, @AbonoPremios, @Acuotas, 
                                @JugadoEmpresa, @Saldo, @BeneficioEmpresa)"

        Try
            Dim cmd As New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@Ejercicio", fila("Ejercicio"))
            cmd.Parameters.AddWithValue("@Comprado", fila("Comprado"))
            cmd.Parameters.AddWithValue("@Vendido", fila("Vendido"))
            cmd.Parameters.AddWithValue("@Premios", fila("Premios"))
            cmd.Parameters.AddWithValue("@AbonoPremios", fila("AbonoPremios"))
            cmd.Parameters.AddWithValue("@Acuotas", fila("Acuotas"))
            cmd.Parameters.AddWithValue("@JugadoEmpresa", fila("JugadoEmpresa"))
            cmd.Parameters.AddWithValue("@Saldo", fila("Saldo"))
            cmd.Parameters.AddWithValue("@BeneficioEmpresa", fila("BeneficioEmpresa"))

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error al  guardar cálculos de liquidación ejercicio:" & ex.Message)
            conn.Close()
            Exit Sub
        Finally
            conn.Close()
        End Try

    End Sub

    Public Function GetLiquidacionFilter(ejercicio As Integer)
        Dim stabla As DataTable = Entidades.LiquidacionEntidad.TablaLiquidacion()

        conn.Open()
        Dim query As String = "SELECT * FROM liquidacion WHERE Ejercicio=@ejercicio"
        Dim cmd As New MySqlCommand(query, conn)
        cmd.Parameters.AddWithValue("@ejercicio", ejercicio)
        Dim reader As MySqlDataReader = cmd.ExecuteReader()

        While reader.Read()
            Dim fila As DataRow = stabla.NewRow()
            fila("Ejercicio") = reader.GetInt32(0)
            fila("Comprado") = reader.GetDouble(1)
            fila("Vendido") = reader.GetDouble(2)
            fila("Premios") = reader.GetDouble(3)
            fila("AbonoPremios") = reader.GetDouble(4)
            fila("ACuotas") = reader.GetDouble(5)
            fila("JugadoEmpresa") = reader.GetDouble(6)
            fila("Saldo") = reader.GetDouble(7)
            fila("BeneficioEmpresa") = reader.GetDouble(8)
            stabla.Rows.Add(fila)
        End While

        reader.Close()
        conn.Close()
        Return stabla
    End Function
End Class
