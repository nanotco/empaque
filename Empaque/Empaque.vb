Imports MySql.Data.MySqlClient
Public Class Empaque
    Private Sub Empaque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Try
            Dim MiBd As New ClaseBd
            Dim CadSql As String
            CadSql = "INSERT INTO empaque(Rut,Nombres,Apellidos,Supermercado,FechaIngreso) VALUES ('" & mtbRut.Text & "', '" & txtNombres.Text & "', '" & txtApellidos.Text & "', '" & txtSupermercado.Text & "','" & dtpFechaIngreso.Text & "')"
            If MiBd.EjecutarIUD(CadSql) > 0 Then
                MsgBox("Empaque registrado con exito")
            Else
                MsgBox("Error al registrar empaque")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub mtbRut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mtbRut.KeyPress
        Select Case e.KeyChar
            Case "0" To "9"
            Case "k", "K"
                e.KeyChar = "K"
            Case Else
                e.KeyChar = vbNullChar
        End Select
    End Sub
End Class