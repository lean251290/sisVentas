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
        Me.PBModifCliente = New System.Windows.Forms.PictureBox()
        Me.LblFotoModifUsusario = New System.Windows.Forms.Label()
        Me.TEmailClienteModif = New System.Windows.Forms.TextBox()
        Me.TDireccionClienteModif = New System.Windows.Forms.TextBox()
        Me.TNombreClienteModif = New System.Windows.Forms.TextBox()
        Me.TApellidoClienteModif = New System.Windows.Forms.TextBox()
        Me.TDniClienteModif = New System.Windows.Forms.TextBox()
        Me.LblDireccionModif = New System.Windows.Forms.Label()
        Me.LblEmailModif = New System.Windows.Forms.Label()
        Me.LblDNIModif = New System.Windows.Forms.Label()
        Me.lblApellidoModif = New System.Windows.Forms.Label()
        Me.LblNombreModif = New System.Windows.Forms.Label()
        Me.BtnCancelarCliente = New System.Windows.Forms.Button()
        Me.BtnActualizarCliente = New System.Windows.Forms.Button()
        Me.dialogModifCli = New System.Windows.Forms.OpenFileDialog()
        Me.BtnAltaCliente = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregarCliente.SuspendLayout()
        CType(Me.PBModifCliente, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelAgregarCliente.Controls.Add(Me.PBModifCliente)
        Me.PanelAgregarCliente.Controls.Add(Me.LblFotoModifUsusario)
        Me.PanelAgregarCliente.Controls.Add(Me.TEmailClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TDireccionClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TNombreClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TApellidoClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TDniClienteModif)
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
        'PBModifCliente
        '
        Me.PBModifCliente.BackColor = System.Drawing.Color.Gainsboro
        Me.PBModifCliente.Image = Global.sisVentas.My.Resources.Resources.user1
        Me.PBModifCliente.Location = New System.Drawing.Point(193, 321)
        Me.PBModifCliente.Name = "PBModifCliente"
        Me.PBModifCliente.Size = New System.Drawing.Size(166, 134)
        Me.PBModifCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PBModifCliente.TabIndex = 19
        Me.PBModifCliente.TabStop = False
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
        'TEmailClienteModif
        '
        Me.TEmailClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailClienteModif.Location = New System.Drawing.Point(193, 261)
        Me.TEmailClienteModif.Name = "TEmailClienteModif"
        Me.TEmailClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TEmailClienteModif.TabIndex = 15
        '
        'TDireccionClienteModif
        '
        Me.TDireccionClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionClienteModif.Location = New System.Drawing.Point(193, 201)
        Me.TDireccionClienteModif.Name = "TDireccionClienteModif"
        Me.TDireccionClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionClienteModif.TabIndex = 14
        '
        'TNombreClienteModif
        '
        Me.TNombreClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreClienteModif.Location = New System.Drawing.Point(193, 21)
        Me.TNombreClienteModif.Name = "TNombreClienteModif"
        Me.TNombreClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TNombreClienteModif.TabIndex = 13
        '
        'TApellidoClienteModif
        '
        Me.TApellidoClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoClienteModif.Location = New System.Drawing.Point(193, 81)
        Me.TApellidoClienteModif.Name = "TApellidoClienteModif"
        Me.TApellidoClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoClienteModif.TabIndex = 12
        '
        'TDniClienteModif
        '
        Me.TDniClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniClienteModif.Location = New System.Drawing.Point(193, 141)
        Me.TDniClienteModif.Name = "TDniClienteModif"
        Me.TDniClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TDniClienteModif.TabIndex = 11
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
        Me.BtnCancelarCliente.TabIndex = 4
        Me.BtnCancelarCliente.Text = "Cancelar"
        Me.BtnCancelarCliente.UseVisualStyleBackColor = True
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
        Me.BtnActualizarCliente.TabIndex = 5
        Me.BtnActualizarCliente.Text = "Actualizar"
        Me.BtnActualizarCliente.UseVisualStyleBackColor = True
        '
        'dialogModifCli
        '
        Me.dialogModifCli.FileName = "OpenFileDialog1"
        '
        'BtnAltaCliente
        '
        Me.BtnAltaCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAltaCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAltaCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAltaCliente.FlatAppearance.BorderSize = 0
        Me.BtnAltaCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAltaCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAltaCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAltaCliente.Location = New System.Drawing.Point(40, 631)
        Me.BtnAltaCliente.Name = "BtnAltaCliente"
        Me.BtnAltaCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnAltaCliente.TabIndex = 11
        Me.BtnAltaCliente.Text = "Alta"
        Me.BtnAltaCliente.UseVisualStyleBackColor = True
        '
        'FrmModificarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnAltaCliente)
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
        CType(Me.PBModifCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelModificarCliente As Label
    Friend WithEvents PanelAgregarCliente As Panel
    Friend WithEvents PBModifCliente As PictureBox
    Friend WithEvents LblFotoModifUsusario As Label
    Friend WithEvents TEmailClienteModif As TextBox
    Friend WithEvents TDireccionClienteModif As TextBox
    Friend WithEvents TNombreClienteModif As TextBox
    Friend WithEvents TApellidoClienteModif As TextBox
    Friend WithEvents TDniClienteModif As TextBox
    Friend WithEvents LblDireccionModif As Label
    Friend WithEvents LblEmailModif As Label
    Friend WithEvents LblDNIModif As Label
    Friend WithEvents lblApellidoModif As Label
    Friend WithEvents LblNombreModif As Label
    Friend WithEvents BtnActualizarCliente As Button
    Friend WithEvents BtnCancelarCliente As Button
    Friend WithEvents dialogModifCli As OpenFileDialog
    Friend WithEvents BtnAltaCliente As Button
End Class
