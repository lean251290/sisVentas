<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProveedor
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
        Me.PBagregarProv = New System.Windows.Forms.PictureBox()
        Me.LabelAgregarProducto = New System.Windows.Forms.Label()
        Me.BtnCancelarProv = New System.Windows.Forms.Button()
        Me.BtnGuardarProv = New System.Windows.Forms.Button()
        Me.PanelAgregarProv = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TTelProv = New System.Windows.Forms.TextBox()
        Me.TNombreProv = New System.Windows.Forms.TextBox()
        Me.TDireccionProv = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblNombreP = New System.Windows.Forms.Label()
        Me.TEmailProv = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBagregarProv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregarProv.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PBagregarProv)
        Me.Panel1.Controls.Add(Me.LabelAgregarProducto)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 10
        '
        'PBagregarProv
        '
        Me.PBagregarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PBagregarProv.Dock = System.Windows.Forms.DockStyle.Left
        Me.PBagregarProv.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBagregarProv.Location = New System.Drawing.Point(0, 0)
        Me.PBagregarProv.Name = "PBagregarProv"
        Me.PBagregarProv.Size = New System.Drawing.Size(53, 50)
        Me.PBagregarProv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBagregarProv.TabIndex = 6
        Me.PBagregarProv.TabStop = False
        '
        'LabelAgregarProducto
        '
        Me.LabelAgregarProducto.AutoSize = True
        Me.LabelAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelAgregarProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgregarProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAgregarProducto.Location = New System.Drawing.Point(487, 0)
        Me.LabelAgregarProducto.Name = "LabelAgregarProducto"
        Me.LabelAgregarProducto.Size = New System.Drawing.Size(193, 25)
        Me.LabelAgregarProducto.TabIndex = 5
        Me.LabelAgregarProducto.Text = "Agregar Proveedor"
        Me.LabelAgregarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCancelarProv
        '
        Me.BtnCancelarProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarProv.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelarProv.FlatAppearance.BorderSize = 0
        Me.BtnCancelarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarProv.Location = New System.Drawing.Point(543, 631)
        Me.BtnCancelarProv.Name = "BtnCancelarProv"
        Me.BtnCancelarProv.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarProv.TabIndex = 12
        Me.BtnCancelarProv.Text = "Cancelar"
        Me.BtnCancelarProv.UseVisualStyleBackColor = True
        '
        'BtnGuardarProv
        '
        Me.BtnGuardarProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnGuardarProv.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnGuardarProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnGuardarProv.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnGuardarProv.FlatAppearance.BorderSize = 0
        Me.BtnGuardarProv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarProv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnGuardarProv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGuardarProv.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGuardarProv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnGuardarProv.Location = New System.Drawing.Point(439, 631)
        Me.BtnGuardarProv.Name = "BtnGuardarProv"
        Me.BtnGuardarProv.Size = New System.Drawing.Size(98, 37)
        Me.BtnGuardarProv.TabIndex = 11
        Me.BtnGuardarProv.Text = "Guardar"
        Me.BtnGuardarProv.UseVisualStyleBackColor = True
        '
        'PanelAgregarProv
        '
        Me.PanelAgregarProv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarProv.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarProv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarProv.Controls.Add(Me.TEmailProv)
        Me.PanelAgregarProv.Controls.Add(Me.Label1)
        Me.PanelAgregarProv.Controls.Add(Me.TTelProv)
        Me.PanelAgregarProv.Controls.Add(Me.TNombreProv)
        Me.PanelAgregarProv.Controls.Add(Me.TDireccionProv)
        Me.PanelAgregarProv.Controls.Add(Me.LblStock)
        Me.PanelAgregarProv.Controls.Add(Me.LblPrecio)
        Me.PanelAgregarProv.Controls.Add(Me.LblNombreP)
        Me.PanelAgregarProv.Location = New System.Drawing.Point(50, 90)
        Me.PanelAgregarProv.Name = "PanelAgregarProv"
        Me.PanelAgregarProv.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarProv.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(56, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "E-mail:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTelProv
        '
        Me.TTelProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTelProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TTelProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTelProv.Location = New System.Drawing.Point(219, 240)
        Me.TTelProv.Name = "TTelProv"
        Me.TTelProv.Size = New System.Drawing.Size(321, 13)
        Me.TTelProv.TabIndex = 4
        '
        'TNombreProv
        '
        Me.TNombreProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreProv.Location = New System.Drawing.Point(219, 113)
        Me.TNombreProv.Name = "TNombreProv"
        Me.TNombreProv.Size = New System.Drawing.Size(321, 13)
        Me.TNombreProv.TabIndex = 1
        '
        'TDireccionProv
        '
        Me.TDireccionProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionProv.Location = New System.Drawing.Point(219, 179)
        Me.TDireccionProv.Name = "TDireccionProv"
        Me.TDireccionProv.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionProv.TabIndex = 3
        '
        'LblStock
        '
        Me.LblStock.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblStock.Location = New System.Drawing.Point(56, 235)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(75, 20)
        Me.LblStock.TabIndex = 4
        Me.LblStock.Text = "Teléfono:"
        Me.LblStock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPrecio
        '
        Me.LblPrecio.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPrecio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPrecio.Location = New System.Drawing.Point(56, 174)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(79, 20)
        Me.LblPrecio.TabIndex = 2
        Me.LblPrecio.Text = "Dirección:"
        Me.LblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombreP
        '
        Me.LblNombreP.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombreP.AutoSize = True
        Me.LblNombreP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreP.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombreP.Location = New System.Drawing.Point(56, 113)
        Me.LblNombreP.Name = "LblNombreP"
        Me.LblNombreP.Size = New System.Drawing.Size(69, 20)
        Me.LblNombreP.TabIndex = 0
        Me.LblNombreP.Text = "Nombre:"
        Me.LblNombreP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEmailProv
        '
        Me.TEmailProv.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailProv.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailProv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailProv.Location = New System.Drawing.Point(219, 295)
        Me.TEmailProv.Name = "TEmailProv"
        Me.TEmailProv.Size = New System.Drawing.Size(321, 13)
        Me.TEmailProv.TabIndex = 21
        '
        'FrmProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelarProv)
        Me.Controls.Add(Me.BtnGuardarProv)
        Me.Controls.Add(Me.PanelAgregarProv)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProveedor"
        Me.Text = "FrmProveedor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBagregarProv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgregarProv.ResumeLayout(False)
        Me.PanelAgregarProv.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBagregarProv As PictureBox
    Friend WithEvents LabelAgregarProducto As Label
    Friend WithEvents BtnCancelarProv As Button
    Friend WithEvents BtnGuardarProv As Button
    Friend WithEvents PanelAgregarProv As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TTelProv As TextBox
    Friend WithEvents TNombreProv As TextBox
    Friend WithEvents TDireccionProv As TextBox
    Friend WithEvents LblStock As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents LblNombreP As Label
    Friend WithEvents TEmailProv As TextBox
End Class
