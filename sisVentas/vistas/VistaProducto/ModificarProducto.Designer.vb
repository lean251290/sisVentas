<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarProducto
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblModificarProducto = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelAgregarProducto = New System.Windows.Forms.Panel()
        Me.CMBModifProd = New System.Windows.Forms.ComboBox()
        Me.PBModifProd = New System.Windows.Forms.PictureBox()
        Me.TBStockModifPrdo = New System.Windows.Forms.TextBox()
        Me.TNombreProdModif = New System.Windows.Forms.TextBox()
        Me.TbPrecioModifProd = New System.Windows.Forms.TextBox()
        Me.LblStockModifProd = New System.Windows.Forms.Label()
        Me.LblFotoModifProd = New System.Windows.Forms.Label()
        Me.LblPrecioModifProd = New System.Windows.Forms.Label()
        Me.LblCategoriaPModif = New System.Windows.Forms.Label()
        Me.LblNombrePModif = New System.Windows.Forms.Label()
        Me.BtnActualizarProd = New System.Windows.Forms.Button()
        Me.BtnCancelarModifProd = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregarProducto.SuspendLayout()
        CType(Me.PBModifProd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblModificarProducto)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 0
        '
        'LblModificarProducto
        '
        Me.LblModificarProducto.AutoSize = True
        Me.LblModificarProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblModificarProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblModificarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblModificarProducto.Location = New System.Drawing.Point(488, 0)
        Me.LblModificarProducto.Name = "LblModificarProducto"
        Me.LblModificarProducto.Size = New System.Drawing.Size(192, 25)
        Me.LblModificarProducto.TabIndex = 9
        Me.LblModificarProducto.Text = "Modificar Producto"
        Me.LblModificarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(52, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PanelAgregarProducto
        '
        Me.PanelAgregarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarProducto.Controls.Add(Me.CMBModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.PBModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.TBStockModifPrdo)
        Me.PanelAgregarProducto.Controls.Add(Me.TNombreProdModif)
        Me.PanelAgregarProducto.Controls.Add(Me.TbPrecioModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.LblStockModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.LblFotoModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.LblPrecioModifProd)
        Me.PanelAgregarProducto.Controls.Add(Me.LblCategoriaPModif)
        Me.PanelAgregarProducto.Controls.Add(Me.LblNombrePModif)
        Me.PanelAgregarProducto.Location = New System.Drawing.Point(40, 75)
        Me.PanelAgregarProducto.Name = "PanelAgregarProducto"
        Me.PanelAgregarProducto.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarProducto.TabIndex = 7
        '
        'CMBModifProd
        '
        Me.CMBModifProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CMBModifProd.FormattingEnabled = True
        Me.CMBModifProd.Location = New System.Drawing.Point(193, 81)
        Me.CMBModifProd.Name = "CMBModifProd"
        Me.CMBModifProd.Size = New System.Drawing.Size(165, 21)
        Me.CMBModifProd.TabIndex = 20
        '
        'PBModifProd
        '
        Me.PBModifProd.BackColor = System.Drawing.Color.Gainsboro
        Me.PBModifProd.Location = New System.Drawing.Point(193, 261)
        Me.PBModifProd.Name = "PBModifProd"
        Me.PBModifProd.Size = New System.Drawing.Size(250, 182)
        Me.PBModifProd.TabIndex = 19
        Me.PBModifProd.TabStop = False
        '
        'TBStockModifPrdo
        '
        Me.TBStockModifPrdo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBStockModifPrdo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBStockModifPrdo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBStockModifPrdo.Location = New System.Drawing.Point(193, 201)
        Me.TBStockModifPrdo.Name = "TBStockModifPrdo"
        Me.TBStockModifPrdo.Size = New System.Drawing.Size(321, 13)
        Me.TBStockModifPrdo.TabIndex = 14
        '
        'TNombreProdModif
        '
        Me.TNombreProdModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreProdModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreProdModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreProdModif.Location = New System.Drawing.Point(193, 21)
        Me.TNombreProdModif.Name = "TNombreProdModif"
        Me.TNombreProdModif.Size = New System.Drawing.Size(321, 13)
        Me.TNombreProdModif.TabIndex = 13
        '
        'TbPrecioModifProd
        '
        Me.TbPrecioModifProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbPrecioModifProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TbPrecioModifProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TbPrecioModifProd.Location = New System.Drawing.Point(193, 141)
        Me.TbPrecioModifProd.Name = "TbPrecioModifProd"
        Me.TbPrecioModifProd.Size = New System.Drawing.Size(321, 13)
        Me.TbPrecioModifProd.TabIndex = 11
        '
        'LblStockModifProd
        '
        Me.LblStockModifProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblStockModifProd.AutoSize = True
        Me.LblStockModifProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStockModifProd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblStockModifProd.Location = New System.Drawing.Point(30, 201)
        Me.LblStockModifProd.Name = "LblStockModifProd"
        Me.LblStockModifProd.Size = New System.Drawing.Size(54, 20)
        Me.LblStockModifProd.TabIndex = 4
        Me.LblStockModifProd.Text = "Stock:"
        Me.LblStockModifProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblFotoModifProd
        '
        Me.LblFotoModifProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblFotoModifProd.AutoSize = True
        Me.LblFotoModifProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFotoModifProd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblFotoModifProd.Location = New System.Drawing.Point(30, 261)
        Me.LblFotoModifProd.Name = "LblFotoModifProd"
        Me.LblFotoModifProd.Size = New System.Drawing.Size(46, 20)
        Me.LblFotoModifProd.TabIndex = 3
        Me.LblFotoModifProd.Text = "Foto:"
        Me.LblFotoModifProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrecioModifProd
        '
        Me.LblPrecioModifProd.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblPrecioModifProd.AutoSize = True
        Me.LblPrecioModifProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecioModifProd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPrecioModifProd.Location = New System.Drawing.Point(30, 141)
        Me.LblPrecioModifProd.Name = "LblPrecioModifProd"
        Me.LblPrecioModifProd.Size = New System.Drawing.Size(57, 20)
        Me.LblPrecioModifProd.TabIndex = 2
        Me.LblPrecioModifProd.Text = "Precio:"
        Me.LblPrecioModifProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCategoriaPModif
        '
        Me.LblCategoriaPModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblCategoriaPModif.AutoSize = True
        Me.LblCategoriaPModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoriaPModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCategoriaPModif.Location = New System.Drawing.Point(30, 81)
        Me.LblCategoriaPModif.Name = "LblCategoriaPModif"
        Me.LblCategoriaPModif.Size = New System.Drawing.Size(82, 20)
        Me.LblCategoriaPModif.TabIndex = 1
        Me.LblCategoriaPModif.Text = "Categoria:"
        Me.LblCategoriaPModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombrePModif
        '
        Me.LblNombrePModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombrePModif.AutoSize = True
        Me.LblNombrePModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombrePModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombrePModif.Location = New System.Drawing.Point(30, 21)
        Me.LblNombrePModif.Name = "LblNombrePModif"
        Me.LblNombrePModif.Size = New System.Drawing.Size(69, 20)
        Me.LblNombrePModif.TabIndex = 0
        Me.LblNombrePModif.Text = "Nombre:"
        Me.LblNombrePModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnActualizarProd
        '
        Me.BtnActualizarProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnActualizarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnActualizarProd.FlatAppearance.BorderSize = 0
        Me.BtnActualizarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualizarProd.Location = New System.Drawing.Point(438, 631)
        Me.BtnActualizarProd.Name = "BtnActualizarProd"
        Me.BtnActualizarProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnActualizarProd.TabIndex = 8
        Me.BtnActualizarProd.Text = "Actualizar"
        Me.BtnActualizarProd.UseVisualStyleBackColor = True
        '
        'BtnCancelarModifProd
        '
        Me.BtnCancelarModifProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarModifProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarModifProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarModifProd.FlatAppearance.BorderSize = 0
        Me.BtnCancelarModifProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarModifProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarModifProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarModifProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarModifProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarModifProd.Location = New System.Drawing.Point(542, 631)
        Me.BtnCancelarModifProd.Name = "BtnCancelarModifProd"
        Me.BtnCancelarModifProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarModifProd.TabIndex = 9
        Me.BtnCancelarModifProd.Text = "Cancelar"
        Me.BtnCancelarModifProd.UseVisualStyleBackColor = True
        '
        'ModificarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelarModifProd)
        Me.Controls.Add(Me.BtnActualizarProd)
        Me.Controls.Add(Me.PanelAgregarProducto)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ModificarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgregarProducto.ResumeLayout(False)
        Me.PanelAgregarProducto.PerformLayout()
        CType(Me.PBModifProd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LblModificarProducto As Label
    Friend WithEvents PanelAgregarProducto As Panel
    Friend WithEvents CMBModifProd As ComboBox
    Friend WithEvents PBModifProd As PictureBox
    Friend WithEvents TBStockModifPrdo As TextBox
    Friend WithEvents TNombreProdModif As TextBox
    Friend WithEvents TbPrecioModifProd As TextBox
    Friend WithEvents LblStockModifProd As Label
    Friend WithEvents LblFotoModifProd As Label
    Friend WithEvents LblPrecioModifProd As Label
    Friend WithEvents LblCategoriaPModif As Label
    Friend WithEvents LblNombrePModif As Label
    Friend WithEvents BtnActualizarProd As Button
    Friend WithEvents BtnCancelarModifProd As Button
End Class
