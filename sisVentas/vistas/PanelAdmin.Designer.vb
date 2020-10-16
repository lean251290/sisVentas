<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PanelAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAdmin))
        Me.PanelAdm = New System.Windows.Forms.Panel()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelClientes = New System.Windows.Forms.Panel()
        Me.PanelReportes = New System.Windows.Forms.Panel()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.PanelUsuarios = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TMOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TMMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedorFormHijo = New System.Windows.Forms.Panel()
        Me.PnllReportes = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnVentasPorProducto = New System.Windows.Forms.Button()
        Me.BtnVentasPorCliente = New System.Windows.Forms.Button()
        Me.BtnVentasPorUser = New System.Windows.Forms.Button()
        Me.BtnVentasPorFecha = New System.Windows.Forms.Button()
        Me.BtnVentasPorDia = New System.Windows.Forms.Button()
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonClientes = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BotonReportes = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BotonVerVentas = New System.Windows.Forms.Button()
        Me.BotonVentas = New System.Windows.Forms.Button()
        Me.BtnAgregarCategoria = New System.Windows.Forms.Button()
        Me.BotonNuevoProd = New System.Windows.Forms.Button()
        Me.BotonVerProd = New System.Windows.Forms.Button()
        Me.BotonProductos = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.BotonVerUsuarios = New System.Windows.Forms.Button()
        Me.BotonUsuarios = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelAdm.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelClientes.SuspendLayout()
        Me.PanelReportes.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.PanelProductos.SuspendLayout()
        Me.PanelUsuarios.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.PanelContenedorFormHijo.SuspendLayout()
        Me.PnllReportes.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAdm
        '
        Me.PanelAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelAdm.Controls.Add(Me.PictureBox2)
        Me.PanelAdm.Controls.Add(Me.PictureBox3)
        Me.PanelAdm.Controls.Add(Me.BtnRestaurar)
        Me.PanelAdm.Controls.Add(Me.BtnMin)
        Me.PanelAdm.Controls.Add(Me.BtnMaximizar)
        Me.PanelAdm.Controls.Add(Me.BtnCerrar)
        Me.PanelAdm.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelAdm.Location = New System.Drawing.Point(0, 0)
        Me.PanelAdm.Name = "PanelAdm"
        Me.PanelAdm.Size = New System.Drawing.Size(900, 40)
        Me.PanelAdm.TabIndex = 0
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.BtnSalir)
        Me.PanelMenu.Controls.Add(Me.PanelClientes)
        Me.PanelMenu.Controls.Add(Me.BotonClientes)
        Me.PanelMenu.Controls.Add(Me.PanelReportes)
        Me.PanelMenu.Controls.Add(Me.BotonReportes)
        Me.PanelMenu.Controls.Add(Me.PanelVentas)
        Me.PanelMenu.Controls.Add(Me.BotonVentas)
        Me.PanelMenu.Controls.Add(Me.PanelProductos)
        Me.PanelMenu.Controls.Add(Me.BotonProductos)
        Me.PanelMenu.Controls.Add(Me.PanelUsuarios)
        Me.PanelMenu.Controls.Add(Me.BotonUsuarios)
        Me.PanelMenu.Controls.Add(Me.Panel11)
        Me.PanelMenu.Controls.Add(Me.Panel10)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 680)
        Me.PanelMenu.TabIndex = 1
        '
        'PanelClientes
        '
        Me.PanelClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelClientes.Controls.Add(Me.Button4)
        Me.PanelClientes.Controls.Add(Me.Button1)
        Me.PanelClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelClientes.Location = New System.Drawing.Point(0, 608)
        Me.PanelClientes.Name = "PanelClientes"
        Me.PanelClientes.Size = New System.Drawing.Size(203, 80)
        Me.PanelClientes.TabIndex = 27
        '
        'PanelReportes
        '
        Me.PanelReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelReportes.Controls.Add(Me.Button2)
        Me.PanelReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelReportes.Location = New System.Drawing.Point(0, 528)
        Me.PanelReportes.Name = "PanelReportes"
        Me.PanelReportes.Size = New System.Drawing.Size(203, 40)
        Me.PanelReportes.TabIndex = 25
        '
        'PanelVentas
        '
        Me.PanelVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelVentas.Controls.Add(Me.Button3)
        Me.PanelVentas.Controls.Add(Me.BotonVerVentas)
        Me.PanelVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVentas.Location = New System.Drawing.Point(0, 408)
        Me.PanelVentas.Name = "PanelVentas"
        Me.PanelVentas.Size = New System.Drawing.Size(203, 80)
        Me.PanelVentas.TabIndex = 23
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelProductos.Controls.Add(Me.BtnAgregarCategoria)
        Me.PanelProductos.Controls.Add(Me.BotonNuevoProd)
        Me.PanelProductos.Controls.Add(Me.BotonVerProd)
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProductos.Location = New System.Drawing.Point(0, 248)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(203, 120)
        Me.PanelProductos.TabIndex = 21
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelUsuarios.Controls.Add(Me.Button8)
        Me.PanelUsuarios.Controls.Add(Me.BotonVerUsuarios)
        Me.PanelUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsuarios.Location = New System.Drawing.Point(0, 128)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Size = New System.Drawing.Size(203, 80)
        Me.PanelUsuarios.TabIndex = 19
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 34)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(203, 54)
        Me.Panel11.TabIndex = 17
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel10.Controls.Add(Me.BtnMenu)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(203, 34)
        Me.Panel10.TabIndex = 17
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(14, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 50)
        Me.Panel1.TabIndex = 0
        '
        'TMOcultarMenu
        '
        '
        'TMMostrarMenu
        '
        '
        'PanelContenedorFormHijo
        '
        Me.PanelContenedorFormHijo.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PanelContenedorFormHijo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelContenedorFormHijo.Controls.Add(Me.PictureBox4)
        Me.PanelContenedorFormHijo.Controls.Add(Me.PnllReportes)
        Me.PanelContenedorFormHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorFormHijo.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedorFormHijo.Name = "PanelContenedorFormHijo"
        Me.PanelContenedorFormHijo.Size = New System.Drawing.Size(680, 680)
        Me.PanelContenedorFormHijo.TabIndex = 2
        '
        'PnllReportes
        '
        Me.PnllReportes.Controls.Add(Me.Panel7)
        Me.PnllReportes.Controls.Add(Me.Panel6)
        Me.PnllReportes.Controls.Add(Me.Panel5)
        Me.PnllReportes.Controls.Add(Me.Panel4)
        Me.PnllReportes.Controls.Add(Me.Panel3)
        Me.PnllReportes.Controls.Add(Me.Panel2)
        Me.PnllReportes.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnllReportes.Location = New System.Drawing.Point(675, 0)
        Me.PnllReportes.Name = "PnllReportes"
        Me.PnllReportes.Size = New System.Drawing.Size(5, 680)
        Me.PnllReportes.TabIndex = 0
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.BtnVentasPorProducto)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 500)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 100)
        Me.Panel7.TabIndex = 31
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnVentasPorCliente)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 400)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 100)
        Me.Panel6.TabIndex = 30
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtnVentasPorUser)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 300)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 100)
        Me.Panel5.TabIndex = 29
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.BtnVentasPorFecha)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 200)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 100)
        Me.Panel4.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnVentasPorDia)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 100)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 100)
        Me.Panel3.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 100)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox4.Image = Global.sisVentas.My.Resources.Resources.fondoPanel
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(675, 680)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 1
        Me.PictureBox4.TabStop = False
        '
        'BtnVentasPorProducto
        '
        Me.BtnVentasPorProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentasPorProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentasPorProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentasPorProducto.FlatAppearance.BorderSize = 0
        Me.BtnVentasPorProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasPorProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasPorProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVentasPorProducto.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnVentasPorProducto.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVentasPorProducto.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentasPorProducto.Name = "BtnVentasPorProducto"
        Me.BtnVentasPorProducto.Size = New System.Drawing.Size(5, 40)
        Me.BtnVentasPorProducto.TabIndex = 26
        Me.BtnVentasPorProducto.Text = "  VENTA POR CLIENTES"
        Me.BtnVentasPorProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentasPorProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentasPorProducto.UseVisualStyleBackColor = False
        '
        'BtnVentasPorCliente
        '
        Me.BtnVentasPorCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentasPorCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentasPorCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentasPorCliente.FlatAppearance.BorderSize = 0
        Me.BtnVentasPorCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasPorCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasPorCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVentasPorCliente.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnVentasPorCliente.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVentasPorCliente.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentasPorCliente.Name = "BtnVentasPorCliente"
        Me.BtnVentasPorCliente.Size = New System.Drawing.Size(5, 40)
        Me.BtnVentasPorCliente.TabIndex = 26
        Me.BtnVentasPorCliente.Text = "             BACK-UP"
        Me.BtnVentasPorCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentasPorCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentasPorCliente.UseVisualStyleBackColor = False
        '
        'BtnVentasPorUser
        '
        Me.BtnVentasPorUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentasPorUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentasPorUser.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentasPorUser.FlatAppearance.BorderSize = 0
        Me.BtnVentasPorUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasPorUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasPorUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVentasPorUser.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnVentasPorUser.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVentasPorUser.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentasPorUser.Name = "BtnVentasPorUser"
        Me.BtnVentasPorUser.Size = New System.Drawing.Size(5, 40)
        Me.BtnVentasPorUser.TabIndex = 26
        Me.BtnVentasPorUser.Text = "   VENTA POR USUARIO"
        Me.BtnVentasPorUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentasPorUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentasPorUser.UseVisualStyleBackColor = False
        '
        'BtnVentasPorFecha
        '
        Me.BtnVentasPorFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentasPorFecha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentasPorFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentasPorFecha.FlatAppearance.BorderSize = 0
        Me.BtnVentasPorFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasPorFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasPorFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVentasPorFecha.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnVentasPorFecha.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVentasPorFecha.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentasPorFecha.Name = "BtnVentasPorFecha"
        Me.BtnVentasPorFecha.Size = New System.Drawing.Size(5, 40)
        Me.BtnVentasPorFecha.TabIndex = 26
        Me.BtnVentasPorFecha.Text = "     VENTAS POR FECHA"
        Me.BtnVentasPorFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentasPorFecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentasPorFecha.UseVisualStyleBackColor = False
        '
        'BtnVentasPorDia
        '
        Me.BtnVentasPorDia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnVentasPorDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnVentasPorDia.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnVentasPorDia.FlatAppearance.BorderSize = 0
        Me.BtnVentasPorDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentasPorDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentasPorDia.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVentasPorDia.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnVentasPorDia.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnVentasPorDia.Location = New System.Drawing.Point(0, 0)
        Me.BtnVentasPorDia.Name = "BtnVentasPorDia"
        Me.BtnVentasPorDia.Size = New System.Drawing.Size(5, 40)
        Me.BtnVentasPorDia.TabIndex = 26
        Me.BtnVentasPorDia.Text = "       VENTAS DEL DIA"
        Me.BtnVentasPorDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnVentasPorDia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentasPorDia.UseVisualStyleBackColor = False
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnSalir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BtnSalir.FlatAppearance.BorderSize = 0
        Me.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSalir.Image = Global.sisVentas.My.Resources.Resources.Salir30px
        Me.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BtnSalir.Location = New System.Drawing.Point(0, 688)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(203, 40)
        Me.BtnSalir.TabIndex = 25
        Me.BtnSalir.Text = "     SALIR"
        Me.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(0, 40)
        Me.Button4.Name = "Button4"
        Me.Button4.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Button4.Size = New System.Drawing.Size(203, 40)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "NUEVO "
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(203, 40)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "VER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BotonClientes
        '
        Me.BotonClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonClientes.FlatAppearance.BorderSize = 0
        Me.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonClientes.ForeColor = System.Drawing.Color.White
        Me.BotonClientes.Image = CType(resources.GetObject("BotonClientes.Image"), System.Drawing.Image)
        Me.BotonClientes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonClientes.Location = New System.Drawing.Point(0, 568)
        Me.BotonClientes.Name = "BotonClientes"
        Me.BotonClientes.Size = New System.Drawing.Size(203, 40)
        Me.BotonClientes.TabIndex = 26
        Me.BotonClientes.Text = "       CLIENTES"
        Me.BotonClientes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonClientes.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(0, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Button2.Size = New System.Drawing.Size(203, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "VER"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BotonReportes
        '
        Me.BotonReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonReportes.FlatAppearance.BorderSize = 0
        Me.BotonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReportes.Image = CType(resources.GetObject("BotonReportes.Image"), System.Drawing.Image)
        Me.BotonReportes.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonReportes.Location = New System.Drawing.Point(0, 488)
        Me.BotonReportes.Name = "BotonReportes"
        Me.BotonReportes.Size = New System.Drawing.Size(203, 40)
        Me.BotonReportes.TabIndex = 24
        Me.BotonReportes.Text = "     REPORTES"
        Me.BotonReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonReportes.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(0, 40)
        Me.Button3.Name = "Button3"
        Me.Button3.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Button3.Size = New System.Drawing.Size(203, 40)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "NUEVA"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'BotonVerVentas
        '
        Me.BotonVerVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVerVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVerVentas.FlatAppearance.BorderSize = 0
        Me.BotonVerVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVerVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVerVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVerVentas.Image = CType(resources.GetObject("BotonVerVentas.Image"), System.Drawing.Image)
        Me.BotonVerVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVerVentas.Location = New System.Drawing.Point(0, 0)
        Me.BotonVerVentas.Name = "BotonVerVentas"
        Me.BotonVerVentas.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonVerVentas.Size = New System.Drawing.Size(203, 40)
        Me.BotonVerVentas.TabIndex = 2
        Me.BotonVerVentas.Text = "VER"
        Me.BotonVerVentas.UseVisualStyleBackColor = False
        '
        'BotonVentas
        '
        Me.BotonVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVentas.FlatAppearance.BorderSize = 0
        Me.BotonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVentas.Image = CType(resources.GetObject("BotonVentas.Image"), System.Drawing.Image)
        Me.BotonVentas.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonVentas.Location = New System.Drawing.Point(0, 368)
        Me.BotonVentas.Name = "BotonVentas"
        Me.BotonVentas.Size = New System.Drawing.Size(203, 40)
        Me.BotonVentas.TabIndex = 22
        Me.BotonVentas.Text = "         VENTAS"
        Me.BotonVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonVentas.UseVisualStyleBackColor = False
        '
        'BtnAgregarCategoria
        '
        Me.BtnAgregarCategoria.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAgregarCategoria.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BtnAgregarCategoria.Dock = System.Windows.Forms.DockStyle.Top
        Me.BtnAgregarCategoria.FlatAppearance.BorderSize = 0
        Me.BtnAgregarCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarCategoria.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAgregarCategoria.Image = Global.sisVentas.My.Resources.Resources.icoCategoria30x30
        Me.BtnAgregarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregarCategoria.Location = New System.Drawing.Point(0, 80)
        Me.BtnAgregarCategoria.Name = "BtnAgregarCategoria"
        Me.BtnAgregarCategoria.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BtnAgregarCategoria.Size = New System.Drawing.Size(203, 40)
        Me.BtnAgregarCategoria.TabIndex = 3
        Me.BtnAgregarCategoria.Text = "           AGREGAR CATEGORÍA"
        Me.BtnAgregarCategoria.UseVisualStyleBackColor = False
        '
        'BotonNuevoProd
        '
        Me.BotonNuevoProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonNuevoProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonNuevoProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonNuevoProd.FlatAppearance.BorderSize = 0
        Me.BotonNuevoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonNuevoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonNuevoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonNuevoProd.Image = CType(resources.GetObject("BotonNuevoProd.Image"), System.Drawing.Image)
        Me.BotonNuevoProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonNuevoProd.Location = New System.Drawing.Point(0, 40)
        Me.BotonNuevoProd.Name = "BotonNuevoProd"
        Me.BotonNuevoProd.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonNuevoProd.Size = New System.Drawing.Size(203, 40)
        Me.BotonNuevoProd.TabIndex = 2
        Me.BotonNuevoProd.Text = "NUEVO"
        Me.BotonNuevoProd.UseVisualStyleBackColor = False
        '
        'BotonVerProd
        '
        Me.BotonVerProd.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonVerProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVerProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVerProd.FlatAppearance.BorderSize = 0
        Me.BotonVerProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVerProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVerProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVerProd.Image = CType(resources.GetObject("BotonVerProd.Image"), System.Drawing.Image)
        Me.BotonVerProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVerProd.Location = New System.Drawing.Point(0, 0)
        Me.BotonVerProd.Name = "BotonVerProd"
        Me.BotonVerProd.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonVerProd.Size = New System.Drawing.Size(203, 40)
        Me.BotonVerProd.TabIndex = 1
        Me.BotonVerProd.Text = "VER"
        Me.BotonVerProd.UseVisualStyleBackColor = False
        '
        'BotonProductos
        '
        Me.BotonProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonProductos.FlatAppearance.BorderSize = 0
        Me.BotonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonProductos.Image = CType(resources.GetObject("BotonProductos.Image"), System.Drawing.Image)
        Me.BotonProductos.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonProductos.Location = New System.Drawing.Point(0, 208)
        Me.BotonProductos.Name = "BotonProductos"
        Me.BotonProductos.Size = New System.Drawing.Size(203, 40)
        Me.BotonProductos.TabIndex = 20
        Me.BotonProductos.Text = "     PRODUCTOS"
        Me.BotonProductos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonProductos.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(0, 40)
        Me.Button8.Name = "Button8"
        Me.Button8.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.Button8.Size = New System.Drawing.Size(203, 40)
        Me.Button8.TabIndex = 6
        Me.Button8.Text = "NUEVO"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'BotonVerUsuarios
        '
        Me.BotonVerUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonVerUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVerUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVerUsuarios.FlatAppearance.BorderSize = 0
        Me.BotonVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVerUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVerUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVerUsuarios.Image = CType(resources.GetObject("BotonVerUsuarios.Image"), System.Drawing.Image)
        Me.BotonVerUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVerUsuarios.Location = New System.Drawing.Point(0, 0)
        Me.BotonVerUsuarios.Name = "BotonVerUsuarios"
        Me.BotonVerUsuarios.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonVerUsuarios.Size = New System.Drawing.Size(203, 40)
        Me.BotonVerUsuarios.TabIndex = 2
        Me.BotonVerUsuarios.Text = "VER"
        Me.BotonVerUsuarios.UseVisualStyleBackColor = False
        '
        'BotonUsuarios
        '
        Me.BotonUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BotonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonUsuarios.FlatAppearance.BorderSize = 0
        Me.BotonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonUsuarios.Image = CType(resources.GetObject("BotonUsuarios.Image"), System.Drawing.Image)
        Me.BotonUsuarios.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.BotonUsuarios.Location = New System.Drawing.Point(0, 88)
        Me.BotonUsuarios.Margin = New System.Windows.Forms.Padding(0)
        Me.BotonUsuarios.Name = "BotonUsuarios"
        Me.BotonUsuarios.Size = New System.Drawing.Size(203, 40)
        Me.BotonUsuarios.TabIndex = 0
        Me.BotonUsuarios.Text = "    USUARIOS"
        Me.BotonUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BotonUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BotonUsuarios.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(-9, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnMenu
        '
        Me.BtnMenu.Dock = System.Windows.Forms.DockStyle.Right
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(165, 0)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(38, 34)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.sisventas_label
        Me.PictureBox2.Location = New System.Drawing.Point(50, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(50, 40)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'BtnRestaurar
        '
        Me.BtnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestaurar.FlatAppearance.BorderSize = 0
        Me.BtnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRestaurar.Image = CType(resources.GetObject("BtnRestaurar.Image"), System.Drawing.Image)
        Me.BtnRestaurar.Location = New System.Drawing.Point(814, 3)
        Me.BtnRestaurar.Name = "BtnRestaurar"
        Me.BtnRestaurar.Size = New System.Drawing.Size(40, 34)
        Me.BtnRestaurar.TabIndex = 3
        Me.BtnRestaurar.UseVisualStyleBackColor = True
        Me.BtnRestaurar.Visible = False
        '
        'BtnMin
        '
        Me.BtnMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMin.FlatAppearance.BorderSize = 0
        Me.BtnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), System.Drawing.Image)
        Me.BtnMin.Location = New System.Drawing.Point(768, 0)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(40, 37)
        Me.BtnMin.TabIndex = 2
        Me.BtnMin.UseVisualStyleBackColor = True
        '
        'BtnMaximizar
        '
        Me.BtnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMaximizar.FlatAppearance.BorderSize = 0
        Me.BtnMaximizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnMaximizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMaximizar.Image = CType(resources.GetObject("BtnMaximizar.Image"), System.Drawing.Image)
        Me.BtnMaximizar.Location = New System.Drawing.Point(814, 0)
        Me.BtnMaximizar.Name = "BtnMaximizar"
        Me.BtnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.BtnMaximizar.TabIndex = 1
        Me.BtnMaximizar.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.FlatAppearance.BorderSize = 0
        Me.BtnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow
        Me.BtnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red
        Me.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCerrar.Image = CType(resources.GetObject("BtnCerrar.Image"), System.Drawing.Image)
        Me.BtnCerrar.Location = New System.Drawing.Point(860, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(37, 37)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PanelAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(900, 720)
        Me.Controls.Add(Me.PanelContenedorFormHijo)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelAdm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PanelAdmin"
        Me.PanelAdm.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelClientes.ResumeLayout(False)
        Me.PanelReportes.ResumeLayout(False)
        Me.PanelVentas.ResumeLayout(False)
        Me.PanelProductos.ResumeLayout(False)
        Me.PanelUsuarios.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.PanelContenedorFormHijo.ResumeLayout(False)
        Me.PnllReportes.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdm As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents TMOcultarMenu As Timer
    Friend WithEvents TMMostrarMenu As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BotonUsuarios As Button
    Friend WithEvents PanelUsuarios As Panel
    Friend WithEvents BotonVerUsuarios As Button
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents BotonNuevoProd As Button
    Friend WithEvents BotonVerProd As Button
    Friend WithEvents BotonProductos As Button
    Friend WithEvents PanelVentas As Panel
    Friend WithEvents BotonVentas As Button
    Friend WithEvents BotonVerVentas As Button
    Friend WithEvents PanelContenedorFormHijo As Panel
    Friend WithEvents BotonReportes As Button
    Friend WithEvents PanelReportes As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelClientes As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button4 As Button
    Friend WithEvents BotonClientes As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnSalir As Button
    Friend WithEvents PnllReportes As Panel
    Friend WithEvents BtnVentasPorDia As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnVentasPorCliente As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnVentasPorUser As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnVentasPorFecha As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BtnVentasPorProducto As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BtnAgregarCategoria As Button
End Class
