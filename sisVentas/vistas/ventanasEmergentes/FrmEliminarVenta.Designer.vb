<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEliminarVenta
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
        Me.PBCerrarEliminarVenta = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEliminarVentaNo = New System.Windows.Forms.Button()
        Me.BtnEliminarVentaSi = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PBCerrarEliminarVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBCerrarEliminarVenta)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 2
        '
        'PBCerrarEliminarVenta
        '
        Me.PBCerrarEliminarVenta.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBCerrarEliminarVenta.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBCerrarEliminarVenta.Location = New System.Drawing.Point(353, 0)
        Me.PBCerrarEliminarVenta.Name = "PBCerrarEliminarVenta"
        Me.PBCerrarEliminarVenta.Size = New System.Drawing.Size(47, 50)
        Me.PBCerrarEliminarVenta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBCerrarEliminarVenta.TabIndex = 4
        Me.PBCerrarEliminarVenta.TabStop = False
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(30, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Desea anular una venta?"
        '
        'BtnEliminarVentaNo
        '
        Me.BtnEliminarVentaNo.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaNo.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnEliminarVentaNo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarVentaNo.FlatAppearance.BorderSize = 0
        Me.BtnEliminarVentaNo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaNo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarVentaNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarVentaNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminarVentaNo.Location = New System.Drawing.Point(290, 151)
        Me.BtnEliminarVentaNo.Name = "BtnEliminarVentaNo"
        Me.BtnEliminarVentaNo.Size = New System.Drawing.Size(98, 37)
        Me.BtnEliminarVentaNo.TabIndex = 9
        Me.BtnEliminarVentaNo.Text = "No"
        Me.BtnEliminarVentaNo.UseVisualStyleBackColor = False
        '
        'BtnEliminarVentaSi
        '
        Me.BtnEliminarVentaSi.BackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaSi.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnEliminarVentaSi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarVentaSi.FlatAppearance.BorderSize = 0
        Me.BtnEliminarVentaSi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaSi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarVentaSi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarVentaSi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarVentaSi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminarVentaSi.Location = New System.Drawing.Point(186, 151)
        Me.BtnEliminarVentaSi.Name = "BtnEliminarVentaSi"
        Me.BtnEliminarVentaSi.Size = New System.Drawing.Size(98, 37)
        Me.BtnEliminarVentaSi.TabIndex = 8
        Me.BtnEliminarVentaSi.Text = "Si"
        Me.BtnEliminarVentaSi.UseVisualStyleBackColor = False
        '
        'FrmEliminarVenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnEliminarVentaNo)
        Me.Controls.Add(Me.BtnEliminarVentaSi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmEliminarVenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEliminarVenta"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBCerrarEliminarVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBCerrarEliminarVenta As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEliminarVentaNo As Button
    Friend WithEvents BtnEliminarVentaSi As Button
End Class
