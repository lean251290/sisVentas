Imports System.Data.SqlClient
Public Class FrmBackUp

    Dim conexion As New SqlConnection("SERVER=.;DATABASE=SisVentas;Uid=LEANDRO;Pwd=123asd")
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub PbBackup_Click(sender As Object, e As EventArgs) Handles PbBackup.Click
        Me.Close()
    End Sub

    Private Sub Btnbackupsi_Click(sender As Object, e As EventArgs) Handles Btnbackupsi.Click

        'Data Source=DESKTOP-PAK241P\LEAN;Initial Catalog=SisVentas;Integrated Security=True
        Dim sBackup As String = "BACKUP DATABASE SisVentas To DISK = 'C:\Desarrollo\SisVentas.bak' WITH DIFFERENTIAL"
        Dim csb As New SqlConnectionStringBuilder
        csb.DataSource = "DESKTOP-PAK241P\LEAN"
        csb.InitialCatalog = "SisVentas"
        csb.IntegratedSecurity = True
        Using con As New SqlConnection(csb.ConnectionString)
            Try
                con.Open()
                Dim cmdBackUp As New SqlCommand(sBackup, con)
                cmdBackUp.ExecuteNonQuery()
                MsgBox("Se ha creado un BackUp de La base de datos satisfactoria", vbOKOnly + vbInformation, "BackUp")
                con.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbOKOnly + vbCritical, "Error")
            End Try
        End Using

    End Sub

    Private Sub Btnbackupno_Click(sender As Object, e As EventArgs) Handles Btnbackupno.Click

    End Sub
End Class