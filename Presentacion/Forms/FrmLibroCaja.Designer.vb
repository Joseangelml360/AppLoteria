<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLibroCaja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLibroCaja))
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.RbtnBanco = New System.Windows.Forms.RadioButton()
        Me.RbtnEfectivo = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.RbtnAbono = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.RbtnPago = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblEjercicio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtImporte = New System.Windows.Forms.TextBox()
        Me.TxtConcepto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpFechaApunte = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DgvLibroCaja = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.DtpFinal = New System.Windows.Forms.DateTimePicker()
        Me.BtnAplicarFechas = New System.Windows.Forms.Button()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnVerTodos = New System.Windows.Forms.Button()
        Me.BtnBanco = New System.Windows.Forms.Button()
        Me.BTnCaja = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DgvLibroCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 6)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(99, 17)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "Modo de pago"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.RbtnBanco)
        Me.Panel4.Controls.Add(Me.Label20)
        Me.Panel4.Controls.Add(Me.RbtnEfectivo)
        Me.Panel4.Location = New System.Drawing.Point(6, 17)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(116, 87)
        Me.Panel4.TabIndex = 43
        '
        'RbtnBanco
        '
        Me.RbtnBanco.AutoSize = True
        Me.RbtnBanco.Location = New System.Drawing.Point(14, 60)
        Me.RbtnBanco.Name = "RbtnBanco"
        Me.RbtnBanco.Size = New System.Drawing.Size(69, 21)
        Me.RbtnBanco.TabIndex = 38
        Me.RbtnBanco.TabStop = True
        Me.RbtnBanco.Text = "Banco"
        Me.RbtnBanco.UseVisualStyleBackColor = True
        '
        'RbtnEfectivo
        '
        Me.RbtnEfectivo.AutoSize = True
        Me.RbtnEfectivo.Location = New System.Drawing.Point(14, 33)
        Me.RbtnEfectivo.Name = "RbtnEfectivo"
        Me.RbtnEfectivo.Size = New System.Drawing.Size(79, 21)
        Me.RbtnEfectivo.TabIndex = 37
        Me.RbtnEfectivo.TabStop = True
        Me.RbtnEfectivo.Text = "Efectivo"
        Me.RbtnEfectivo.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.RbtnAbono)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.RbtnPago)
        Me.Panel3.Location = New System.Drawing.Point(146, 17)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(116, 87)
        Me.Panel3.TabIndex = 42
        '
        'RbtnAbono
        '
        Me.RbtnAbono.AutoSize = True
        Me.RbtnAbono.Location = New System.Drawing.Point(14, 60)
        Me.RbtnAbono.Name = "RbtnAbono"
        Me.RbtnAbono.Size = New System.Drawing.Size(70, 21)
        Me.RbtnAbono.TabIndex = 38
        Me.RbtnAbono.TabStop = True
        Me.RbtnAbono.Text = "Abono"
        Me.RbtnAbono.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 17)
        Me.Label12.TabIndex = 39
        Me.Label12.Text = "Entrada/Salida"
        '
        'RbtnPago
        '
        Me.RbtnPago.AutoSize = True
        Me.RbtnPago.Location = New System.Drawing.Point(14, 33)
        Me.RbtnPago.Name = "RbtnPago"
        Me.RbtnPago.Size = New System.Drawing.Size(67, 21)
        Me.RbtnPago.TabIndex = 37
        Me.RbtnPago.TabStop = True
        Me.RbtnPago.Text = "Cobro"
        Me.RbtnPago.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 25)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Movimientos de Caja/Banco"
        '
        'LblEjercicio
        '
        Me.LblEjercicio.AutoSize = True
        Me.LblEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjercicio.Location = New System.Drawing.Point(387, 17)
        Me.LblEjercicio.Name = "LblEjercicio"
        Me.LblEjercicio.Size = New System.Drawing.Size(85, 25)
        Me.LblEjercicio.TabIndex = 45
        Me.LblEjercicio.Text = "Ejercicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(776, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 50
        Me.Label2.Text = "Importe"
        '
        'TxtImporte
        '
        Me.TxtImporte.Location = New System.Drawing.Point(837, 60)
        Me.TxtImporte.Name = "TxtImporte"
        Me.TxtImporte.Size = New System.Drawing.Size(100, 22)
        Me.TxtImporte.TabIndex = 51
        '
        'TxtConcepto
        '
        Me.TxtConcepto.Location = New System.Drawing.Point(360, 62)
        Me.TxtConcepto.Name = "TxtConcepto"
        Me.TxtConcepto.Size = New System.Drawing.Size(398, 22)
        Me.TxtConcepto.TabIndex = 53
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(289, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Concepto"
        '
        'DtpFechaApunte
        '
        Me.DtpFechaApunte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechaApunte.Location = New System.Drawing.Point(411, 24)
        Me.DtpFechaApunte.Name = "DtpFechaApunte"
        Me.DtpFechaApunte.Size = New System.Drawing.Size(120, 22)
        Me.DtpFechaApunte.TabIndex = 54
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(284, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Seleccionar fecha"
        '
        'DgvLibroCaja
        '
        Me.DgvLibroCaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvLibroCaja.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLibroCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLibroCaja.Location = New System.Drawing.Point(12, 163)
        Me.DgvLibroCaja.Name = "DgvLibroCaja"
        Me.DgvLibroCaja.ReadOnly = True
        Me.DgvLibroCaja.RowHeadersWidth = 51
        Me.DgvLibroCaja.RowTemplate.Height = 24
        Me.DgvLibroCaja.Size = New System.Drawing.Size(1230, 314)
        Me.DgvLibroCaja.TabIndex = 56
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BtnGuardar)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.BtnCancelar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.TxtImporte)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TxtConcepto)
        Me.Panel1.Controls.Add(Me.DtpFechaApunte)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(12, 522)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1230, 116)
        Me.Panel1.TabIndex = 60
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnGuardar.Location = New System.Drawing.Point(1104, 69)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(107, 30)
        Me.BtnGuardar.TabIndex = 49
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.undo16
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnCancelar.Location = New System.Drawing.Point(1104, 13)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(107, 30)
        Me.BtnCancelar.TabIndex = 48
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(468, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(168, 17)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "Apuntes entre fechas:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(808, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Final"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(642, 130)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Inicio"
        '
        'DtpInicio
        '
        Me.DtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpInicio.Location = New System.Drawing.Point(686, 128)
        Me.DtpInicio.Name = "DtpInicio"
        Me.DtpInicio.Size = New System.Drawing.Size(98, 22)
        Me.DtpInicio.TabIndex = 64
        '
        'DtpFinal
        '
        Me.DtpFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFinal.Location = New System.Drawing.Point(850, 128)
        Me.DtpFinal.Name = "DtpFinal"
        Me.DtpFinal.Size = New System.Drawing.Size(108, 22)
        Me.DtpFinal.TabIndex = 65
        '
        'BtnAplicarFechas
        '
        Me.BtnAplicarFechas.Image = Global.Presentacion.My.Resources.Resources._001_44
        Me.BtnAplicarFechas.Location = New System.Drawing.Point(964, 117)
        Me.BtnAplicarFechas.Name = "BtnAplicarFechas"
        Me.BtnAplicarFechas.Size = New System.Drawing.Size(128, 40)
        Me.BtnAplicarFechas.TabIndex = 66
        Me.BtnAplicarFechas.Text = "Aplicar"
        Me.BtnAplicarFechas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAplicarFechas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAplicarFechas.UseVisualStyleBackColor = True
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.Añadir
        Me.BtnAñadir.Location = New System.Drawing.Point(12, 482)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(149, 40)
        Me.BtnAñadir.TabIndex = 46
        Me.BtnAñadir.Text = "Añadir apunte"
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnVerTodos
        '
        Me.BtnVerTodos.Image = Global.Presentacion.My.Resources.Resources.Hoja_Contable24x24
        Me.BtnVerTodos.Location = New System.Drawing.Point(287, 117)
        Me.BtnVerTodos.Name = "BtnVerTodos"
        Me.BtnVerTodos.Size = New System.Drawing.Size(128, 40)
        Me.BtnVerTodos.TabIndex = 59
        Me.BtnVerTodos.Text = "Todos"
        Me.BtnVerTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVerTodos.UseVisualStyleBackColor = True
        '
        'BtnBanco
        '
        Me.BtnBanco.Image = Global.Presentacion.My.Resources.Resources.Banco24x24
        Me.BtnBanco.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BtnBanco.Location = New System.Drawing.Point(149, 116)
        Me.BtnBanco.Name = "BtnBanco"
        Me.BtnBanco.Size = New System.Drawing.Size(128, 40)
        Me.BtnBanco.TabIndex = 58
        Me.BtnBanco.Text = "Solo Banco"
        Me.BtnBanco.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnBanco.UseVisualStyleBackColor = True
        '
        'BTnCaja
        '
        Me.BTnCaja.Image = Global.Presentacion.My.Resources.Resources.Caja_fuerte24x241
        Me.BTnCaja.Location = New System.Drawing.Point(11, 116)
        Me.BTnCaja.Name = "BTnCaja"
        Me.BTnCaja.Size = New System.Drawing.Size(128, 40)
        Me.BTnCaja.TabIndex = 57
        Me.BTnCaja.Text = "Solo Caja"
        Me.BTnCaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BTnCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BTnCaja.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1163, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(79, 40)
        Me.BtnSalir.TabIndex = 47
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(80, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(1072, 51)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = resources.GetString("Label8.Text")
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.money
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 40)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
        '
        'FrmLibroCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1254, 644)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblEjercicio)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnAplicarFechas)
        Me.Controls.Add(Me.DtpFinal)
        Me.Controls.Add(Me.DtpInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.BtnVerTodos)
        Me.Controls.Add(Me.BtnBanco)
        Me.Controls.Add(Me.BTnCaja)
        Me.Controls.Add(Me.DgvLibroCaja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLibroCaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Caja"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DgvLibroCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label20 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents RbtnBanco As RadioButton
    Friend WithEvents RbtnEfectivo As RadioButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RbtnAbono As RadioButton
    Friend WithEvents Label12 As Label
    Friend WithEvents RbtnPago As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents LblEjercicio As Label
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtImporte As TextBox
    Friend WithEvents TxtConcepto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpFechaApunte As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents DgvLibroCaja As DataGridView
    Friend WithEvents BTnCaja As Button
    Friend WithEvents BtnBanco As Button
    Friend WithEvents BtnVerTodos As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents DtpInicio As DateTimePicker
    Friend WithEvents DtpFinal As DateTimePicker
    Friend WithEvents BtnAplicarFechas As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
