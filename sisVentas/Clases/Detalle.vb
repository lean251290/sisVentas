﻿Public Class Detalle
    Private producto As Integer
    Private cantidad As Integer
    Private venta As Integer



    'DECLARO UN CONSTRUCTOR CON TODOS SUS ATRIBUTOS 
    Public Sub New(p_producto As Integer, p_cantidad As Integer, p_venta As Integer)
        setProducto(p_producto)
        setCantidad(p_cantidad)
        setVenta(p_venta)
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

End Class