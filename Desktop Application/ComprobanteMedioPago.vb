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

Partial Public Class ComprobanteMedioPago
    Public Property IDComprobante As Integer
    Public Property Indice As Byte
    Public Property IDMedioPago As Byte
    Public Property FechaHora As Nullable(Of Date)
    Public Property Numero As String
    Public Property IDBanco As Nullable(Of Short)
    Public Property IDTipo As Nullable(Of Byte)
    Public Property Sucursal As Nullable(Of Short)
    Public Property Cuenta As String
    Public Property Cbu As String
    Public Property CbuAlias As String
    Public Property Cuit As Nullable(Of Long)
    Public Property Titular As String
    Public Property IDCheque As Nullable(Of Integer)
    Public Property Importe As Decimal

    Public Overridable Property Banco As Banco
    Public Overridable Property Comprobante As Comprobante
    Public Overridable Property MedioPago As MedioPago
    Public Overridable Property Cheque As Cheque

End Class
