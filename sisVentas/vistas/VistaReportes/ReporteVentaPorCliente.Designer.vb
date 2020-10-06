<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteVentaPorCliente
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
        Me.LblReporteVentaXCliente = New System.Windows.Forms.Label()
        Me.PanelReportes = New System.Windows.Forms.Panel()
        Me.PBReporteVentaXCliente = New System.Windows.Forms.PictureBox()
        Me.TbReporteVentaXCliente = New System.Windows.Forms.TextBox()
        Me.TexBoxTotalUsuarios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblCliente = New System.Windows.Forms.Label()
        Me.PanelReporteVentaXCliente = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelReporteVentaXCliente = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PanelReportes.SuspendLayout()
        CType(Me.PBReporteVentaXCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblReporteVentaXCliente
        '
        Me.LblReporteVentaXCliente.AutoSize = True
        Me.LblReporteVentaXCliente.BackColor = System.Drawing.Color.Transparent
        Me.LblReporteVentaXCliente.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblReporteVentaXCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReporteVentaXCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblReporteVentaXCliente.Location = New System.Drawing.Point(0, 50)
        Me.LblReporteVentaXCliente.Name = "LblReporteVentaXCliente"
        Me.LblReporteVentaXCliente.Size = New System.Drawing.Size(180, 25)
        Me.LblReporteVentaXCliente.TabIndex = 11
        Me.LblReporteVentaXCliente.Text = "Venta Por Cliente"
        Me.LblReporteVentaXCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelReportes
        '
        Me.PanelReportes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelReportes.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelReportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelReportes.Controls.Add(Me.PBReporteVentaXCliente)
        Me.PanelReportes.Controls.Add(Me.TbReporteVentaXCliente)
        Me.PanelReportes.Controls.Add(Me.TexBoxTotalUsuarios)
        Me.PanelReportes.Controls.Add(Me.Label1)
        Me.PanelReportes.Controls.Add(Me.LblCliente)
        Me.PanelReportes.Controls.Add(Me.PanelReporteVentaXCliente)
        Me.PanelReportes.Location = New System.Drawing.Point(39, 109)
        Me.PanelReportes.Name = "PanelReportes"
        Me.PanelReportes.Size = New System.Drawing.Size(600, 530)
        Me.PanelReportes.TabIndex = 10
        '
        'PBReporteVentaXCliente
        '
        Me.PBReporteVentaXCliente.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PBReporteVentaXCliente.Location = New System.Drawing.Point(480, 3)
        Me.PBReporteVentaXCliente.Name = "PBReporteVentaXCliente"
        Me.PBReporteVentaXCliente.Size = New System.Drawing.Size(74, 47)
        Me.PBReporteVentaXCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBReporteVentaXCliente.TabIndex = 16
        Me.PBReporteVentaXCliente.TabStop = False
        '
        'TbReporteVentaXCliente
        '
        Me.TbReporteVentaXCliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbReporteVentaXCliente.Location = New System.Drawing.Point(132, 17)
        Me.TbReporteVentaXCliente.Name = "TbReporteVentaXCliente"
        Me.TbReporteVentaXCliente.Size = New System.Drawing.Size(330, 20)
        Me.TbReporteVentaXCliente.TabIndex = 15
        '
        'TexBoxTotalUsuarios
        '
        Me.TexBoxTotalUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TexBoxTotalUsuarios.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TexBoxTotalUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TexBoxTotalUsuarios.Location = New System.Drawing.Point(445, 484)
        Me.TexBoxTotalUsuarios.Name = "TexBoxTotalUsuarios"
        Me.TexBoxTotalUsuarios.Size = New System.Drawing.Size(120, 13)
        Me.TexBoxTotalUsuarios.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(34, 484)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Monto Total:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCliente
        '
        Me.LblCliente.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblCliente.AutoSize = True
        Me.LblCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblCliente.Location = New System.Drawing.Point(50, 17)
        Me.LblCliente.Name = "LblCliente"
        Me.LblCliente.Size = New System.Drawing.Size(62, 20)
        Me.LblCliente.TabIndex = 1
        Me.LblCliente.Text = "Cliente:"
        Me.LblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelReporteVentaXCliente
        '
        Me.PanelReporteVentaXCliente.BackColor = System.Drawing.Color.White
        Me.PanelReporteVentaXCliente.ForeColor = System.Drawing.Color.Black
        Me.PanelReporteVentaXCliente.Location = New System.Drawing.Point(54, 52)
        Me.PanelReporteVentaXCliente.Name = "PanelReporteVentaXCliente"
        Me.PanelReporteVentaXCliente.Size = New System.Drawing.Size(500, 400)
        Me.PanelReporteVentaXCliente.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelReporteVentaXCliente)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(664, 50)
        Me.Panel1.TabIndex = 9
        '
        'LabelReporteVentaXCliente
        '
        Me.LabelReporteVentaXCliente.AutoSize = True
        Me.LabelReporteVentaXCliente.BackColor = System.Drawing.Color.Transparent
        Me.LabelReporteVentaXCliente.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelReporteVentaXCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelReporteVentaXCliente.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelReporteVentaXCliente.Location = New System.Drawing.Point(565, 0)
        Me.LabelReporteVentaXCliente.Name = "LabelReporteVentaXCliente"
        Me.LabelReporteVentaXCliente.Size = New System.Drawing.Size(99, 25)
        Me.LabelReporteVentaXCliente.TabIndex = 7
        Me.LabelReporteVentaXCliente.Text = "Reportes"
        Me.LabelReporteVentaXCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'ReporteVentaPorCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(664, 641)
        Me.Controls.Add(Me.LblReporteVentaXCliente)
        Me.Controls.Add(Me.PanelReportes)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReporteVentaPorCliente"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.PanelReportes.ResumeLayout(False)
        Me.PanelReportes.PerformLayout()
        CType(Me.PBReporteVentaXCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblReporteVentaXCliente As Label
    Friend WithEvents PanelReportes As Panel
    Friend WithEvents PBReporteVentaXCliente As PictureBox
    Friend WithEvents TbReporteVentaXCliente As TextBox
    Friend WithEvents TexBoxTotalUsuarios As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LblCliente As Label
    Friend WithEvents PanelReporteVentaXCliente As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelReporteVentaXCliente As Label
    Friend WithEvents PictureBox2 As PictureBox
End Class
