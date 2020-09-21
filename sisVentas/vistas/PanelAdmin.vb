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
        'TNombreUsuario.AutoSize = False
        'TNombreUsuario.Size = New Size(250, 250)
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

    'en este metodo escondemos los paneles que contienen los botones de los submenus
    Private Sub esconderSubMenu()
        PanelProductos.Visible = False
        PanelUsuarios.Visible = False
        PanelVentas.Visible = False
        PanelClientes.Visible = False
        PanelReportes.Visible = False

    End Sub

    'en este metodo mostramos los paneles escondidos
    Private Sub mostrarSubMenu(submenu As Panel)
        If submenu.Visible = False Then
            esconderSubMenu()
            submenu.Visible = True
        Else
            submenu.Visible = False
        End If
    End Sub
    Private Sub PanelAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        esconderSubMenu()
    End Sub

    Private Sub BotonUsuarios_Click(sender As Object, e As EventArgs) Handles BotonUsuarios.Click
        mostrarSubMenu(PanelUsuarios)
    End Sub

    Private Sub BotonProductos_Click(sender As Object, e As EventArgs) Handles BotonProductos.Click
        mostrarSubMenu(PanelProductos)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BotonModificarProd.Click
        esconderSubMenu()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BotonVerUsuarios.Click
        abrirFormHijo(New VerUsuarios)
        esconderSubMenu()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        esconderSubMenu()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BotonVerProd.Click
        esconderSubMenu()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BotonNuevoProd.Click
        esconderSubMenu()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) 
        abrirFormHijo(New Agregar_Usuario)
        esconderSubMenu()
    End Sub

    Private formActual As Form = Nothing
    Private Sub abrirFormHijo(formHijo As Form)
        If formActual IsNot Nothing Then formActual.Close()
        formActual = formHijo
        formHijo.TopLevel = False
        formHijo.FormBorderStyle = FormBorderStyle.None
        formHijo.Dock = DockStyle.Fill
        PanelContenedorFormHijo.Controls.Add(formHijo)
        formHijo.BringToFront()
        formHijo.Show()
    End Sub

    Private Sub BotonVentas_Click(sender As Object, e As EventArgs) Handles BotonVentas.Click
        mostrarSubMenu(PanelVentas)
    End Sub

    Private Sub BotonReportes_Click(sender As Object, e As EventArgs) Handles BotonReportes.Click
        mostrarSubMenu(PanelReportes)
    End Sub

    Private Sub BotonClientes_Click(sender As Object, e As EventArgs) Handles BotonClientes.Click
        mostrarSubMenu(PanelClientes)
    End Sub

    Private Sub BotonUsuarios_MouseEnter(sender As Object, e As EventArgs) Handles BotonUsuarios.MouseEnter
        BotonUsuarios.ForeColor = Color.FromArgb(252, 54, 10)
    End Sub

    Private Sub BotonUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles BotonUsuarios.MouseLeave
        BotonUsuarios.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub
End Class