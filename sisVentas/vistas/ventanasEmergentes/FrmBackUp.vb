Imports System.Data.SqlClient
Public Class FrmBackUp

    Dim conexion As New SqlConnection("SERVER=DESKTOP-PAK241P\LEAN;DATABASE=SisVentas;Uid=DESKTOP-PAK241P\Lean!")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PbBackup_Click(sender As Object, e As EventArgs) Handles PbBackup.Click
        Me.Close()
    End Sub

    Private Sub Btnbackupsi_Click(sender As Object, e As EventArgs) Handles Btnbackupsi.Click

        Dim nombre_copia As String = (Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & "-" & Date.Now.Hour.ToString & "-" & Date.Now.Minute.ToString & "-" & Date.Now.Second.ToString & "MiCopia")
        Dim comando_consulta As String = "BACKUP DATABASE [SisVentas] To  DISK = N'C:\Desarrollo" & nombre_copia & "' WITH NOFORMAT, NOINIT,  NAME = N'SisVentas-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10"
        Dim cmd As SqlCommand = New SqlCommand(comando_consulta, conexion)

        Try
            conexion.Open()
            cmd.ExecuteNonQuery()
            MsgBox("LA COPIA DE SEGURIDAD SE HA REALIZADO")
        Catch ex As Exception
            MsgBox("UPS!!! ALGO OCURRIO, CIERRE EL FORMULARIO E INTENTE NUEVAMENTE")

        Finally
            conexion.Close()
            conexion.Dispose()
        End Try

    End Sub

End Class