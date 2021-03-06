﻿Public Class VerProductos
    Private Sub BtnModificarProducto_Click(sender As Object, e As EventArgs) Handles BtnModificarProducto.Click
        Dim filaSeleccionadaProd As Integer
        If DataGridProd.SelectedRows.Count > 0 Then
            filaSeleccionadaProd = DataGridProd.CurrentRow.Index
            PanelAdmin.Enabled = False
            PanelAdmin.Hide()
            ModificarProducto.Tag = DataGridProd.SelectedRows(0).Cells(0).Value.ToString
            ModificarProducto.Show()
            PanelAdmin.cerrarFormHijo(Me)
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
        Dim NumeroDeFilaSeleccionada As Integer
        If DataGridProd.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridProd.CurrentRow.Index
            FrmSiNoProducto.Tag = DataGridProd.SelectedRows(0).Cells(0).Value
            FrmSiNoProducto.Show()
        Else
            FrmSiNoProducto.Show()
        End If

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


    Private Sub TBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarProd.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
           (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub
    Public Sub CargarProdBorrados()
        Dim prod As New Producto
        prod.TraerProductosEliminados(DataGridProd)
        DataGridProd.Columns(0).Visible = False
        DataGridProd.Columns(2).Visible = False
        DataGridProd.Columns(3).Visible = False
        DataGridProd.Columns(6).Visible = False
        DataGridProd.Columns(7).Visible = False
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
        RBProdActivos.Checked = True
        If RBProdActivos.Checked = True Then
            cargarGridP()
        ElseIf RBprodEliminados.Checked = True Then
            CargarProdBorrados()
        End If

    End Sub

    Private Sub DataGridProd_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridProd.CellFormatting
        If DataGridProd.Columns(e.ColumnIndex).Name = "STOCK" Then
            If Convert.ToInt32(e.Value) <= 15 Then
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub RBProdActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RBProdActivos.CheckedChanged
        TBuscarProd.Text = ""
        cargarGridP()
        BtnAltaProd.Visible = False
        BtnEliminarProducto.Visible = True
        BtnModificarProducto.Visible = True
    End Sub

    Private Sub RBprodEliminados_CheckedChanged(sender As Object, e As EventArgs) Handles RBprodEliminados.CheckedChanged
        TBuscarProd.Text = ""
        CargarProdBorrados()
        BtnEliminarProducto.Visible = False
        BtnModificarProducto.Visible = False
        BtnAltaProd.Visible = True
    End Sub

    Private Sub BtnAltaProd_Click(sender As Object, e As EventArgs) Handles BtnAltaProd.Click
        Dim prod As New Producto
        Dim NumeroDeFilaSeleccionada As Integer
        If DataGridProd.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridProd.CurrentRow.Index
            prod.ActivarProd(DataGridProd.SelectedRows(0).Cells(0).Value)
            FrmDatosActualizados.Show()
            RBProdActivos.Checked = True
            cargarGridP()
        Else
            FrmSeleccioneFila.Show()
        End If
    End Sub

    Private Sub TBuscarProd_TextChanged(sender As Object, e As EventArgs) Handles TBuscarProd.TextChanged
        Dim prod As New Producto
        If RBProdActivos.Checked = True Then
            prod.TraerProductoVentaPorNombre(TBuscarProd.Text, DataGridProd)
        ElseIf RBprodEliminados.Checked = True Then
            prod.traerEliminados(TBuscarProd.Text, DataGridProd)
        End If
    End Sub

    Private Sub DataGridProd_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridProd.CellContentClick

    End Sub
End Class