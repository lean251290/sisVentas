Public Class FrmSiNoProducto
    Private Sub BtnSiProd_Click(sender As Object, e As EventArgs) Handles BtnSiProd.Click
        Dim prod As New Producto
        prod.EliminarProd(Me.Tag)
        PanelAdmin.cerrarFormHijo(VerProductos)
        PanelAdmin.abrirFormHijo(VerProductos)

        VerProductos.CargarProdBorrados()
        VerProductos.RBprodEliminados.Checked = True

    End Sub

    Private Sub BtnSiProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSiProd.MouseDown
        BtnSiProd.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnSiProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSiProd.MouseUp
        BtnSiProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnNoProd_Click(sender As Object, e As EventArgs) Handles BtnNoProd.Click

    End Sub

    Private Sub BtnNoProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnNoProd.MouseDown
        BtnNoProd.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnNoProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnNoProd.MouseUp
        BtnNoProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class