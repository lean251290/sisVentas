Public Class Proveedor
    Private nombre As String
    Private direccion As String
    Private telefono As String
    Private email As String


    Public Sub New()

    End Sub

    Public Sub New(p_nombre As String, p_direccion As String, p_telefono As String, p_email As String)
        setNombre(p_nombre)
        setDireccion(p_direccion)
        setTelefono(p_telefono)
        setEmail(p_email)
    End Sub

    Public Sub setNombre(ByVal p_nombre As String)
        nombre = p_nombre
    End Sub
    Public Sub setDireccion(ByVal p_direccion As String)
        direccion = p_direccion
    End Sub
    Public Sub setTelefono(ByVal p_telefono As String)
        telefono = p_telefono
    End Sub
    Public Sub setEmail(ByVal p_email As String)
        email = p_email
    End Sub
    Public Function getNombre()
        getNombre = nombre
    End Function
    Public Function getTelefono()
        getTelefono = telefono
    End Function
    Public Function getDireccion()
        getDireccion = direccion
    End Function
    Public Function getEmail()
        getEmail = email
    End Function

    Public Function AgregarProveedor()
        Try
            Using db As New SisVentasEntities
                Dim prov As New tblProveedores
                With prov
                    .nombre = getNombre()
                    .direccion = getDireccion()
                    .telefono = getTelefono()
                    .email = getTelefono()
                End With
                db.tblProveedores.Add(prov)
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function TraerProveedor(ByRef comboP As ComboBox)
        Try
            Using db As New SisVentasEntities
                Dim traerProv = From p In db.tblProveedores
                                Select
                                    p.id_proveedor,
                                    p.nombre,
                                    p.direccion,
                                    p.telefono,
                                    p.email
                comboP.DataSource = traerProv.ToList
                comboP.DisplayMember = "nombre"
                comboP.ValueMember = "id_proveedor"
            End Using
        Catch ex As Exception

        End Try
    End Function

End Class
