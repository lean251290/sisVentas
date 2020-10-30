Public Class VerUsuarios
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click
        
        Dim NumeroDeFilaSeleccionada As Integer

        If DataGridUser.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridUser.CurrentRow.Index
            PanelAdmin.Enabled = False
            PanelAdmin.Hide()
            FrmModificarUsuario.Tag = DataGridUser.SelectedRows(0).Cells(0).Value.ToString
            FrmModificarUsuario.Show()
        Else
            FrmSeleccioneFila.Show()
        End If

    End Sub

    Private Sub BtnModificarUsuario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarUsuario.MouseDown
        BtnModificarUsuario.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarUsuario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarUsuario.MouseUp
        BtnModificarUsuario.BackgroundImage = My.Resources.btn122x45

    End Sub



    Private Sub BtnEliminarUsusario_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarUsusario.MouseDown
        BtnEliminarUsusario.BackgroundImage = My.Resources.btn122x45Rojo

    End Sub

    Private Sub BtnEliminarUsusario_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarUsusario.MouseUp
        BtnEliminarUsusario.BackgroundImage = My.Resources.btn122x45

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminarUsusario_Click(sender As Object, e As EventArgs) Handles BtnEliminarUsusario.Click

        Dim NumeroDeFilaSeleccionada As Integer
        If DataGridUser.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridUser.CurrentRow.Index
            FrmSiNoUser.Show()
            FrmSiNoUser.Tag = DataGridUser.SelectedRows(0).Cells(0).Value
            cargarGridUserActivo()
        Else
            FrmSeleccioneFila.Show()
        End If
    End Sub



    Private Sub TBuscarUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarUsuario.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub

    Public Sub cargarGridUser()
        Dim users As New Usuarios()

        users.TraerUser(DataGridUser)
        DataGridUser.Columns(0).Visible = False

        CType(DataGridUser.Columns(8), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridUser.Columns(8).Width = 50
        DataGridUser.Refresh()

    End Sub
    Public Sub cargarGridUserBorrados()
        Dim users As New Usuarios()
        users.TraerUserBorrados(DataGridUser)
        DataGridUser.Columns(0).Visible = False
        CType(DataGridUser.Columns(8), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridUser.Columns(8).Width = 50
    End Sub
    Public Sub cargarGridUserActivo()
        Dim users As New Usuarios()
        users.TraerUserActivos(DataGridUser)
        DataGridUser.Columns(0).Visible = False
        CType(DataGridUser.Columns(8), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
        DataGridUser.Columns(8).Width = 50
    End Sub

    Private Sub VerUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'FUNCION PARA CARGAR EL FORMULARIO DE COSTADO
        'Dim i As Integer
        ' For i = 50 To 679
        'Me.ClientSize = New System.Drawing.Size(i, i)
        'Me.Show()
        'Next
        RBUsuariosActivos.Checked = True
        If RBUsuariosActivos.Checked = True Then
            cargarGridUserActivo()
        ElseIf RBUsuariosBorrados.Checked = True Then
            cargarGridUserBorrados()
        ElseIf RBTodosLosUsuarios.Checked = True Then
            cargarGridUser()
        End If
    End Sub

    Private Sub RBUsuariosBorrados_CheckedChanged(sender As Object, e As EventArgs) Handles RBUsuariosBorrados.CheckedChanged
        cargarGridUserBorrados()
        BtnEliminarUsusario.Visible = False
        BtnModificarUsuario.Visible = False
        BtnAltaUser.Visible = True
    End Sub

    Private Sub RBTodosLosUsuarios_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodosLosUsuarios.CheckedChanged
        cargarGridUser()
        BtnEliminarUsusario.Visible = False
        BtnModificarUsuario.Visible = False
        BtnAltaUser.Visible = False
    End Sub

    Private Sub RBUsuariosActivos_CheckedChanged(sender As Object, e As EventArgs) Handles RBUsuariosActivos.CheckedChanged
        cargarGridUserActivo()
        BtnEliminarUsusario.Visible = True
        BtnModificarUsuario.Visible = True
        BtnAltaUser.Visible = False
    End Sub

    Private Sub BtnAltaUser_Click(sender As Object, e As EventArgs) Handles BtnAltaUser.Click
        Dim user As New Usuarios
        Dim NumeroDeFilaSeleccionada As Integer
        If DataGridUser.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridUser.CurrentRow.Index
            user.AltaUser(DataGridUser.SelectedRows(0).Cells(0).Value)
            FrmDatosActualizados.Show()
            RBUsuariosActivos.Checked = True
            cargarGridUserActivo()
        Else
            FrmSeleccioneFila.Show()
        End If
    End Sub
    Private Sub TBuscarUsuario_TextChanged(sender As Object, e As EventArgs) Handles TBuscarUsuario.TextChanged
        Dim user As New Usuarios
        If RBTodosLosUsuarios.Checked = True Then
            user.BuscarUserNombre(TBuscarUsuario.Text, DataGridUser)
        ElseIf RBUsuariosActivos.Checked = True Then
            user.BuscarUserNombreActivo(TBuscarUsuario.Text, DataGridUser)
        Else
            user.BuscarUserNombreEliminado(TBuscarUsuario.Text, DataGridUser)
        End If

    End Sub
End Class