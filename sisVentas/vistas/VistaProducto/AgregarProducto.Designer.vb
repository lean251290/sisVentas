<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarProducto
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
        Me.LabelAgregarProducto = New System.Windows.Forms.Label()
        Me.PanelAgregarProducto = New System.Windows.Forms.Panel()
        Me.ComboBoxProveedor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxCat = New System.Windows.Forms.ComboBox()
        Me.TStockProd = New System.Windows.Forms.TextBox()
        Me.TNombreProd = New System.Windows.Forms.TextBox()
        Me.TPrecioProd = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCategoriaP = New System.Windows.Forms.Label()
        Me.LblNombreP = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelarProd = New System.Windows.Forms.Button()
        Me.BtnGuardarProducto = New System.Windows.Forms.Button()
        Me.PanelAgregarProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAgregarProducto
        '
        Me.LabelAgregarProducto.AutoSize = True
        Me.LabelAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelAgregarProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAgregarProducto.Location = New System.Drawing.Point(500, 0)
        Me.LabelAgregarProducto.Name = "LabelAgregarProducto"
        Me.LabelAgregarProducto.Size = New System.Drawing.Size(180, 25)
        Me.LabelAgregarProducto.TabIndex = 5
        Me.LabelAgregarProducto.Text = "Agregar Producto"
        Me.LabelAgregarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelAgregarProducto
        '
        Me.PanelAgregarProducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarProducto.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarProducto.Controls.Add(Me.ComboBoxProveedor)
        Me.PanelAgregarProducto.Controls.Add(Me.Label1)
        Me.PanelAgregarProducto.Controls.Add(Me.ComboBoxCat)
        Me.PanelAgregarProducto.Controls.Add(Me.TStockProd)
        Me.PanelAgregarProducto.Controls.Add(Me.TNombreProd)
        Me.PanelAgregarProducto.Controls.Add(Me.TPrecioProd)
        Me.PanelAgregarProducto.Controls.Add(Me.LblStock)
        Me.PanelAgregarProducto.Controls.Add(Me.LblPrecio)
        Me.PanelAgregarProducto.Controls.Add(Me.LblCategoriaP)
        Me.PanelAgregarProducto.Controls.Add(Me.LblNombreP)
        Me.PanelAgregarProducto.Location = New System.Drawing.Point(50, 90)
        Me.PanelAgregarProducto.Name = "PanelAgregarProducto"
        Me.PanelAgregarProducto.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarProducto.TabIndex = 6
        '
        'ComboBoxProveedor
        '
        Me.ComboBoxProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxProveedor.FormattingEnabled = True
        Me.ComboBoxProveedor.Location = New System.Drawing.Point(193, 258)
        Me.ComboBoxProveedor.Name = "ComboBoxProveedor"
        Me.ComboBoxProveedor.Size = New System.Drawing.Size(165, 21)
        Me.ComboBoxProveedor.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 259)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Proveedor:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ComboBoxCat
        '
        Me.ComboBoxCat.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxCat.FormattingEnabled = True
        Me.ComboBoxCat.Location = New System.Drawing.Point(193, 81)
        Me.ComboBoxCat.Name = "ComboBoxCat"
        Me.ComboBoxCat.Size = New System.Drawing.Size(165, 21)
        Me.ComboBoxCat.TabIndex = 2
        '
        'TStockProd
        '
        Me.TStockProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TStockProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TStockProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TStockProd.Location = New System.Drawing.Point(193, 201)
        Me.TStockProd.Name = "TStockProd"
        Me.TStockProd.Size = New System.Drawing.Size(321, 13)
        Me.TStockProd.TabIndex = 4
        '
        'TNombreProd
        '
        Me.TNombreProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreProd.Location = New System.Drawing.Point(193, 21)
        Me.TNombreProd.Name = "TNombreProd"
        Me.TNombreProd.Size = New System.Drawing.Size(321, 13)
        Me.TNombreProd.TabIndex = 1
        '
        'TPrecioProd
        '
        Me.TPrecioProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPrecioProd.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TPrecioProd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPrecioProd.Location = New System.Drawing.Point(193, 141)
        Me.TPrecioProd.Name = "TPrecioProd"
        Me.TPrecioProd.Size = New System.Drawing.Size(321, 13)
        Me.TPrecioProd.TabIndex = 3
        '
        'LblStock
        '
        Me.LblStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblStock.Location = New System.Drawing.Point(30, 201)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(54, 20)
        Me.LblStock.TabIndex = 4
        Me.LblStock.Text = "Stock:"
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrecio
        '
        Me.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPrecio.Location = New System.Drawing.Point(30, 141)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(57, 20)
        Me.LblPrecio.TabIndex = 2
        Me.LblPrecio.Text = "Precio:"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCategoriaP
        '
        Me.LblCategoriaP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblCategoriaP.AutoSize = True
        Me.LblCategoriaP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCategoriaP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCategoriaP.Location = New System.Drawing.Point(30, 81)
        Me.LblCategoriaP.Name = "LblCategoriaP"
        Me.LblCategoriaP.Size = New System.Drawing.Size(82, 20)
        Me.LblCategoriaP.TabIndex = 1
        Me.LblCategoriaP.Text = "Categoria:"
        Me.LblCategoriaP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombreP
        '
        Me.LblNombreP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombreP.AutoSize = True
        Me.LblNombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombreP.Location = New System.Drawing.Point(30, 21)
        Me.LblNombreP.Name = "LblNombreP"
        Me.LblNombreP.Size = New System.Drawing.Size(69, 20)
        Me.LblNombreP.TabIndex = 0
        Me.LblNombreP.Text = "Nombre:"
        Me.LblNombreP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelAgregarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'BtnCancelarProd
        '
        Me.BtnCancelarProd.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarProd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarProd.FlatAppearance.BorderSize = 0
        Me.BtnCancelarProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarProd.Location = New System.Drawing.Point(554, 631)
        Me.BtnCancelarProd.Name = "BtnCancelarProd"
        Me.BtnCancelarProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarProd.TabIndex = 6
        Me.BtnCancelarProd.Text = "Cancelar"
        Me.BtnCancelarProd.UseVisualStyleBackColor = True
        '
        'BtnGuardarProducto
        '
        Me.BtnGuardarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarProducto.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnGuardarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardarProducto.FlatAppearance.BorderSize = 0
        Me.BtnGuardarProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarProducto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardarProducto.Location = New System.Drawing.Point(450, 631)
        Me.BtnGuardarProducto.Name = "BtnGuardarProducto"
        Me.BtnGuardarProducto.Size = New System.Drawing.Size(98, 37)
        Me.BtnGuardarProducto.TabIndex = 5
        Me.BtnGuardarProducto.Text = "Guardar"
        Me.BtnGuardarProducto.UseVisualStyleBackColor = True
        '
        'AgregarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelarProd)
        Me.Controls.Add(Me.BtnGuardarProducto)
        Me.Controls.Add(Me.PanelAgregarProducto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarProducto"
        Me.Text = "Form3"
        Me.PanelAgregarProducto.ResumeLayout(False)
        Me.PanelAgregarProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelAgregarProducto As Label
    Friend WithEvents PanelAgregarProducto As Panel
    Friend WithEvents TStockProd As TextBox
    Friend WithEvents TNombreProd As TextBox
    Friend WithEvents TPrecioProd As TextBox
    Friend WithEvents LblStock As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblCategoriaP As Label
    Friend WithEvents LblNombreP As Label
    Friend WithEvents ComboBoxCat As ComboBox
    Friend WithEvents BtnGuardarProducto As Button
    Friend WithEvents BtnCancelarProd As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBoxProveedor As ComboBox
    Friend WithEvents Label1 As Label
End Class
