Imports Negocio

Public Class FrmSorteos
    Public ReadOnly negocio As New SorteosNegocio
    Public ReadOnly eje As New EjercicioActivoNegocio
    Public ReadOnly miadmon As New AdministracionesNegocio
    Public ReadOnly misorteo As New TipoSorteoNegocio
    Public ReadOnly vendor As New VendedoresNegocio
    Public ReadOnly detalle As New DetalleVentasLoteriaNegocio
    Public ReadOnly recalc As New RecalcularSorteosNegocio
    Public ReadOnly pagos As New DetallesAdmonNegocio
    Private estado As Integer

    Private Sub FrmSorteos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblEjercicio.Text = eje.GetEjercicioActivo


        Me.Width = 1400
        Me.TxtEjercicio.Text = Me.LblEjercicio.Text
        Me.Panel1.Visible = False

        'Me.Line.Enabled = True
        'Me.Line.Text = " "
        'Me.Line.Height = 30
        'Me.Line.Width = 1


        TotalizarSorteos()
        Limpiar()
        Cargar() 'Cargar tabla sorteos en el Dgv

        Me.CboAdmon.DataSource = miadmon.GetAdmon
        Me.CboAdmon.DisplayMember = "Nombre"
        Me.CboAdmon.SelectedItem = "NumAdmon"
        Me.TxtIdAdmon.Text = ""

        Me.CboTipoSorteo.DataSource = misorteo.GetTipoSorteo
        Me.CboTipoSorteo.DisplayMember = "Tipo"
        Me.CboTipoSorteo.SelectedItem = "Tipo"
        Me.CboTipoSorteo.ValueMember = "Tipo"
        Me.TxtTipoSorteo.Text = ""

        Me.BtnGuardar.Enabled = False
    End Sub

    Private Sub Cargar()
        DgvSorteos.DataSource = negocio.GetSorteos

        If DgvSorteos.Rows.Count = 0 Then
            Me.LblRegistros.Visible = True
        Else
            Me.LblRegistros.Visible = False
        End If
        Me.DgvSorteos.Columns("IdSorteo").DisplayIndex = 0
        Me.DgvSorteos.Columns("Ejercicio").DisplayIndex = 1
        Me.DgvSorteos.Columns("TipoSorteo").DisplayIndex = 2
        Me.DgvSorteos.Columns("Fecha").DisplayIndex = 3
        Me.DgvSorteos.Columns("IdAdmon").DisplayIndex = 4
        Me.DgvSorteos.Columns("NumeroJugado").DisplayIndex = 5
        Me.DgvSorteos.Columns("NumeroJugado2").DisplayIndex = 6
        Me.DgvSorteos.Columns("ImporteDecimo").DisplayIndex = 7
        Me.DgvSorteos.Columns("ImportePapeleta").DisplayIndex = 8
        Me.DgvSorteos.Columns("PapeletasImpresas").DisplayIndex = 9
        Me.DgvSorteos.Columns("PapeletasEntregadas").DisplayIndex = 10
        Me.DgvSorteos.Columns("PapeletasDevueltas").DisplayIndex = 11
        Me.DgvSorteos.Columns("LoteriaJugada").DisplayIndex = 12
        Me.DgvSorteos.Columns("DecimosJugados").DisplayIndex = 13
        Me.DgvSorteos.Columns("ImporteTotal").DisplayIndex = 14
        Me.DgvSorteos.Columns("JuegaEmpresa").DisplayIndex = 15
        Me.DgvSorteos.Columns("ImportePremioPapeleta").DisplayIndex = 16
        Me.DgvSorteos.Columns("ImportePagado").DisplayIndex = 17
        Me.DgvSorteos.Columns("ImportePremioNum1").DisplayIndex = 18
        Me.DgvSorteos.Columns("ImportePremioNum2").DisplayIndex = 19


        Me.DgvSorteos.Columns("IdSorteo").HeaderText = "Sorteo"
        Me.DgvSorteos.Columns("Ejercicio").HeaderText = "Ejercicio"
        Me.DgvSorteos.Columns("TipoSorteo").HeaderText = "T.Sorteo"
        Me.DgvSorteos.Columns("Fecha").HeaderText = "Fecha"
        Me.DgvSorteos.Columns("IdAdmon").HeaderText = "Admon"
        Me.DgvSorteos.Columns("NumeroJugado").HeaderText = "Num.1"
        Me.DgvSorteos.Columns("NumeroJugado2").HeaderText = "Num.2"
        Me.DgvSorteos.Columns("ImporteDecimo").HeaderText = "Importe Decimo"
        Me.DgvSorteos.Columns("ImportePapeleta").HeaderText = "Importe Ppta"
        Me.DgvSorteos.Columns("PapeletasImpresas").HeaderText = "Pptas Impresas"
        Me.DgvSorteos.Columns("PapeletasEntregadas").HeaderText = "Pptas Entregadas"
        Me.DgvSorteos.Columns("PapeletasDevueltas").HeaderText = "Pptas Devueltas"
        Me.DgvSorteos.Columns("LoteriaJugada").HeaderText = "Total Pptas"
        Me.DgvSorteos.Columns("DecimosJugados").HeaderText = "Nº Decimos"
        Me.DgvSorteos.Columns("ImporteTotal").HeaderText = "Importe Decimos"
        Me.DgvSorteos.Columns("JuegaEmpresa").HeaderText = " Importe sobrante"
        Me.DgvSorteos.Columns("ImportePremioPapeleta").HeaderText = "Importe premio/Ppta"
        Me.DgvSorteos.Columns("ImportePagado").HeaderText = "Pagado Admon"
        Me.DgvSorteos.Columns("ImportePremioNum1").HeaderText = "Importe premio Num1"
        Me.DgvSorteos.Columns("ImportePremioNum2").HeaderText = "Importe premio Num2"

        Me.DgvSorteos.Columns(1).Visible = False

        Me.DgvSorteos.Columns(0).Width = 35
        'Me.DgvSorteos.Columns(2).Width = 50
        Me.DgvSorteos.Columns(3).Width = 70
        Me.DgvSorteos.Columns(4).Width = 50
        Me.DgvSorteos.Columns(5).Width = 50
        Me.DgvSorteos.Columns(6).Width = 40
        Me.DgvSorteos.Columns(7).Width = 40
        DgvSorteos.Refresh()

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Dim IdSorteo As Integer
        Me.Panel1.Visible = True
        Limpiar()
        If DgvSorteos.Rows.Count = 0 Then
            IdSorteo = 1
        Else
            Dim LastRow As Short = DgvSorteos.RowCount - 1
            If DgvSorteos.CurrentRow.Index > 0 Then
                DgvSorteos.ClearSelection()
                DgvSorteos.CurrentCell = DgvSorteos.Rows(LastRow).Cells(0)
                DgvSorteos.Rows(LastRow).Selected = True
                IdSorteo = DgvSorteos.Rows(LastRow).Cells(0).Value + 1
            End If
        End If
        Me.TxtIdSorteo.Text = IdSorteo
        Me.BtnGuardar.Enabled = False
        estado = 1
    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        Me.Panel1.Visible = True
        If DgvSorteos.Rows.Count = 0 Then
            MsgBox("No hay registros para editar")
            Exit Sub
        End If
        Me.BtnGuardar.Enabled = False
        With DgvSorteos.CurrentRow
            Me.TxtIdSorteo.Text = .Cells(0).Value
            Me.TxtEjercicio.Text = .Cells(1).Value
            Me.TxtTipoSorteo.Text = .Cells(2).Value
            Me.DtpFecha.Text = .Cells(3).Value
            Me.TxtIdAdmon.Text = .Cells(4).Value
            Me.TxtNumJugado.Text = .Cells(5).Value
            Me.TxtImporteDecimo.Text = .Cells(6).Value
            Me.TxtImportePpta.Text = .Cells(7).Value
            Me.TxtPptasImpresas.Text = .Cells(8).Value
            Me.TxtPptasEntregadas.Text = .Cells(9).Value
            Me.TxtPptasDevueltas.Text = .Cells(10).Value
            Me.TxtLotJugada.Text = .Cells(11).Value
            Me.TxtDecimosJugados.Text = .Cells(12).Value
            Me.TxtImpporteTotal.Text = .Cells(13).Value
            Me.TxtJuegaEmp.Text = .Cells(14).Value
            Me.TxtImpPremioPpta.Text = .Cells(15).Value
            Me.TxtNumJugado2.Text = .Cells(17).Value
            Me.TxtPremioNum1.Text = .Cells(18).Value
            Me.TxtPremioNum2.Text = .Cells(19).Value
        End With
        estado = 2
        Me.BtnGuardar.Enabled = False
        CalcularResumenSorteo()

    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Calcular()
        Me.BtnGuardar.Enabled = True
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim IdSorteo, Ejercicio, IdAdmon, NumJugado, NumJugado2, PptImpresas, PptEntregadas, PptDevueltas, DecJugado As Integer
        Dim ImpDecimo, ImpPpta, LotJugada, ImpTotal, JuegaEmp, ImportePremioPapeleta, ImportePagado As Double
        Dim PremioNum1, PremioNum2 As Double
        Dim dFecha As Date
        Dim TipoSorteo As String

        Try
            IdSorteo = CInt(Me.TxtIdSorteo.Text)
            Ejercicio = CInt(Me.TxtEjercicio.Text)
            IdAdmon = CInt(Me.TxtIdAdmon.Text)
            NumJugado = CInt(Me.TxtNumJugado.Text)
            NumJugado2 = CInt(Me.TxtNumJugado2.Text)
            PptImpresas = CInt(Me.TxtPptasImpresas.Text)
            PptEntregadas = CInt(Me.TxtPptasEntregadas.Text)
            PptDevueltas = CInt(Me.TxtPptasDevueltas.Text)
            DecJugado = CInt(Me.TxtDecimosJugados.Text)
            ImpDecimo = Convert.ToDouble(Me.TxtImporteDecimo.Text)
            ImpPpta = Convert.ToDouble(Me.TxtImportePpta.Text)
            LotJugada = Convert.ToDouble(Me.TxtLotJugada.Text)
            ImpTotal = Convert.ToDouble(Me.TxtImpporteTotal.Text)
            JuegaEmp = Convert.ToDouble(Me.TxtJuegaEmp.Text)
            dFecha = DtpFecha.Value
            TipoSorteo = Me.TxtTipoSorteo.Text
            PremioNum1 = Convert.ToDouble(Me.TxtPremioNum1.Text)
            PremioNum2 = Convert.ToDouble(Me.TxtPremioNum2.Text)
            ImportePremioPapeleta = PremioNum1 + PremioNum2
            ImportePagado = 0
        Catch ex As Exception
            MsgBox("Verifica si hay algún campo sin valor ")
            Exit Sub
        End Try

        If estado = 1 Then

            Try
                negocio.GuardarSorteo(IdSorteo, Ejercicio, TipoSorteo, dFecha, IdAdmon, NumJugado, ImpDecimo,
                                            ImpPpta, PptImpresas, PptEntregadas, PptDevueltas, LotJugada, DecJugado,
                                            ImpTotal, JuegaEmp, ImportePremioPapeleta, ImportePagado, NumJugado2,
                                            PremioNum1, PremioNum2)
                MsgBox("Registro guardado")
                Cargar()
                Limpiar()
            Catch ex As Exception
                MsgBox("no se ha guardado el apunte; " & ex.Message)
            End Try
            estado = 0

        ElseIf estado = 2 Then
            IdSorteo = CInt(Me.TxtIdSorteo.Text)
            Try
                negocio.ActualizarSorteo(IdSorteo, PptEntregadas, PptDevueltas, LotJugada,
                                         DecJugado, ImpTotal, JuegaEmp, ImportePremioPapeleta, ImportePagado,
                                         NumJugado, NumJugado2, PremioNum1, PremioNum2)
                MsgBox("Registro guardado")
                Cargar()
                Limpiar()
            Catch ex As Exception
                MsgBox("no se ha guardado el apunte; " & ex.Message)
            End Try
            estado = 0
        End If
        Me.Panel1.Visible = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CboAdmon_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboAdmon.SelectedIndexChanged

        Dim valorSeleccionado As Integer

        ' Verifica si el ComboBox está usando un DataTable como origen de datos
        If TypeOf CboAdmon.SelectedItem Is DataRowView Then
            valorSeleccionado = Convert.ToInt32(CType(CboAdmon.SelectedItem, DataRowView)("NumAdmon"))

        Else
            valorSeleccionado = Convert.ToInt32(CboAdmon.SelectedItem)
        End If
        Me.TxtIdAdmon.Text = valorSeleccionado
    End Sub

    Private Sub CboTipoSorteo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboTipoSorteo.SelectedIndexChanged
        Dim cTipo As String

        If TypeOf CboTipoSorteo.SelectedItem Is DataRowView Then
            cTipo = Convert.ToString(CType(CboTipoSorteo.SelectedItem, DataRowView)("Tipo"))
        Else
            cTipo = CboAdmon.SelectedItem
        End If
        Me.TxtTipoSorteo.Text = cTipo

    End Sub

    Private Sub Limpiar()

        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = 0
            ElseIf TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next

        Me.DtpFecha.Value = Today
        Me.TxtEjercicio.Text = eje.GetEjercicioActivo

    End Sub

    Private Sub Calcular()
        Dim frm As New FrmCalcularSorteo
        With frm
            .TxtIdSorteo.Text = Me.TxtIdSorteo.Text
            .TxtTipoSorteo.Text = Me.TxtTipoSorteo.Text
            .DtpFecha.Value = Me.DtpFecha.Value
            .TxtIdAdmon.Text = Me.TxtIdAdmon.Text
            .TxtImporteDecimo.Text = Me.TxtImporteDecimo.Text
            .TxtImportePapeleta.Text = Me.TxtImportePpta.Text
            .TxtNumLoteria.Text = Me.TxtNumJugado.Text
            .LblEjercicioActivo.Text = Me.TxtEjercicio.Text
        End With
        frm.ShowDialog()

        Me.TxtDecimosJugados.Text = frm.TxtDecimosComprar.Text
            Me.TxtPptasImpresas.Text = frm.TxtPptaImprimir.Text
            Me.TxtPptasEntregadas.Text = frm.TxtPptasAVenta.Text
            Me.TxtLotJugada.Text = frm.TxtTotalPptasAVenta.Text
            Me.TxtImpporteTotal.Text = frm.TxtTotalDecimosComprar.Text
            Me.TxtJuegaEmp.Text = frm.TxtTotalPptasAComision.Text
            Me.TxtPptasDevueltas.Text = 0

    End Sub

    Private Sub CalcularResumenSorteo()
        Dim eje As Integer = CInt(Me.LblEjercicio.Text)
        Dim idsorteo As Integer = DgvSorteos.CurrentRow.Cells("IdSorteo").Value
        Dim liquidado As Double

        recalc.ActualizarSorteo(idsorteo, eje)
        Me.DgvSorteos.Refresh()

        Dim fila As DataRow = detalle.ObtenerResumenSorteo(idsorteo, eje)
        If fila IsNot Nothing Then
            liquidado = fila("Liquidado") * 0.8
        Else
            liquidado = 0
        End If

        Dim resultado = recalc.CalcularSorteo(idsorteo, eje)
        Dim deuda = resultado.Item1.ToString("N2")
        Dim importepagado = resultado.Item2.ToString("N2")
        Dim saldo = resultado.Item3.ToString("N2")

        Me.TxtDeudaSorteo.Text = deuda
        Me.TxtLiquidadoSorteo.Text = liquidado
        Me.TxtSaldoSorteo.Text = (-saldo).ToString("N2")
        Me.TxtResIdSorteo.Text = idsorteo
        Me.TxtAdministracion.Text = miadmon.Nombre(DgvSorteos.CurrentRow.Cells(4).Value)
        Me.TxtPagadoAdmonSorteo.Text = importepagado
        'Me.TxtTotalPagadoAdmon.Text = pagadoAdmon.ToString("N2")
        Me.TxtSaldoVendor.Text = (liquidado - deuda).ToString("N2")

        Me.TxtImportePremios.Text = pagos.GetPremiosAbonadoSorteo(eje, idsorteo).ToString
        Me.TxtPremiosAbonados.Text = detalle.ObtenerImportePremios(idsorteo, eje).ToString
    End Sub

    Private Sub TotalizarSorteos()
        Dim pagado As Double = pagos.GetTotalPagadoAdmon(CInt(Me.LblEjercicio.Text))

        Dim resultado = recalc.RecalcularTodosSorteos(CInt(Me.LblEjercicio.Text))

        Dim importetotal As Double = resultado.Item1
        Dim importepagadoAdmon As Double = resultado.Item2
        Dim saldo As Double = resultado.Item3
        Me.TxtDeudaTotal.Text = importetotal.ToString("N2")
        Me.TxtTotalPagadoAdmon.Text = importepagadoAdmon.ToString("N2")
        Me.TxtSaldoTotal.Text = saldo.ToString("N2")

    End Sub

    Private Sub DgvSorteos_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvSorteos.CellMouseClick

        CalcularResumenSorteo()
        ' Cargar()

        ' Hay que dejar el cursor en la fila seleccionada

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Panel1.Visible = False
        Limpiar()
    End Sub

    'Private Sub TxtImpPremioPpta_Enter(sender As Object, e As EventArgs) Handles TxtImpPremioPpta.Leave
    '    If CInt(Me.TxtImpPremioPpta.Text) > 0 Then
    '        Me.BtnGuardar.Enabled = True
    '    End If
    'End Sub

    'Private Sub TxtImpPremioPpta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImpPremioPpta.KeyPress
    '    If CInt(Me.TxtImpPremioPpta.Text) > 0 Then
    '        If e.KeyChar = ChrW(Keys.Enter) Then
    '            Me.BtnGuardar.Enabled = True
    '            Me.BtnGuardar.Focus()
    '        End If
    '    End If

    'End Sub

    Private Sub TxtPremioNum1_Leave(sender As Object, e As EventArgs) Handles TxtPremioNum1.Leave

        Dim Premio1 As Double = Convert.ToDouble(Me.TxtPremioNum1.Text)


        Me.TxtImpPremioPpta.Text = Premio1 + Convert.ToDouble(Me.TxtPremioNum2.Text)
        Me.BtnGuardar.Enabled = True

    End Sub

    Private Sub TxtPremioNum2_Leave(sender As Object, e As EventArgs) Handles TxtPremioNum2.Leave

        Dim Premio2 As Double = Convert.ToDouble(Me.TxtPremioNum2.Text)

        Me.TxtImpPremioPpta.Text = Convert.ToDouble(Me.TxtPremioNum1.Text) + Premio2
        Me.BtnGuardar.Enabled = True

    End Sub
End Class