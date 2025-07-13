<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInformePagosAdmon
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformePagosAdmon))
        Me.pagosadmonBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcensosDataSet = New Presentacion.dbcensosDataSet()
        Me.BtnTodosMovimientos = New System.Windows.Forms.Button()
        Me.BtnResumen = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.pagosadmonTableAdapter = New Presentacion.dbcensosDataSetTableAdapters.pagosadmonTableAdapter()
        CType(Me.pagosadmonBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcensosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pagosadmonBindingSource
        '
        Me.pagosadmonBindingSource.DataMember = "pagosadmon"
        Me.pagosadmonBindingSource.DataSource = Me.dbcensosDataSet
        '
        'dbcensosDataSet
        '
        Me.dbcensosDataSet.DataSetName = "dbcensosDataSet"
        Me.dbcensosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BtnTodosMovimientos
        '
        Me.BtnTodosMovimientos.Location = New System.Drawing.Point(173, 85)
        Me.BtnTodosMovimientos.Name = "BtnTodosMovimientos"
        Me.BtnTodosMovimientos.Size = New System.Drawing.Size(196, 30)
        Me.BtnTodosMovimientos.TabIndex = 1
        Me.BtnTodosMovimientos.Text = "Todos movimientos"
        Me.BtnTodosMovimientos.UseVisualStyleBackColor = True
        Me.BtnTodosMovimientos.Visible = False
        '
        'BtnResumen
        '
        Me.BtnResumen.Location = New System.Drawing.Point(12, 85)
        Me.BtnResumen.Name = "BtnResumen"
        Me.BtnResumen.Size = New System.Drawing.Size(136, 30)
        Me.BtnResumen.TabIndex = 2
        Me.BtnResumen.Text = "Resumen"
        Me.BtnResumen.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.Location = New System.Drawing.Point(849, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(100, 30)
        Me.BtnSalir.TabIndex = 3
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(80, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(544, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Informe de movimientos con administraciones de lotería"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.Admon
        Me.PictureBox1.Location = New System.Drawing.Point(12, 7)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 60)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.pagosadmonBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.RptPagosAdmon.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 122)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(936, 316)
        Me.ReportViewer1.TabIndex = 7
        '
        'pagosadmonTableAdapter
        '
        Me.pagosadmonTableAdapter.ClearBeforeFill = True
        '
        'FrmInformePagosAdmon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnResumen)
        Me.Controls.Add(Me.BtnTodosMovimientos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmInformePagosAdmon"
        Me.Text = "Informe movimientos Admon"
        CType(Me.pagosadmonBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcensosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnTodosMovimientos As Button
    Friend WithEvents BtnResumen As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents dbcensosDataSet As dbcensosDataSet
    Friend WithEvents pagosadmonBindingSource As BindingSource
    Friend WithEvents pagosadmonTableAdapter As dbcensosDataSetTableAdapters.pagosadmonTableAdapter
End Class
