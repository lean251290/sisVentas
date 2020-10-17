Public Class Producto
    Private nombre As String
    Private categoria As Integer
    Private estado As String
    Private precio As Decimal
    Private stock As Integer
    Private stockMinimo As Integer
    Private proveedor As Integer

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONSTRUCTOR CON TODOS SUS ATRIBUTOS 
    Public Sub New(p_nombre As String, p_categoria As Integer, p_estado As String, p_precio As Double, p_stock As Integer, p_stockMinimo As Integer, p_proveedor As Integer)
        SetNombre(p_nombre)
        SetCategoria(p_categoria)
        SetEstado(p_estado)
        SetPrecio(p_precio)
        SetStock(p_stock)
        SetStockMinimo(p_stockMinimo)
        SetProveedor(p_proveedor)
    End Sub

    'DECLARACION DE LOS SETTERS
    Public Sub SetNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub
    Public Sub SetCategoria(ByVal p_categoria As Integer)
        categoria = p_categoria
    End Sub

    Public Sub SetEstado(ByVal p_estado As String)
        estado = p_estado
    End Sub

    Public Sub SetPrecio(ByVal p_precio As Decimal)
        precio = p_precio
    End Sub

    Public Sub SetStock(ByVal p_stock As Integer)
        stock = p_stock
    End Sub

    Public Sub SetStockMinimo(ByVal p_stockMinimo As Integer)
        stockMinimo = p_stockMinimo
    End Sub
    Public Sub SetProveedor(ByVal p_proveedor As Integer)
        proveedor = p_proveedor
    End Sub

    'DECLARAION DE LOS GETTERS
    Public Function GetNombre()
        GetNombre = nombre
    End Function

    Public Function GetCategoria()
        GetCategoria = categoria
    End Function

    Public Function GetEstado()
        GetEstado = estado
    End Function

    Public Function GetPrecio()
        GetPrecio = precio
    End Function

    Public Function GetStock()
        GetStock = stock
    End Function

    Public Function GetStockMinimo()
        GetStockMinimo = stockMinimo
    End Function

    Public Function GetProveedor()
        GetProveedor = proveedor
    End Function

    Public Function NuevoProducto()
        Try
            Using db As New SisVentasEntities
                Dim obj As New tblProducto
                With obj
                    .nombre = GetNombre()
                    .id_categoria = Val(GetCategoria())
                    .estado = GetEstado()
                    .precio = GetPrecio()
                    .stock = GetStock()
                    .stockminimo = GetStockMinimo()
                    .id_proveedor = GetProveedor()
                End With
                'aca inserto el objeto construido en memoria
                db.tblProducto.Add(obj)
                'aca se escribe en la base de datos
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
