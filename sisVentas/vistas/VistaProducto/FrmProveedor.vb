Public Class FrmProveedor
    Private Sub PBagregarProv_Click(sender As Object, e As EventArgs) Handles PBagregarProv.Click
        Me.Close()
    End Sub

    Private Sub BtnGuardarProv_Click(sender As Object, e As EventArgs) Handles BtnGuardarProv.Click
        Dim prov As New Proveedor(TDireccionProv.Text, TDireccionProv.Text, TTelProv.Text, TEmailProv.Text)
        If prov.AgregarProveedor() Then
            FrmDatosCargadosCorrecto.Show()
        Else
            MsgBox("Ups hubo algun error intenta de nuevo")
        End If
    End Sub
End Class