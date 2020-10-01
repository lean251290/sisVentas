Public Class ModificarProducto
    Private Sub BtnActualizarProd_Click(sender As Object, e As EventArgs) Handles BtnActualizarProd.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnActualizarProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnActualizarProd.MouseDown
        BtnActualizarProd.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnActualizarProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnActualizarProd.MouseUp
        BtnActualizarProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarModifProd_Click(sender As Object, e As EventArgs) Handles BtnCancelarModifProd.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnCancelarModifProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarModifProd.MouseDown
        BtnCancelarModifProd.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarModifProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarModifProd.MouseUp
        BtnCancelarModifProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub
End Class