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

Partial Public Class MedioPago
    Public Property IDMedioPago As Byte
    Public Property Nombre As String
    Public Property EsCheque As Boolean
    Public Property UtilizaBanco As Boolean
    Public Property UtilizaFechaHora As Boolean
    Public Property UtilizaNumero As Boolean
    Public Property UtilizaCuenta As Boolean
    Public Property UtilizaTitular As Boolean
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property ComprobanteMediosPago As ICollection(Of ComprobanteMedioPago) = New HashSet(Of ComprobanteMedioPago)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario

End Class
