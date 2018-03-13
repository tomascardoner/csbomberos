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

Partial Public Class PersonaSancion
    Public Property IDPersona As Integer
    Public Property IDSancion As Short
    Public Property SolicitudIDPersona As Integer
    Public Property SolicitudIDCargo As Byte
    Public Property SolicitudIDJerarquia As Byte
    Public Property SolicitudMotivo As String
    Public Property SolicitudFecha As Date
    Public Property EncuadreTexto As String
    Public Property EncuadreFecha As Nullable(Of Date)
    Public Property ResolucionIDSancionTipo As Nullable(Of Byte)
    Public Property ResolucionFecha As Nullable(Of Date)
    Public Property NotificacionFecha As Nullable(Of Date)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property CargoJerarquia As CargoJerarquia
    Public Overridable Property Persona As Persona
    Public Overridable Property PersonaSolicita As Persona
    Public Overridable Property SancionTipo As SancionTipo
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
