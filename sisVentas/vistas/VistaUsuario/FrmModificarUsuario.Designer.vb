﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarUsuario
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
        Me.PanelAgregarUsuario = New System.Windows.Forms.Panel()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelModificarUsuarios = New System.Windows.Forms.Label()
        Me.BtnActualizarUser = New System.Windows.Forms.Button()
        Me.BtnCancelarUser = New System.Windows.Forms.Button()
        Me.PanelAgregarUsuario.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelAgregarUsuario.Controls.Add(Me.PictureBox1)
        Me.PanelAgregarUsuario.Controls.Add(Me.Label2)
        Me.PanelAgregarUsuario.Controls.Add(Me.TRePassUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TPassUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TEmailUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDireccionUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TNombreUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TApellidoUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.TDniUsuario)
        Me.PanelAgregarUsuario.Controls.Add(Me.Lblrepetir)
        Me.PanelAgregarUsuario.Controls.Add(Me.LblPass)
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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelAgregarUsuario As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TRePassUsuario As TextBox
    Friend WithEvents TPassUsuario As TextBox
    Friend WithEvents TEmailUsuario As TextBox
    Friend WithEvents TDireccionUsuario As TextBox
    Friend WithEvents TNombreUsuario As TextBox
    Friend WithEvents TApellidoUsuario As TextBox
    Friend WithEvents TDniUsuario As TextBox
    Friend WithEvents Lblrepetir As Label
    Friend WithEvents LblPass As Label
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
End Class