Imports Negocio
Public Class FrmLiquidacion
    Public ReadOnly negocio As New LiquidacionNegocio
    Public ReadOnly dato As New EjercicioActivoNegocio
    Public ReadOnly ventas As New DetalleVentasLoteriaNegocio
    Public ReadOnly admon As New DetallesAdmonNegocio
    Public ReadOnly vendor As New VendedoresNegocio
    Public ReadOnly sorteo As New SorteosNegocio
    Public ReadOnly save As New CalcularLiquidacion
    Private Sub FrmLiquidacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.LblEjercicio.Text = dato.GetEjercicioActivo

        save.RecalcularLiquidacion()

        Me.CboEjercicios.DataSource = negocio.GetLiquidacion
        Me.CboEjercicios.DisplayMember = "Ejercicio"
        Me.CboEjercicios.ValueMember = "Ejercicio"
        CargarDatos()
        Me.DgvLiquidacion.Columns(0).Width = 60
        Me.DgvLiquidacion.Columns(1).Width = 60
    End Sub

    Public Sub CargarDatos()
        Me.DgvLiquidacion.DataSource = negocio.GetLiquidacion
        Me.DgvLiquidacion.Refresh()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub CboEjercicios_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CboEjercicios.SelectedIndexChanged
        Dim valorSeleccionado As Integer

        ' Verifica si el ComboBox está usando un DataTable como origen de datos
        If TypeOf CboEjercicios.SelectedItem Is DataRowView Then
            valorSeleccionado = Convert.ToInt32(CType(CboEjercicios.SelectedItem, DataRowView)("Ejercicio"))
        Else
            valorSeleccionado = Convert.ToInt32(CboEjercicios.SelectedItem)
        End If

        Me.DgvLiquidacion.DataSource = negocio.GetLiquidacionFilter(valorSeleccionado)
    End Sub

    Private Sub BtnVerTodos_Click(sender As Object, e As EventArgs) Handles BtnVerTodos.Click
        CargarDatos()
        Me.DgvLiquidacion.Refresh()
    End Sub
End Class