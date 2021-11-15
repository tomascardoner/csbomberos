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

Partial Public Class SiniestroAsistenciaTipo
    Public Property IDSiniestroAsistenciaTipo As Byte
    Public Property Nombre As String
    Public Property Abreviatura As String
    Public Property EsPresente As Boolean
    Public Property EsAusenciaJustificada As Boolean
    Public Property ExcluyeDelTotal As Boolean
    Public Property Orden As Nullable(Of Byte)
    Public Property Notas As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property SiniestrosAsistencias As ICollection(Of SiniestroAsistencia) = New HashSet(Of SiniestroAsistencia)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property SiniestrosAsistenciasTipoPuntajes As ICollection(Of SiniestroAsistenciaTipoPuntaje) = New HashSet(Of SiniestroAsistenciaTipoPuntaje)

End Class
