<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Totales
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Totales))
        Me.dgvTotales = New System.Windows.Forms.DataGridView()
        Me.DiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GastosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetallepropinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpaqueDataSet = New Empaques.empaqueDataSet()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.AñosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CmbMes = New System.Windows.Forms.ComboBox()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNuevaConsulta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCrearPDF = New System.Windows.Forms.Button()
        Me.MesesTableAdapter = New Empaques.empaqueDataSetTableAdapters.mesesTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AñosTableAdapter = New Empaques.empaqueDataSetTableAdapters.añosTableAdapter()
        Me.DetallepropinasTableAdapter = New Empaques.empaqueDataSetTableAdapters.detallepropinasTableAdapter()
        Me.txtPromedio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDiastrabajo = New System.Windows.Forms.TextBox()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetallepropinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpaqueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AñosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTotales
        '
        Me.dgvTotales.AllowUserToAddRows = False
        Me.dgvTotales.AllowUserToDeleteRows = False
        Me.dgvTotales.AutoGenerateColumns = False
        Me.dgvTotales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTotales.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvTotales.BackgroundColor = System.Drawing.Color.White
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTotales.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DiaDataGridViewTextBoxColumn, Me.MesDataGridViewTextBoxColumn, Me.AnioDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn, Me.GastosDataGridViewTextBoxColumn, Me.TotalDataGridViewTextBoxColumn})
        Me.dgvTotales.DataSource = Me.DetallepropinasBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotales.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTotales.Location = New System.Drawing.Point(135, 93)
        Me.dgvTotales.Name = "dgvTotales"
        Me.dgvTotales.ReadOnly = True
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Noto Sans", 12.0!)
        Me.dgvTotales.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvTotales.Size = New System.Drawing.Size(616, 563)
        Me.dgvTotales.TabIndex = 9
        '
        'DiaDataGridViewTextBoxColumn
        '
        Me.DiaDataGridViewTextBoxColumn.DataPropertyName = "dia"
        Me.DiaDataGridViewTextBoxColumn.HeaderText = "Día"
        Me.DiaDataGridViewTextBoxColumn.Name = "DiaDataGridViewTextBoxColumn"
        Me.DiaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MesDataGridViewTextBoxColumn
        '
        Me.MesDataGridViewTextBoxColumn.DataPropertyName = "mes"
        Me.MesDataGridViewTextBoxColumn.HeaderText = "Mes"
        Me.MesDataGridViewTextBoxColumn.Name = "MesDataGridViewTextBoxColumn"
        Me.MesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnioDataGridViewTextBoxColumn
        '
        Me.AnioDataGridViewTextBoxColumn.DataPropertyName = "anio"
        Me.AnioDataGridViewTextBoxColumn.HeaderText = "Año"
        Me.AnioDataGridViewTextBoxColumn.Name = "AnioDataGridViewTextBoxColumn"
        Me.AnioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GastosDataGridViewTextBoxColumn
        '
        Me.GastosDataGridViewTextBoxColumn.DataPropertyName = "gastos"
        Me.GastosDataGridViewTextBoxColumn.HeaderText = "Gastos"
        Me.GastosDataGridViewTextBoxColumn.Name = "GastosDataGridViewTextBoxColumn"
        Me.GastosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalDataGridViewTextBoxColumn
        '
        Me.TotalDataGridViewTextBoxColumn.DataPropertyName = "total"
        Me.TotalDataGridViewTextBoxColumn.HeaderText = "Total"
        Me.TotalDataGridViewTextBoxColumn.Name = "TotalDataGridViewTextBoxColumn"
        Me.TotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetallepropinasBindingSource
        '
        Me.DetallepropinasBindingSource.DataMember = "detallepropinas"
        Me.DetallepropinasBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'EmpaqueDataSet
        '
        Me.EmpaqueDataSet.DataSetName = "empaqueDataSet"
        Me.EmpaqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbAnio
        '
        Me.cmbAnio.DataSource = Me.AñosBindingSource
        Me.cmbAnio.DisplayMember = "anios"
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(49, 49)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(94, 30)
        Me.cmbAnio.TabIndex = 0
        '
        'AñosBindingSource
        '
        Me.AñosBindingSource.DataMember = "años"
        Me.AñosBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'CmbMes
        '
        Me.CmbMes.DataSource = Me.MesesBindingSource
        Me.CmbMes.DisplayMember = "mes"
        Me.CmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbMes.FormattingEnabled = True
        Me.CmbMes.Location = New System.Drawing.Point(149, 49)
        Me.CmbMes.Name = "CmbMes"
        Me.CmbMes.Size = New System.Drawing.Size(137, 30)
        Me.CmbMes.TabIndex = 1
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "meses"
        Me.MesesBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(45, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 22)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(145, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 22)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mes:"
        '
        'btnNuevaConsulta
        '
        Me.btnNuevaConsulta.Location = New System.Drawing.Point(292, 49)
        Me.btnNuevaConsulta.Name = "btnNuevaConsulta"
        Me.btnNuevaConsulta.Size = New System.Drawing.Size(138, 30)
        Me.btnNuevaConsulta.TabIndex = 2
        Me.btnNuevaConsulta.Text = "Nueva Consulta"
        Me.btnNuevaConsulta.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(436, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 22)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "TOTAL:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Noto Sans", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(494, 44)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(219, 38)
        Me.txtTotal.TabIndex = 7
        Me.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnCrearPDF
        '
        Me.btnCrearPDF.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.btnCrearPDF.Location = New System.Drawing.Point(719, 44)
        Me.btnCrearPDF.Name = "btnCrearPDF"
        Me.btnCrearPDF.Size = New System.Drawing.Size(127, 38)
        Me.btnCrearPDF.TabIndex = 8
        Me.btnCrearPDF.Text = "Crear PDF"
        Me.btnCrearPDF.UseVisualStyleBackColor = True
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(543, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Gastos:"
        '
        'txtGastos
        '
        Me.txtGastos.Enabled = False
        Me.txtGastos.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtGastos.Location = New System.Drawing.Point(606, 16)
        Me.txtGastos.Multiline = True
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(107, 26)
        Me.txtGastos.TabIndex = 10
        Me.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.Location = New System.Drawing.Point(430, 16)
        Me.txtSaldo.Multiline = True
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(117, 25)
        Me.txtSaldo.TabIndex = 11
        Me.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(374, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 22)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Saldo:"
        '
        'AñosTableAdapter
        '
        Me.AñosTableAdapter.ClearBeforeFill = True
        '
        'DetallepropinasTableAdapter
        '
        Me.DetallepropinasTableAdapter.ClearBeforeFill = True
        '
        'txtPromedio
        '
        Me.txtPromedio.Enabled = False
        Me.txtPromedio.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtPromedio.Location = New System.Drawing.Point(22, 118)
        Me.txtPromedio.Multiline = True
        Me.txtPromedio.Name = "txtPromedio"
        Me.txtPromedio.Size = New System.Drawing.Size(107, 26)
        Me.txtPromedio.TabIndex = 13
        Me.txtPromedio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(40, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 22)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Promedio:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(20, 147)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Días Trabajo:"
        '
        'txtDiastrabajo
        '
        Me.txtDiastrabajo.Enabled = False
        Me.txtDiastrabajo.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDiastrabajo.Location = New System.Drawing.Point(22, 172)
        Me.txtDiastrabajo.Multiline = True
        Me.txtDiastrabajo.Name = "txtDiastrabajo"
        Me.txtDiastrabajo.Size = New System.Drawing.Size(107, 26)
        Me.txtDiastrabajo.TabIndex = 16
        Me.txtDiastrabajo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Totales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Empaques.My.Resources.Resources._10abstracto_g_07
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(887, 657)
        Me.Controls.Add(Me.txtDiastrabajo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtPromedio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSaldo)
        Me.Controls.Add(Me.txtGastos)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnCrearPDF)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnNuevaConsulta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbMes)
        Me.Controls.Add(Me.cmbAnio)
        Me.Controls.Add(Me.dgvTotales)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Totales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Totales"
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetallepropinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpaqueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AñosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvTotales As System.Windows.Forms.DataGridView
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents CmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnNuevaConsulta As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents btnCrearPDF As System.Windows.Forms.Button
    Friend WithEvents EmpaqueDataSet As Empaques.empaqueDataSet
    Friend WithEvents MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesesTableAdapter As Empaques.empaqueDataSetTableAdapters.mesesTableAdapter
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AñosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AñosTableAdapter As Empaques.empaqueDataSetTableAdapters.añosTableAdapter
    Friend WithEvents DetallepropinasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetallepropinasTableAdapter As Empaques.empaqueDataSetTableAdapters.detallepropinasTableAdapter
    Friend WithEvents DiaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AnioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GastosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPromedio As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDiastrabajo As System.Windows.Forms.TextBox
End Class
