Public Class FrmSiNoCliente
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnSiProd_Click(sender As Object, e As EventArgs) Handles BtnSiCliente.Click

    End Sub

    Private Sub BtnSiCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSiCliente.MouseDown
        BtnSiCliente.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnSiCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSiCliente.MouseUp
        BtnSiCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnNoCliente_Click(sender As Object, e As EventArgs) Handles BtnNoCliente.Click

    End Sub

    Private Sub BtnNoCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnNoCliente.MouseDown
        BtnNoCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnNoCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnNoCliente.MouseUp
        BtnNoCliente.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class