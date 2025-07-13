<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmSorteos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSorteos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtPremioNum2 = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.TxtPremioNum1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TxtNumJugado2 = New System.Windows.Forms.TextBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.TxtImpPremioPpta = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.CboTipoSorteo = New System.Windows.Forms.ComboBox()
        Me.DtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CboAdmon = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtTipoSorteo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtIdAdmon = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtIdSorteo = New System.Windows.Forms.TextBox()
        Me.TxtNumJugado = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtImporteDecimo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtImportePpta = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtPptasImpresas = New System.Windows.Forms.TextBox()
        Me.TxtPptasEntregadas = New System.Windows.Forms.TextBox()
        Me.TxtPptasDevueltas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtLotJugada = New System.Windows.Forms.TextBox()
        Me.TxtDecimosJugados = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtImpporteTotal = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TxtJuegaEmp = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.BtnCalcular = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.TxtEjercicio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DgvSorteos = New System.Windows.Forms.DataGridView()
        Me.LblRegistros = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtSaldoVendor = New System.Windows.Forms.TextBox()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.TxtResIdSorteo = New System.Windows.Forms.TextBox()
        Me.TxtPagadoAdmonSorteo = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.TxtTotalPagadoAdmon = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.TxtSaldoTotal = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.TxtDeudaTotal = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.TxtSaldoSorteo = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.TxtLiquidadoSorteo = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtDeudaSorteo = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtAdministracion = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.LblEjercicio = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtPremiosAbonados = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.TxtImportePremios = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DgvSorteos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Mantenimiento Sorteos"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtPremioNum2)
        Me.Panel1.Controls.Add(Me.Label33)
        Me.Panel1.Controls.Add(Me.TxtPremioNum1)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.TxtNumJugado2)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.TxtImpPremioPpta)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.CboTipoSorteo)
        Me.Panel1.Controls.Add(Me.DtpFecha)
        Me.Panel1.Controls.Add(Me.CboAdmon)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TxtTipoSorteo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TxtIdAdmon)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.TxtIdSorteo)
        Me.Panel1.Controls.Add(Me.TxtNumJugado)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TxtImporteDecimo)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.TxtImportePpta)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.TxtPptasImpresas)
        Me.Panel1.Controls.Add(Me.TxtPptasEntregadas)
        Me.Panel1.Controls.Add(Me.TxtPptasDevueltas)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.TxtLotJugada)
        Me.Panel1.Controls.Add(Me.TxtDecimosJugados)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.TxtImpporteTotal)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.TxtJuegaEmp)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.BtnCalcular)
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.TxtEjercicio)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Location = New System.Drawing.Point(16, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(239, 633)
        Me.Panel1.TabIndex = 6
        '
        'TxtPremioNum2
        '
        Me.TxtPremioNum2.Location = New System.Drawing.Point(151, 522)
        Me.TxtPremioNum2.Name = "TxtPremioNum2"
        Me.TxtPremioNum2.Size = New System.Drawing.Size(63, 22)
        Me.TxtPremioNum2.TabIndex = 48
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(25, 527)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(119, 17)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "Imp Premio Num2"
        '
        'TxtPremioNum1
        '
        Me.TxtPremioNum1.Location = New System.Drawing.Point(151, 494)
        Me.TxtPremioNum1.Name = "TxtPremioNum1"
        Me.TxtPremioNum1.Size = New System.Drawing.Size(63, 22)
        Me.TxtPremioNum1.TabIndex = 46
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(25, 497)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(119, 17)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Imp Premio Num1"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(48, 186)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 17)
        Me.Label18.TabIndex = 44
        Me.Label18.Text = "Núm jugado 2"
        '
        'TxtNumJugado2
        '
        Me.TxtNumJugado2.Location = New System.Drawing.Point(152, 183)
        Me.TxtNumJugado2.Name = "TxtNumJugado2"
        Me.TxtNumJugado2.Size = New System.Drawing.Size(63, 22)
        Me.TxtNumJugado2.TabIndex = 43
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.cancel1
        Me.BtnCancelar.Location = New System.Drawing.Point(12, 594)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(92, 30)
        Me.BtnCancelar.TabIndex = 42
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'TxtImpPremioPpta
        '
        Me.TxtImpPremioPpta.Location = New System.Drawing.Point(152, 466)
        Me.TxtImpPremioPpta.Name = "TxtImpPremioPpta"
        Me.TxtImpPremioPpta.ReadOnly = True
        Me.TxtImpPremioPpta.Size = New System.Drawing.Size(63, 22)
        Me.TxtImpPremioPpta.TabIndex = 41
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(33, 469)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 17)
        Me.Label19.TabIndex = 40
        Me.Label19.Text = "Imp Premio/Ppta"
        '
        'CboTipoSorteo
        '
        Me.CboTipoSorteo.DropDownWidth = 120
        Me.CboTipoSorteo.FormattingEnabled = True
        Me.CboTipoSorteo.Location = New System.Drawing.Point(191, 94)
        Me.CboTipoSorteo.Name = "CboTipoSorteo"
        Me.CboTipoSorteo.Size = New System.Drawing.Size(24, 24)
        Me.CboTipoSorteo.TabIndex = 39
        '
        'DtpFecha
        '
        Me.DtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFecha.Location = New System.Drawing.Point(90, 68)
        Me.DtpFecha.Name = "DtpFecha"
        Me.DtpFecha.Size = New System.Drawing.Size(125, 22)
        Me.DtpFecha.TabIndex = 38
        '
        'CboAdmon
        '
        Me.CboAdmon.DropDownWidth = 120
        Me.CboAdmon.FormattingEnabled = True
        Me.CboAdmon.Location = New System.Drawing.Point(191, 122)
        Me.CboAdmon.Name = "CboAdmon"
        Me.CboAdmon.Size = New System.Drawing.Size(24, 24)
        Me.CboAdmon.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Fecha"
        '
        'TxtTipoSorteo
        '
        Me.TxtTipoSorteo.Location = New System.Drawing.Point(90, 96)
        Me.TxtTipoSorteo.Name = "TxtTipoSorteo"
        Me.TxtTipoSorteo.Size = New System.Drawing.Size(99, 22)
        Me.TxtTipoSorteo.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(4, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Tipo sorteo"
        '
        'TxtIdAdmon
        '
        Me.TxtIdAdmon.Location = New System.Drawing.Point(138, 124)
        Me.TxtIdAdmon.Name = "TxtIdAdmon"
        Me.TxtIdAdmon.Size = New System.Drawing.Size(51, 22)
        Me.TxtIdAdmon.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(64, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Id Admon"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(66, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 17)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "Id Sorteo"
        '
        'TxtIdSorteo
        '
        Me.TxtIdSorteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtIdSorteo.Location = New System.Drawing.Point(139, 11)
        Me.TxtIdSorteo.Name = "TxtIdSorteo"
        Me.TxtIdSorteo.ReadOnly = True
        Me.TxtIdSorteo.Size = New System.Drawing.Size(62, 22)
        Me.TxtIdSorteo.TabIndex = 37
        '
        'TxtNumJugado
        '
        Me.TxtNumJugado.Location = New System.Drawing.Point(152, 155)
        Me.TxtNumJugado.Name = "TxtNumJugado"
        Me.TxtNumJugado.Size = New System.Drawing.Size(63, 22)
        Me.TxtNumJugado.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Núm jugado 1"
        '
        'TxtImporteDecimo
        '
        Me.TxtImporteDecimo.Location = New System.Drawing.Point(151, 216)
        Me.TxtImporteDecimo.Name = "TxtImporteDecimo"
        Me.TxtImporteDecimo.Size = New System.Drawing.Size(63, 22)
        Me.TxtImporteDecimo.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(47, 219)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 17)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Precio décimo"
        '
        'TxtImportePpta
        '
        Me.TxtImportePpta.Location = New System.Drawing.Point(151, 244)
        Me.TxtImportePpta.Name = "TxtImportePpta"
        Me.TxtImportePpta.Size = New System.Drawing.Size(63, 22)
        Me.TxtImportePpta.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(37, 247)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Precio papeleta"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(46, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 17)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Ppta impresas"
        '
        'TxtPptasImpresas
        '
        Me.TxtPptasImpresas.Location = New System.Drawing.Point(151, 272)
        Me.TxtPptasImpresas.Name = "TxtPptasImpresas"
        Me.TxtPptasImpresas.ReadOnly = True
        Me.TxtPptasImpresas.Size = New System.Drawing.Size(63, 22)
        Me.TxtPptasImpresas.TabIndex = 23
        '
        'TxtPptasEntregadas
        '
        Me.TxtPptasEntregadas.Location = New System.Drawing.Point(151, 300)
        Me.TxtPptasEntregadas.Name = "TxtPptasEntregadas"
        Me.TxtPptasEntregadas.ReadOnly = True
        Me.TxtPptasEntregadas.Size = New System.Drawing.Size(63, 22)
        Me.TxtPptasEntregadas.TabIndex = 25
        '
        'TxtPptasDevueltas
        '
        Me.TxtPptasDevueltas.Location = New System.Drawing.Point(151, 328)
        Me.TxtPptasDevueltas.Name = "TxtPptasDevueltas"
        Me.TxtPptasDevueltas.ReadOnly = True
        Me.TxtPptasDevueltas.Size = New System.Drawing.Size(63, 22)
        Me.TxtPptasDevueltas.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 333)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "Ppta devueltas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(31, 305)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 17)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Ppta entregadas"
        '
        'TxtLotJugada
        '
        Me.TxtLotJugada.Location = New System.Drawing.Point(151, 354)
        Me.TxtLotJugada.Name = "TxtLotJugada"
        Me.TxtLotJugada.ReadOnly = True
        Me.TxtLotJugada.Size = New System.Drawing.Size(63, 22)
        Me.TxtLotJugada.TabIndex = 29
        '
        'TxtDecimosJugados
        '
        Me.TxtDecimosJugados.Location = New System.Drawing.Point(151, 381)
        Me.TxtDecimosJugados.Name = "TxtDecimosJugados"
        Me.TxtDecimosJugados.ReadOnly = True
        Me.TxtDecimosJugados.Size = New System.Drawing.Size(63, 22)
        Me.TxtDecimosJugados.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(23, 357)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "Importe papeletas"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 386)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(136, 17)
        Me.Label14.TabIndex = 30
        Me.Label14.Text = "Decimos comprados"
        '
        'TxtImpporteTotal
        '
        Me.TxtImpporteTotal.Location = New System.Drawing.Point(151, 409)
        Me.TxtImpporteTotal.Name = "TxtImpporteTotal"
        Me.TxtImpporteTotal.ReadOnly = True
        Me.TxtImpporteTotal.Size = New System.Drawing.Size(63, 22)
        Me.TxtImpporteTotal.TabIndex = 33
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(33, 414)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(111, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Importe décimos"
        '
        'TxtJuegaEmp
        '
        Me.TxtJuegaEmp.Location = New System.Drawing.Point(151, 437)
        Me.TxtJuegaEmp.Name = "TxtJuegaEmp"
        Me.TxtJuegaEmp.ReadOnly = True
        Me.TxtJuegaEmp.Size = New System.Drawing.Size(63, 22)
        Me.TxtJuegaEmp.TabIndex = 35
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(29, 440)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(115, 17)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Sbrte a Comision"
        '
        'BtnCalcular
        '
        Me.BtnCalcular.Image = CType(resources.GetObject("BtnCalcular.Image"), System.Drawing.Image)
        Me.BtnCalcular.Location = New System.Drawing.Point(67, 558)
        Me.BtnCalcular.Name = "BtnCalcular"
        Me.BtnCalcular.Size = New System.Drawing.Size(93, 30)
        Me.BtnCalcular.TabIndex = 3
        Me.BtnCalcular.Text = "Calcular"
        Me.BtnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCalcular.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.Location = New System.Drawing.Point(126, 594)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(108, 30)
        Me.BtnGuardar.TabIndex = 2
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'TxtEjercicio
        '
        Me.TxtEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtEjercicio.Location = New System.Drawing.Point(138, 39)
        Me.TxtEjercicio.Name = "TxtEjercicio"
        Me.TxtEjercicio.ReadOnly = True
        Me.TxtEjercicio.Size = New System.Drawing.Size(63, 22)
        Me.TxtEjercicio.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Ejercicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Entrada de Datos"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(687, 208)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(63, 22)
        Me.TextBox3.TabIndex = 11
        '
        'DgvSorteos
        '
        Me.DgvSorteos.AllowUserToAddRows = False
        Me.DgvSorteos.AllowUserToDeleteRows = False
        Me.DgvSorteos.AllowUserToOrderColumns = True
        Me.DgvSorteos.AllowUserToResizeColumns = False
        Me.DgvSorteos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvSorteos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSorteos.Location = New System.Drawing.Point(261, 98)
        Me.DgvSorteos.MultiSelect = False
        Me.DgvSorteos.Name = "DgvSorteos"
        Me.DgvSorteos.RowHeadersWidth = 51
        Me.DgvSorteos.RowTemplate.Height = 24
        Me.DgvSorteos.Size = New System.Drawing.Size(1003, 462)
        Me.DgvSorteos.TabIndex = 9
        '
        'LblRegistros
        '
        Me.LblRegistros.AutoSize = True
        Me.LblRegistros.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRegistros.ForeColor = System.Drawing.Color.Red
        Me.LblRegistros.Location = New System.Drawing.Point(302, 237)
        Me.LblRegistros.Name = "LblRegistros"
        Me.LblRegistros.Size = New System.Drawing.Size(795, 39)
        Me.LblRegistros.TabIndex = 12
        Me.LblRegistros.Text = "No hay registros, pulsa Añadir para crear el primero"
        Me.LblRegistros.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtPremiosAbonados)
        Me.Panel2.Controls.Add(Me.Label34)
        Me.Panel2.Controls.Add(Me.TxtImportePremios)
        Me.Panel2.Controls.Add(Me.Label35)
        Me.Panel2.Controls.Add(Me.TxtSaldoVendor)
        Me.Panel2.Controls.Add(Me.Label32)
        Me.Panel2.Controls.Add(Me.Label30)
        Me.Panel2.Controls.Add(Me.TxtResIdSorteo)
        Me.Panel2.Controls.Add(Me.TxtPagadoAdmonSorteo)
        Me.Panel2.Controls.Add(Me.Label29)
        Me.Panel2.Controls.Add(Me.TxtTotalPagadoAdmon)
        Me.Panel2.Controls.Add(Me.Label28)
        Me.Panel2.Controls.Add(Me.TxtSaldoTotal)
        Me.Panel2.Controls.Add(Me.Label27)
        Me.Panel2.Controls.Add(Me.TxtDeudaTotal)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.TxtSaldoSorteo)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.TxtLiquidadoSorteo)
        Me.Panel2.Controls.Add(Me.Label23)
        Me.Panel2.Controls.Add(Me.TxtDeudaSorteo)
        Me.Panel2.Controls.Add(Me.Label22)
        Me.Panel2.Controls.Add(Me.TxtAdministracion)
        Me.Panel2.Controls.Add(Me.Label21)
        Me.Panel2.Location = New System.Drawing.Point(261, 582)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1005, 149)
        Me.Panel2.TabIndex = 13
        '
        'TxtSaldoVendor
        '
        Me.TxtSaldoVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSaldoVendor.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldoVendor.Location = New System.Drawing.Point(212, 98)
        Me.TxtSaldoVendor.Name = "TxtSaldoVendor"
        Me.TxtSaldoVendor.ReadOnly = True
        Me.TxtSaldoVendor.Size = New System.Drawing.Size(58, 22)
        Me.TxtSaldoVendor.TabIndex = 43
        Me.TxtSaldoVendor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(277, 99)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(111, 17)
        Me.Label32.TabIndex = 42
        Me.Label32.Text = "Saldo Papeletas"
        '
        'Label30
        '
        Me.Label30.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(340, 14)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(65, 17)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "Id Sorteo"
        '
        'TxtResIdSorteo
        '
        Me.TxtResIdSorteo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtResIdSorteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtResIdSorteo.Location = New System.Drawing.Point(411, 12)
        Me.TxtResIdSorteo.Name = "TxtResIdSorteo"
        Me.TxtResIdSorteo.ReadOnly = True
        Me.TxtResIdSorteo.Size = New System.Drawing.Size(51, 22)
        Me.TxtResIdSorteo.TabIndex = 41
        '
        'TxtPagadoAdmonSorteo
        '
        Me.TxtPagadoAdmonSorteo.Location = New System.Drawing.Point(133, 62)
        Me.TxtPagadoAdmonSorteo.Name = "TxtPagadoAdmonSorteo"
        Me.TxtPagadoAdmonSorteo.ReadOnly = True
        Me.TxtPagadoAdmonSorteo.Size = New System.Drawing.Size(58, 22)
        Me.TxtPagadoAdmonSorteo.TabIndex = 39
        Me.TxtPagadoAdmonSorteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(10, 65)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(117, 17)
        Me.Label29.TabIndex = 38
        Me.Label29.Text = "Pagado a Admon"
        '
        'TxtTotalPagadoAdmon
        '
        Me.TxtTotalPagadoAdmon.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtTotalPagadoAdmon.Location = New System.Drawing.Point(910, 62)
        Me.TxtTotalPagadoAdmon.Name = "TxtTotalPagadoAdmon"
        Me.TxtTotalPagadoAdmon.ReadOnly = True
        Me.TxtTotalPagadoAdmon.Size = New System.Drawing.Size(63, 22)
        Me.TxtTotalPagadoAdmon.TabIndex = 37
        Me.TxtTotalPagadoAdmon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label28
        '
        Me.Label28.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(792, 65)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(117, 17)
        Me.Label28.TabIndex = 36
        Me.Label28.Text = "Pagado a Admon"
        '
        'TxtSaldoTotal
        '
        Me.TxtSaldoTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtSaldoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSaldoTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldoTotal.Location = New System.Drawing.Point(910, 97)
        Me.TxtSaldoTotal.Name = "TxtSaldoTotal"
        Me.TxtSaldoTotal.ReadOnly = True
        Me.TxtSaldoTotal.Size = New System.Drawing.Size(63, 22)
        Me.TxtSaldoTotal.TabIndex = 35
        Me.TxtSaldoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(829, 100)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(80, 17)
        Me.Label27.TabIndex = 34
        Me.Label27.Text = "Total Saldo"
        '
        'TxtDeudaTotal
        '
        Me.TxtDeudaTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtDeudaTotal.Location = New System.Drawing.Point(910, 37)
        Me.TxtDeudaTotal.Name = "TxtDeudaTotal"
        Me.TxtDeudaTotal.ReadOnly = True
        Me.TxtDeudaTotal.Size = New System.Drawing.Size(63, 22)
        Me.TxtDeudaTotal.TabIndex = 31
        Me.TxtDeudaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(800, 40)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(109, 17)
        Me.Label25.TabIndex = 30
        Me.Label25.Text = "Total Comprado"
        '
        'TxtSaldoSorteo
        '
        Me.TxtSaldoSorteo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtSaldoSorteo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSaldoSorteo.Location = New System.Drawing.Point(133, 97)
        Me.TxtSaldoSorteo.Name = "TxtSaldoSorteo"
        Me.TxtSaldoSorteo.ReadOnly = True
        Me.TxtSaldoSorteo.Size = New System.Drawing.Size(58, 22)
        Me.TxtSaldoSorteo.TabIndex = 29
        Me.TxtSaldoSorteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(39, 100)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(88, 17)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Saldo sorteo"
        '
        'TxtLiquidadoSorteo
        '
        Me.TxtLiquidadoSorteo.Location = New System.Drawing.Point(212, 63)
        Me.TxtLiquidadoSorteo.Name = "TxtLiquidadoSorteo"
        Me.TxtLiquidadoSorteo.ReadOnly = True
        Me.TxtLiquidadoSorteo.Size = New System.Drawing.Size(58, 22)
        Me.TxtLiquidadoSorteo.TabIndex = 27
        Me.TxtLiquidadoSorteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(277, 65)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(112, 17)
        Me.Label23.TabIndex = 26
        Me.Label23.Text = "Pptas liquidadas"
        '
        'TxtDeudaSorteo
        '
        Me.TxtDeudaSorteo.Location = New System.Drawing.Point(133, 33)
        Me.TxtDeudaSorteo.Name = "TxtDeudaSorteo"
        Me.TxtDeudaSorteo.ReadOnly = True
        Me.TxtDeudaSorteo.Size = New System.Drawing.Size(137, 22)
        Me.TxtDeudaSorteo.TabIndex = 25
        Me.TxtDeudaSorteo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(33, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 17)
        Me.Label22.TabIndex = 24
        Me.Label22.Text = "Deuda sorteo"
        '
        'TxtAdministracion
        '
        Me.TxtAdministracion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAdministracion.Location = New System.Drawing.Point(541, 11)
        Me.TxtAdministracion.Name = "TxtAdministracion"
        Me.TxtAdministracion.ReadOnly = True
        Me.TxtAdministracion.Size = New System.Drawing.Size(276, 22)
        Me.TxtAdministracion.TabIndex = 23
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(483, 13)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(52, 17)
        Me.Label21.TabIndex = 22
        Me.Label21.Text = "Admon"
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(279, 576)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(310, 18)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Detalles con la administración de lotería"
        '
        'LblEjercicio
        '
        Me.LblEjercicio.AutoSize = True
        Me.LblEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjercicio.Location = New System.Drawing.Point(342, 21)
        Me.LblEjercicio.Name = "LblEjercicio"
        Me.LblEjercicio.Size = New System.Drawing.Size(94, 25)
        Me.LblEjercicio.TabIndex = 14
        Me.LblEjercicio.Text = "Ejercicio"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(1085, 577)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(149, 17)
        Me.Label31.TabIndex = 15
        Me.Label31.Text = "Total todos sorteos"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.Bombo_loteria
        Me.PictureBox1.Location = New System.Drawing.Point(12, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.InsertFila1
        Me.BtnAñadir.Location = New System.Drawing.Point(261, 62)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(98, 30)
        Me.BtnAñadir.TabIndex = 5
        Me.BtnAñadir.Text = "  Añadir"
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = CType(resources.GetObject("BtnEditar.Image"), System.Drawing.Image)
        Me.BtnEditar.Location = New System.Drawing.Point(376, 62)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(132, 30)
        Me.BtnEditar.TabIndex = 4
        Me.BtnEditar.Text = " Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1185, 16)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'TxtPremiosAbonados
        '
        Me.TxtPremiosAbonados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtPremiosAbonados.Location = New System.Drawing.Point(581, 99)
        Me.TxtPremiosAbonados.Name = "TxtPremiosAbonados"
        Me.TxtPremiosAbonados.ReadOnly = True
        Me.TxtPremiosAbonados.Size = New System.Drawing.Size(63, 22)
        Me.TxtPremiosAbonados.TabIndex = 47
        Me.TxtPremiosAbonados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label34
        '
        Me.Label34.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(449, 102)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(126, 17)
        Me.Label34.TabIndex = 46
        Me.Label34.Text = "Premios abonados"
        '
        'TxtImportePremios
        '
        Me.TxtImportePremios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtImportePremios.Location = New System.Drawing.Point(581, 74)
        Me.TxtImportePremios.Name = "TxtImportePremios"
        Me.TxtImportePremios.ReadOnly = True
        Me.TxtImportePremios.Size = New System.Drawing.Size(63, 22)
        Me.TxtImportePremios.TabIndex = 45
        Me.TxtImportePremios.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label35
        '
        Me.Label35.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(465, 77)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(110, 17)
        Me.Label35.TabIndex = 44
        Me.Label35.Text = "Importe Premios"
        '
        'FrmSorteos
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1277, 735)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.LblEjercicio)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LblRegistros)
        Me.Controls.Add(Me.DgvSorteos)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmSorteos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Sorteos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvSorteos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCalcular As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtTipoSorteo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtIdAdmon As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtNumJugado As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtImporteDecimo As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtImportePpta As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TxtPptasImpresas As TextBox
    Friend WithEvents TxtPptasEntregadas As TextBox
    Friend WithEvents TxtPptasDevueltas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtDecimosJugados As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtImpporteTotal As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents TxtJuegaEmp As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents TxtIdSorteo As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtEjercicio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtLotJugada As TextBox
    Friend WithEvents DgvSorteos As DataGridView
    Friend WithEvents CboAdmon As ComboBox
    Friend WithEvents DtpFecha As DateTimePicker
    Friend WithEvents CboTipoSorteo As ComboBox
    Friend WithEvents LblRegistros As Label
    Friend WithEvents TxtImpPremioPpta As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtSaldoTotal As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents TxtDeudaTotal As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TxtSaldoSorteo As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents TxtLiquidadoSorteo As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtDeudaSorteo As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtAdministracion As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents LblEjercicio As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents TxtResIdSorteo As TextBox
    Friend WithEvents TxtPagadoAdmonSorteo As TextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents TxtTotalPagadoAdmon As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents TxtSaldoVendor As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label18 As Label
    Friend WithEvents TxtNumJugado2 As TextBox
    Friend WithEvents TxtPremioNum2 As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents TxtPremioNum1 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TxtPremiosAbonados As TextBox
    Friend WithEvents Label34 As Label
    Friend WithEvents TxtImportePremios As TextBox
    Friend WithEvents Label35 As Label
End Class
