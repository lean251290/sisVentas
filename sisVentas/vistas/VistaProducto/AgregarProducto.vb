Public Class AgregarProducto
    Private Sub BtnGuardarProducto_Click(sender As Object, e As EventArgs) Handles BtnGuardarProducto.Click
        Dim precio As Decimal

        If TNombreProd.Text = "" Or TPrecioProd.Text = "" Or ComboBoxCat.Text = "Selecciona un categoría" Or
         TStockProd.Text = "" Then
            FrmRellenarCampos.Show()
        Else
            'p_nombre, p_categoria, p_estado, p_precio, p_stock, p_stockMinimo, p_proveedor
            'precio = FormatNumber(TPrecioProd.Text, 2)
            Decimal.TryParse(TPrecioProd.Text, precio)
            Dim producto As New Producto(TNombreProd.Text, ComboBoxCat.SelectedValue, "Activo", precio, Val(TStockProd.Text), 5, ComboBoxProveedor.SelectedValue)
            'Dim producto As New Producto()

            If producto.NuevoProducto() Then
                FmrProductoAgregado.Show()
            Else
                FrmUpsError.Show()
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
        Dim cat As New Categoria
        cat.TraerCategoria(ComboBoxCat)
    End Sub
    
    Private Sub ComboBoxCat_Click(sender As Object, e As EventArgs) Handles ComboBoxCat.Click
        CargarCat()
    End Sub

    Private Sub cargarProveedor()
        Dim pro As New Proveedor
        pro.TraerProveedor(ComboBoxProveedor)
    End Sub

    Private Sub ComboBoxProveedor_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBoxProveedor.MouseClick
        CargarProveedor()
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class