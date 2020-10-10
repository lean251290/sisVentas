Imports System.Text.RegularExpressions
Public Class AgregarCliente

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        If (TNombreCliente.Text = "" Or TApellidoCliente.Text = "" Or TEmailCliente.Text = "" Or
            TDniCliente.Text = "" Or TDireccionCliente.Text = "" Or TTelefonoCliente.Text = "") Then
            FrmRellenarCampos.Show()
        Else
            Dim cliente As New Cliente(TDniCliente.Text, TNombreCliente.Text, TApellidoCliente.Text, TDireccionCliente.Text, TEmailCliente.Text, TTelefonoCliente.Text)
            If cliente.AgregarCliente() Then
                MsgBox("correcto", vbOK, "Correcto")
                FrmDatosCargadosCorrecto.Show()
                TNombreCliente.Text = ""
                TApellidoCliente.Text = ""
                TEmailCliente.Text = ""
                TDniCliente.Text = ""
                TDireccionCliente.Text = ""
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
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"

        If Not Regex.IsMatch(TEmailCliente.Text, mail) Then
            FrmErrorMail.Show()
        End If
    End Sub

    Private Sub BtnAgregarCliente_MouseLeave(sender As Object, e As EventArgs) Handles BtnAgregarCliente.MouseLeave
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub TDniCliente_LostFocus(sender As Object, e As EventArgs) Handles TDniCliente.LostFocus
        Dim cantidad As Integer
        cantidad = Len(TDniCliente.Text)
        If cantidad < 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = ""
        ElseIf cantidad > 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = ""
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
End Class