<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInformeVendedorSorteo
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
        Me.components = New System.ComponentModel.Container()
        Dim CodigoLabel As System.Windows.Forms.Label
        Dim NombreLabel As System.Windows.Forms.Label
        Dim ApellidosLabel As System.Windows.Forms.Label
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInformeVendedorSorteo))
        Me.VendedorSorteoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dbcensosDataSet = New Presentacion.dbcensosDataSet()
        Me.vendedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CodigoTextBox = New System.Windows.Forms.TextBox()
        Me.NombreTextBox = New System.Windows.Forms.TextBox()
        Me.ApellidosTextBox = New System.Windows.Forms.TextBox()
        Me.DgvVendedores = New System.Windows.Forms.DataGridView()
        Me.BtnSelectVendor = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.VendedorSorteoTableAdapter = New Presentacion.dbcensosDataSetTableAdapters.VendedorSorteoTableAdapter()
        Me.vendedoresTableAdapter = New Presentacion.dbcensosDataSetTableAdapters.vendedoresTableAdapter()
        Me.TableAdapterManager = New Presentacion.dbcensosDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CodigoLabel = New System.Windows.Forms.Label()
        NombreLabel = New System.Windows.Forms.Label()
        ApellidosLabel = New System.Windows.Forms.Label()
        CType(Me.VendedorSorteoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dbcensosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vendedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DgvVendedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CodigoLabel
        '
        CodigoLabel.AutoSize = True
        CodigoLabel.Location = New System.Drawing.Point(17, 69)
        CodigoLabel.Name = "CodigoLabel"
        CodigoLabel.Size = New System.Drawing.Size(56, 17)
        CodigoLabel.TabIndex = 2
        CodigoLabel.Text = "Codigo:"
        '
        'NombreLabel
        '
        NombreLabel.AutoSize = True
        NombreLabel.Location = New System.Drawing.Point(151, 69)
        NombreLabel.Name = "NombreLabel"
        NombreLabel.Size = New System.Drawing.Size(62, 17)
        NombreLabel.TabIndex = 4
        NombreLabel.Text = "Nombre:"
        '
        'ApellidosLabel
        '
        ApellidosLabel.AutoSize = True
        ApellidosLabel.Location = New System.Drawing.Point(335, 69)
        ApellidosLabel.Name = "ApellidosLabel"
        ApellidosLabel.Size = New System.Drawing.Size(69, 17)
        ApellidosLabel.TabIndex = 6
        ApellidosLabel.Text = "Apellidos:"
        '
        'VendedorSorteoBindingSource
        '
        Me.VendedorSorteoBindingSource.DataMember = "VendedorSorteo"
        Me.VendedorSorteoBindingSource.DataSource = Me.dbcensosDataSet
        '
        'dbcensosDataSet
        '
        Me.dbcensosDataSet.DataSetName = "dbcensosDataSet"
        Me.dbcensosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'vendedoresBindingSource
        '
        Me.vendedoresBindingSource.DataMember = "vendedores"
        Me.vendedoresBindingSource.DataSource = Me.dbcensosDataSet
        '
        'BtnSalir
        '
        Me.BtnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnSalir.Image = Global.Presentacion.My.Resources.Resources.door_out
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSalir.Location = New System.Drawing.Point(1046, 12)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(73, 35)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ReportDataSource3.Name = "DataSet1"
        ReportDataSource3.Value = Me.VendedorSorteoBindingSource
        ReportDataSource4.Name = "DataSet2"
        ReportDataSource4.Value = Me.vendedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Presentacion.RptVendedorSorteo.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 94)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1107, 442)
        Me.ReportViewer1.TabIndex = 1
        '
        'CodigoTextBox
        '
        Me.CodigoTextBox.Location = New System.Drawing.Point(79, 64)
        Me.CodigoTextBox.Name = "CodigoTextBox"
        Me.CodigoTextBox.Size = New System.Drawing.Size(66, 22)
        Me.CodigoTextBox.TabIndex = 3
        '
        'NombreTextBox
        '
        Me.NombreTextBox.Location = New System.Drawing.Point(219, 64)
        Me.NombreTextBox.Name = "NombreTextBox"
        Me.NombreTextBox.Size = New System.Drawing.Size(100, 22)
        Me.NombreTextBox.TabIndex = 5
        '
        'ApellidosTextBox
        '
        Me.ApellidosTextBox.Location = New System.Drawing.Point(410, 64)
        Me.ApellidosTextBox.Name = "ApellidosTextBox"
        Me.ApellidosTextBox.Size = New System.Drawing.Size(264, 22)
        Me.ApellidosTextBox.TabIndex = 7
        '
        'DgvVendedores
        '
        Me.DgvVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvVendedores.Location = New System.Drawing.Point(586, 124)
        Me.DgvVendedores.Name = "DgvVendedores"
        Me.DgvVendedores.RowHeadersWidth = 51
        Me.DgvVendedores.RowTemplate.Height = 24
        Me.DgvVendedores.Size = New System.Drawing.Size(481, 23)
        Me.DgvVendedores.TabIndex = 20
        Me.DgvVendedores.Visible = False
        '
        'BtnSelectVendor
        '
        Me.BtnSelectVendor.Image = CType(resources.GetObject("BtnSelectVendor.Image"), System.Drawing.Image)
        Me.BtnSelectVendor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnSelectVendor.Location = New System.Drawing.Point(734, 53)
        Me.BtnSelectVendor.Name = "BtnSelectVendor"
        Me.BtnSelectVendor.Size = New System.Drawing.Size(170, 35)
        Me.BtnSelectVendor.TabIndex = 22
        Me.BtnSelectVendor.Text = "Buscar Vendedor"
        Me.BtnSelectVendor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelectVendor.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(734, 96)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(291, 22)
        Me.TxtBuscar.TabIndex = 21
        Me.TxtBuscar.Visible = False
        '
        'VendedorSorteoTableAdapter
        '
        Me.VendedorSorteoTableAdapter.ClearBeforeFill = True
        '
        'vendedoresTableAdapter
        '
        Me.vendedoresTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.administracionesTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.librodiarioTableAdapter = Nothing
        Me.TableAdapterManager.liquidacionTableAdapter = Nothing
        Me.TableAdapterManager.premiosTableAdapter = Nothing
        Me.TableAdapterManager.sorteosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Presentacion.dbcensosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.vendedoresTableAdapter = Me.vendedoresTableAdapter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Presentacion.My.Resources.Resources.Usuario48x48
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 23
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(352, 25)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Informe Detalles de venta de loteria"
        '
        'FrmInformeVendedorSorteo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 548)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DgvVendedores)
        Me.Controls.Add(Me.BtnSelectVendor)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(ApellidosLabel)
        Me.Controls.Add(Me.ApellidosTextBox)
        Me.Controls.Add(NombreLabel)
        Me.Controls.Add(Me.NombreTextBox)
        Me.Controls.Add(CodigoLabel)
        Me.Controls.Add(Me.CodigoTextBox)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.BtnSalir)
        Me.Name = "FrmInformeVendedorSorteo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmInformeVendedorSorteo"
        CType(Me.VendedorSorteoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dbcensosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vendedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DgvVendedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSalir As Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents VendedorSorteoBindingSource As BindingSource
    Friend WithEvents dbcensosDataSet As dbcensosDataSet
    Friend WithEvents vendedoresBindingSource As BindingSource
    Friend WithEvents VendedorSorteoTableAdapter As dbcensosDataSetTableAdapters.VendedorSorteoTableAdapter
    Friend WithEvents vendedoresTableAdapter As dbcensosDataSetTableAdapters.vendedoresTableAdapter
    Friend WithEvents TableAdapterManager As dbcensosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CodigoTextBox As TextBox
    Friend WithEvents NombreTextBox As TextBox
    Friend WithEvents ApellidosTextBox As TextBox
    Friend WithEvents DgvVendedores As DataGridView
    Friend WithEvents BtnSelectVendor As Button
    Friend WithEvents TxtBuscar As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
