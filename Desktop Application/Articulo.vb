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

Partial Public Class Articulo
    Public Property IDArticulo As Short
    Public Property Nombre As String
    Public Property IDArticuloGrupo As Byte
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date
    Public Property IDConcepto As Byte

    Public Overridable Property ArticuloGrupo As ArticuloGrupo
    Public Overridable Property Concepto As Concepto

End Class
