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

Partial Public Class PersonaLicencia
    Public Property IDPersona As Integer
    Public Property IDLicencia As Short
    Public Property Fecha As Date
    Public Property IDLicenciaCausa As Byte
    Public Property FechaDesde As Date
    Public Property FechaHasta As Date
    Public Property FechaInterrupcion As Nullable(Of Date)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property LicenciaCausa As LicenciaCausa
    Public Overridable Property Persona As Persona
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
