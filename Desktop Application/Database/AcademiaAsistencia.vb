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

Partial Public Class AcademiaAsistencia
    Public Property IDAcademia As Integer
    Public Property IDPersona As Integer
    Public Property IDAcademiaAsistenciaTipo As Byte
    Public Property IDAsistenciaMetodo As Byte
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Academia As Academia
    Public Overridable Property AcademiaAsistenciaTipo As AcademiaAsistenciaTipo
    Public Overridable Property Persona As Persona
    Public Overridable Property AsistenciaMetodo As AsistenciaMetodo
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
