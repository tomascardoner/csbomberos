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

Partial Public Class PersonaCapacitacion
    Public Property IDPersona As Integer
    Public Property IDCapacitacion As Short
    Public Property Fecha As Date
    Public Property IDCurso As Short
    Public Property IDProvincia As Nullable(Of Byte)
    Public Property IDLocalidad As Nullable(Of Short)
    Public Property IDCapacitacionNivel As Nullable(Of Byte)
    Public Property CapacitacionNivelOtro As String
    Public Property IDCapacitacionTipo As Nullable(Of Byte)
    Public Property CapacitacionTipoOtro As String
    Public Property CantidadHoras As Nullable(Of Short)
    Public Property CantidadDias As Nullable(Of Short)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property CapacitacionNivel As CapacitacionNivel
    Public Overridable Property CapacitacionTipo As CapacitacionTipo
    Public Overridable Property Curso As Curso
    Public Overridable Property Localidad As Localidad
    Public Overridable Property Persona As Persona
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
