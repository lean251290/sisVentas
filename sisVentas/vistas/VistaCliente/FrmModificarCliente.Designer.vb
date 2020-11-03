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
        Me.LabelDireccionCliModif = New System.Windows.Forms.Label()
        Me.LabelEmailClienteModif = New System.Windows.Forms.Label()
        Me.TTelefonoClienteModif = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.LabelEmailInvalido = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAgregarCliente.SuspendLayout()
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
        Me.PanelAgregarCliente.Controls.Add(Me.LabelEmailInvalido)
        Me.PanelAgregarCliente.Controls.Add(Me.LabelDireccionCliModif)
        Me.PanelAgregarCliente.Controls.Add(Me.LabelEmailClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.TTelefonoClienteModif)
        Me.PanelAgregarCliente.Controls.Add(Me.Label1)
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
        'LabelDireccionCliModif
        '
        Me.LabelDireccionCliModif.AutoSize = True
        Me.LabelDireccionCliModif.ForeColor = System.Drawing.Color.Red
        Me.LabelDireccionCliModif.Location = New System.Drawing.Point(190, 270)
        Me.LabelDireccionCliModif.Name = "LabelDireccionCliModif"
        Me.LabelDireccionCliModif.Size = New System.Drawing.Size(221, 13)
        Me.LabelDireccionCliModif.TabIndex = 104
        Me.LabelDireccionCliModif.Text = "Dirección inválida, ""Ejemplo: Mendoza 3267"""
        '
        'LabelEmailClienteModif
        '
        Me.LabelEmailClienteModif.AutoSize = True
        Me.LabelEmailClienteModif.ForeColor = System.Drawing.Color.Red
        Me.LabelEmailClienteModif.Location = New System.Drawing.Point(190, 212)
        Me.LabelEmailClienteModif.Name = "LabelEmailClienteModif"
        Me.LabelEmailClienteModif.Size = New System.Drawing.Size(154, 13)
        Me.LabelEmailClienteModif.TabIndex = 103
        Me.LabelEmailClienteModif.Text = "Ya existe un E-mail ingrese otro"
        '
        'TTelefonoClienteModif
        '
        Me.TTelefonoClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TTelefonoClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TTelefonoClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTelefonoClienteModif.Location = New System.Drawing.Point(193, 332)
        Me.TTelefonoClienteModif.Name = "TTelefonoClienteModif"
        Me.TTelefonoClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TTelefonoClienteModif.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(30, 332)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Telefono:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TEmailClienteModif
        '
        Me.TEmailClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TEmailClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TEmailClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TEmailClienteModif.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TEmailClienteModif.Location = New System.Drawing.Point(193, 196)
        Me.TEmailClienteModif.Name = "TEmailClienteModif"
        Me.TEmailClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TEmailClienteModif.TabIndex = 0
        '
        'TDireccionClienteModif
        '
        Me.TDireccionClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDireccionClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDireccionClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDireccionClienteModif.Location = New System.Drawing.Point(193, 254)
        Me.TDireccionClienteModif.Name = "TDireccionClienteModif"
        Me.TDireccionClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TDireccionClienteModif.TabIndex = 2
        '
        'TNombreClienteModif
        '
        Me.TNombreClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TNombreClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TNombreClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TNombreClienteModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TNombreClienteModif.Location = New System.Drawing.Point(193, 76)
        Me.TNombreClienteModif.Name = "TNombreClienteModif"
        Me.TNombreClienteModif.ReadOnly = True
        Me.TNombreClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TNombreClienteModif.TabIndex = 100
        '
        'TApellidoClienteModif
        '
        Me.TApellidoClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TApellidoClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TApellidoClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TApellidoClienteModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TApellidoClienteModif.Location = New System.Drawing.Point(193, 136)
        Me.TApellidoClienteModif.Name = "TApellidoClienteModif"
        Me.TApellidoClienteModif.ReadOnly = True
        Me.TApellidoClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TApellidoClienteModif.TabIndex = 101
        '
        'TDniClienteModif
        '
        Me.TDniClienteModif.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TDniClienteModif.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TDniClienteModif.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TDniClienteModif.Cursor = System.Windows.Forms.Cursors.No
        Me.TDniClienteModif.Location = New System.Drawing.Point(193, 21)
        Me.TDniClienteModif.MaxLength = 15
        Me.TDniClienteModif.Name = "TDniClienteModif"
        Me.TDniClienteModif.ReadOnly = True
        Me.TDniClienteModif.Size = New System.Drawing.Size(321, 13)
        Me.TDniClienteModif.TabIndex = 102
        '
        'LblDireccionModif
        '
        Me.LblDireccionModif.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDireccionModif.AutoSize = True
        Me.LblDireccionModif.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDireccionModif.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDireccionModif.Location = New System.Drawing.Point(30, 254)
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
        Me.LblEmailModif.Location = New System.Drawing.Point(30, 196)
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
        Me.LblDNIModif.Location = New System.Drawing.Point(30, 16)
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
        Me.lblApellidoModif.Location = New System.Drawing.Point(30, 136)
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
        Me.LblNombreModif.Location = New System.Drawing.Point(30, 76)
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
        Me.BtnCancelarCliente.TabIndex = 5
        Me.BtnCancelarCliente.TabStop = False
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
        Me.BtnActualizarCliente.TabIndex = 4
        Me.BtnActualizarCliente.TabStop = False
        Me.BtnActualizarCliente.Text = "Actualizar"
        Me.BtnActualizarCliente.UseVisualStyleBackColor = True
        '
        'dialogModifCli
        '
        Me.dialogModifCli.FileName = "OpenFileDialog1"
        '
        'LabelEmailInvalido
        '
        Me.LabelEmailInvalido.AutoSize = True
        Me.LabelEmailInvalido.ForeColor = System.Drawing.Color.Red
        Me.LabelEmailInvalido.Location = New System.Drawing.Point(190, 212)
        Me.LabelEmailInvalido.Name = "LabelEmailInvalido"
        Me.LabelEmailInvalido.Size = New System.Drawing.Size(137, 13)
        Me.LabelEmailInvalido.TabIndex = 105
        Me.LabelEmailInvalido.Text = "Dirección de E-mail inválida"
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
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmModificarCliente"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAgregarCliente.ResumeLayout(False)
        Me.PanelAgregarCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelModificarCliente As Label
    Friend WithEvents PanelAgregarCliente As Panel
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
    Friend WithEvents TTelefonoClienteModif As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelEmailClienteModif As Label
    Friend WithEvents LabelDireccionCliModif As Label
    Friend WithEvents LabelEmailInvalido As Label
End Class
