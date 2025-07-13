Imports System.Windows.Forms

Public Class MDIParent1

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub VendedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendedoresToolStripMenuItem1.Click
        Dim frm As New FrmVendedores With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub DetalleVendedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetalleVendedorToolStripMenuItem.Click
        Dim frm As New FrmDetalleVentasLoteria With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub NuevoSorteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Dim frm As New FrmSorteos With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub TiposDeSorteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiposDeSorteoToolStripMenuItem.Click
        Dim frm As New FrmTipoSorteo With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub ApuntesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApuntesToolStripMenuItem.Click
        Dim frm As New FrmLibroCaja With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub LiquidaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiquidaciónToolStripMenuItem.Click
        Dim frm As New FrmLiquidacion With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub Administraciones_Click(sender As Object, e As EventArgs) Handles Administraciones.Click
        Dim frm As New FrmAdministraciones With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub DetallesAdmon_Click(sender As Object, e As EventArgs) Handles DetallesAdmon.Click
        Dim frm As New FrmDetallesAdmon With {.MdiParent = Me}
        frm.Show()
    End Sub

    'Private Sub MDIParent1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    'End Sub

    Private Sub CerrarAplicaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarAplicaciónToolStripMenuItem.Click
        Me.Close()

    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click
        Dim frm As New InformeVendedores With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub InformeResumenMovimientosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeResumenMovimientosToolStripMenuItem.Click
        Dim frm As New FrmInformePagosAdmon With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub InformeDetallesDeVentaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeDetallesDeVentaToolStripMenuItem.Click
        Dim frm As New FrmInformeVendedorSorteo With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        Dim frm As New AboutBox1 With {.MdiParent = Me}
        frm.Show()
    End Sub

    Private Sub HojaLiquidaciónSorteoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HojaLiquidaciónSorteoToolStripMenuItem.Click
        Dim frm As New FrmHojaLiquidacionSorteo With {.MdiParent = Me}
        frm.Show()
    End Sub
End Class
