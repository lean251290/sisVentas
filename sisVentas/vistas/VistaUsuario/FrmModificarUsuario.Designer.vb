<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmModificarUsuario
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
        Me.PanelAgregarUsuario = New System.Windows.Forms.Panel()
        Me.LabelEmailUser = New System.Windows.Forms.Label()
        Me.LabelDirModifUser = New System.Windows.Forms.Label()
        Me.PBUserModif = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TEmailUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TDniUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TDireccionUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TNombreUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TApellidoUsuarioModif = New System.Windows.Forms.TextBox()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelModificarUsuarios = New System.Windows.Forms.Label()
        Me.BtnActualizarUser = New System.Windows.Forms.Button()
        Me.BtnCancelarUser = New System.Windows.Forms.Button()
        Me.DialogModificarUsuario = New System.Windows.Forms.OpenFileDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PanelAgregarUsuario.SuspendLayout()
        CType(Me.PBUserModif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelAgregarUsuario
        '
        Me.PanelAgregarUsuario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelEmailUser)
        Me.PanelAgregarUsuario.Controls.Add(Me.LabelDirModifUser)
        Me.PanelAgregarUsuario.Controls.Add(Me.PBUserModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.Label2)
        Me.PanelAgregarUsuario.Controls.Add(Me.TEmailUsuarioModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDniUsuarioModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDireccionUsuarioModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.TNombreUsuarioModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.TApellidoUsuarioModif)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblDireccion)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblEmail)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblDNI)
        Me.PanelAgregarUsuario.Controls.Add(Me.lblApellido)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblNombre)
        Me.PanelAgregarUsuario.Location = New System.Drawing.Point(40, 75)
        Me.PanelAgregarUsuario.Name = "PanelAgregarUsuario"
        Me.PanelAgregarUsuario.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarUsuario.TabIndex = 5
        '
        'LabelEmailUser
        '
        Me.LabelEmailUser.AutoSize = True
        Me.LabelEmailUser.ForeColor = System.Drawing.Color.Red
        Me.LabelEmailUser.Location = New System.Drawing.Point(190, 277)
        Me.LabelEmailUser.Name = "LabelEmailUser"
        Me.LabelEmailUser.Size = New System.Drawing.Size(154, 13)
        Me.LabelEmailUser.TabIndex = 106
        Me.LabelEmailUser.Text = "Ya existe un E-mail ingrese otro"
        '
        'LabelDirModifUser
        '
        Me.LabelDirModifUser.AutoSize = True
        Me.LabelDirModifUser.ForeColor = System.Drawing.Color.Red
        Me.LabelDirModifUser.Location = New System.Drawing.Point(190, 217)
        Me.LabelDirModifUser.Name = "LabelDirModifUser"
        Me.LabelDirModifUser.Size = New System.Drawing.Size(221, 13)
        Me.LabelDirModifUser.TabIndex = 105
        Me.LabelDirModifUser.Text = "Dirección inválida, ""Ejemplo: Mendoza 3267"""
        '
        'PBUserModif
        '
        Me.PBUserModif.BackColor = System.Drawing.Color.Gainsboro
        Me.PBUserModif.Location = New System.Drawing.Point(181, 321)
        Me.PBUserModif.Name = "PBUserModif"
        Me.PBUserModif.Size = New System.Drawing.Size(238, 173)
        Me.PBUserModif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBUserModif.TabIndex = 19
        Me.PBUserModif.TabStop = False
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
        'TEmailUsuarioModif
        '
        Me.TEmailUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailUsuarioModif.Location = New System.Drawing.Point(193, 261)
        Me.TEmailUsuarioModif.Name = "TEmailUsuarioModif"
        Me.TEmailUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TEmailUsuarioModif.TabIndex = 1
        '
        'TDniUsuarioModif
        '
        Me.TDniUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniUsuarioModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TDniUsuarioModif.Location = New System.Drawing.Point(193, 21)
        Me.TDniUsuarioModif.MaxLength = 15
        Me.TDniUsuarioModif.Name = "TDniUsuarioModif"
        Me.TDniUsuarioModif.ReadOnly = True
        Me.TDniUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TDniUsuarioModif.TabIndex = 11
        '
        'TDireccionUsuarioModif
        '
        Me.TDireccionUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionUsuarioModif.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionUsuarioModif.Name = "TDireccionUsuarioModif"
        Me.TDireccionUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionUsuarioModif.TabIndex = 0
        '
        'TNombreUsuarioModif
        '
        Me.TNombreUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreUsuarioModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TNombreUsuarioModif.Location = New System.Drawing.Point(193, 76)
        Me.TNombreUsuarioModif.Name = "TNombreUsuarioModif"
        Me.TNombreUsuarioModif.ReadOnly = True
        Me.TNombreUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TNombreUsuarioModif.TabIndex = 13
        '
        'TApellidoUsuarioModif
        '
        Me.TApellidoUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoUsuarioModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TApellidoUsuarioModif.Location = New System.Drawing.Point(193, 141)
        Me.TApellidoUsuarioModif.Name = "TApellidoUsuarioModif"
        Me.TApellidoUsuarioModif.ReadOnly = True
        Me.TApellidoUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoUsuarioModif.TabIndex = 12
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
        Me.LblDNI.Location = New System.Drawing.Point(30, 16)
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
        Me.LblNombre.Location = New System.Drawing.Point(30, 76)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelModificarUsuarios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 49)
        Me.Panel1.TabIndex = 6
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 49)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'LabelModificarUsuarios
        '
        Me.LabelModificarUsuarios.AutoSize = True
        Me.LabelModificarUsuarios.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelModificarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModificarUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelModificarUsuarios.Location = New System.Drawing.Point(500, 0)
        Me.LabelModificarUsuarios.Name = "LabelModificarUsuarios"
        Me.LabelModificarUsuarios.Size = New System.Drawing.Size(180, 25)
        Me.LabelModificarUsuarios.TabIndex = 6
        Me.LabelModificarUsuarios.Text = "Modificar Usuario"
        Me.LabelModificarUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnActualizarUser
        '
        Me.BtnActualizarUser.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnActualizarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizarUser.FlatAppearance.BorderSize = 0
        Me.BtnActualizarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualizarUser.Location = New System.Drawing.Point(436, 632)
        Me.BtnActualizarUser.Name = "BtnActualizarUser"
        Me.BtnActualizarUser.Size = New System.Drawing.Size(98, 37)
        Me.BtnActualizarUser.TabIndex = 7
        Me.BtnActualizarUser.Text = "Actualizar"
        Me.BtnActualizarUser.UseVisualStyleBackColor = True
        '
        'BtnCancelarUser
        '
        Me.BtnCancelarUser.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarUser.FlatAppearance.BorderSize = 0
        Me.BtnCancelarUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarUser.Location = New System.Drawing.Point(542, 632)
        Me.BtnCancelarUser.Name = "BtnCancelarUser"
        Me.BtnCancelarUser.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarUser.TabIndex = 8
        Me.BtnCancelarUser.Text = "Cancelar"
        Me.BtnCancelarUser.UseVisualStyleBackColor = True
        '
        'DialogModificarUsuario
        '
        Me.DialogModificarUsuario.FileName = "OpenFileDialog1"
        '
        'FrmModificarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelarUser)
        Me.Controls.Add(Me.BtnActualizarUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelAgregarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarUsuario"
        Me.PanelAgregarUsuario.ResumeLayout(False)
        Me.PanelAgregarUsuario.PerformLayout()
        CType(Me.PBUserModif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAgregarUsuario As Panel
    Friend WithEvents PBUserModif As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TEmailUsuarioModif As TextBox
    Friend WithEvents TDireccionUsuarioModif As TextBox
    Friend WithEvents TNombreUsuarioModif As TextBox
    Friend WithEvents TApellidoUsuarioModif As TextBox
    Friend WithEvents TDniUsuarioModif As TextBox
    Friend WithEvents LblDireccion As Label
    Friend WithEvents LblEmail As Label
    Friend WithEvents LblDNI As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents LblNombre As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelModificarUsuarios As Label
    Friend WithEvents BtnActualizarUser As Button
    Friend WithEvents BtnCancelarUser As Button
    Friend WithEvents DialogModificarUsuario As OpenFileDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents LabelDirModifUser As Label
    Friend WithEvents LabelEmailUser As Label
End Class
