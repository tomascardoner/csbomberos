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

Partial Public Class ReporteGrupo
    Public Property IDReporteGrupo As Byte
    Public Property IDModulo As Byte
    Public Property Nombre As String
    Public Property EsActivo As Boolean
    Public Property Orden As Nullable(Of Byte)

    Public Overridable Property Reportes As ICollection(Of Reporte) = New HashSet(Of Reporte)
    Public Overridable Property Modulo As Modulo

End Class
