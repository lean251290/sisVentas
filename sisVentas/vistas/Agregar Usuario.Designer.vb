<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Agregar_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Agregar_Usuario))
        Me.LblAgregarUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnAgregarUser = New System.Windows.Forms.Button()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.PanelAgregarUser = New System.Windows.Forms.Panel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
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
        Me.PanelAgregarUser.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblAgregarUsuario
        '
        Me.LblAgregarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAgregarUsuario.AutoSize = True
        Me.LblAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LblAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblAgregarUsuario.Location = New System.Drawing.Point(512, 9)
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
        'BtnAgregarUser
        '
        Me.BtnAgregarUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregarUser.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarUser.BackgroundImage = CType(resources.GetObject("BtnAgregarUser.BackgroundImage"), System.Drawing.Image)
        Me.BtnAgregarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarUser.FlatAppearance.BorderSize = 0
        Me.BtnAgregarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnAgregarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnAgregarUser.Location = New System.Drawing.Point(339, 600)
        Me.BtnAgregarUser.Name = "BtnAgregarUser"
        Me.BtnAgregarUser.Size = New System.Drawing.Size(181, 40)
        Me.BtnAgregarUser.TabIndex = 2
        Me.BtnAgregarUser.Text = "AGREGAR USUARIO"
        Me.BtnAgregarUser.UseVisualStyleBackColor = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BtnCancelar.Location = New System.Drawing.Point(539, 600)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(110, 40)
        Me.BtnCancelar.TabIndex = 3
        Me.BtnCancelar.Text = "CANCELAR"
        Me.BtnCancelar.UseVisualStyleBackColor = False
        '
        'PanelAgregarUser
        '
        Me.PanelAgregarUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUser.BackColor = System.Drawing.Color.Transparent
        Me.PanelAgregarUser.BackgroundImage = CType(resources.GetObject("PanelAgregarUser.BackgroundImage"), System.Drawing.Image)
        Me.PanelAgregarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUser.Controls.Add(Me.TextBox4)
        Me.PanelAgregarUser.Controls.Add(Me.TextBox3)
        Me.PanelAgregarUser.Controls.Add(Me.TextBox2)
        Me.PanelAgregarUser.Controls.Add(Me.TextBox1)
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
        Me.PanelAgregarUser.Location = New System.Drawing.Point(29, 55)
        Me.PanelAgregarUser.Name = "PanelAgregarUser"
        Me.PanelAgregarUser.Size = New System.Drawing.Size(638, 526)
        Me.PanelAgregarUser.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox4.Location = New System.Drawing.Point(176, 423)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(359, 13)
        Me.TextBox4.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox3.Location = New System.Drawing.Point(176, 363)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(359, 13)
        Me.TextBox3.TabIndex = 16
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(176, 319)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(359, 13)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(176, 262)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(359, 13)
        Me.TextBox1.TabIndex = 14
        '
        'TNombreUsuario
        '
        Me.TNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreUsuario.Location = New System.Drawing.Point(176, 90)
        Me.TNombreUsuario.Name = "TNombreUsuario"
        Me.TNombreUsuario.Size = New System.Drawing.Size(359, 13)
        Me.TNombreUsuario.TabIndex = 13
        '
        'TApellidoUsuario
        '
        Me.TApellidoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoUsuario.Location = New System.Drawing.Point(176, 141)
        Me.TApellidoUsuario.Name = "TApellidoUsuario"
        Me.TApellidoUsuario.Size = New System.Drawing.Size(359, 13)
        Me.TApellidoUsuario.TabIndex = 12
        '
        'TDniUsuario
        '
        Me.TDniUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniUsuario.Location = New System.Drawing.Point(176, 191)
        Me.TDniUsuario.Name = "TDniUsuario"
        Me.TDniUsuario.Size = New System.Drawing.Size(359, 13)
        Me.TDniUsuario.TabIndex = 11
        '
        'Lblrepetir
        '
        Me.Lblrepetir.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lblrepetir.AutoSize = True
        Me.Lblrepetir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblrepetir.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Lblrepetir.Location = New System.Drawing.Point(13, 418)
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
        Me.LblPass.Location = New System.Drawing.Point(13, 363)
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
        Me.LblDireccion.Location = New System.Drawing.Point(13, 257)
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
        Me.LblEmail.Location = New System.Drawing.Point(13, 314)
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
        Me.LblDNI.Location = New System.Drawing.Point(13, 191)
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
        Me.lblApellido.Location = New System.Drawing.Point(13, 139)
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
        Me.LblNombre.Location = New System.Drawing.Point(13, 88)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PanelAgregarUser)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.BtnAgregarUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAgregarUsuario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_Usuario"
        Me.Text = "Agregar_Usuario"
        Me.PanelAgregarUser.ResumeLayout(False)
        Me.PanelAgregarUser.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAgregarUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnAgregarUser As Button
    Friend WithEvents BtnCancelar As Button
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
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
