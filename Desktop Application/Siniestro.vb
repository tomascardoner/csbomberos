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

Partial Public Class Siniestro
    Public Property IDSiniestro As Integer
    Public Property IDCuartel As Byte
    Public Property NumeroPrefijo As Short
    Public Property Numero As Integer
    Public Property NumeroCompleto As String
    Public Property IDSiniestroRubro As Byte
    Public Property IDSiniestroTipo As Byte
    Public Property SiniestroTipoOtro As String
    Public Property Clave As String
    Public Property ClaveNombre As String
    Public Property Fecha As Date
    Public Property HoraSalida As Nullable(Of System.TimeSpan)
    Public Property HoraFin As Nullable(Of System.TimeSpan)
    Public Property Anulado As Boolean
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property SiniestroTipo As SiniestroTipo
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property SiniestroAsistencias As ICollection(Of SiniestroAsistencia) = New HashSet(Of SiniestroAsistencia)

End Class
