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

Partial Public Class PersonaCambioUnidad
    Public Property IDPersona As Integer
    Public Property IDCambioUnidad As Byte
    Public Property FechaAlta As Date
    Public Property UnidadOrigen As String
    Public Property FechaBaja As Nullable(Of Date)
    Public Property UnidadDestino As String
    Public Property LibroNumero As String
    Public Property FolioNumero As String
    Public Property ActaNumero As String
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Usuario As Usuario
    Public Overridable Property Usuario1 As Usuario
    Public Overridable Property Persona As Persona

End Class
