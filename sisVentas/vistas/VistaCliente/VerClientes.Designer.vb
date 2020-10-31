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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelVerCliente = New System.Windows.Forms.Label()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.PanelVerClientes = New System.Windows.Forms.Panel()
        Me.DGVerClientes = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnModificarCliente = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelVerClientes.SuspendLayout()
        CType(Me.DGVerClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVerCliente
        '
        Me.LabelVerCliente.AutoSize = True
        Me.LabelVerCliente.BackColor = System.Drawing.Color.Transparent
        Me.LabelVerCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelVerCliente.Location = New System.Drawing.Point(545, 0)
        Me.LabelVerCliente.Name = "LabelVerCliente"
        Me.LabelVerCliente.Size = New System.Drawing.Size(135, 25)
        Me.LabelVerCliente.TabIndex = 1
        Me.LabelVerCliente.Text = "Ver Clientes "
        Me.LabelVerCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarCliente.Location = New System.Drawing.Point(46, 46)
        Me.LBuscarCliente.Name = "LBuscarCliente"
        Me.LBuscarCliente.Size = New System.Drawing.Size(62, 20)
        Me.LBuscarCliente.TabIndex = 0
        Me.LBuscarCliente.Text = "Cliente:"
        Me.LBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TBuscarCliente
        '
        Me.TBuscarCliente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarCliente.Location = New System.Drawing.Point(122, 51)
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(374, 13)
        Me.TBuscarCliente.TabIndex = 13
        '
        'PanelVerClientes
        '
        Me.PanelVerClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerClientes.Controls.Add(Me.DGVerClientes)
        Me.PanelVerClientes.Controls.Add(Me.PictureBox1)
        Me.PanelVerClientes.Controls.Add(Me.TBuscarCliente)
        Me.PanelVerClientes.Controls.Add(Me.LBuscarCliente)
        Me.PanelVerClientes.Location = New System.Drawing.Point(50, 159)
        Me.PanelVerClientes.Name = "PanelVerClientes"
        Me.PanelVerClientes.Size = New System.Drawing.Size(600, 466)
        Me.PanelVerClientes.TabIndex = 5
        '
        'DGVerClientes
        '
        Me.DGVerClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVerClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVerClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DGVerClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DGVerClientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DGVerClientes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DGVerClientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVerClientes.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVerClientes.ColumnHeadersHeight = 28
        Me.DGVerClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGVerClientes.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGVerClientes.EnableHeadersVisualStyles = False
        Me.DGVerClientes.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DGVerClientes.Location = New System.Drawing.Point(22, 101)
        Me.DGVerClientes.Name = "DGVerClientes"
        Me.DGVerClientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DGVerClientes.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.DGVerClientes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DGVerClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVerClientes.Size = New System.Drawing.Size(560, 325)
        Me.DGVerClientes.TabIndex = 18
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBox1.Location = New System.Drawing.Point(509, 36)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'BtnModificarCliente
        '
        Me.BtnModificarCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModificarCliente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnModificarCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificarCliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnModificarCliente.FlatAppearance.BorderSize = 0
        Me.BtnModificarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificarCliente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnModificarCliente.Location = New System.Drawing.Point(550, 631)
        Me.BtnModificarCliente.Name = "BtnModificarCliente"
        Me.BtnModificarCliente.Size = New System.Drawing.Size(98, 37)
        Me.BtnModificarCliente.TabIndex = 6
        Me.BtnModificarCliente.Text = "Modificar"
        Me.BtnModificarCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelVerCliente)
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
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'VerClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnModificarCliente)
        Me.Controls.Add(Me.PanelVerClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerClientes"
        Me.Text = "Form1"
        Me.PanelVerClientes.ResumeLayout(False)
        Me.PanelVerClientes.PerformLayout()
        CType(Me.DGVerClientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelVerCliente As Label
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents PanelVerClientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnModificarCliente As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DGVerClientes As DataGridView
End Class
