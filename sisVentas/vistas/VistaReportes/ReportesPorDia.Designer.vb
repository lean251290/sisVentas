<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportesPorDia
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
        Me.LReportes = New System.Windows.Forms.Label()
        Me.PanelReportesVentasXdia = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DTPVentasXDia = New System.Windows.Forms.DateTimePicker()
        Me.LblVentasXdia = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PBVentasXDia = New System.Windows.Forms.PictureBox()
        Me.LabelVentasXdia = New System.Windows.Forms.Label()
        Me.PanelReportesVentasXdia.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PBVentasXDia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LReportes
        '
        Me.LReportes.AutoSize = True
        Me.LReportes.Dock = System.Windows.Forms.DockStyle.Right
        Me.LReportes.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LReportes.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LReportes.Location = New System.Drawing.Point(581, 0)
        Me.LReportes.Name = "LReportes"
        Me.LReportes.Size = New System.Drawing.Size(99, 25)
        Me.LReportes.TabIndex = 1
        Me.LReportes.Text = "Reportes"
        Me.LReportes.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelReportesVentasXdia
        '
        Me.PanelReportesVentasXdia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelReportesVentasXdia.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.PanelReportesVentasXdia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanelReportesVentasXdia.Controls.Add(Me.RichTextBox1)
        Me.PanelReportesVentasXdia.Controls.Add(Me.Label8)
        Me.PanelReportesVentasXdia.Controls.Add(Me.Label7)
        Me.PanelReportesVentasXdia.Controls.Add(Me.Label4)
        Me.PanelReportesVentasXdia.Controls.Add(Me.Label1)
        Me.PanelReportesVentasXdia.Controls.Add(Me.DTPVentasXDia)
        Me.PanelReportesVentasXdia.Controls.Add(Me.LblVentasXdia)
        Me.PanelReportesVentasXdia.Location = New System.Drawing.Point(50, 90)
        Me.PanelReportesVentasXdia.Name = "PanelReportesVentasXdia"
        Me.PanelReportesVentasXdia.Size = New System.Drawing.Size(600, 530)
        Me.PanelReportesVentasXdia.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 110)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(594, 311)
        Me.RichTextBox1.TabIndex = 32
        Me.RichTextBox1.Text = ""
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(537, 92)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Total"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(101, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(309, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Vendedor"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(16, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Fecha"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DTPVentasXDia
        '
        Me.DTPVentasXDia.Cursor = System.Windows.Forms.Cursors.No
        Me.DTPVentasXDia.Enabled = False
        Me.DTPVentasXDia.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTPVentasXDia.Location = New System.Drawing.Point(135, 20)
        Me.DTPVentasXDia.Name = "DTPVentasXDia"
        Me.DTPVentasXDia.Size = New System.Drawing.Size(99, 20)
        Me.DTPVentasXDia.TabIndex = 18
        '
        'LblVentasXdia
        '
        Me.LblVentasXdia.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LblVentasXdia.AutoSize = True
        Me.LblVentasXdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVentasXdia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LblVentasXdia.Location = New System.Drawing.Point(15, 20)
        Me.LblVentasXdia.Name = "LblVentasXdia"
        Me.LblVentasXdia.Size = New System.Drawing.Size(114, 20)
        Me.LblVentasXdia.TabIndex = 16
        Me.LblVentasXdia.Text = "Ventas del día:"
        Me.LblVentasXdia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PBVentasXDia)
        Me.Panel1.Controls.Add(Me.LReportes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(680, 50)
        Me.Panel1.TabIndex = 7
        '
        'PBVentasXDia
        '
        Me.PBVentasXDia.Dock = System.Windows.Forms.DockStyle.Left
        Me.PBVentasXDia.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBVentasXDia.Location = New System.Drawing.Point(0, 0)
        Me.PBVentasXDia.Name = "PBVentasXDia"
        Me.PBVentasXDia.Size = New System.Drawing.Size(52, 50)
        Me.PBVentasXDia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBVentasXDia.TabIndex = 2
        Me.PBVentasXDia.TabStop = False
        '
        'LabelVentasXdia
        '
        Me.LabelVentasXdia.AutoSize = True
        Me.LabelVentasXdia.Dock = System.Windows.Forms.DockStyle.Left
        Me.LabelVentasXdia.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVentasXdia.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.LabelVentasXdia.Location = New System.Drawing.Point(0, 50)
        Me.LabelVentasXdia.Name = "LabelVentasXdia"
        Me.LabelVentasXdia.Size = New System.Drawing.Size(151, 25)
        Me.LabelVentasXdia.TabIndex = 8
        Me.LabelVentasXdia.Text = "Ventas por día"
        Me.LabelVentasXdia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ReportesPorDia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(680, 680)
        Me.Controls.Add(Me.LabelVentasXdia)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelReportesVentasXdia)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ReportesPorDia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.PanelReportesVentasXdia.ResumeLayout(False)
        Me.PanelReportesVentasXdia.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBVentasXDia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LReportes As Label
    Friend WithEvents PanelReportesVentasXdia As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBVentasXDia As PictureBox
    Friend WithEvents LabelVentasXdia As Label
    Friend WithEvents LblVentasXdia As Label
    Friend WithEvents DTPVentasXDia As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
