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

Partial Public Class Inventario
    Public Property IDInventario As Integer
    Public Property IDArea As Short
    Public Property Codigo As String
    Public Property Cantidad As Nullable(Of Short)
    Public Property IDElemento As Integer
    Public Property DescripcionPropia As String
    Public Property IDModoAdquisicion As Nullable(Of Byte)
    Public Property FechaAdquicision As Nullable(Of Date)
    Public Property IDUbicacion As Nullable(Of Short)
    Public Property IDSubUbicacion As Nullable(Of Short)
    Public Property EsActivo As Boolean
    Public Property FechaBaja As Nullable(Of Date)
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Area As Area
    Public Overridable Property Elemento As Elemento
    Public Overridable Property ModoAdquisicion As ModoAdquisicion
    Public Overridable Property SubUbicacion As SubUbicacion
    Public Overridable Property Ubicacion As Ubicacion
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
