<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VerVentas))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelVerVentas = New System.Windows.Forms.Label()
        Me.PanelVerVentas = New System.Windows.Forms.Panel()
        Me.TBuscarUsuario = New System.Windows.Forms.TextBox()
        Me.LBuscarUsuario = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnModifcarUsuario = New System.Windows.Forms.Button()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.PanelVerVentas.SuspendLayout()
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
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "X"
        '
        'LabelVerVentas
        '
        Me.LabelVerVentas.AutoSize = True
        Me.LabelVerVentas.Dock = System.Windows.Forms.DockStyle.Right
        Me.LabelVerVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVerVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LabelVerVentas.Location = New System.Drawing.Point(562, 0)
        Me.LabelVerVentas.Name = "LabelVerVentas"
        Me.LabelVerVentas.Size = New System.Drawing.Size(118, 25)
        Me.LabelVerVentas.TabIndex = 6
        Me.LabelVerVentas.Text = "Ver Ventas"
        Me.LabelVerVentas.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelVerVentas
        '
        Me.PanelVerVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelVerVentas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelVerVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelVerVentas.Controls.Add(Me.TBuscarUsuario)
        Me.PanelVerVentas.Controls.Add(Me.LBuscarUsuario)
        Me.PanelVerVentas.Controls.Add(Me.BtnModifcarUsuario)
        Me.PanelVerVentas.Controls.Add(Me.DataGridView1)
        Me.PanelVerVentas.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerVentas.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerVentas.Name = "PanelVerVentas"
        Me.PanelVerVentas.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerVentas.TabIndex = 8
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
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.PanelVerVentas)
        Me.Controls.Add(Me.LabelVerVentas)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerVentas"
        Me.Text = "Form5"
        Me.PanelVerVentas.ResumeLayout(False)
        Me.PanelVerVentas.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents LabelVerVentas As Label
    Friend WithEvents PanelVerVentas As Panel
    Friend WithEvents TBuscarUsuario As TextBox
    Friend WithEvents LBuscarUsuario As Label
    Friend WithEvents BtnModifcarUsuario As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PictureBuscarUsuario As PictureBox
End Class
