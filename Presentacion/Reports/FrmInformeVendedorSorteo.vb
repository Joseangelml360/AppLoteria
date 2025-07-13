Imports Negocio
Public Class FrmInformeVendedorSorteo
    Public ReadOnly eje As New EjercicioActivoNegocio
    Public ReadOnly vendor As New VendedoresNegocio
    Public ReadOnly Neje As Integer = eje.GetEjercicioActivo
    Private Sub FrmInformeVendedorSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim codigo As Integer

        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet.vendedores' Puede moverla o quitarla según sea necesario.
        Me.vendedoresTableAdapter.FillByCodigo(Me.dbcensosDataSet.vendedores, codigo)

        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet.VendedorSorteo' Puede moverla o quitarla según sea necesario.
        Me.VendedorSorteoTableAdapter.Fill(Me.dbcensosDataSet.VendedorSorteo, Neje, codigo)
        Me.ReportViewer1.RefreshReport()

        Me.TxtBuscar.Visible = False
        Me.DgvVendedores.Visible = False
        Me.DgvVendedores.Height = 200

        Me.DgvVendedores.DataSource = vendor.GetlistaVendedores(Neje)
        Me.DgvVendedores.Columns(0).Visible = False
        Me.DgvVendedores.Columns(4).Visible = False
        Me.DgvVendedores.Columns(5).Visible = False
        Me.DgvVendedores.Columns(6).Visible = False
        Me.DgvVendedores.Columns(7).Visible = False
        Me.DgvVendedores.Columns(8).Visible = False
        Me.DgvVendedores.Columns(9).Visible = False

        Me.DgvVendedores.Columns(1).Width = 50
        Me.DgvVendedores.Columns(2).Width = 100
        Me.DgvVendedores.Columns(3).Width = 220

    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnSelectVendor_Click(sender As Object, e As EventArgs) Handles BtnSelectVendor.Click
        Me.TxtBuscar.Visible = True
        Me.DgvVendedores.Visible = True
        Me.DgvVendedores.Refresh()
        Me.TxtBuscar.Focus()

    End Sub

    Private Sub DgvVendedores_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvVendedores.CellContentClick
        Me.DgvVendedores.Visible = False
        Me.CodigoTextBox.Text = Me.DgvVendedores.CurrentRow.Cells("Codigo").Value
        Me.NombreTextBox.Text = Me.DgvVendedores.CurrentRow.Cells("Nombre").Value
        Me.ApellidosTextBox.Text = Me.DgvVendedores.CurrentRow.Cells("Apellidos").Value
        Me.TxtBuscar.Visible = False
        Me.VendedorSorteoTableAdapter.Fill(Me.dbcensosDataSet.VendedorSorteo, Neje, CInt(Me.CodigoTextBox.Text))
        Me.vendedoresTableAdapter.FillByCodigo(Me.dbcensosDataSet.vendedores, CInt(Me.CodigoTextBox.Text))
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub TxtBuscar_TextChanged(sender As Object, e As EventArgs) Handles TxtBuscar.TextChanged
        'Dim Neje As Integer = eje.GetEjercicioActivo
        Dim vista As New DataView(vendor.GetlistaVendedores(Neje))

        If TxtBuscar.Text <> "" Then
            vista.RowFilter = $"Apellidos LIKE '%{TxtBuscar.Text}%'"
        End If
        If TxtBuscar.Text <> "" AndAlso IsNumeric(TxtBuscar.Text) Then
            vista.RowFilter = $"Codigo = {TxtBuscar.Text}"
        End If
        DgvVendedores.DataSource = vista

    End Sub
End Class