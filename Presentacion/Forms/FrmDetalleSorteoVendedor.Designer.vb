<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetalleSorteoVendedor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.LblEjercicio = New System.Windows.Forms.Label()
        Me.DgvDetalleSorteos = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtSaldo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtEntregaParcial = New System.Windows.Forms.TextBox()
        Me.TxtDeuda = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtPptasDevueltas = New System.Windows.Forms.TextBox()
        Me.TxtIdVendor = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtPptasEntregadas = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtIdSorteo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        CType(Me.DgvDetalleSorteos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Detalle sorteos "
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1051, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'LblEjercicio
        '
        Me.LblEjercicio.AutoSize = True
        Me.LblEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjercicio.Location = New System.Drawing.Point(234, 13)
        Me.LblEjercicio.Name = "LblEjercicio"
        Me.LblEjercicio.Size = New System.Drawing.Size(92, 29)
        Me.LblEjercicio.TabIndex = 2
        Me.LblEjercicio.Text = "Label2"
        '
        'DgvDetalleSorteos
        '
        Me.DgvDetalleSorteos.AllowUserToAddRows = False
        Me.DgvDetalleSorteos.AllowUserToDeleteRows = False
        Me.DgvDetalleSorteos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetalleSorteos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetalleSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetalleSorteos.Location = New System.Drawing.Point(281, 98)
        Me.DgvDetalleSorteos.MultiSelect = False
        Me.DgvDetalleSorteos.Name = "DgvDetalleSorteos"
        Me.DgvDetalleSorteos.RowHeadersWidth = 51
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DgvDetalleSorteos.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DgvDetalleSorteos.RowTemplate.Height = 24
        Me.DgvDetalleSorteos.Size = New System.Drawing.Size(850, 339)
        Me.DgvDetalleSorteos.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.TxtSaldo)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtEntregaParcial)
        Me.Panel1.Controls.Add(Me.TxtDeuda)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtPptasDevueltas)
        Me.Panel1.Controls.Add(Me.TxtIdVendor)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtPptasEntregadas)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.TxtIdSorteo)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(20, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 365)
        Me.Panel1.TabIndex = 4
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(132, 322)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(92, 30)
        Me.BtnGuardar.TabIndex = 18
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.undo16
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(16, 322)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(92, 30)
        Me.BtnCancelar.TabIndex = 17
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtSaldo
        '
        Me.TxtSaldo.Location = New System.Drawing.Point(132, 255)
        Me.TxtSaldo.Name = "TxtSaldo"
        Me.TxtSaldo.ReadOnly = True
        Me.TxtSaldo.Size = New System.Drawing.Size(67, 22)
        Me.TxtSaldo.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 258)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Saldo"
        '
        'TxtEntregaParcial
        '
        Me.TxtEntregaParcial.Location = New System.Drawing.Point(132, 197)
        Me.TxtEntregaParcial.Name = "TxtEntregaParcial"
        Me.TxtEntregaParcial.ReadOnly = True
        Me.TxtEntregaParcial.Size = New System.Drawing.Size(67, 22)
        Me.TxtEntregaParcial.TabIndex = 14
        '
        'TxtDeuda
        '
        Me.TxtDeuda.Location = New System.Drawing.Point(132, 227)
        Me.TxtDeuda.Name = "TxtDeuda"
        Me.TxtDeuda.ReadOnly = True
        Me.TxtDeuda.Size = New System.Drawing.Size(67, 22)
        Me.TxtDeuda.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(40, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Id Vendedor"
        '
        'TxtPptasDevueltas
        '
        Me.TxtPptasDevueltas.Location = New System.Drawing.Point(132, 169)
        Me.TxtPptasDevueltas.Name = "TxtPptasDevueltas"
        Me.TxtPptasDevueltas.ReadOnly = True
        Me.TxtPptasDevueltas.Size = New System.Drawing.Size(67, 22)
        Me.TxtPptasDevueltas.TabIndex = 10
        '
        'TxtIdVendor
        '
        Me.TxtIdVendor.Location = New System.Drawing.Point(132, 84)
        Me.TxtIdVendor.Name = "TxtIdVendor"
        Me.TxtIdVendor.ReadOnly = True
        Me.TxtIdVendor.Size = New System.Drawing.Size(67, 22)
        Me.TxtIdVendor.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(39, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total Deuda"
        '
        'TxtPptasEntregadas
        '
        Me.TxtPptasEntregadas.Location = New System.Drawing.Point(132, 141)
        Me.TxtPptasEntregadas.Name = "TxtPptasEntregadas"
        Me.TxtPptasEntregadas.ReadOnly = True
        Me.TxtPptasEntregadas.Size = New System.Drawing.Size(67, 22)
        Me.TxtPptasEntregadas.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 17)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Pap. Devueltas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 144)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pap. Entregadas"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 200)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Entrega parcial"
        '
        'TxtIdSorteo
        '
        Me.TxtIdSorteo.Location = New System.Drawing.Point(132, 56)
        Me.TxtIdSorteo.Name = "TxtIdSorteo"
        Me.TxtIdSorteo.ReadOnly = True
        Me.TxtIdSorteo.Size = New System.Drawing.Size(67, 22)
        Me.TxtIdSorteo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Id Sorteo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 19)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Entrada de datos"
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Presentacion.My.Resources.Resources.table_row_delete1
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(501, 63)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(87, 30)
        Me.BtnEliminar.TabIndex = 20
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(706, 76)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 22)
        Me.TextBox1.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(706, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Seleccionar vendedor"
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Presentacion.My.Resources.Resources.Modificar
        Me.BtnEditar.Location = New System.Drawing.Point(391, 63)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(87, 30)
        Me.BtnEditar.TabIndex = 19
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.InsertFila1
        Me.BtnAñadir.Location = New System.Drawing.Point(281, 63)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(87, 30)
        Me.BtnAñadir.TabIndex = 18
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'FrmDetalleSorteoVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblEjercicio)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDetalleSorteos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetalleSorteoVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle Sorteo Vendedor"
        CType(Me.DgvDetalleSorteos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents LblEjercicio As Label
    Friend WithEvents DgvDetalleSorteos As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtSaldo As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtEntregaParcial As TextBox
    Friend WithEvents TxtDeuda As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPptasDevueltas As TextBox
    Friend WithEvents TxtIdVendor As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtPptasEntregadas As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtIdSorteo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
End Class
