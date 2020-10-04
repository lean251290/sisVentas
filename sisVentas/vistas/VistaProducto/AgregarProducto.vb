﻿Public Class AgregarProducto
    Private Sub BtnGuardarProducto_Click(sender As Object, e As EventArgs) Handles BtnGuardarProducto.Click
        If TNombreProd.Text = "" Or TPrecioProd.Text = "" Or ComboBoxCat.Text = "Selecciona un categoría" Or
            TStockProd.Text = "" Or PBAgregarProd.Image Is Nothing Then
            FrmRellenarCampos.Show()
        End If
    End Sub

    Private Sub BtnGuardarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnGuardarProducto.MouseDown
        BtnGuardarProducto.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnGuardarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnGuardarProducto.MouseUp
        BtnGuardarProducto.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarProd_Click(sender As Object, e As EventArgs) Handles BtnCancelarProd.Click

    End Sub

    Private Sub BtnCancelarProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarProd.MouseDown
        BtnCancelarProd.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarProd.MouseUp
        BtnCancelarProd.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub PBAgregarProd_Click(sender As Object, e As EventArgs) Handles PBAgregarProd.Click
        dialogProd.ShowDialog()
        If dialogProd.FileName <> "" Then
            PBAgregarProd.ImageLocation = dialogProd.FileName
        End If

    End Sub

    Private Sub TNombreProd_TextChanged(sender As Object, e As EventArgs) Handles TNombreProd.TextChanged

    End Sub

    Private Sub TNombreProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreProd.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
            (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub

    Private Sub TStockProd_TextChanged(sender As Object, e As EventArgs) Handles TStockProd.TextChanged

    End Sub

    Private Sub TStockProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStockProd.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub TPrecioProd_TextChanged(sender As Object, e As EventArgs) Handles TPrecioProd.TextChanged

    End Sub

    Private Sub TPrecioProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecioProd.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmNumerosDecimales.Show()

        End If
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxCat.Items.Add("Bebidas")
        ComboBoxCat.Items.Add("Limpieza")
        ComboBoxCat.Items.Add("Higiene")
        ComboBoxCat.Items.Add("Lácteos")
        ComboBoxCat.Items.Add("Otros")


    End Sub

End Class