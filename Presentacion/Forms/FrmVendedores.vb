
Imports Negocio

Public Class FrmVendedores

    Private ReadOnly negocio As New VendedoresNegocio()
    Private ReadOnly lista As New SociosNegocio()

    Private estado As Integer

    Private Sub FrmVendedoresPresentacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Panel1.Visible = False
        Me.DgvDbCensosFallero.Visible = False
        Me.TxtAñadirNUevo.Visible = False
        Me.TxtBuscar.Focus()
        Me.Button1.Visible = False

        CargarFalleros()

        Me.DgvVendedores.Columns(0).Width = 55
        Me.DgvVendedores.Columns(1).Width = 50
        Me.DgvVendedores.Columns(3).Width = 160
        Me.DgvVendedores.Columns(4).Width = 60
        Me.DgvVendedores.Columns(5).Width = 60
        Me.DgvVendedores.Columns(6).Width = 50
        Me.DgvVendedores.Columns(7).Width = 55
        Me.DgvVendedores.Columns(8).Width = 60
        Me.DgvVendedores.Columns(9).Width = 55

        Me.DgvVendedores.Columns(6).HeaderText = "Venta"
        Me.DgvVendedores.Columns(8).HeaderText = "A Cuotas"

    End Sub

    Private Sub CargarFalleros()

        DgvVendedores.DataSource = negocio.ObtenerVendedores()

        If DgvVendedores.Rows.Count = 0 Then
            Button1.Visible = True
            Me.DgvVendedores.Visible = False
            MsgBox("No hay vendedores asignados. Pulsa el botón Importar para añadirlos desde el Censo", vbOKOnly,
                 vbExclamation)
            Me.Button1.Visible = True
        End If
        Me.LblMayores.Text = "Mayores: " & negocio.ObtenerNumeroMayores().ToString
        Me.LblJuveniles.Text = "Juveniles: " & negocio.ObtenerNumeroJuveniles().ToString

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click

        Me.DgvVendedores.Visible = False
        Me.Panel1.Visible = True
        Me.BtnAñadir.Visible = False
        Me.BtnEditar.Visible = False
        Me.BtnEliminar.Visible = False
        Me.TxtBuscar.Visible = False
        Me.LblBuscar.Visible = False
        Me.TxtAñadirNUevo.Visible = True
        Me.TxtAñadirNUevo.Focus()
        estado = 1

        For Each c As Control In Panel1.Controls
            c.Visible = True
        Next

        Me.TxtEjercicio.ReadOnly = True
        Me.TxtCodigo.ReadOnly = True
        Me.TxtNombre.ReadOnly = True
        Me.TxtApellidos.ReadOnly = True
        Me.TxtComision.ReadOnly = True

        Me.LblPanel.Visible = True
        Me.TxtAñadirNUevo.Visible = True
        Me.LblPanel.Text = "Añadir fallero a lotería"

        Me.DgvDbCensosFallero.Visible = True
        Me.DgvDbCensosFallero.DataSource = lista.ObtenerFallerosCenso()
        Me.DgvDbCensosFallero.Columns("ANO_CEN").Visible = False
        Me.DgvDbCensosFallero.Columns(4).Visible = False
        Me.DgvDbCensosFallero.Columns(5).Visible = False
        Me.DgvDbCensosFallero.Columns("FALLERO_CODIGO").HeaderText = "Código"
        DgvDbCensosFallero.Refresh()


    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click

        Me.Panel1.Visible = True
        Me.BtnAñadir.Visible = False
        Me.BtnEditar.Visible = False
        Me.BtnEliminar.Visible = False
        estado = 2

        Me.LblPanel.Visible = True
        Me.LblPanel.Text = "Editar datos de fallero"
        Me.TxtAñadirNUevo.Visible = False
        Me.TxtEjercicio.ReadOnly = True
        Me.TxtCodigo.ReadOnly = True
        Me.TxtNombre.ReadOnly = True
        Me.TxtApellidos.ReadOnly = True
        Me.TxtComision.ReadOnly = True


        Me.TxtEjercicio.Text = DgvVendedores.CurrentRow.Cells(0).Value
        Me.TxtCodigo.Text = DgvVendedores.CurrentRow.Cells(1).Value
        Me.TxtNombre.Text = DgvVendedores.CurrentRow.Cells(2).Value
        Me.TxtApellidos.Text = DgvVendedores.CurrentRow.Cells(3).Value
        Me.TxtComision.Text = DgvVendedores.CurrentRow.Cells(4).Value
        Me.TxtLoteria.Text = DgvVendedores.CurrentRow.Cells(5).Value
        If DgvVendedores.CurrentRow.Cells(5).Value = True Then
            Me.ChkLoteria.Checked = True
            Me.ChkLoteria.Text = "Cuota con lotería"
        Else
            Me.ChkLoteria.Checked = False
            Me.ChkLoteria.Text = "Cuota sin lotería"
        End If

        Me.TxtValAsignado.Text = DgvVendedores.CurrentRow.Cells(6).Value
        Me.TxtPagado.Text = DgvVendedores.CurrentRow.Cells(7).Value
        Me.TxtACuotas.Text = DgvVendedores.CurrentRow.Cells(8).Value
        Me.TxtBeneficio.Text = DgvVendedores.CurrentRow.Cells(9).Value

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim idFallero As Integer = DgvVendedores.CurrentRow.Cells(1).Value

        Try
            negocio.EliminarVendedor(idFallero)
            MessageBox.Show("Fallero eliminado correctamente.")
            Me.TxtBuscar.Text = ""
            CargarFalleros()
            Me.DgvVendedores.Refresh()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub EditarFallero()
        Try
            negocio.EditarVendedor(TxtEjercicio.Text, CInt(TxtCodigo.Text), TxtNombre.Text, TxtApellidos.Text,
                                   Val(TxtComision.Text), CBool(TxtLoteria.Text), Val(TxtValAsignado.Text),
                                   Convert.ToDouble(TxtPagado.Text), Convert.ToDouble(TxtACuotas.Text),
                                   Convert.ToDouble(TxtBeneficio.Text))
            MessageBox.Show("Vendedor actualizado correctamente.")
            Me.TxtBuscar.Text = ""
            CargarFalleros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Me.Panel1.Visible = False
        Me.BtnAñadir.Visible = True
        Me.BtnEditar.Visible = True
        Me.BtnEliminar.Visible = True

    End Sub

    Private Sub GuardarCambios()

        Try
            negocio.GuardarVendedor(CInt(TxtEjercicio.Text), CInt(TxtCodigo.Text), TxtNombre.Text, TxtApellidos.Text,
                                    CInt(TxtComision.Text), CBool(TxtLoteria.Text), CInt(TxtValAsignado.Text),
                                    Convert.ToDouble(TxtPagado.Text), Convert.ToDouble(TxtACuotas.Text),
                                    Convert.ToDouble(TxtBeneficio.Text))
            MessageBox.Show("Vendedor agregado correctamente.")
            Me.LblPanel.Text = ""
            Me.Panel1.Visible = False
            Me.BtnAñadir.Visible = True
            Me.BtnEditar.Visible = True
            Me.BtnEliminar.Visible = True
            Me.DgvDbCensosFallero.Visible = False
            Me.TxtAñadirNUevo.Visible = False
            Me.DgvVendedores.Visible = True
            Me.TxtBuscar.Visible = True
            Me.TxtBuscar.Focus()
            Me.LblBuscar.Visible = True
            estado = 0
            CargarFalleros()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub

    Private Sub TxtAñadirNUevo_TextChanged(sender As Object, e As EventArgs) Handles TxtAñadirNUevo.TextChanged
        Dim filtro As New DataView(lista.ObtenerFallerosCenso())

        If TxtAñadirNUevo.Text <> "" Then
            filtro.RowFilter = $"APELLIDOS LIKE '%{TxtAñadirNUevo.Text}%'"
        End If

        DgvDbCensosFallero.DataSource = filtro
        DgvDbCensosFallero.Visible = True

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        Dim vista As New DataView(negocio.ObtenerVendedores())

        If TxtBuscar.Text <> "" Then
            vista.RowFilter = $"Apellidos LIKE '%{TxtBuscar.Text}%'"
        End If

        'If TxtBuscar.Text <> "" AndAlso IsNumeric(TxtBuscar.Text) Then
        '    vista.RowFilter += $" AND Codigo = {TxtBuscar.Text}"
        'End If

        DgvVendedores.DataSource = vista
    End Sub

    Private Sub DgvDbCensosFallero_Click(sender As Object, e As EventArgs) Handles DgvDbCensosFallero.Click
        Me.TxtEjercicio.Text = DgvDbCensosFallero.CurrentRow.Cells(0).Value
        Me.TxtCodigo.Text = DgvDbCensosFallero.CurrentRow.Cells(1).Value
        Me.TxtNombre.Text = DgvDbCensosFallero.CurrentRow.Cells(2).Value
        Me.TxtApellidos.Text = DgvDbCensosFallero.CurrentRow.Cells(3).Value
        Me.TxtLoteria.Text = DgvDbCensosFallero.CurrentRow.Cells(4).Value
        If DgvDbCensosFallero.CurrentRow.Cells(4).Value = True Then
            Me.ChkLoteria.Checked = True
            Me.ChkLoteria.Text = "Cuota con lotería"
        Else
            Me.ChkLoteria.Checked = False
            Me.ChkLoteria.Text = "Cuota sin lotería"
        End If
        Me.TxtComision.Text = DgvDbCensosFallero.CurrentRow.Cells(5).Value
        Me.TxtValAsignado.Text = 0
        Me.TxtPagado.Text = 0
        Me.TxtACuotas.Text = 0
        Me.TxtBeneficio.Text = 0

        DgvDbCensosFallero.Visible = False

        Me.TxtLoteria.Visible = False

        Dim com As Integer = Val(Me.TxtComision.Text)
        Dim lot As Integer = Val(Me.TxtLoteria.Text)

        If lot = 1 And com = 1 Then
            Me.TxtValAsignado.Text = 750
        End If
        If lot = 0 Then
            Me.TxtValAsignado.Text = 0
        End If
        If com = 3 And lot = 1 Then
            Me.TxtValAsignado.Text = 510
        End If

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        If estado = 2 Then
            For Each c As Control In Me.Panel1.Controls
                If TypeOf c Is TextBox Then c.Text = ""
            Next

        ElseIf estado = 1 Then
            For Each c As Control In Me.Panel1.Controls
                If TypeOf c Is TextBox Then c.Text = ""
            Next
            Me.DgvDbCensosFallero.Visible = False
            Me.DgvVendedores.Visible = True
            Me.TxtAñadirNUevo.Visible = False
        End If

        Me.LblPanel.Text = ""
        Me.Panel1.Visible = False
        Me.BtnAñadir.Visible = True
        Me.BtnEditar.Visible = True
        Me.BtnEliminar.Visible = True
        Me.TxtBuscar.Visible = True
        Me.TxtBuscar.Focus()
        Me.LblBuscar.Visible = True

        estado = 0

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If estado = 2 Then
            EditarFallero()
        ElseIf estado = 1 Then
            GuardarCambios()
        ElseIf estado = 0 Then
            MsgBox("ERROR" + vbCrLf + "No hay datos para guardar")
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        negocio.ImportarVendedores()
        Button1.Visible = False
        Me.DgvVendedores.Visible = True
        CargarFalleros()
    End Sub

    Private Sub BtnInforme_Click(sender As Object, e As EventArgs) Handles BtnInforme.Click
        Dim frm As New InformeVendedores
        frm.ShowDialog()
    End Sub
End Class