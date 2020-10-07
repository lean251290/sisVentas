Public Class PanelRepoVentaXUsuario
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub



    Private Sub TbVentaReportes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbReporteVentaXUsuario.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub

    Private Sub DTPVentaXUsuarioDesde_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentaXUsuarioDesde.ValueChanged
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        Dim fecha As Date

        If DateTime.Compare(DTPVentaXUsuarioDesde.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            fecha = DateAdd(DateInterval.Day, -1, fechaActual)
            DTPVentaXUsuarioDesde.Value = fecha
        End If
    End Sub

    Private Sub DTPVentaXUsuarioHasta_ValueChanged(sender As Object, e As EventArgs) Handles DTPVentaXUsuarioHasta.ValueChanged
        Dim fechaInicial As Date
        Dim fechaActual As Date
        fechaActual = DateTime.Now
        fechaInicial = DTPVentaXUsuarioDesde.Value
        If DateTime.Compare(DTPVentaXUsuarioHasta.Value, DTPVentaXUsuarioDesde.Value) < 0 Then
            FrmErrorFechaFinal.Show()
            DTPVentaXUsuarioHasta.Value = fechaActual
        ElseIf DateTime.Compare(DTPVentaXUsuarioHasta.Value, fechaActual) > 0 Then
            FrmFechaActual.Show()
            DTPVentaXUsuarioHasta.Value = fechaActual

        End If

    End Sub
End Class