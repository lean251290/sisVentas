Public Class Agregar_Usuario
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub BtnAgregarUser_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
        PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
    End Sub

    Private Sub BtnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles BtnAgregarUsuario.Click
        Dim User As New UserClass(TNombreUsuario.Text, TApellidoUsuario.Text, TDniUsuario.Text, TDireccionUsuario.Text, TEmailUsuario.Text, TPassUsuario.Text, PictureBox1.Image)
        If User.agregarUsuario() Then
            MsgBox("correcto", vbOK, "Correcto")
        Else
            MsgBox("error", vbCritical, "error")
        End If
    End Sub



    Private Sub BtnAgregarUsuario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseUp
        BtnAgregarUsuario.ForeColor = Color.FromArgb(250, 250, 250)
        'BtnAgregarUsuario.Image = Image.FromFile(".\sisVentas\Iconos\AgregarTiulo.png")
    End Sub

    Private Sub BtnAgregarUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarUsuario.MouseDown
        BtnAgregarUsuario.ForeColor = Color.FromArgb(0, 40, 40)
        'BtnAgregarUsuario.Image = Image.FromFile(".\sisVentas\Iconos\AgregarTiulo04040.png")
    End Sub
End Class