Imports System.Drawing.Drawing2D
Public Class CustomControl1


    Private lapiz As Pen
    Private brocha As SolidBrush 'interna
    Private brochaInterior As SolidBrush 'externa
    Private brochaTexto As SolidBrush ' es para el texto del boton

    Private _posicionTexto As New Point(0, 0)
    Private _sobreColor As Color = Color.FromKnownColor(KnownColor.ControlDark)
    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        lapiz = New Pen(BackColor)
        brocha = New SolidBrush(Color.FromKnownColor(KnownColor.Control))
        brochaInterior = New SolidBrush(BackColor)
        brochatexto = New SolidBrush(ForeColor)
        'defino el tamaña del boton
        Me.Width = 50
        Me.Height = 50

        Me.Cursor = Cursors.Hand
    End Sub

    Protected Overrides Sub OnPaint(ByVal e As System.Windows.Forms.PaintEventArgs)
        MyBase.OnPaint(e)
        e.Graphics.FillRectangle(brocha, 0, 0, ClientSize.Width, ClientSize.Height)
        e.Graphics.DrawEllipse(lapiz, 0, 0, ClientSize.Width, ClientSize.Height)
        e.Graphics.FillEllipse(brochaInterior, 0, 0, ClientSize.Width, ClientSize.Height)
        'Agregue su código personalizado de dibujo aquí

        Dim area As New GraphicsPath
        area.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height)
        'defino la regin del area del control para que solo se haga click en el circulo
        Me.Region = New Region(area)
        AgregarTexto(e.Graphics)
    End Sub

    Private Sub CustomControl1_BackColorChanged(sender As Object, e As EventArgs) Handles Me.BackColorChanged
        lapiz.Color = BackColor
        brochaInterior.Color = BackColor
    End Sub

    Public Property PosicionTexto() As Point
        Get
            Return _posicionTexto
        End Get

        Set(value As Point)
            _posicionTexto = value
            Me.Invalidate()
        End Set
    End Property

    Private Sub AgregarTexto(ByVal g As Graphics)
        g.DrawString(Me.Text, Me.Font, brochaTexto, New PointF(_posicionTexto.X, _posicionTexto.Y))
    End Sub

    Private Sub CustomControl1_ForeColorChanged(sender As Object, e As EventArgs) Handles Me.ForeColorChanged
        brochaTexto.Color = ForeColor
    End Sub

    Private Sub CustomControl1_MouseEnter(sender As Object, e As EventArgs) Handles Me.MouseEnter
        lapiz.Color = _sobreColor
        brochaInterior.Color = _sobreColor
        Me.Invalidate()
    End Sub

    Private Sub CustomControl1_MouseLeave(sender As Object, e As EventArgs) Handles Me.MouseLeave
        lapiz.Color = BackColor
        brochaInterior.Color = BackColor
        Me.Invalidate()
    End Sub

    Public Property SobreColor() As Color
        Get
            Return _sobreColor
        End Get
        Set(value As Color)
            _sobreColor = value
        End Set
    End Property

End Class
