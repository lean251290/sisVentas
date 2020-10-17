Public Class AgregarProducto
    Private Sub BtnGuardarProducto_Click(sender As Object, e As EventArgs) Handles BtnGuardarProducto.Click
        Dim precio As Double
        If TNombreProd.Text = "" Or TPrecioProd.Text = "" Or ComboBoxCat.Text = "Selecciona un categoría" Or
         TStockProd.Text = "" Then
            FrmRellenarCampos.Show()
        Else
            'p_nombre, p_categoria, p_estado, p_precio, p_stock, p_stockMinimo, p_proveedor
            precio = CType(TPrecioProd.Text, Double)
            Dim producto As New Producto(TNombreProd.Text, ComboBoxCat.SelectedValue, "Activo", precio, TStockProd.Text, 5, ComboBoxProveedor.SelectedValue)
            If producto.NuevoProducto() Then
                MsgBox("agregado")
            Else
                MsgBox("te cabio")
            End If
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




    Private Sub TNombreProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreProd.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
            (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub

    Private Sub TStockProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TStockProd.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub TPrecioProd_TextChanged(sender As Object, e As EventArgs) Handles TPrecioProd.TextChanged

    End Sub

    Private Sub TPrecioProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TPrecioProd.KeyPress
        NumConFrac(Me.TPrecioProd, e)
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmNumerosDecimales.Show()

        End If
    End Sub
    Private Sub CargarCat()
        Dim prod As New Categoria
        prod.TraerCategoria(ComboBoxCat)
    End Sub
    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBoxProveedor.Items.Add(1)
        ComboBoxProveedor.Items.Add(2)
        ComboBoxProveedor.Items.Add(3)

    End Sub


    Private Sub ComboBoxCat_Click(sender As Object, e As EventArgs) Handles ComboBoxCat.Click
        CargarCat()
    End Sub
End Class