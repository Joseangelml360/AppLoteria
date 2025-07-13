Imports Negocio
Public Class FrmLibroCaja
    Public ReadOnly libro As New LibroDiarioNegocio
    Public ReadOnly eje As New EjercicioActivoNegocio
    Private Sub LibroCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblEjercicio.Text = eje.GetEjercicioActivo().ToString
        Cargar()
        Me.DgvLibroCaja.Columns(0).Visible = False
        Me.DgvLibroCaja.Columns(1).Visible = False
        Me.DgvLibroCaja.Columns(2).HeaderText = "Fecha"
        Me.DgvLibroCaja.Columns(3).HeaderText = "E/S"
        Me.DgvLibroCaja.Columns(5).HeaderText = "Caja/Banco"
        Me.DgvLibroCaja.Columns(7).HeaderText = "Salida"
        Me.DgvLibroCaja.Columns(8).HeaderText = "Entrada"
        Me.DgvLibroCaja.Columns(6).Width = 300

        Me.DgvLibroCaja.Columns(1).Width = 50
        Me.DgvLibroCaja.Columns(2).Width = 80
        Me.DgvLibroCaja.Columns(3).Width = 50
        Me.DgvLibroCaja.Columns(4).Width = 50
        Me.DgvLibroCaja.Columns(5).Width = 80




    End Sub

    Private Sub Cargar()
        Dim dt As DataTable = libro.GetLibroDiario(CInt(Me.LblEjercicio.Text))

        ' Aplica el orden descendente en la columna "Fecha"
        dt.DefaultView.Sort = "IdDiario DESC"

        ' Asigna el DataView al DataGridView
        Me.DgvLibroCaja.DataSource = dt

        Me.DgvLibroCaja.Refresh()
    End Sub

    Private Sub Limpiar()
        Me.TxtImporte.Text = 0
        Me.TxtConcepto.Text = ""
        Me.TxtImporte.Focus()
        Cargar()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
        Cargar()
    End Sub

    Private Sub BTnCaja_Click(sender As Object, e As EventArgs) Handles BTnCaja.Click

        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)
        Dim vista As New DataView(libro.GetLibroDiario(ejercicio)) With {
            .RowFilter = $"CajaBanco= 'C'",
            .Sort = "Fecha DESC"
        }

        Me.DgvLibroCaja.DataSource = vista
        Me.DgvLibroCaja.Refresh()


    End Sub

    Private Sub BtnBanco_Click(sender As Object, e As EventArgs) Handles BtnBanco.Click

        'Eliminar una vista anterior

        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)
        Dim vista As New DataView(libro.GetLibroDiario(ejercicio)) With {
            .RowFilter = $"CajaBanco= 'B'",
            .Sort = "Fecha DESC"
        }
        Me.DgvLibroCaja.DataSource = vista
        Me.DgvLibroCaja.Refresh()


    End Sub

    Private Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        Cargar()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim ejercicio As Integer = CInt(Me.LblEjercicio.Text)
        Dim fecha As Date = Me.DtpFechaApunte.Value
        Dim entradasalida As String = "", cajabanco As String = "", concepto As String
        Dim importe, debe, haber, saldo, saldolibro As Double

        If RbtnAbono.Checked Then entradasalida = "S"
        If RbtnPago.Checked Then entradasalida = "E"
        If RbtnBanco.Checked Then cajabanco = "B"
        If RbtnEfectivo.Checked Then cajabanco = "C"
        concepto = Me.TxtConcepto.Text
        importe = Convert.ToDouble(Me.TxtImporte.Text)
        If entradasalida = "S" Then debe = Convert.ToDouble(Me.TxtImporte.Text)
        If entradasalida = "E" Then haber = Convert.ToDouble(Me.TxtImporte.Text)
        saldolibro = libro.ObtenerSaldo(ejercicio)
        If entradasalida = "S" Then
            saldo = saldolibro - importe
        End If
        If entradasalida = "E" Then
            saldo = saldolibro + importe
        End If

        Try
            libro.InsertarApunte(ejercicio, fecha, entradasalida, importe, cajabanco, concepto, debe, haber, saldo)
            MsgBox("Apunte guardado")
        Catch ex As Exception
            MsgBox("No se ha guardado el apunte. Error: " & ex.Message)
        Finally
            Limpiar()
            Cargar()
        End Try

    End Sub

    Private Sub FiltrarPorFechas()
        Dim fechaInicio As Date = DtpInicio.Value
        Dim fechaFin As Date = DtpFinal.Value

        'Eliminar una vista anterior si la hubiera
        Cargar()

        ' Verifica que la fecha de inicio no sea mayor que la final
        If fechaInicio > fechaFin Then
            MessageBox.Show("La fecha de inicio no puede ser mayor que la fecha final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Aplica el filtro
        Dim filtro As String = String.Format("Fecha >= #{0}# AND Fecha <= #{1}#", fechaInicio.ToString("MM/dd/yyyy"), fechaFin.ToString("MM/dd/yyyy"))
        DirectCast(DgvLibroCaja.DataSource, DataTable).DefaultView.RowFilter = filtro
    End Sub

    Private Sub BtnAplicarFechas_Click(sender As Object, e As EventArgs) Handles BtnAplicarFechas.Click
        FiltrarPorFechas()
    End Sub
End Class