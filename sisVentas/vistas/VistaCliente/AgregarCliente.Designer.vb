<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarCliente
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
        Me.LabelAgregarCliente = New System.Windows.Forms.Label()
        Me.PanelAgregarCliente = New System.Windows.Forms.Panel()
        Me.PBAgregarCliente = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TEmailCliente = New System.Windows.Forms.TextBox()
        Me.TDireccionCliente = New System.Windows.Forms.TextBox()
        Me.TNombreCliente = New System.Windows.Forms.TextBox()
        Me.TApellidoCliente = New System.Windows.Forms.TextBox()
        Me.TDniCliente = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.dialogCliente = New System.Windows.Forms.OpenFileDialog()
        Me.BtnCancelarCliente = New System.Windows.Forms.Button()
        Me.BtnAgregarCliente = New System.Windows.Forms.Button()
        Me.PanelAgregarCliente.SuspendLayout()
        CType(Me.PBAgregarCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAgregarCliente
        '
        Me.LabelAgregarCliente.AutoSize = True
        Me.LabelAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LabelAgregarCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAgregarCliente.Location = New System.Drawing.Point(508, 0)
        Me.LabelAgregarCliente.Name = "LabelAgregarCliente"
        Me.LabelAgregarCliente.Size = New System.Drawing.Size(172, 25)
        Me.LabelAgregarCliente.TabIndex = 4
        Me.LabelAgregarCliente.Text = "Agregar Clientes"
        Me.LabelAgregarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelAgregarCliente
        '
        Me.PanelAgregarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarCliente.Controls.Add(Me.PBAgregarCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.Label2)
        Me.PanelAgregarCliente.Controls.Add(Me.TEmailCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.TDireccionCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.TNombreCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.TApellidoCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.TDniCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.LblDireccion)
        Me.PanelAgregarCliente.Controls.Add(Me.LblEmail)
        Me.PanelAgregarCliente.Controls.Add(Me.LblDNI)
        Me.PanelAgregarCliente.Controls.Add(Me.lblApellido)
        Me.PanelAgregarCliente.Controls.Add(Me.LblNombre)
        Me.PanelAgregarCliente.Location = New System.Drawing.Point(50, 90)
        Me.PanelAgregarCliente.Name = "PanelAgregarCliente"
        Me.PanelAgregarCliente.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarCliente.TabIndex = 5
        '
        'PBAgregarCliente
        '
        Me.PBAgregarCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.PBAgregarCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.user1
        Me.PBAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PBAgregarCliente.Location = New System.Drawing.Point(193, 321)
        Me.PBAgregarCliente.Name = "PBAgregarCliente"
        Me.PBAgregarCliente.Size = New System.Drawing.Size(240, 177)
        Me.PBAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBAgregarCliente.TabIndex = 19
        Me.PBAgregarCliente.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(30, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Foto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEmailCliente
        '
        Me.TEmailCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailCliente.Location = New System.Drawing.Point(193, 261)
        Me.TEmailCliente.Name = "TEmailCliente"
        Me.TEmailCliente.Size = New System.Drawing.Size(321, 13)
        Me.TEmailCliente.TabIndex = 15
        '
        'TDireccionCliente
        '
        Me.TDireccionCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionCliente.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionCliente.Name = "TDireccionCliente"
        Me.TDireccionCliente.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionCliente.TabIndex = 14
        '
        'TNombreCliente
        '
        Me.TNombreCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreCliente.Location = New System.Drawing.Point(193, 79)
        Me.TNombreCliente.Name = "TNombreCliente"
        Me.TNombreCliente.Size = New System.Drawing.Size(321, 13)
        Me.TNombreCliente.TabIndex = 13
        '
        'TApellidoCliente
        '
        Me.TApellidoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoCliente.Location = New System.Drawing.Point(193, 136)
        Me.TApellidoCliente.Name = "TApellidoCliente"
        Me.TApellidoCliente.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoCliente.TabIndex = 12
        '
        'TDniCliente
        '
        Me.TDniCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniCliente.Location = New System.Drawing.Point(193, 26)
        Me.TDniCliente.MaxLength = 20
        Me.TDniCliente.Name = "TDniCliente"
        Me.TDniCliente.Size = New System.Drawing.Size(321, 13)
        Me.TDniCliente.TabIndex = 11
        '
        'LblDireccion
        '
        Me.LblDireccion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDireccion.Location = New System.Drawing.Point(30, 201)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(79, 20)
        Me.LblDireccion.TabIndex = 4
        Me.LblDireccion.Text = "Dirección:"
        Me.LblDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEmail
        '
        Me.LblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblEmail.Location = New System.Drawing.Point(30, 261)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(57, 20)
        Me.LblEmail.TabIndex = 3
        Me.LblEmail.Text = "E-mail:"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDNI
        '
        Me.LblDNI.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDNI.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDNI.Location = New System.Drawing.Point(30, 21)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(53, 20)
        Me.LblDNI.TabIndex = 2
        Me.LblDNI.Text = "D.N.I.:"
        Me.LblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellido
        '
        Me.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblApellido.Location = New System.Drawing.Point(30, 136)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(69, 20)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        Me.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombre.Location = New System.Drawing.Point(30, 74)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelAgregarCliente)
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
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'dialogCliente
        '
        Me.dialogCliente.FileName = "OpenFileDialog1"
        '
        'BtnCancelarCliente
        '
        Me.BtnCancelarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelarCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarCliente.FlatAppearance.BorderSize = 0
        Me.BtnCancelarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarCliente.Location = New System.Drawing.Point(552, 637)
        Me.BtnCancelarCliente.Name = "BtnCancelarCliente"
        Me.BtnCancelarCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarCliente.TabIndex = 7
        Me.BtnCancelarCliente.Text = "Cancelar"
        Me.BtnCancelarCliente.UseVisualStyleBackColor = True
        '
        'BtnAgregarCliente
        '
        Me.BtnAgregarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregarCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarCliente.FlatAppearance.BorderSize = 0
        Me.BtnAgregarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAgregarCliente.Location = New System.Drawing.Point(448, 637)
        Me.BtnAgregarCliente.Name = "BtnAgregarCliente"
        Me.BtnAgregarCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnAgregarCliente.TabIndex = 0
        Me.BtnAgregarCliente.Text = "Guardar"
        Me.BtnAgregarCliente.UseVisualStyleBackColor = True
        '
        'AgregarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelarCliente)
        Me.Controls.Add(Me.BtnAgregarCliente)
        Me.Controls.Add(Me.PanelAgregarCliente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AgregarCliente"
        Me.Text = "Form2"
        Me.PanelAgregarCliente.ResumeLayout(False)
        Me.PanelAgregarCliente.PerformLayout()
        CType(Me.PBAgregarCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelAgregarCliente As Label
    Friend WithEvents PanelAgregarCliente As Panel
    Friend WithEvents PBAgregarCliente As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TEmailCliente As TextBox
    Friend WithEvents TDireccionCliente As TextBox
    Friend WithEvents TNombreCliente As TextBox
    Friend WithEvents TApellidoCliente As TextBox
    Friend WithEvents TDniCliente As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents BtnAgregarCliente As Button
    Friend WithEvents BtnCancelarCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents dialogCliente As OpenFileDialog
End Class
