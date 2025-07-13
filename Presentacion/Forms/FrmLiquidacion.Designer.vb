<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmLiquidacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLiquidacion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.CboEjercicios = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnVerTodos = New System.Windows.Forms.Button()
        Me.LblEjercicio = New System.Windows.Forms.Label()
        Me.DgvLiquidacion = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DgvLiquidacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Liquidación ejercicio"
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(1150, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(80, 30)
        Me.BtnSalir.TabIndex = 1
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'CboEjercicios
        '
        Me.CboEjercicios.FormattingEnabled = True
        Me.CboEjercicios.Location = New System.Drawing.Point(557, 76)
        Me.CboEjercicios.Name = "CboEjercicios"
        Me.CboEjercicios.Size = New System.Drawing.Size(121, 24)
        Me.CboEjercicios.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(418, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Selecciona ejercicio"
        '
        'BtnVerTodos
        '
        Me.BtnVerTodos.Image = Global.Presentacion.My.Resources.Resources.eye
        Me.BtnVerTodos.Location = New System.Drawing.Point(748, 72)
        Me.BtnVerTodos.Name = "BtnVerTodos"
        Me.BtnVerTodos.Size = New System.Drawing.Size(100, 30)
        Me.BtnVerTodos.TabIndex = 4
        Me.BtnVerTodos.Text = "Ver todos"
        Me.BtnVerTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVerTodos.UseVisualStyleBackColor = True
        '
        'LblEjercicio
        '
        Me.LblEjercicio.AutoSize = True
        Me.LblEjercicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEjercicio.Location = New System.Drawing.Point(297, 28)
        Me.LblEjercicio.Name = "LblEjercicio"
        Me.LblEjercicio.Size = New System.Drawing.Size(77, 25)
        Me.LblEjercicio.TabIndex = 5
        Me.LblEjercicio.Text = "Label3"
        '
        'DgvLiquidacion
        '
        Me.DgvLiquidacion.AllowUserToAddRows = False
        Me.DgvLiquidacion.AllowUserToDeleteRows = False
        Me.DgvLiquidacion.AllowUserToResizeColumns = False
        Me.DgvLiquidacion.AllowUserToResizeRows = False
        Me.DgvLiquidacion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvLiquidacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvLiquidacion.Location = New System.Drawing.Point(18, 106)
        Me.DgvLiquidacion.MultiSelect = False
        Me.DgvLiquidacion.Name = "DgvLiquidacion"
        Me.DgvLiquidacion.ReadOnly = True
        Me.DgvLiquidacion.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DgvLiquidacion.RowTemplate.Height = 24
        Me.DgvLiquidacion.Size = New System.Drawing.Size(1212, 166)
        Me.DgvLiquidacion.TabIndex = 6
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.Contabilidad
        Me.PictureBox1.Location = New System.Drawing.Point(5, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'FrmLiquidacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1242, 284)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvLiquidacion)
        Me.Controls.Add(Me.LblEjercicio)
        Me.Controls.Add(Me.BtnVerTodos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CboEjercicios)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLiquidacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Liquidación ejercicio"
        CType(Me.DgvLiquidacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSalir As Button
    Friend WithEvents CboEjercicios As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnVerTodos As Button
    Friend WithEvents LblEjercicio As Label
    Friend WithEvents DgvLiquidacion As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
End Class
