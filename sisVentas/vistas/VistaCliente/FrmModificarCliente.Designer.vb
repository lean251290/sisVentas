<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModificarCliente
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LabelModificarCliente = New System.Windows.Forms.Label()
        Me.PanelAgregarCliente = New System.Windows.Forms.Panel()
        Me.PBModifUsuario = New System.Windows.Forms.PictureBox()
        Me.LblFotoModifUsusario = New System.Windows.Forms.Label()
        Me.TEmailUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TDireccionUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TNombreUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TApellidoUsuarioModif = New System.Windows.Forms.TextBox()
        Me.TDniUsuarioModif = New System.Windows.Forms.TextBox()
        Me.LblDireccionModif = New System.Windows.Forms.Label()
        Me.LblEmailModif = New System.Windows.Forms.Label()
        Me.LblDNIModif = New System.Windows.Forms.Label()
        Me.lblApellidoModif = New System.Windows.Forms.Label()
        Me.LblNombreModif = New System.Windows.Forms.Label()
        Me.BtnActualizarCliente = New System.Windows.Forms.Button()
        Me.BtnCancelarCliente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregarCliente.SuspendLayout()
        CType(Me.PBModifUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelModificarCliente)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 9
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
        'LabelModificarCliente
        '
        Me.LabelModificarCliente.AutoSize = True
        Me.LabelModificarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LabelModificarCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelModificarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelModificarCliente.Location = New System.Drawing.Point(507, 0)
        Me.LabelModificarCliente.Name = "LabelModificarCliente"
        Me.LabelModificarCliente.Size = New System.Drawing.Size(173, 25)
        Me.LabelModificarCliente.TabIndex = 4
        Me.LabelModificarCliente.Text = "Modificar Cliente"
        Me.LabelModificarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelAgregarCliente
        '
        Me.PanelAgregarCliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarCliente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelAgregarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarCliente.Controls.Add(Me.PBModifUsuario)
        Me.PanelAgregarCliente.Controls.Add(Me.LblFotoModifUsusario)
        Me.PanelAgregarCliente.Controls.Add(Me.TEmailUsuarioModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TDireccionUsuarioModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TNombreUsuarioModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TApellidoUsuarioModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TDniUsuarioModif)
        Me.PanelAgregarCliente.Controls.Add(Me.LblDireccionModif)
        Me.PanelAgregarCliente.Controls.Add(Me.LblEmailModif)
        Me.PanelAgregarCliente.Controls.Add(Me.LblDNIModif)
        Me.PanelAgregarCliente.Controls.Add(Me.lblApellidoModif)
        Me.PanelAgregarCliente.Controls.Add(Me.LblNombreModif)
        Me.PanelAgregarCliente.Location = New System.Drawing.Point(40, 75)
        Me.PanelAgregarCliente.Name = "PanelAgregarCliente"
        Me.PanelAgregarCliente.Size = New System.Drawing.Size(600, 530)
        Me.PanelAgregarCliente.TabIndex = 10
        '
        'PBModifUsuario
        '
        Me.PBModifUsuario.BackColor = System.Drawing.Color.Gainsboro
        Me.PBModifUsuario.Location = New System.Drawing.Point(193, 321)
        Me.PBModifUsuario.Name = "PBModifUsuario"
        Me.PBModifUsuario.Size = New System.Drawing.Size(240, 177)
        Me.PBModifUsuario.TabIndex = 19
        Me.PBModifUsuario.TabStop = False
        '
        'LblFotoModifUsusario
        '
        Me.LblFotoModifUsusario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblFotoModifUsusario.AutoSize = True
        Me.LblFotoModifUsusario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFotoModifUsusario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblFotoModifUsusario.Location = New System.Drawing.Point(30, 321)
        Me.LblFotoModifUsusario.Name = "LblFotoModifUsusario"
        Me.LblFotoModifUsusario.Size = New System.Drawing.Size(46, 20)
        Me.LblFotoModifUsusario.TabIndex = 18
        Me.LblFotoModifUsusario.Text = "Foto:"
        Me.LblFotoModifUsusario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEmailUsuarioModif
        '
        Me.TEmailUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailUsuarioModif.Location = New System.Drawing.Point(193, 261)
        Me.TEmailUsuarioModif.Name = "TEmailUsuarioModif"
        Me.TEmailUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TEmailUsuarioModif.TabIndex = 15
        '
        'TDireccionUsuarioModif
        '
        Me.TDireccionUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionUsuarioModif.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionUsuarioModif.Name = "TDireccionUsuarioModif"
        Me.TDireccionUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionUsuarioModif.TabIndex = 14
        '
        'TNombreUsuarioModif
        '
        Me.TNombreUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreUsuarioModif.Location = New System.Drawing.Point(193, 21)
        Me.TNombreUsuarioModif.Name = "TNombreUsuarioModif"
        Me.TNombreUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TNombreUsuarioModif.TabIndex = 13
        '
        'TApellidoUsuarioModif
        '
        Me.TApellidoUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoUsuarioModif.Location = New System.Drawing.Point(193, 81)
        Me.TApellidoUsuarioModif.Name = "TApellidoUsuarioModif"
        Me.TApellidoUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoUsuarioModif.TabIndex = 12
        '
        'TDniUsuarioModif
        '
        Me.TDniUsuarioModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniUsuarioModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniUsuarioModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniUsuarioModif.Location = New System.Drawing.Point(193, 141)
        Me.TDniUsuarioModif.Name = "TDniUsuarioModif"
        Me.TDniUsuarioModif.Size = New System.Drawing.Size(321, 13)
        Me.TDniUsuarioModif.TabIndex = 11
        '
        'LblDireccionModif
        '
        Me.LblDireccionModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDireccionModif.AutoSize = True
        Me.LblDireccionModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDireccionModif.Location = New System.Drawing.Point(30, 201)
        Me.LblDireccionModif.Name = "LblDireccionModif"
        Me.LblDireccionModif.Size = New System.Drawing.Size(79, 20)
        Me.LblDireccionModif.TabIndex = 4
        Me.LblDireccionModif.Text = "Dirección:"
        Me.LblDireccionModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEmailModif
        '
        Me.LblEmailModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblEmailModif.AutoSize = True
        Me.LblEmailModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmailModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblEmailModif.Location = New System.Drawing.Point(30, 261)
        Me.LblEmailModif.Name = "LblEmailModif"
        Me.LblEmailModif.Size = New System.Drawing.Size(57, 20)
        Me.LblEmailModif.TabIndex = 3
        Me.LblEmailModif.Text = "E-mail:"
        Me.LblEmailModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDNIModif
        '
        Me.LblDNIModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDNIModif.AutoSize = True
        Me.LblDNIModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDNIModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDNIModif.Location = New System.Drawing.Point(30, 141)
        Me.LblDNIModif.Name = "LblDNIModif"
        Me.LblDNIModif.Size = New System.Drawing.Size(53, 20)
        Me.LblDNIModif.TabIndex = 2
        Me.LblDNIModif.Text = "D.N.I.:"
        Me.LblDNIModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellidoModif
        '
        Me.lblApellidoModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblApellidoModif.AutoSize = True
        Me.lblApellidoModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellidoModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblApellidoModif.Location = New System.Drawing.Point(30, 81)
        Me.lblApellidoModif.Name = "lblApellidoModif"
        Me.lblApellidoModif.Size = New System.Drawing.Size(69, 20)
        Me.lblApellidoModif.TabIndex = 1
        Me.lblApellidoModif.Text = "Apellido:"
        Me.lblApellidoModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombreModif
        '
        Me.LblNombreModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombreModif.AutoSize = True
        Me.LblNombreModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombreModif.Location = New System.Drawing.Point(30, 21)
        Me.LblNombreModif.Name = "LblNombreModif"
        Me.LblNombreModif.Size = New System.Drawing.Size(69, 20)
        Me.LblNombreModif.TabIndex = 0
        Me.LblNombreModif.Text = "Nombre:"
        Me.LblNombreModif.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnActualizarCliente
        '
        Me.BtnActualizarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnActualizarCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnActualizarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnActualizarCliente.FlatAppearance.BorderSize = 0
        Me.BtnActualizarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnActualizarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnActualizarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnActualizarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnActualizarCliente.Location = New System.Drawing.Point(439, 631)
        Me.BtnActualizarCliente.Name = "BtnActualizarCliente"
        Me.BtnActualizarCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnActualizarCliente.TabIndex = 12
        Me.BtnActualizarCliente.Text = "Actualizar"
        Me.BtnActualizarCliente.UseVisualStyleBackColor = True
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
        Me.BtnCancelarCliente.Location = New System.Drawing.Point(542, 631)
        Me.BtnCancelarCliente.Name = "BtnCancelarCliente"
        Me.BtnCancelarCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarCliente.TabIndex = 13
        Me.BtnCancelarCliente.Text = "Cancelar"
        Me.BtnCancelarCliente.UseVisualStyleBackColor = True
        '
        'FrmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelarCliente)
        Me.Controls.Add(Me.BtnActualizarCliente)
        Me.Controls.Add(Me.PanelAgregarCliente)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmModificarCliente"
        Me.Text = "FrmModificarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgregarCliente.ResumeLayout(False)
        Me.PanelAgregarCliente.PerformLayout()
        CType(Me.PBModifUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelModificarCliente As Label
    Friend WithEvents PanelAgregarCliente As Panel
    Friend WithEvents PBModifUsuario As PictureBox
    Friend WithEvents LblFotoModifUsusario As Label
    Friend WithEvents TEmailUsuarioModif As TextBox
    Friend WithEvents TDireccionUsuarioModif As TextBox
    Friend WithEvents TNombreUsuarioModif As TextBox
    Friend WithEvents TApellidoUsuarioModif As TextBox
    Friend WithEvents TDniUsuarioModif As TextBox
    Friend WithEvents LblDireccionModif As Label
    Friend WithEvents LblEmailModif As Label
    Friend WithEvents LblDNIModif As Label
    Friend WithEvents lblApellidoModif As Label
    Friend WithEvents LblNombreModif As Label
    Friend WithEvents BtnActualizarCliente As Button
    Friend WithEvents BtnCancelarCliente As Button
End Class
