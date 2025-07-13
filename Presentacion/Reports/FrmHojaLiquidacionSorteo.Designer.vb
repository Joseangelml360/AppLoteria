<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHojaLiquidacionSorteo
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHojaLiquidacionSorteo))
        Me.SorteosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DgvSorteos = New System.Windows.Forms.DataGridView()
        Me.SorteosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSelectSorteo = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.DbcensosDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DbcensosDataSet = New Presentacion.dbcensosDataSet()
        Me.administracionesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SorteosTableAdapter = New Presentacion.dbcensosDataSetTableAdapters.sorteosTableAdapter()
        Me.administracionesTableAdapter = New Presentacion.dbcensosDataSetTableAdapters.administracionesTableAdapter()
        Me.IdSorteoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoSorteoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroJugado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroJugado2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SorteosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvSorteos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SorteosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcensosDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DbcensosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.administracionesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SorteosBindingSource
        '
        Me.SorteosBindingSource.DataMember = "sorteos"
        Me.SorteosBindingSource.DataSource = Me.DbcensosDataSetBindingSource
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Informe liquidación sorteo para imprimir"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.SorteosBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.administracionesBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.RptHojaLiquidacionSorteo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 137)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1145, 406)
        Me.ReportViewer1.TabIndex = 3
        '
        'DgvSorteos
        '
        Me.DgvSorteos.AllowUserToAddRows = False
        Me.DgvSorteos.AllowUserToDeleteRows = False
        Me.DgvSorteos.AllowUserToOrderColumns = True
        Me.DgvSorteos.AutoGenerateColumns = False
        Me.DgvSorteos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvSorteos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvSorteos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdSorteoDataGridViewTextBoxColumn, Me.TipoSorteoDataGridViewTextBoxColumn, Me.FechaDataGridViewTextBoxColumn, Me.NumeroJugado, Me.NumeroJugado2})
        Me.DgvSorteos.DataSource = Me.SorteosBindingSource1
        Me.DgvSorteos.Location = New System.Drawing.Point(146, 58)
        Me.DgvSorteos.Name = "DgvSorteos"
        Me.DgvSorteos.ReadOnly = True
        Me.DgvSorteos.RowHeadersWidth = 51
        Me.DgvSorteos.RowTemplate.Height = 24
        Me.DgvSorteos.Size = New System.Drawing.Size(434, 58)
        Me.DgvSorteos.TabIndex = 4
        '
        'SorteosBindingSource1
        '
        Me.SorteosBindingSource1.DataMember = "sorteos"
        Me.SorteosBindingSource1.DataSource = Me.DbcensosDataSetBindingSource
        '
        'BtnSelectSorteo
        '
        Me.BtnSelectSorteo.Location = New System.Drawing.Point(17, 58)
        Me.BtnSelectSorteo.Name = "BtnSelectSorteo"
        Me.BtnSelectSorteo.Size = New System.Drawing.Size(123, 58)
        Me.BtnSelectSorteo.TabIndex = 5
        Me.BtnSelectSorteo.Text = "Seleccionar Sorteo"
        Me.BtnSelectSorteo.UseVisualStyleBackColor = True
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1054, 18)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(85, 30)
        Me.BtnSalir.TabIndex = 6
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'DbcensosDataSetBindingSource
        '
        Me.DbcensosDataSetBindingSource.DataSource = Me.DbcensosDataSet
        Me.DbcensosDataSetBindingSource.Position = 0
        '
        'DbcensosDataSet
        '
        Me.DbcensosDataSet.DataSetName = "dbcensosDataSet"
        Me.DbcensosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'administracionesBindingSource
        '
        Me.administracionesBindingSource.DataMember = "administraciones"
        Me.administracionesBindingSource.DataSource = Me.DbcensosDataSet
        '
        'SorteosTableAdapter
        '
        Me.SorteosTableAdapter.ClearBeforeFill = True
        '
        'administracionesTableAdapter
        '
        Me.administracionesTableAdapter.ClearBeforeFill = True
        '
        'IdSorteoDataGridViewTextBoxColumn
        '
        Me.IdSorteoDataGridViewTextBoxColumn.DataPropertyName = "IdSorteo"
        Me.IdSorteoDataGridViewTextBoxColumn.HeaderText = "Id Sorteo"
        Me.IdSorteoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdSorteoDataGridViewTextBoxColumn.Name = "IdSorteoDataGridViewTextBoxColumn"
        Me.IdSorteoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TipoSorteoDataGridViewTextBoxColumn
        '
        Me.TipoSorteoDataGridViewTextBoxColumn.DataPropertyName = "TipoSorteo"
        Me.TipoSorteoDataGridViewTextBoxColumn.HeaderText = "Tipo Sorteo"
        Me.TipoSorteoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TipoSorteoDataGridViewTextBoxColumn.Name = "TipoSorteoDataGridViewTextBoxColumn"
        Me.TipoSorteoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaDataGridViewTextBoxColumn
        '
        Me.FechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.FechaDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FechaDataGridViewTextBoxColumn.Name = "FechaDataGridViewTextBoxColumn"
        Me.FechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumeroJugado
        '
        Me.NumeroJugado.DataPropertyName = "NumeroJugado"
        Me.NumeroJugado.HeaderText = "NumeroJugado"
        Me.NumeroJugado.MinimumWidth = 6
        Me.NumeroJugado.Name = "NumeroJugado"
        Me.NumeroJugado.ReadOnly = True
        Me.NumeroJugado.Visible = False
        '
        'NumeroJugado2
        '
        Me.NumeroJugado2.DataPropertyName = "NumeroJugado2"
        Me.NumeroJugado2.HeaderText = "NumeroJugado2"
        Me.NumeroJugado2.MinimumWidth = 6
        Me.NumeroJugado2.Name = "NumeroJugado2"
        Me.NumeroJugado2.ReadOnly = True
        Me.NumeroJugado2.Visible = False
        '
        'FrmHojaLiquidacionSorteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1141, 555)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.BtnSelectSorteo)
        Me.Controls.Add(Me.DgvSorteos)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(350, 0)
        Me.Name = "FrmHojaLiquidacionSorteo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hoja Liquidacion Sorteo"
        CType(Me.SorteosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvSorteos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SorteosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcensosDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DbcensosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.administracionesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DbcensosDataSetBindingSource As BindingSource
    Friend WithEvents DbcensosDataSet As dbcensosDataSet
    Friend WithEvents SorteosBindingSource As BindingSource
    Friend WithEvents SorteosTableAdapter As dbcensosDataSetTableAdapters.sorteosTableAdapter
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents administracionesBindingSource As BindingSource
    Friend WithEvents administracionesTableAdapter As dbcensosDataSetTableAdapters.administracionesTableAdapter
    Friend WithEvents DgvSorteos As DataGridView
    Friend WithEvents SorteosBindingSource1 As BindingSource
    Friend WithEvents BtnSelectSorteo As Button
    Friend WithEvents BtnSalir As Button
    Friend WithEvents IdSorteoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TipoSorteoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FechaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NumeroJugado As DataGridViewTextBoxColumn
    Friend WithEvents NumeroJugado2 As DataGridViewTextBoxColumn
End Class
