Public Class Producto
    Private nombreP As String
    Private categoriaP As Integer
    Private estadoP As String
    Private precioP As Decimal
    Private stockP As Integer
    Private stockMinimoP As Integer
    Private proveedorP As Integer

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONSTRUCTOR CON TODOS SUS ATRIBUTOS 
    Public Sub New(p_nombre As String, p_categoria As Integer, p_estado As String, p_precio As Decimal, p_stock As Integer, p_stockMinimo As Integer, p_proveedor As Integer)
        setNombreP(p_nombre)
        setCategoriaP(p_categoria)
        setEstadoP(p_estado)
        setPrecioP(p_precio)
        setStockP(p_stock)
        setStockMinimoP(p_stockMinimo)
        setProveedorP(p_proveedor)
    End Sub
    'declaracion de los setters 
    Public Sub setNombreP(ByRef p_nombre As String)
        nombreP = p_nombre
    End Sub

    Public Sub setCategoriaP(ByRef p_categoria As Integer)
        categoriaP = p_categoria
    End Sub

    Public Sub setEstadoP(ByVal p_estado As String)
        estadoP = p_estado
    End Sub

    Public Sub setPrecioP(ByVal p_precio As Decimal)
        precioP = p_precio
    End Sub

    Public Sub setStockP(ByVal p_stock As Integer)
        stockP = p_stock
    End Sub

    Public Sub setStockMinimoP(ByVal p_stockMinimo As Integer)
        stockMinimoP = p_stockMinimo
    End Sub

    Public Sub setProveedorP(ByVal p_proveedor As Integer)
        proveedorP = p_proveedor
    End Sub

    'declaracion de los getters
    Public Function getNombreP()
        getNombreP = nombreP
    End Function

    Public Function getCategoriaP()
        getCategoriaP = categoriaP
    End Function

    Public Function getEstadoP()
        getEstadoP = estadoP
    End Function

    Public Function getPrecioP()
        getPrecioP = precioP
    End Function

    Public Function getStockP()
        getStockP = stockP
    End Function

    Public Function getStockMinimoP()
        getStockMinimoP = stockMinimoP
    End Function

    Public Function getProveedorP()
        getProveedorP = proveedorP
    End Function


    Public Function NuevoProducto()
        Try
            Using db As New SisVentasEntities
                Dim prod As New tblProducto
                With prod
                    .nombre = getNombreP()
                    .id_categoria = getCategoriaP()
                    .estado = getEstadoP()
                    .precio = getPrecioP()
                    .stock = getStockP()
                    .stockminimo = getStockMinimoP()
                    .id_proveedor = getProveedorP()
                End With
                'aca inserto el objeto construido en memoria
                db.tblProducto.Add(prod)
                'aca se escribe en la base de datos
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            'Return False
            MsgBox(ex.InnerException.ToString)
            MsgBox(ex.Message)
        End Try
    End Function
End Class
