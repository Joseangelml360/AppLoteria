
Imports Datos
Imports Entidades

Public Class VendedoresNegocio

    Private ReadOnly datosCenso As New CensoFalleroDatos
    Private ReadOnly datosLoteria As New LoteriaDatos
    Private ReadOnly datosvendedor As New VendedoresDatos

    Public Function ObtenerVendedoresCenso()
        Return datosCenso.ObtenerCensoFalleros()
    End Function

    Public Sub ImportarVendedores()
        datosLoteria.ImportarNuevosVendedores()
    End Sub

    Public Function ObtenerVendedores()

        Return datosLoteria.ObtenerVendedoresLoteria()

    End Function

    Public Function ObtenerNumeroMayores()
        Dim NumMayor As Integer = datosvendedor.GetVendedoresMayor()
        Return NumMayor
    End Function

    Public Function ObtenerNumeroJuveniles()
        Return datosvendedor.GetVendedoresJuvenil()
    End Function

    Public Function ObtenerVendedoresExtra(ejercicio As Integer)
        Return datosvendedor.GetVendedoresExtra(ejercicio)
    End Function

    Public Sub GuardarVendedor(ejercicio As Integer, codigo As Integer, nombre As String, apellidos As String,
                               comision As Integer, cuotaloteria As Boolean, valorasignado As Integer,
                               pagado As Double, acuotas As Double, saldo As Double)
        Dim cuotas As Double = acuotas

        'validaciones
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ArgumentException("El nombre no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(apellidos) Then
            Throw New ArgumentException("El campo apellidos no puede estar vacío.")
        End If
        If comision < 1 Or comision > 3 Then
            MsgBox("Comisión solo puede ser entre 1 y 3")
        End If
        If cuotaloteria Then
            If comision = 1 Then
                valorasignado = 750
            ElseIf comision = 3 Then
                valorasignado = 510
            End If
        Else
            valorasignado = 0
        End If

        'seguir con validaciones para el resto de valores

        Dim tabla As DataTable = VendedorEntidad.TablaVendedores()
        Dim fila As DataRow = tabla.NewRow()

        fila("Ejercicio") = ejercicio
        fila("Codigo") = codigo
        fila("Nombre") = nombre
        fila("Apellidos") = apellidos
        fila("CuotaLoteria") = cuotaloteria
        fila("Comision") = comision
        fila("LoteriaAsignada") = valorasignado
        fila("Liquidado") = pagado
        If pagado >= valorasignado Then
            saldo = (pagado - valorasignado) * 0.1
            cuotas = valorasignado * 0.2
        Else
            cuotas = pagado * 0.2
        End If
        fila("ACuota") = cuotas
        fila("Saldo") = saldo
        tabla.Rows.Add(fila)

        datosLoteria.InsertarVendedor(fila)

    End Sub

    Public Sub EditarVendedor(ejercicio As Integer, codigo As Integer, nombre As String, apellidos As String,
                              comision As Integer, cuotaloteria As Boolean, valorasignado As Integer, pagado As Double,
                              acuotas As Double, beneficio As Double)
        'validaciones
        If String.IsNullOrWhiteSpace(nombre) Then
            Throw New ArgumentException("El nombre no puede estar vacío.")
        End If
        If String.IsNullOrWhiteSpace(apellidos) Then
            Throw New ArgumentException("El campo apellidos no puede estar vacío.")
        End If
        If comision < 1 Or comision > 3 Then
            Throw New ArgumentException("Comisión solo puede ser 1, 2 o 3")
        End If
        If cuotaloteria Then
            If comision = 1 Then
                valorasignado = 750
            ElseIf comision = 3 Then
                valorasignado = 510
            ElseIf comision = 2 Then
                Throw New ArgumentException("Infantiles no tienen asignada cuota con loteria")
                cuotaloteria = False
            End If
        Else
            valorasignado = 0
        End If

        If pagado = Nothing Or pagado < 0 Then
            pagado = 0
        End If
        'seguir con validaciones para el resto de valores

        Dim tabla As DataTable = VendedorEntidad.TablaVendedores()
        Dim fila As DataRow = tabla.NewRow()
        fila("Ejercicio") = ejercicio
        fila("Codigo") = codigo
        fila("Nombre") = nombre
        fila("Apellidos") = apellidos
        fila("CuotaLoteria") = cuotaloteria
        fila("Comision") = comision
        fila("LoteriaAsignada") = valorasignado
        fila("Liquidado") = pagado
        If pagado >= valorasignado Then
            beneficio = (pagado - valorasignado) * 0.1
            acuotas = valorasignado * 0.2
        Else
            acuotas = pagado * 0.2
            beneficio = (pagado - valorasignado) * 0.2
        End If
        fila("ACuota") = acuotas
        fila("Saldo") = beneficio
        tabla.Rows.Add(fila)
        datosLoteria.EditarVendedor(fila)
    End Sub
    Public Sub EditarVendedorDetallesVentaLoteria(liquidado As Double, acuota As Double, saldo As Double,
                                                 codigo As Integer, ejercicio As Integer)

        Dim tabla As DataTable = VendedorEntidad.TablaVendedores
        Dim fila As DataRow = tabla.NewRow
        fila("Liquidado") = liquidado
        fila("ACuota") = acuota
        fila("Saldo") = saldo
        fila("Codigo") = codigo
        fila("Ejercicio") = ejercicio
        tabla.Rows.Add(fila)
        datosLoteria.EditarVendedorDetallesVenta(fila)


    End Sub
    Public Sub EliminarVendedor(Codigo As Integer)
        Dim tabla As DataTable = VendedorEntidad.TablaVendedores()
        Dim fila As DataRow = tabla.NewRow()
        fila("Codigo") = Codigo

        datosLoteria.EliminarVendedor(fila)
    End Sub

    Public Function GetlistaVendedores(ejercicio As Integer)
        Dim eje As Integer = ejercicio
        Return datosvendedor.ListaVendedores(eje)

    End Function

    Public Function GetVendorEjercicio(ejercicio, codigo)
        Return datosvendedor.GetVendorEjercicio(ejercicio, codigo)

    End Function

    Public Sub ActualizarVendor(ejercicio, codigo, liquidado, acuotas, saldo)

        'seguir con validaciones para el resto de valores

        Dim tabla As DataTable = VendedorEntidad.TablaVendedores()
        'Dim tabla As New DataTable
        Dim fila As DataRow = tabla.NewRow()
        fila("Ejercicio") = ejercicio
        fila("Codigo") = codigo
        fila("Liquidado") = liquidado
        fila("ACuota") = acuotas
        fila("Saldo") = saldo
        tabla.Rows.Add(fila)
        datosLoteria.EditarVendedor(fila)
    End Sub
End Class
