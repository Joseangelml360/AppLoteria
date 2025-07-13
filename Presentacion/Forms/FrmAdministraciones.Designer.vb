<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdministraciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAdministraciones))
        Me.DgvAdmon = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNumAdmon = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtCodPos = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtPoblacion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtTefono = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtMail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtResponsable = New System.Windows.Forms.TextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnAñadir = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.BtnEliminar = New System.Windows.Forms.Button()
        Me.BtnEditar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtCuenta = New System.Windows.Forms.MaskedTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvAdmon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvAdmon
        '
        Me.DgvAdmon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvAdmon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvAdmon.Location = New System.Drawing.Point(12, 130)
        Me.DgvAdmon.MultiSelect = False
        Me.DgvAdmon.Name = "DgvAdmon"
        Me.DgvAdmon.RowHeadersWidth = 51
        Me.DgvAdmon.RowTemplate.Height = 24
        Me.DgvAdmon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvAdmon.Size = New System.Drawing.Size(1231, 211)
        Me.DgvAdmon.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Administraciones de lotería"
        '
        'TxtNumAdmon
        '
        Me.TxtNumAdmon.Location = New System.Drawing.Point(100, 397)
        Me.TxtNumAdmon.Name = "TxtNumAdmon"
        Me.TxtNumAdmon.Size = New System.Drawing.Size(48, 22)
        Me.TxtNumAdmon.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 400)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nº Admon"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(241, 398)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Nombre"
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(305, 395)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(553, 22)
        Me.TxtNombre.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 439)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Dirección"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(90, 436)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(306, 22)
        Me.TxtDireccion.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(425, 441)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "C.P."
        '
        'TxtCodPos
        '
        Me.TxtCodPos.Location = New System.Drawing.Point(465, 438)
        Me.TxtCodPos.Name = "TxtCodPos"
        Me.TxtCodPos.Size = New System.Drawing.Size(100, 22)
        Me.TxtCodPos.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(598, 441)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Poblacion"
        '
        'TxtPoblacion
        '
        Me.TxtPoblacion.Location = New System.Drawing.Point(674, 440)
        Me.TxtPoblacion.Name = "TxtPoblacion"
        Me.TxtPoblacion.Size = New System.Drawing.Size(184, 22)
        Me.TxtPoblacion.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 480)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 17)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Teléfono"
        '
        'TxtTefono
        '
        Me.TxtTefono.Location = New System.Drawing.Point(87, 475)
        Me.TxtTefono.Name = "TxtTefono"
        Me.TxtTefono.Size = New System.Drawing.Size(116, 22)
        Me.TxtTefono.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(231, 480)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "e-mail"
        '
        'TxtMail
        '
        Me.TxtMail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtMail.Location = New System.Drawing.Point(288, 477)
        Me.TxtMail.Name = "TxtMail"
        Me.TxtMail.Size = New System.Drawing.Size(204, 22)
        Me.TxtMail.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(516, 480)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Responsable"
        '
        'TxtResponsable
        '
        Me.TxtResponsable.Location = New System.Drawing.Point(613, 479)
        Me.TxtResponsable.Name = "TxtResponsable"
        Me.TxtResponsable.Size = New System.Drawing.Size(245, 22)
        Me.TxtResponsable.TabIndex = 16
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(20, 359)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.ReadOnly = True
        Me.TxtId.Size = New System.Drawing.Size(43, 22)
        Me.TxtId.TabIndex = 18
        Me.TxtId.Visible = False
        '
        'BtnAñadir
        '
        Me.BtnAñadir.Image = Global.Presentacion.My.Resources.Resources.InsertFila1
        Me.BtnAñadir.Location = New System.Drawing.Point(11, 94)
        Me.BtnAñadir.Name = "BtnAñadir"
        Me.BtnAñadir.Size = New System.Drawing.Size(94, 30)
        Me.BtnAñadir.TabIndex = 19
        Me.BtnAñadir.Text = "Añadir"
        Me.BtnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAñadir.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardar.Image = Global.Presentacion.My.Resources.Resources.luzverde
        Me.BtnGuardar.Location = New System.Drawing.Point(1145, 506)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(98, 30)
        Me.BtnGuardar.TabIndex = 23
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.Image = Global.Presentacion.My.Resources.Resources.undo16
        Me.BtnCancelar.Location = New System.Drawing.Point(1145, 393)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 30)
        Me.BtnCancelar.TabIndex = 24
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1145, 13)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(98, 30)
        Me.BtnSalir.TabIndex = 22
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'BtnEliminar
        '
        Me.BtnEliminar.Image = Global.Presentacion.My.Resources.Resources.table_row_delete1
        Me.BtnEliminar.Location = New System.Drawing.Point(233, 94)
        Me.BtnEliminar.Name = "BtnEliminar"
        Me.BtnEliminar.Size = New System.Drawing.Size(94, 30)
        Me.BtnEliminar.TabIndex = 21
        Me.BtnEliminar.Text = "Eliminar"
        Me.BtnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEliminar.UseVisualStyleBackColor = True
        '
        'BtnEditar
        '
        Me.BtnEditar.Image = Global.Presentacion.My.Resources.Resources.save_green16
        Me.BtnEditar.Location = New System.Drawing.Point(122, 94)
        Me.BtnEditar.Name = "BtnEditar"
        Me.BtnEditar.Size = New System.Drawing.Size(94, 30)
        Me.BtnEditar.TabIndex = 20
        Me.BtnEditar.Text = "Editar"
        Me.BtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEditar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 519)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 17)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Número de cuenta"
        '
        'TxtCuenta
        '
        Me.TxtCuenta.Location = New System.Drawing.Point(148, 516)
        Me.TxtCuenta.Mask = "ES00 0000 0000 0000 0000"
        Me.TxtCuenta.Name = "TxtCuenta"
        Me.TxtCuenta.Size = New System.Drawing.Size(230, 22)
        Me.TxtCuenta.TabIndex = 27
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'FrmAdministraciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1259, 549)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvAdmon)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnEliminar)
        Me.Controls.Add(Me.BtnEditar)
        Me.Controls.Add(Me.BtnAñadir)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtResponsable)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtMail)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtTefono)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtPoblacion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtCodPos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNumAdmon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCuenta)
        Me.Controls.Add(Me.Label10)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdministraciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Administraciones de Loteria"
        CType(Me.DgvAdmon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvAdmon As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNumAdmon As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtCodPos As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtPoblacion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtTefono As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtMail As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtResponsable As TextBox
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnAñadir As Button
    Friend WithEvents BtnEditar As Button
    Friend WithEvents BtnEliminar As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtCuenta As MaskedTextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
