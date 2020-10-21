<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosActualizados
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
        Me.PBDatosActualizados = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDatosActualizados = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PBDatosActualizados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBDatosActualizados)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 1
        '
        'PBDatosActualizados
        '
        Me.PBDatosActualizados.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBDatosActualizados.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBDatosActualizados.Location = New System.Drawing.Point(353, 0)
        Me.PBDatosActualizados.Name = "PBDatosActualizados"
        Me.PBDatosActualizados.Size = New System.Drawing.Size(47, 50)
        Me.PBDatosActualizados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBDatosActualizados.TabIndex = 4
        Me.PBDatosActualizados.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoVisto
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(22, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Datos actualizados Correctamente"
        '
        'BDatosActualizados
        '
        Me.BDatosActualizados.BackColor = System.Drawing.Color.Transparent
        Me.BDatosActualizados.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BDatosActualizados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BDatosActualizados.FlatAppearance.BorderSize = 0
        Me.BDatosActualizados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BDatosActualizados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BDatosActualizados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDatosActualizados.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDatosActualizados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BDatosActualizados.Location = New System.Drawing.Point(290, 151)
        Me.BDatosActualizados.Name = "BDatosActualizados"
        Me.BDatosActualizados.Size = New System.Drawing.Size(98, 37)
        Me.BDatosActualizados.TabIndex = 4
        Me.BDatosActualizados.Text = "Aceptar"
        Me.BDatosActualizados.UseVisualStyleBackColor = False
        '
        'FrmDatosActualizados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BDatosActualizados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDatosActualizados"
        Me.Text = "FrmDatosActualizados"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PBDatosActualizados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBDatosActualizados As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BDatosActualizados As Button
End Class
