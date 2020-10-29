<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NuevaVenta
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelNuevaVenta = New System.Windows.Forms.Label()
        Me.PanelVerClientes = New System.Windows.Forms.Panel()
        Me.DGVentaProductos = New System.Windows.Forms.DataGridView()
        Me.PBAgregarProducto = New System.Windows.Forms.PictureBox()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.DGVenta = New System.Windows.Forms.DataGridView()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TBProducto = New System.Windows.Forms.TextBox()
        Me.LblBuscarProd = New System.Windows.Forms.Label()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblNombreVenta = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelNombreCliente = New System.Windows.Forms.Label()
        Me.BtnCancelarVenta = New System.Windows.Forms.Button()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelVerClientes.SuspendLayout()
        CType(Me.DGVentaProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBAgregarProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNuevaVenta
        '
        Me.LabelNuevaVenta.AutoSize = True
        Me.LabelNuevaVenta.BackColor = System.Drawing.Color.Transparent
        Me.LabelNuevaVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelNuevaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevaVenta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNuevaVenta.Location = New System.Drawing.Point(544, 0)
        Me.LabelNuevaVenta.Name = "LabelNuevaVenta"
        Me.LabelNuevaVenta.Size = New System.Drawing.Size(136, 25)
        Me.LabelNuevaVenta.TabIndex = 5
        Me.LabelNuevaVenta.Text = "Nueva Venta"
        Me.LabelNuevaVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelVerClientes
        '
        Me.PanelVerClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerClientes.Controls.Add(Me.DGVentaProductos)
        Me.PanelVerClientes.Controls.Add(Me.PBAgregarProducto)
        Me.PanelVerClientes.Controls.Add(Me.TBuscarCliente)
        Me.PanelVerClientes.Controls.Add(Me.DGVenta)
        Me.PanelVerClientes.Controls.Add(Me.DateTimePicker1)
        Me.PanelVerClientes.Controls.Add(Me.Label1)
        Me.PanelVerClientes.Controls.Add(Me.TBCantidad)
        Me.PanelVerClientes.Controls.Add(Me.Label4)
        Me.PanelVerClientes.Controls.Add(Me.Label3)
        Me.PanelVerClientes.Controls.Add(Me.PictureBox3)
        Me.PanelVerClientes.Controls.Add(Me.TBProducto)
        Me.PanelVerClientes.Controls.Add(Me.LblBuscarProd)
        Me.PanelVerClientes.Controls.Add(Me.LBuscarCliente)
        Me.PanelVerClientes.Location = New System.Drawing.Point(47, 89)
        Me.PanelVerClientes.Name = "PanelVerClientes"
        Me.PanelVerClientes.Size = New System.Drawing.Size(600, 524)
        Me.PanelVerClientes.TabIndex = 7
        '
        'DGVentaProductos
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        Me.DGVentaProductos.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVentaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVentaProductos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6})
        Me.DGVentaProductos.Location = New System.Drawing.Point(20, 357)
        Me.DGVentaProductos.Name = "DGVentaProductos"
        Me.DGVentaProductos.Size = New System.Drawing.Size(551, 147)
        Me.DGVentaProductos.TabIndex = 37
        '
        'PBAgregarProducto
        '
        Me.PBAgregarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.PBAgregarProducto.Image = Global.sisVentas.My.Resources.Resources.icoAgregar
        Me.PBAgregarProducto.Location = New System.Drawing.Point(502, 88)
        Me.PBAgregarProducto.Name = "PBAgregarProducto"
        Me.PBAgregarProducto.Size = New System.Drawing.Size(26, 26)
        Me.PBAgregarProducto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAgregarProducto.TabIndex = 36
        Me.PBAgregarProducto.TabStop = False
        '
        'TBuscarCliente
        '
        Me.TBuscarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarCliente.Location = New System.Drawing.Point(174, 48)
        Me.TBuscarCliente.MaxLength = 15
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(321, 13)
        Me.TBuscarCliente.TabIndex = 35
        '
        'DGVenta
        '
        Me.DGVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVenta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVenta.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVenta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVenta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DGVenta.ColumnHeadersHeight = 28
        Me.DGVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVenta.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGVenta.EnableHeadersVisualStyles = False
        Me.DGVenta.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DGVenta.Location = New System.Drawing.Point(41, 132)
        Me.DGVenta.Name = "DGVenta"
        Me.DGVenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVenta.RowHeadersVisible = False
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.DGVenta.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DGVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVenta.Size = New System.Drawing.Size(516, 117)
        Me.DGVenta.TabIndex = 33
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DateTimePicker1.Cursor = System.Windows.Forms.Cursors.No
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(103, 272)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(106, 20)
        Me.DateTimePicker1.TabIndex = 31
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(39, 272)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Fecha:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TBCantidad
        '
        Me.TBCantidad.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.TBCantidad.Location = New System.Drawing.Point(335, 272)
        Me.TBCantidad.Name = "TBCantidad"
        Me.TBCantidad.Size = New System.Drawing.Size(100, 20)
        Me.TBCantidad.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(252, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(39, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Detalle de la Venta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.sisVentas.My.Resources.Resources.icoAgregar
        Me.PictureBox3.Location = New System.Drawing.Point(501, 43)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(26, 26)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'TBProducto
        '
        Me.TBProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBProducto.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBProducto.Location = New System.Drawing.Point(174, 93)
        Me.TBProducto.Name = "TBProducto"
        Me.TBProducto.Size = New System.Drawing.Size(322, 13)
        Me.TBProducto.TabIndex = 20
        '
        'LblBuscarProd
        '
        Me.LblBuscarProd.AutoSize = True
        Me.LblBuscarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarProd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblBuscarProd.Location = New System.Drawing.Point(37, 88)
        Me.LblBuscarProd.Name = "LblBuscarProd"
        Me.LblBuscarProd.Size = New System.Drawing.Size(131, 20)
        Me.LblBuscarProd.TabIndex = 19
        Me.LblBuscarProd.Text = "Buscar Producto:"
        Me.LblBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarCliente.Location = New System.Drawing.Point(106, 43)
        Me.LBuscarCliente.Name = "LBuscarCliente"
        Me.LBuscarCliente.Size = New System.Drawing.Size(62, 20)
        Me.LBuscarCliente.TabIndex = 0
        Me.LBuscarCliente.Text = "Cliente:"
        Me.LBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelNuevaVenta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(43, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Vendedor:"
        '
        'LblNombreVenta
        '
        Me.LblNombreVenta.AutoSize = True
        Me.LblNombreVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblNombreVenta.Location = New System.Drawing.Point(133, 66)
        Me.LblNombreVenta.Name = "LblNombreVenta"
        Me.LblNombreVenta.Size = New System.Drawing.Size(150, 20)
        Me.LblNombreVenta.TabIndex = 12
        Me.LblNombreVenta.Text = "nombredelvendedor"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(429, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cliente:"
        '
        'LabelNombreCliente
        '
        Me.LabelNombreCliente.AutoSize = True
        Me.LabelNombreCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNombreCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelNombreCliente.Location = New System.Drawing.Point(497, 66)
        Me.LabelNombreCliente.Name = "LabelNombreCliente"
        Me.LabelNombreCliente.Size = New System.Drawing.Size(29, 20)
        Me.LabelNombreCliente.TabIndex = 14
        Me.LabelNombreCliente.Text = "     "
        '
        'BtnCancelarVenta
        '
        Me.BtnCancelarVenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarVenta.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarVenta.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarVenta.FlatAppearance.BorderSize = 0
        Me.BtnCancelarVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarVenta.Location = New System.Drawing.Point(549, 631)
        Me.BtnCancelarVenta.Name = "BtnCancelarVenta"
        Me.BtnCancelarVenta.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarVenta.TabIndex = 10
        Me.BtnCancelarVenta.Text = "Cancelar"
        Me.BtnCancelarVenta.UseVisualStyleBackColor = False
        '
        'BtnVender
        '
        Me.BtnVender.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnVender.BackColor = System.Drawing.Color.Transparent
        Me.BtnVender.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVender.FlatAppearance.BorderSize = 0
        Me.BtnVender.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVender.Location = New System.Drawing.Point(445, 631)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(98, 37)
        Me.BtnVender.TabIndex = 9
        Me.BtnVender.Text = "Vender"
        Me.BtnVender.UseVisualStyleBackColor = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Precio"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Eliminar"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.Text = ""
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sub-Total"
        Me.Column6.Name = "Column6"
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.LabelNombreCliente)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LblNombreVenta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnCancelarVenta)
        Me.Controls.Add(Me.BtnVender)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelVerClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaVenta"
        Me.Tag = ""
        Me.Text = "Form6"
        Me.PanelVerClientes.ResumeLayout(False)
        Me.PanelVerClientes.PerformLayout()
        CType(Me.DGVentaProductos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBAgregarProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelNuevaVenta As Label
    Friend WithEvents PanelVerClientes As Panel
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TBProducto As TextBox
    Friend WithEvents LblBuscarProd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnVender As Button
    Friend WithEvents BtnCancelarVenta As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents TBCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblNombreVenta As Label
    Friend WithEvents DGVenta As DataGridView
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelNombreCliente As Label
    Friend WithEvents PBAgregarProducto As PictureBox
    Friend WithEvents DGVentaProductos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewButtonColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
