Public Class Cliente
    Private nombreC As String
    Private apellidoC As String
    Private dniC As String
    Private correoC As String
    Private direccionC As String
    Private telefonoC As String

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONTRUCTOR CON TODOS SUS ATRIBUTOS
    Public Sub New(p_nombre, p_apellido, p_dni, p_correo, p_direccion, p_telefono)
        setNombre(p_nombre)
        setApellido(p_apellido)
        setDni(p_dni)
        setCorreo(p_correo)
        setDireccion(p_direccion)
        setTelefono(p_telefono)
    End Sub

    'DECLARACION DE SETTERS
    Public Sub setNombre(ByVal p_nombre As String)
        nombreC = p_nombre
    End Sub
    Public Sub setApellido(ByVal p_apellido As String)
        apellidoC = p_apellido
    End Sub
    Public Sub setDni(ByVal p_dni As String)
        dniC = p_dni
    End Sub

    Public Sub setCorreo(ByVal p_correo As String)
        correoC = p_correo
    End Sub
    Public Sub setDireccion(ByVal p_direccion As String)
        direccionC = p_direccion
    End Sub

    Public Sub setTelefono(ByVal p_telefono As String)
        telefonoC = p_telefono
    End Sub

    'DECLARACION DE GETTERS
    Public Function getNombre()
        getNombre = nombreC
    End Function
    Public Function getApellido()
        getApellido = apellidoC
    End Function
    Public Function getDni()
        getDni = dniC
    End Function
    Public Function getCorreo()
        getCorreo = correoC
    End Function
    Public Function getDireccion()
        getDireccion = direccionC
    End Function
    Public Function getTelefono()
        getTelefono = telefonoC
    End Function

    Public Function AgregarCliente()
        Try
            'INSTANCIA UNA NUEVA CONEXION (DB)
            Using db As New SisVentasEntities
                Dim cli As New tblCliente
                With cli
                    .nombre = getNombre()
                    .apellido = getApellido()
                    .dni = getDni()
                    .correo = getCorreo()
                    .direccion = getDireccion()
                    .telefono = getTelefono()
                End With
                'aca inserto el objeto construido en memoria
                db.tblCliente.Add(cli)
                'aca se escribe en la base de datos
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
