<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerProductos
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
        Me.PanelVerProductos = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBProdActivos = New System.Windows.Forms.RadioButton()
        Me.RBprodEliminados = New System.Windows.Forms.RadioButton()
        Me.DataGridProd = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBuscarProd = New System.Windows.Forms.TextBox()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.LabelVerProducto = New System.Windows.Forms.Label()
        Me.BtnModificarProducto = New System.Windows.Forms.Button()
        Me.BtnEliminarProducto = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnAltaProd = New System.Windows.Forms.Button()
        Me.PanelVerProductos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridProd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelVerProductos
        '
        Me.PanelVerProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerProductos.Controls.Add(Me.GroupBox1)
        Me.PanelVerProductos.Controls.Add(Me.DataGridProd)
        Me.PanelVerProductos.Controls.Add(Me.PictureBox1)
        Me.PanelVerProductos.Controls.Add(Me.TBuscarProd)
        Me.PanelVerProductos.Controls.Add(Me.LBuscarCliente)
        Me.PanelVerProductos.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerProductos.Name = "PanelVerProductos"
        Me.PanelVerProductos.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerProductos.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBProdActivos)
        Me.GroupBox1.Controls.Add(Me.RBprodEliminados)
        Me.GroupBox1.Location = New System.Drawing.Point(384, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 66)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver por:"
        '
        'RBProdActivos
        '
        Me.RBProdActivos.AutoSize = True
        Me.RBProdActivos.Location = New System.Drawing.Point(6, 30)
        Me.RBProdActivos.Name = "RBProdActivos"
        Me.RBProdActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBProdActivos.TabIndex = 19
        Me.RBProdActivos.TabStop = True
        Me.RBProdActivos.Text = "Activos"
        Me.RBProdActivos.UseVisualStyleBackColor = True
        '
        'RBprodEliminados
        '
        Me.RBprodEliminados.AutoSize = True
        Me.RBprodEliminados.Location = New System.Drawing.Point(103, 30)
        Me.RBprodEliminados.Name = "RBprodEliminados"
        Me.RBprodEliminados.Size = New System.Drawing.Size(75, 17)
        Me.RBprodEliminados.TabIndex = 20
        Me.RBprodEliminados.TabStop = True
        Me.RBprodEliminados.Text = "Eliminados"
        Me.RBprodEliminados.UseVisualStyleBackColor = True
        '
        'DataGridProd
        '
        Me.DataGridProd.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridProd.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridProd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridProd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridProd.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridProd.ColumnHeadersHeight = 28
        Me.DataGridProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridProd.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridProd.EnableHeadersVisualStyles = False
        Me.DataGridProd.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DataGridProd.Location = New System.Drawing.Point(35, 183)
        Me.DataGridProd.Name = "DataGridProd"
        Me.DataGridProd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridProd.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridProd.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridProd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridProd.Size = New System.Drawing.Size(549, 332)
        Me.DataGridProd.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBox1.Location = New System.Drawing.Point(509, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TBuscarProd
        '
        Me.TBuscarProd.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarProd.Location = New System.Drawing.Point(122, 51)
        Me.TBuscarProd.Name = "TBuscarProd"
        Me.TBuscarProd.Size = New System.Drawing.Size(374, 13)
        Me.TBuscarProd.TabIndex = 13
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarCliente.Location = New System.Drawing.Point(46, 46)
        Me.LBuscarCliente.Name = "LBuscarCliente"
        Me.LBuscarCliente.Size = New System.Drawing.Size(77, 20)
        Me.LBuscarCliente.TabIndex = 0
        Me.LBuscarCliente.Text = "Producto:"
        Me.LBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LabelVerProducto
        '
        Me.LabelVerProducto.AutoSize = True
        Me.LabelVerProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelVerProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelVerProducto.Location = New System.Drawing.Point(532, 0)
        Me.LabelVerProducto.Name = "LabelVerProducto"
        Me.LabelVerProducto.Size = New System.Drawing.Size(148, 25)
        Me.LabelVerProducto.TabIndex = 8
        Me.LabelVerProducto.Text = "Ver Productos"
        Me.LabelVerProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnModificarProducto
        '
        Me.BtnModificarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModificarProducto.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnModificarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificarProducto.FlatAppearance.BorderSize = 0
        Me.BtnModificarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnModificarProducto.Location = New System.Drawing.Point(448, 631)
        Me.BtnModificarProducto.Name = "BtnModificarProducto"
        Me.BtnModificarProducto.Size = New System.Drawing.Size(98, 37)
        Me.BtnModificarProducto.TabIndex = 9
        Me.BtnModificarProducto.Text = "Modificar"
        Me.BtnModificarProducto.UseVisualStyleBackColor = True
        '
        'BtnEliminarProducto
        '
        Me.BtnEliminarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminarProducto.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnEliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEliminarProducto.FlatAppearance.BorderSize = 0
        Me.BtnEliminarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminarProducto.Location = New System.Drawing.Point(552, 631)
        Me.BtnEliminarProducto.Name = "BtnEliminarProducto"
        Me.BtnEliminarProducto.Size = New System.Drawing.Size(98, 37)
        Me.BtnEliminarProducto.TabIndex = 10
        Me.BtnEliminarProducto.Text = "Eliminar"
        Me.BtnEliminarProducto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelVerProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 11
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'BtnAltaProd
        '
        Me.BtnAltaProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAltaProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAltaProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAltaProd.FlatAppearance.BorderSize = 0
        Me.BtnAltaProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAltaProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAltaProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAltaProd.Location = New System.Drawing.Point(50, 631)
        Me.BtnAltaProd.Name = "BtnAltaProd"
        Me.BtnAltaProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnAltaProd.TabIndex = 12
        Me.BtnAltaProd.Text = "Alta"
        Me.BtnAltaProd.UseVisualStyleBackColor = True
        '
        'VerProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnAltaProd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnEliminarProducto)
        Me.Controls.Add(Me.BtnModificarProducto)
        Me.Controls.Add(Me.PanelVerProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerProductos"
        Me.Text = "Form2"
        Me.PanelVerProductos.ResumeLayout(False)
        Me.PanelVerProductos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridProd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelVerProductos As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBuscarProd As TextBox
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents LabelVerProducto As Label
    Friend WithEvents BtnModificarProducto As Button
    Friend WithEvents BtnEliminarProducto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGridProd As DataGridView
    Friend WithEvents RBprodEliminados As RadioButton
    Friend WithEvents RBProdActivos As RadioButton
    Friend WithEvents BtnAltaProd As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
