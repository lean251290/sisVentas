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
        Me.LabelTelCli = New System.Windows.Forms.Label()
        Me.LabelDireccionCli = New System.Windows.Forms.Label()
        Me.LabelEmailCliente = New System.Windows.Forms.Label()
        Me.LabelDniCliente = New System.Windows.Forms.Label()
        Me.TTelefonoCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.PanelAgregarCliente.Controls.Add(Me.LabelTelCli)
        Me.PanelAgregarCliente.Controls.Add(Me.LabelDireccionCli)
        Me.PanelAgregarCliente.Controls.Add(Me.LabelEmailCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.LabelDniCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.TTelefonoCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.Label1)
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
        Me.PanelAgregarCliente.Size = New System.Drawing.Size(600, 514)
        Me.PanelAgregarCliente.TabIndex = 5
        '
        'LabelTelCli
        '
        Me.LabelTelCli.AutoSize = True
        Me.LabelTelCli.ForeColor = System.Drawing.Color.Red
        Me.LabelTelCli.Location = New System.Drawing.Point(190, 331)
        Me.LabelTelCli.Name = "LabelTelCli"
        Me.LabelTelCli.Size = New System.Drawing.Size(279, 13)
        Me.LabelTelCli.TabIndex = 21
        Me.LabelTelCli.Text = "Teléfono inválido, ""Ejemplo: 3794015410 ú 1134236789"""
        '
        'LabelDireccionCli
        '
        Me.LabelDireccionCli.AutoSize = True
        Me.LabelDireccionCli.ForeColor = System.Drawing.Color.Red
        Me.LabelDireccionCli.Location = New System.Drawing.Point(190, 209)
        Me.LabelDireccionCli.Name = "LabelDireccionCli"
        Me.LabelDireccionCli.Size = New System.Drawing.Size(221, 13)
        Me.LabelDireccionCli.TabIndex = 20
        Me.LabelDireccionCli.Text = "Dirección inválida, ""Ejemplo: Mendoza 3267"""
        '
        'LabelEmailCliente
        '
        Me.LabelEmailCliente.AutoSize = True
        Me.LabelEmailCliente.ForeColor = System.Drawing.Color.Red
        Me.LabelEmailCliente.Location = New System.Drawing.Point(190, 269)
        Me.LabelEmailCliente.Name = "LabelEmailCliente"
        Me.LabelEmailCliente.Size = New System.Drawing.Size(154, 13)
        Me.LabelEmailCliente.TabIndex = 19
        Me.LabelEmailCliente.Text = "Ya existe un E-mail ingrese otro"
        '
        'LabelDniCliente
        '
        Me.LabelDniCliente.AutoSize = True
        Me.LabelDniCliente.ForeColor = System.Drawing.Color.Red
        Me.LabelDniCliente.Location = New System.Drawing.Point(190, 34)
        Me.LabelDniCliente.Name = "LabelDniCliente"
        Me.LabelDniCliente.Size = New System.Drawing.Size(154, 13)
        Me.LabelDniCliente.TabIndex = 18
        Me.LabelDniCliente.Text = "Ya existe un D.N.I. ingrese otro"
        '
        'TTelefonoCliente
        '
        Me.TTelefonoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTelefonoCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TTelefonoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTelefonoCliente.Location = New System.Drawing.Point(193, 315)
        Me.TTelefonoCliente.Name = "TTelefonoCliente"
        Me.TTelefonoCliente.Size = New System.Drawing.Size(321, 13)
        Me.TTelefonoCliente.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 308)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Telefono:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEmailCliente
        '
        Me.TEmailCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailCliente.Location = New System.Drawing.Point(193, 253)
        Me.TEmailCliente.Name = "TEmailCliente"
        Me.TEmailCliente.Size = New System.Drawing.Size(321, 13)
        Me.TEmailCliente.TabIndex = 15
        '
        'TDireccionCliente
        '
        Me.TDireccionCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionCliente.Location = New System.Drawing.Point(193, 193)
        Me.TDireccionCliente.Name = "TDireccionCliente"
        Me.TDireccionCliente.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionCliente.TabIndex = 14
        '
        'TNombreCliente
        '
        Me.TNombreCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreCliente.Location = New System.Drawing.Point(193, 71)
        Me.TNombreCliente.Name = "TNombreCliente"
        Me.TNombreCliente.Size = New System.Drawing.Size(321, 13)
        Me.TNombreCliente.TabIndex = 13
        '
        'TApellidoCliente
        '
        Me.TApellidoCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoCliente.Location = New System.Drawing.Point(193, 128)
        Me.TApellidoCliente.Name = "TApellidoCliente"
        Me.TApellidoCliente.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoCliente.TabIndex = 12
        '
        'TDniCliente
        '
        Me.TDniCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniCliente.Location = New System.Drawing.Point(193, 18)
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
        Me.LblDireccion.Location = New System.Drawing.Point(30, 193)
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
        Me.LblEmail.Location = New System.Drawing.Point(30, 253)
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
        Me.LblDNI.Location = New System.Drawing.Point(30, 13)
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
        Me.lblApellido.Location = New System.Drawing.Point(30, 128)
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
        Me.LblNombre.Location = New System.Drawing.Point(30, 66)
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
        Me.BtnCancelarCliente.TabStop = False
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
        Me.BtnAgregarCliente.TabStop = False
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
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelAgregarCliente As Label
    Friend WithEvents PanelAgregarCliente As Panel
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
    Friend WithEvents Label1 As Label
    Friend WithEvents TTelefonoCliente As TextBox
    Friend WithEvents LabelDniCliente As Label
    Friend WithEvents LabelEmailCliente As Label
    Friend WithEvents LabelDireccionCli As Label
    Friend WithEvents LabelTelCli As Label
End Class
