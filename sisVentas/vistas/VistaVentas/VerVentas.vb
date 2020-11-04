Public Class VerVentas
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
End Class