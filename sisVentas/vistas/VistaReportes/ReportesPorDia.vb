Public Class ReportesPorDia
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PBVentasXDia.Click
        Me.Close()
    End Sub

    Private Sub DTPVentasXDia_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentasXDia.ValueChanged
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        Dim fecha As Date

        If DateTime.Compare(DTPVentasXDia.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            fecha = DateAdd(DateInterval.Day, -1, fechaActual)
            DTPVentasXDia.Value = fecha
        End If
    End Sub

    Private Sub ReportesPorDia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cabecera As New Cabecera()
        RichTextBox1.Text = cabecera.reportesPorDia()
    End Sub
End Class