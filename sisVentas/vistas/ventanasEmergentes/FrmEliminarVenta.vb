﻿Public Class FrmEliminarVenta
    Private Sub PBCerrarEliminarVenta_Click(sender As Object, e As EventArgs) Handles PBCerrarEliminarVenta.Click
        Me.Close()
    End Sub

    Private Sub BtnEliminarVentaSi_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarVentaSi.MouseDown
        BtnEliminarVentaSi.BackgroundImage = My.Resources.btn122x45Oscuro

    End Sub

    Private Sub BtnEliminarVentaSi_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarVentaSi.MouseUp
        BtnEliminarVentaSi.BackgroundImage = My.Resources.btn122x45
    End Sub



    Private Sub BtnEliminarVentaNo_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEliminarVentaNo.MouseDown
        BtnEliminarVentaNo.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub BtnEliminarVentaNo_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEliminarVentaNo.MouseUp
        BtnEliminarVentaNo.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub BtnEliminarVentaNo_Click(sender As Object, e As EventArgs) Handles BtnEliminarVentaNo.Click
        Me.Close()
    End Sub
End Class