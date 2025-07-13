Imports Negocio

Public Class FrmAdministraciones
    Public ReadOnly negocio As New AdministracionesNegocio
    Private estado As Integer
    Private Sub FrmAdministraciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DgvAdmon.Height = 340
        Me.DgvAdmon.Width = 1070
        Me.Height = 500
        Me.Width = 1100

        CargarAdmon()

        Me.DgvAdmon.Columns(1).Width = 40
        Me.DgvAdmon.Columns(4).Width = 50
        Me.DgvAdmon.Columns(5).Width = 70
        Me.DgvAdmon.Columns(6).Width = 60
        Me.DgvAdmon.Columns(0).Visible = False


    End Sub
    Private Sub CargarAdmon()
        Me.DgvAdmon.DataSource = negocio.GetAdmon()
        Me.DgvAdmon.Refresh()
    End Sub
    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        Me.DgvAdmon.Height = 190
        If DgvAdmon.Rows.Count = 1 Then
            Me.TxtId.Text = 1
        Else
            Me.DgvAdmon.ClearSelection()
            Dim lastRowIndex As Integer = Me.DgvAdmon.Rows.Count - 1
            Me.DgvAdmon.Rows(lastRowIndex).Selected = True
            Me.TxtId.Text = Me.DgvAdmon.CurrentRow.Cells(0).Value + 1
        End If
        estado = 1

    End Sub
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        Dim cCuenta = Me.TxtCuenta.Text.Replace(" ", "")
        If estado = 1 Then
            If Me.TxtId.Text = (Nothing Or 0) Then
                MsgBox("El campo Id no puede estar vacío o ser 0")
                Me.TxtId.Focus()
            Else
                Try
                    negocio.GuardarAdmon(CInt(TxtNumAdmon.Text), TxtNombre.Text, TxtDireccion.Text,
                                         CInt(TxtCodPos.Text), TxtPoblacion.Text, TxtTefono.Text, TxtMail.Text,
                                         TxtResponsable.Text, cCuenta)
                    MsgBox("Se ha añadido nueva Administración")
                Catch ex As Exception
                    MsgBox("Error de datos, no se ha guardado el registro" & ex.Message)
                    Exit Sub
                End Try
                CargarAdmon()
                estado = 0
                LimpiarTextBox()
                Me.DgvAdmon.Height = 340
            End If
        Else estado = 2
            Try
                negocio.ActualizarAdmon(CInt(TxtId.Text), CInt(TxtNumAdmon.Text), TxtNombre.Text, TxtDireccion.Text,
                                         CInt(TxtCodPos.Text), TxtPoblacion.Text, TxtTefono.Text, TxtMail.Text,
                                         TxtResponsable.Text, cCuenta)
                MsgBox("Se han guardado los cambios")
            Catch ex As Exception
                MsgBox("Error de datos, no se ha guardado el registro" & vbCrLf & ex.Message)
            End Try
            CargarAdmon()
            estado = 0
            LimpiarTextBox()
            Me.DgvAdmon.Height = 340
        End If

    End Sub
    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        estado = 2
        Me.DgvAdmon.Height = 190
        Me.TxtId.Text = Me.DgvAdmon.CurrentRow.Cells(0).Value
        Me.TxtNumAdmon.Text = Me.DgvAdmon.CurrentRow.Cells(1).Value
        Me.TxtNombre.Text = Me.DgvAdmon.CurrentRow.Cells(2).Value
        Me.TxtDireccion.Text = Me.DgvAdmon.CurrentRow.Cells(3).Value
        Me.TxtCodPos.Text = Me.DgvAdmon.CurrentRow.Cells(4).Value
        Me.TxtPoblacion.Text = Me.DgvAdmon.CurrentRow.Cells(5).Value
        Me.TxtTefono.Text = Me.DgvAdmon.CurrentRow.Cells(6).Value
        Me.TxtMail.Text = Me.DgvAdmon.CurrentRow.Cells(7).Value
        Me.TxtResponsable.Text = Me.DgvAdmon.CurrentRow.Cells(8).Value
        Me.TxtCuenta.Text = Me.DgvAdmon.CurrentRow.Cells(9).Value

    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim nId As Integer = Me.DgvAdmon.CurrentRow.Cells(0).Value
        Try
            negocio.EraseAdmon(nId)
            MsgBox("Administración eliminada")
            CargarAdmon()
        Catch ex As Exception
            MsgBox("Error de datos. No se ha eliminado el registro")
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        LimpiarTextBox()
        Me.DgvAdmon.Height = 340
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub LimpiarTextBox()

        Dim a As Control
        For Each a In Me.Controls
            If TypeOf a Is TextBox Then
                a.Text = Nothing
            End If
        Next

    End Sub
End Class