<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PanelRepoVentaXUsuario
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelAgregarCliente = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelReportesVenta = New System.Windows.Forms.Panel()
        Me.DTPVentaXUsuarioHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPVentaXUsuarioDesde = New System.Windows.Forms.DateTimePicker()
        Me.LblHastaVentaXUsuario = New System.Windows.Forms.Label()
        Me.LblDesdeVentaXUsuario = New System.Windows.Forms.Label()
        Me.PBUsuarioReportes = New System.Windows.Forms.PictureBox()
        Me.TbReporteVentaXUsuario = New System.Windows.Forms.TextBox()
        Me.TexBoxTotalVentaXUsuarios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.PanelReporteVentaXUsuario = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelReportesVenta.SuspendLayout()
        CType(Me.PBUsuarioReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelAgregarCliente)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 0
        '
        'LabelAgregarCliente
        '
        Me.LabelAgregarCliente.AutoSize = True
        Me.LabelAgregarCliente.BackColor = System.Drawing.Color.Transparent
        Me.LabelAgregarCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelAgregarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAgregarCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelAgregarCliente.Location = New System.Drawing.Point(581, 0)
        Me.LabelAgregarCliente.Name = "LabelAgregarCliente"
        Me.LabelAgregarCliente.Size = New System.Drawing.Size(99, 25)
        Me.LabelAgregarCliente.TabIndex = 7
        Me.LabelAgregarCliente.Text = "Reportes"
        Me.LabelAgregarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(55, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 6
        Me.PictureBox2.TabStop = False
        '
        'PanelReportesVenta
        '
        Me.PanelReportesVenta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelReportesVenta.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelReportesVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelReportesVenta.Controls.Add(Me.DTPVentaXUsuarioHasta)
        Me.PanelReportesVenta.Controls.Add(Me.DTPVentaXUsuarioDesde)
        Me.PanelReportesVenta.Controls.Add(Me.LblHastaVentaXUsuario)
        Me.PanelReportesVenta.Controls.Add(Me.LblDesdeVentaXUsuario)
        Me.PanelReportesVenta.Controls.Add(Me.PBUsuarioReportes)
        Me.PanelReportesVenta.Controls.Add(Me.TbReporteVentaXUsuario)
        Me.PanelReportesVenta.Controls.Add(Me.TexBoxTotalVentaXUsuarios)
        Me.PanelReportesVenta.Controls.Add(Me.Label1)
        Me.PanelReportesVenta.Controls.Add(Me.LblNombre)
        Me.PanelReportesVenta.Controls.Add(Me.PanelReporteVentaXUsuario)
        Me.PanelReportesVenta.Location = New System.Drawing.Point(43, 107)
        Me.PanelReportesVenta.Name = "PanelReportesVenta"
        Me.PanelReportesVenta.Size = New System.Drawing.Size(600, 530)
        Me.PanelReportesVenta.TabIndex = 7
        '
        'DTPVentaXUsuarioHasta
        '
        Me.DTPVentaXUsuarioHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVentaXUsuarioHasta.Location = New System.Drawing.Point(378, 61)
        Me.DTPVentaXUsuarioHasta.Name = "DTPVentaXUsuarioHasta"
        Me.DTPVentaXUsuarioHasta.Size = New System.Drawing.Size(99, 20)
        Me.DTPVentaXUsuarioHasta.TabIndex = 22
        '
        'DTPVentaXUsuarioDesde
        '
        Me.DTPVentaXUsuarioDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVentaXUsuarioDesde.Location = New System.Drawing.Point(117, 60)
        Me.DTPVentaXUsuarioDesde.Name = "DTPVentaXUsuarioDesde"
        Me.DTPVentaXUsuarioDesde.Size = New System.Drawing.Size(99, 20)
        Me.DTPVentaXUsuarioDesde.TabIndex = 21
        '
        'LblHastaVentaXUsuario
        '
        Me.LblHastaVentaXUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblHastaVentaXUsuario.AutoSize = True
        Me.LblHastaVentaXUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHastaVentaXUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblHastaVentaXUsuario.Location = New System.Drawing.Point(316, 61)
        Me.LblHastaVentaXUsuario.Name = "LblHastaVentaXUsuario"
        Me.LblHastaVentaXUsuario.Size = New System.Drawing.Size(56, 20)
        Me.LblHastaVentaXUsuario.TabIndex = 20
        Me.LblHastaVentaXUsuario.Text = "Hasta:"
        Me.LblHastaVentaXUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDesdeVentaXUsuario
        '
        Me.LblDesdeVentaXUsuario.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblDesdeVentaXUsuario.AutoSize = True
        Me.LblDesdeVentaXUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDesdeVentaXUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblDesdeVentaXUsuario.Location = New System.Drawing.Point(55, 60)
        Me.LblDesdeVentaXUsuario.Name = "LblDesdeVentaXUsuario"
        Me.LblDesdeVentaXUsuario.Size = New System.Drawing.Size(60, 20)
        Me.LblDesdeVentaXUsuario.TabIndex = 19
        Me.LblDesdeVentaXUsuario.Text = "Desde:"
        Me.LblDesdeVentaXUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PBUsuarioReportes
        '
        Me.PBUsuarioReportes.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PBUsuarioReportes.Location = New System.Drawing.Point(480, 3)
        Me.PBUsuarioReportes.Name = "PBUsuarioReportes"
        Me.PBUsuarioReportes.Size = New System.Drawing.Size(74, 47)
        Me.PBUsuarioReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBUsuarioReportes.TabIndex = 16
        Me.PBUsuarioReportes.TabStop = False
        '
        'TbReporteVentaXUsuario
        '
        Me.TbReporteVentaXUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbReporteVentaXUsuario.Location = New System.Drawing.Point(132, 17)
        Me.TbReporteVentaXUsuario.Name = "TbReporteVentaXUsuario"
        Me.TbReporteVentaXUsuario.Size = New System.Drawing.Size(330, 20)
        Me.TbReporteVentaXUsuario.TabIndex = 15
        '
        'TexBoxTotalVentaXUsuarios
        '
        Me.TexBoxTotalVentaXUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TexBoxTotalVentaXUsuarios.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TexBoxTotalVentaXUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TexBoxTotalVentaXUsuarios.Location = New System.Drawing.Point(434, 484)
        Me.TexBoxTotalVentaXUsuarios.Name = "TexBoxTotalVentaXUsuarios"
        Me.TexBoxTotalVentaXUsuarios.Size = New System.Drawing.Size(120, 13)
        Me.TexBoxTotalVentaXUsuarios.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(305, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monto Total:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblNombre
        '
        Me.LblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblNombre.Location = New System.Drawing.Point(50, 17)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(76, 20)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Usuarios:"
        Me.LblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelReporteVentaXUsuario
        '
        Me.PanelReporteVentaXUsuario.BackColor = System.Drawing.Color.White
        Me.PanelReporteVentaXUsuario.ForeColor = System.Drawing.Color.Black
        Me.PanelReporteVentaXUsuario.Location = New System.Drawing.Point(54, 114)
        Me.PanelReporteVentaXUsuario.Name = "PanelReporteVentaXUsuario"
        Me.PanelReporteVentaXUsuario.Size = New System.Drawing.Size(500, 338)
        Me.PanelReporteVentaXUsuario.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(0, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 25)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Venta Por Usuario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'PanelRepoVentaXUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PanelReportesVenta)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PanelRepoVentaXUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form3"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelReportesVenta.ResumeLayout(False)
        Me.PanelReportesVenta.PerformLayout()
        CType(Me.PBUsuarioReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LabelAgregarCliente As Label
    Friend WithEvents PanelReportesVenta As Panel
    Friend WithEvents PanelReporteVentaXUsuario As Panel
    Friend WithEvents LblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TexBoxTotalVentaXUsuarios As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TbReporteVentaXUsuario As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents PBUsuarioReportes As PictureBox
    Friend WithEvents DTPVentaXUsuarioHasta As DateTimePicker
    Friend WithEvents DTPVentaXUsuarioDesde As DateTimePicker
    Friend WithEvents LblHastaVentaXUsuario As Label
    Friend WithEvents LblDesdeVentaXUsuario As Label
End Class
