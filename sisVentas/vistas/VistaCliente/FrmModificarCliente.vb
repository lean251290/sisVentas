Imports System.Text.RegularExpressions
Public Class FrmModificarCliente
    Private Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click

        If TEmailClienteModif.Text = "" Or TDireccionClienteModif.Text = "" Or TTelefonoClienteModif.Text = "" Then
            FrmRellenarCampos.Show()
            Exit Sub
        End If


        Dim cliente As New Cliente(TDniClienteModif.Text, TNombreClienteModif.Text, TApellidoClienteModif.Text, TEmailClienteModif.Text,
         TDireccionClienteModif.Text, TTelefonoClienteModif.Text)

        If cliente.ActualizarCliente(Me.Tag) Then
            FrmDatosActualizados.Show()
            PanelAdmin.Enabled = True
            Me.Close()
            PanelAdmin.Show()
            PanelAdmin.cerrarFormHijo(VerClientes)
            PanelAdmin.abrirFormHijo(VerClientes)
            'VerUsuarios.cargarGridUser()
        Else
            FrmUpsError.Show()
        End If

    End Sub

    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelEmailClienteModif.Visible = False
        LabelDireccionCliModif.Visible = False
        LabelEmailInvalido.Visible = False
        Dim cli As New Cliente()
        cli.TraerPorIdCliente(Me.Tag)
        TDniClienteModif.Text = cli.getDni
        TNombreClienteModif.Text = cli.getNombre
        TApellidoClienteModif.Text = cli.getApellido
        TDireccionClienteModif.Text = cli.getDireccion
        TEmailClienteModif.Text = cli.getCorreo
        TTelefonoClienteModif.Text = cli.getTelefono

    End Sub

    Private Sub BtnActualizarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnActualizarCliente.MouseDown
        BtnActualizarCliente.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnActualizarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnActualizarCliente.MouseUp
        BtnActualizarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarCliente_Click(sender As Object, e As EventArgs) Handles BtnCancelarCliente.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub

    Private Sub BtnCancelarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseDown
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseUp
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PanelAdmin.Enabled = True
        Me.Close()
        PanelAdmin.Show()
    End Sub


    '' Private Sub TNombreClienteModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreClienteModif.KeyPress
    '' If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
    ''   e.Handled = True
    ''    FrmSoloLetras.Show()
    ''  End If
    '' End Sub


    '' Private Sub TApellidoClienteModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TApellidoClienteModif.KeyPress
    ''If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
    ''  e.Handled = True
    '' FrmSoloLetras.Show()
    ''End If
    '' End Sub


    ''Private Sub TDniClienteModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TDniClienteModif.KeyPress
    ''If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
    ''  e.Handled = True
    ''  FrmSoloNumeros.Show()
    ''End If
    '' End Sub



    Private Sub TEmailClienteModif_LostFocus(sender As Object, e As EventArgs) Handles TEmailClienteModif.LostFocus
        Dim cli As New Cliente
        Dim mail As String
        Dim mailbd As String
        cli.TraerPorIdCliente(Me.Tag)
        mailbd = cli.getCorreo

        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If Not Regex.IsMatch(TEmailClienteModif.Text, mail) Then
            LabelEmailInvalido.Visible = True
            TEmailClienteModif.Text = ""
        ElseIf cli.VerificarEmail(TEmailClienteModif.Text) Then
            LabelEmailClienteModif.Visible = True
            TEmailClienteModif.Text = ""
            LabelEmailInvalido.Visible = False
        Else
            LabelEmailClienteModif.Visible = False

        End If


    End Sub

    Private Sub TDniClienteModif_LostFocus(sender As Object, e As EventArgs) Handles TDniClienteModif.LostFocus
        'Dim cantidad As Integer
        'cantidad = Len(TDniClienteModif.Text)
        'If cantidad < 8 Then
        'FrmValidarDni.Show()
        'TDniClienteModif.Text = ""
        ' ElseIf cantidad > 8 Then
        'FrmValidarDni.Show()
        'DniClienteModif.Text = ""
        'End If
    End Sub


    Private Sub TDireccionClienteModif_LostFocus(sender As Object, e As EventArgs) Handles TDireccionClienteModif.LostFocus
        Dim direccion As String
        direccion = "^[A-z\s]+(\d{1,5})"
        If Not Regex.IsMatch(TDireccionClienteModif.Text, direccion) Then
            LabelDireccionCliModif.Visible = True
            TDireccionClienteModif.Text = ""
        Else
            LabelDireccionCliModif.Visible = False
        End If
    End Sub

    Private Sub TTelefonoClienteModif_TextChanged(sender As Object, e As EventArgs) Handles TTelefonoClienteModif.TextChanged

    End Sub

    Private Sub TTelefonoClienteModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TTelefonoClienteModif.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then

            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub TDireccionClienteModif_TextChanged(sender As Object, e As EventArgs) Handles TDireccionClienteModif.TextChanged

    End Sub

    Private Sub TEmailClienteModif_TextChanged(sender As Object, e As EventArgs) Handles TEmailClienteModif.TextChanged

    End Sub
End Class