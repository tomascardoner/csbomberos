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

Partial Public Class CalificacionConcepto
    Public Property IDCalificacionConcepto As Byte
    Public Property Abreviatura As String
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Orden As Nullable(Of Byte)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property PersonaCalificaciones As ICollection(Of PersonaCalificacion) = New HashSet(Of PersonaCalificacion)

End Class
