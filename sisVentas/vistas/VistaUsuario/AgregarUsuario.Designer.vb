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
        Me.LabelAgregarUsuario = New System.Windows.Forms.Label()
        Me.PanelAgregarUsuario = New System.Windows.Forms.Panel()
        Me.LabelVerifEmail = New System.Windows.Forms.Label()
        Me.LabelDniNumeros = New System.Windows.Forms.Label()
        Me.LabelPass = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelDNI = New System.Windows.Forms.Label()
        Me.LblPassNoCoincide = New System.Windows.Forms.Label()
        Me.CMPerfil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PBUser = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TRePassUsuario = New System.Windows.Forms.TextBox()
        Me.TPassUsuario = New System.Windows.Forms.TextBox()
        Me.TNombreUsuario = New System.Windows.Forms.TextBox()
        Me.TEmailUsuario = New System.Windows.Forms.TextBox()
        Me.TDireccionUsuario = New System.Windows.Forms.TextBox()
        Me.TApellidoUsuario = New System.Windows.Forms.TextBox()
        Me.TDniUsuario = New System.Windows.Forms.TextBox()
        Me.Lblrepetir = New System.Windows.Forms.Label()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCancelar = New System.Windows.Forms.Button()
        Me.dialogUser = New System.Windows.Forms.OpenFileDialog()
        Me.BtnAgregarUsuario = New System.Windows.Forms.Button()
        Me.PanelAgregarUsuario.SuspendLayout()
        CType(Me.PBUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelAgregarUsuario
        '
        Me.LabelAgregarUsuario.AutoSize = True
        Me.LabelAgregarUsuario.BackColor = System.Drawing.Color.Transparent
        Me.LabelAgregarUsuario.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAgregarUsuario.Location = New System.Drawing.Point(512, 0)
        Me.LabelAgregarUsuario.Name = "LabelAgregarUsuario"
        Me.LabelAgregarUsuario.Size = New System.Drawing.Size(168, 25)
        Me.LabelAgregarUsuario.TabIndex = 0
        Me.LabelAgregarUsuario.Text = "Agregar Usuario"
        Me.LabelAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelAgregarUsuario
        '
        Me.PanelAgregarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelVerifEmail)
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelDniNumeros)
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelPass)
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelEmail)
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelDNI)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblPassNoCoincide)
        Me.PanelAgregarUsuario.Controls.Add(Me.CMPerfil)
        Me.PanelAgregarUsuario.Controls.Add(Me.Label1)
        Me.PanelAgregarUsuario.Controls.Add(Me.PBUser)
        Me.PanelAgregarUsuario.Controls.Add(Me.Label2)
        Me.PanelAgregarUsuario.Controls.Add(Me.TRePassUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TPassUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TNombreUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TEmailUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDireccionUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TApellidoUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDniUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.Lblrepetir)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblPass)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblDireccion)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblEmail)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblDNI)
        Me.PanelAgregarUsuario.Controls.Add(Me.lblApellido)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblNombre)
        Me.PanelAgregarUsuario.Location = New System.Drawing.Point(50, 90)
        Me.PanelAgregarUsuario.Name = "PanelAgregarUsuario"
        Me.PanelAgregarUsuario.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarUsuario.TabIndex = 4
        '
        'LabelVerifEmail
        '
        Me.LabelVerifEmail.AutoSize = True
        Me.LabelVerifEmail.ForeColor = System.Drawing.Color.Red
        Me.LabelVerifEmail.Location = New System.Drawing.Point(193, 277)
        Me.LabelVerifEmail.Name = "LabelVerifEmail"
        Me.LabelVerifEmail.Size = New System.Drawing.Size(133, 13)
        Me.LabelVerifEmail.TabIndex = 27
        Me.LabelVerifEmail.Text = "Ya existe nombre de e-mail"
        '
        'LabelDniNumeros
        '
        Me.LabelDniNumeros.AutoSize = True
        Me.LabelDniNumeros.ForeColor = System.Drawing.Color.Red
        Me.LabelDniNumeros.Location = New System.Drawing.Point(190, 44)
        Me.LabelDniNumeros.Name = "LabelDniNumeros"
        Me.LabelDniNumeros.Size = New System.Drawing.Size(165, 13)
        Me.LabelDniNumeros.TabIndex = 26
        Me.LabelDniNumeros.Text = "El D.N.I. contiene solo 8 números"
        '
        'LabelPass
        '
        Me.LabelPass.AutoSize = True
        Me.LabelPass.ForeColor = System.Drawing.Color.Red
        Me.LabelPass.Location = New System.Drawing.Point(190, 337)
        Me.LabelPass.Name = "LabelPass"
        Me.LabelPass.Size = New System.Drawing.Size(100, 13)
        Me.LabelPass.TabIndex = 25
        Me.LabelPass.Text = "Contraseña inválida"
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.ForeColor = System.Drawing.Color.Red
        Me.LabelEmail.Location = New System.Drawing.Point(190, 277)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(136, 13)
        Me.LabelEmail.TabIndex = 24
        Me.LabelEmail.Text = "Dirección de e-mail inválido"
        '
        'LabelDNI
        '
        Me.LabelDNI.AutoSize = True
        Me.LabelDNI.ForeColor = System.Drawing.Color.Red
        Me.LabelDNI.Location = New System.Drawing.Point(190, 44)
        Me.LabelDNI.Name = "LabelDNI"
        Me.LabelDNI.Size = New System.Drawing.Size(131, 13)
        Me.LabelDNI.TabIndex = 23
        Me.LabelDNI.Text = "Ya existe ese N° de D.N.I."
        '
        'LblPassNoCoincide
        '
        Me.LblPassNoCoincide.AutoSize = True
        Me.LblPassNoCoincide.ForeColor = System.Drawing.Color.Red
        Me.LblPassNoCoincide.Location = New System.Drawing.Point(190, 397)
        Me.LblPassNoCoincide.Name = "LblPassNoCoincide"
        Me.LblPassNoCoincide.Size = New System.Drawing.Size(149, 13)
        Me.LblPassNoCoincide.TabIndex = 22
        Me.LblPassNoCoincide.Text = "Las contraseñas no coinciden"
        '
        'CMPerfil
        '
        Me.CMPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMPerfil.FormattingEnabled = True
        Me.CMPerfil.Location = New System.Drawing.Point(393, 431)
        Me.CMPerfil.Name = "CMPerfil"
        Me.CMPerfil.Size = New System.Drawing.Size(121, 21)
        Me.CMPerfil.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(325, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Perfil:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBUser
        '
        Me.PBUser.Image = Global.sisVentas.My.Resources.Resources.user1
        Me.PBUser.Location = New System.Drawing.Point(193, 429)
        Me.PBUser.Name = "PBUser"
        Me.PBUser.Size = New System.Drawing.Size(126, 86)
        Me.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBUser.TabIndex = 19
        Me.PBUser.TabStop = False
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
        Me.TRePassUsuario.TabIndex = 7
        Me.TRePassUsuario.UseSystemPasswordChar = True
        '
        'TPassUsuario
        '
        Me.TPassUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TPassUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TPassUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TPassUsuario.Location = New System.Drawing.Point(193, 321)
        Me.TPassUsuario.Name = "TPassUsuario"
        Me.TPassUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TPassUsuario.TabIndex = 6
        Me.TPassUsuario.UseSystemPasswordChar = True
        '
        'TNombreUsuario
        '
        Me.TNombreUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreUsuario.Location = New System.Drawing.Point(193, 79)
        Me.TNombreUsuario.Name = "TNombreUsuario"
        Me.TNombreUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TNombreUsuario.TabIndex = 1
        '
        'TEmailUsuario
        '
        Me.TEmailUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailUsuario.Location = New System.Drawing.Point(193, 261)
        Me.TEmailUsuario.Name = "TEmailUsuario"
        Me.TEmailUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TEmailUsuario.TabIndex = 5
        '
        'TDireccionUsuario
        '
        Me.TDireccionUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionUsuario.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionUsuario.Name = "TDireccionUsuario"
        Me.TDireccionUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionUsuario.TabIndex = 4
        '
        'TApellidoUsuario
        '
        Me.TApellidoUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoUsuario.Location = New System.Drawing.Point(193, 139)
        Me.TApellidoUsuario.Name = "TApellidoUsuario"
        Me.TApellidoUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoUsuario.TabIndex = 2
        '
        'TDniUsuario
        '
        Me.TDniUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniUsuario.Location = New System.Drawing.Point(193, 28)
        Me.TDniUsuario.MaxLength = 15
        Me.TDniUsuario.Name = "TDniUsuario"
        Me.TDniUsuario.Size = New System.Drawing.Size(321, 13)
        Me.TDniUsuario.TabIndex = 3
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
        Me.lblApellido.Location = New System.Drawing.Point(30, 134)
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
        Me.Panel1.Controls.Add(Me.LabelAgregarUsuario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCancelar.BackgroundImage = CType(resources.GetObject("BtnCancelar.BackgroundImage"), System.Drawing.Image)
        Me.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancelar.FlatAppearance.BorderSize = 0
        Me.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelar.Location = New System.Drawing.Point(552, 631)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelar.TabIndex = 10
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'dialogUser
        '
        Me.dialogUser.FileName = "OpenFileDialog1"
        '
        'BtnAgregarUsuario
        '
        Me.BtnAgregarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAgregarUsuario.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnAgregarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAgregarUsuario.Location = New System.Drawing.Point(448, 631)
        Me.BtnAgregarUsuario.Name = "BtnAgregarUsuario"
        Me.BtnAgregarUsuario.Size = New System.Drawing.Size(98, 37)
        Me.BtnAgregarUsuario.TabIndex = 9
        Me.BtnAgregarUsuario.Text = "Guardar"
        Me.BtnAgregarUsuario.UseVisualStyleBackColor = True
        '
        'Agregar_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnAgregarUsuario)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.PanelAgregarUsuario)
        Me.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Agregar_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar_Usuario"
        Me.PanelAgregarUsuario.ResumeLayout(False)
        Me.PanelAgregarUsuario.PerformLayout()
        CType(Me.PBUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelAgregarUsuario As Label
    Friend WithEvents PanelAgregarUsuario As Panel
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
    Friend WithEvents BtnCancelar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PBUser As PictureBox
    Friend WithEvents dialogUser As OpenFileDialog
    Friend WithEvents BtnAgregarUsuario As Button
    Friend WithEvents CMPerfil As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPassNoCoincide As Label
    Friend WithEvents LabelDNI As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelPass As Label
    Friend WithEvents LabelDniNumeros As Label
    Friend WithEvents LabelVerifEmail As Label
End Class
