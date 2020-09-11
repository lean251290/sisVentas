<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PanelAdmin))
        Me.PanelAdm = New System.Windows.Forms.Panel()
        Me.BtnRestaurar = New System.Windows.Forms.Button()
        Me.BtnMin = New System.Windows.Forms.Button()
        Me.BtnMaximizar = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.BtnProductos = New System.Windows.Forms.Button()
        Me.BtnCompras = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.BtnPagos = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtnUsuarios = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtnReportes = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BtnVentas = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnClientes = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnMenu = New System.Windows.Forms.PictureBox()
        Me.PanelForms = New System.Windows.Forms.Panel()
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.TMOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.TMMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.PanelAdm.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelForms.SuspendLayout()
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
        Me.PanelAdm.Size = New System.Drawing.Size(985, 40)
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
        Me.BtnRestaurar.Location = New System.Drawing.Point(899, 0)
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
        Me.BtnMin.Location = New System.Drawing.Point(853, 0)
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
        Me.BtnMaximizar.Location = New System.Drawing.Point(899, 0)
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
        Me.BtnCerrar.Location = New System.Drawing.Point(945, 0)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(40, 40)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.PanelMenu.Controls.Add(Me.Panel9)
        Me.PanelMenu.Controls.Add(Me.Panel8)
        Me.PanelMenu.Controls.Add(Me.BtnProductos)
        Me.PanelMenu.Controls.Add(Me.BtnCompras)
        Me.PanelMenu.Controls.Add(Me.Panel7)
        Me.PanelMenu.Controls.Add(Me.BtnPagos)
        Me.PanelMenu.Controls.Add(Me.Panel6)
        Me.PanelMenu.Controls.Add(Me.BtnUsuarios)
        Me.PanelMenu.Controls.Add(Me.Panel5)
        Me.PanelMenu.Controls.Add(Me.BtnReportes)
        Me.PanelMenu.Controls.Add(Me.Panel4)
        Me.PanelMenu.Controls.Add(Me.BtnVentas)
        Me.PanelMenu.Controls.Add(Me.Panel3)
        Me.PanelMenu.Controls.Add(Me.BtnClientes)
        Me.PanelMenu.Controls.Add(Me.Panel2)
        Me.PanelMenu.Controls.Add(Me.Panel1)
        Me.PanelMenu.Controls.Add(Me.BtnAgregar)
        Me.PanelMenu.Controls.Add(Me.PictureBox1)
        Me.PanelMenu.Controls.Add(Me.BtnMenu)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 40)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(220, 552)
        Me.PanelMenu.TabIndex = 1
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel9.Location = New System.Drawing.Point(0, 486)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(5, 50)
        Me.Panel9.TabIndex = 15
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel8.Location = New System.Drawing.Point(0, 430)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(5, 50)
        Me.Panel8.TabIndex = 12
        '
        'BtnProductos
        '
        Me.BtnProductos.FlatAppearance.BorderSize = 0
        Me.BtnProductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnProductos.Image = CType(resources.GetObject("BtnProductos.Image"), System.Drawing.Image)
        Me.BtnProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProductos.Location = New System.Drawing.Point(0, 486)
        Me.BtnProductos.Name = "BtnProductos"
        Me.BtnProductos.Size = New System.Drawing.Size(220, 50)
        Me.BtnProductos.TabIndex = 16
        Me.BtnProductos.Text = " Productos"
        Me.BtnProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnProductos.UseVisualStyleBackColor = True
        '
        'BtnCompras
        '
        Me.BtnCompras.FlatAppearance.BorderSize = 0
        Me.BtnCompras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCompras.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnCompras.Image = CType(resources.GetObject("BtnCompras.Image"), System.Drawing.Image)
        Me.BtnCompras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCompras.Location = New System.Drawing.Point(0, 430)
        Me.BtnCompras.Name = "BtnCompras"
        Me.BtnCompras.Size = New System.Drawing.Size(220, 50)
        Me.BtnCompras.TabIndex = 13
        Me.BtnCompras.Text = " Compras"
        Me.BtnCompras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnCompras.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel7.Location = New System.Drawing.Point(0, 262)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(5, 50)
        Me.Panel7.TabIndex = 10
        '
        'BtnPagos
        '
        Me.BtnPagos.FlatAppearance.BorderSize = 0
        Me.BtnPagos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnPagos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnPagos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPagos.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnPagos.Image = CType(resources.GetObject("BtnPagos.Image"), System.Drawing.Image)
        Me.BtnPagos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPagos.Location = New System.Drawing.Point(0, 262)
        Me.BtnPagos.Name = "BtnPagos"
        Me.BtnPagos.Size = New System.Drawing.Size(220, 50)
        Me.BtnPagos.TabIndex = 11
        Me.BtnPagos.Text = " Pagos"
        Me.BtnPagos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPagos.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel6.Location = New System.Drawing.Point(0, 318)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(5, 50)
        Me.Panel6.TabIndex = 8
        '
        'BtnUsuarios
        '
        Me.BtnUsuarios.FlatAppearance.BorderSize = 0
        Me.BtnUsuarios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnUsuarios.Image = CType(resources.GetObject("BtnUsuarios.Image"), System.Drawing.Image)
        Me.BtnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnUsuarios.Location = New System.Drawing.Point(0, 318)
        Me.BtnUsuarios.Name = "BtnUsuarios"
        Me.BtnUsuarios.Size = New System.Drawing.Size(220, 50)
        Me.BtnUsuarios.TabIndex = 9
        Me.BtnUsuarios.Text = " Usuarios"
        Me.BtnUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnUsuarios.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(0, 374)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 6
        '
        'BtnReportes
        '
        Me.BtnReportes.FlatAppearance.BorderSize = 0
        Me.BtnReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReportes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnReportes.Image = CType(resources.GetObject("BtnReportes.Image"), System.Drawing.Image)
        Me.BtnReportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnReportes.Location = New System.Drawing.Point(0, 374)
        Me.BtnReportes.Name = "BtnReportes"
        Me.BtnReportes.Size = New System.Drawing.Size(220, 50)
        Me.BtnReportes.TabIndex = 7
        Me.BtnReportes.Text = " Reportes"
        Me.BtnReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnReportes.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(0, 206)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 4
        '
        'BtnVentas
        '
        Me.BtnVentas.FlatAppearance.BorderSize = 0
        Me.BtnVentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVentas.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnVentas.Image = CType(resources.GetObject("BtnVentas.Image"), System.Drawing.Image)
        Me.BtnVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnVentas.Location = New System.Drawing.Point(0, 206)
        Me.BtnVentas.Name = "BtnVentas"
        Me.BtnVentas.Size = New System.Drawing.Size(220, 50)
        Me.BtnVentas.TabIndex = 5
        Me.BtnVentas.Text = " Ventas"
        Me.BtnVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnVentas.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(0, 150)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(5, 50)
        Me.Panel3.TabIndex = 2
        '
        'BtnClientes
        '
        Me.BtnClientes.FlatAppearance.BorderSize = 0
        Me.BtnClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnClientes.Image = CType(resources.GetObject("BtnClientes.Image"), System.Drawing.Image)
        Me.BtnClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnClientes.Location = New System.Drawing.Point(0, 150)
        Me.BtnClientes.Name = "BtnClientes"
        Me.BtnClientes.Size = New System.Drawing.Size(220, 50)
        Me.BtnClientes.TabIndex = 3
        Me.BtnClientes.Text = " Clientes"
        Me.BtnClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClientes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 50)
        Me.Panel2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(14, 161)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1, 50)
        Me.Panel1.TabIndex = 0
        '
        'BtnAgregar
        '
        Me.BtnAgregar.FlatAppearance.BorderSize = 0
        Me.BtnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Navy
        Me.BtnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.BtnAgregar.Image = CType(resources.GetObject("BtnAgregar.Image"), System.Drawing.Image)
        Me.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnAgregar.Location = New System.Drawing.Point(0, 94)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(220, 50)
        Me.BtnAgregar.TabIndex = 0
        Me.BtnAgregar.Text = "  Agregar Usuario"
        Me.BtnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 47)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'BtnMenu
        '
        Me.BtnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMenu.Image = CType(resources.GetObject("BtnMenu.Image"), System.Drawing.Image)
        Me.BtnMenu.Location = New System.Drawing.Point(167, 0)
        Me.BtnMenu.Name = "BtnMenu"
        Me.BtnMenu.Size = New System.Drawing.Size(53, 41)
        Me.BtnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.BtnMenu.TabIndex = 0
        Me.BtnMenu.TabStop = False
        '
        'PanelForms
        '
        Me.PanelForms.BackColor = System.Drawing.Color.LightGray
        Me.PanelForms.Controls.Add(Me.PanelContenedor)
        Me.PanelForms.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelForms.Location = New System.Drawing.Point(220, 40)
        Me.PanelForms.Name = "PanelForms"
        Me.PanelForms.Size = New System.Drawing.Size(765, 552)
        Me.PanelForms.TabIndex = 2
        '
        'PanelContenedor
        '
        Me.PanelContenedor.BackColor = System.Drawing.Color.LightGray
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(765, 552)
        Me.PanelContenedor.TabIndex = 14
        '
        'TMOcultarMenu
        '
        '
        'TMMostrarMenu
        '
        '
        'PanelAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(985, 592)
        Me.Controls.Add(Me.PanelForms)
        Me.Controls.Add(Me.PanelMenu)
        Me.Controls.Add(Me.PanelAdm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelAdmin"
        Me.Text = "PanelAdmin"
        Me.PanelAdm.ResumeLayout(False)
        Me.PanelMenu.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelForms.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAdm As Panel
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelForms As Panel
    Friend WithEvents BtnMin As Button
    Friend WithEvents BtnMaximizar As Button
    Friend WithEvents BtnRestaurar As Button
    Friend WithEvents BtnMenu As PictureBox
    Friend WithEvents TMOcultarMenu As Timer
    Friend WithEvents TMMostrarMenu As Timer
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents BtnCompras As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents BtnPagos As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtnUsuarios As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtnReportes As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents BtnVentas As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnClientes As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents BtnProductos As Button
    Friend WithEvents PanelContenedor As Panel
End Class
