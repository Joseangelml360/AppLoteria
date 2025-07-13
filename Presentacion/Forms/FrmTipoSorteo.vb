Imports Negocio

Public Class FrmTipoSorteo
    Public ReadOnly negocio As New TipoSorteoNegocio
    Public estado As Integer
    Private Sub FrmTipoSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarTipoSorteo()
        Me.DgvTipoSorteo.Columns(0).Width = 60
        Me.DgvTipoSorteo.Columns(1).Width = 160

    End Sub

    Private Sub CargarTipoSorteo()

        estado = 0

        Me.DgvTipoSorteo.Visible = True
        Me.DgvTipoSorteo.DataSource = negocio.GetTipoSorteo()
        Me.DgvTipoSorteo.Refresh()
        Me.TxtCodigo.Clear()
        Me.TxtTipo.Clear()

    End Sub

    Private Sub BtnAñadir_Click(sender As Object, e As EventArgs) Handles BtnAñadir.Click
        If Me.DgvTipoSorteo.Rows.Count = 0 Then
            Me.TxtCodigo.Text = 1
        Else
            Me.DgvTipoSorteo.ClearSelection()
            Dim lastRowIndex As Integer = Me.DgvTipoSorteo.Rows.Count - 1
            Me.DgvTipoSorteo.Rows(lastRowIndex).Selected = True
            Me.TxtCodigo.Text = Me.DgvTipoSorteo.Rows(lastRowIndex).Cells(0).Value + 1
        End If
        Me.DgvTipoSorteo.Visible = False
        estado = 1
        Me.TxtTipo.Focus()

    End Sub

    Private Sub BtnEditar_Click(sender As Object, e As EventArgs) Handles BtnEditar.Click
        estado = 2
        Me.TxtCodigo.Text = Me.DgvTipoSorteo.CurrentRow.Cells(0).Value
        Me.TxtTipo.Text = Me.DgvTipoSorteo.CurrentRow.Cells(1).Value
        Me.DgvTipoSorteo.Visible = False
        Me.TxtTipo.Focus()
    End Sub

    Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
        Dim codigo As Integer = DgvTipoSorteo.CurrentRow.Cells(0).Value
        Try
            negocio.EraseTipoSorteo(codigo)
            CargarTipoSorteo()

        Catch ex As Exception
            MsgBox("Error, no se ha eliminado el tipo de sorteo" And vbCrLf And ex.Message)
        End Try

    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        If estado = 1 Then
            If Me.TxtTipo.Text = Nothing Then
                MsgBox("El campo Tipo de sorteo no puede estar vacío", vbOKOnly, vbObjectError)
                Me.TxtTipo.Focus()

            Else
                Try
                    negocio.GuardarTipoSorteo(CInt(TxtCodigo.Text), TxtTipo.Text)
                    MsgBox("Se ha registrado nuevo tipo de sorteo", vbOKOnly, vbInformation)

                Catch ex As Exception
                    MsgBox("Error, no se ha guardado el registro." And vbCrLf And ex.Message)

                End Try
            End If

        ElseIf estado = 2 Then
            If Me.TxtTipo.Text = Nothing Then
                MsgBox("El campo Tipo de sorteo no puede estar vacío", vbOKOnly, vbObjectError)
                Me.TxtTipo.Focus()

            Else
                Try
                    negocio.ActualizarTipoSorteo(CInt(TxtCodigo.Text), TxtTipo.Text)
                    MsgBox("Se ha modificado el tipo de sorteo", vbOKOnly, vbInformation)

                Catch ex As Exception
                    MsgBox("Error, no se ha modificado el registro." And vbCrLf And ex.Message)
                    estado = 0

                End Try

            End If
        End If
        estado = 0

        CargarTipoSorteo()

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        CargarTipoSorteo()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class