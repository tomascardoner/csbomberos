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

Partial Public Class SiniestroAsistenciaTipoPuntaje
    Public Property IDSiniestroAsistenciaTipo As Byte
    Public Property IDSiniestroAsistenciaTipoPuntaje As Byte
    Public Property FechaInicio As Date

    Public Overridable Property SiniestroAsistenciaTipo As SiniestroAsistenciaTipo
    Public Overridable Property SiniestroAsistenciaTipoPuntajesClave As ICollection(Of SiniestroAsistenciaTipoPuntajeClave) = New HashSet(Of SiniestroAsistenciaTipoPuntajeClave)

End Class
