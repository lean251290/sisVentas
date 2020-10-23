Public Class Categoria
    Private categoria As String


    Public Sub New()

    End Sub

    Public Sub New(p_categoria)
        setCategoria(p_categoria)
    End Sub

    Public Sub setCategoria(ByVal p_categoria As String)
        categoria = p_categoria
    End Sub

    Public Function getCategoria()
        getCategoria = categoria
    End Function


    Public Function AgregarCategoria()
        Try
            Using db As New SisVentasEntities
                Dim cat As New tblCategoria
                With cat
                    .descripicion = getCategoria()
                End With
                db.tblCategoria.Add(cat)
                db.SaveChanges()
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


    Public Function TraerCategoria(ByRef combo As ComboBox)
        Try
            Using db As New SisVentasEntities
                Dim traerCat = From c In db.tblCategoria
                               Select
                                   c.id_categoria,
                                   c.descripicion
                combo.DataSource = traerCat.ToList
                'combo.DisplayMember = "descripicion"
                'combo.ValueMember = "id_categoria"
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Function traerCatxId(ByVal idCat As Integer)
        Try
            Using db As New SisVentasEntities
                Dim categoria = From cat In db.tblCategoria
                                Where cat.id_categoria = idCat
                                Select cat
            End Using
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
