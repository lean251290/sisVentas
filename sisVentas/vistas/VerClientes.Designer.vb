<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerClientes
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
        Me.LblAgregarUsuario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.PanelBuscarClientes = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelBuscarClientes.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.LblAgregarUsuario.Location = New System.Drawing.Point(572, 9)
        Me.LblAgregarUsuario.Name = "LblAgregarUsuario"
        Me.LblAgregarUsuario.Size = New System.Drawing.Size(96, 25)
        Me.LblAgregarUsuario.TabIndex = 1
        Me.LblAgregarUsuario.Text = "Clientes "
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
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarCliente.Location = New System.Drawing.Point(46, 46)
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
        Me.TBuscarCliente.Location = New System.Drawing.Point(122, 46)
        Me.TBuscarCliente.Multiline = True
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(374, 20)
        Me.TBuscarCliente.TabIndex = 13
        '
        'PanelBuscarClientes
        '
        Me.PanelBuscarClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelBuscarClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelBuscarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelBuscarClientes.Controls.Add(Me.DataGridView1)
        Me.PanelBuscarClientes.Controls.Add(Me.PictureBox1)
        Me.PanelBuscarClientes.Controls.Add(Me.TBuscarCliente)
        Me.PanelBuscarClientes.Controls.Add(Me.LBuscarCliente)
        Me.PanelBuscarClientes.Location = New System.Drawing.Point(50, 90)
        Me.PanelBuscarClientes.Name = "PanelBuscarClientes"
        Me.PanelBuscarClientes.Size = New System.Drawing.Size(600, 530)
        Me.PanelBuscarClientes.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 200)
        Me.DataGridView1.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBox1.Location = New System.Drawing.Point(509, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'VerClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PanelBuscarClientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblAgregarUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerClientes"
        Me.Text = "Form1"
        Me.PanelBuscarClientes.ResumeLayout(False)
        Me.PanelBuscarClientes.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblAgregarUsuario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents PanelBuscarClientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
