﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelVerUsuarios = New System.Windows.Forms.Label()
        Me.PanelVerUsuarios = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuario = New System.Windows.Forms.Label()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.BtnEliminarUsusario = New System.Windows.Forms.Button()
        Me.BtnModificarUsuario = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelVerUsuarios.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelVerUsuarios.Controls.Add(Me.DataGridView1)
        Me.PanelVerUsuarios.Controls.Add(Me.TBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.LBuscarUsuario)
        Me.PanelVerUsuarios.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerUsuarios.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerUsuarios.Name = "PanelVerUsuarios"
        Me.PanelVerUsuarios.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerUsuarios.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.GridColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridView1.Location = New System.Drawing.Point(50, 116)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(500, 150)
        Me.DataGridView1.TabIndex = 16
        '
        'TBuscarUsuario
        '
        Me.TBuscarUsuario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBuscarUsuario.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TBuscarUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TBuscarUsuario.Location = New System.Drawing.Point(122, 46)
        Me.TBuscarUsuario.Name = "TBuscarUsuario"
        Me.TBuscarUsuario.Size = New System.Drawing.Size(372, 13)
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
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(514, 31)
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
        'VerUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtnEliminarUsusario)
        Me.Controls.Add(Me.BtnModificarUsuario)
        Me.Controls.Add(Me.PanelVerUsuarios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerUsuarios"
        Me.Text = "VerUsuario"
        Me.PanelVerUsuarios.ResumeLayout(False)
        Me.PanelVerUsuarios.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
End Class
