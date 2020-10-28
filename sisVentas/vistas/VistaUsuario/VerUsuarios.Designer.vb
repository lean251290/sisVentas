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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelVerUsuarios = New System.Windows.Forms.Label()
        Me.PanelVerUsuarios = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RBTodosLosUsuarios = New System.Windows.Forms.RadioButton()
        Me.RBUsuariosActivos = New System.Windows.Forms.RadioButton()
        Me.RBUsuariosBorrados = New System.Windows.Forms.RadioButton()
        Me.DataGridUser = New System.Windows.Forms.DataGridView()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuario = New System.Windows.Forms.Label()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.BtnEliminarUsusario = New System.Windows.Forms.Button()
        Me.BtnModificarUsuario = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAltaUser = New System.Windows.Forms.Button()
        Me.PanelVerUsuarios.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelVerUsuarios.Controls.Add(Me.GroupBox1)
        Me.PanelVerUsuarios.Controls.Add(Me.DataGridUser)
        Me.PanelVerUsuarios.Controls.Add(Me.TBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.LBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerUsuarios.Location = New System.Drawing.Point(12, 66)
        Me.PanelVerUsuarios.Name = "PanelVerUsuarios"
        Me.PanelVerUsuarios.Size = New System.Drawing.Size(656, 554)
        Me.PanelVerUsuarios.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBTodosLosUsuarios)
        Me.GroupBox1.Controls.Add(Me.RBUsuariosActivos)
        Me.GroupBox1.Controls.Add(Me.RBUsuariosBorrados)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(324, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(308, 53)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ver Por:"
        '
        'RBTodosLosUsuarios
        '
        Me.RBTodosLosUsuarios.AutoSize = True
        Me.RBTodosLosUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBTodosLosUsuarios.Location = New System.Drawing.Point(246, 30)
        Me.RBTodosLosUsuarios.Name = "RBTodosLosUsuarios"
        Me.RBTodosLosUsuarios.Size = New System.Drawing.Size(55, 17)
        Me.RBTodosLosUsuarios.TabIndex = 17
        Me.RBTodosLosUsuarios.TabStop = True
        Me.RBTodosLosUsuarios.Text = "Todos"
        Me.RBTodosLosUsuarios.UseVisualStyleBackColor = True
        '
        'RBUsuariosActivos
        '
        Me.RBUsuariosActivos.AutoSize = True
        Me.RBUsuariosActivos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBUsuariosActivos.Location = New System.Drawing.Point(6, 30)
        Me.RBUsuariosActivos.Name = "RBUsuariosActivos"
        Me.RBUsuariosActivos.Size = New System.Drawing.Size(60, 17)
        Me.RBUsuariosActivos.TabIndex = 19
        Me.RBUsuariosActivos.TabStop = True
        Me.RBUsuariosActivos.Text = "Activos"
        Me.RBUsuariosActivos.UseVisualStyleBackColor = True
        '
        'RBUsuariosBorrados
        '
        Me.RBUsuariosBorrados.AutoSize = True
        Me.RBUsuariosBorrados.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RBUsuariosBorrados.Location = New System.Drawing.Point(120, 30)
        Me.RBUsuariosBorrados.Name = "RBUsuariosBorrados"
        Me.RBUsuariosBorrados.Size = New System.Drawing.Size(75, 17)
        Me.RBUsuariosBorrados.TabIndex = 18
        Me.RBUsuariosBorrados.TabStop = True
        Me.RBUsuariosBorrados.Text = "Eliminados"
        Me.RBUsuariosBorrados.UseVisualStyleBackColor = True
        '
        'DataGridUser
        '
        Me.DataGridUser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridUser.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridUser.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridUser.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridUser.ColumnHeadersHeight = 28
        Me.DataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridUser.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridUser.EnableHeadersVisualStyles = False
        Me.DataGridUser.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DataGridUser.Location = New System.Drawing.Point(24, 166)
        Me.DataGridUser.Name = "DataGridUser"
        Me.DataGridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridUser.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridUser.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridUser.Size = New System.Drawing.Size(608, 342)
        Me.DataGridUser.TabIndex = 16
        '
        'TBuscarUsuario
        '
        Me.TBuscarUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarUsuario.Location = New System.Drawing.Point(122, 46)
        Me.TBuscarUsuario.Name = "TBuscarUsuario"
        Me.TBuscarUsuario.Size = New System.Drawing.Size(428, 13)
        Me.TBuscarUsuario.TabIndex = 15
        '
        'LBuscarUsuario
        '
        Me.LBuscarUsuario.AutoSize = True
        Me.LBuscarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBuscarUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LBuscarUsuario.Location = New System.Drawing.Point(46, 41)
        Me.LBuscarUsuario.Name = "LBuscarUsuario"
        Me.LBuscarUsuario.Size = New System.Drawing.Size(68, 20)
        Me.LBuscarUsuario.TabIndex = 13
        Me.LBuscarUsuario.Text = "Usuario:"
        Me.LBuscarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBuscarUsuario
        '
        Me.PictureBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBuscarUsuario.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(570, 31)
        Me.PictureBuscarUsuario.Name = "PictureBuscarUsuario"
        Me.PictureBuscarUsuario.Size = New System.Drawing.Size(36, 35)
        Me.PictureBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBuscarUsuario.TabIndex = 10
        Me.PictureBuscarUsuario.TabStop = False
        '
        'BtnEliminarUsusario
        '
        Me.BtnEliminarUsusario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnEliminarUsusario.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnEliminarUsusario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnEliminarUsusario.FlatAppearance.BorderSize = 0
        Me.BtnEliminarUsusario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarUsusario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnEliminarUsusario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEliminarUsusario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEliminarUsusario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnEliminarUsusario.Location = New System.Drawing.Point(552, 631)
        Me.BtnEliminarUsusario.Name = "BtnEliminarUsusario"
        Me.BtnEliminarUsusario.Size = New System.Drawing.Size(98, 37)
        Me.BtnEliminarUsusario.TabIndex = 9
        Me.BtnEliminarUsusario.Text = "Eliminar"
        Me.BtnEliminarUsusario.UseVisualStyleBackColor = True
        '
        'BtnModificarUsuario
        '
        Me.BtnModificarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnModificarUsuario.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnModificarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnModificarUsuario.FlatAppearance.BorderSize = 0
        Me.BtnModificarUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnModificarUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnModificarUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnModificarUsuario.Location = New System.Drawing.Point(446, 631)
        Me.BtnModificarUsuario.Name = "BtnModificarUsuario"
        Me.BtnModificarUsuario.Size = New System.Drawing.Size(98, 37)
        Me.BtnModificarUsuario.TabIndex = 8
        Me.BtnModificarUsuario.Text = "Modificar"
        Me.BtnModificarUsuario.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelVerUsuarios)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(54, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'BtnAltaUser
        '
        Me.BtnAltaUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnAltaUser.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAltaUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAltaUser.FlatAppearance.BorderSize = 0
        Me.BtnAltaUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAltaUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAltaUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAltaUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAltaUser.Location = New System.Drawing.Point(12, 631)
        Me.BtnAltaUser.Name = "BtnAltaUser"
        Me.BtnAltaUser.Size = New System.Drawing.Size(98, 37)
        Me.BtnAltaUser.TabIndex = 11
        Me.BtnAltaUser.Text = "Alta"
        Me.BtnAltaUser.UseVisualStyleBackColor = True
        '
        'VerUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnAltaUser)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnEliminarUsusario)
        Me.Controls.Add(Me.BtnModificarUsuario)
        Me.Controls.Add(Me.PanelVerUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerUsuarios"
        Me.Text = "VerUsuario"
        Me.PanelVerUsuarios.ResumeLayout(False)
        Me.PanelVerUsuarios.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelVerUsuarios As Label
    Friend WithEvents PanelVerUsuarios As Panel
    Friend WithEvents PictureBuscarUsuario As PictureBox
    Friend WithEvents LBuscarUsuario As Label
    Friend WithEvents TBuscarUsuario As TextBox
    Friend WithEvents BtnModificarUsuario As Button
    Friend WithEvents BtnEliminarUsusario As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents DataGridUser As DataGridView
    Friend WithEvents RBUsuariosActivos As RadioButton
    Friend WithEvents RBUsuariosBorrados As RadioButton
    Friend WithEvents RBTodosLosUsuarios As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BtnAltaUser As Button
End Class
