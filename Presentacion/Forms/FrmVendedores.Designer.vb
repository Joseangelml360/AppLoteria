<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVendedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmVendedores))
        Me.DgvDbCensosFallero = New System.Windows.Forms.DataGridView()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtAñadirNUevo = New System.Windows.Forms.TextBox()
        Me.LblBuscar = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ChkLoteria = New System.Windows.Forms.CheckBox()
        Me.TxtACuotas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellidos = New System.Windows.Forms.TextBox()
        Me.LblPanel = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtLoteria = New System.Windows.Forms.TextBox()
        Me.TxtComision = New System.Windows.Forms.TextBox()
        Me.TxtPagado = New System.Windows.Forms.TextBox()
        Me.TxtBeneficio = New System.Windows.Forms.TextBox()
        Me.TxtValAsignado = New System.Windows.Forms.TextBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtEjercicio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DgvVendedores = New System.Windows.Forms.DataGridView()
        Me.LblMayores = New System.Windows.Forms.Label()
        Me.LblJuveniles = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnInforme = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvDbCensosFallero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvDbCensosFallero
        '
        Me.DgvDbCensosFallero.AllowUserToAddRows = False
        Me.DgvDbCensosFallero.AllowUserToDeleteRows = False
        Me.DgvDbCensosFallero.AllowUserToResizeRows = False
        Me.DgvDbCensosFallero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDbCensosFallero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DgvDbCensosFallero.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.DgvDbCensosFallero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDbCensosFallero.Location = New System.Drawing.Point(329, 156)
        Me.DgvDbCensosFallero.Name = "DgvDbCensosFallero"
        Me.DgvDbCensosFallero.ReadOnly = True
        Me.DgvDbCensosFallero.RowHeadersVisible = False
        Me.DgvDbCensosFallero.RowHeadersWidth = 51
        Me.DgvDbCensosFallero.RowTemplate.Height = 24
        Me.DgvDbCensosFallero.Size = New System.Drawing.Size(498, 384)
        Me.DgvDbCensosFallero.TabIndex = 36
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(60, 82)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(361, 22)
        Me.TxtBuscar.TabIndex = 35
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(244, 25)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "Administrar Vendedores"
        '
        'TxtAñadirNUevo
        '
        Me.TxtAñadirNUevo.Location = New System.Drawing.Point(448, 128)
        Me.TxtAñadirNUevo.Name = "TxtAñadirNUevo"
        Me.TxtAñadirNUevo.Size = New System.Drawing.Size(229, 22)
        Me.TxtAñadirNUevo.TabIndex = 37
        '
        'LblBuscar
        '
        Me.LblBuscar.AutoSize = True
        Me.LblBuscar.Location = New System.Drawing.Point(3, 78)
        Me.LblBuscar.Name = "LblBuscar"
        Me.LblBuscar.Size = New System.Drawing.Size(52, 17)
        Me.LblBuscar.TabIndex = 33
        Me.LblBuscar.Text = "Buscar"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1250, 6)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 32)
        Me.BtnSalir.TabIndex = 29
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.ChkLoteria)
        Me.Panel1.Controls.Add(Me.TxtACuotas)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TxtApellidos)
        Me.Panel1.Controls.Add(Me.LblPanel)
        Me.Panel1.Controls.Add(Me.TxtNombre)
        Me.Panel1.Controls.Add(Me.TxtLoteria)
        Me.Panel1.Controls.Add(Me.TxtComision)
        Me.Panel1.Controls.Add(Me.TxtPagado)
        Me.Panel1.Controls.Add(Me.TxtBeneficio)
        Me.Panel1.Controls.Add(Me.TxtValAsignado)
        Me.Panel1.Controls.Add(Me.TxtCodigo)
        Me.Panel1.Controls.Add(Me.TxtEjercicio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.BtnCancel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Location = New System.Drawing.Point(1051, 112)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(279, 479)
        Me.Panel1.TabIndex = 28
        '
        'ChkLoteria
        '
        Me.ChkLoteria.AutoSize = True
        Me.ChkLoteria.Location = New System.Drawing.Point(71, 227)
        Me.ChkLoteria.Name = "ChkLoteria"
        Me.ChkLoteria.Size = New System.Drawing.Size(74, 21)
        Me.ChkLoteria.TabIndex = 29
        Me.ChkLoteria.Text = "Loteria"
        Me.ChkLoteria.UseVisualStyleBackColor = True
        '
        'TxtACuotas
        '
        Me.TxtACuotas.Location = New System.Drawing.Point(90, 366)
        Me.TxtACuotas.Name = "TxtACuotas"
        Me.TxtACuotas.ReadOnly = True
        Me.TxtACuotas.Size = New System.Drawing.Size(100, 22)
        Me.TxtACuotas.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 369)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "A Cuotas"
        '
        'TxtApellidos
        '
        Me.TxtApellidos.Location = New System.Drawing.Point(90, 189)
        Me.TxtApellidos.Name = "TxtApellidos"
        Me.TxtApellidos.ReadOnly = True
        Me.TxtApellidos.Size = New System.Drawing.Size(170, 22)
        Me.TxtApellidos.TabIndex = 24
        '
        'LblPanel
        '
        Me.LblPanel.AutoSize = True
        Me.LblPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPanel.Location = New System.Drawing.Point(7, -2)
        Me.LblPanel.Name = "LblPanel"
        Me.LblPanel.Size = New System.Drawing.Size(173, 19)
        Me.LblPanel.TabIndex = 26
        Me.LblPanel.Text = "Añadir fallero a lotería"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(90, 149)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.ReadOnly = True
        Me.TxtNombre.Size = New System.Drawing.Size(170, 22)
        Me.TxtNombre.TabIndex = 18
        '
        'TxtLoteria
        '
        Me.TxtLoteria.Location = New System.Drawing.Point(135, 227)
        Me.TxtLoteria.Name = "TxtLoteria"
        Me.TxtLoteria.Size = New System.Drawing.Size(55, 22)
        Me.TxtLoteria.TabIndex = 23
        Me.TxtLoteria.Visible = False
        '
        'TxtComision
        '
        Me.TxtComision.Location = New System.Drawing.Point(90, 265)
        Me.TxtComision.Name = "TxtComision"
        Me.TxtComision.ReadOnly = True
        Me.TxtComision.Size = New System.Drawing.Size(100, 22)
        Me.TxtComision.TabIndex = 22
        '
        'TxtPagado
        '
        Me.TxtPagado.Location = New System.Drawing.Point(90, 336)
        Me.TxtPagado.Name = "TxtPagado"
        Me.TxtPagado.Size = New System.Drawing.Size(100, 22)
        Me.TxtPagado.TabIndex = 21
        '
        'TxtBeneficio
        '
        Me.TxtBeneficio.Location = New System.Drawing.Point(90, 394)
        Me.TxtBeneficio.Name = "TxtBeneficio"
        Me.TxtBeneficio.ReadOnly = True
        Me.TxtBeneficio.Size = New System.Drawing.Size(100, 22)
        Me.TxtBeneficio.TabIndex = 20
        '
        'TxtValAsignado
        '
        Me.TxtValAsignado.Location = New System.Drawing.Point(90, 303)
        Me.TxtValAsignado.Name = "TxtValAsignado"
        Me.TxtValAsignado.Size = New System.Drawing.Size(100, 22)
        Me.TxtValAsignado.TabIndex = 19
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(90, 113)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodigo.TabIndex = 18
        '
        'TxtEjercicio
        '
        Me.TxtEjercicio.Location = New System.Drawing.Point(90, 75)
        Me.TxtEjercicio.Name = "TxtEjercicio"
        Me.TxtEjercicio.ReadOnly = True
        Me.TxtEjercicio.Size = New System.Drawing.Size(100, 22)
        Me.TxtEjercicio.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ejercicio"
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(161, 447)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(99, 32)
        Me.BtnGuardar.TabIndex = 3
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Image = Global.Presentacion.My.Resources.Resources.undo16
        Me.BtnCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancel.Location = New System.Drawing.Point(10, 447)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(99, 32)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancelar"
        Me.BtnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Codigo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellidos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Comision"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Asignación"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 339)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Pagado"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(40, 397)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 17)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Saldo"
        '
        'DgvVendedores
        '
        Me.DgvVendedores.AllowUserToAddRows = False
        Me.DgvVendedores.AllowUserToDeleteRows = False
        Me.DgvVendedores.AllowUserToOrderColumns = True
        Me.DgvVendedores.AllowUserToResizeRows = False
        Me.DgvVendedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVendedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DgvVendedores.Location = New System.Drawing.Point(2, 112)
        Me.DgvVendedores.MultiSelect = False
        Me.DgvVendedores.Name = "DgvVendedores"
        Me.DgvVendedores.ReadOnly = True
        Me.DgvVendedores.RowHeadersWidth = 51
        Me.DgvVendedores.RowTemplate.Height = 24
        Me.DgvVendedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvVendedores.Size = New System.Drawing.Size(1035, 467)
        Me.DgvVendedores.TabIndex = 27
        '
        'LblMayores
        '
        Me.LblMayores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblMayores.AutoSize = True
        Me.LblMayores.Location = New System.Drawing.Point(47, 586)
        Me.LblMayores.Name = "LblMayores"
        Me.LblMayores.Size = New System.Drawing.Size(62, 17)
        Me.LblMayores.TabIndex = 40
        Me.LblMayores.Text = "Mayores"
        '
        'LblJuveniles
        '
        Me.LblJuveniles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LblJuveniles.AutoSize = True
        Me.LblJuveniles.Location = New System.Drawing.Point(253, 585)
        Me.LblJuveniles.Name = "LblJuveniles"
        Me.LblJuveniles.Size = New System.Drawing.Size(67, 17)
        Me.LblJuveniles.TabIndex = 41
        Me.LblJuveniles.Text = "Juveniles"
        '
        'Button1
        '
        Me.Button1.Image = Global.Presentacion.My.Resources.Resources.DocumentoAzul
        Me.Button1.Location = New System.Drawing.Point(462, 73)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(212, 34)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Importar Vendedores"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnInforme
        '
        Me.BtnInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnInforme.Image = Global.Presentacion.My.Resources.Resources.report
        Me.BtnInforme.Location = New System.Drawing.Point(1094, 75)
        Me.BtnInforme.Name = "BtnInforme"
        Me.BtnInforme.Size = New System.Drawing.Size(112, 30)
        Me.BtnInforme.TabIndex = 38
        Me.BtnInforme.Text = "Ver informe"
        Me.BtnInforme.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnInforme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnInforme.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Presentacion.My.Resources.Resources.cancel1
        Me.BtnEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnEliminar.Location = New System.Drawing.Point(946, 72)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(92, 32)
        Me.BtnEliminar.TabIndex = 32
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Presentacion.My.Resources.Resources.Modificar
        Me.BtnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnEditar.Location = New System.Drawing.Point(845, 72)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(92, 32)
        Me.BtnEditar.TabIndex = 31
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.InsertFila1
        Me.BtnAñadir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAñadir.Location = New System.Drawing.Point(744, 72)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(92, 32)
        Me.BtnAñadir.TabIndex = 30
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'FrmVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1346, 620)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblJuveniles)
        Me.Controls.Add(Me.LblMayores)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BtnInforme)
        Me.Controls.Add(Me.DgvDbCensosFallero)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtAñadirNUevo)
        Me.Controls.Add(Me.LblBuscar)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DgvVendedores)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVendedoresPresentacion"
        CType(Me.DgvDbCensosFallero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnInforme As Button
    Friend WithEvents DgvDbCensosFallero As DataGridView
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtAñadirNUevo As TextBox
    Friend WithEvents LblBuscar As Label
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtApellidos As TextBox
    Friend WithEvents LblPanel As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents TxtLoteria As TextBox
    Friend WithEvents TxtComision As TextBox
    Friend WithEvents TxtPagado As TextBox
    Friend WithEvents TxtBeneficio As TextBox
    Friend WithEvents TxtValAsignado As TextBox
    Friend WithEvents TxtCodigo As TextBox
    Friend WithEvents TxtEjercicio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DgvVendedores As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TxtACuotas As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ChkLoteria As CheckBox
    Friend WithEvents LblMayores As Label
    Friend WithEvents LblJuveniles As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
