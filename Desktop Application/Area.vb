'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Area
    Public Property IDArea As Short
    Public Property IDCuartel As Byte
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property MostrarEnInventario As Boolean
    Public Property MostrarEnCompras As Boolean
    Public Property Notas As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property Inventario As ICollection(Of Inventario) = New HashSet(Of Inventario)
    Public Overridable Property CompraDetalles As ICollection(Of CompraDetalle) = New HashSet(Of CompraDetalle)

End Class
