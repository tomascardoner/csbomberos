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

Partial Public Class PersonaFamiliar
    Public Property IDPersona As Integer
    Public Property IDFamiliar As Byte
    Public Property IDParentesco As Nullable(Of Byte)
    Public Property Apellido As String
    Public Property Nombre As String
    Public Property ApellidoNombre As String
    Public Property IDDocumentoTipo As Nullable(Of Byte)
    Public Property DocumentoNumero As String
    Public Property FechaNacimiento As Nullable(Of Date)
    Public Property Genero As String
    Public Property GrupoSanguineo As String
    Public Property FactorRH As String
    Public Property IOMATiene As String
    Public Property IOMANumeroAfiliado As String
    Public Property Vive As Nullable(Of Boolean)
    Public Property DomicilioCalle1 As String
    Public Property DomicilioNumero As String
    Public Property DomicilioPiso As String
    Public Property DomicilioDepartamento As String
    Public Property DomicilioCalle2 As String
    Public Property DomicilioCalle3 As String
    Public Property DomicilioCodigoPostal As String
    Public Property DomicilioIDProvincia As Nullable(Of Byte)
    Public Property DomicilioIDLocalidad As Nullable(Of Short)
    Public Property Telefono As String
    Public Property Celular As String
    Public Property Email As String
    Public Property EsActivo As Boolean
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Persona As Persona
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property Parentesco As Parentesco
    Public Overridable Property DocumentoTipo As DocumentoTipo
    Public Overridable Property Localidad As Localidad

End Class
