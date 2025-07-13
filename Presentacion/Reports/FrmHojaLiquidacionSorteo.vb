Imports Microsoft.Reporting.WinForms

Public Class FrmHojaLiquidacionSorteo
    Private Sub FrmHojaLiquidacionSorteo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.administraciones' Puede moverla o quitarla según sea necesario.
        Me.administracionesTableAdapter.Fill(Me.DbcensosDataSet.administraciones)
        'TODO: esta línea de código carga datos en la tabla 'DbcensosDataSet.sorteos' Puede moverla o quitarla según sea necesario.
        Me.SorteosTableAdapter.Fill(Me.DbcensosDataSet.sorteos)

        Me.ReportViewer1.RefreshReport()
        Me.DgvSorteos.Visible = False
        Me.DgvSorteos.Height = 250
        Me.Height = 700


    End Sub

    Private Sub DgvSorteos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvSorteos.CellContentClick
        Dim n As Integer
        Dim i As Integer = DgvSorteos.CurrentRow.Cells(0).Value
        Me.SorteosTableAdapter.FillByIdSorteo(Me.DbcensosDataSet.sorteos, i)
        Me.ReportViewer1.RefreshReport()
        Me.DgvSorteos.Visible = False
        If DgvSorteos.CurrentRow.Cells("NumeroJugado").Value > 0 Then
            n += 1
        End If
        If DgvSorteos.CurrentRow.Cells("NumeroJugado2").Value > 0 Then
            n += 1
        End If
        ' Crear el parámetro
        Dim parametros As New List(Of ReportParameter) From {
            New ReportParameter("ReportParameter1", n)
        }
        ' Asignar parámetros antes de refrescar el informe
        ReportViewer1.LocalReport.SetParameters(parametros)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub BtnSelectSorteo_Click(sender As Object, e As EventArgs) Handles BtnSelectSorteo.Click
        Me.DgvSorteos.Visible = True
        Me.SorteosTableAdapter.Fill(DbcensosDataSet.sorteos)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub
End Class