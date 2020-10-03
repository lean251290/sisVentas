Module Efecto
    Public Sub Entrada()
        Dim efecto As Double

        For efecto = 0.0 To 1.1 Step 0.1
            FormBienvenida.Opacity = efecto
            FormBienvenida.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Public Sub Salida()
        Dim efecto As Double

        For efecto = 1.1 To 0.0 Step -0.1
            FormBienvenida.Opacity = efecto
            FormBienvenida.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub EntradaPanelAdmin()
        Dim efecto As Double

        For efecto = 0.0 To 1.1 Step 0.1
            PanelAdmin.Opacity = efecto
            PanelAdmin.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Public Sub SalidaPanelAdmin()
        Dim efecto As Double

        For efecto = 1.1 To 0.0 Step -0.1
            PanelAdmin.Opacity = efecto
            PanelAdmin.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub
    Public Sub EntradaLogin()
        Dim efecto As Double

        For efecto = 0.0 To 1.1 Step 0.1
            Login.Opacity = efecto
            Login.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

    Public Sub SalidaLogin()
        Dim efecto As Double

        For efecto = 1.1 To 0.0 Step -0.1
            Login.Opacity = efecto
            Login.Refresh()
            Threading.Thread.Sleep(100)
        Next
    End Sub

End Module
