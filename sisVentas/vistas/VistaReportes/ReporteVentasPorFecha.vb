Public Class ReporteVentasPorFecha
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        Dim fecha As Date

        If DateTime.Compare(DateTimePicker1.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            fecha = DateAdd(DateInterval.Day, -1, fechaActual)
            DateTimePicker1.Value = fecha
        Else
            Dim fechaInicio As DateTime
            Dim fechaFin As DateTime
            fechaInicio = DateTimePicker1.Value
            fechaFin = DateTimePicker2.Value

            Dim fechaStringInicio As String = fechaInicio.ToShortDateString()
            Dim fechaStringFin As String = fechaFin.ToShortDateString()
            Dim cabecera As New Cabecera()
            RichTextBox1.Text = cabecera.reportes(fechaStringInicio, fechaStringFin, TextBoxCorreo.Text)
        End If
    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        Dim fechaInicial As Date
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        fechaInicial = DateTimePicker1.Value
        If DateTime.Compare(DateTimePicker2.Value, DateTimePicker1.Value) < 0 Then
            FrmErrorFechaFinal.Show()
            DateTimePicker2.Value = fechaActual
        ElseIf DateTime.Compare(DateTimePicker2.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DateTimePicker2.Value = fechaActual
        Else
            Dim fechaInicio As DateTime
            Dim fechaFin As DateTime
            fechaInicio = DateTimePicker1.Value
            fechaFin = DateTimePicker2.Value

            Dim fechaStringInicio As String = fechaInicio.ToShortDateString()
            Dim fechaStringFin As String = fechaFin.ToShortDateString()
            Dim cabecera As New Cabecera()
            RichTextBox1.Text = cabecera.reportes(fechaStringInicio, fechaStringFin, TextBoxCorreo.Text)

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ReporteVentasPorFecha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim fechaInicio As DateTime
        'Dim fechaFin As DateTime
        'fechaInicio = DateTimePicker1.Value
        'fechaFin = DateTimePicker2.Value

        'Dim fechaStringInicio As String = fechaInicio.ToShortDateString()
        'Dim fechaStringFin As String = fechaFin.ToShortDateString()
        'Dim cabecera As New Cabecera()
        'RichTextBox1.Text = cabecera.reportes(fechaStringInicio, fechaStringFin, TextBoxCorreo.Text)
    End Sub

    Private Sub TextBoxCorreo_TextChanged(sender As Object, e As EventArgs) Handles TextBoxCorreo.TextChanged
        Dim fechaInicio As DateTime
        Dim fechaFin As DateTime
        fechaInicio = DateTimePicker1.Value
        fechaFin = DateTimePicker2.Value

        Dim fechaStringInicio As String = fechaInicio.ToShortDateString()
        Dim fechaStringFin As String = fechaFin.ToShortDateString()
        Dim cabecera As New Cabecera()
        RichTextBox1.Text = cabecera.reportes(fechaStringInicio, fechaStringFin, TextBoxCorreo.Text)
    End Sub
End Class