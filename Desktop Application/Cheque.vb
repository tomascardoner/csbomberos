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

Partial Public Class Cheque
    Public Property IDCheque As Integer
    Public Property IDBanco As Nullable(Of Short)
    Public Property FechaEmision As Nullable(Of Date)
    Public Property FechaPago As Nullable(Of Date)
    Public Property Numero As String
    Public Property Importe As Decimal
    Public Property Cuenta As String
    Public Property CUIT As String
    Public Property Titular As String
    Public Property CodigoPostal As String
    Public Property Estado As String
    Public Property IDChequeMotivoRechazo As Nullable(Of Byte)

    Public Overridable Property Banco As Banco
    Public Overridable Property ComprobanteMedioPago As ICollection(Of ComprobanteMedioPago) = New HashSet(Of ComprobanteMedioPago)

End Class
