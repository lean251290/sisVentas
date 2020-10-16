<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgregarCategoria
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
        Me.BtnAgregarCat = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBAgregarCat = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancelarCat = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbCategoria = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBAgregarCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnAgregarCat
        '
        Me.BtnAgregarCat.BackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCat.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAgregarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAgregarCat.FlatAppearance.BorderSize = 0
        Me.BtnAgregarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAgregarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAgregarCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAgregarCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAgregarCat.Location = New System.Drawing.Point(183, 151)
        Me.BtnAgregarCat.Name = "BtnAgregarCat"
        Me.BtnAgregarCat.Size = New System.Drawing.Size(98, 37)
        Me.BtnAgregarCat.TabIndex = 11
        Me.BtnAgregarCat.Text = "Agregar"
        Me.BtnAgregarCat.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBAgregarCat)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 10
        '
        'PBAgregarCat
        '
        Me.PBAgregarCat.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBAgregarCat.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBAgregarCat.Location = New System.Drawing.Point(353, 0)
        Me.PBAgregarCat.Name = "PBAgregarCat"
        Me.PBAgregarCat.Size = New System.Drawing.Size(47, 50)
        Me.PBAgregarCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBAgregarCat.TabIndex = 4
        Me.PBAgregarCat.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoAlerta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(53, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Agregar Categoría"
        '
        'BtnCancelarCat
        '
        Me.BtnCancelarCat.BackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarCat.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnCancelarCat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnCancelarCat.FlatAppearance.BorderSize = 0
        Me.BtnCancelarCat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnCancelarCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancelarCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelarCat.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnCancelarCat.Location = New System.Drawing.Point(290, 151)
        Me.BtnCancelarCat.Name = "BtnCancelarCat"
        Me.BtnCancelarCat.Size = New System.Drawing.Size(98, 37)
        Me.BtnCancelarCat.TabIndex = 12
        Me.BtnCancelarCat.Text = "Cancelar"
        Me.BtnCancelarCat.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Categoría:"
        '
        'TbCategoria
        '
        Me.TbCategoria.Location = New System.Drawing.Point(110, 94)
        Me.TbCategoria.Name = "TbCategoria"
        Me.TbCategoria.Size = New System.Drawing.Size(278, 20)
        Me.TbCategoria.TabIndex = 13
        '
        'FrmAgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.TbCategoria)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCancelarCat)
        Me.Controls.Add(Me.BtnAgregarCat)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmAgregarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmAgregarCategoria"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBAgregarCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAgregarCat As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBAgregarCat As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCancelarCat As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TbCategoria As TextBox
End Class
