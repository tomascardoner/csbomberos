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

Partial Public Class CategoriaIVA
    Public Property IDCategoriaIVA As Byte
    Public Property Nombre As String
    Public Property VentaIDComprobanteTipo As Byte
    Public Property EsActivo As Boolean

    Public Overridable Property Entidad As ICollection(Of Entidad) = New HashSet(Of Entidad)
    Public Overridable Property Comprobante As ICollection(Of Comprobante) = New HashSet(Of Comprobante)

End Class
