Public Class AgregarCliente
    Private Sub BtnAgregarCliente_Click(sender As Object, e As EventArgs) Handles BtnAgregarCliente.Click

    End Sub

    Private Sub BtnAgregarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarCliente.MouseDown
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnAgregarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarCliente.MouseUp
        BtnAgregarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub
    Private Sub BtnCancelarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseDown
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarCliente.MouseUp
        BtnCancelarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PBAgregarCliente_Click(sender As Object, e As EventArgs) Handles PBAgregarCliente.Click
        dialogCliente.ShowDialog()
        If PBAgregarCliente.ImageLocation <> "" Then
            PBAgregarCliente.ImageLocation = dialogCliente.FileName

        End If


    End Sub
End Class