Public Class Producto
    Private idP As Integer
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
    Public Sub setIdP(ByRef p_id As String)
        idP = p_id
    End Sub
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
    Public Function getIdP()
        getIdP = idP
    End Function
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
            Return False
        End Try
    End Function

    Public Function TraerProductos(ByVal gridP As DataGridView)
        Try
            Using db As New SisVentasEntities
                Dim productos = From q In db.tblProducto
                                Select
                                    ID = q.id_producto,
                                    NOMBRE = q.nombre,
                                    CATEGORÍA = q.id_categoria,
                                    ESTADO = q.estado,
                                    PRECIO = q.precio,
                                    STOCK = q.stock,
                                    STOCKMINIMO = q.stockminimo,
                                    PROVEEDOR = q.id_proveedor
                gridP.DataSource = productos.ToList
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function traerProdId(ByVal id As Integer)
        Try
            Using db As New SisVentasEntities
                Dim traerProdXId = (From p In db.tblProducto
                                    Where p.id_producto = id
                                    Select p.nombre,
                                        p.precio,
                                        p.stock,
                                        p.id_categoria
                                        ).ToList
                setNombreP(traerProdXId(0).nombre)
                setPrecioP(traerProdXId(0).precio)
                setStockP(traerProdXId(0).stock)
                setCategoriaP(traerProdXId(0).id_categoria)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TraerProductoVentaPorNombre(ByVal name As String, ByVal gridP As DataGridView)
        Try
            Using db As New SisVentasEntities
                Dim productos = From q In db.tblProducto
                                Where q.nombre.Contains(name)
                                Select
                                    ID = q.id_producto,
                                    NOMBRE = q.nombre,
                                    PRECIO = q.precio,
                                    STOCK = q.stock
                gridP.DataSource = productos.ToList
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Function TraerProductoVentaPorId(ByVal idP As Integer, ByVal gridP As DataGridView)
        Try
            Using db As New SisVentasEntities
                Dim productos = From q In db.tblProducto
                                Where q.id_producto = idP
                                Select
                                    ID = q.id_producto,
                                    NOMBRE = q.nombre,
                                    PRECIO = q.precio
                gridP.DataSource = productos.ToList
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
