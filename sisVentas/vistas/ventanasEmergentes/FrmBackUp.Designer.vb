<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBackUp
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
        Me.Btnbackupno = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbBackup = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Btnbackupsi = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PbBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Btnbackupno
        '
        Me.Btnbackupno.BackColor = System.Drawing.Color.Transparent
        Me.Btnbackupno.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.Btnbackupno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnbackupno.FlatAppearance.BorderSize = 0
        Me.Btnbackupno.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btnbackupno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btnbackupno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbackupno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbackupno.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnbackupno.Location = New System.Drawing.Point(290, 151)
        Me.Btnbackupno.Name = "Btnbackupno"
        Me.Btnbackupno.Size = New System.Drawing.Size(98, 37)
        Me.Btnbackupno.TabIndex = 17
        Me.Btnbackupno.Text = "No"
        Me.Btnbackupno.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(10, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(234, 20)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Desea realizar un Back-Up?"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PbBackup)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 15
        '
        'PbBackup
        '
        Me.PbBackup.Dock = System.Windows.Forms.DockStyle.Right
        Me.PbBackup.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PbBackup.Location = New System.Drawing.Point(353, 0)
        Me.PbBackup.Name = "PbBackup"
        Me.PbBackup.Size = New System.Drawing.Size(47, 50)
        Me.PbBackup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbBackup.TabIndex = 2
        Me.PbBackup.TabStop = False
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
        'Btnbackupsi
        '
        Me.Btnbackupsi.BackColor = System.Drawing.Color.Transparent
        Me.Btnbackupsi.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.Btnbackupsi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Btnbackupsi.FlatAppearance.BorderSize = 0
        Me.Btnbackupsi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Btnbackupsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Btnbackupsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Btnbackupsi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnbackupsi.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnbackupsi.Location = New System.Drawing.Point(186, 151)
        Me.Btnbackupsi.Name = "Btnbackupsi"
        Me.Btnbackupsi.Size = New System.Drawing.Size(98, 37)
        Me.Btnbackupsi.TabIndex = 18
        Me.Btnbackupsi.Text = "Si"
        Me.Btnbackupsi.UseVisualStyleBackColor = False
        '
        'FrmBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.Btnbackupsi)
        Me.Controls.Add(Me.Btnbackupno)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmBackUp"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btnbackupno As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbBackup As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Btnbackupsi As Button
End Class
