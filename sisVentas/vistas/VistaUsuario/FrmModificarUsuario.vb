Imports System.Text.RegularExpressions
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



    Private Sub TApellidoUsuarioModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoUsuarioModif.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub


    Private Sub TEmailUsuarioModif_LostFocus(sender As Object, e As EventArgs) Handles TEmailUsuarioModif.LostFocus
        Dim mail As String
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If Not Regex.IsMatch(TEmailUsuarioModif.Text, mail) Then
            FrmErrorMail.Show()
            TEmailUsuarioModif.Text = ""
        End If
    End Sub




    Private Sub TNombreUsuarioModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreUsuarioModif.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub


    Private Sub TDniUsuarioModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniUsuarioModif.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub PBUserModif_Click(sender As Object, e As EventArgs) Handles PBUserModif.Click
        DialogModificarUsuario.ShowDialog()
        If DialogModificarUsuario.FileName <> "" Then
            PBUserModif.ImageLocation = DialogModificarUsuario.FileName
        End If
    End Sub


    Private Sub TDireccionUsuarioModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDireccionUsuarioModif.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
       (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub



    Private Sub TDniUsuarioModif_LostFocus(sender As Object, e As EventArgs) Handles TDniUsuarioModif.LostFocus
        'Dim cantidad As Integer
        '  cantidad = Len(TDniUsuarioModif.Text)
        '  If cantidad < 8 Then
        ' FrmValidarDni.Show()
        '  TDniUsuarioModif.Text = ""
        ' ElseIf cantidad > 8 Then
        ' FrmValidarDni.Show()
        ' TDniUsuarioModif.Text = ""
        ' End If
    End Sub


    Private Sub FrmModificarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user As New Usuarios()
        user.TraerPorId(Me.Tag)
        TDniUsuarioModif.Text = user.getDni
        TNombreUsuarioModif.Text = user.getNombre
        TApellidoUsuarioModif.Text = user.getApellido
        TDireccionUsuarioModif.Text = user.getDireccion
        TEmailUsuarioModif.Text = user.getCorreo
        PBUserModif.Image = user.getImagen
    End Sub
    Private Sub BtnActualizarUser_Click(sender As Object, e As EventArgs) Handles BtnActualizarUser.Click
        Dim user As New Usuarios(TDireccionUsuarioModif.Text, TEmailUsuarioModif.Text, PBUserModif.Image)

        If user.ActualizarUser(Me.Tag) Then
            MsgBox("correcto")
            PanelAdmin.Enabled = True
            Me.Close()
            PanelAdmin.Show()
            PanelAdmin.cerrarFormHijo(VerUsuarios)
            PanelAdmin.abrirFormHijo(VerUsuarios)
            'VerUsuarios.cargarGridUser()
        Else
            MsgBox("error")
        End If

    End Sub
End Class