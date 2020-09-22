<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UsuarioAgregadoVista
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UsuarioAgregadoVista))
        Me.PUsuarioAgregado = New System.Windows.Forms.Panel()
        Me.LUsuarioAgregado = New System.Windows.Forms.Label()
        Me.BUsuarioAgregadoCerrar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PUsuarioAgregado.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PUsuarioAgregado
        '
        Me.PUsuarioAgregado.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PUsuarioAgregado.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PUsuarioAgregado.Controls.Add(Me.LUsuarioAgregado)
        Me.PUsuarioAgregado.Controls.Add(Me.BUsuarioAgregadoCerrar)
        Me.PUsuarioAgregado.Controls.Add(Me.PictureBox1)
        Me.PUsuarioAgregado.Location = New System.Drawing.Point(0, 0)
        Me.PUsuarioAgregado.Name = "PUsuarioAgregado"
        Me.PUsuarioAgregado.Size = New System.Drawing.Size(400, 50)
        Me.PUsuarioAgregado.TabIndex = 0
        '
        'LUsuarioAgregado
        '
        Me.LUsuarioAgregado.AutoSize = True
        Me.LUsuarioAgregado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUsuarioAgregado.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LUsuarioAgregado.Location = New System.Drawing.Point(56, 15)
        Me.LUsuarioAgregado.Name = "LUsuarioAgregado"
        Me.LUsuarioAgregado.Size = New System.Drawing.Size(54, 20)
        Me.LUsuarioAgregado.TabIndex = 6
        Me.LUsuarioAgregado.Text = "Éxito!"
        '
        'BUsuarioAgregadoCerrar
        '
        Me.BUsuarioAgregadoCerrar.FlatAppearance.BorderSize = 0
        Me.BUsuarioAgregadoCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BUsuarioAgregadoCerrar.Image = CType(resources.GetObject("BUsuarioAgregadoCerrar.Image"), System.Drawing.Image)
        Me.BUsuarioAgregadoCerrar.Location = New System.Drawing.Point(356, 12)
        Me.BUsuarioAgregadoCerrar.Name = "BUsuarioAgregadoCerrar"
        Me.BUsuarioAgregadoCerrar.Size = New System.Drawing.Size(43, 23)
        Me.BUsuarioAgregadoCerrar.TabIndex = 5
        Me.BUsuarioAgregadoCerrar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 47)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Usuario agregado correctamente"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(290, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 37)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "ACEPTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UsuarioAgregadoVista
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(400, 187)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PUsuarioAgregado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UsuarioAgregadoVista"
        Me.Text = "Usuario Agregado"
        Me.PUsuarioAgregado.ResumeLayout(False)
        Me.PUsuarioAgregado.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PUsuarioAgregado As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BUsuarioAgregadoCerrar As Button
    Friend WithEvents LUsuarioAgregado As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
