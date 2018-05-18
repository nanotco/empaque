Imports MySql.Data.MySqlClient
Public Class Principal
    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        Dim Frm As New RegistrarPropinas
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim Frm As Form
        Frm = Me.ActiveMdiChild
        If Not Frm Is Nothing Then
            Frm.Close()
        End If
    End Sub
    Private Sub CerrarFormulariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarFormulariosToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub CerrarTodosFormulariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarTodosFormulariosToolStripMenuItem.Click
        Dim Frm As Form
        For Each Frm In Me.MdiChildren
            Frm.Close()
        Next
    End Sub
    Private Sub RegistarEmpaqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistarEmpaqueToolStripMenuItem.Click
        Dim Frm As New Empaque
        Frm.MdiParent = Me
        Frm.Show()
    End Sub
    Private Sub TotalesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TotalesToolStripMenuItem.Click
        Dim Frm As New Totales
        Frm.MdiParent = Me
        Frm.Show()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
