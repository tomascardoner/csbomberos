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

Partial Public Class Reporte
    Public Property IDReporte As Short
    Public Property IDReporteGrupo As Byte
    Public Property Nombre As String
    Public Property Archivo As String
    Public Property MostrarEnVisor As Boolean
    Public Property Orden As Nullable(Of Byte)

    Public Overridable Property ReporteParametros As ICollection(Of ReporteParametro) = New HashSet(Of ReporteParametro)
    Public Overridable Property ReporteGrupo As ReporteGrupo

End Class
