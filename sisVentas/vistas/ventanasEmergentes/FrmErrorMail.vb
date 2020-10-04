Public Class FrmErrorMail


    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles BtnEmailInvalido.MouseDown
        BtnEmailInvalido.BackgroundImage = My.Resources.btn122x45Oscuro
        'Button1.ForeColor = Color.FromArgb(250, 250, 250)

    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles BtnEmailInvalido.MouseUp
        BtnEmailInvalido.BackgroundImage = My.Resources.btn122x45
    End Sub



    Private Sub BtnEmailInvalido_Click(sender As Object, e As EventArgs) Handles BtnEmailInvalido.Click
        PanelAdmin.Enabled = True
        Me.Close()
    End Sub

    Private Sub PBEmailInvalido_Click(sender As Object, e As EventArgs) Handles PBEmailInvalido.Click
        PanelAdmin.Enabled = True
        Me.Close()
    End Sub


End Class