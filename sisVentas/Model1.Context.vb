﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure

Partial Public Class taller2Entities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=taller2Entities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property cabecera_venta() As DbSet(Of cabecera_venta)
    Public Overridable Property categoria() As DbSet(Of categoria)
    Public Overridable Property clientes() As DbSet(Of VerClientes)
    Public Overridable Property detalle_venta() As DbSet(Of detalle_venta)
    Public Overridable Property productos() As DbSet(Of productos)
    Public Overridable Property proveedores() As DbSet(Of proveedores)
    Public Overridable Property sysdiagrams() As DbSet(Of sysdiagrams)
    Public Overridable Property usuarios() As DbSet(Of usuarios)

End Class
