Public Class FrmModificarUsuario
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub



    Private Sub BtnActualizarUser_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnActualizarUser.MouseDown
        BtnActualizarUser.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnActualizarUser_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnActualizarUser.MouseUp
        BtnActualizarUser.BackgroundImage = My.Resources.btn122x45

    End Sub



    Private Sub BtnCancelarUser_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarUser.MouseDown
        BtnCancelarUser.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarUser_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarUser.MouseUp
        BtnCancelarUser.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub BtnCancelarUser_Click(sender As Object, e As EventArgs) Handles BtnCancelarUser.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub

    Private Sub BtnActualizarUser_Click(sender As Object, e As EventArgs) Handles BtnActualizarUser.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub
End Class