Imports System.Runtime.InteropServices
Imports System.Text.RegularExpressions
Public Class Login

#Region "Form Behaviors"
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Application.Exit()
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
#End Region

#Region "Drag Form"
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub BtnSesion_Click(sender As Object, e As EventArgs) Handles BtnSesion.Click
        Dim usuario As New Usuarios
        Dim id As Integer
        Dim mail As String
        Dim admin As String
        Dim vendedor As String
        Dim gerente As String
        vendedor = "Vendedor"
        gerente = "Gerente"
        admin = "Administrador"
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If TxtUser.Text = "" And TxtPass.Text = "" Then
            FrmErrorLogin.Show()
        ElseIf Not (Regex.IsMatch(TxtUser.Text, mail)) Then
            FrmErrorMail.Show()
        ElseIf usuario.Login(TxtUser.Text, TxtPass.Text, admin) Then
            Me.Hide()
            PanelAdmin.BotonClientes.Hide()
            PanelAdmin.BotonVentas.Hide()
            id = usuario.Login(TxtUser.Text, TxtPass.Text, admin)
            PanelAdmin.Tag = id
            PanelAdmin.Show()
        ElseIf usuario.Login(TxtUser.Text, TxtPass.Text, vendedor) Then
            Me.Hide()
            PanelAdmin.BotonUsuarios.Hide()
            PanelAdmin.BotonProductos.Hide()
            PanelAdmin.BotonReportes.Hide()
            id = usuario.Login(TxtUser.Text, TxtPass.Text, vendedor)
            PanelAdmin.Tag = id
            PanelAdmin.Show()
        ElseIf usuario.Login(TxtUser.Text, TxtPass.Text, gerente) Then
            Me.Hide()
            PanelAdmin.BotonUsuarios.Hide()
            PanelAdmin.BotonProductos.Hide()
            PanelAdmin.BotonVentas.Hide()
            PanelAdmin.BotonClientes.Hide()
            id = usuario.Login(TxtUser.Text, TxtPass.Text, gerente)
            PanelAdmin.Tag = id
            PanelAdmin.Show()
        Else
            FrmUsuarioInexistente.Show()
        End If

    End Sub



    'Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TxtUser.LostFocus
    ' Dim mail As String
    'mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
    'If TextBox1
    'If Regex.IsMatch(TxtUser.Text, mail) Then
    'Me.Hide()
    ' PanelAdmin.Show()
    'Else
    'MsgBox("Error, el mail ingresado no es correcto!", vbOKOnly, "Error!!! ")
    ' FrmErrorLogin.Show()
    'End If
    'End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, He As Integer) As IntPtr

    End Function
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 35, 35))
        EntradaLogin()
    End Sub

    Private Sub BtnSesion_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnSesion.MouseDown
        BtnSesion.BackgroundImage = My.Resources.btn201x45iniciar064
    End Sub

    Private Sub BtnSesion_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnSesion.MouseUp
        BtnSesion.BackgroundImage = My.Resources.btn201x45iniciar
    End Sub

    Private Sub TxtUser_TextChanged(sender As Object, e As EventArgs) Handles TxtUser.TextChanged

    End Sub


#End Region
End Class
