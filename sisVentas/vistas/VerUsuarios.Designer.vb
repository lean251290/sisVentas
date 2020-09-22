<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VerUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerUsuarios))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LVerUsuarios = New System.Windows.Forms.Label()
        Me.PPagos = New System.Windows.Forms.Panel()
        Me.BtnModifcarUsuario = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.TextBoxBuscar = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuarios = New System.Windows.Forms.Label()
        Me.PPagos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'LVerUsuarios
        '
        Me.LVerUsuarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LVerUsuarios.AutoSize = True
        Me.LVerUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVerUsuarios.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LVerUsuarios.Location = New System.Drawing.Point(532, 9)
        Me.LVerUsuarios.Name = "LVerUsuarios"
        Me.LVerUsuarios.Size = New System.Drawing.Size(136, 25)
        Me.LVerUsuarios.TabIndex = 5
        Me.LVerUsuarios.Text = "Ver Usuarios"
        Me.LVerUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PPagos
        '
        Me.PPagos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PPagos.BackColor = System.Drawing.Color.Transparent
        Me.PPagos.BackgroundImage = CType(resources.GetObject("PPagos.BackgroundImage"), System.Drawing.Image)
        Me.PPagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PPagos.Controls.Add(Me.BtnModifcarUsuario)
        Me.PPagos.Controls.Add(Me.DataGridView1)
        Me.PPagos.Controls.Add(Me.PictureBuscarUsuario)
        Me.PPagos.Controls.Add(Me.TextBoxBuscar)
        Me.PPagos.Controls.Add(Me.LBuscarUsuarios)
        Me.PPagos.Location = New System.Drawing.Point(41, 55)
        Me.PPagos.Name = "PPagos"
        Me.PPagos.Size = New System.Drawing.Size(627, 613)
        Me.PPagos.TabIndex = 7
        '
        'BtnModifcarUsuario
        '
        Me.BtnModifcarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnModifcarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BtnModifcarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModifcarUsuario.Image = CType(resources.GetObject("BtnModifcarUsuario.Image"), System.Drawing.Image)
        Me.BtnModifcarUsuario.Location = New System.Drawing.Point(307, 519)
        Me.BtnModifcarUsuario.Name = "BtnModifcarUsuario"
        Me.BtnModifcarUsuario.Size = New System.Drawing.Size(78, 31)
        Me.BtnModifcarUsuario.TabIndex = 12
        Me.BtnModifcarUsuario.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(49, 101)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(485, 344)
        Me.DataGridView1.TabIndex = 11
        '
        'PictureBuscarUsuario
        '
        Me.PictureBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBuscarUsuario.Image = CType(resources.GetObject("PictureBuscarUsuario.Image"), System.Drawing.Image)
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(548, 42)
        Me.PictureBuscarUsuario.Name = "PictureBuscarUsuario"
        Me.PictureBuscarUsuario.Size = New System.Drawing.Size(36, 35)
        Me.PictureBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBuscarUsuario.TabIndex = 10
        Me.PictureBuscarUsuario.TabStop = False
        '
        'TextBoxBuscar
        '
        Me.TextBoxBuscar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxBuscar.Location = New System.Drawing.Point(129, 49)
        Me.TextBoxBuscar.Name = "TextBoxBuscar"
        Me.TextBoxBuscar.Size = New System.Drawing.Size(405, 20)
        Me.TextBoxBuscar.TabIndex = 9
        '
        'LBuscarUsuarios
        '
        Me.LBuscarUsuarios.AutoSize = True
        Me.LBuscarUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarUsuarios.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.LBuscarUsuarios.Location = New System.Drawing.Point(44, 44)
        Me.LBuscarUsuarios.Name = "LBuscarUsuarios"
        Me.LBuscarUsuarios.Size = New System.Drawing.Size(79, 25)
        Me.LBuscarUsuarios.TabIndex = 8
        Me.LBuscarUsuarios.Text = "Buscar"
        Me.LBuscarUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'VerUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PPagos)
        Me.Controls.Add(Me.LVerUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerUsuarios"
        Me.Text = "VerUsuario"
        Me.PPagos.ResumeLayout(False)
        Me.PPagos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LVerUsuarios As Label
    Friend WithEvents PPagos As Panel
    Friend WithEvents LBuscarUsuarios As Label
    Friend WithEvents PictureBuscarUsuario As PictureBox
    Friend WithEvents TextBoxBuscar As TextBox
    Friend WithEvents BtnModifcarUsuario As Button
    Friend WithEvents DataGridView1 As DataGridView
End Class
