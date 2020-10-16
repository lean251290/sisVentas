Public Class FrmAgregarCategoria


    Private Sub BtnAgregarCat_Click(sender As Object, e As EventArgs) Handles BtnAgregarCat.Click

        If TbCategoria.Text = "" Then
            MsgBox("debe agregar algo")
        Else
            Dim cat As New Categoria(TbCategoria.Text)
            If cat.AgregarCategoria() Then
                MsgBox("agregado")
                Me.Close()
                PanelAdmin.Enabled = True
                PanelAdmin.Show()
            Else
                MsgBox("error")
            End If


        End If
    End Sub

    Private Sub BtnCancelarCat_Click(sender As Object, e As EventArgs) Handles BtnCancelarCat.Click
        Me.Close()
        PanelAdmin.Enabled = True
        PanelAdmin.Show()

    End Sub

    Private Sub PBAgregarCat_Click(sender As Object, e As EventArgs) Handles PBAgregarCat.Click
        Me.Close()
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
    End Sub

    Private Sub BtnAgregarCat_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAgregarCat.MouseDown
        BtnAgregarCat.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnAgregarCat_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAgregarCat.MouseUp
        BtnAgregarCat.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarCat_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarCat.MouseDown
        BtnCancelarCat.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarCat_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarCat.MouseUp
        BtnCancelarCat.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class