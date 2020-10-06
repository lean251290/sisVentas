Public Class ReporteVentasPorFecha
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker1_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker1.LostFocus
        Dim fechaActual As Date
        fechaActual = DateTime.Now

        If DateTime.Compare(DateTimePicker1.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DateTimePicker1.Value = fechaActual
        End If

    End Sub



    Private Sub DateTimePicker2_LostFocus(sender As Object, e As EventArgs) Handles DateTimePicker2.LostFocus
        Dim fechaInicial As Date
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        fechaInicial = DateTimePicker1.Value
        If DateTime.Compare(DateTimePicker2.Value, DateTimePicker1.Value) < 0 Then
            FrmErrorFechaFinal.Show()
            DateTimePicker2.Value = fechaActual
        End If
        If DateTime.Compare(DateTimePicker2.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DateTimePicker2.Value = fechaActual
        End If
    End Sub
End Class