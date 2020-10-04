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
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmNumerosDecimales.Show()
        End If
    End Sub

    Private Sub TBStockModifPrdo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBStockModifPrdo.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    Private Sub PBModifProd_Click(sender As Object, e As EventArgs) Handles PBModifProd.Click
        DialogProducto.ShowDialog()
        If DialogProducto.FileName <> "" Then
            PBModifProd.ImageLocation = DialogProducto.FileName
        End If
    End Sub

    Private Sub AgregarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CMBModifProd.Items.Add("Bebidas")
        CMBModifProd.Items.Add("Limpieza")
        CMBModifProd.Items.Add("Higiene")
        CMBModifProd.Items.Add("Lácteos")
        CMBModifProd.Items.Add("Otros")
    End Sub
End Class