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

Partial Public Class CompraOrden
    Public Property IDCompraOrden As Integer
    Public Property IDCuartel As Byte
    Public Property Numero As Integer
    Public Property Fecha As Date
    Public Property IDProveedor As Short
    Public Property FacturaFecha As Nullable(Of Date)
    Public Property FacturaNumero As String
    Public Property Cerrada As Boolean
    Public Property CierreFecha As Nullable(Of Date)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property CompraOrdenDetalles As ICollection(Of CompraOrdenDetalle) = New HashSet(Of CompraOrdenDetalle)
    Public Overridable Property Proveedor As Proveedor
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property CompraOrdenFactura As ICollection(Of CompraOrdenFactura) = New HashSet(Of CompraOrdenFactura)

End Class
