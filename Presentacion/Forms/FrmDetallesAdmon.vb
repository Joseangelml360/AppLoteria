Imports Negocio
Public Class FrmDetallesAdmon
    Public ReadOnly negocio As New DetallesAdmonNegocio
    Public ReadOnly miadmon As New AdministracionesNegocio
    Public ReadOnly misorteo As New SorteosNegocio
    Public ReadOnly eje As New EjercicioActivoNegocio
    Public ReadOnly libro As New LibroDiarioNegocio
    Public ReadOnly calc As New CalcularPremiosLoteriaNegocio
    Public ReadOnly detalleventas As New DetalleVentasLoteriaNegocio


    Private Sub FrmDetallesAdmon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblEjercicio.Text = eje.GetEjercicioActivo
        Me.Panel1.Visible = False
        Limpiar()
        CargarDatos()
        ListView1.Visible = False
        CargarLista()

    End Sub

    Private Sub Limpiar()
        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = 0
            End If
        Next
        For Each c As Control In Panel2.Controls
            If TypeOf c Is TextBox Then
                c.Text = 0
            End If
        Next
        Me.CboModo.Text = ""
        Me.CboPagadoAbono.Text = ""
        Me.LblEstado.Text = ""
        Me.DtFecha.Value = Today
    End Sub

    Private Sub CargarDatos()
        Me.DgvDetallesAdmon.DataSource = negocio.GetDetallesAdmon
        Me.DgvDetallesAdmon.Columns(0).Visible = False
        Me.DgvDetallesAdmon.Columns(2).Visible = False
        Me.DgvDetallesAdmon.Columns(6).Visible = True
        Me.DgvDetallesAdmon.Columns(7).Visible = True
        Me.DgvDetallesAdmon.Columns(8).Visible = True
        Me.DgvDetallesAdmon.Refresh()


    End Sub

    Private Sub CargarLista()

        Me.TxtIdAdmon.Text = ""
        Dim ejercicio As Integer = (CInt(Me.LblEjercicio.Text))
        Dim tabla As DataTable = misorteo.GetSorteoEjeActivo(ejercicio)

        ListView1.View = View.Details
        ListView1.Columns.Add("ID Sorteo", 60, HorizontalAlignment.Center)
        ListView1.Columns.Add("Tipo Sorteo", 100, HorizontalAlignment.Left)
        ListView1.Columns.Add("Fecha", 80, HorizontalAlignment.Left)
        ListView1.Columns.Add("Núm. Jugado 1", 60, HorizontalAlignment.Left)
        ListView1.Columns.Add("Núm. Jugado 2", 60, HorizontalAlignment.Left)
        ListView1.Columns.Add("Id admon", 60, HorizontalAlignment.Left)

        ListView1.Items.Clear()

        For Each fila As DataRow In tabla.Rows
            Dim item As New ListViewItem(fila("IdSorteo").ToString()) ' Primera columna
            item.SubItems.Add(fila("TipoSorteo").ToString()) ' Segunda columna
            item.SubItems.Add(Convert.ToDateTime(fila("Fecha")).ToString("dd/MM/yyyy")) ' Tercera columna
            item.SubItems.Add(fila("NumeroJugado").ToString())  ' Cuarta columna
            item.SubItems.Add(fila("NumeroJugado2").ToString())  ' Quinta columna
            item.SubItems.Add(fila("IdAdmon").ToString())    ' Sexta columna

            ListView1.Items.Add(item)
        Next

    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
        Me.Panel1.Visible = False
        CargarDatos()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim IdSorteo, IdAdmon, NumJugado, NumJugado2, ejercicio As Integer
        Dim Fecha As Date
        Dim PagoAbono, Modo As String
        Dim ImportePago, PagoPremios, ImporteDecimos As Double
        ejercicio = CInt(Me.LblEjercicio.Text)

        Try
            IdSorteo = CInt(TxtIdSorteo.Text)
            IdAdmon = CInt(TxtIdAdmon.Text)
            NumJugado = CInt(TxtNumJugado.Text)
            NumJugado2 = CInt(Me.TxtNumJugado2.Text)
            Fecha = DtFecha.Value
            If IdSorteo = 0 Then
                MsgBox("Seleccionar un sorteo")
                Me.TxtIdSorteo.Focus()
                Exit Sub
            End If
            If Me.CboModo.Text IsNot Nothing And Me.CboPagadoAbono.Text IsNot Nothing Then
                PagoAbono = CboPagadoAbono.Text.ToString.Chars(0)
                Modo = CboModo.Text.ToString.Chars(0)
            Else
                MsgBox("P/A o Modo no pueden estar en blanco")
                Me.CboPagadoAbono.Focus()
                Exit Sub
            End If

            If Me.TxtImporte.Text = 0 Then
                If Me.TxtPagoPremios.Text = 0 Then
                    MsgBox("Importe y Pago premios no pueden ser simultáneamente cero (0)")
                    Me.TxtPagoPremios.Focus()
                    Exit Sub
                Else
                    PagoPremios = Convert.ToDouble(TxtPagoPremios.Text)
                End If
            Else
                ImportePago = Convert.ToDouble(TxtImporte.Text)
                PagoPremios = Convert.ToDouble(TxtPagoPremios.Text)
            End If

            If ImportePago > 0 And CboPagadoAbono.Text = "A (Abono)" Then
                MsgBox("Con abono seleccionado el Importe pagado debe ser 0")
                Me.TxtImporte.Text = 0
                Exit Sub
            End If

            If PagoPremios > 0 And CboPagadoAbono.Text = "P (Pago)" Then
                MsgBox("Con Pago seleccionado el Importe premios debe ser 0")
                Me.TxtImportePremios.Text = 0
                Exit Sub
            End If

        Catch ex As Exception
            MsgBox("Verifica si hay algún campo sin valor ")
            Exit Sub
        End Try

        ImporteDecimos = misorteo.GetImporteTotal(CInt(Me.LblEjercicio.Text), IdSorteo)
        Me.TxtImporteDecimos.Text = ImporteDecimos

        Try
            negocio.GuardarDetallesAdmon(IdAdmon, ejercicio, IdSorteo, NumJugado, NumJugado2,
                                         Fecha, PagoAbono, Modo, ImportePago, PagoPremios, ImporteDecimos)
        Catch ex As Exception
            MsgBox("no se ha guardado el apunte del detalle con la admon; " & ex.Message)
        End Try

        'Añadir registro a LibroDiario 

        Dim Debe, Haber, Saldo As Double
        Dim EntradaSalida, CajaBanco, Concepto As String

        Saldo = libro.ObtenerSaldo(ejercicio)

        If PagoAbono = "P" Then
            EntradaSalida = "S"
            Concepto = "Pago loteria a admon " & IdAdmon & ", sorteo " & IdSorteo
            Debe = ImportePago
            Haber = 0
            Saldo -= ImportePago
        ElseIf PagoAbono = "A" Then
            EntradaSalida = "E"
            Concepto = "Abono admon " & IdAdmon & " de premio lotería, sorteo " & IdSorteo
            Debe = 0
            Haber = PagoPremios
            Saldo += PagoPremios
            ImportePago = PagoPremios
        Else
            EntradaSalida = "n/d"
            Concepto = "s/c"
        End If

        If Modo = "T" Then
            CajaBanco = "B"
        Else
            CajaBanco = "C"
        End If

        Try

            libro.InsertarApunte(ejercicio, Fecha, EntradaSalida, ImportePago, CajaBanco, Concepto,
                                 Debe, Haber, Saldo)
        Catch ex As Exception
            MsgBox("No se ha guardado apunte en el libro de Caja. Error: " & ex.Message)
        End Try

        'Sumar ImportePago a ImportePagado de tabla sorteos
        If PagoAbono = "P" Then
            Dim Pagado As Double = misorteo.GetImportePagadoSorteo(ejercicio, IdSorteo) + ImportePago
            Try
                misorteo.UpdateImportePagado(IdSorteo, Pagado)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        'Reescribir datos
        Resumen(IdSorteo)
        EstadoSaldo()
        CargarDatos()

        Panel1.Visible = False

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Me.Panel1.Visible = True
        Me.BtnGuardar.Enabled = True
        Limpiar()

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Limpiar()

        If ListView1.SelectedItems.Count > 0 Then
            Dim ejercicio As Integer = Me.LblEjercicio.Text
            Dim itemSeleccionado As ListViewItem = ListView1.SelectedItems(0)
            Dim idsorteo As Integer = itemSeleccionado.SubItems(0).Text ' Id Sorteo
            Me.TxtNumJugado.Text = itemSeleccionado.SubItems(3).Text ' Cuarta columna
            Me.TxtNumJugado2.Text = itemSeleccionado.SubItems(4).Text   ' Quinta columna
            Me.TxtIdAdmon.Text = itemSeleccionado.SubItems(5).Text   ' Sexta columna
            Me.TxtIdSorteo.Text = idsorteo
            Me.TxtImporteDecimos.Text = misorteo.GetImporteTotal(ejercicio, idsorteo)
            Me.TxtImporteAdeudado.Text = TxtImporteDecimos.Text

            If negocio.GetTotalPagadoSorteo(idsorteo) IsNot Nothing Then
                Me.TxtImportePagado.Text = negocio.GetTotalPagadoSorteo(idsorteo)
            Else
                Me.TxtImportePagado.Text = 0
            End If
            Me.TxtSaldoDeudor.Text = Me.TxtImporteAdeudado.Text - Me.TxtImportePagado.Text
            EstadoSaldo()
        End If
        Me.ListView1.Visible = False
    End Sub

    Private Sub TxtIdSorteo_Click(sender As Object, e As EventArgs) Handles TxtIdSorteo.Click
        VerLista()
    End Sub

    Private Sub TxtId_Click(sender As Object, e As EventArgs) Handles TxtId.Click
        VerLista()
    End Sub

    Private Sub TxtIdAdmon_Click(sender As Object, e As EventArgs) Handles TxtIdAdmon.Click
        VerLista()
    End Sub

    Private Sub TxtNumJugado_Click(sender As Object, e As EventArgs) Handles TxtNumJugado.Click
        VerLista()
    End Sub
    Private Sub VerLista()
        Me.ListView1.Visible = True
        Me.ListView1.Height = 250
        Me.ListView1.Width = 250
    End Sub

    Private Sub EstadoSaldo()
        Select Case Me.TxtSaldoDeudor.Text
            Case > 0
                Me.LblEstado.ForeColor = Color.Red
                Me.LblEstado.Text = "Deudor"
            Case = 0
                Me.LblEstado.ForeColor = Color.Green
                Me.LblEstado.Text = "Liquidado"
            Case < 0
                Me.LblEstado.ForeColor = Color.Blue
                Me.LblEstado.Text = "Acreedor"
        End Select
    End Sub

    Private Sub Resumen(idsorteo As Integer)
        Dim resultadoPagoSorteo As Double = misorteo.GetImportePagadoSorteo(CInt(Me.LblEjercicio.Text), idsorteo)

        ' extraer total pagado para el sorteo seleccionado (suma(importe) para id sorteo y ejercicio
        Me.TxtImportePagado.Text = negocio.GetTotalPagadoSorteo(idsorteo)
        If resultadoPagoSorteo <> Convert.ToDouble(Me.TxtImportePagado.Text) Then
            MsgBox("Error en el  Importe pagado del sorteo")
            Exit Sub
        End If
        Me.TxtImporteAdeudado.Text = misorteo.GetImporteTotal(CInt(Me.LblEjercicio.Text), idsorteo)
        Me.TxtSaldoDeudor.Text = Me.TxtImporteAdeudado.Text - Me.TxtImportePagado.Text
        Me.TxtImportePremios.Text = calc.CalcularImportePremioSorteo(CInt(Me.LblEjercicio.Text), idsorteo).ToString

        Me.TxtPremiosAbonados.Text = detalleventas.ObtenerImportePremios(idsorteo, CInt(Me.LblEjercicio.Text))
        Me.TxtsaldoPremios.Text = Convert.ToDouble(Me.TxtImportePremios.Text - Me.TxtPremiosAbonados.Text)
        Me.TxtIdResumen.Text = idsorteo
        'Me.TxtAdmon.Text = miadmon.Nombre(CInt(Me.TxtIdAdmon.Text))

        EstadoSaldo()

    End Sub
    Private Sub DgvDetallesAdmon_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DgvDetallesAdmon.CellMouseClick
        If DgvDetallesAdmon.Rows.Count - 1 > 0 Then
            Dim idsorteo As Integer = DgvDetallesAdmon.CurrentRow.Cells(3).Value
            Dim idadmon As Integer = DgvDetallesAdmon.CurrentRow.Cells("IdAdmon").Value
            Dim admon As String = miadmon.Nombre(idadmon)
            Me.TxtAdmon.Text = idadmon & ",  " & admon
            Resumen(idsorteo)
        Else
            MsgBox("no hay registros para visualizar sorteo")
        End If

    End Sub

    Private Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        CargarDatos()
    End Sub

    Private Sub BtnVerResumen_Click(sender As Object, e As EventArgs) Handles BtnVerResumen.Click
        Me.DgvDetallesAdmon.DataSource = negocio.GetTotalDetallesAdmonSorteo(CInt(Me.LblEjercicio.Text))
        Me.DgvDetallesAdmon.Columns(0).Visible = False
        Me.DgvDetallesAdmon.Columns(2).Visible = False
        Me.DgvDetallesAdmon.Columns(6).Visible = False
        Me.DgvDetallesAdmon.Columns(7).Visible = False
        Me.DgvDetallesAdmon.Columns(8).Visible = False
        Me.DgvDetallesAdmon.Refresh()
    End Sub
End Class