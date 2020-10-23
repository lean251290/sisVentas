Public Class VerProductos
    Private Sub BtnModificarProducto_Click(sender As Object, e As EventArgs) Handles BtnModificarProducto.Click
        Dim filaSeleccionadaProd As Integer
        If DataGridProd.SelectedRows.Count > 0 Then
            filaSeleccionadaProd = DataGridProd.CurrentRow.Index
            PanelAdmin.Enabled = False
            PanelAdmin.Hide()
            ModificarProducto.Tag = DataGridProd.SelectedRows(0).Cells(0).Value.ToString
            ModificarProducto.Show()
        End If

        PanelAdmin.Enabled = False
        PanelAdmin.Hide()
        ModificarProducto.Show()
    End Sub

    Private Sub BtnModificarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarProducto.MouseDown
        BtnModificarProducto.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarProducto.MouseUp
        BtnModificarProducto.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub BtnEliminarProducto_Click(sender As Object, e As EventArgs) Handles BtnEliminarProducto.Click
        FrmSiNoProducto.Show()
    End Sub

    Private Sub BtnEliminarProducto_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarProducto.MouseDown
        BtnEliminarProducto.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnEliminarProducto_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarProducto.MouseUp
        BtnEliminarProducto.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub TBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarCliente.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
           (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub
    Public Sub cargarGridP()
        Dim productos As New Producto()
        productos.TraerProductos(DataGridProd)
        DataGridProd.Columns(0).Visible = False
        DataGridProd.Columns(2).Visible = False
        DataGridProd.Columns(3).Visible = False
        DataGridProd.Columns(6).Visible = False
        DataGridProd.Columns(7).Visible = False
    End Sub
    Private Sub VerProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridP()
    End Sub

    Private Sub DataGridProd_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridProd.CellFormatting
        If DataGridProd.Columns(e.ColumnIndex).Name = "STOCK" Then
            If Convert.ToInt32(e.Value) <= 15 Then
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub
End Class