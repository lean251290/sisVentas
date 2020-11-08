﻿Public Class VerVentas
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    Public Sub verVentasXUser()
        Dim venta As New Cabecera
        venta.VerVentasPorUser(DataGridVerVentas, PanelAdmin.idUsuario)
    End Sub
    Private Sub VerVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        verVentasXUser()
    End Sub

    Private Sub DataGridVerVentas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVerVentas.CellContentClick

    End Sub

    Private Sub DataGridVerVentas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVerVentas.CellClick


    End Sub

    Private Sub DataGridVerVentas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridVerVentas.CellDoubleClick
        Dim filaSeleccionada = DataGridVerVentas.CurrentRow.Index
        VistaDetalle.idVenta = Val(DataGridVerVentas.Rows(filaSeleccionada).Cells(0).Value)
        VistaDetalle.Show()
    End Sub



    Private Sub BtnAnular_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnAnular.MouseDown
        BtnAnular.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub BtnAnular_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnAnular.MouseUp
        BtnAnular.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnAnular_Click(sender As Object, e As EventArgs) Handles BtnAnular.Click
        FrmEliminarVenta.Show()
    End Sub
End Class