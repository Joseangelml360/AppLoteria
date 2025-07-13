Public Class InformeVendedores
    Private Sub InformeVendedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet.vendedores' Puede moverla o quitarla según sea necesario.
        Me.vendedoresTableAdapter.Fill(Me.dbcensosDataSet.vendedores)
        Me.Width = 1000
        Me.Height = 650


        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class