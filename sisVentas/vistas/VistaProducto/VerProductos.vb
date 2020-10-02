Public Class VerProductos
    Private Sub BtnModificarProducto_Click(sender As Object, e As EventArgs) Handles BtnModificarProducto.Click
        PanelAdmin.Enabled = False
        PanelAdmin.Hide()
        ModificarProducto.Show()
    End Sub

    Private Sub BtnModificarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarProducto.MouseDown
        BtnModificarProducto.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarProducto.MouseUp
        BtnModificarProducto.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        FrmSiNoProducto.Show()
    End Sub

    Private Sub BtnEliminarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarProducto.MouseDown
        BtnEliminarProducto.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnEliminarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarProducto.MouseUp
        BtnEliminarProducto.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class