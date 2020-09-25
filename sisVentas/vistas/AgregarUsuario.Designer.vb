<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Agregar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Usuario))
        Me.LblAgregarUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAgregarUser = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TRePassUsuario = New System.Windows.Forms.TextBox()
        Me.TPassUsuario = New System.Windows.Forms.TextBox()
        Me.TEmailUsuario = New System.Windows.Forms.TextBox()
        Me.TDireccionUsuario = New System.Windows.Forms.TextBox()
        Me.TNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.TDniUsuario = New System.Windows.Forms.TextBox()
        Me.Lblrepetir = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.BtnAgregarUsuario = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.PanelAgregarUser.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAgregarUsuario
        '
        Me.LblAgregarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAgregarUsuario.AutoSize = True
        Me.LblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblAgregarUsuario.Location = New System.Drawing.Point(502, 9)
        Me.LblAgregarUsuario.Name = "LblAgregarUsuario"
        Me.LblAgregarUsuario.Size = New System.Drawing.Size(168, 25)
        Me.LblAgregarUsuario.TabIndex = 0
        Me.LblAgregarUsuario.Text = "Agregar Usuario"
        Me.LblAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "X"
        '
        'PanelAgregarUser
        '
        Me.PanelAgregarUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUser.Controls.Add(Me.PictureBox1)
        Me.PanelAgregarUser.Controls.Add(Me.Label2)
        Me.PanelAgregarUser.Controls.Add(Me.TRePassUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TPassUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TEmailUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TDireccionUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TNombreUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TApellidoUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.TDniUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.Lblrepetir)
        Me.PanelAgregarUser.Controls.Add(Me.LblPass)
        Me.PanelAgregarUser.Controls.Add(Me.LblDireccion)
        Me.PanelAgregarUser.Controls.Add(Me.LblEmail)
        Me.PanelAgregarUser.Controls.Add(Me.LblDNI)
        Me.PanelAgregarUser.Controls.Add(Me.lblApellido)
        Me.PanelAgregarUser.Controls.Add(Me.LblNombre)
        Me.PanelAgregarUser.Location = New System.Drawing.Point(50, 90)
        Me.PanelAgregarUser.Name = "PanelAgregarUser"
        Me.PanelAgregarUser.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarUser.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.PictureBox1.Location = New System.Drawing.Point(193, 428)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 94)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(30, 429)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Foto:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TRePassUsuario
        '
        Me.TRePassUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TRePassUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TRePassUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TRePassUsuario.Location = New System.Drawing.Point(193, 381)
        Me.TRePassUsuario.Name = "TRePassUsuario"
        Me.TRePassUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TRePassUsuario.TabIndex = 17
        '
        'TPassUsuario
        '
        Me.TPassUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPassUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TPassUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPassUsuario.Location = New System.Drawing.Point(193, 321)
        Me.TPassUsuario.Name = "TPassUsuario"
        Me.TPassUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TPassUsuario.TabIndex = 16
        '
        'TEmailUsuario
        '
        Me.TEmailUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailUsuario.Location = New System.Drawing.Point(193, 261)
        Me.TEmailUsuario.Name = "TEmailUsuario"
        Me.TEmailUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TEmailUsuario.TabIndex = 15
        '
        'TDireccionUsuario
        '
        Me.TDireccionUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionUsuario.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionUsuario.Name = "TDireccionUsuario"
        Me.TDireccionUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionUsuario.TabIndex = 14
        '
        'TNombreUsuario
        '
        Me.TNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreUsuario.Location = New System.Drawing.Point(193, 21)
        Me.TNombreUsuario.Name = "TNombreUsuario"
        Me.TNombreUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TNombreUsuario.TabIndex = 13
        '
        'TApellidoUsuario
        '
        Me.TApellidoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoUsuario.Location = New System.Drawing.Point(193, 81)
        Me.TApellidoUsuario.Name = "TApellidoUsuario"
        Me.TApellidoUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoUsuario.TabIndex = 12
        '
        'TDniUsuario
        '
        Me.TDniUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniUsuario.Location = New System.Drawing.Point(193, 141)
        Me.TDniUsuario.Name = "TDniUsuario"
        Me.TDniUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TDniUsuario.TabIndex = 11
        '
        'Lblrepetir
        '
        Me.Lblrepetir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lblrepetir.AutoSize = True
        Me.Lblrepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrepetir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lblrepetir.Location = New System.Drawing.Point(30, 381)
        Me.Lblrepetir.Name = "Lblrepetir"
        Me.Lblrepetir.Size = New System.Drawing.Size(152, 20)
        Me.Lblrepetir.TabIndex = 6
        Me.Lblrepetir.Text = "Repetir Contraseña:"
        Me.Lblrepetir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPass
        '
        Me.LblPass.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblPass.AutoSize = True
        Me.LblPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPass.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblPass.Location = New System.Drawing.Point(30, 321)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(96, 20)
        Me.LblPass.TabIndex = 5
        Me.LblPass.Text = "Contraseña:"
        Me.LblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.LblDNI.Location = New System.Drawing.Point(30, 141)
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
        Me.lblApellido.Location = New System.Drawing.Point(30, 81)
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
        Me.LblNombre.Location = New System.Drawing.Point(30, 21)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnAgregarUsuario
        '
        Me.BtnAgregarUsuario.BackgroundImage = CType(resources.GetObject("BtnAgregarUsuario.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAgregarUsuario.Location = New System.Drawing.Point(368, 625)
        Me.BtnAgregarUsuario.Name = "BtnAgregarUsuario"
        Me.BtnAgregarUsuario.Size = New System.Drawing.Size(110, 43)
        Me.BtnAgregarUsuario.TabIndex = 5
        Me.BtnAgregarUsuario.Text = "Agregar"
        Me.BtnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'BtnCancelar
        '
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelar.Location = New System.Drawing.Point(507, 625)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 43)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregarUsuario)
        Me.Controls.Add(Me.PanelAgregarUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAgregarUsuario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_Usuario"
        Me.Text = "Agregar_Usuario"
        Me.PanelAgregarUser.ResumeLayout(False)
        Me.PanelAgregarUser.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAgregarUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelAgregarUser As Panel
    Friend WithEvents LblPass As Label
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents Lblrepetir As Label
    Friend WithEvents TNombreUsuario As TextBox
    Friend WithEvents TApellidoUsuario As TextBox
    Friend WithEvents TDniUsuario As TextBox
    Friend WithEvents TRePassUsuario As TextBox
    Friend WithEvents TPassUsuario As TextBox
    Friend WithEvents TEmailUsuario As TextBox
    Friend WithEvents TDireccionUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnAgregarUsuario As Button
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
