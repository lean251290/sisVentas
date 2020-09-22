<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Usuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Usuarios))
        Me.LUsuarios = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelAgregarUser = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DGUsuarios = New System.Windows.Forms.DataGridView()
        Me.CNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuario = New System.Windows.Forms.Label()
        Me.PanelAgregarUser.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUsuarios
        '
        Me.LUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LUsuarios.AutoSize = True
        Me.LUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LUsuarios.Location = New System.Drawing.Point(571, 9)
        Me.LUsuarios.Name = "LUsuarios"
        Me.LUsuarios.Size = New System.Drawing.Size(97, 25)
        Me.LUsuarios.TabIndex = 2
        Me.LUsuarios.Text = "Usuarios"
        Me.LUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'PanelAgregarUser
        '
        Me.PanelAgregarUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUser.BackColor = System.Drawing.Color.Transparent
        Me.PanelAgregarUser.BackgroundImage = CType(resources.GetObject("PanelAgregarUser.BackgroundImage"), System.Drawing.Image)
        Me.PanelAgregarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUser.Controls.Add(Me.PictureBox1)
        Me.PanelAgregarUser.Controls.Add(Me.DGUsuarios)
        Me.PanelAgregarUser.Controls.Add(Me.TBuscarUsuario)
        Me.PanelAgregarUser.Controls.Add(Me.LBuscarUsuario)
        Me.PanelAgregarUser.Location = New System.Drawing.Point(41, 55)
        Me.PanelAgregarUser.Name = "PanelAgregarUser"
        Me.PanelAgregarUser.Size = New System.Drawing.Size(627, 613)
        Me.PanelAgregarUser.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(518, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'DGUsuarios
        '
        Me.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNombre, Me.CApellido, Me.CDni, Me.CTelefono, Me.CDireccion, Me.Column1})
        Me.DGUsuarios.Location = New System.Drawing.Point(41, 105)
        Me.DGUsuarios.Name = "DGUsuarios"
        Me.DGUsuarios.Size = New System.Drawing.Size(543, 274)
        Me.DGUsuarios.TabIndex = 15
        '
        'CNombre
        '
        Me.CNombre.HeaderText = "Mail"
        Me.CNombre.Name = "CNombre"
        '
        'CApellido
        '
        Me.CApellido.HeaderText = "Nombre"
        Me.CApellido.Name = "CApellido"
        '
        'CDni
        '
        Me.CDni.HeaderText = "Apellido"
        Me.CDni.Name = "CDni"
        '
        'CTelefono
        '
        Me.CTelefono.HeaderText = "Telefono"
        Me.CTelefono.Name = "CTelefono"
        '
        'CDireccion
        '
        Me.CDireccion.HeaderText = "Direccion"
        Me.CDireccion.Name = "CDireccion"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Tipo Usuario"
        Me.Column1.Name = "Column1"
        '
        'TBuscarUsuario
        '
        Me.TBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarUsuario.Location = New System.Drawing.Point(102, 39)
        Me.TBuscarUsuario.Multiline = True
        Me.TBuscarUsuario.Name = "TBuscarUsuario"
        Me.TBuscarUsuario.Size = New System.Drawing.Size(400, 20)
        Me.TBuscarUsuario.TabIndex = 14
        '
        'LBuscarUsuario
        '
        Me.LBuscarUsuario.AutoSize = True
        Me.LBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarUsuario.Location = New System.Drawing.Point(37, 39)
        Me.LBuscarUsuario.Name = "LBuscarUsuario"
        Me.LBuscarUsuario.Size = New System.Drawing.Size(59, 20)
        Me.LBuscarUsuario.TabIndex = 1
        Me.LBuscarUsuario.Text = "Buscar"
        Me.LBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Usuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PanelAgregarUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Usuarios"
        Me.Text = "Form2"
        Me.PanelAgregarUser.ResumeLayout(False)
        Me.PanelAgregarUser.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUsuarios As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelAgregarUser As Panel
    Friend WithEvents LBuscarUsuario As Label
    Friend WithEvents TBuscarUsuario As TextBox
    Friend WithEvents DGUsuarios As DataGridView
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CApellido As DataGridViewTextBoxColumn
    Friend WithEvents CDni As DataGridViewTextBoxColumn
    Friend WithEvents CTelefono As DataGridViewTextBoxColumn
    Friend WithEvents CDireccion As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
