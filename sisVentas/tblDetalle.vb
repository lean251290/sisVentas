'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class tblDetalle
    Public Property id_detalle As Integer
    Public Property id_producto As Nullable(Of Integer)
    Public Property cantidad As Nullable(Of Integer)
    Public Property id_venta As Nullable(Of Integer)

    Public Overridable Property tblCabecera As tblCabecera
    Public Overridable Property tblProducto As tblProducto

End Class