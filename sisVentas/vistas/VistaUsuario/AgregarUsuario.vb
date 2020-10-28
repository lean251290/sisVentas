﻿Imports System.Text.RegularExpressions
Public Class Agregar_Usuario
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub BtnAgregarUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseDown
        BtnAgregarUsuario.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()

    End Sub

    Private Sub BtnCancelar_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelar.MouseDown
        BtnCancelar.BackgroundImage = My.Resources.btn122x45Rojo

    End Sub

    Private Sub BtnCancelar_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelar.MouseUp
        BtnCancelar.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PBUser_Click(sender As Object, e As EventArgs) Handles PBUser.Click
        dialogUser.ShowDialog()
        If dialogUser.FileName <> "" Then
            PBUser.ImageLocation = dialogUser.FileName
        End If
    End Sub


    Private Sub TNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreUsuario.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub


    Private Sub TApellidoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoUsuario.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub


    Private Sub TDniUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniUsuario.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub



    Private Sub TEmailUsuario_LostFocus(sender As Object, e As EventArgs) Handles TEmailUsuario.LostFocus
        Dim mail As String
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"

        If Not Regex.IsMatch(TEmailUsuario.Text, mail) Then
            FrmErrorMail.Show()

            TEmailUsuario.Text = ""
        End If
    End Sub



    Private Sub TRePassUsuario_LostFocus(sender As Object, e As EventArgs) Handles TRePassUsuario.LostFocus
        If TPassUsuario.Text <> TRePassUsuario.Text Then
            FrmMatch.Show()
            TPassUsuario.Text = ""
            TRePassUsuario.Text = ""
        End If
    End Sub



    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuario.Click
        Dim cantidad As Integer
        cantidad = Len(TDniUsuario.Text)
        If cantidad <> 8 Then
            FrmValidarDni.Show()
            TDniUsuario.Text = ""
        End If
        Dim imagen As Image
        imagen = PBUser.Image
        If TNombreUsuario.Text = "" Or TApellidoUsuario.Text = "" Or TDniUsuario.Text = "" Or
           TDireccionUsuario.Text = "" Or TEmailUsuario.Text = "" Or TPassUsuario.Text = "" Or
           TRePassUsuario.Text = "" Or CMPerfil.SelectedItem Is Nothing Or PBUser.Image Is Nothing Then
            FrmRellenarCampos.Show()
            'p_dni, p_nombre, p_apellido, p_correo, p_direccion, p_pass, p_imagen, p_tipo, p_estado
        Else
            Dim User As New Usuarios(TDniUsuario.Text, TNombreUsuario.Text, TApellidoUsuario.Text, TEmailUsuario.Text, TDireccionUsuario.Text, TPassUsuario.Text, PBUser.Image, CMPerfil.SelectedItem, "Activo")
            If User.agregarUsuario() Then
                TNombreUsuario.Text = ""
                TApellidoUsuario.Text = ""
                TDniUsuario.Text = ""
                TDireccionUsuario.Text = ""
                TEmailUsuario.Text = ""
                TPassUsuario.Text = ""
                TRePassUsuario.Text = ""
                CMPerfil.SelectedItem = -1
                CMPerfil.Text = "Selecciona un perfil"
                FrmDatosCargadosCorrecto.Show()
            Else
                MsgBox("error", vbCritical, "error")
            End If
        End If
    End Sub

    Private Sub BtnAgregarUsuario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseUp
        BtnAgregarUsuario.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub TDniUsuario_LostFocus(sender As Object, e As EventArgs) Handles TDniUsuario.LostFocus
        Dim user As New Usuarios
        If user.VerificarDNI(TDniUsuario.Text) Then
            FrmVerificaDNI.Show()
            TDniUsuario.Text = ""
        End If

    End Sub

    Private Sub TDireccionUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDireccionUsuario.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
           (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub

    Private Sub Agregar_Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CMPerfil.Items.Add("Gerente")
        Me.CMPerfil.Items.Add("Vendedor")
        Me.CMPerfil.Items.Add("Administrador")
    End Sub


End Class