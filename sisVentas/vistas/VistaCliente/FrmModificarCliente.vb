Imports System.Text.RegularExpressions
Public Class FrmModificarCliente
    Private Sub BtnActualizarCliente_Click(sender As Object, e As EventArgs) Handles BtnActualizarCliente.Click
        Dim cliente As New Cliente(TNombreClienteModif.Text, TApellidoClienteModif.Text, TDniClienteModif.Text, TEmailClienteModif.Text,
         TDireccionClienteModif.Text, TTelefonoClienteModif.Text)

        If cliente.ActualizarCliente(Me.Tag) Then
            FrmDatosActualizados.Show()
            PanelAdmin.Enabled = True
            Me.Close()
            PanelAdmin.Show()
            PanelAdmin.cerrarFormHijo(VerUsuarios)
            PanelAdmin.abrirFormHijo(VerUsuarios)
            'VerUsuarios.cargarGridUser()
        Else
            FrmUpsError.Show()
        End If

    End Sub

    Private Sub FrmModificarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim mail As String
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"

        If Not Regex.IsMatch(TEmailClienteModif.Text, mail) Then
            FrmErrorMail.Show()
            TEmailClienteModif.Text = ""
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

    Private Sub TDniClienteModif_TextChanged(sender As Object, e As EventArgs) Handles TDniClienteModif.TextChanged

    End Sub
End Class