<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoriaAgregada
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnProductoAgregado = New System.Windows.Forms.Button()
        Me.PBCerrarProductoAgregado = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBCerrarProductoAgregado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBCerrarProductoAgregado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(53, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Atención!!!"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(31, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(269, 20)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Categoria agrega correctamente"
        '
        'BtnProductoAgregado
        '
        Me.BtnProductoAgregado.BackColor = System.Drawing.Color.Transparent
        Me.BtnProductoAgregado.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnProductoAgregado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnProductoAgregado.FlatAppearance.BorderSize = 0
        Me.BtnProductoAgregado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnProductoAgregado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnProductoAgregado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProductoAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProductoAgregado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnProductoAgregado.Location = New System.Drawing.Point(290, 151)
        Me.BtnProductoAgregado.Name = "BtnProductoAgregado"
        Me.BtnProductoAgregado.Size = New System.Drawing.Size(98, 37)
        Me.BtnProductoAgregado.TabIndex = 15
        Me.BtnProductoAgregado.Text = "Aceptar"
        Me.BtnProductoAgregado.UseVisualStyleBackColor = False
        '
        'PBCerrarProductoAgregado
        '
        Me.PBCerrarProductoAgregado.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBCerrarProductoAgregado.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBCerrarProductoAgregado.Location = New System.Drawing.Point(353, 0)
        Me.PBCerrarProductoAgregado.Name = "PBCerrarProductoAgregado"
        Me.PBCerrarProductoAgregado.Size = New System.Drawing.Size(47, 50)
        Me.PBCerrarProductoAgregado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBCerrarProductoAgregado.TabIndex = 2
        Me.PBCerrarProductoAgregado.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoVisto
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FrmCategoriaAgregada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnProductoAgregado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCategoriaAgregada"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCategoriaAgregada"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBCerrarProductoAgregado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBCerrarProductoAgregado As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnProductoAgregado As Button
End Class
