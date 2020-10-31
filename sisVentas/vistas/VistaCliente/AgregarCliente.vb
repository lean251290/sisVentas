Imports System.Text.RegularExpressions
Public Class AgregarCliente

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        If (TNombreCliente.Text = "" Or TApellidoCliente.Text = "" Or TEmailCliente.Text = "" Or
            TDniCliente.Text = "" Or TDireccionCliente.Text = "" Or TTelefonoCliente.Text = "") Then
            FrmRellenarCampos.Show()
        Else
            Dim cliente As New Cliente(TNombreCliente.Text, TApellidoCliente.Text, TDniCliente.Text, TEmailCliente.Text, TDireccionCliente.Text, TTelefonoCliente.Text)
            If cliente.AgregarCliente() Then
                FrmDatosCargadosCorrecto.Show()
                TNombreCliente.Text = ""
                TApellidoCliente.Text = ""
                TEmailCliente.Text = ""
                TDniCliente.Text = ""
                TDireccionCliente.Text = ""
                TTelefonoCliente.Text = ""
            End If
        End If
    End Sub

    Private Sub BtnAgregarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarCliente.MouseDown
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnAgregarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarCliente.MouseUp
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub
    Private Sub BtnCancelarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseDown
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseUp
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub TNombreUsuario_TextChanged(sender As Object, e As EventArgs) Handles TNombreCliente.TextChanged

    End Sub

    Private Sub TNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If

    End Sub

    Private Sub TDniUsuario_TextChanged(sender As Object, e As EventArgs) Handles TDniCliente.TextChanged

    End Sub

    Private Sub TDniUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniCliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub TApellidoUsuario_TextChanged(sender As Object, e As EventArgs) Handles TApellidoCliente.TextChanged

    End Sub

    Private Sub TApellidoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub

    Private Sub TEmailUsuario_TextChanged(sender As Object, e As EventArgs) Handles TEmailCliente.TextChanged

    End Sub

    Private Sub TEmailUsuario_LostFocus(sender As Object, e As EventArgs) Handles TEmailCliente.LostFocus
        Dim mail As String
        Dim cli As New Cliente
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"

        If Not Regex.IsMatch(TEmailCliente.Text, mail) Then
            FrmErrorMail.Show()
        ElseIf cli.VerificarEmail(TEmailCliente.Text) Then
            LabelEmailCliente.Visible = True
            TEmailCliente.Text = ""
        Else
            LabelEmailCliente.Visible = False
        End If
    End Sub

    Private Sub BtnAgregarCliente_MouseLeave(sender As Object, e As EventArgs) Handles BtnAgregarCliente.MouseLeave
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub TDniCliente_LostFocus(sender As Object, e As EventArgs) Handles TDniCliente.LostFocus
        Dim cantidad As Integer
        Dim cliente As New Cliente
        cantidad = Len(TDniCliente.Text)
        If cantidad < 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = ""
        ElseIf cantidad > 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = ""
        ElseIf cliente.VerificarDNI(TDniCliente.Text) Then
            LabelDniCliente.Visible = True
            TDniCliente.Text = ""
        Else
            LabelDniCliente.Visible = False
        End If
    End Sub



    Private Sub TDireccionCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDireccionCliente.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
          (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub


    Private Sub TTelefonoCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefonoCliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then

            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub AgregarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelDniCliente.Visible = False
        LabelEmailCliente.Visible = False
        LabelDireccionCli.Visible = False
        LabelTelCli.Visible = False
    End Sub



    Private Sub TDireccionCliente_LostFocus(sender As Object, e As EventArgs) Handles TDireccionCliente.LostFocus
        Dim direccion As String
        direccion = "^[A-z\s]+(\d{1,5})"
        If Not Regex.IsMatch(TDireccionCliente.Text, direccion) Then
            LabelDireccionCli.Visible = True
            TDireccionCliente.Text = ""
        Else
            LabelDireccionCli.Visible = False
        End If
    End Sub


    Private Sub TTelefonoCliente_LostFocus(sender As Object, e As EventArgs) Handles TTelefonoCliente.LostFocus
        Dim telefono As String
        telefono = "^\d{1,3}"
        If Not Regex.IsMatch(TTelefonoCliente.Text, telefono) Then
            LabelTelCli.Visible = True
            TTelefonoCliente.Text = ""
        Else
            LabelTelCli.Visible = False
        End If
    End Sub

    Private Sub TTelefonoCliente_TextChanged(sender As Object, e As EventArgs) Handles TTelefonoCliente.TextChanged

    End Sub
End Class