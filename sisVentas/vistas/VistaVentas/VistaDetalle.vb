Public Class VistaDetalle
    Public idVenta As Integer
    Private Sub VistaDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim det As New Detalle
        det.traerDetalle(idVenta, DGDetalle)

    End Sub



    Private Sub PBCerraDetalleDeVenta_Click(sender As Object, e As EventArgs) Handles PBCerraDetalleDeVenta.Click
        Me.Close()
    End Sub
End Class