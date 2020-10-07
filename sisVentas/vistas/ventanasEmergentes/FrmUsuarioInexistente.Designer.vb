<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioInexistente
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
        Me.LblUsuarioInexistente = New System.Windows.Forms.Label()
        Me.BtnUsuarioInexistente = New System.Windows.Forms.Button()
        Me.PnlUsuarioInexistente = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PBUsuarioInexistente = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlUsuarioInexistente.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBUsuarioInexistente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblUsuarioInexistente
        '
        Me.LblUsuarioInexistente.AutoSize = True
        Me.LblUsuarioInexistente.BackColor = System.Drawing.Color.Transparent
        Me.LblUsuarioInexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUsuarioInexistente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblUsuarioInexistente.Location = New System.Drawing.Point(12, 101)
        Me.LblUsuarioInexistente.Name = "LblUsuarioInexistente"
        Me.LblUsuarioInexistente.Size = New System.Drawing.Size(168, 20)
        Me.LblUsuarioInexistente.TabIndex = 5
        Me.LblUsuarioInexistente.Text = "Usuario inexistente!"
        '
        'BtnUsuarioInexistente
        '
        Me.BtnUsuarioInexistente.BackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarioInexistente.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnUsuarioInexistente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnUsuarioInexistente.FlatAppearance.BorderSize = 0
        Me.BtnUsuarioInexistente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarioInexistente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnUsuarioInexistente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnUsuarioInexistente.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUsuarioInexistente.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnUsuarioInexistente.Location = New System.Drawing.Point(288, 137)
        Me.BtnUsuarioInexistente.Name = "BtnUsuarioInexistente"
        Me.BtnUsuarioInexistente.Size = New System.Drawing.Size(98, 37)
        Me.BtnUsuarioInexistente.TabIndex = 3
        Me.BtnUsuarioInexistente.Text = "Aceptar"
        Me.BtnUsuarioInexistente.UseVisualStyleBackColor = False
        '
        'PnlUsuarioInexistente
        '
        Me.PnlUsuarioInexistente.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PnlUsuarioInexistente.Controls.Add(Me.PictureBox2)
        Me.PnlUsuarioInexistente.Controls.Add(Me.PBUsuarioInexistente)
        Me.PnlUsuarioInexistente.Controls.Add(Me.Label2)
        Me.PnlUsuarioInexistente.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlUsuarioInexistente.Location = New System.Drawing.Point(0, 0)
        Me.PnlUsuarioInexistente.Name = "PnlUsuarioInexistente"
        Me.PnlUsuarioInexistente.Size = New System.Drawing.Size(400, 50)
        Me.PnlUsuarioInexistente.TabIndex = 4
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
        'PBUsuarioInexistente
        '
        Me.PBUsuarioInexistente.Dock = System.Windows.Forms.DockStyle.Left
        Me.PBUsuarioInexistente.Image = Global.sisVentas.My.Resources.Resources.icoAlerta
        Me.PBUsuarioInexistente.Location = New System.Drawing.Point(0, 0)
        Me.PBUsuarioInexistente.Name = "PBUsuarioInexistente"
        Me.PBUsuarioInexistente.Size = New System.Drawing.Size(47, 50)
        Me.PBUsuarioInexistente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBUsuarioInexistente.TabIndex = 3
        Me.PBUsuarioInexistente.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(53, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Error Login"
        '
        'FrmUsuarioInexistente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.LblUsuarioInexistente)
        Me.Controls.Add(Me.BtnUsuarioInexistente)
        Me.Controls.Add(Me.PnlUsuarioInexistente)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmUsuarioInexistente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.PnlUsuarioInexistente.ResumeLayout(False)
        Me.PnlUsuarioInexistente.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBUsuarioInexistente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblUsuarioInexistente As Label
    Friend WithEvents BtnUsuarioInexistente As Button
    Friend WithEvents PnlUsuarioInexistente As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PBUsuarioInexistente As PictureBox
    Friend WithEvents Label2 As Label
End Class
