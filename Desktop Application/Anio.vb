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

Partial Public Class Anio
    Public Property IDAnio As Byte
    Public Property IDNivel As Byte
    Public Property Nombre As String
    Public Property IDAnioSiguiente As Nullable(Of Byte)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Curso As ICollection(Of Curso) = New HashSet(Of Curso)
    Public Overridable Property Nivel As Nivel

End Class
