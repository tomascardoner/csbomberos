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

Partial Public Class ComprobanteLote
    Public Property IDComprobanteLote As Integer
    Public Property FechaHora As Date
    Public Property Nombre As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ComprobanteCabecera As ICollection(Of ComprobanteCabecera) = New HashSet(Of ComprobanteCabecera)

End Class
