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

Partial Public Class Ubicacion
    Public Property IDUbicacion As Short
    Public Property IDUbicacionPadre As Nullable(Of Short)
    Public Property Nombre As String
    Public Property EsActivo As Boolean

    Public Overridable Property Ubicacion1 As ICollection(Of Ubicacion) = New HashSet(Of Ubicacion)
    Public Overridable Property Ubicacion2 As Ubicacion

End Class
