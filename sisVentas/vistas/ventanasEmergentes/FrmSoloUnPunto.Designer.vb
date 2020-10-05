<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSoloUnPunto
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
        Me.BtnSoloPunto = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBPunto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBPunto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSoloPunto
        '
        Me.BtnSoloPunto.BackColor = System.Drawing.Color.Transparent
        Me.BtnSoloPunto.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnSoloPunto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSoloPunto.FlatAppearance.BorderSize = 0
        Me.BtnSoloPunto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSoloPunto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSoloPunto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSoloPunto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSoloPunto.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnSoloPunto.Location = New System.Drawing.Point(290, 151)
        Me.BtnSoloPunto.Name = "BtnSoloPunto"
        Me.BtnSoloPunto.Size = New System.Drawing.Size(98, 37)
        Me.BtnSoloPunto.TabIndex = 20
        Me.BtnSoloPunto.Text = "Aceptar"
        Me.BtnSoloPunto.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(330, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Solo se acepta un (.) para los decimales"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBPunto)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 18
        '
        'PBPunto
        '
        Me.PBPunto.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBPunto.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBPunto.Location = New System.Drawing.Point(353, 0)
        Me.PBPunto.Name = "PBPunto"
        Me.PBPunto.Size = New System.Drawing.Size(47, 50)
        Me.PBPunto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBPunto.TabIndex = 2
        Me.PBPunto.TabStop = False
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
        'FrmSoloUnPunto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnSoloPunto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmSoloUnPunto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmSoloUnPunto"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBPunto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnSoloPunto As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBPunto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
