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
                    'cadena = cadena & cabe.cab_fecha & " " & cabe.cab_cliente & " " & cabe.cab_vendedor & " " & cabe.cab_total & vbCrLf
                Next
            End Using
            Return cadena
        Catch ex As Exception
            Return ""
        End Try
    End Function

End Class
