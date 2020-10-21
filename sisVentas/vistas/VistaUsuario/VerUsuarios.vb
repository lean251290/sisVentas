Public Class VerUsuarios
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnModificarUsuario_Click(sender As Object, e As EventArgs) Handles BtnModificarUsuario.Click
        'creo una variable para saber si selecciono o no alguna fila del datagrid
        Dim NumeroDeFilaSeleccionada As Integer

        If DataGridUser.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridUser.CurrentRow.Index
            'PanelAdmin.Enabled = False
            'PanelAdmin.Hide()
            FrmModificarUsuario.Tag = DataGridUser.SelectedRows(0).Cells(0).Value.ToString
            FrmModificarUsuario.Show()
        Else
            MessageBox.Show("Selecciona una fila")
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
        FrmSiNoUser.Show()
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
        'DataGridUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub VerUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridUser()
    End Sub
End Class