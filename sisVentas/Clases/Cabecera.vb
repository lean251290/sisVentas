Public Class Cabecera
    Private fecha As Date
    Private total As Decimal
    Private usuario As Integer
    Private cliente As Integer

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONSTRUCTOR CON TODOS SUS ATRIBUTOS 
    Public Sub New(p_fecha As Date, p_total As Decimal, p_usuario As Integer, p_cliente As Integer)
        setFecha(p_fecha)
        setTotal(p_total)
        setUsuario(p_usuario)
        setcliente(p_cliente)
    End Sub

    'DECLARO TODOS LOS SETTERS
    Public Sub setFecha(ByRef p_fecha As Date)
        fecha = p_fecha
    End Sub
    Public Sub setTotal(ByRef p_total As Decimal)
        total = p_total
    End Sub
    Public Sub setUsuario(ByRef p_usuarios As Integer)
        usuario = p_usuarios
    End Sub
    Public Sub setcliente(ByRef p_clientes As Integer)
        p_clientes = p_clientes
    End Sub

    'DECLARACION DE LOS GETTERS
    Public Function getFecha()
        getFecha = fecha
    End Function

    Public Function getTotal()
        getTotal = total
    End Function
    Public Function getUsuario()
        getUsuario = usuario
    End Function
    Public Function getCliente()
        getCliente = cliente
    End Function

End Class
