﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDebeAgregarCategoria
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
        Me.PBDebeAgregarAlgo = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BDebeAgregarAlgo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PBDebeAgregarAlgo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PBDebeAgregarAlgo)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 50)
        Me.Panel1.TabIndex = 1
        '
        'PBDebeAgregarAlgo
        '
        Me.PBDebeAgregarAlgo.Dock = System.Windows.Forms.DockStyle.Right
        Me.PBDebeAgregarAlgo.Image = Global.sisVentas.My.Resources.Resources.close
        Me.PBDebeAgregarAlgo.Location = New System.Drawing.Point(353, 0)
        Me.PBDebeAgregarAlgo.Name = "PBDebeAgregarAlgo"
        Me.PBDebeAgregarAlgo.Size = New System.Drawing.Size(47, 50)
        Me.PBDebeAgregarAlgo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PBDebeAgregarAlgo.TabIndex = 4
        Me.PBDebeAgregarAlgo.TabStop = False
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
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Error"
        '
        'BDebeAgregarAlgo
        '
        Me.BDebeAgregarAlgo.BackColor = System.Drawing.Color.Transparent
        Me.BDebeAgregarAlgo.BackgroundImage = Global.sisVentas.My.Resources.Resources.btn122x45
        Me.BDebeAgregarAlgo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BDebeAgregarAlgo.FlatAppearance.BorderSize = 0
        Me.BDebeAgregarAlgo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BDebeAgregarAlgo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BDebeAgregarAlgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BDebeAgregarAlgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BDebeAgregarAlgo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BDebeAgregarAlgo.Location = New System.Drawing.Point(290, 151)
        Me.BDebeAgregarAlgo.Name = "BDebeAgregarAlgo"
        Me.BDebeAgregarAlgo.Size = New System.Drawing.Size(98, 37)
        Me.BDebeAgregarAlgo.TabIndex = 2
        Me.BDebeAgregarAlgo.Text = "Aceptar"
        Me.BDebeAgregarAlgo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(27, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Debe agregar una categoria."
        '
        'FrmDebeAgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BDebeAgregarAlgo)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmDebeAgregarCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDebeAgregarCategoria"
        Me.TopMost = True
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBDebeAgregarAlgo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PBDebeAgregarAlgo As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BDebeAgregarAlgo As Button
    Friend WithEvents Label1 As Label
End Class
