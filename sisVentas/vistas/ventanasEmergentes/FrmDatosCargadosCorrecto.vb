Public Class FrmDatosCargadosCorrecto
    Private Sub BtnDatosCargados_Click(sender As Object, e As EventArgs) Handles BtnDatosCargados.Click
        Me.Close()
        Agregar_Usuario.PBUser.Image = My.Resources.user1
    End Sub

    Private Sub PBDatosCargados_Click(sender As Object, e As EventArgs) Handles PBDatosCargados.Click
        Me.Close()
        Agregar_Usuario.PBUser.Image = My.Resources.user1
    End Sub
End Class