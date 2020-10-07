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

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class