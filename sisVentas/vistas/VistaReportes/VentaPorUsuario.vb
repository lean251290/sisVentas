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



    Private Sub TbReporteVentaXUsuario_TextChanged(sender As Object, e As EventArgs) Handles TbReporteVentaXUsuario.TextChanged
        Dim cabe As New Cabecera
        RichTextBox1.Text = cabe.reportesPorUsuario(TbReporteVentaXUsuario.Text)

    End Sub
End Class