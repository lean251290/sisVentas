Public Class VerClientes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles BtnModificarCliente.Click

    End Sub

    Private Sub BtnModificarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseDown
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseUp
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class