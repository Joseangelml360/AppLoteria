<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDetallesAdmon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDetallesAdmon))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtNumJugado2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtImporteDecimos = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TxtIdAdmon = New System.Windows.Forms.TextBox()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.CboModo = New System.Windows.Forms.ComboBox()
        Me.CboPagadoAbono = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DtFecha = New System.Windows.Forms.DateTimePicker()
        Me.TxtIdSorteo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNumJugado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtPagoPremios = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DgvDetallesAdmon = New System.Windows.Forms.DataGridView()
        Me.LblEjercicio = New System.Windows.Forms.Label()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtAdmon = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TxtIdResumen = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblEstado = New System.Windows.Forms.Label()
        Me.TxtImportePremios = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtsaldoPremios = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtPremiosAbonados = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TxtImporteAdeudado = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtSaldoDeudor = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtImportePagado = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.BtnVerTodos = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnVerResumen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDetallesAdmon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Movimientos con la administración de lotería"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtNumJugado2)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.TxtImporteDecimos)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.TxtIdAdmon)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.CboModo)
        Me.Panel1.Controls.Add(Me.CboPagadoAbono)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.DtFecha)
        Me.Panel1.Controls.Add(Me.TxtIdSorteo)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtNumJugado)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TxtImporte)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtPagoPremios)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtId)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(17, 107)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(238, 493)
        Me.Panel1.TabIndex = 2
        '
        'TxtNumJugado2
        '
        Me.TxtNumJugado2.Location = New System.Drawing.Point(118, 161)
        Me.TxtNumJugado2.Name = "TxtNumJugado2"
        Me.TxtNumJugado2.ReadOnly = True
        Me.TxtNumJugado2.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumJugado2.TabIndex = 28
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(8, 164)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 17)
        Me.Label22.TabIndex = 27
        Me.Label22.Text = "Núm. Jugado 2"
        '
        'TxtImporteDecimos
        '
        Me.TxtImporteDecimos.Location = New System.Drawing.Point(118, 231)
        Me.TxtImporteDecimos.Name = "TxtImporteDecimos"
        Me.TxtImporteDecimos.ReadOnly = True
        Me.TxtImporteDecimos.Size = New System.Drawing.Size(100, 22)
        Me.TxtImporteDecimos.TabIndex = 26
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(2, 234)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 17)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Importe décimos"
        '
        'TxtIdAdmon
        '
        Me.TxtIdAdmon.Location = New System.Drawing.Point(118, 94)
        Me.TxtIdAdmon.Name = "TxtIdAdmon"
        Me.TxtIdAdmon.ReadOnly = True
        Me.TxtIdAdmon.Size = New System.Drawing.Size(75, 22)
        Me.TxtIdAdmon.TabIndex = 8
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(123, 430)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(95, 30)
        Me.BtnGuardar.TabIndex = 22
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.undo16
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(13, 430)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 30)
        Me.BtnCancelar.TabIndex = 21
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(69, 298)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Modo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(82, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(30, 17)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "P/A"
        '
        'CboModo
        '
        Me.CboModo.FormattingEnabled = True
        Me.CboModo.Items.AddRange(New Object() {"T (Transferencia)", "E (Efectivo)"})
        Me.CboModo.Location = New System.Drawing.Point(118, 295)
        Me.CboModo.Name = "CboModo"
        Me.CboModo.Size = New System.Drawing.Size(100, 24)
        Me.CboModo.TabIndex = 18
        '
        'CboPagadoAbono
        '
        Me.CboPagadoAbono.FormattingEnabled = True
        Me.CboPagadoAbono.Items.AddRange(New Object() {"P (Pago)", "A (Abono)"})
        Me.CboPagadoAbono.Location = New System.Drawing.Point(118, 259)
        Me.CboPagadoAbono.Name = "CboPagadoAbono"
        Me.CboPagadoAbono.Size = New System.Drawing.Size(100, 24)
        Me.CboPagadoAbono.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 201)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Fecha apunte"
        '
        'DtFecha
        '
        Me.DtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtFecha.Location = New System.Drawing.Point(118, 198)
        Me.DtFecha.Name = "DtFecha"
        Me.DtFecha.Size = New System.Drawing.Size(100, 22)
        Me.DtFecha.TabIndex = 15
        '
        'TxtIdSorteo
        '
        Me.TxtIdSorteo.Location = New System.Drawing.Point(118, 60)
        Me.TxtIdSorteo.Name = "TxtIdSorteo"
        Me.TxtIdSorteo.ReadOnly = True
        Me.TxtIdSorteo.Size = New System.Drawing.Size(42, 22)
        Me.TxtIdSorteo.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(47, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Id Sorteo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Id Admon"
        '
        'TxtNumJugado
        '
        Me.TxtNumJugado.Location = New System.Drawing.Point(118, 128)
        Me.TxtNumJugado.Name = "TxtNumJugado"
        Me.TxtNumJugado.ReadOnly = True
        Me.TxtNumJugado.Size = New System.Drawing.Size(100, 22)
        Me.TxtNumJugado.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Núm. Jugado 1"
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(118, 331)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(100, 22)
        Me.TxtImporte.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(4, 334)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Importe pagado"
        '
        'TxtPagoPremios
        '
        Me.TxtPagoPremios.Location = New System.Drawing.Point(118, 365)
        Me.TxtPagoPremios.Name = "TxtPagoPremios"
        Me.TxtPagoPremios.Size = New System.Drawing.Size(100, 22)
        Me.TxtPagoPremios.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Importe Premios"
        '
        'TxtId
        '
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtId.Location = New System.Drawing.Point(118, 26)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(100, 22)
        Me.TxtId.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(93, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Entrada de datos"
        '
        'ListView1
        '
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(239, 167)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(48, 23)
        Me.ListView1.Sorting = System.Windows.Forms.SortOrder.Descending
        Me.ListView1.TabIndex = 24
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'DgvDetallesAdmon
        '
        Me.DgvDetallesAdmon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDetallesAdmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDetallesAdmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDetallesAdmon.Location = New System.Drawing.Point(262, 107)
        Me.DgvDetallesAdmon.MultiSelect = False
        Me.DgvDetallesAdmon.Name = "DgvDetallesAdmon"
        Me.DgvDetallesAdmon.ReadOnly = True
        Me.DgvDetallesAdmon.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.DgvDetallesAdmon.RowTemplate.Height = 24
        Me.DgvDetallesAdmon.Size = New System.Drawing.Size(1134, 336)
        Me.DgvDetallesAdmon.TabIndex = 3
        '
        'LblEjercicio
        '
        Me.LblEjercicio.AutoSize = True
        Me.LblEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjercicio.Location = New System.Drawing.Point(564, 30)
        Me.LblEjercicio.Name = "LblEjercicio"
        Me.LblEjercicio.Size = New System.Drawing.Size(157, 25)
        Me.LblEjercicio.TabIndex = 5
        Me.LblEjercicio.Text = "Ejercicio activo"
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.InsertFila1
        Me.BtnAñadir.Location = New System.Drawing.Point(262, 69)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(106, 30)
        Me.BtnAñadir.TabIndex = 4
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1316, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtAdmon)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Controls.Add(Me.TxtIdResumen)
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.TxtImportePremios)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.TxtsaldoPremios)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.TxtPremiosAbonados)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.TxtImporteAdeudado)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.TxtSaldoDeudor)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.TxtImportePagado)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Location = New System.Drawing.Point(262, 462)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1132, 137)
        Me.Panel2.TabIndex = 25
        '
        'TxtAdmon
        '
        Me.TxtAdmon.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtAdmon.Location = New System.Drawing.Point(255, 27)
        Me.TxtAdmon.Name = "TxtAdmon"
        Me.TxtAdmon.ReadOnly = True
        Me.TxtAdmon.Size = New System.Drawing.Size(459, 22)
        Me.TxtAdmon.TabIndex = 30
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(150, 29)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 17)
        Me.Label21.TabIndex = 29
        Me.Label21.Text = "Administración"
        '
        'TxtIdResumen
        '
        Me.TxtIdResumen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtIdResumen.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtIdResumen.Location = New System.Drawing.Point(66, 26)
        Me.TxtIdResumen.Name = "TxtIdResumen"
        Me.TxtIdResumen.ReadOnly = True
        Me.TxtIdResumen.Size = New System.Drawing.Size(24, 22)
        Me.TxtIdResumen.TabIndex = 28
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(8, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 17)
        Me.Label20.TabIndex = 26
        Me.Label20.Text = "Sorteo"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LblEstado)
        Me.GroupBox1.Location = New System.Drawing.Point(983, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(125, 67)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Estado Pagos"
        '
        'LblEstado
        '
        Me.LblEstado.AutoSize = True
        Me.LblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEstado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblEstado.Location = New System.Drawing.Point(15, 33)
        Me.LblEstado.Name = "LblEstado"
        Me.LblEstado.Size = New System.Drawing.Size(67, 20)
        Me.LblEstado.TabIndex = 0
        Me.LblEstado.Text = "Estado"
        '
        'TxtImportePremios
        '
        Me.TxtImportePremios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImportePremios.Location = New System.Drawing.Point(136, 99)
        Me.TxtImportePremios.Name = "TxtImportePremios"
        Me.TxtImportePremios.ReadOnly = True
        Me.TxtImportePremios.Size = New System.Drawing.Size(85, 22)
        Me.TxtImportePremios.TabIndex = 24
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 102)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(110, 17)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Importe Premios"
        '
        'TxtsaldoPremios
        '
        Me.TxtsaldoPremios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtsaldoPremios.Location = New System.Drawing.Point(629, 99)
        Me.TxtsaldoPremios.Name = "TxtsaldoPremios"
        Me.TxtsaldoPremios.ReadOnly = True
        Me.TxtsaldoPremios.Size = New System.Drawing.Size(85, 22)
        Me.TxtsaldoPremios.TabIndex = 22
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(525, 102)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(99, 17)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Saldo Premios"
        '
        'TxtPremiosAbonados
        '
        Me.TxtPremiosAbonados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtPremiosAbonados.Location = New System.Drawing.Point(388, 99)
        Me.TxtPremiosAbonados.Name = "TxtPremiosAbonados"
        Me.TxtPremiosAbonados.ReadOnly = True
        Me.TxtPremiosAbonados.Size = New System.Drawing.Size(85, 22)
        Me.TxtPremiosAbonados.TabIndex = 20
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(262, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(126, 17)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Premios abonados"
        '
        'TxtImporteAdeudado
        '
        Me.TxtImporteAdeudado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImporteAdeudado.Location = New System.Drawing.Point(136, 62)
        Me.TxtImporteAdeudado.Name = "TxtImporteAdeudado"
        Me.TxtImporteAdeudado.ReadOnly = True
        Me.TxtImporteAdeudado.Size = New System.Drawing.Size(85, 22)
        Me.TxtImporteAdeudado.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 17)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Importe Adeudado"
        '
        'TxtSaldoDeudor
        '
        Me.TxtSaldoDeudor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtSaldoDeudor.Location = New System.Drawing.Point(629, 62)
        Me.TxtSaldoDeudor.Name = "TxtSaldoDeudor"
        Me.TxtSaldoDeudor.ReadOnly = True
        Me.TxtSaldoDeudor.Size = New System.Drawing.Size(85, 22)
        Me.TxtSaldoDeudor.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(525, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(93, 17)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Saldo deudor"
        '
        'TxtImportePagado
        '
        Me.TxtImportePagado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TxtImportePagado.Location = New System.Drawing.Point(388, 62)
        Me.TxtImportePagado.Name = "TxtImportePagado"
        Me.TxtImportePagado.ReadOnly = True
        Me.TxtImportePagado.Size = New System.Drawing.Size(85, 22)
        Me.TxtImportePagado.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(274, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(108, 17)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Importe Pagado"
        '
        'Label14
        '
        Me.Label14.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(266, 454)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(200, 17)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Resumen de pagos Sorteo"
        '
        'BtnVerTodos
        '
        Me.BtnVerTodos.Image = Global.Presentacion.My.Resources.Resources.eye
        Me.BtnVerTodos.Location = New System.Drawing.Point(557, 69)
        Me.BtnVerTodos.Name = "BtnVerTodos"
        Me.BtnVerTodos.Size = New System.Drawing.Size(196, 30)
        Me.BtnVerTodos.TabIndex = 27
        Me.BtnVerTodos.Text = "Ver Todos movimientos"
        Me.BtnVerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVerTodos.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(17, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'BtnVerResumen
        '
        Me.BtnVerResumen.Image = Global.Presentacion.My.Resources.Resources.eye
        Me.BtnVerResumen.Location = New System.Drawing.Point(781, 69)
        Me.BtnVerResumen.Name = "BtnVerResumen"
        Me.BtnVerResumen.Size = New System.Drawing.Size(196, 30)
        Me.BtnVerResumen.TabIndex = 29
        Me.BtnVerResumen.Text = "Resumen por sorteo"
        Me.BtnVerResumen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVerResumen.UseVisualStyleBackColor = True
        '
        'FrmDetallesAdmon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 611)
        Me.Controls.Add(Me.BtnVerResumen)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnVerTodos)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LblEjercicio)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DgvDetallesAdmon)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDetallesAdmon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimientos con la administración de lotería"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDetallesAdmon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents CboModo As ComboBox
    Friend WithEvents CboPagadoAbono As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents DtFecha As DateTimePicker
    Friend WithEvents TxtIdSorteo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtIdAdmon As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNumJugado As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtImporte As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtPagoPremios As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DgvDetallesAdmon As DataGridView
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents LblEjercicio As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSaldoDeudor As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtImportePagado As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents BtnVerTodos As Button
    Friend WithEvents TxtImporteAdeudado As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtImporteDecimos As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtImportePremios As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtsaldoPremios As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtPremiosAbonados As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LblEstado As Label
    Friend WithEvents TxtIdResumen As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents TxtAdmon As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TxtNumJugado2 As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents BtnVerResumen As Button
End Class
