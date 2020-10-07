<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnMin = New System.Windows.Forms.PictureBox()
        Me.BtnClose = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.TxtUser = New System.Windows.Forms.TextBox()
        Me.TxtPass = New System.Windows.Forms.TextBox()
        Me.LblPass = New System.Windows.Forms.Label()
        Me.ChkRecuerdame = New System.Windows.Forms.CheckBox()
        Me.BtnSesion = New System.Windows.Forms.Button()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.BtnMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.BtnMin)
        Me.Panel1.Controls.Add(Me.BtnClose)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(285, 38)
        Me.Panel1.TabIndex = 0
        '
        'BtnMin
        '
        Me.BtnMin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMin.Image = CType(resources.GetObject("BtnMin.Image"), System.Drawing.Image)
        Me.BtnMin.Location = New System.Drawing.Point(203, 3)
        Me.BtnMin.Name = "BtnMin"
        Me.BtnMin.Size = New System.Drawing.Size(32, 23)
        Me.BtnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnMin.TabIndex = 1
        Me.BtnMin.TabStop = False
        '
        'BtnClose
        '
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
        Me.BtnClose.Location = New System.Drawing.Point(241, 0)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(32, 32)
        Me.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.BtnClose.TabIndex = 0
        Me.BtnClose.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 425)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(285, 25)
        Me.Panel2.TabIndex = 1
        '
        'LblUser
        '
        Me.LblUser.AutoSize = True
        Me.LblUser.BackColor = System.Drawing.Color.Transparent
        Me.LblUser.ForeColor = System.Drawing.Color.Gray
        Me.LblUser.Location = New System.Drawing.Point(24, 187)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Size = New System.Drawing.Size(56, 13)
        Me.LblUser.TabIndex = 2
        Me.LblUser.Text = "USUARIO"
        '
        'TxtUser
        '
        Me.TxtUser.Location = New System.Drawing.Point(27, 203)
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(223, 20)
        Me.TxtUser.TabIndex = 3
        '
        'TxtPass
        '
        Me.TxtPass.Location = New System.Drawing.Point(27, 254)
        Me.TxtPass.Name = "TxtPass"
        Me.TxtPass.Size = New System.Drawing.Size(223, 20)
        Me.TxtPass.TabIndex = 5
        '
        'LblPass
        '
        Me.LblPass.AutoSize = True
        Me.LblPass.BackColor = System.Drawing.Color.Transparent
        Me.LblPass.ForeColor = System.Drawing.Color.Gray
        Me.LblPass.Location = New System.Drawing.Point(27, 238)
        Me.LblPass.Name = "LblPass"
        Me.LblPass.Size = New System.Drawing.Size(81, 13)
        Me.LblPass.TabIndex = 4
        Me.LblPass.Text = "CONTRASEÑA"
        '
        'ChkRecuerdame
        '
        Me.ChkRecuerdame.AutoSize = True
        Me.ChkRecuerdame.BackColor = System.Drawing.Color.Transparent
        Me.ChkRecuerdame.ForeColor = System.Drawing.Color.Gray
        Me.ChkRecuerdame.Location = New System.Drawing.Point(27, 296)
        Me.ChkRecuerdame.Name = "ChkRecuerdame"
        Me.ChkRecuerdame.Size = New System.Drawing.Size(87, 17)
        Me.ChkRecuerdame.TabIndex = 6
        Me.ChkRecuerdame.Text = "Recuérdame"
        Me.ChkRecuerdame.UseVisualStyleBackColor = False
        '
        'BtnSesion
        '
        Me.BtnSesion.BackColor = System.Drawing.Color.Transparent
        Me.BtnSesion.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn201x45iniciar
        Me.BtnSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnSesion.FlatAppearance.BorderSize = 0
        Me.BtnSesion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSesion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSesion.ForeColor = System.Drawing.Color.White
        Me.BtnSesion.Location = New System.Drawing.Point(27, 331)
        Me.BtnSesion.Name = "BtnSesion"
        Me.BtnSesion.Size = New System.Drawing.Size(220, 42)
        Me.BtnSesion.TabIndex = 7
        Me.BtnSesion.Text = "INICIAR SESION"
        Me.BtnSesion.UseVisualStyleBackColor = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Gray
        Me.LinkLabel1.Location = New System.Drawing.Point(92, 398)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(99, 13)
        Me.LinkLabel1.TabIndex = 8
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Olvidé la Contrseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Gray
        Me.Label1.Location = New System.Drawing.Point(48, 376)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "______________________________"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(111, 65)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 54)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(95, 114)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(80, 24)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(6, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(23, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(285, 450)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.BtnSesion)
        Me.Controls.Add(Me.ChkRecuerdame)
        Me.Controls.Add(Me.TxtPass)
        Me.Controls.Add(Me.LblPass)
        Me.Controls.Add(Me.TxtUser)
        Me.Controls.Add(Me.LblUser)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BtnMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnClose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnMin As PictureBox
    Friend WithEvents BtnClose As PictureBox
    Friend WithEvents LblUser As Label
    Friend WithEvents TxtUser As TextBox
    Friend WithEvents TxtPass As TextBox
    Friend WithEvents LblPass As Label
    Friend WithEvents ChkRecuerdame As CheckBox
    Friend WithEvents BtnSesion As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
