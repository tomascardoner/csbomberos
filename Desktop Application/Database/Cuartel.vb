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

Partial Public Class Cuartel
    Public Property IDCuartel As Byte
    Public Property Codigo As String
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property DomicilioCalle1 As String
    Public Property DomicilioNumero As String
    Public Property DomicilioPiso As String
    Public Property DomicilioDepartamento As String
    Public Property DomicilioCalle2 As String
    Public Property DomicilioCalle3 As String
    Public Property DomicilioCodigoPostal As String
    Public Property DomicilioIDProvincia As Nullable(Of Byte)
    Public Property DomicilioIDLocalidad As Nullable(Of Short)
    Public Property Telefono As String
    Public Property Celular As String
    Public Property Email As String
    Public Property EsActivo As Boolean
    Public Property PrefijoSiniestro As String
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Persona As ICollection(Of Persona) = New HashSet(Of Persona)
    Public Overridable Property Localidad As Localidad
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Unidad As ICollection(Of Unidad) = New HashSet(Of Unidad)
    Public Overridable Property Area As ICollection(Of Area) = New HashSet(Of Area)
    Public Overridable Property Ubicacion As ICollection(Of Ubicacion) = New HashSet(Of Ubicacion)
    Public Overridable Property Usuarios As ICollection(Of Usuario) = New HashSet(Of Usuario)
    Public Overridable Property Responsables As ICollection(Of Responsable) = New HashSet(Of Responsable)
    Public Overridable Property CompraOrden As ICollection(Of CompraOrden) = New HashSet(Of CompraOrden)
    Public Overridable Property Siniestros As ICollection(Of Siniestro) = New HashSet(Of Siniestro)
    Public Overridable Property Academias As ICollection(Of Academia) = New HashSet(Of Academia)

End Class