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

Partial Public Class Proveedor
    Public Property IDProveedor As Short
    Public Property Nombre As String
    Public Property CUIT As String
    Public Property Telefono1 As String
    Public Property Telefono2 As String
    Public Property Email1 As String
    Public Property Email2 As String
    Public Property DomicilioCalle1 As String
    Public Property DomicilioNumero As String
    Public Property DomicilioPiso As String
    Public Property DomicilioDepartamento As String
    Public Property DomicilioCalle2 As String
    Public Property DomicilioCalle3 As String
    Public Property DomicilioCodigoPostal As String
    Public Property DomicilioIDProvincia As Nullable(Of Byte)
    Public Property DomicilioIDLocalidad As Nullable(Of Short)
    Public Property Notas As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Compras As ICollection(Of Compra) = New HashSet(Of Compra)
    Public Overridable Property Localidad As Localidad
    Public Overridable Property Usuario As Usuario
    Public Overridable Property Usuario1 As Usuario

End Class
