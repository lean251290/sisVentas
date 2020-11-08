Public Class Detalle
    Private idDetalle As Integer
    Private producto As Integer
    Private cantidad As Integer
    Private venta As Integer
    Private subTotal As Decimal

    Public Sub New()

    End Sub

    'DECLARO UN CONSTRUCTOR CON TODOS SUS ATRIBUTOS 
    Public Sub New(p_producto As Integer, p_cantidad As Integer, p_venta As Integer, p_subtotal As Decimal)
        setProducto(p_producto)
        setCantidad(p_cantidad)
        setVenta(p_venta)
        setSubTotal(p_subtotal)
    End Sub

    'DECLARO TODOS LOS SETTERS 
    Public Sub setProducto(ByRef p_prodcuto As Integer)
        producto = p_prodcuto
    End Sub

    Public Sub setCantidad(ByRef p_cantidad As Integer)
        cantidad = p_cantidad
    End Sub

    Public Sub setVenta(ByRef p_venta As Integer)
        venta = p_venta
    End Sub
    Public Sub setSubTotal(ByRef p_subtotal As Integer)
        subTotal = p_subtotal
    End Sub

    'DECLARO TODOS LOS GETTERS 
    Public Function getProducto()
        getProducto = producto
    End Function

    Public Function getCantidad()
        getCantidad = cantidad
    End Function

    Public Function getVenta()
        getVenta = venta
    End Function
    Public Function getSubTotal()
        getSubTotal = subTotal
    End Function


    Public Function NuevoDetalle()
        Try
            Using db As New SisVentasEntities
                Dim detalle As New tblDetalle
                With detalle
                    .id_producto = getProducto()
                    .cantidad = getCantidad()
                    .id_venta = getVenta()
                    .subtotal = getSubTotal()
                End With
                db.tblDetalle.Add(detalle)
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function traerDetalle(ByVal idVenta As Integer, ByVal grid As DataGridView)
        Try
            Using db As New SisVentasEntities
                Dim detalle = (From d In db.tblDetalle
                               Join p In db.tblProducto On p.id_producto Equals d.id_producto
                               Where d.id_venta = idVenta
                               Select
                                  NOMBRE = p.nombre,
                                  CANTIDAD = d.cantidad,
                                  SUBTOTAL = d.subtotal)
                grid.DataSource = detalle.ToList
            End Using
            Return True

        Catch ex As Exception
            Return False
        End Try

    End Function


    Public Function AnularVenta(ByVal idVenta As Integer)
        Dim prod As New Producto
        Try
            Using db As New SisVentasEntities

                Dim detalle = From d In db.tblDetalle
                              Where d.id_venta = idVenta
                              Select
                                    d
                For Each d In detalle
                    prod.ActStockSuma(d.id_producto, d.cantidad)
                Next
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function



End Class
