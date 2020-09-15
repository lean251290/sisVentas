Imports System.Runtime.InteropServices
Public Class PanelAdmin
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()

    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(hWnd As IntPtr, wMsg As Integer, wParam As Integer, lParam As Integer)

    End Sub
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Me.Close()
    End Sub

    Private Sub BtnMaximizar_Click(sender As Object, e As EventArgs) Handles BtnMaximizar.Click
        Me.BtnMaximizar.Visible = False
        BtnRestaurar.Visible = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub BtnRestaurar_Click(sender As Object, e As EventArgs) Handles BtnRestaurar.Click
        BtnMaximizar.Visible = True
        BtnRestaurar.Visible = False
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub BtnMin_Click(sender As Object, e As EventArgs) Handles BtnMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelAdm_Paint(sender As Object, e As PaintEventArgs) Handles PanelAdm.Paint

    End Sub

    Private Sub PanelAdm_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelAdm.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub TMOcultarMenu_Tick(sender As Object, e As EventArgs) Handles TMOcultarMenu.Tick
        If PanelMenu.Width <= 60 Then
            Me.TMOcultarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub TMMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TMMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            Me.TMMostrarMenu.Enabled = False
        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If PanelMenu.Width = 220 Then
            TMOcultarMenu.Enabled = True
        ElseIf PanelMenu.Width = 60 Then
            TMMostrarMenu.Enabled = True
        End If
    End Sub


    Private Sub abrirFormHijo(ByVal formHijo As Object)
        If Me.PanelContenedor.Controls.Count > 0 Then
            Me.PanelContenedor.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(formHijo, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.BorderStyle.None
        fh.Dock = DockStyle.Fill
        Me.PanelContenedor.Controls.Add(fh)
        Me.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        abrirFormHijo(New Agregar_Usuario)
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        abrirFormHijo(New Clientes)
    End Sub
    Private Sub BtnPagos_Click(sender As Object, e As EventArgs) Handles BtnPagos.Click
        abrirFormHijo(New Pagos)
    End Sub

    Private Sub BtnUsuarios_Click(sender As Object, e As EventArgs) Handles BtnUsuarios.Click
        abrirFormHijo(New Usuarios)
    End Sub
End Class