<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatosCargadosCorrecto
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
        Me.BtnDatosCargados = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBDatosCargados = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBDatosCargados, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Datos cargados correctamente!"
        '
        'BtnDatosCargados
        '
        Me.BtnDatosCargados.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnDatosCargados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnDatosCargados.FlatAppearance.BorderSize = 0
        Me.BtnDatosCargados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnDatosCargados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnDatosCargados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDatosCargados.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDatosCargados.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnDatosCargados.Location = New System.Drawing.Point(290, 151)
        Me.BtnDatosCargados.Name = "BtnDatosCargados"
        Me.BtnDatosCargados.Size = New System.Drawing.Size(98, 37)
        Me.BtnDatosCargados.TabIndex = 3
        Me.BtnDatosCargados.Text = "Aceptar"
        Me.BtnDatosCargados.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBDatosCargados)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 4
        '
        'PBDatosCargados
        '
        Me.PBDatosCargados.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBDatosCargados.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBDatosCargados.Location = New System.Drawing.Point(353, 0)
        Me.PBDatosCargados.Name = "PBDatosCargados"
        Me.PBDatosCargados.Size = New System.Drawing.Size(47, 50)
        Me.PBDatosCargados.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBDatosCargados.TabIndex = 2
        Me.PBDatosCargados.TabStop = False
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
        'FrmDatosCargadosCorrecto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDatosCargados)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDatosCargadosCorrecto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDatosCargadosCorrecto"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBDatosCargados, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents BtnDatosCargados As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBDatosCargados As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
