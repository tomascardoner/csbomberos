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

Partial Public Class SiniestroTipo
    Public Property IDSiniestroRubro As Byte
    Public Property IDSiniestroTipo As Byte
    Public Property Nombre As String
    Public Property IDSiniestroClave As Nullable(Of Byte)
    Public Property Notas As String
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Siniestros As ICollection(Of Siniestro) = New HashSet(Of Siniestro)
    Public Overridable Property SiniestroRubro As SiniestroRubro
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property SiniestroClave As SiniestroClave

End Class
