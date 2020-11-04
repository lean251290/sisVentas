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

    Private Sub TbReporteVentaXCliente_TextChanged(sender As Object, e As EventArgs) Handles TbReporteVentaXCliente.TextChanged
        Dim cabecera As New Cabecera
        RichTextBox1.Text = cabecera.reportesPorCliente(TbReporteVentaXCliente.Text)
    End Sub
End Class