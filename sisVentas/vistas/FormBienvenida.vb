﻿Public Class FormBienvenida
    Private Sub TimerBienvenidaAbrir_Tick(sender As Object, e As EventArgs) Handles TimerBienvenidaAbrir.Tick
        CircularProgressBar1.Value += 1
        CircularProgressBar1.Text = CircularProgressBar1.Value.ToString()
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If CircularProgressBar1.Value = 100 Then
            TimerBienvenidaAbrir.Stop()
            TimerBienvenidaCerrar.Start()
        End If
    End Sub

    Private Sub FormBienvenida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CircularProgressBar1.Value = 0
        Me.Opacity = 0
        TimerBienvenidaAbrir.Start()
    End Sub

    Private Sub TimerBienvenidaCerrar_Tick(sender As Object, e As EventArgs) Handles TimerBienvenidaCerrar.Tick
        Me.Opacity -= 0.1
        If Me.Opacity = Opacity Then
            TimerBienvenidaCerrar.Stop()
            Me.Hide()
            Login.Show()
        End If
    End Sub
End Class