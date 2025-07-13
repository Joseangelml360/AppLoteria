<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.VendedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetalleVendedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeDetallesDeVentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LibroDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApuntesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiquidaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SorteosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TiposDeSorteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HojaLiquidaciónSorteoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdministracionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallesAdmon = New System.Windows.Forms.ToolStripMenuItem()
        Me.Administraciones = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformeResumenMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarAplicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendedoresToolStripMenuItem, Me.LibroDeCajaToolStripMenuItem, Me.SorteosToolStripMenuItem, Me.AdministracionesToolStripMenuItem, Me.ToolsMenu, Me.WindowsMenu, Me.ViewMenu, Me.HelpMenu, Me.CerrarAplicaciónToolStripMenuItem})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1101, 38)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'VendedoresToolStripMenuItem
        '
        Me.VendedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetalleVendedorToolStripMenuItem, Me.VendedoresToolStripMenuItem1, Me.InformeToolStripMenuItem, Me.InformeDetallesDeVentaToolStripMenuItem})
        Me.VendedoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedoresToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.VendedoresToolStripMenuItem.Name = "VendedoresToolStripMenuItem"
        Me.VendedoresToolStripMenuItem.Size = New System.Drawing.Size(105, 24)
        Me.VendedoresToolStripMenuItem.Text = "Vendedores"
        '
        'DetalleVendedorToolStripMenuItem
        '
        Me.DetalleVendedorToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.decimo_loteria
        Me.DetalleVendedorToolStripMenuItem.Name = "DetalleVendedorToolStripMenuItem"
        Me.DetalleVendedorToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.DetalleVendedorToolStripMenuItem.Text = "Ventas de lotería"
        '
        'VendedoresToolStripMenuItem1
        '
        Me.VendedoresToolStripMenuItem1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedoresToolStripMenuItem1.Image = Global.Presentacion.My.Resources.Resources.usuarios
        Me.VendedoresToolStripMenuItem1.Name = "VendedoresToolStripMenuItem1"
        Me.VendedoresToolStripMenuItem1.Size = New System.Drawing.Size(288, 26)
        Me.VendedoresToolStripMenuItem1.Text = "Vendedores"
        '
        'InformeToolStripMenuItem
        '
        Me.InformeToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.report
        Me.InformeToolStripMenuItem.Name = "InformeToolStripMenuItem"
        Me.InformeToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.InformeToolStripMenuItem.Text = "Informe"
        '
        'InformeDetallesDeVentaToolStripMenuItem
        '
        Me.InformeDetallesDeVentaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeDetallesDeVentaToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Usuario
        Me.InformeDetallesDeVentaToolStripMenuItem.Name = "InformeDetallesDeVentaToolStripMenuItem"
        Me.InformeDetallesDeVentaToolStripMenuItem.Size = New System.Drawing.Size(288, 26)
        Me.InformeDetallesDeVentaToolStripMenuItem.Text = "Informe detalles de vendedor"
        '
        'LibroDeCajaToolStripMenuItem
        '
        Me.LibroDeCajaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApuntesToolStripMenuItem, Me.LiquidaciónToolStripMenuItem})
        Me.LibroDeCajaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LibroDeCajaToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.LibroDeCajaToolStripMenuItem.Name = "LibroDeCajaToolStripMenuItem"
        Me.LibroDeCajaToolStripMenuItem.Size = New System.Drawing.Size(113, 24)
        Me.LibroDeCajaToolStripMenuItem.Text = "Libro de Caja"
        '
        'ApuntesToolStripMenuItem
        '
        Me.ApuntesToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.money
        Me.ApuntesToolStripMenuItem.Name = "ApuntesToolStripMenuItem"
        Me.ApuntesToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.ApuntesToolStripMenuItem.Text = "Apuntes"
        '
        'LiquidaciónToolStripMenuItem
        '
        Me.LiquidaciónToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LiquidaciónToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Contabilidad
        Me.LiquidaciónToolStripMenuItem.Name = "LiquidaciónToolStripMenuItem"
        Me.LiquidaciónToolStripMenuItem.Size = New System.Drawing.Size(169, 26)
        Me.LiquidaciónToolStripMenuItem.Text = "Liquidación"
        '
        'SorteosToolStripMenuItem
        '
        Me.SorteosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem, Me.TiposDeSorteoToolStripMenuItem, Me.HojaLiquidaciónSorteoToolStripMenuItem})
        Me.SorteosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SorteosToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.SorteosToolStripMenuItem.Name = "SorteosToolStripMenuItem"
        Me.SorteosToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SorteosToolStripMenuItem.Text = "Sorteos"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Bombo_loteria
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.NuevoToolStripMenuItem.Text = "Sorteo"
        '
        'TiposDeSorteoToolStripMenuItem
        '
        Me.TiposDeSorteoToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TiposDeSorteoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.Modificar
        Me.TiposDeSorteoToolStripMenuItem.Name = "TiposDeSorteoToolStripMenuItem"
        Me.TiposDeSorteoToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.TiposDeSorteoToolStripMenuItem.Text = "Tipos de sorteo"
        '
        'HojaLiquidaciónSorteoToolStripMenuItem
        '
        Me.HojaLiquidaciónSorteoToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.report
        Me.HojaLiquidaciónSorteoToolStripMenuItem.Name = "HojaLiquidaciónSorteoToolStripMenuItem"
        Me.HojaLiquidaciónSorteoToolStripMenuItem.Size = New System.Drawing.Size(253, 26)
        Me.HojaLiquidaciónSorteoToolStripMenuItem.Text = "Hoja liquidación sorteo"
        '
        'AdministracionesToolStripMenuItem
        '
        Me.AdministracionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallesAdmon, Me.Administraciones, Me.InformeResumenMovimientosToolStripMenuItem})
        Me.AdministracionesToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdministracionesToolStripMenuItem.Margin = New System.Windows.Forms.Padding(20, 5, 20, 5)
        Me.AdministracionesToolStripMenuItem.Name = "AdministracionesToolStripMenuItem"
        Me.AdministracionesToolStripMenuItem.Size = New System.Drawing.Size(145, 24)
        Me.AdministracionesToolStripMenuItem.Text = "Administraciones"
        '
        'DetallesAdmon
        '
        Me.DetallesAdmon.Image = Global.Presentacion.My.Resources.Resources.calculadora
        Me.DetallesAdmon.Name = "DetallesAdmon"
        Me.DetallesAdmon.Size = New System.Drawing.Size(298, 26)
        Me.DetallesAdmon.Text = "Movimientos"
        '
        'Administraciones
        '
        Me.Administraciones.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Administraciones.Image = Global.Presentacion.My.Resources.Resources.Admon
        Me.Administraciones.Name = "Administraciones"
        Me.Administraciones.Size = New System.Drawing.Size(298, 26)
        Me.Administraciones.Text = "Administraciones"
        '
        'InformeResumenMovimientosToolStripMenuItem
        '
        Me.InformeResumenMovimientosToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InformeResumenMovimientosToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.report
        Me.InformeResumenMovimientosToolStripMenuItem.Name = "InformeResumenMovimientosToolStripMenuItem"
        Me.InformeResumenMovimientosToolStripMenuItem.Size = New System.Drawing.Size(298, 26)
        Me.InformeResumenMovimientosToolStripMenuItem.Text = "Informe Resumen movimientos"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Margin = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(112, 34)
        Me.ToolsMenu.Text = "&Herramientas"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(154, 26)
        Me.OptionsToolStripMenuItem.Text = "&Opciones"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(82, 34)
        Me.WindowsMenu.Text = "&Ventanas"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.NewWindowToolStripMenuItem.Text = "&Nueva ventana"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.CascadeToolStripMenuItem.Text = "&Cascada"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.TileVerticalToolStripMenuItem.Text = "Mosaico &vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.TileHorizontalToolStripMenuItem.Text = "Mosaico &horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.CloseAllToolStripMenuItem.Text = "C&errar todo"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(219, 26)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Organizar iconos"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 34)
        Me.ViewMenu.Text = "&Ver"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.ToolBarToolStripMenuItem.Text = "&Barra de herramientas"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(238, 26)
        Me.StatusBarToolStripMenuItem.Text = "&Barra de estado"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(65, 34)
        Me.HelpMenu.Text = "Ay&uda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.ContentsToolStripMenuItem.Text = "&Contenido"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.SearchToolStripMenuItem.Text = "&Buscar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(215, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(218, 26)
        Me.AboutToolStripMenuItem.Text = "&Acerca de..."
        '
        'CerrarAplicaciónToolStripMenuItem
        '
        Me.CerrarAplicaciónToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CerrarAplicaciónToolStripMenuItem.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.CerrarAplicaciónToolStripMenuItem.Name = "CerrarAplicaciónToolStripMenuItem"
        Me.CerrarAplicaciónToolStripMenuItem.Size = New System.Drawing.Size(155, 34)
        Me.CerrarAplicaciónToolStripMenuItem.Text = "Cerrar aplicación"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 532)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Padding = New System.Windows.Forms.Padding(1, 0, 19, 0)
        Me.StatusStrip.Size = New System.Drawing.Size(1101, 26)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripStatusLabel.Text = "Estado"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1101, 558)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MDIParent1"
        Me.Text = "Módulo Lotería"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AdministracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SorteosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LibroDeCajaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DetalleVendedorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Administraciones As ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TiposDeSorteoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApuntesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LiquidaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DetallesAdmon As ToolStripMenuItem
    Friend WithEvents CerrarAplicaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeResumenMovimientosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InformeDetallesDeVentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HojaLiquidaciónSorteoToolStripMenuItem As ToolStripMenuItem
End Class
