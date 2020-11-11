Public Class GenerarTicket
    Public idTicket As Integer
    Private Sub ImprimirVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim hora As Date = Now
        hora = (Format(hora, "HH:mm:ss"))
        LblHora.Text = hora
        Dim fecha As Date
        fecha = Date.Now.Date
        LblFecha.Text = fecha

        Dim total As String
        Dim det As New Cabecera()
        total = det.GenerarTicket(idTicket)
        LblTotalTicket.Text = total

        Dim det2 As New Detalle
        det2.TraerDetalleTicket(idTicket, DGTicket)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        PrintDocument1.Print()
    End Sub
End Class