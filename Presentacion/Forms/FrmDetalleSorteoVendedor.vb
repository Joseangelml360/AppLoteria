Imports Negocio
Public Class FrmDetalleSorteoVendedor
    Public ReadOnly detalle As New DetalleSorteoVendedorNegocio
    Public ReadOnly eje As New EjercicioActivoNegocio

    Private Sub FrmDetalleSorteoVendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblEjercicio.Text = eje.GetEjercicioActivo
        Cargar()
    End Sub

    Private Sub Cargar()
        Me.DgvDetalleSorteos.DataSource = detalle.GetDetalleSorteoVendorTodos(CInt(Me.LblEjercicio.Text))
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Limpiar()
    End Sub

    Private Sub Limpiar()
        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                c.Text = 0
            End If
        Next
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

    End Sub
End Class