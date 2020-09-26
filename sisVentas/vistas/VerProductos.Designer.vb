<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerProductos
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
        Me.PanelVerProductos = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelVerProducto = New System.Windows.Forms.Label()
        Me.PanelVerProductos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelVerProductos
        '
        Me.PanelVerProductos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerProductos.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerProductos.Controls.Add(Me.DataGridView1)
        Me.PanelVerProductos.Controls.Add(Me.PictureBox1)
        Me.PanelVerProductos.Controls.Add(Me.TBuscarCliente)
        Me.PanelVerProductos.Controls.Add(Me.LBuscarCliente)
        Me.PanelVerProductos.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerProductos.Name = "PanelVerProductos"
        Me.PanelVerProductos.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerProductos.TabIndex = 6
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "X"
        '
        'LabelVerProducto
        '
        Me.LabelVerProducto.AutoSize = True
        Me.LabelVerProducto.BackColor = System.Drawing.Color.Transparent
        Me.LabelVerProducto.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerProducto.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelVerProducto.Location = New System.Drawing.Point(571, 0)
        Me.LabelVerProducto.Name = "LabelVerProducto"
        Me.LabelVerProducto.Size = New System.Drawing.Size(109, 25)
        Me.LabelVerProducto.TabIndex = 8
        Me.LabelVerProducto.Text = "Productos"
        Me.LabelVerProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VerProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.LabelVerProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelVerProductos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerProductos"
        Me.Text = "Form2"
        Me.PanelVerProductos.ResumeLayout(False)
        Me.PanelVerProductos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelVerProductos As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVerProducto As Label
End Class
