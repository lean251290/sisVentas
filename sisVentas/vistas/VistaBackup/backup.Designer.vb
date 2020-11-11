<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
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
        Me.txtBaseRestaurar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtRutaGuardar = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboBaseDatos = New System.Windows.Forms.ComboBox()
        Me.txtRutaRestaurar = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnRutaGuardar = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.btnRutaRestaurar = New System.Windows.Forms.Button()
        Me.btnRestaurar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBaseRestaurar
        '
        Me.txtBaseRestaurar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBaseRestaurar.Location = New System.Drawing.Point(229, 336)
        Me.txtBaseRestaurar.Name = "txtBaseRestaurar"
        Me.txtBaseRestaurar.Size = New System.Drawing.Size(368, 26)
        Me.txtBaseRestaurar.TabIndex = 48
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(536, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Backup y rastauración Base de Datos SQL Server"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(26, 165)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Ruta guardar"
        '
        'txtRutaGuardar
        '
        Me.txtRutaGuardar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaGuardar.Location = New System.Drawing.Point(145, 163)
        Me.txtRutaGuardar.Name = "txtRutaGuardar"
        Me.txtRutaGuardar.ShortcutsEnabled = False
        Me.txtRutaGuardar.Size = New System.Drawing.Size(453, 26)
        Me.txtRutaGuardar.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(26, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Ruta restaurar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(25, 337)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(193, 20)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Base de datos a restaurar"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(26, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Base de datos"
        '
        'cboBaseDatos
        '
        Me.cboBaseDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaseDatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBaseDatos.FormattingEnabled = True
        Me.cboBaseDatos.Location = New System.Drawing.Point(144, 129)
        Me.cboBaseDatos.Name = "cboBaseDatos"
        Me.cboBaseDatos.Size = New System.Drawing.Size(219, 28)
        Me.cboBaseDatos.TabIndex = 36
        '
        'txtRutaRestaurar
        '
        Me.txtRutaRestaurar.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaRestaurar.Location = New System.Drawing.Point(144, 297)
        Me.txtRutaRestaurar.Name = "txtRutaRestaurar"
        Me.txtRutaRestaurar.Size = New System.Drawing.Size(368, 26)
        Me.txtRutaRestaurar.TabIndex = 40
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 74)
        Me.Panel1.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label7.Location = New System.Drawing.Point(-5, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(812, 13)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "_________________________________________________________________________________" &
    "__________________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(744, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 74)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 56
        Me.PictureBox1.TabStop = False
        '
        'btnConectar
        '
        Me.btnConectar.BackColor = System.Drawing.Color.Transparent
        Me.btnConectar.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.btnConectar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConectar.FlatAppearance.BorderSize = 0
        Me.btnConectar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnConectar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnConectar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConectar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConectar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConectar.Location = New System.Drawing.Point(369, 125)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(98, 35)
        Me.btnConectar.TabIndex = 49
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = False
        '
        'btnRutaGuardar
        '
        Me.btnRutaGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnRutaGuardar.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.btnRutaGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRutaGuardar.FlatAppearance.BorderSize = 0
        Me.btnRutaGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRutaGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRutaGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRutaGuardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRutaGuardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRutaGuardar.Location = New System.Drawing.Point(604, 158)
        Me.btnRutaGuardar.Name = "btnRutaGuardar"
        Me.btnRutaGuardar.Size = New System.Drawing.Size(98, 35)
        Me.btnRutaGuardar.TabIndex = 50
        Me.btnRutaGuardar.Text = "Ruta"
        Me.btnRutaGuardar.UseVisualStyleBackColor = False
        '
        'btnBackup
        '
        Me.btnBackup.BackColor = System.Drawing.Color.Transparent
        Me.btnBackup.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBackup.FlatAppearance.BorderSize = 0
        Me.btnBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackup.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBackup.Location = New System.Drawing.Point(144, 211)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(113, 35)
        Me.btnBackup.TabIndex = 51
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = False
        '
        'btnRutaRestaurar
        '
        Me.btnRutaRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRutaRestaurar.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.btnRutaRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRutaRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRutaRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRutaRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRutaRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRutaRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRutaRestaurar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRutaRestaurar.Location = New System.Drawing.Point(518, 291)
        Me.btnRutaRestaurar.Name = "btnRutaRestaurar"
        Me.btnRutaRestaurar.Size = New System.Drawing.Size(98, 35)
        Me.btnRutaRestaurar.TabIndex = 52
        Me.btnRutaRestaurar.Text = "Ruta"
        Me.btnRutaRestaurar.UseVisualStyleBackColor = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.BackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.btnRestaurar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRestaurar.FlatAppearance.BorderSize = 0
        Me.btnRestaurar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRestaurar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRestaurar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnRestaurar.Location = New System.Drawing.Point(145, 382)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(113, 35)
        Me.btnRestaurar.TabIndex = 53
        Me.btnRestaurar.Text = "Restaurar"
        Me.btnRestaurar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label6.Location = New System.Drawing.Point(-5, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(812, 13)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "_________________________________________________________________________________" &
    "__________________________________"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label8.Location = New System.Drawing.Point(-5, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(812, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "_________________________________________________________________________________" &
    "__________________________________"
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnRestaurar)
        Me.Controls.Add(Me.btnRutaRestaurar)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRutaGuardar)
        Me.Controls.Add(Me.btnConectar)
        Me.Controls.Add(Me.txtBaseRestaurar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRutaGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboBaseDatos)
        Me.Controls.Add(Me.txtRutaRestaurar)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtBaseRestaurar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtRutaGuardar As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboBaseDatos As ComboBox
    Friend WithEvents txtRutaRestaurar As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnConectar As Button
    Friend WithEvents btnRutaGuardar As Button
    Friend WithEvents btnBackup As Button
    Friend WithEvents btnRutaRestaurar As Button
    Friend WithEvents btnRestaurar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label7 As Label
End Class
