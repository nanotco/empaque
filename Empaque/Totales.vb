Imports MySql.Data.MySqlClient
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class Totales
    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DetallepropinasTableAdapter.Fill(Me.EmpaqueDataSet.detallepropinas)
        Me.AñosTableAdapter.Fill(Me.EmpaqueDataSet.años)
        Me.MesesTableAdapter.Fill(Me.EmpaqueDataSet.meses)
        CmbMes.SelectedIndex = -1
        Call Saldo()
        Call Gastos()
        Call Total()
        Call Promedio()
        Call Contador()
    End Sub
    Sub Contador()
        Dim total As Double = 0
        Dim iTotal As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgvTotales(5, i).Value) / iTotal
        Next
        txtDiastrabajo.Text = Format(iTotal, "#,##")
    End Sub
    Sub Promedio()
        Dim total As Double = 0
        Dim iTotal As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgvTotales(5, i).Value) / iTotal
        Next
        txtPromedio.Text = Format(total, "$ #,##")
    End Sub
    Sub Total()
        Dim total As Double = 0
        Dim iTotal As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgvTotales(5, i).Value)
        Next
        txtTotal.Text = Format(total, "$ #,##")
    End Sub
    Sub Gastos()
        Dim gastos As Double = 0
        Dim igastos As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To igastos - 1
            gastos = gastos + Double.Parse(Me.dgvTotales(4, i).Value)
        Next
        txtGastos.Text = Format(gastos, "$ #,##")
    End Sub
    Sub Saldo()
        Dim total As Double = 0
        Dim iTotal As Integer = Me.dgvTotales.Rows.Count
        Dim i As Integer
        For i = 0 To iTotal - 1
            total = total + Double.Parse(Me.dgvTotales(3, i).Value)
        Next
        txtSaldo.Text = Format(total, "$ #,##")
    End Sub
    Private Sub btnCrearPDF_Click(sender As Object, e As EventArgs) Handles btnCrearPDF.Click
        Try
            Dim doc As New Document(PageSize.LETTER, 80, 80, 10, 10)
            Dim filename As String = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\Informe Empaque.pdf"
            Dim file As New FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.ReadWrite)
            PdfWriter.GetInstance(doc, file)
            doc.Open()
            ExportarDatosPDF(doc)
            doc.Close()
            Process.Start(filename)
        Catch ex As Exception
            MessageBox.Show("Recuerde tener instalado Adobe PDF Reader")
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub ExportarDatosPDF(ByVal document As Document)
        Dim datatable As New PdfPTable(dgvTotales.ColumnCount)
        datatable.DefaultCell.Padding = 3
        Dim headerwidths As Single() = GetColumnasSize(dgvTotales)
        datatable.SetWidths(headerwidths)
        datatable.WidthPercentage = 100
        datatable.DefaultCell.BorderWidth = 2
        datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER
        Dim encabezado As New Paragraph("Empaque Jumbo Temuco", New Font(Font.Name = "Arial", 12, Font.Bold))
        Dim texto As New Phrase("Listado de Propinas de: " + CmbMes.Text + " " + cmbAnio.Text + " al día " + Now.Date(), New Font(Font.Name = "Arial", 10, Font.Bold))
        Dim saldo As New Paragraph("El saldo de " + CmbMes.Text + " " + cmbAnio.Text + " es: " + txtSaldo.Text, New Font(Font.Name = "Arial", 10, Font.Bold))
        Dim gastos As New Paragraph("El gasto de " + CmbMes.Text + " " + cmbAnio.Text + " es: " + txtGastos.Text, New Font(Font.Name = "Arial", 10, Font.Bold))
        Dim total As New Paragraph("El total de " + CmbMes.Text + " " + cmbAnio.Text + " es: " + txtTotal.Text, New Font(Font.Name = "Arial", 10, Font.Bold))
        For i As Integer = 0 To dgvTotales.ColumnCount - 1
            datatable.AddCell(dgvTotales.Columns(i).HeaderText)
        Next
        datatable.HeaderRows = 1
        datatable.DefaultCell.BorderWidth = 1
        For i As Integer = 0 To dgvTotales.RowCount - 1
            For j As Integer = 0 To dgvTotales.ColumnCount - 1
                datatable.AddCell(dgvTotales(j, i).Value.ToString())
            Next
            datatable.CompleteRow()
        Next
        document.Add(encabezado)
        document.Add(texto)
        document.Add(datatable)
        document.Add(saldo)
        document.Add(gastos)
        document.Add(total)
    End Sub
    Public Function GetColumnasSize(ByVal dg As DataGridView) As Single()
        Dim values As Single() = New Single(dg.ColumnCount - 1) {}
        For i As Integer = 0 To dg.ColumnCount - 1
            values(i) = CSng(dg.Columns(i).Width)
        Next
        Return values
    End Function
    Private Sub cmbAnio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnio.SelectedIndexChanged
        Try
            Dim GC As New DataView(EmpaqueDataSet.detallepropinas)
            GC.RowFilter = String.Format("Convert(anio,'System.String') like '%{0}%'", cmbAnio.Text)
            dgvTotales.DataSource = GC
            Call Gastos()
            Call Saldo()
            Call Total()
            Call Promedio()
            Call Contador()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CmbMes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbMes.SelectedIndexChanged
        Try
            Dim GC As New DataView(EmpaqueDataSet.detallepropinas)
            If (cmbAnio.SelectedIndex > -1) And (CmbMes.SelectedIndex > -1) Then
                GC.RowFilter = String.Format("Convert (anio,'System.String') LIKE '%" & cmbAnio.Text & "%' And mes LIKE '%" & CmbMes.Text & "%'")
                dgvTotales.DataSource = GC
            Else
                'MsgBox("Seleccione año")
                cmbAnio.Focus()
            End If
            Call Gastos()
            Call Saldo()
            Call Total()
            Call Promedio()
            Call Contador()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNuevaConsulta.Click
        cmbAnio.SelectedIndex = -1
        CmbMes.SelectedIndex = -1
        cmbAnio.Focus()
        Call Saldo()
        Call Gastos()
        Call Total()
        Call Promedio()
        Call Contador()
    End Sub
End Class