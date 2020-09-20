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
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.PanelClientes = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonClientes = New System.Windows.Forms.Button()
        Me.PanelReportes = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BotonReportes = New System.Windows.Forms.Button()
        Me.PanelVentas = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BotonVerVentas = New System.Windows.Forms.Button()
        Me.BotonVentas = New System.Windows.Forms.Button()
        Me.PanelProductos = New System.Windows.Forms.Panel()
        Me.BotonModificarProd = New System.Windows.Forms.Button()
        Me.BotonNuevoProd = New System.Windows.Forms.Button()
        Me.BotonVerProd = New System.Windows.Forms.Button()
        Me.BotonProductos = New System.Windows.Forms.Button()
        Me.PanelUsuarios = New System.Windows.Forms.Panel()
        Me.BotonVerUsuarios = New System.Windows.Forms.Button()
        Me.BotonAgregarUsuario = New System.Windows.Forms.Button()
        Me.BotonUsuarios = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TMOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TMMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContenedorFormHijo = New System.Windows.Forms.Panel()
        Me.PanelAdm.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.PanelClientes.SuspendLayout()
        Me.PanelReportes.SuspendLayout()
        Me.PanelVentas.SuspendLayout()
        Me.PanelProductos.SuspendLayout()
        Me.PanelUsuarios.SuspendLayout()
        Me.Panel11.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAdm
        '
        Me.PanelAdm.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer))
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
        Me.BtnRestaurar.Size = New System.Drawing.Size(40, 40)
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
        Me.BtnMin.Size = New System.Drawing.Size(40, 40)
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
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.AutoScroll = True
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
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
        Me.PanelClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelClientes.Controls.Add(Me.Button4)
        Me.PanelClientes.Controls.Add(Me.Button1)
        Me.PanelClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelClientes.Location = New System.Drawing.Point(0, 608)
        Me.PanelClientes.Name = "PanelClientes"
        Me.PanelClientes.Size = New System.Drawing.Size(203, 80)
        Me.PanelClientes.TabIndex = 27
        '
        'Button4
        '
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
        Me.Button4.Text = "NUEVO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button1
        '
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
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonClientes
        '
        Me.BotonClientes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonClientes.FlatAppearance.BorderSize = 0
        Me.BotonClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonClientes.ForeColor = System.Drawing.Color.White
        Me.BotonClientes.Location = New System.Drawing.Point(0, 568)
        Me.BotonClientes.Name = "BotonClientes"
        Me.BotonClientes.Size = New System.Drawing.Size(203, 40)
        Me.BotonClientes.TabIndex = 26
        Me.BotonClientes.Text = "CLIENTES"
        Me.BotonClientes.UseVisualStyleBackColor = True
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
        'Button2
        '
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
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BotonReportes
        '
        Me.BotonReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonReportes.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonReportes.FlatAppearance.BorderSize = 0
        Me.BotonReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonReportes.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonReportes.Image = CType(resources.GetObject("BotonReportes.Image"), System.Drawing.Image)
        Me.BotonReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonReportes.Location = New System.Drawing.Point(0, 488)
        Me.BotonReportes.Name = "BotonReportes"
        Me.BotonReportes.Size = New System.Drawing.Size(203, 40)
        Me.BotonReportes.TabIndex = 24
        Me.BotonReportes.Text = "REPORTES"
        Me.BotonReportes.UseVisualStyleBackColor = True
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
        'Button3
        '
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
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BotonVerVentas
        '
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
        Me.BotonVerVentas.UseVisualStyleBackColor = True
        '
        'BotonVentas
        '
        Me.BotonVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVentas.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVentas.FlatAppearance.BorderSize = 0
        Me.BotonVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVentas.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVentas.Image = CType(resources.GetObject("BotonVentas.Image"), System.Drawing.Image)
        Me.BotonVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVentas.Location = New System.Drawing.Point(0, 368)
        Me.BotonVentas.Name = "BotonVentas"
        Me.BotonVentas.Size = New System.Drawing.Size(203, 40)
        Me.BotonVentas.TabIndex = 22
        Me.BotonVentas.Text = "VENTAS"
        Me.BotonVentas.UseVisualStyleBackColor = True
        '
        'PanelProductos
        '
        Me.PanelProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelProductos.Controls.Add(Me.BotonModificarProd)
        Me.PanelProductos.Controls.Add(Me.BotonNuevoProd)
        Me.PanelProductos.Controls.Add(Me.BotonVerProd)
        Me.PanelProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelProductos.Location = New System.Drawing.Point(0, 248)
        Me.PanelProductos.Name = "PanelProductos"
        Me.PanelProductos.Size = New System.Drawing.Size(203, 120)
        Me.PanelProductos.TabIndex = 21
        '
        'BotonModificarProd
        '
        Me.BotonModificarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonModificarProd.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonModificarProd.FlatAppearance.BorderSize = 0
        Me.BotonModificarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonModificarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonModificarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonModificarProd.Image = CType(resources.GetObject("BotonModificarProd.Image"), System.Drawing.Image)
        Me.BotonModificarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonModificarProd.Location = New System.Drawing.Point(0, 80)
        Me.BotonModificarProd.Name = "BotonModificarProd"
        Me.BotonModificarProd.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonModificarProd.Size = New System.Drawing.Size(203, 40)
        Me.BotonModificarProd.TabIndex = 3
        Me.BotonModificarProd.Text = "MODIFICAR"
        Me.BotonModificarProd.UseVisualStyleBackColor = True
        '
        'BotonNuevoProd
        '
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
        Me.BotonNuevoProd.UseVisualStyleBackColor = True
        '
        'BotonVerProd
        '
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
        Me.BotonVerProd.UseVisualStyleBackColor = True
        '
        'BotonProductos
        '
        Me.BotonProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonProductos.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonProductos.FlatAppearance.BorderSize = 0
        Me.BotonProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonProductos.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonProductos.Image = CType(resources.GetObject("BotonProductos.Image"), System.Drawing.Image)
        Me.BotonProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonProductos.Location = New System.Drawing.Point(0, 208)
        Me.BotonProductos.Name = "BotonProductos"
        Me.BotonProductos.Size = New System.Drawing.Size(203, 40)
        Me.BotonProductos.TabIndex = 20
        Me.BotonProductos.Text = "PRODUCTOS"
        Me.BotonProductos.UseVisualStyleBackColor = True
        '
        'PanelUsuarios
        '
        Me.PanelUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.PanelUsuarios.Controls.Add(Me.BotonVerUsuarios)
        Me.PanelUsuarios.Controls.Add(Me.BotonAgregarUsuario)
        Me.PanelUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelUsuarios.Location = New System.Drawing.Point(0, 128)
        Me.PanelUsuarios.Name = "PanelUsuarios"
        Me.PanelUsuarios.Size = New System.Drawing.Size(203, 80)
        Me.PanelUsuarios.TabIndex = 19
        '
        'BotonVerUsuarios
        '
        Me.BotonVerUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonVerUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonVerUsuarios.FlatAppearance.BorderSize = 0
        Me.BotonVerUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonVerUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonVerUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonVerUsuarios.Image = CType(resources.GetObject("BotonVerUsuarios.Image"), System.Drawing.Image)
        Me.BotonVerUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonVerUsuarios.Location = New System.Drawing.Point(0, 40)
        Me.BotonVerUsuarios.Name = "BotonVerUsuarios"
        Me.BotonVerUsuarios.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonVerUsuarios.Size = New System.Drawing.Size(203, 40)
        Me.BotonVerUsuarios.TabIndex = 2
        Me.BotonVerUsuarios.Text = "VER"
        Me.BotonVerUsuarios.UseVisualStyleBackColor = True
        '
        'BotonAgregarUsuario
        '
        Me.BotonAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.BotonAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonAgregarUsuario.Image = CType(resources.GetObject("BotonAgregarUsuario.Image"), System.Drawing.Image)
        Me.BotonAgregarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonAgregarUsuario.Location = New System.Drawing.Point(0, 0)
        Me.BotonAgregarUsuario.Name = "BotonAgregarUsuario"
        Me.BotonAgregarUsuario.Padding = New System.Windows.Forms.Padding(30, 0, 0, 0)
        Me.BotonAgregarUsuario.Size = New System.Drawing.Size(203, 40)
        Me.BotonAgregarUsuario.TabIndex = 1
        Me.BotonAgregarUsuario.Text = "NUEVO"
        Me.BotonAgregarUsuario.UseVisualStyleBackColor = True
        '
        'BotonUsuarios
        '
        Me.BotonUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BotonUsuarios.Dock = System.Windows.Forms.DockStyle.Top
        Me.BotonUsuarios.FlatAppearance.BorderSize = 0
        Me.BotonUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BotonUsuarios.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BotonUsuarios.Image = CType(resources.GetObject("BotonUsuarios.Image"), System.Drawing.Image)
        Me.BotonUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BotonUsuarios.Location = New System.Drawing.Point(0, 88)
        Me.BotonUsuarios.Name = "BotonUsuarios"
        Me.BotonUsuarios.Size = New System.Drawing.Size(203, 40)
        Me.BotonUsuarios.TabIndex = 0
        Me.BotonUsuarios.Text = "USUARIOS"
        Me.BotonUsuarios.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.PictureBox1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel11.Location = New System.Drawing.Point(0, 34)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(203, 54)
        Me.Panel11.TabIndex = 17
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(229, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.BtnMenu)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(203, 34)
        Me.Panel10.TabIndex = 17
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(150, 0)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(50, 34)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.TabStop = False
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
        Me.PanelContenedorFormHijo.BackColor = System.Drawing.Color.DarkRed
        Me.PanelContenedorFormHijo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedorFormHijo.Location = New System.Drawing.Point(220, 40)
        Me.PanelContenedorFormHijo.Name = "PanelContenedorFormHijo"
        Me.PanelContenedorFormHijo.Size = New System.Drawing.Size(680, 680)
        Me.PanelContenedorFormHijo.TabIndex = 2
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents BotonUsuarios As Button
    Friend WithEvents PanelUsuarios As Panel
    Friend WithEvents BotonVerUsuarios As Button
    Friend WithEvents BotonAgregarUsuario As Button
    Friend WithEvents PanelProductos As Panel
    Friend WithEvents BotonNuevoProd As Button
    Friend WithEvents BotonVerProd As Button
    Friend WithEvents BotonProductos As Button
    Friend WithEvents BotonModificarProd As Button
    Friend WithEvents PanelVentas As Panel
    Friend WithEvents BotonVentas As Button
    Friend WithEvents BotonVerVentas As Button
    Friend WithEvents PanelContenedorFormHijo As Panel
    Friend WithEvents BotonReportes As Button
    Friend WithEvents PanelReportes As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelClientes As Panel
    Friend WithEvents BotonClientes As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
End Class
