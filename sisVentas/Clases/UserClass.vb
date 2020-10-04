Public Class UserClass
    Private nombre As String
    Private apellido As String
    Private dni As Integer
    Private tipo As Integer
    Private estado As Integer
    Private correo As String
    Private direccion As String
    Private pass As String
    Private imagen As Image

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONTRUCTOR CON TODOS SUS ATRIBUTOS
    Public Sub New(p_nombre, p_apellido, p_dni, p_correo, p_direccion, p_pass, p_imagen, p_tipo, p_estado)
        setNombre(p_nombre)
        setApellido(p_apellido)
        setDni(p_dni)
        setCorreo(p_correo)
        setDireccion(p_direccion)
        setPass(p_pass)
        setImagen(p_imagen)
        setTipo(p_tipo)
        setEstado(p_estado)
    End Sub
    'DECLARACION DE SETTERS
    Public Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub
    Public Sub setApellido(ByVal p_apellido As String)
        apellido = p_apellido
    End Sub
    Public Sub setDni(ByVal p_dni As Integer)
        dni = p_dni
    End Sub
    Public Sub setTipo(ByVal p_tipo As Integer)
        tipo = p_tipo
    End Sub
    Public Sub setEstado(ByVal p_estado As Integer)
        estado = p_estado
    End Sub
    Public Sub setCorreo(ByVal p_correo As String)
        correo = p_correo
    End Sub
    Public Sub setDireccion(ByVal p_direccion As String)
        direccion = p_direccion
    End Sub
    Public Sub setPass(ByVal p_pass As String)
        pass = p_pass
    End Sub
    Public Sub setImagen(ByVal p_imagen As Image)
        imagen = p_imagen
    End Sub
    'DECLARACION DE GETTERS
    Public Function getNombre()
        getNombre = nombre
    End Function
    Public Function getApellido()
        getApellido = apellido
    End Function
    Public Function getDni()
        getDni = dni
    End Function
    Public Function getTipo()
        getTipo = tipo
    End Function
    Public Function getEstado()
        getEstado = estado
    End Function
    Public Function getCorreo()
        getCorreo = correo
    End Function
    Public Function getDireccion()
        getDireccion = direccion
    End Function
    Public Function getPass()
        getPass = pass
    End Function
    Public Function getImagen()
        getImagen = imagen
    End Function


    Public Function agregarUsuario()
        Try
            Using db As New taller2Entities
                Dim obj As New Usuarios
                With obj
                    .nombre = getNombre()
                    .apellido = getApellido()
                    .dni = getDni()
                    .tipo = getTipo()
                    .estado = getEstado()
                    .correo = getCorreo()
                    .direccion = getDireccion()
                    .pass = getPass()
                    .imagen = ImageToByte(getImagen())
                End With
                'aca inserto el objeto construido en memoria
                db.usuarios.Add(obj)
                'aca se escribe en la base de datos
                db.SaveChanges()

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function verificaUser()

    End Function


End Class

