Imports Negocio

Public Class FrmDetalleVentasLoteria
    Public ReadOnly negocio As New DetalleVentasLoteriaNegocio
    Public ReadOnly vendor As New VendedoresNegocio
    Public ReadOnly misorteo As New SorteosNegocio
    Public ReadOnly miejercicio As New EjercicioActivoNegocio
    Public ReadOnly libro As New LibroDiarioNegocio
    Public ReadOnly recalc As New RecalcularSorteosNegocio
    Public fila As Integer

    'Public estado As Integer
    Private Sub FrmDetalleVentasLoteria_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Limpiar()
        Me.LblEjercicio.Text = miejercicio.GetEjercicioActivo()
        Me.LblImpPremioPpta.Visible = False
        Me.TxtImpPremioPpta.Visible = False
        Me.DgvSorteos.Visible = False
        Me.DgvVendedores.Visible = False
        Me.TxtBuscarVendor.Visible = False
        Me.BtnSelectSorteo.Enabled = False
        Me.BtnSelectVendor.Enabled = False
        Me.RbtnPago.Checked = 1
        Me.RbtnEfectivo.Checked = 1
        CargarDatos()

    End Sub

    Private Sub CargarDatos()

        Me.DgvDetVentLot.DataSource = negocio.GetDetallesVentaLoteria

        With DgvDetVentLot
            .Columns(0).Visible = False
            .Columns(1).Visible = False
        End With

        Me.DgvDetVentLot.Refresh()

        Limpiar()

        If CInt(Me.TxtIdVendor.Text) > 0 Then
            CargarDatosVendor()
        End If

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click

        Me.BtnAñadir.Enabled = False
        Me.BtnSelectSorteo.Enabled = True
        Limpiar()

    End Sub


    Private Sub BtnSelectVendor_Click(sender As Object, e As EventArgs) Handles BtnSelectVendor.Click
        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)

        Me.DgvVendedores.Visible = True
        Me.DgvVendedores.Height = 200
        Me.DgvVendedores.Width = 400
        Me.DgvVendedores.DataSource = vendor.GetlistaVendedores(ejercicio)
        Me.TxtBuscarVendor.Visible = True
        Me.TxtBuscarVendor.Focus()
        Me.BtnSelectVendor.Enabled = False

        With DgvVendedores
            .Columns(0).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
        End With

    End Sub

    Private Sub DgvVendedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVendedores.CellContentClick
        Dim beneficio, asignado, liquidado As Double
        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)
        Dim codigo As Integer = Me.DgvVendedores.CurrentRow.Cells("Codigo").Value

        Me.DgvVendedores.Visible = False
        Me.TxtBuscarVendor.Visible = False
        Me.DgvVendedores.DataSource = vendor.GetVendorEjercicio(ejercicio, codigo)
        Me.DgvVendedores.Refresh()

        Me.TxtIdVendor.Text = Me.DgvVendedores.CurrentRow.Cells("Codigo").Value
        Me.TxtNombre.Text = Me.DgvVendedores.CurrentRow.Cells("Nombre").Value
        Me.TxtApellidos.Text = Me.DgvVendedores.CurrentRow.Cells("Apellidos").Value
        Me.ChkLoteria.Checked = Me.DgvVendedores.CurrentRow.Cells("CuotaLoteria").Value
        Me.TxtLoteriaAsignada.Text = DgvVendedores.CurrentRow.Cells("LoteriaAsignada").Value
        Me.TxtAcuotas.Text = DgvVendedores.CurrentRow.Cells("Acuota").Value
        Me.TxtSaldo.Text = DgvVendedores.CurrentRow.Cells("Saldo").Value
        Me.TxtLiquidado.Text = DgvVendedores.CurrentRow.Cells("Liquidado").Value


        'Calcular beneficio
        asignado = Me.DgvVendedores.CurrentRow.Cells("LoteriaAsignada").Value
        liquidado = DgvVendedores.CurrentRow.Cells("Liquidado").Value
        beneficio = (liquidado - asignado) * 0.1
        If beneficio > 0 Then
            Me.TxtBenefVendor.Text = beneficio
        Else
            Me.TxtBenefVendor.Text = 0
        End If
        Me.Panel1.Visible = True
        Me.BtnGuardar.Enabled = True
        Me.BtnSelectVendor.Enabled = True

        CargarDetallesVendor()
        CalcularResumenSorteoVendor()
        Me.RbtnPago.Focus()


    End Sub

    Private Sub BtnSelectSorteo_Click(sender As Object, e As EventArgs) Handles BtnSelectSorteo.Click
        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)

        Me.DgvVendedores.Visible = False
        Me.DgvSorteos.Visible = True
        Me.DgvSorteos.Height = 200
        Me.DgvSorteos.Width = 300

        Me.DgvSorteos.DataSource = misorteo.GetSorteoEjeActivo(ejercicio)
        With DgvSorteos
            .Columns(0).Width = 50
            .Columns(1).Visible = False
            .Columns(4).Visible = False
            .Columns(5).Visible = False
            .Columns(6).Visible = False
            .Columns(7).Visible = False
            .Columns(8).Visible = False
            .Columns(9).Visible = False
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False
            .Columns(13).Visible = False
            .Columns(14).Visible = False
            .Columns(15).Visible = False
        End With

        Me.TxtPptasEntregadas.Text = 0
        Me.TxtPptasDevueltas.Text = 0
        Me.TxtImporte.Text = 0
        Me.TxtNumPptasPremiadas.Text = 0
        Me.TxtImportePptasPremiadas.Text = 0

    End Sub

    Private Sub DgvSorteos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSorteos.CellContentClick
        fila = DgvSorteos.CurrentRow.Index

        Me.TxtIdSorteo.Text = DgvSorteos.CurrentRow.Cells("IdSorteo").Value
        Me.TxtNombreSorteo.Text = DgvSorteos.CurrentRow.Cells("TipoSorteo").Value
        Me.TxtFechaSorteo.Text = DgvSorteos.CurrentRow.Cells("Fecha").Value.ToShortDateString()
        Me.TxtImportePpta.Text = DgvSorteos.CurrentRow.Cells("ImportePapeleta").Value
        Me.TxtImpPremioPpta.Text = DgvSorteos.CurrentRow.Cells("ImportepremioPapeleta").Value
        Me.TxtNum1.Text = DgvSorteos.CurrentRow.Cells("NumeroJugado").Value
        Me.TxtNum2.Text = DgvSorteos.CurrentRow.Cells("NumeroJugado2").Value
        Me.TxtImportePremio1.Text = DgvSorteos.CurrentRow.Cells("ImportePremioNum1").Value
        Me.TxtImportePremio2.Text = DgvSorteos.CurrentRow.Cells("ImportePremioNum2").Value

        Me.DgvSorteos.Visible = False
        If Val(Me.TxtImpPremioPpta.Text) > 0 Then
            Me.TxtImpPremioPpta.Visible = True
            Me.LblImpPremioPpta.Visible = True
            Me.TxtNum1.Visible = True
            Me.LblNum1.Visible = True
            Me.TxtNum2.Visible = True
            Me.LblNum2.Visible = True
            Me.TxtImportePremio1.Visible = True
            Me.LblPremio1.Visible = True
            Me.TxtImportePremio2.Visible = True
            Me.LblPremio2.Visible = True
        Else
            Me.TxtImpPremioPpta.Visible = False
            Me.LblImpPremioPpta.Visible = False
            Me.TxtNum1.Visible = False
            Me.LblNum1.Visible = False
            Me.TxtNum2.Visible = False
            Me.LblNum2.Visible = False
            Me.TxtImportePremio1.Visible = False
            Me.LblPremio1.Visible = False
            Me.TxtImportePremio2.Visible = False
            Me.LblPremio2.Visible = False
        End If

        CalcularTotalSorteo(fila)
    End Sub

    Private Function CalcularTotalSorteo(fila)
        Dim importetotal, importepagado, importedecimo, pptasliquidado, totalsaldosorteo As Double
        Dim pptasreservadas, pptasimpresas, pptasentregadas, pptasdevueltas, pptasdisponibles As Integer
        Dim eje As Integer = CInt(Me.LblEjercicio.Text)

        Me.DgvSorteos.DataSource = misorteo.GetSorteoEjeActivo(eje)
        Me.DgvSorteos.Refresh()

        importetotal = DgvSorteos.Rows(fila).Cells("ImporteTotal").Value
        importepagado = DgvSorteos.Rows(fila).Cells("ImportePagado").Value
        importedecimo = DgvSorteos.Rows(fila).Cells("ImporteDecimo").Value
        pptasimpresas = DgvSorteos.Rows(fila).Cells("PapeletasImpresas").Value
        pptasentregadas = DgvSorteos.Rows(fila).Cells("PapeletasEntregadas").Value
        pptasdevueltas = DgvSorteos.Rows(fila).Cells("PapeletasDevueltas").Value
        If importepagado > 0 Then
            pptasreservadas = (importepagado / 0.8) / DgvSorteos.CurrentRow.Cells("ImportePapeleta").Value
            pptasdisponibles = pptasreservadas - pptasentregadas - pptasdevueltas
        Else
            pptasreservadas = pptasimpresas
            pptasdisponibles = pptasimpresas - pptasentregadas - pptasdevueltas
        End If


        Me.TxtPptasReservadasorteo.Text = pptasimpresas
        Me.TxtPptasAVentaSorteo.Text = pptasentregadas - pptasdevueltas
        Me.TxtPptasDisponiblesSorteo.Text = pptasdisponibles

        'De la tabla detallesventaloteria
        Dim fila2 As DataRow = negocio.ObtenerResumenSorteo(CInt(Me.TxtIdSorteo.Text), eje)
        pptasliquidado = fila2("Liquidado") * 0.8
        If importepagado > 0 Then
            totalsaldosorteo = pptasliquidado - importepagado
        Else
            totalsaldosorteo = pptasliquidado - importetotal
        End If

        Me.TxtPptasLiquidado.Text = pptasliquidado
        Me.TxtTotalSaldoSorteo.Text = totalsaldosorteo

        Me.BtnSelectVendor.Enabled = True
        Me.BtnCancelar.Enabled = True
        Me.BtnGuardar.Enabled = True

        CargarDetallesSorteo()

        Return Nothing

    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()

    End Sub

    Private Sub Limpiar()
        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = 0
            End If
        Next
        Me.ChkLoteria.Checked = 0
        Me.TxtNombre.Text = ""
        Me.TxtApellidos.Text = ""
        Me.TxtNombreSorteo.Text = ""
        Me.BtnAñadir.Enabled = True
        Me.BtnCancelar.Enabled = False
        Me.BtnGuardar.Enabled = False
        Me.LblImpPremioPpta.Visible = False
        Me.TxtImpPremioPpta.Visible = False

        For Each c As Control In Panel2.Controls
            If TypeOf c Is TextBox Then c.Text = 0
        Next
        For Each c As Control In Panel5.Controls
            If TypeOf c Is TextBox Then c.Text = 0
        Next
        'Me.DgvDetVentLot.DataSource = Nothing
        Me.DgvDetVentLot.Refresh()

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim Id, Ejercicio, CodigoVendedor, IdSorteo, PptasEntregadas, PptasDevueltas, PapeletasPremiadas As Integer
        Dim ImportePpta, ImportePremiadas, ImporteEntregado, liquidado, acuota, saldo, saldoSorteo As Double
        Dim FechaApunte As Date
        Dim TipoSorteo As String

        Dim entradasalida, cajabanco, concepto As String 'variables para el libro diario
        Dim importe, debe, haber, saldolibro As Double
        cajabanco = ""
        concepto = ""
        entradasalida = ""
        Calcular()

        If DgvDetVentLot.RowCount - 1 = 0 Then
            Id = 1
            MsgBox("primer registro")
        End If

        Ejercicio = CInt(Me.LblEjercicio.Text)
        CodigoVendedor = CInt(Me.TxtIdVendor.Text)
        IdSorteo = CInt(Me.TxtIdSorteo.Text)
        PptasEntregadas = CInt(Me.TxtPptasEntregadas.Text)
        PptasDevueltas = CInt(Me.TxtPptasDevueltas.Text)
        PapeletasPremiadas = CInt(Me.TxtNumPptasPremiadas.Text)
        ImportePpta = Convert.ToDouble(Me.TxtImportePpta.Text)
        ImporteEntregado = Convert.ToDouble(Me.TxtImporte.Text)
        ImportePremiadas = Convert.ToDouble(Me.TxtImportePptasPremiadas.Text)
        saldoSorteo = Convert.ToDouble(Me.TxtSaldoSorteo.Text)

        FechaApunte = Today()
        TipoSorteo = Me.TxtNombreSorteo.Text
        'Para tabla vendedores
        liquidado = Convert.ToDouble(Me.TxtLiquidado.Text)
        acuota = Convert.ToDouble(Me.TxtAcuotas.Text)
        saldo = Convert.ToDouble(Me.TxtSaldo.Text)

        'Para tabla librodiario
        saldolibro = libro.ObtenerSaldo(Ejercicio)
        If RbtnBanco.Checked Then cajabanco = "B"
        If RbtnEfectivo.Checked Then cajabanco = "C"

        If RbtnAbono.Checked Then
            entradasalida = "S"
            concepto = "Abono Premios " & TxtNombre.Text & " " & TxtApellidos.Text & ", sorteo " & TxtFechaSorteo.Text
            importe = ImportePremiadas
            debe = ImportePremiadas
            haber = 0
            saldolibro -= ImportePremiadas
        End If

        If RbtnPago.Checked Then
            entradasalida = "E"
            concepto = "Pago loteria " & TxtNombre.Text & " " & TxtApellidos.Text & ", sorteo " & TxtFechaSorteo.Text
            importe = ImporteEntregado
            debe = 0
            haber = ImporteEntregado
            saldolibro += ImporteEntregado
        End If

        If RbtnCompensar.Checked Then
            entradasalida = "C"
            concepto = "Compensa loteria/premio " & TxtNombre.Text & " " & TxtApellidos.Text & ", sorteo " & TxtFechaSorteo.Text
            If saldoSorteo >= ImportePremiadas Then
                ImporteEntregado = ImportePremiadas
            Else
                ImporteEntregado = saldoSorteo
            End If

            debe = ImportePremiadas
            haber = ImporteEntregado
            importe = haber - debe
            saldolibro += importe
        End If

        'Resumen sorteo en detalles venta de loteria

        Try
            negocio.GuardarDetalleVentasLoteria(Id, Ejercicio, CodigoVendedor, FechaApunte, IdSorteo, TipoSorteo,
                                                ImportePpta, PptasEntregadas, PptasDevueltas, ImporteEntregado,
                                                PapeletasPremiadas, ImportePremiadas)
            MsgBox("Apunte registrado")

            Me.BtnGuardar.Enabled = False
            Try
                vendor.EditarVendedorDetallesVentaLoteria(liquidado, acuota, saldo, CodigoVendedor, Ejercicio)

            Catch ex As Exception
                MsgBox("Error al guardar datos de vendedor: " & ex.Message)
            End Try

        Catch ex As Exception
            MsgBox("Error. No se ha guardado el detalle: " & ex.Message)
        Finally
            CargarDetallesVendor()
            Me.DgvDetVentLot.Refresh()
            Me.BtnAñadir.Enabled = True
        End Try

        Try
            If importe > 0 Then
                libro.InsertarApunte(Ejercicio, FechaApunte, entradasalida, importe, cajabanco, concepto,
                                                 debe, haber, saldolibro)
            ElseIf RbtnCompensar.Checked Then
                libro.InsertarApunte(Ejercicio, FechaApunte, entradasalida, importe, cajabanco, concepto,
                                                 debe, haber, saldolibro)
            End If

        Catch ex As Exception
            MsgBox("Error al guardar libro diario. " & ex.Message)
        End Try
        CalcularResumenSorteoVendor()

        'Actualizar Idsorteo (entregadas, devueltas, importe total, decimos jugados, juega empresa,
        'loteriajugada, importepremiopapeleta...)

        Try
            recalc.ActualizarSorteo(IdSorteo, Ejercicio)
        Catch ex As Exception
            MsgBox("Error al actualizar sorteo. " & ex.Message)
        End Try

        CalcularTotalSorteo(fila)
        Me.TxtPptasEntregadas.Text = 0
        Me.TxtPptasDevueltas.Text = 0
        Me.TxtImporte.Text = 0
        Me.TxtNumPptasPremiadas.Text = 0
        Me.TxtImportePptasPremiadas.Text = 0
        Me.BtnGuardar.Enabled = False

    End Sub

    Private Sub CargarDatosVendor()
        Dim nEje As Integer = CInt(Me.LblEjercicio.Text)
        Dim Codigo As Integer = CInt(Me.TxtIdVendor.Text)
        Me.DgvVendedores.DataSource = vendor.GetVendorEjercicio(nEje, Codigo)
        Me.TxtLoteriaAsignada.Text = DgvVendedores.CurrentRow.Cells("LoteriaAsignada").Value
        Me.TxtAcuotas.Text = DgvVendedores.CurrentRow.Cells("ACuota").Value
        Me.TxtSaldo.Text = DgvVendedores.CurrentRow.Cells("Saldo").Value
        If CInt(TxtSaldo.Text) > 0 Then Me.TxtBenefVendor.Text = CInt(Me.TxtSaldo.Text)

    End Sub
    Private Sub CargarDetallesVendor()
        Me.DgvDetVentLot.DataSource = negocio.GetDetallesVentaLoteriaVendor(CInt(LblEjercicio.Text),
                                                                  CInt(TxtIdVendor.Text), CInt(TxtIdSorteo.Text))
    End Sub

    Private Sub CargarDetallesSorteo()

        Me.DgvDetVentLot.DataSource = negocio.GetDetallesVentaLoteriaSorteo(CInt(LblEjercicio.Text), CInt(TxtIdSorteo.Text))
        Me.DgvDetVentLot.Refresh()
    End Sub
    Private Sub Calcular()
        Dim liquidado, ImporteEntregado, Acuota, Saldo, LoteriaAsignada, Beneficio, ImportePremiadas As Double
        Dim PptasEntregadas, PptasDevueltas, PptasPremiadas As Integer

        liquidado = Convert.ToDouble(Me.TxtLiquidado.Text)
        ImporteEntregado = Convert.ToDouble(Me.TxtImporte.Text)
        Acuota = Convert.ToDouble(TxtAcuotas.Text)
        Saldo = Convert.ToDouble(Me.TxtSaldo.Text)
        LoteriaAsignada = Convert.ToDouble(Me.TxtLoteriaAsignada.Text)
        Beneficio = Convert.ToDouble(Me.TxtBenefVendor.Text)
        ImportePremiadas = Convert.ToDouble(Me.TxtImportePptasPremiadas.Text)
        PptasEntregadas = CInt(Me.TxtPptasEntregadas.Text)
        PptasDevueltas = CInt(Me.TxtPptasDevueltas.Text)
        PptasPremiadas = CInt(Me.TxtNumPptasPremiadas.Text)

        'Para tabla vendedores
        liquidado += ImporteEntregado
        Me.TxtLiquidado.Text = liquidado
        If liquidado >= LoteriaAsignada Then
            Acuota = LoteriaAsignada * 0.2
            Beneficio = (liquidado - LoteriaAsignada) * 0.1
            Saldo = Beneficio
        Else
            Acuota += ImporteEntregado * 0.2
            Saldo += ImporteEntregado * 0.2
        End If
        Me.TxtAcuotas.Text = Acuota
        Me.TxtBenefVendor.Text = Beneficio
        Me.TxtSaldo.Text = Saldo

    End Sub

    Private Sub RbtnPago_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnPago.CheckedChanged

        If RbtnPago.Checked Then
            Me.TxtImportePptasPremiadas.Text = 0
            Me.TxtImportePptasPremiadas.ReadOnly = True
            Me.TxtNumPptasPremiadas.ReadOnly = True
            Me.TxtNumPptasPremiadas.Text = 0
            Me.LblImpPremioPpta.Visible = False
            Me.TxtImpPremioPpta.Visible = False
            Me.TxtImporte.ReadOnly = False
            Me.TxtImporte.Focus()
        End If

    End Sub

    Private Sub RbtnAbono_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnAbono.CheckedChanged

        If RbtnAbono.Checked Then
            Me.TxtImportePptasPremiadas.ReadOnly = False
            Me.TxtNumPptasPremiadas.ReadOnly = False
            Me.LblImpPremioPpta.Visible = True
            Me.TxtImpPremioPpta.Visible = True
            Me.TxtImporte.ReadOnly = True
            Me.TxtImporte.Text = 0
            Me.TxtNumPptasPremiadas.Focus()
        End If

    End Sub

    Private Sub RbtnCompensar_CheckedChanged(sender As Object, e As EventArgs) Handles RbtnCompensar.CheckedChanged
        If RbtnCompensar.Checked Then
            Me.TxtImportePptasPremiadas.ReadOnly = False
            Me.TxtNumPptasPremiadas.ReadOnly = False
            Me.LblImpPremioPpta.Visible = True
            Me.TxtImpPremioPpta.Visible = True
            Me.TxtImporte.ReadOnly = False
            Me.TxtImporte.Text = 0
            Me.TxtNumPptasPremiadas.Focus()
        End If
    End Sub

    Private Sub TxtBuscarVendor_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscarVendor.TextChanged
        Dim vista As New DataView(vendor.ObtenerVendedores())

        If Me.TxtBuscarVendor.Text <> "" Then
            vista.RowFilter = $"Apellidos LIKE '%{TxtBuscarVendor.Text}%'"
        End If
        If TxtBuscarVendor.Text <> "" AndAlso IsNumeric(TxtBuscarVendor.Text) Then
            vista.RowFilter = $"Codigo = {TxtBuscarVendor.Text}"
        End If

        DgvVendedores.DataSource = vista
    End Sub

    Private Sub TxtNumPptasPremiadas_TextChanged(sender As Object, e As EventArgs) Handles TxtNumPptasPremiadas.Leave
        If Val(Me.TxtImpPremioPpta.Text) > 0 Then
            Me.TxtImportePptasPremiadas.Text = Val(Me.TxtImpPremioPpta.Text) * Val(Me.TxtNumPptasPremiadas.Text)
        Else
            Me.TxtNumPptasPremiadas.Text = 0
        End If

    End Sub

    Private Sub CalcularResumenSorteoVendor()
        Dim PptasEntregadas, PptasDevueltas, PptasPremiadas, ejercicio, codigovendor, idsorteo As Integer
        Dim Adeudado, EntregasParciales, Saldo As Double

        ejercicio = CInt(Me.LblEjercicio.Text)
        codigovendor = CInt(Me.TxtIdVendor.Text)
        idsorteo = CInt(Me.TxtIdSorteo.Text)
        Dim fila As DataRow = negocio.ObtenerResumenSorteoVendor(idsorteo, codigovendor, ejercicio)

        If fila IsNot Nothing Then
            PptasEntregadas = fila("PapeletasEntregadas")
            PptasDevueltas = fila("PapeletasDevueltas")
            EntregasParciales = fila("Liquidado")
            PptasPremiadas = fila("PapeletasPremiadas")
            Me.TxtEntregadasAnterior.Text = PptasEntregadas
            Me.TxtDevueltasAnterior.Text = PptasDevueltas
        Else
            MsgBox("No se encontraron datos resumen para este vendedor")
        End If

        Adeudado = (PptasEntregadas - PptasDevueltas) * Convert.ToDouble(Me.TxtImportePpta.Text)
        Saldo = EntregasParciales - Adeudado

        Me.TxtEntregadasAnterior.Text = PptasEntregadas
        Me.TxtDevueltasAnterior.Text = PptasDevueltas
        Me.TxtEntregaParcial.Text = EntregasParciales
        Me.TxtAdeudado.Text = Adeudado
        Me.TxtSaldoSorteo.Text = Saldo
        Me.TxtPptasPdtesAbono.Text = PptasEntregadas - PptasDevueltas - PptasPremiadas

    End Sub

End Class