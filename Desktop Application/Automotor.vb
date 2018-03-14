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

Partial Public Class Automotor
    Public Property IDAutomotor As Short
    Public Property Numero As Short
    Public Property Marca As String
    Public Property Modelo As String
    Public Property MarcaModelo As String
    Public Property NumeroMarcaModelo As String
    Public Property Anio As Short
    Public Property IDAutomotorTipo As Byte
    Public Property FechaAdquisicion As Nullable(Of Date)
    Public Property Dominio As String
    Public Property IDCombustibleTipo As Nullable(Of Byte)
    Public Property KilometrajeInicial As Nullable(Of Integer)
    Public Property CapacidadAguaLitros As Nullable(Of Integer)
    Public Property IDCuartel As Byte
    Public Property EsActivo As Boolean
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date
    Public Property NumeroMotor As String
    Public Property NumeroChasis As String
    Public Property IDAutomotorUso As Byte
    Public Property EsPropio As Boolean

    Public Overridable Property AutomotorTipo As AutomotorTipo
    Public Overridable Property CombustibleTipo As CombustibleTipo
    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Ubicacion As ICollection(Of Ubicacion) = New HashSet(Of Ubicacion)
    Public Overridable Property AutomotorUso As AutomotorUso

End Class
