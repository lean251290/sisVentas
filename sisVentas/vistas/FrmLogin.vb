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
        Dim mail As String
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        If TxtUser.Text = "" Or TxtPass.Text = "" Then
            MsgBox("Error usuario y/o contraseña deben tener caracteres", vbOKOnly, "Error")
        ElseIf Regex.IsMatch(TxtUser.Text, mail) Then
            Me.Hide()
                PanelAdmin.Show()
            Else
                'MsgBox("Error, el mail ingresado no es correcto!", vbOKOnly, "Error!!! ")
                FrmErrorLogin.Show()
            End If

    End Sub



    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TxtUser.LostFocus
        Dim mail As String
        mail = "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$"
        'If TextBox1
        If Regex.IsMatch(TxtUser.Text, mail) Then
            Me.Hide()
            PanelAdmin.Show()
        Else
            'MsgBox("Error, el mail ingresado no es correcto!", vbOKOnly, "Error!!! ")
            FrmErrorLogin.Show()
        End If
    End Sub
    <DllImport("Gdi32.dll", EntryPoint:="CreateRoundRectRgn")>
    Private Shared Function CreateRoundRectRgn(LR As Integer, TR As Integer, RR As Integer, BR As Integer, WE As Integer, He As Integer) As IntPtr

    End Function
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width - 2, Height - 2, 35, 35))
    End Sub


#End Region
End Class
