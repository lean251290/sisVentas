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
        Dim NumeroDeFilaSeleccionada As Integer
        Dim verificar As New Cabecera
        If DataGridVerVentas.SelectedRows.Count > 0 Then
            NumeroDeFilaSeleccionada = DataGridVerVentas.CurrentRow.Index
            FrmEliminarVenta.Tag = DataGridVerVentas.SelectedRows(0).Cells(0).Value.ToString
            FrmEliminarVenta.idVenta = DataGridVerVentas.SelectedRows(0).Cells(0).Value
            If verificar.verificarVenta(FrmEliminarVenta.idVenta) Then
                FrmVentaAnulada.Show()

            Else
                FrmEliminarVenta.Show()
            End If
        Else
            FrmSeleccioneFila.Show()
        End If

    End Sub

    Private Sub DataGridVerVentas_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DataGridVerVentas.CellFormatting
        If DataGridVerVentas.Columns(e.ColumnIndex).Name = "ESTADO" Then
            If e.Value = "Anulado" Then
                e.CellStyle.ForeColor = Color.White
                e.CellStyle.BackColor = Color.Red
            End If
        End If
    End Sub
End Class