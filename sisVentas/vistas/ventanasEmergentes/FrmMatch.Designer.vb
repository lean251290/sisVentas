<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMatch
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBmatch = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAceptarImagen = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PBmatch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 102)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(253, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Las contraseñas no coinciden!"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBmatch)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 15
        '
        'PBmatch
        '
        Me.PBmatch.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBmatch.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBmatch.Location = New System.Drawing.Point(353, 0)
        Me.PBmatch.Name = "PBmatch"
        Me.PBmatch.Size = New System.Drawing.Size(47, 50)
        Me.PBmatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBmatch.TabIndex = 2
        Me.PBmatch.TabStop = False
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
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoAlerta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'BtnAceptarImagen
        '
        Me.BtnAceptarImagen.BackColor = System.Drawing.Color.Transparent
        Me.BtnAceptarImagen.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAceptarImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAceptarImagen.FlatAppearance.BorderSize = 0
        Me.BtnAceptarImagen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAceptarImagen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAceptarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAceptarImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAceptarImagen.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAceptarImagen.Location = New System.Drawing.Point(290, 151)
        Me.BtnAceptarImagen.Name = "BtnAceptarImagen"
        Me.BtnAceptarImagen.Size = New System.Drawing.Size(98, 37)
        Me.BtnAceptarImagen.TabIndex = 17
        Me.BtnAceptarImagen.Text = "Aceptar"
        Me.BtnAceptarImagen.UseVisualStyleBackColor = False
        '
        'FrmMatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnAceptarImagen)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMatch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBmatch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAceptarImagen As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBmatch As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
