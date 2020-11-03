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
        setCliente(p_cliente)
    End Sub

    'DECLARO TODOS LOS SETTERS
    Public Sub setFecha(ByRef p_fecha As Date)
        fecha = p_fecha
    End Sub
    Public Sub setTotal(ByRef p_total As Decimal)
        total = p_total
    End Sub
    Public Sub setUsuario(ByRef p_usuario As Integer)
        usuario = p_usuario
    End Sub
    Public Sub setCliente(ByRef p_cliente As Integer)
        cliente = p_cliente
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


    Public Function VentaCabecera()
        Try
            Using db As New SisVentasEntities
                Dim venta As New tblCabecera
                With venta
                    .fecha = getFecha()
                    .total = getTotal()
                    .id_user = getUsuario()
                    .id_cliente = getCliente()
                End With
                db.tblCabecera.Add(venta)
                db.SaveChanges()

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
