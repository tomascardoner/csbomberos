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

Partial Public Class CompraOrdenDetalle
    Public Property IDCompraOrden As Integer
    Public Property IDDetalle As Byte
    Public Property IDArea As Short
    Public Property Detalle As String
    Public Property Importe As Nullable(Of Decimal)
    Public Property Notas As String
    Public Property IDCompraFactura As Nullable(Of Integer)

    Public Overridable Property Area As Area
    Public Overridable Property CompraOrden As CompraOrden
    Public Overridable Property CompraFactura As CompraFactura

End Class
