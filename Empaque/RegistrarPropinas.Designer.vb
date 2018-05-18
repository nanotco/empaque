<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPropinas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarPropinas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSumar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtSupermercado = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApellidos = New System.Windows.Forms.TextBox()
        Me.txtNombres = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbRut = New System.Windows.Forms.ComboBox()
        Me.EmpaqueBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpaqueDataSet = New Empaques.empaqueDataSet()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtGastos = New System.Windows.Forms.TextBox()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbAnio = New System.Windows.Forms.ComboBox()
        Me.AñosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbMes = New System.Windows.Forms.ComboBox()
        Me.MesesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbDia = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.MesesTableAdapter = New Empaques.empaqueDataSetTableAdapters.mesesTableAdapter()
        Me.AñosTableAdapter = New Empaques.empaqueDataSetTableAdapters.añosTableAdapter()
        Me.EmpaqueTableAdapter = New Empaques.empaqueDataSetTableAdapters.empaqueTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpaqueBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpaqueDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AñosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnSumar)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtSupermercado)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtApellidos)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbRut)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.btnConsultar)
        Me.GroupBox1.Controls.Add(Me.txtTotal)
        Me.GroupBox1.Controls.Add(Me.txtGastos)
        Me.GroupBox1.Controls.Add(Me.txtSaldo)
        Me.GroupBox1.Controls.Add(Me.dtpFecha)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.btnEliminar)
        Me.GroupBox1.Controls.Add(Me.btnModificar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbAnio)
        Me.GroupBox1.Controls.Add(Me.cmbMes)
        Me.GroupBox1.Controls.Add(Me.cmbDia)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox1.Location = New System.Drawing.Point(33, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(710, 418)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro"
        '
        'btnSumar
        '
        Me.btnSumar.Location = New System.Drawing.Point(272, 229)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(132, 31)
        Me.btnSumar.TabIndex = 5
        Me.btnSumar.Text = "Sumar"
        Me.btnSumar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(434, 294)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(190, 48)
        Me.btnLimpiar.TabIndex = 9
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(121, 277)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(19, 22)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "$"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(121, 237)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(19, 22)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "$"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(121, 194)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 22)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "$"
        '
        'txtSupermercado
        '
        Me.txtSupermercado.Location = New System.Drawing.Point(442, 39)
        Me.txtSupermercado.MaxLength = 5
        Me.txtSupermercado.Name = "txtSupermercado"
        Me.txtSupermercado.ReadOnly = True
        Me.txtSupermercado.Size = New System.Drawing.Size(220, 29)
        Me.txtSupermercado.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(309, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 22)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Supermercado:"
        '
        'txtApellidos
        '
        Me.txtApellidos.Location = New System.Drawing.Point(442, 87)
        Me.txtApellidos.MaxLength = 5
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.ReadOnly = True
        Me.txtApellidos.Size = New System.Drawing.Size(220, 29)
        Me.txtApellidos.TabIndex = 17
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(127, 91)
        Me.txtNombres.MaxLength = 5
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.ReadOnly = True
        Me.txtNombres.Size = New System.Drawing.Size(220, 29)
        Me.txtNombres.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(353, 94)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 22)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Apellidos:"
        '
        'cmbRut
        '
        Me.cmbRut.DataSource = Me.EmpaqueBindingSource
        Me.cmbRut.DisplayMember = "Rut"
        Me.cmbRut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRut.FormattingEnabled = True
        Me.cmbRut.Location = New System.Drawing.Point(127, 39)
        Me.cmbRut.Name = "cmbRut"
        Me.cmbRut.Size = New System.Drawing.Size(144, 30)
        Me.cmbRut.TabIndex = 14
        '
        'EmpaqueBindingSource
        '
        Me.EmpaqueBindingSource.DataMember = "empaque"
        Me.EmpaqueBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'EmpaqueDataSet
        '
        Me.EmpaqueDataSet.DataSetName = "empaqueDataSet"
        Me.EmpaqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(33, 94)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Nombres:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(33, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 22)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "RUT:"
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(434, 174)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(190, 57)
        Me.btnConsultar.TabIndex = 8
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(141, 270)
        Me.txtTotal.MaxLength = 5
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(130, 29)
        Me.txtTotal.TabIndex = 6
        '
        'txtGastos
        '
        Me.txtGastos.Location = New System.Drawing.Point(141, 230)
        Me.txtGastos.MaxLength = 5
        Me.txtGastos.Name = "txtGastos"
        Me.txtGastos.Size = New System.Drawing.Size(130, 29)
        Me.txtGastos.TabIndex = 4
        '
        'txtSaldo
        '
        Me.txtSaldo.Location = New System.Drawing.Point(141, 188)
        Me.txtSaldo.MaxLength = 5
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(130, 29)
        Me.txtSaldo.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(188, 313)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(149, 29)
        Me.dtpFecha.TabIndex = 29
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(37, 364)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(182, 48)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(528, 364)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(182, 48)
        Me.btnEliminar.TabIndex = 11
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(340, 364)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(182, 48)
        Me.btnModificar.TabIndex = 10
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(149, 22)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Fecha de Registro:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 278)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 22)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 237)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 22)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Gastos:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 22)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Saldo:"
        '
        'cmbAnio
        '
        Me.cmbAnio.DataSource = Me.AñosBindingSource
        Me.cmbAnio.DisplayMember = "anios"
        Me.cmbAnio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(503, 141)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(121, 30)
        Me.cmbAnio.TabIndex = 2
        '
        'AñosBindingSource
        '
        Me.AñosBindingSource.DataMember = "años"
        Me.AñosBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'cmbMes
        '
        Me.cmbMes.DataSource = Me.MesesBindingSource
        Me.cmbMes.DisplayMember = "mes"
        Me.cmbMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMes.FormattingEnabled = True
        Me.cmbMes.Location = New System.Drawing.Point(272, 141)
        Me.cmbMes.Name = "cmbMes"
        Me.cmbMes.Size = New System.Drawing.Size(164, 30)
        Me.cmbMes.TabIndex = 1
        '
        'MesesBindingSource
        '
        Me.MesesBindingSource.DataMember = "meses"
        Me.MesesBindingSource.DataSource = Me.EmpaqueDataSet
        '
        'cmbDia
        '
        Me.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDia.FormattingEnabled = True
        Me.cmbDia.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDia.Location = New System.Drawing.Point(78, 141)
        Me.cmbDia.MaxLength = 2
        Me.cmbDia.Name = "cmbDia"
        Me.cmbDia.Size = New System.Drawing.Size(121, 30)
        Me.cmbDia.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(453, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 22)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Año:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(220, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 22)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Mes:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 22)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Día:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(423, 462)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(132, 31)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.Location = New System.Drawing.Point(611, 462)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(132, 31)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'MesesTableAdapter
        '
        Me.MesesTableAdapter.ClearBeforeFill = True
        '
        'AñosTableAdapter
        '
        Me.AñosTableAdapter.ClearBeforeFill = True
        '
        'EmpaqueTableAdapter
        '
        Me.EmpaqueTableAdapter.ClearBeforeFill = True
        '
        'RegistrarPropinas
        '
        Me.AcceptButton = Me.btnAceptar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Empaques.My.Resources.Resources.abst_20_min
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(776, 505)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "RegistrarPropinas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrar Propinas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpaqueBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpaqueDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AñosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MesesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtGastos As System.Windows.Forms.TextBox
    Friend WithEvents txtSaldo As System.Windows.Forms.TextBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMes As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDia As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSupermercado As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApellidos As System.Windows.Forms.TextBox
    Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbRut As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnConsultar As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnSumar As System.Windows.Forms.Button
    Friend WithEvents EmpaqueDataSet As Empaques.empaqueDataSet
    Friend WithEvents MesesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MesesTableAdapter As Empaques.empaqueDataSetTableAdapters.mesesTableAdapter
    Friend WithEvents AñosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AñosTableAdapter As Empaques.empaqueDataSetTableAdapters.añosTableAdapter
    Friend WithEvents EmpaqueBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpaqueTableAdapter As Empaques.empaqueDataSetTableAdapters.empaqueTableAdapter
End Class
