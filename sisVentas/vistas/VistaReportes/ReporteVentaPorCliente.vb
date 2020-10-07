Public Class ReporteVentaPorCliente
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub TbReporteVentaXCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbReporteVentaXCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub

    Private Sub DTPVentaXClienteDesde_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentaXClienteDesde.ValueChanged
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        Dim fecha As Date

        If DateTime.Compare(DTPVentaXClienteDesde.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            fecha = DateAdd(DateInterval.Day, -1, fechaActual)
            DTPVentaXClienteDesde.Value = fecha
        End If
    End Sub

    Private Sub DTPVentaXClienteHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentaXClienteHasta.ValueChanged
        Dim fechaInicial As Date
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        fechaInicial = DTPVentaXClienteDesde.Value
        If DateTime.Compare(DTPVentaXClienteHasta.Value, DTPVentaXClienteDesde.Value) < 0 Then
            FrmErrorFechaFinal.Show()
            DTPVentaXClienteHasta.Value = fechaActual
        ElseIf DateTime.Compare(DTPVentaXClienteHasta.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DTPVentaXClienteHasta.Value = fechaActual

        End If

    End Sub
End Class