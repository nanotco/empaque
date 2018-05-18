Imports MySql.Data.MySqlClient
Public Class RegistrarPropinas
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSaldo.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case vbBack
            Case Else
                e.KeyChar = vbNullChar
        End Select
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGastos.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case vbBack
            Case Else
                e.KeyChar = vbNullChar
        End Select
    End Sub
    Private Sub RegistrarPropinas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.EmpaqueTableAdapter.Fill(Me.EmpaqueDataSet.empaque)
        Me.AñosTableAdapter.Fill(Me.EmpaqueDataSet.años)
        Me.MesesTableAdapter.Fill(Me.EmpaqueDataSet.meses)
        Me.AñosTableAdapter.Fill(Me.EmpaqueDataSet.años)
        Call Consulta()
        btnEliminar.Visible = False
        btnModificar.Visible = False
        txtGastos.Text = 0
    End Sub
    Sub Consulta()
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT * FROM empaque WHERE Rut= '" & cmbRut.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                txtNombres.Text = Rec("Nombres")
                txtApellidos.Text = Rec("Apellidos")
                txtSupermercado.Text = Rec("Supermercado")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnSumar_Click(sender As Object, e As EventArgs) Handles btnSumar.Click
        Try
            Dim saldo As Integer
            Dim gastos As Integer
            Dim total As Integer
            saldo = txtSaldo.Text
            gastos = txtGastos.Text
            total = saldo + gastos
            txtTotal.Text = total
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If cmbDia.SelectedIndex = -1 Then
            MsgBox("Seleccione dia", MsgBoxStyle.Information)
            cmbDia.Focus()
            Return
        End If
        If txtSaldo.Text = "" Then
            MsgBox("Ingrese saldo", MsgBoxStyle.Information)
            txtSaldo.Focus()
            Return
        End If
        If txtGastos.Text = "" Then
            MsgBox("Ingrese gastos o ingrese cero, si no hubo gastos", MsgBoxStyle.Information)
            txtGastos.Focus()
            Return
        End If
        If txtTotal.Text = "" Then
            MsgBox("Presione botón Sumar", MsgBoxStyle.Information)
            btnSumar.Focus()
            Return
        End If
        Dim MiBd As New ClaseBd
        Dim CadSql As String
        Dim Rec As MySqlDataReader
        Try
            CadSql = "SELECT * FROM detallepropinas WHERE rut='" & cmbRut.Text & "'and dia= '" & cmbDia.Text & "'and mes= '" & cmbMes.Text & "'and anio= '" & cmbAnio.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe Registro en la Base de Datos", MsgBoxStyle.Information)
                Rec.Close()
                Return
            Else
                Rec.Close()
                CadSql = "INSERT INTO detallepropinas(rut,dia,mes,anio,saldo,gastos,total,fechaRegistro) VALUES ('" & cmbRut.Text & "', '" & cmbDia.Text & "', '" & cmbMes.Text & "', '" & cmbAnio.Text & "','" & txtSaldo.Text & "', '" & txtGastos.Text & "','" & txtTotal.Text & "', '" & dtpFecha.Text & "' )"
                If MiBd.EjecutarIUD(CadSql) > 0 Then
                    MsgBox("Se registró con éxito")
                    Totales.DetallepropinasTableAdapter.Fill(Me.EmpaqueDataSet.detallepropinas)
                    txtGastos.Text = 0
                    txtSaldo.Clear()
                    txtTotal.Clear()
                    cmbDia.Focus()
                Else
                    MsgBox("No se registró")
                End If
                Rec.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            Dim Rec As MySqlDataReader
            CadSql = "SELECT * FROM detallepropinas WHERE rut='" & cmbRut.Text & "'and dia= '" & cmbDia.Text & "'and mes= '" & cmbMes.Text & "'and anio= '" & cmbAnio.Text & "'"
            Rec = MiBd.EjecutarConsulta(CadSql)
            If Rec.Read Then
                MsgBox("Ya existe Registro en la Base de Datos", MsgBoxStyle.Information)
                txtSaldo.Text = Rec("saldo")
                txtGastos.Text = Rec("gastos")
                txtTotal.Text = Rec("total")
            Else
                MsgBox("Nada Registrado en la Base de Datos", MsgBoxStyle.Information)
                Call Limpiar()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Call Limpiar()
    End Sub
    Sub Limpiar()
        txtSaldo.Clear()
        txtGastos.Clear()
        txtTotal.Clear()
        cmbMes.SelectedIndex = -1
        cmbDia.SelectedIndex = -1
        btnEliminar.Visible = False
        btnModificar.Visible = False
        cmbDia.Focus()
    End Sub
End Class