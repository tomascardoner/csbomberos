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

Partial Public Class PersonaAltaBaja
    Public Property IDPersona As Integer
    Public Property IDAltaBaja As Byte
    Public Property Tipo As String
    Public Property TipoNombre As String
    Public Property Fecha As Date
    Public Property LibroNumero As String
    Public Property FolioNumero As String
    Public Property ActaNumero As String
    Public Property OrdenGeneralNumero As String
    Public Property ResolucionNumero As String
    Public Property IDPersonaBajaMotivo As Nullable(Of Byte)
    Public Property BajaUnidadDestino As String
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Persona As Persona
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property PersonaBajaMotivo As PersonaBajaMotivo

End Class
