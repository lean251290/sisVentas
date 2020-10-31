Imports System.Text.RegularExpressions
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

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuario.Click
        Dim imagen As Image
        imagen = PBUser.Image
        If TNombreUsuario.Text = "" Or TApellidoUsuario.Text = "" Or TDniUsuario.Text = "" Or
           TDireccionUsuario.Text = "" Or TEmailUsuario.Text = "" Or TPassUsuario.Text = "" Or
           TRePassUsuario.Text = "" Or CMPerfil.SelectedItem Is Nothing Or PBUser.Image Is Nothing Then
            FrmRellenarCampos.Show()
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
                CMPerfil.Refresh()
                PBUser.Refresh()
                CMPerfil.Text = "Selecciona un perfil"
                PanelAdmin.cerrarFormHijo(Me)
                PanelAdmin.abrirFormHijo(VerUsuarios)
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
        Dim cantidad As Integer
        cantidad = Len(TDniUsuario.Text)
        If cantidad <> 8 Then
            LabelDniNumeros.Visible = True
            TDniUsuario.Text = ""
        Else
            LabelDniNumeros.Visible = False
        End If
        If user.VerificarDNI(TDniUsuario.Text) Then
            LabelDNI.Visible = True
            TDniUsuario.Text = ""
        Else
            LabelDNI.Visible = False
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
        LblPassNoCoincide.Visible = False
        LabelDNI.Visible = False
        LabelEmail.Visible = False
        LabelPass.Visible = False
        LabelDniNumeros.Visible = False
        LabelVerifEmail.Visible = False
        LabelDireUser.Visible = False
    End Sub



    Private Sub TPassUsuario_LostFocus(sender As Object, e As EventArgs) Handles TPassUsuario.LostFocus
        '^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$
        'La contraseña debe tener al entre 8 y 16 caracteres, al menos un dígito,
        'al menos una minúscula, al menos una mayúscula y al menos un caracter no alfanumérico.
        Dim pass As String
        pass = "^(?=.*\d)(?=.*[\u0021-\u002b\u003c-\u0040])(?=.*[A-Z])(?=.*[a-z])\S{8,16}$"
        If Not Regex.IsMatch(TPassUsuario.Text, pass) Then
            LabelPass.Visible = True
            TPassUsuario.Text = ""
        Else
            LabelPass.Visible = False
        End If
    End Sub

    Private Sub TEmailUsuario_LostFocus(sender As Object, e As EventArgs) Handles TEmailUsuario.LostFocus
        Dim mail As String
        Dim user As New Usuarios
        If user.VerificarEmail(TEmailUsuario.Text) Then
            LabelVerifEmail.Visible = True
            TEmailUsuario.Text = ""
        Else
            LabelVerifEmail.Visible = False
        End If
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If Not Regex.IsMatch(TEmailUsuario.Text, mail) Then
            LabelEmail.Visible = True
            TEmailUsuario.Text = ""
        Else
            LabelEmail.Visible = False
        End If
    End Sub

    Private Sub TRePassUsuario_TextChanged(sender As Object, e As EventArgs) Handles TRePassUsuario.TextChanged

    End Sub

    Private Sub TRePassUsuario_LostFocus(sender As Object, e As EventArgs) Handles TRePassUsuario.LostFocus
        If TPassUsuario.Text <> TRePassUsuario.Text Then
            LblPassNoCoincide.Visible = True
            TRePassUsuario.Text = ""
        Else
            LblPassNoCoincide.Visible = False
        End If
    End Sub

    Private Sub TDireccionUsuario_TextChanged(sender As Object, e As EventArgs) Handles TDireccionUsuario.TextChanged

    End Sub

    Private Sub TDireccionUsuario_LostFocus(sender As Object, e As EventArgs) Handles TDireccionUsuario.LostFocus
        Dim direccion As String
        direccion = "^[A-z\s]+(\d{1,5})"
        If Not Regex.IsMatch(TDireccionUsuario.Text, direccion) Then
            LabelDireUser.Visible = True
            TDireccionUsuario.Text = ""
        Else
            LabelDireUser.Visible = False
        End If
    End Sub
End Class