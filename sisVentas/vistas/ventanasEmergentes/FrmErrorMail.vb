Public Class FrmErrorMail
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Me.Close()
    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs) Handles Button1.MouseDown
        Button1.BackgroundImage = My.Resources.btn122x45Oscuro
        'Button1.ForeColor = Color.FromArgb(250, 250, 250)

    End Sub

    Private Sub Button1_MouseUp(sender As Object, e As MouseEventArgs) Handles Button1.MouseUp
        Button1.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class