<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmErrorFechaFinal
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PbFechaErrorFinal = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnErroFechaFinal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PbFechaErrorFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PbFechaErrorFinal)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 7
        '
        'PbFechaErrorFinal
        '
        Me.PbFechaErrorFinal.Dock = System.Windows.Forms.DockStyle.Right
        Me.PbFechaErrorFinal.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PbFechaErrorFinal.Location = New System.Drawing.Point(353, 0)
        Me.PbFechaErrorFinal.Name = "PbFechaErrorFinal"
        Me.PbFechaErrorFinal.Size = New System.Drawing.Size(47, 50)
        Me.PbFechaErrorFinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PbFechaErrorFinal.TabIndex = 4
        Me.PbFechaErrorFinal.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.sisVentas.My.Resources.Resources.icoAlerta
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(53, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Error Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "La fecha final no puede ser menor a la inicial!"
        '
        'BtnErroFechaFinal
        '
        Me.BtnErroFechaFinal.BackColor = System.Drawing.Color.Transparent
        Me.BtnErroFechaFinal.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BtnErroFechaFinal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnErroFechaFinal.FlatAppearance.BorderSize = 0
        Me.BtnErroFechaFinal.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnErroFechaFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnErroFechaFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnErroFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnErroFechaFinal.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnErroFechaFinal.Location = New System.Drawing.Point(290, 157)
        Me.BtnErroFechaFinal.Name = "BtnErroFechaFinal"
        Me.BtnErroFechaFinal.Size = New System.Drawing.Size(98, 37)
        Me.BtnErroFechaFinal.TabIndex = 8
        Me.BtnErroFechaFinal.Text = "Aceptar"
        Me.BtnErroFechaFinal.UseVisualStyleBackColor = False
        '
        'FrmErrorFechaFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.BtnErroFechaFinal)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmErrorFechaFinal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PbFechaErrorFinal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnErroFechaFinal As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PbFechaErrorFinal As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
