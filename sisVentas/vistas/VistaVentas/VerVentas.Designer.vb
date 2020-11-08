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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.LabelVerVentas = New System.Windows.Forms.Label()
        Me.PanelVerVentas = New System.Windows.Forms.Panel()
        Me.DataGridVerVentas = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBuscarUsuario = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnAnular = New System.Windows.Forms.Button()
        Me.PanelVerVentas.SuspendLayout()
        CType(Me.DataGridVerVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.PanelVerVentas.Controls.Add(Me.DataGridVerVentas)
        Me.PanelVerVentas.Controls.Add(Me.Label2)
        Me.PanelVerVentas.Controls.Add(Me.PictureBuscarUsuario)
        Me.PanelVerVentas.Location = New System.Drawing.Point(50, 90)
        Me.PanelVerVentas.Name = "PanelVerVentas"
        Me.PanelVerVentas.Size = New System.Drawing.Size(600, 530)
        Me.PanelVerVentas.TabIndex = 8
        '
        'DataGridVerVentas
        '
        Me.DataGridVerVentas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridVerVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridVerVentas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridVerVentas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DataGridVerVentas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridVerVentas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridVerVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridVerVentas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridVerVentas.ColumnHeadersHeight = 28
        Me.DataGridVerVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Green
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.LightGray
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridVerVentas.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridVerVentas.EnableHeadersVisualStyles = False
        Me.DataGridVerVentas.GridColor = System.Drawing.Color.FromArgb(CType(CType(17, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.DataGridVerVentas.Location = New System.Drawing.Point(25, 94)
        Me.DataGridVerVentas.Name = "DataGridVerVentas"
        Me.DataGridVerVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridVerVentas.RowHeadersVisible = False
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White
        Me.DataGridVerVentas.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridVerVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridVerVentas.Size = New System.Drawing.Size(551, 395)
        Me.DataGridVerVentas.TabIndex = 23
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(21, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Ventas del día"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBuscarUsuario
        '
        Me.PictureBuscarUsuario.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBuscarUsuario.Image = Global.sisVentas.My.Resources.Resources.icoLupa
        Me.PictureBuscarUsuario.Location = New System.Drawing.Point(517, 32)
        Me.PictureBuscarUsuario.Name = "PictureBuscarUsuario"
        Me.PictureBuscarUsuario.Size = New System.Drawing.Size(36, 35)
        Me.PictureBuscarUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBuscarUsuario.TabIndex = 10
        Me.PictureBuscarUsuario.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.LabelVerVentas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnAnular
        '
        Me.BtnAnular.BackColor = System.Drawing.Color.Transparent
        Me.BtnAnular.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnAnular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnAnular.FlatAppearance.BorderSize = 0
        Me.BtnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAnular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAnular.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnAnular.Location = New System.Drawing.Point(50, 631)
        Me.BtnAnular.Name = "BtnAnular"
        Me.BtnAnular.Size = New System.Drawing.Size(98, 37)
        Me.BtnAnular.TabIndex = 24
        Me.BtnAnular.Text = "Anular "
        Me.BtnAnular.UseVisualStyleBackColor = False
        '
        'VerVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.BtnAnular)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelVerVentas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "VerVentas"
        Me.Text = "Form5"
        Me.PanelVerVentas.ResumeLayout(False)
        Me.PanelVerVentas.PerformLayout()
        CType(Me.DataGridVerVentas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBuscarUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabelVerVentas As Label
    Friend WithEvents PanelVerVentas As Panel
    Friend WithEvents PictureBuscarUsuario As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridVerVentas As DataGridView
    Friend WithEvents BtnAnular As Button
End Class
