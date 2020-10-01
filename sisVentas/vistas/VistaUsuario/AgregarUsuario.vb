﻿Public Class Agregar_Usuario
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnAgregarUser_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuario.Click
        Dim User As New UserClass(TNombreUsuario.Text, TApellidoUsuario.Text, TDniUsuario.Text, TDireccionUsuario.Text, TEmailUsuario.Text, TPassUsuario.Text, PictureBox1.Image)
        If User.agregarUsuario() Then
            MsgBox("correcto", vbOK, "Correcto")
        Else
            MsgBox("error", vbCritical, "error")
        End If
    End Sub



    Private Sub BtnAgregarUsuario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseUp
        BtnAgregarUsuario.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnAgregarUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseDown
        BtnAgregarUsuario.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click


    End Sub

    Private Sub BtnCancelar_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelar.MouseDown
        BtnCancelar.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnCancelar_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelar.MouseUp
        BtnCancelar.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class