<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVentas
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
        Me.LabelVerVentas = New System.Windows.Forms.Label()
        Me.PanelVerVentas = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DTPVentasVerHasta = New System.Windows.Forms.DateTimePicker()
        Me.DTPVentasVerDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelVerVentas.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelVerVentas
        '
        Me.LabelVerVentas.AutoSize = True
        Me.LabelVerVentas.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVerVentas.Location = New System.Drawing.Point(562, 0)
        Me.LabelVerVentas.Name = "LabelVerVentas"
        Me.LabelVerVentas.Size = New System.Drawing.Size(118, 25)
        Me.LabelVerVentas.TabIndex = 6
        Me.LabelVerVentas.Text = "Ver Ventas"
        Me.LabelVerVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelVerVentas
        '
        Me.PanelVerVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerVentas.Controls.Add(Me.DTPVentasVerHasta)
        Me.PanelVerVentas.Controls.Add(Me.DTPVentasVerDesde)
        Me.PanelVerVentas.Controls.Add(Me.Label3)
        Me.PanelVerVentas.Controls.Add(Me.Label2)
        Me.PanelVerVentas.Controls.Add(Me.DataGridView1)
        Me.PanelVerVentas.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerVentas.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerVentas.Name = "PanelVerVentas"
        Me.PanelVerVentas.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerVentas.TabIndex = 8
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(517, 386)
        Me.DataGridView1.TabIndex = 11
        '
        'PictureBuscarUsuario
        '
        Me.PictureBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBuscarUsuario.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(517, 32)
        Me.PictureBuscarUsuario.Name = "PictureBuscarUsuario"
        Me.PictureBuscarUsuario.Size = New System.Drawing.Size(36, 35)
        Me.PictureBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBuscarUsuario.TabIndex = 10
        Me.PictureBuscarUsuario.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelVerVentas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'DTPVentasVerHasta
        '
        Me.DTPVentasVerHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVentasVerHasta.Location = New System.Drawing.Point(359, 47)
        Me.DTPVentasVerHasta.Name = "DTPVentasVerHasta"
        Me.DTPVentasVerHasta.Size = New System.Drawing.Size(99, 20)
        Me.DTPVentasVerHasta.TabIndex = 22
        '
        'DTPVentasVerDesde
        '
        Me.DTPVentasVerDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVentasVerDesde.Location = New System.Drawing.Point(112, 47)
        Me.DTPVentasVerDesde.Name = "DTPVentasVerDesde"
        Me.DTPVentasVerDesde.Size = New System.Drawing.Size(99, 20)
        Me.DTPVentasVerDesde.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label3.Location = New System.Drawing.Point(297, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Hasta:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(46, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Desde:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelVerVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerVentas"
        Me.Text = "Form5"
        Me.PanelVerVentas.ResumeLayout(False)
        Me.PanelVerVentas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelVerVentas As Label
    Friend WithEvents PanelVerVentas As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBuscarUsuario As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DTPVentasVerHasta As DateTimePicker
    Friend WithEvents DTPVentasVerDesde As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
