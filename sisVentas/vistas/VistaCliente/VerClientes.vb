Public Class VerClientes
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles BtnModificarCliente.Click
        PanelAdmin.Enabled = False
        PanelAdmin.Hide()
        FrmModificarCliente.Show()
    End Sub

    Private Sub BtnModificarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseDown
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseUp
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs) Handles BtnEliminarCliente.Click
        FrmSiNoCliente.Show()
    End Sub

    Private Sub BtnEliminarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarCliente.MouseDown
        BtnEliminarCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnEliminarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarCliente.MouseUp
        BtnEliminarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub



    Private Sub TBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub
End Class