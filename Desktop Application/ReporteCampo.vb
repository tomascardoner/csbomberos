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

Partial Public Class ReporteCampo
    Public Property IDReporte As Short
    Public Property IDCampo As Byte
    Public Property Nombre As String
    Public Property IDTipografiaEstilo As Nullable(Of Byte)
    Public Property PosicionX As Decimal
    Public Property PosicionY As Decimal
    Public Property EspaciadoY As Nullable(Of Decimal)
    Public Property EspaciadoIntercaracter As Nullable(Of Decimal)
    Public Property OffsetCaracter As Nullable(Of Decimal)
    Public Property CantidadCaracter As Nullable(Of Byte)
    Public Property AlineadoDerecha As Nullable(Of Boolean)

    Public Overridable Property Reporte As Reporte
    Public Overridable Property TipografiaEstilo As TipografiaEstilo

End Class
