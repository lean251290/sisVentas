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
        Me.LabelVerUsuarios = New System.Windows.Forms.Label()
        Me.PanelVerUsuarios = New System.Windows.Forms.Panel()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuario = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnModifcarUsuario = New System.Windows.Forms.Button()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.PanelVerUsuarios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'LabelVerUsuarios
        '
        Me.LabelVerUsuarios.AutoSize = True
        Me.LabelVerUsuarios.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerUsuarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVerUsuarios.Location = New System.Drawing.Point(544, 0)
        Me.LabelVerUsuarios.Name = "LabelVerUsuarios"
        Me.LabelVerUsuarios.Size = New System.Drawing.Size(136, 25)
        Me.LabelVerUsuarios.TabIndex = 5
        Me.LabelVerUsuarios.Text = "Ver Usuarios"
        Me.LabelVerUsuarios.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelVerUsuarios
        '
        Me.PanelVerUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerUsuarios.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerUsuarios.Controls.Add(Me.TBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.LBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.BtnModifcarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.DataGridView1)
        Me.PanelVerUsuarios.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerUsuarios.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerUsuarios.Name = "PanelVerUsuarios"
        Me.PanelVerUsuarios.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerUsuarios.TabIndex = 7
        '
        'TBuscarUsuario
        '
        Me.TBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarUsuario.Location = New System.Drawing.Point(122, 46)
        Me.TBuscarUsuario.Multiline = True
        Me.TBuscarUsuario.Name = "TBuscarUsuario"
        Me.TBuscarUsuario.Size = New System.Drawing.Size(372, 20)
        Me.TBuscarUsuario.TabIndex = 15
        '
        'LBuscarUsuario
        '
        Me.LBuscarUsuario.AutoSize = True
        Me.LBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarUsuario.Location = New System.Drawing.Point(46, 46)
        Me.LBuscarUsuario.Name = "LBuscarUsuario"
        Me.LBuscarUsuario.Size = New System.Drawing.Size(59, 20)
        Me.LBuscarUsuario.TabIndex = 13
        Me.LBuscarUsuario.Text = "Buscar"
        Me.LBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(50, 90)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 200)
        Me.DataGridView1.TabIndex = 11
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
        'PictureBuscarUsuario
        '
        Me.PictureBuscarUsuario.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(514, 31)
        Me.PictureBuscarUsuario.Name = "PictureBuscarUsuario"
        Me.PictureBuscarUsuario.Size = New System.Drawing.Size(36, 35)
        Me.PictureBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBuscarUsuario.TabIndex = 10
        Me.PictureBuscarUsuario.TabStop = False
        '
        'VerUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PanelVerUsuarios)
        Me.Controls.Add(Me.LabelVerUsuarios)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerUsuarios"
        Me.Text = "VerUsuario"
        Me.PanelVerUsuarios.ResumeLayout(False)
        Me.PanelVerUsuarios.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVerUsuarios As Label
    Friend WithEvents PanelVerUsuarios As Panel
    Friend WithEvents PictureBuscarUsuario As PictureBox
    Friend WithEvents BtnModifcarUsuario As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LBuscarUsuario As Label
    Friend WithEvents TBuscarUsuario As TextBox
End Class
