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

Partial Public Class ComprobanteTipo
    Public Property IDComprobanteTipo As Byte
    Public Property OperacionTipo As String
    Public Property Sigla As String
    Public Property Nombre As String
    Public Property Letra As String
    Public Property CodigoAFIP As Byte
    Public Property EmisionElectronica As Nullable(Of Boolean)
    Public Property ReporteNombre As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date
    Public Property NombreCompleto As String
    Public Property UtilizaDetalle As Nullable(Of Boolean)
    Public Property UtilizaAplicacion As Nullable(Of Boolean)
    Public Property UtilizaMedioPago As Nullable(Of Boolean)

    Public Overridable Property ComprobanteTipoPuntoVenta As ICollection(Of ComprobanteTipoPuntoVenta) = New HashSet(Of ComprobanteTipoPuntoVenta)
    Public Overridable Property Comprobante As ICollection(Of Comprobante) = New HashSet(Of Comprobante)

End Class
