Public Class FrmModificarCliente
    Private Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub

    Private Sub BtnActualizarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnActualizarCliente.MouseDown
        BtnActualizarCliente.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnActualizarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnActualizarCliente.MouseUp
        BtnActualizarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarCliente_Click(sender As Object, e As EventArgs) Handles BtnCancelarCliente.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub

    Private Sub BtnCancelarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseDown
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseUp
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub
End Class