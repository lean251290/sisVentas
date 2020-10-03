Public Class FrmCargarImagenError
    Private Sub BtnAceptarImagen_Click(sender As Object, e As EventArgs) Handles BtnAceptarImagen.Click

    End Sub

    Private Sub BtnAceptarImagen_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAceptarImagen.MouseDown
        BtnAceptarImagen.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnAceptarImagen_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAceptarImagen.MouseUp
        BtnAceptarImagen.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class