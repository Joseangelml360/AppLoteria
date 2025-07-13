Public Class FrmInformePagosAdmon
    Private Sub FrmInformePagosAdmon_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet.pagosadmon' Puede moverla o quitarla según sea necesario.
        Me.pagosadmonTableAdapter.Fill(Me.dbcensosDataSet.pagosadmon)
        'TODO: esta línea de código carga datos en la tabla 'dbcensosDataSet.detallesadmon' Puede moverla o quitarla según sea necesario.


        Me.Width = 1000
        Me.Height = 600

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnResumen_Click(sender As Object, e As EventArgs) Handles BtnResumen.Click
        Me.pagosadmonTableAdapter.Fill(Me.dbcensosDataSet.pagosadmon)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnTodosMovimientos_Click(sender As Object, e As EventArgs) Handles BtnTodosMovimientos.Click
        Me.pagosadmonTableAdapter.FillByTodos(Me.dbcensosDataSet.pagosadmon)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class