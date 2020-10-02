<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSiNoProducto
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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnNoProd = New System.Windows.Forms.Button()
        Me.BtnSiProd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Panel1.TabIndex = 2
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
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Atención!!!"
        '
        'BtnNoProd
        '
        Me.BtnNoProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnNoProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnNoProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnNoProd.FlatAppearance.BorderSize = 0
        Me.BtnNoProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnNoProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnNoProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNoProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNoProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnNoProd.Location = New System.Drawing.Point(290, 153)
        Me.BtnNoProd.Name = "BtnNoProd"
        Me.BtnNoProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnNoProd.TabIndex = 10
        Me.BtnNoProd.Text = "No"
        Me.BtnNoProd.UseVisualStyleBackColor = False
        '
        'BtnSiProd
        '
        Me.BtnSiProd.BackColor = System.Drawing.Color.Transparent
        Me.BtnSiProd.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnSiProd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSiProd.FlatAppearance.BorderSize = 0
        Me.BtnSiProd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSiProd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSiProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSiProd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSiProd.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSiProd.Location = New System.Drawing.Point(186, 153)
        Me.BtnSiProd.Name = "BtnSiProd"
        Me.BtnSiProd.Size = New System.Drawing.Size(98, 37)
        Me.BtnSiProd.TabIndex = 9
        Me.BtnSiProd.Text = "Si"
        Me.BtnSiProd.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 95)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(233, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Desea eliminar el producto?"
        '
        'FrmSiNoProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnNoProd)
        Me.Controls.Add(Me.BtnSiProd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSiNoProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSiNoProducto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnNoProd As Button
    Friend WithEvents BtnSiProd As Button
    Friend WithEvents Label1 As Label
End Class
