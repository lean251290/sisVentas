Public Class VerUsuarios
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click

    End Sub

    Private Sub BtnModificarUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarUsuario.MouseDown
        BtnModificarUsuario.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarUsuario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarUsuario.MouseUp
        BtnModificarUsuario.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub BtnEliminarUsusario_Click(sender As Object, e As EventArgs) Handles BtnEliminarUsusario.Click

    End Sub

    Private Sub BtnEliminarUsusario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarUsusario.MouseDown
        BtnEliminarUsusario.BackgroundImage = My.Resources.btn122x45Rojo

    End Sub

    Private Sub BtnEliminarUsusario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarUsusario.MouseUp
        BtnEliminarUsusario.BackgroundImage = My.Resources.btn122x45

    End Sub
End Class