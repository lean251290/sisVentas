<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.LblAgregarUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.PanelAgregarUser = New System.Windows.Forms.Panel()
        Me.DGClientes = New System.Windows.Forms.DataGridView()
        Me.CNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CApellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CDireccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelAgregarUser.SuspendLayout()
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblAgregarUsuario
        '
        Me.LblAgregarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAgregarUsuario.AutoSize = True
        Me.LblAgregarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAgregarUsuario.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LblAgregarUsuario.Location = New System.Drawing.Point(692, 9)
        Me.LblAgregarUsuario.Name = "LblAgregarUsuario"
        Me.LblAgregarUsuario.Size = New System.Drawing.Size(96, 25)
        Me.LblAgregarUsuario.TabIndex = 1
        Me.LblAgregarUsuario.Text = "Clientes "
        Me.LblAgregarUsuario.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LBuscarCliente.Location = New System.Drawing.Point(85, 19)
        Me.LBuscarCliente.Name = "LBuscarCliente"
        Me.LBuscarCliente.Size = New System.Drawing.Size(59, 20)
        Me.LBuscarCliente.TabIndex = 0
        Me.LBuscarCliente.Text = "Buscar"
        Me.LBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TBuscarCliente
        '
        Me.TBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBuscarCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarCliente.Location = New System.Drawing.Point(167, 26)
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(444, 13)
        Me.TBuscarCliente.TabIndex = 13
        '
        'PanelAgregarUser
        '
        Me.PanelAgregarUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelAgregarUser.BackColor = System.Drawing.Color.White
        Me.PanelAgregarUser.BackgroundImage = CType(resources.GetObject("PanelAgregarUser.BackgroundImage"), System.Drawing.Image)
        Me.PanelAgregarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelAgregarUser.Controls.Add(Me.DGClientes)
        Me.PanelAgregarUser.Controls.Add(Me.TBuscarCliente)
        Me.PanelAgregarUser.Controls.Add(Me.LBuscarCliente)
        Me.PanelAgregarUser.Location = New System.Drawing.Point(41, 55)
        Me.PanelAgregarUser.Name = "PanelAgregarUser"
        Me.PanelAgregarUser.Size = New System.Drawing.Size(747, 383)
        Me.PanelAgregarUser.TabIndex = 5
        '
        'DGClientes
        '
        Me.DGClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGClientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CNombre, Me.CApellido, Me.CDni, Me.CTelefono, Me.CDireccion})
        Me.DGClientes.Location = New System.Drawing.Point(89, 76)
        Me.DGClientes.Name = "DGClientes"
        Me.DGClientes.Size = New System.Drawing.Size(544, 274)
        Me.DGClientes.TabIndex = 14
        '
        'CNombre
        '
        Me.CNombre.HeaderText = "Nombre"
        Me.CNombre.Name = "CNombre"
        '
        'CApellido
        '
        Me.CApellido.HeaderText = "Apellido"
        Me.CApellido.Name = "CApellido"
        '
        'CDni
        '
        Me.CDni.HeaderText = "DNI"
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
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelAgregarUser)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAgregarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Clientes"
        Me.Text = "Form1"
        Me.PanelAgregarUser.ResumeLayout(False)
        Me.PanelAgregarUser.PerformLayout()
        CType(Me.DGClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAgregarUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents PanelAgregarUser As Panel
    Friend WithEvents DGClientes As DataGridView
    Friend WithEvents CNombre As DataGridViewTextBoxColumn
    Friend WithEvents CApellido As DataGridViewTextBoxColumn
    Friend WithEvents CDni As DataGridViewTextBoxColumn
    Friend WithEvents CTelefono As DataGridViewTextBoxColumn
    Friend WithEvents CDireccion As DataGridViewTextBoxColumn
End Class
