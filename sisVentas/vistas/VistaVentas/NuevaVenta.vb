Public Class NuevaVenta
    Public id As Integer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub


    Private Sub TBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()

        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBProducto.KeyPress
        If Not ((Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Or
            (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8)) Then
            e.Handled = True
            FrmNoCaracteresEspeciales.Show()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBCantidad.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 46) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloNumeros.Show()
        End If
    End Sub

    'Public Sub TraerClienteVenta()
    ' Dim cliente As New Cliente
    '     cliente.TraerPorNombre(TBuscarCliente.Text, DGVenta)
    ' End Sub
    Private Sub NuevaVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVentaProductos.Columns(0).Visible = False
        DGVentaProductos.AllowUserToAddRows = False
        DGVentaProductos.Columns(0).Width = 105
        DGVentaProductos.Columns(1).Width = 105
        DGVentaProductos.Columns(2).Width = 105
        DGVentaProductos.Columns(3).Width = 105
        DGVentaProductos.Columns(4).Width = 105
        Dim user As New Usuarios
        user.TraerPorId(PanelAdmin.idUsuario)
        LblNombreVenta.Text = user.getNombre
        PictureBox3.Visible = False
        PBAgregarProducto.Visible = False

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TBuscarCliente.TextChanged
        Dim cliente As New Cliente
        Dim cli As String
        cli = TBuscarCliente.Text
        If cli <> "" Then
            cliente.TraerPorNombre(cli, DGVenta)
        Else
            DGVenta.DataSource = Nothing
        End If

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idUser As Integer
        Dim user As New Cliente
        If DGVenta.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DGVenta.CurrentRow.Index
            idUser = Val(DGVenta.SelectedRows(0).Cells(0).Value)
            user.TraerPorIdCliente(idUser)
            LabelNombreCliente.Text = user.getNombre
        Else
            FrmSeleccioneFila.Show()
        End If



    End Sub

    Private Sub PBAgregarProducto_Click(sender As Object, e As EventArgs) Handles PBAgregarProducto.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idProd As Integer
        Dim nombre As String
        Dim precio As Double
        Dim total As Decimal
        Dim cantidad As Integer
        Dim stock As Integer
        Dim subtotal As Double
        Dim prod As New Producto
        If DGVenta.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DGVenta.CurrentRow.Index
            idProd = Val(DGVenta.SelectedRows(0).Cells(0).Value)
            prod.traerProdId(idProd)
            nombre = prod.getNombreP
            precio = prod.getPrecioP
            stock = prod.getStockP
            cantidad = Val(TBCantidad.Text)
            subtotal = precio * cantidad
            If TBCantidad.Text = "" Then
                MsgBox("debe agregar una cantidad")
            ElseIf cantidad > stock Then
                MsgBox("no puede agregar no tiene stock")
            Else
                For Each fila As DataGridViewRow In DGVentaProductos.Rows
                    If fila.Cells(0).Value = idProd Then
                        fila.Cells(3).Value = fila.Cells(3).Value + cantidad
                        fila.Cells(5).Value = fila.Cells(2).Value * fila.Cells(3).Value
                        total = total + fila.Cells(5).Value
                        Exit Sub
                    End If
                Next
                DGVentaProductos.Rows.Add(idProd, nombre, precio, cantidad, "eliminar", subtotal)
                For Each fila As DataGridViewRow In DGVentaProductos.Rows
                    total = total + fila.Cells(5).Value
                Next
            End If

            LblTot.Text = total
        Else
                FrmSeleccioneFila.Show()
        End If
    End Sub

    Private Sub TBProducto_TextChanged(sender As Object, e As EventArgs) Handles TBProducto.TextChanged
        Dim prod As New Producto
        Dim nombreP As String
        nombreP = TBProducto.Text
        If nombreP <> "" Then
            prod.TraerProductoVentaPorNombre(nombreP, DGVenta)
        Else
            DGVenta.DataSource = Nothing
        End If
    End Sub

    Private Sub TBuscarCliente_GotFocus(sender As Object, e As EventArgs) Handles TBuscarCliente.GotFocus
        PictureBox3.Visible = True
        PBAgregarProducto.Visible = False
        TBProducto.Text = ""
    End Sub



    Private Sub TBProducto_GotFocus(sender As Object, e As EventArgs) Handles TBProducto.GotFocus
        PictureBox3.Visible = False
        PBAgregarProducto.Visible = True
        TBuscarCliente.Text = ""
    End Sub


    Private Sub DGVentaProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVentaProductos.CellContentClick
        Dim ask As MsgBoxResult
        Dim cantidad As Integer
        Dim fila As Integer
        Dim prod As New Producto
        If e.ColumnIndex = 4 Then
            ask = MsgBox("Esta seguro de querer borrar el registro?", vbYesNo + vbExclamation + vbDefaultButton2, "Eliminar")
            If ask = vbYes Then
                fila = DGVentaProductos.CurrentRow.Index
                DGVentaProductos.Rows.Remove(DGVentaProductos.CurrentRow)
                cantidad = Val(DGVentaProductos.SelectedRows(0).Cells(3).Value)
                prod.ActualizarStock(id, cantidad)

            End If
        End If
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs)
        Dim ask As MsgBoxResult
        Dim cantidad As Integer
        Dim fila As Integer
        Dim prod As New Producto

        fila = DGVentaProductos.CurrentRow.Index
        DGVentaProductos.Rows.Remove(DGVentaProductos.CurrentRow)
        cantidad = Val(DGVentaProductos.SelectedRows(0).Cells(3).Value)
        prod.ActualizarStock(id, cantidad)


    End Sub
End Class
