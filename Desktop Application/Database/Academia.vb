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

Partial Public Class Academia
    Public Property IDAcademia As Integer
    Public Property IDCuartel As Byte
    Public Property Fecha As Date
    Public Property IDAcademiaTipo As Byte
    Public Property AcademiaTipoOtro As String
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property AcademiasAsistencias As ICollection(Of AcademiaAsistencia) = New HashSet(Of AcademiaAsistencia)
    Public Overridable Property AcademiaTipo As AcademiaTipo
    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
