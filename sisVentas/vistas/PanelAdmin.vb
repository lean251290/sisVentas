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
            esconderSubMenu()
            Me.TMOcultarMenu.Enabled = False

        Else
            Me.PanelMenu.Width = PanelMenu.Width - 20
        End If
    End Sub

    Private Sub TMMostrarMenu_Tick(sender As Object, e As EventArgs) Handles TMMostrarMenu.Tick
        If PanelMenu.Width >= 220 Then
            esconderSubMenu()
            Me.TMMostrarMenu.Enabled = False

        Else
            Me.PanelMenu.Width = PanelMenu.Width + 20
        End If
    End Sub

    Private Sub BtnMenu_Click(sender As Object, e As EventArgs) Handles BtnMenu.Click
        If PanelMenu.Width = 220 Then

            TMOcultarMenu.Enabled = True
            BotonUsuarios.Enabled = False
            BotonUsuarios.Text = ""
            BotonVerUsuarios.Enabled = False
            Button8.Enabled = False
            BotonProductos.Enabled = False
            BotonProductos.Text = ""
            BotonVerProd.Enabled = False
            BotonNuevoProd.Enabled = False
            BotonReportes.Enabled = False
            BotonReportes.Text = ""
            Button2.Enabled = False
            BotonVentas.Enabled = False
            BotonVentas.Text = ""
            BotonVerVentas.Enabled = False
            Button3.Enabled = False
            BotonClientes.Enabled = False
            BotonClientes.Text = ""
            Button1.Enabled = False
            Button4.Enabled = False
            BtnSalir.Text = ""
            esconderSubMenu()
        ElseIf PanelMenu.Width = 60 Then

            TMMostrarMenu.Enabled = True
            BotonUsuarios.Enabled = True
            BotonUsuarios.Text = "    USUARIOS"
            BotonVerUsuarios.Enabled = True
            Button8.Enabled = True
            BotonProductos.Enabled = True
            BotonProductos.Text = "     PRODUCTOS"
            BotonVerProd.Enabled = True
            BotonNuevoProd.Enabled = True
            BotonReportes.Enabled = True
            BotonReportes.Text = "     REPORTES"
            Button2.Enabled = True
            BotonVentas.Enabled = True
            BotonVentas.Text = "         VENTAS"
            BotonVerVentas.Enabled = True
            Button3.Enabled = True
            BotonClientes.Enabled = True
            BotonClientes.Text = "       CLIENTES"
            Button1.Enabled = True
            Button4.Enabled = True
            BtnSalir.Text = "     SALIR"
            'esconderSubMenu()
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
        BtnVentas1.Hide()
        BtnVentas2.Hide()
        BtnVentas3.Hide()
        BtnVentas4.Hide()
        BtnVentas5.Hide()
    End Sub

    Private Sub BotonUsuarios_Click(sender As Object, e As EventArgs) Handles BotonUsuarios.Click
        mostrarSubMenu(PanelUsuarios)
    End Sub

    Private Sub BotonProductos_Click(sender As Object, e As EventArgs) Handles BotonProductos.Click
        mostrarSubMenu(PanelProductos)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
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
        abrirFormHijo(New VerProductos)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BotonNuevoProd.Click
        esconderSubMenu()
        abrirFormHijo(New AgregarProducto)
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
        BotonUsuarios.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles BotonUsuarios.MouseLeave
        BotonUsuarios.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click
        abrirFormHijo(New Agregar_Usuario)
        esconderSubMenu()
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        abrirFormHijo(New AgregarCliente)
        esconderSubMenu()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        abrirFormHijo(New VerClientes)
        esconderSubMenu()
    End Sub



    Private Sub BotonProductos_MouseEnter(sender As Object, e As EventArgs) Handles BotonProductos.MouseEnter
        BotonProductos.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonProductos_MouseLeave(sender As Object, e As EventArgs) Handles BotonProductos.MouseLeave
        BotonProductos.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonVentas_MouseLeave(sender As Object, e As EventArgs) Handles BotonVentas.MouseLeave
        BotonVentas.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonVentas_MouseEnter(sender As Object, e As EventArgs) Handles BotonVentas.MouseEnter
        BotonVentas.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonReportes_MouseEnter(sender As Object, e As EventArgs) Handles BotonReportes.MouseEnter
        BotonReportes.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonReportes_MouseLeave(sender As Object, e As EventArgs) Handles BotonReportes.MouseLeave
        BotonReportes.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonClientes_MouseEnter(sender As Object, e As EventArgs) Handles BotonClientes.MouseEnter
        BotonClientes.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonClientes_MouseLeave(sender As Object, e As EventArgs) Handles BotonClientes.MouseLeave
        BotonClientes.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click

    End Sub

    Private Sub BtnSalir_MouseEnter(sender As Object, e As EventArgs) Handles BtnSalir.MouseEnter
        BtnSalir.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BtnSalir_MouseLeave(sender As Object, e As EventArgs) Handles BtnSalir.MouseLeave
        BtnSalir.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button8_MouseEnter(sender As Object, e As EventArgs) Handles Button8.MouseEnter
        Button8.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub Button8_MouseLeave(sender As Object, e As EventArgs) Handles Button8.MouseLeave
        Button8.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button4_MouseEnter(sender As Object, e As EventArgs) Handles Button4.MouseEnter
        Button4.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonVerUsuarios_MouseEnter(sender As Object, e As EventArgs) Handles BotonVerUsuarios.MouseEnter
        BotonVerUsuarios.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonVerUsuarios_MouseLeave(sender As Object, e As EventArgs) Handles BotonVerUsuarios.MouseLeave
        BotonVerUsuarios.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonVerProd_MouseEnter(sender As Object, e As EventArgs) Handles BotonVerProd.MouseEnter
        BotonVerProd.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonVerProd_MouseLeave(sender As Object, e As EventArgs) Handles BotonVerProd.MouseLeave
        BotonVerProd.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonNuevoProd_MouseEnter(sender As Object, e As EventArgs) Handles BotonNuevoProd.MouseEnter
        BotonNuevoProd.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonNuevoProd_MouseLeave(sender As Object, e As EventArgs) Handles BotonNuevoProd.MouseLeave
        BotonNuevoProd.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub BotonVerVentas_Click(sender As Object, e As EventArgs) Handles BotonVerVentas.Click
        esconderSubMenu()
        abrirFormHijo(New VerVentas)
    End Sub

    Private Sub BotonVerVentas_MouseEnter(sender As Object, e As EventArgs) Handles BotonVerVentas.MouseEnter
        BotonVerVentas.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub BotonVerVentas_MouseLeave(sender As Object, e As EventArgs) Handles BotonVerVentas.MouseLeave
        BotonVerVentas.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If PnllReportes.Width = 5 Then
            PnllReportes.Width = 200
            PnllReportes.BackColor = Color.FromArgb(0, 40, 40)
            BtnVentas1.Show()
            BtnVentas2.Show()
            BtnVentas3.Show()
            BtnVentas4.Show()
            BtnVentas5.Show()
        Else
            PnllReportes.Width = 5
            PnllReportes.BackColor = Color.FromArgb(0, 64, 64)
            BtnVentas1.Hide()
            BtnVentas2.Hide()
            BtnVentas3.Hide()
            BtnVentas4.Hide()
            BtnVentas5.Hide()
        End If

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Button2.ForeColor = Color.FromArgb(17, 255, 141)
    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        esconderSubMenu()
        abrirFormHijo(New NuevaVenta)
    End Sub
End Class