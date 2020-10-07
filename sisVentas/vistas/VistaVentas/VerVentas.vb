Public Class VerVentas
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub DTPVentasVerDesde_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentasVerDesde.ValueChanged
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        Dim fecha As Date

        If DateTime.Compare(DTPVentasVerDesde.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            fecha = DateAdd(DateInterval.Day, -1, fechaActual)
             DTPVentasVerDesde.Value = fecha
        End If
    End Sub

    Private Sub DTPVentasVerHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentasVerHasta.ValueChanged
        Dim fechaInicial As Date
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        fechaInicial = DTPVentasVerDesde.Value
        If DateTime.Compare(DTPVentasVerHasta.Value, DTPVentasVerDesde.Value) < 0 Then
            FrmErrorFechaFinal.Show()
            DTPVentasVerHasta.Value = fechaActual
        ElseIf DateTime.Compare(DTPVentasVerHasta.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DTPVentasVerHasta.Value = fechaActual

        End If
    End Sub
End Class