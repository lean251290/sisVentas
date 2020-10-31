﻿Public Class VerClientes
    Private Sub Label1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub BtnModificarCliente_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseDown
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnModificarCliente_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnModificarCliente.MouseUp
        BtnModificarCliente.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminarCliente_Click(sender As Object, e As EventArgs)
        FrmSiNoCliente.Show()
    End Sub





    Private Sub TBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TBuscarCliente.KeyPress
        If Not (Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or Asc(e.KeyChar) = 8) Then
            e.Handled = True
            FrmSoloLetras.Show()
        End If
    End Sub

    'CARGAMOS EN EL DATAGRID LOS CLIENTES
    Private Sub cargarGridCliente()
        Dim cliente As New Cliente()

        cliente.Traercliente(DGVerClientes)
        DGVerClientes.Columns(0).Visible = False
    End Sub
    'CARGAMOS LOS CLIENTES
    Private Sub VerClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarGridCliente()
    End Sub

    Private Sub BtnModificarCliente_Click(sender As Object, e As EventArgs) Handles BtnModificarCliente.Click
        'creo una variable para saber si selecciono o no alguna fila del datagrid
        Dim NumeroDeFilaSeleccionada As Integer

        If DGVerClientes.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DGVerClientes.CurrentRow.Index
            PanelAdmin.Enabled = False
            PanelAdmin.Hide()
            FrmModificarCliente.Tag = DGVerClientes.SelectedRows(0).Cells(0).Value.ToString
            FrmModificarCliente.Show()
        Else
            FrmSeleccioneFila.Show()
        End If

    End Sub

    Private Sub TBuscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TBuscarCliente.TextChanged
        Dim cliente As New Cliente
        cliente.TraerPorNombre(TBuscarCliente.Text, DGVerClientes)


    End Sub

    Private Sub TBuscarCliente_LostFocus(sender As Object, e As EventArgs) Handles TBuscarCliente.LostFocus

    End Sub
End Class