Public Class Cabecera
    Private id As Integer
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
    Public Sub setId(ByRef p_id As Integer)
        id = p_id
    End Sub
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
    Public Function getId()
        getId = id
    End Function


    Public Function VentaCabecera() As Integer
        Dim id As Integer
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
                id = venta.id_venta
            End Using
            Return id
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function VerVentasPorUser(grid As DataGridView, idUser As Integer)
        Dim fechaHoy As DateTime
        fechaHoy = DateTime.Now.Date
        Dim fechaString As String
        fechaString = fechaHoy.ToShortDateString()
        Try
            Using db As New SisVentasEntities
                Dim verVentasUser = From cab In db.tblCabecera
                                    Where cab.id_user = idUser And cab.fecha = fechaString
                                    Join cli In db.tblCliente
                                    On cab.id_cliente Equals cli.id_cliente
                                    Select
                                        IDVENTA = cab.id_venta,
                                        CLIENTE = cli.nombre,
                                        FECHA = cab.fecha,
                                        TOTAL = cab.total
                grid.DataSource = verVentasUser.ToList

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function reportes(ByVal fechaI As String, ByVal fechaFinal As String, ByVal mail As String)
        Dim cadena As String = ""

        Dim output As New System.Text.StringBuilder
        Try
            Using db As New SisVentasEntities
                Dim repo = From cabe In db.tblCabecera
                           Join usua In db.tblUsuarios On usua.id_user Equals cabe.id_user
                           Join clie In db.tblCliente On clie.id_cliente Equals cabe.id_cliente
                           Where cabe.fecha >= fechaI And cabe.fecha <= fechaFinal And usua.correo.Contains(mail)
                           Select
                               cab_fecha = cabe.fecha,
                               cab_total = cabe.total,
                               cab_cliente = clie.nombre & " " & clie.apellido,
                               cab_vendedor = usua.nombre & " " & usua.apellido

                For Each cabe In repo

                    Dim fechaHoy As DateTime
                    fechaHoy = cabe.cab_fecha
                    Dim fechaString As String = fechaHoy.ToShortDateString()

                    Dim StrFecha As String = fechaString & Space(11 - fechaString.Length)
                    Dim StrCliente As String = cabe.cab_cliente & Space(30 - cabe.cab_cliente.ToString.Length)
                    Dim StrVendedor As String = cabe.cab_vendedor & Space(30 - cabe.cab_vendedor.ToString.Length)
                    Dim StrTotal As String = Space(11 - Format(cabe.cab_total, "$ #0.00").Length) & Format(cabe.cab_total, "$ #0.00")

                    cadena = cadena & StrFecha & StrCliente & StrVendedor & StrTotal & vbCrLf
                    'cadena = cadena & cabe.cab_fecha & " " & cabe.cab_cliente & " " & cabe.cab_vendedor & " " & cabe.cab_total & vbCrLf
                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function reportesPorDia()
        Dim fechaActual As DateTime
        fechaActual = DateTime.Now.Date
        Dim fechaCadena As String
        fechaCadena = fechaActual.ToShortDateString()
        Dim cadena As String = ""
        Dim output As New System.Text.StringBuilder
        Try
            Using db As New SisVentasEntities
                Dim repo = From cabe In db.tblCabecera
                           Join usua In db.tblUsuarios On usua.id_user Equals cabe.id_user
                           Join clie In db.tblCliente On clie.id_cliente Equals cabe.id_cliente
                           Where cabe.fecha = fechaCadena
                           Select
                               cab_fecha = cabe.fecha,
                               cab_total = cabe.total,
                               cab_cliente = clie.nombre & " " & clie.apellido,
                               cab_vendedor = usua.nombre & " " & usua.apellido

                For Each cabe In repo

                    Dim fechaHoy As DateTime
                    fechaHoy = cabe.cab_fecha
                    Dim fechaString As String = fechaHoy.ToShortDateString()

                    Dim StrFecha As String = fechaString & Space(11 - fechaString.Length)
                    Dim StrCliente As String = cabe.cab_cliente & Space(30 - cabe.cab_cliente.ToString.Length)
                    Dim StrVendedor As String = cabe.cab_vendedor & Space(30 - cabe.cab_vendedor.ToString.Length)
                    Dim StrTotal As String = Space(11 - Format(cabe.cab_total, "$ #0.00").Length) & Format(cabe.cab_total, "$ #0.00")
                    cadena = cadena & StrFecha & StrCliente & StrVendedor & StrTotal & vbCrLf
                    'cadena = cadena & cabe.cab_fecha & " " & cabe.cab_cliente & " " & cabe.cab_vendedor & " " & cabe.cab_total & vbCrLf
                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function reportesPorUsuario(ByVal name As String)

        Dim cadena As String = ""
        Dim output As New System.Text.StringBuilder
        Try
            Using db As New SisVentasEntities
                Dim repo = From cabe In db.tblCabecera
                           Join usua In db.tblUsuarios On usua.id_user Equals cabe.id_user
                           Join clie In db.tblCliente On clie.id_cliente Equals cabe.id_cliente
                           Where usua.nombre.Contains(name)
                           Select
                              cab_fecha = cabe.fecha,
                              cab_total = cabe.total,
                              cab_cliente = clie.nombre & " " & clie.apellido,
                              cab_vendedor = usua.nombre & " " & usua.apellido

                For Each cabe In repo

                    Dim fechaHoy As DateTime
                    fechaHoy = cabe.cab_fecha
                    Dim fechaString As String = fechaHoy.ToShortDateString()

                    Dim StrFecha As String = fechaString & Space(11 - fechaString.Length)
                    Dim StrCliente As String = cabe.cab_cliente & Space(30 - cabe.cab_cliente.ToString.Length)
                    Dim StrVendedor As String = cabe.cab_vendedor & Space(30 - cabe.cab_vendedor.ToString.Length)
                    Dim StrTotal As String = Space(11 - Format(cabe.cab_total, "$ #0.00").Length) & Format(cabe.cab_total, "$ #0.00")
                    cadena = cadena & StrFecha & StrCliente & StrVendedor & StrTotal & vbCrLf
                    'cadena = cadena & cabe.cab_fecha & " " & cabe.cab_cliente & " " & cabe.cab_vendedor & " " & cabe.cab_total & vbCrLf
                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function reportesPorCliente(ByVal name As String)

        Dim cadena As String = ""
        Dim output As New System.Text.StringBuilder
        Try
            Using db As New SisVentasEntities
                Dim repo = From cabe In db.tblCabecera
                           Join usua In db.tblUsuarios On usua.id_user Equals cabe.id_user
                           Join clie In db.tblCliente On clie.id_cliente Equals cabe.id_cliente
                           Where clie.nombre.Contains(name)
                           Select
                              cab_fecha = cabe.fecha,
                              cab_total = cabe.total,
                              cab_cliente = clie.nombre & " " & clie.apellido,
                              cab_vendedor = usua.nombre & " " & usua.apellido

                For Each cabe In repo

                    Dim fechaHoy As DateTime
                    fechaHoy = cabe.cab_fecha
                    Dim fechaString As String = fechaHoy.ToShortDateString()

                    Dim StrFecha As String = fechaString & Space(11 - fechaString.Length)
                    Dim StrCliente As String = cabe.cab_cliente & Space(30 - cabe.cab_cliente.ToString.Length)
                    Dim StrVendedor As String = cabe.cab_vendedor & Space(30 - cabe.cab_vendedor.ToString.Length)
                    Dim StrTotal As String = Space(11 - Format(cabe.cab_total, "$ #0.00").Length) & Format(cabe.cab_total, "$ #0.00")
                    cadena = cadena & StrFecha & StrCliente & StrVendedor & StrTotal & vbCrLf

                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function CabeceraDetalle(ByVal fechaI As String, ByVal fechaFinal As String, ByVal mail As String)
        Dim cadena As String = ""
        Dim cadena2 As String = ""


        Dim output As New System.Text.StringBuilder
        Try
            Using db As New SisVentasEntities
                Dim repo = From cabe In db.tblCabecera
                           Join detalle In db.tblDetalle On detalle.id_venta Equals cabe.id_venta
                           Join prod In db.tblProducto On prod.id_producto Equals detalle.id_producto
                           Join usua In db.tblUsuarios On usua.id_user Equals cabe.id_user
                           Join clie In db.tblCliente On clie.id_cliente Equals cabe.id_cliente
                           Where usua.correo.Contains(mail)
                           Select
                               cab_idVenta = cabe.id_venta,
                               detalle_idVenta = detalle.id_venta,
                               cab_fecha = cabe.fecha,
                               cab_total = cabe.total,
                               cab_cliente = clie.nombre & " " & clie.apellido,
                               cab_vendedor = usua.nombre & " " & usua.apellido,
                               detalle_producto = prod.nombre,
                               detalle_cantidad = detalle.cantidad,
                               detalle_subtotal = detalle.subtotal

                For Each cabe In repo

                    Dim fechaHoy As DateTime
                    fechaHoy = cabe.cab_fecha
                    Dim fechaString As String = fechaHoy.ToShortDateString()
                    Dim StrFecha As String = fechaString & Space(11 - fechaString.Length)
                    Dim StrCliente As String = cabe.cab_cliente & Space(30 - cabe.cab_cliente.ToString.Length)
                    Dim StrVendedor As String = cabe.cab_vendedor & Space(30 - cabe.cab_vendedor.ToString.Length)
                    Dim StrTotal As String = Space(10 - Format(cabe.cab_total, "$ #0.00").Length) & Format(cabe.cab_total, "$ #0.00")

                    cadena = cadena & StrFecha & StrCliente & StrVendedor & StrTotal & vbCrLf & vbCrLf
                    For Each detalle In repo
                        If detalle.detalle_idVenta = cabe.cab_idVenta Then
                            Dim StrProducto As String = vbTab & detalle.detalle_producto & Space(30 - detalle.detalle_producto.ToString.Length)
                            Dim detalleCantidad As String = detalle.detalle_cantidad & Space(30 - detalle.detalle_cantidad.ToString.Length)
                            Dim detalleStrTotal As String = Space(10 - Format(detalle.detalle_subtotal, "$ #0.00").Length) & Format(detalle.detalle_subtotal, "$ #0.00") & vbCrLf
                            cadena2 = cadena2 & StrProducto & detalleCantidad & detalleStrTotal
                        End If
                    Next

                    cadena = cadena & cadena2 & vbCrLf
                    cadena2 = ""
                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function AnularVenta(ByVal p_id As Integer)
        Try
            Using db As New SisVentasEntities

            End Using
        Catch ex As Exception

        End Try
    End Function

End Class
