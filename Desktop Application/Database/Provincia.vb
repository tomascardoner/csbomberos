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

Partial Public Class Provincia
    Public Property IDProvincia As Byte
    Public Property Nombre As String
    Public Property Codigo As String

    Public Overridable Property Localidad As ICollection(Of Localidad) = New HashSet(Of Localidad)
    Public Overridable Property Partido As ICollection(Of Partido) = New HashSet(Of Partido)

End Class