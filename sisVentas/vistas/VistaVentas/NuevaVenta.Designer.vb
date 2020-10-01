<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevaVenta
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
        Me.LabelNuevaVenta = New System.Windows.Forms.Label()
        Me.PanelVerClientes = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblBuscarProd = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TBuscarCliente = New System.Windows.Forms.TextBox()
        Me.LBuscarCliente = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnVender = New System.Windows.Forms.Button()
        Me.BtnCancelarVenta = New System.Windows.Forms.Button()
        Me.PanelVerClientes.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelNuevaVenta
        '
        Me.LabelNuevaVenta.AutoSize = True
        Me.LabelNuevaVenta.BackColor = System.Drawing.Color.Transparent
        Me.LabelNuevaVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelNuevaVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNuevaVenta.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelNuevaVenta.Location = New System.Drawing.Point(544, 0)
        Me.LabelNuevaVenta.Name = "LabelNuevaVenta"
        Me.LabelNuevaVenta.Size = New System.Drawing.Size(136, 25)
        Me.LabelNuevaVenta.TabIndex = 5
        Me.LabelNuevaVenta.Text = "Nueva Venta"
        Me.LabelNuevaVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelVerClientes
        '
        Me.PanelVerClientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerClientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerClientes.Controls.Add(Me.Label2)
        Me.PanelVerClientes.Controls.Add(Me.Label6)
        Me.PanelVerClientes.Controls.Add(Me.Label5)
        Me.PanelVerClientes.Controls.Add(Me.TextBox2)
        Me.PanelVerClientes.Controls.Add(Me.Label4)
        Me.PanelVerClientes.Controls.Add(Me.Label3)
        Me.PanelVerClientes.Controls.Add(Me.Label1)
        Me.PanelVerClientes.Controls.Add(Me.DataGridView2)
        Me.PanelVerClientes.Controls.Add(Me.PictureBox3)
        Me.PanelVerClientes.Controls.Add(Me.TextBox1)
        Me.PanelVerClientes.Controls.Add(Me.LblBuscarProd)
        Me.PanelVerClientes.Controls.Add(Me.PictureBox1)
        Me.PanelVerClientes.Controls.Add(Me.TBuscarCliente)
        Me.PanelVerClientes.Controls.Add(Me.LBuscarCliente)
        Me.PanelVerClientes.Location = New System.Drawing.Point(47, 70)
        Me.PanelVerClientes.Name = "PanelVerClientes"
        Me.PanelVerClientes.Size = New System.Drawing.Size(600, 555)
        Me.PanelVerClientes.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(219, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "____________________"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(219, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(189, 20)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "____________________"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(219, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(189, 20)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "____________________"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(174, 203)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(322, 20)
        Me.TextBox2.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(37, 203)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 20)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cantidad:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(30, 282)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Detalle de la Venta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(219, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "____________________"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView2
        '
        Me.DataGridView2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(43, 305)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(500, 225)
        Me.DataGridView2.TabIndex = 23
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBox3.Location = New System.Drawing.Point(500, 111)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(174, 121)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(322, 20)
        Me.TextBox1.TabIndex = 20
        '
        'LblBuscarProd
        '
        Me.LblBuscarProd.AutoSize = True
        Me.LblBuscarProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarProd.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblBuscarProd.Location = New System.Drawing.Point(37, 121)
        Me.LblBuscarProd.Name = "LblBuscarProd"
        Me.LblBuscarProd.Size = New System.Drawing.Size(131, 20)
        Me.LblBuscarProd.TabIndex = 19
        Me.LblBuscarProd.Text = "Buscar Producto:"
        Me.LblBuscarProd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBox1.Location = New System.Drawing.Point(502, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 17
        Me.PictureBox1.TabStop = False
        '
        'TBuscarCliente
        '
        Me.TBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TBuscarCliente.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarCliente.Location = New System.Drawing.Point(124, 42)
        Me.TBuscarCliente.Multiline = True
        Me.TBuscarCliente.Name = "TBuscarCliente"
        Me.TBuscarCliente.Size = New System.Drawing.Size(372, 20)
        Me.TBuscarCliente.TabIndex = 13
        '
        'LBuscarCliente
        '
        Me.LBuscarCliente.AutoSize = True
        Me.LBuscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarCliente.Location = New System.Drawing.Point(37, 42)
        Me.LBuscarCliente.Name = "LBuscarCliente"
        Me.LBuscarCliente.Size = New System.Drawing.Size(78, 20)
        Me.LBuscarCliente.TabIndex = 0
        Me.LBuscarCliente.Text = "Vender a:"
        Me.LBuscarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.LabelNuevaVenta)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(53, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'BtnVender
        '
        Me.BtnVender.BackColor = System.Drawing.Color.Transparent
        Me.BtnVender.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnVender.FlatAppearance.BorderSize = 0
        Me.BtnVender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnVender.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnVender.Location = New System.Drawing.Point(445, 631)
        Me.BtnVender.Name = "BtnVender"
        Me.BtnVender.Size = New System.Drawing.Size(98, 37)
        Me.BtnVender.TabIndex = 9
        Me.BtnVender.Text = "Vender"
        Me.BtnVender.UseVisualStyleBackColor = False
        '
        'BtnCancelarVenta
        '
        Me.BtnCancelarVenta.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarVenta.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarVenta.FlatAppearance.BorderSize = 0
        Me.BtnCancelarVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnCancelarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarVenta.Location = New System.Drawing.Point(549, 631)
        Me.BtnCancelarVenta.Name = "BtnCancelarVenta"
        Me.BtnCancelarVenta.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarVenta.TabIndex = 10
        Me.BtnCancelarVenta.Text = "Cancelar"
        Me.BtnCancelarVenta.UseVisualStyleBackColor = False
        '
        'NuevaVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnCancelarVenta)
        Me.Controls.Add(Me.BtnVender)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelVerClientes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NuevaVenta"
        Me.Text = "Form6"
        Me.PanelVerClientes.ResumeLayout(False)
        Me.PanelVerClientes.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LabelNuevaVenta As Label
    Friend WithEvents PanelVerClientes As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TBuscarCliente As TextBox
    Friend WithEvents LBuscarCliente As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblBuscarProd As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents BtnVender As Button
    Friend WithEvents BtnCancelarVenta As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
End Class
