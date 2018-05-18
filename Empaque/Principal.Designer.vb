<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistarEmpaqueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarTodosFormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarFormulariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TotalesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Noto Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.VerToolStripMenuItem, Me.TotalesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1066, 25)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistarEmpaqueToolStripMenuItem, Me.SalirToolStripMenuItem, Me.CerrarTodosFormulariosToolStripMenuItem, Me.CerrarFormulariosToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(62, 21)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'RegistarEmpaqueToolStripMenuItem
        '
        Me.RegistarEmpaqueToolStripMenuItem.Name = "RegistarEmpaqueToolStripMenuItem"
        Me.RegistarEmpaqueToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.RegistarEmpaqueToolStripMenuItem.Text = "Registar Empaque"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.SalirToolStripMenuItem.Text = "Cerrar Formulario"
        '
        'CerrarTodosFormulariosToolStripMenuItem
        '
        Me.CerrarTodosFormulariosToolStripMenuItem.Name = "CerrarTodosFormulariosToolStripMenuItem"
        Me.CerrarTodosFormulariosToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CerrarTodosFormulariosToolStripMenuItem.Text = "Cerrar Todos Formularios"
        '
        'CerrarFormulariosToolStripMenuItem
        '
        Me.CerrarFormulariosToolStripMenuItem.Name = "CerrarFormulariosToolStripMenuItem"
        Me.CerrarFormulariosToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.CerrarFormulariosToolStripMenuItem.Text = "Salir"
        '
        'VerToolStripMenuItem
        '
        Me.VerToolStripMenuItem.Name = "VerToolStripMenuItem"
        Me.VerToolStripMenuItem.Size = New System.Drawing.Size(118, 21)
        Me.VerToolStripMenuItem.Text = "Registar Propinas"
        '
        'TotalesToolStripMenuItem
        '
        Me.TotalesToolStripMenuItem.Name = "TotalesToolStripMenuItem"
        Me.TotalesToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.TotalesToolStripMenuItem.Text = "Totales"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Empaques.My.Resources.Resources._10abstracto_g_071
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1066, 548)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Noto Sans", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empaque Universitario"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarFormulariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CerrarTodosFormulariosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistarEmpaqueToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TotalesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
