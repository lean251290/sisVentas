﻿Public Class FrmSiNoUser


    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSiUser.MouseDown
        BtnSiUser.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnSiUser_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSiUser.MouseUp
        BtnSiUser.BackgroundImage = My.Resources.btn122x45
    End Sub



    Private Sub BtnNoUser_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnNoUser.MouseUp
        BtnNoUser.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnNoUser_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnNoUser.MouseDown
        BtnNoUser.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnSiUser_Click(sender As Object, e As EventArgs) Handles BtnSiUser.Click
        Dim user As New Usuarios()
        user.BorrarUser(Me.Tag)
        'VerUsuarios.Activate()
        'VerUsuarios.RBUsuariosBorrados.Checked = True
        'VerUsuarios.cargarGridUserBorrados()
        PanelAdmin.cerrarFormHijo(VerUsuarios)
        PanelAdmin.abrirFormHijo(VerUsuarios)
        Me.Close()
        FrmDatosActualizados.Show()
    End Sub
End Class