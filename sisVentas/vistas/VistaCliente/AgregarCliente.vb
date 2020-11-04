Imports System.Text.RegularExpressions
Public Class AgregarCliente

    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click
        If (TNombreCliente.Text = "Ingrese Nombre" Or TApellidoCliente.Text = "Ingrese Apellido" Or TEmailCliente.Text = "Ingrese E-mail" Or
            TDniCliente.Text = "Ingrese D.N.I." Or TDireccionCliente.Text = "Ingrese Dirección" Or TTelefonoCliente.Text = "Ingrese Teléfono") Then
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
                PanelAdmin.abrirFormHijo(NuevaVenta)
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



    Private Sub TNombreUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If

    End Sub


    Private Sub TDniUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniCliente.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub



    Private Sub TApellidoUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub


    Private Sub TEmailUsuario_LostFocus(sender As Object, e As EventArgs) Handles TEmailCliente.LostFocus
        Dim mail As String
        Dim cli As New Cliente
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If TEmailCliente.Text = Nothing Then
            TEmailCliente.Text = "Ingrese E-mail"
            TEmailCliente.ForeColor = Color.DarkSlateGray
            Exit Sub
        End If

        If Not Regex.IsMatch(TEmailCliente.Text, mail) Then
            FrmErrorMail.Show()
            TEmailCliente.Text = "Ingrese E-mail"
            TEmailCliente.ForeColor = Color.DarkSlateGray
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
        If TDniCliente.Text = Nothing Then
            TDniCliente.Text = "Ingrese D.N.I."
            TDniCliente.ForeColor = Color.DarkSlateGray
        ElseIf cantidad < 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = "Ingrese D.N.I."
            TDniCliente.ForeColor = Color.DarkSlateGray
        ElseIf cantidad > 8 Then
            FrmValidarDni.Show()
            TDniCliente.Text = "Ingrese D.N.I."
            TDniCliente.ForeColor = Color.DarkSlateGray
        ElseIf cliente.VerificarDNI(TDniCliente.Text) Then
            LabelDniCliente.Visible = True
            TDniCliente.Text = "Ingrese D.N.I."
            TDniCliente.ForeColor = Color.DarkSlateGray
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
        TDniCliente.Text = "Ingrese D.N.I."
        TDniCliente.ForeColor = Color.DarkSlateGray
        TNombreCliente.Text = "Ingrese Nombre"
        TNombreCliente.ForeColor = Color.DarkSlateGray
        TApellidoCliente.Text = "Ingrese Apellido"
        TApellidoCliente.ForeColor = Color.DarkSlateGray
        TEmailCliente.Text = "Ingrese E-mail"
        TEmailCliente.ForeColor = Color.DarkSlateGray
        TDireccionCliente.Text = "Ingrese Dirección"
        TDireccionCliente.ForeColor = Color.DarkSlateGray
        TTelefonoCliente.Text = "Ingrese Teléfono"
        TTelefonoCliente.ForeColor = Color.DarkSlateGray
    End Sub



    Private Sub TDireccionCliente_LostFocus(sender As Object, e As EventArgs) Handles TDireccionCliente.LostFocus
        Dim direccion As String
        If TDireccionCliente.Text = Nothing Then
            TDireccionCliente.Text = "Ingrese Dirección"
            TDireccionCliente.ForeColor = Color.DarkSlateGray
            Exit Sub
        End If
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
        If TTelefonoCliente.Text = Nothing Then
            TTelefonoCliente.Text = "Ingrese Teléfono"
            TTelefonoCliente.ForeColor = Color.DarkSlateGray
            Exit Sub
        End If
        If Not Regex.IsMatch(TTelefonoCliente.Text, telefono) Then
            LabelTelCli.Visible = True
            TTelefonoCliente.Text = ""
        Else
            LabelTelCli.Visible = False
        End If
    End Sub

    Private Sub TNombreCliente_LostFocus(sender As Object, e As EventArgs) Handles TNombreCliente.LostFocus
        If TNombreCliente.Text = Nothing Then
            TNombreCliente.Text = "Ingrese Nombre"
            TNombreCliente.ForeColor = Color.DarkSlateGray
            Exit Sub
        End If

        If TNombreCliente.Text <> "" Then
            Dim texto As String()
            Dim nombreCompleto As String = ""
            texto = TNombreCliente.Text.Split(" ")
            For Each part In texto
                part = part(0).ToString.ToUpper & Mid(part, 2).ToLower
                nombreCompleto = nombreCompleto & part & " "
            Next
            TNombreCliente.Text = Trim(nombreCompleto)
        End If
    End Sub

    Private Sub TApellidoCliente_LostFocus(sender As Object, e As EventArgs) Handles TApellidoCliente.LostFocus
        If TApellidoCliente.Text = Nothing Then
            TApellidoCliente.Text = "Ingrese Apellido"
            TApellidoCliente.ForeColor = Color.DarkSlateGray
            Exit Sub
        End If


        If TApellidoCliente.Text <> "" Then
            Dim texto As String()
            Dim nombreCompleto As String = ""
            texto = TApellidoCliente.Text.Split(" ")
            For Each part In texto
                part = part(0).ToString.ToUpper & Mid(part, 2).ToLower
                nombreCompleto = nombreCompleto & part & " "
            Next
            TApellidoCliente.Text = Trim(nombreCompleto)
        End If
    End Sub

    Private Sub BtnCancelarCliente_Click(sender As Object, e As EventArgs) Handles BtnCancelarCliente.Click
        Me.Close()
        PanelAdmin.Show()
    End Sub

    Private Sub TDniCliente_TextChanged(sender As Object, e As EventArgs) Handles TDniCliente.TextChanged

    End Sub

    Private Sub TDniCliente_GotFocus(sender As Object, e As EventArgs) Handles TDniCliente.GotFocus
        If TDniCliente.Text = "Ingrese D.N.I." Then
            TDniCliente.ForeColor = Color.Black
            TDniCliente.Text = ""
        End If
    End Sub

    Private Sub TNombreCliente_TextChanged(sender As Object, e As EventArgs) Handles TNombreCliente.TextChanged

    End Sub

    Private Sub TNombreCliente_GotFocus(sender As Object, e As EventArgs) Handles TNombreCliente.GotFocus
        If TNombreCliente.Text = "Ingrese Nombre" Then
            TNombreCliente.ForeColor = Color.Black
            TNombreCliente.Text = ""
        End If
    End Sub

    Private Sub TApellidoCliente_TextChanged(sender As Object, e As EventArgs) Handles TApellidoCliente.TextChanged

    End Sub

    Private Sub TApellidoCliente_GotFocus(sender As Object, e As EventArgs) Handles TApellidoCliente.GotFocus
        If TApellidoCliente.Text = "Ingrese Apellido" Then
            TApellidoCliente.ForeColor = Color.Black
            TApellidoCliente.Text = ""
        End If
    End Sub

    Private Sub TEmailCliente_TextChanged(sender As Object, e As EventArgs) Handles TEmailCliente.TextChanged

    End Sub

    Private Sub TEmailCliente_GotFocus(sender As Object, e As EventArgs) Handles TEmailCliente.GotFocus
        If TEmailCliente.Text = "Ingrese E-mail" Then
            TEmailCliente.ForeColor = Color.Black
            TEmailCliente.Text = ""
        End If
    End Sub

    Private Sub TDireccionCliente_TextChanged(sender As Object, e As EventArgs) Handles TDireccionCliente.TextChanged

    End Sub

    Private Sub TDireccionCliente_GotFocus(sender As Object, e As EventArgs) Handles TDireccionCliente.GotFocus
        If TDireccionCliente.Text = "Ingrese Dirección" Then
            TDireccionCliente.ForeColor = Color.Black
            TDireccionCliente.Text = ""
        End If
    End Sub

    Private Sub TTelefonoCliente_TextChanged(sender As Object, e As EventArgs) Handles TTelefonoCliente.TextChanged

    End Sub

    Private Sub TTelefonoCliente_GotFocus(sender As Object, e As EventArgs) Handles TTelefonoCliente.GotFocus
        If TTelefonoCliente.Text = "Ingrese Teléfono" Then
            TTelefonoCliente.ForeColor = Color.Black
            TTelefonoCliente.Text = ""
        End If
    End Sub
End Class