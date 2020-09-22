<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.CustomControl11 = New sisVentas.CustomControl1()
        Me.SuspendLayout()
        '
        'CustomControl11
        '
        Me.CustomControl11.BackColor = System.Drawing.Color.Black
        Me.CustomControl11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomControl11.Location = New System.Drawing.Point(192, 160)
        Me.CustomControl11.Name = "CustomControl11"
        Me.CustomControl11.PosicionTexto = New System.Drawing.Point(0, 0)
        Me.CustomControl11.Size = New System.Drawing.Size(150, 150)
        Me.CustomControl11.SobreColor = System.Drawing.SystemColors.ControlDark
        Me.CustomControl11.TabIndex = 0
        Me.CustomControl11.Text = "CustomControl11"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.CustomControl11)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CustomControl11 As CustomControl1
End Class
