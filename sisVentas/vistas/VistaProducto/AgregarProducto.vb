Public Class AgregarProducto
    Private Sub BtnGuardarProducto_Click(sender As Object, e As EventArgs) Handles BtnGuardarProducto.Click

    End Sub

    Private Sub BtnGuardarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnGuardarProducto.MouseDown
        BtnGuardarProducto.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnGuardarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnGuardarProducto.MouseUp
        BtnGuardarProducto.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarProd_Click(sender As Object, e As EventArgs) Handles BtnCancelarProd.Click

    End Sub

    Private Sub BtnCancelarProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarProd.MouseDown
        BtnCancelarProd.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarProd.MouseUp
        BtnCancelarProd.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class