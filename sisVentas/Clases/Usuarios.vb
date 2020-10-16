Public Class Usuarios
    Private nombreU As String
    Private apellidoU As String
    Private dniU As String
    Private tipoU As String
    Private estadoU As String
    Private correoU As String
    Private direccionU As String
    Private passU As String
    Private imagenU As Image

    'DECLARO UN CONTRUCTOR VACIO
    Public Sub New()

    End Sub

    'DECLARO UN CONTRUCTOR CON TODOS SUS ATRIBUTOS
    Public Sub New(p_dni, p_nombre, p_apellido, p_correo, p_direccion, p_pass, p_imagen, p_tipo, p_estado)
        setDni(p_dni)
        setNombre(p_nombre)
        setApellido(p_apellido)
        setCorreo(p_correo)
        setDireccion(p_direccion)
        setPass(p_pass)
        setImagen(p_imagen)
        setTipo(p_tipo)
        setEstado(p_estado)
    End Sub
    'DECLARACION DE SETTERS
    Public Sub setNombre(ByVal p_nombre As String)
        nombreU = p_nombre
    End Sub
    Public Sub setApellido(ByVal p_apellido As String)
        apellidoU = p_apellido
    End Sub
    Public Sub setDni(ByVal p_dni As String)
        dniU = p_dni
    End Sub
    Public Sub setTipo(ByVal p_tipo As String)
        tipoU = p_tipo
    End Sub
    Public Sub setEstado(ByVal p_estado As String)
        estadoU = p_estado
    End Sub
    Public Sub setCorreo(ByVal p_correo As String)
        correoU = p_correo
    End Sub
    Public Sub setDireccion(ByVal p_direccion As String)
        direccionU = p_direccion
    End Sub
    Public Sub setPass(ByVal p_pass As String)
        passU = p_pass
    End Sub
    Public Sub setImagen(ByVal p_imagen As Image)
        imagenU = p_imagen
    End Sub
    'DECLARACION DE GETTERS
    Public Function getNombre()
        getNombre = nombreU
    End Function
    Public Function getApellido()
        getApellido = ApellidoU
    End Function
    Public Function getDni()
        getDni = dniU
    End Function
    Public Function getTipo()
        getTipo = tipoU
    End Function
    Public Function getEstado()
        getEstado = estadoU
    End Function
    Public Function getCorreo()
        getCorreo = correoU
    End Function
    Public Function getDireccion()
        getDireccion = direccionU
    End Function
    Public Function getPass()
        getPass = passU
    End Function
    Public Function getImagen()
        getImagen = imagenU
    End Function


    Public Function agregarUsuario()
        Try
            Using db As New SisVentasEntities
                Dim obj As New tblUsuarios
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
                db.tblUsuarios.Add(obj)
                'aca se escribe en la base de datos
                db.SaveChanges()

            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TraerUser(ByVal grid As DataGridView)
        Try
            Using MST As New SisVentasEntities
                Dim mostrarUser = From q In MST.tblUsuarios
                                  Select
                                    Id = q.id_user,
                                    DNI = q.dni,
                                    Nombre = q.nombre,
                                    Apellido = q.apellido,
                                    Estado = q.estado,
                                    Direccion = q.direccion,
                                    Correo = q.correo,
                                    Tipo = q.tipo,
                                    Foto = q.imagen
                grid.DataSource = mostrarUser.ToList
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TraerPorDni(query As Integer)
        Try
            Using MST As New SisVentasEntities
                Dim mostrarPorDni = (From q In MST.tblUsuarios
                                     Where q.id_user = query
                                     Select q).ToList
                setNombre(mostrarPorDni(0).nombre)
                setDni(mostrarPorDni(0).dni)
                'setApellido(mostrarPorDni(0).apellido)
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function


End Class

