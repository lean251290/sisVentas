Public Class NuevaVenta
    Public id As Integer
    Dim idCliente As Integer
    'Dim idVendedor As Integer
    Dim idUsuario As Integer

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

        idUsuario = PanelAdmin.idUsuario
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

        Dim user As New Cliente
        If DGVenta.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DGVenta.CurrentRow.Index
            idCliente = Val(DGVenta.SelectedRows(0).Cells(0).Value)
            user.TraerPorIdCliente(idCliente)
            LabelNombreCliente.Text = user.getNombre
        Else
            FrmSeleccioneFila.Show()
        End If



    End Sub

    Private Sub PBAgregarProducto_Click(sender As Object, e As EventArgs) Handles PBAgregarProducto.Click
        Dim NumeroDeFilaSeleccionada As Integer
        Dim idProd As Integer
        Dim existe As Boolean
        Dim nombre As String
        Dim precio As Double
        Dim total As Decimal
        Dim totalFRep As Decimal
        Dim cantidad As Integer
        Dim stock As Integer
        Dim subtotal As Double
        Dim prod As New Producto
        If DGVenta.SelectedRows.Count = 0 Then
            FrmSeleccioneFila.Show()
            Exit Sub
        End If

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
            Exit Sub
        End If
        If cantidad > stock Then
            MsgBox("no puede agregar no tiene stock")
            Exit Sub
        End If

        For Each fila As DataGridViewRow In DGVentaProductos.Rows
            Dim cantidadVenta As Integer
            Dim totalXFila As Integer

            If fila.Cells(0).Value = idProd Then
                existe = True
                cantidadVenta = fila.Cells(3).Value
                totalXFila = cantidadVenta + cantidad
                If totalXFila > stock Then
                    MsgBox("supera el stock")
                    Exit Sub
                Else
                    fila.Cells(3).Value = fila.Cells(3).Value + cantidad
                    fila.Cells(5).Value = fila.Cells(2).Value * fila.Cells(3).Value
                End If
            End If
        Next
        If Not existe Then
            DGVentaProductos.Rows.Add(idProd, nombre, precio, cantidad, "eliminar", subtotal)
        End If


        For Each fila As DataGridViewRow In DGVentaProductos.Rows
            total = total + fila.Cells(5).Value + totalFRep
        Next
        LblTot.Text = total

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
        Dim total As Decimal
        Dim prod As New Producto
        If e.ColumnIndex = 4 Then
            ask = MsgBox("Esta seguro de querer borrar el registro?", vbYesNo + vbExclamation + vbDefaultButton2, "Eliminar")
            If ask = vbYes Then
                fila = DGVentaProductos.CurrentRow.Index
                DGVentaProductos.Rows.Remove(DGVentaProductos.CurrentRow)
                cantidad = Val(DGVentaProductos.SelectedRows(0).Cells(3).Value)
                'prod.ActualizarStock(id, cantidad)
                For Each fila2 As DataGridViewRow In DGVentaProductos.Rows
                    total = total + fila2.Cells(5).Value
                Next
                LblTot.Text = total
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

    Private Sub BtnVender_Click(sender As Object, e As EventArgs) Handles BtnVender.Click
        Dim totalCabecera As Decimal
        Dim fecha As Date
        fecha = DateTimePicker1.Value.Date
        Decimal.TryParse(LblTot.Text, totalCabecera)
        Dim venta As New Cabecera(fecha, totalCabecera, Val(idUsuario), Val(idCliente))

        Dim idventa As Integer
        idventa = venta.VentaCabecera()
        Dim idPrdoDetalle As Integer
        Dim cantidad As Integer
        Dim subTot As Decimal
        Dim subTot2 As Decimal
        If idventa <> 0 Then
            For Each fila As DataGridViewRow In DGVentaProductos.Rows
                idPrdoDetalle = fila.Cells(0).Value
                cantidad = fila.Cells(3).Value
                subTot = fila.Cells(5).Value
                'Decimal.TryParse(subTot, subTot2)

                Dim detalle As New Detalle(idPrdoDetalle, cantidad, idventa, subTot)
                detalle.NuevoDetalle()
                Dim prod As New Producto
                prod.ActualizarStock(idPrdoDetalle, cantidad)
            Next
            PanelAdmin.cerrarFormHijo(Me)
        Else
            MsgBox("todomal")
        End If



    End Sub
End Class
