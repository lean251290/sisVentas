Imports System.IO
Public Class backup

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    'metadata=res://*/Model12.csdl|res://*/Model12.ssdl|res://*/Model12.msl;provider=System.Data.SqlClient;provider connection string="data source=DESKTOP-2CT3B8H;initial catalog=SisVentas;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework"
    Private Sub btnConectar_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        Dim conString As String = "data source=.;initial catalog=SisVentas;integrated security=True"

        Dim conexion As New SqlClient.SqlConnection
        conexion.ConnectionString = conString

        conexion.Open()

        Dim cmd As New SqlClient.SqlCommand("SELECT name from sys.databases", conexion)
        Dim da As New SqlClient.SqlDataAdapter(cmd)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            Dim fila As DataRow
            For Each fila In ds.Tables(0).Rows
                cboBaseDatos.Items.Add(fila(0).ToString)
            Next

            cboBaseDatos.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnRutaGuardar_Click_1(sender As Object, e As EventArgs) Handles btnRutaGuardar.Click
        SaveFileDialog1.Filter = "SQL Backup files|*.bak"
        SaveFileDialog1.FileName = cboBaseDatos.Text & "-" & Today.Date.ToString("dd-MM-yyyy") & "-" & TimeOfDay.ToString("h.mm") & ".bak"

        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaGuardar.Text = SaveFileDialog1.FileName
        End If
    End Sub

    Private Sub btnBackup_Click_1(sender As Object, e As EventArgs) Handles btnBackup.Click
        Try
            'Verifica que exista la carpeta, en caso contrario la crea
            If Not Directory.Exists("D:\backup") Then
                Directory.CreateDirectory("D:\backup")
            End If

            Process.Start("cmd", "/k" & "sqlcmd -S DESKTOP-2CT3B8H -E -Q ""BACKUP DATABASE [" & cboBaseDatos.Text & "] TO DISK='" & txtRutaGuardar.Text & "'""")

        Catch ex As Exception
            MessageBox.Show(Err.Description)
        End Try
    End Sub

    Private Sub btnRutaRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRutaRestaurar.Click
        OpenFileDialog1.Filter = "SQL Backup Files|*.bak"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtRutaRestaurar.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub btnRestaurar_Click_1(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        Process.Start("cmd", "/k" & "Sqlcmd -S DESKTOP-2CT3B8H -E -Q ""RESTORE DATABASE [" & txtBaseRestaurar.Text & "] FROM DISK = '" & txtRutaRestaurar.Text & "'""")
    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnConectar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnConectar.MouseDown
        btnConectar.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub btnConectar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnConectar.MouseUp
        btnConectar.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub btnRutaGuardar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRutaGuardar.MouseDown
        btnRutaGuardar.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub btnRutaGuardar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRutaGuardar.MouseUp
        btnRutaGuardar.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub btnBackup_MouseDown(sender As Object, e As MouseEventArgs) Handles btnBackup.MouseDown
        btnBackup.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub btnBackup_MouseUp(sender As Object, e As MouseEventArgs) Handles btnBackup.MouseUp
        btnBackup.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub btnRutaRestaurar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRutaRestaurar.MouseDown
        btnRutaRestaurar.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub btnRutaRestaurar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRutaRestaurar.MouseUp
        btnRutaRestaurar.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub btnRestaurar_MouseDown(sender As Object, e As MouseEventArgs) Handles btnRestaurar.MouseDown
        btnRestaurar.BackgroundImage = My.Resources.btn122x45Oscuro
    End Sub

    Private Sub btnRestaurar_MouseUp(sender As Object, e As MouseEventArgs) Handles btnRestaurar.MouseUp
        btnRestaurar.BackgroundImage = My.Resources.btn122x45
    End Sub

    Private Sub btnRestaurar_MouseHover(sender As Object, e As EventArgs) Handles btnRestaurar.MouseHover
        btnRestaurar.BackgroundImage = My.Resources.btn122x45Rojo
    End Sub

    Private Sub btnRestaurar_MouseLeave(sender As Object, e As EventArgs) Handles btnRestaurar.MouseLeave
        btnRestaurar.BackgroundImage = My.Resources.btn122x45
    End Sub
End Class

