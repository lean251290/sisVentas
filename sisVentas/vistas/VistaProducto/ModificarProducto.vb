Public Class ModificarProducto
    Private Sub BtnActualizarProd_Click(sender As Object, e As EventArgs) Handles BtnActualizarProd.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnActualizarProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnActualizarProd.MouseDown
        BtnActualizarProd.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnActualizarProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnActualizarProd.MouseUp
        BtnActualizarProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnCancelarModifProd_Click(sender As Object, e As EventArgs) Handles BtnCancelarModifProd.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub

    Private Sub BtnCancelarModifProd_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnCancelarModifProd.MouseDown
        BtnCancelarModifProd.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnCancelarModifProd_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnCancelarModifProd.MouseUp
        BtnCancelarModifProd.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PanelAdmin.Enabled = True
        PanelAdmin.Show()
        Me.Close()
    End Sub

    Private Sub TbPrecioModifProd_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbPrecioModifProd.KeyPress
        NumConFrac(Me.TbPrecioModifProd, e)
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmNumerosDecimales.Show()
        End If
    End Sub

    Private Sub TBStockModifPrdo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockModifPrdo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub TNombreProdModif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TNombreProdModif.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
            (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub

    Private Sub CMBModifProdCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBModifProdCat.SelectedIndexChanged

    End Sub
    Public Sub CargarCatModifProd()
        Dim cat As New Categoria
        cat.TraerCategoria(CMBModifProdCat)
        CMBModifProdCat.ValueMember = "id_categoria"
        CMBModifProdCat.DisplayMember = "descripicion"
    End Sub
    Private Sub CMBModifProdCat_Click(sender As Object, e As EventArgs) Handles CMBModifProdCat.Click
        CargarCatModifProd()
    End Sub

    Private Sub ModificarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCatModifProd()
        Dim producto As New Producto()
        Dim categoria As New Categoria()
        Dim valor As Integer
        producto.traerProdId(Me.Tag)
        valor = producto.getCategoriaP

        CMBModifProdCat.SelectedValue = producto.getCategoriaP
        TNombreProdModif.Text = producto.getNombreP
        TbPrecioModifProd.Text = producto.getPrecioP
        TBStockModifPrdo.Text = producto.getStockP
        CMBModifProdCat.ValueMember = "id_categoria"
        CMBModifProdCat.DisplayMember = "descripicion"


    End Sub
End Class