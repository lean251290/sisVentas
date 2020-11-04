<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarProdDetalle
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSiVenta = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNoVenta = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(328, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desea eliminar el producto del registro?"
        '
        'BtnSiVenta
        '
        Me.BtnSiVenta.BackColor = System.Drawing.Color.Transparent
        Me.BtnSiVenta.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnSiVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiVenta.FlatAppearance.BorderSize = 0
        Me.BtnSiVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSiVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSiVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSiVenta.Location = New System.Drawing.Point(192, 151)
        Me.BtnSiVenta.Name = "BtnSiVenta"
        Me.BtnSiVenta.Size = New System.Drawing.Size(98, 37)
        Me.BtnSiVenta.TabIndex = 6
        Me.BtnSiVenta.Text = "Si"
        Me.BtnSiVenta.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 7
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox2.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox2.Location = New System.Drawing.Point(353, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
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
        Me.Label2.Size = New System.Drawing.Size(119, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Advertencia!!!"
        '
        'BtnNoVenta
        '
        Me.BtnNoVenta.BackColor = System.Drawing.Color.Transparent
        Me.BtnNoVenta.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnNoVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNoVenta.FlatAppearance.BorderSize = 0
        Me.BtnNoVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNoVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNoVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoVenta.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNoVenta.Location = New System.Drawing.Point(296, 151)
        Me.BtnNoVenta.Name = "BtnNoVenta"
        Me.BtnNoVenta.Size = New System.Drawing.Size(98, 37)
        Me.BtnNoVenta.TabIndex = 9
        Me.BtnNoVenta.Text = "No"
        Me.BtnNoVenta.UseVisualStyleBackColor = False
        '
        'FrmEliminarProdDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnNoVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnSiVenta)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarProdDetalle"
        Me.Text = "FrmEliminarProdDetalle"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtnSiVenta As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnNoVenta As Button
End Class
