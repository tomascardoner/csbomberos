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

Partial Public Class Persona
    Public Property IDPersona As Integer
    Public Property Foto As Byte()
    Public Property MatriculaNumero As String
    Public Property Apellido As String
    Public Property Nombre As String
    Public Property ApellidoNombre As String
    Public Property IDDocumentoTipo As Nullable(Of Byte)
    Public Property DocumentoNumero As String
    Public Property LicenciaConducirNumero As String
    Public Property LicenciaConducirVencimiento As Nullable(Of Date)
    Public Property FechaNacimiento As Nullable(Of Date)
    Public Property Genero As String
    Public Property GrupoSanguineo As String
    Public Property FactorRH As String
    Public Property IOMATiene As String
    Public Property IOMANumeroAfiliado As String
    Public Property IDNivelEstudio As Nullable(Of Byte)
    Public Property Profesion As String
    Public Property Nacionalidad As String
    Public Property IDCuartel As Byte
    Public Property DomicilioParticularCalle1 As String
    Public Property DomicilioParticularNumero As String
    Public Property DomicilioParticularPiso As String
    Public Property DomicilioParticularDepartamento As String
    Public Property DomicilioParticularCalle2 As String
    Public Property DomicilioParticularCalle3 As String
    Public Property DomicilioParticularCodigoPostal As String
    Public Property DomicilioParticularIDProvincia As Nullable(Of Byte)
    Public Property DomicilioParticularIDLocalidad As Nullable(Of Short)
    Public Property TelefonoParticular As String
    Public Property CelularParticular As String
    Public Property EmailParticular As String
    Public Property DomicilioLaboralCalle1 As String
    Public Property DomicilioLaboralNumero As String
    Public Property DomicilioLaboralPiso As String
    Public Property DomicilioLaboralDepartamento As String
    Public Property DomicilioLaboralCalle2 As String
    Public Property DomicilioLaboralCalle3 As String
    Public Property DomicilioLaboralCodigoPostal As String
    Public Property DomicilioLaboralIDProvincia As Nullable(Of Byte)
    Public Property DomicilioLaboralIDLocalidad As Nullable(Of Short)
    Public Property TelefonoLaboral As String
    Public Property CelularLaboral As String
    Public Property EmailLaboral As String
    Public Property EsActivo As Boolean
    Public Property Notas As String
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property DocumentoTipo As DocumentoTipo
    Public Overridable Property LocalidadLaboral As Localidad
    Public Overridable Property LocalidadParticular As Localidad
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property PersonaFamiliares As ICollection(Of PersonaFamiliar) = New HashSet(Of PersonaFamiliar)
    Public Overridable Property NivelEstudio As NivelEstudio
    Public Overridable Property PersonaAccidentes As ICollection(Of PersonaAccidente) = New HashSet(Of PersonaAccidente)
    Public Overridable Property PersonaAltasBajas As ICollection(Of PersonaAltaBaja) = New HashSet(Of PersonaAltaBaja)
    Public Overridable Property PersonaAscensos As ICollection(Of PersonaAscenso) = New HashSet(Of PersonaAscenso)
    Public Overridable Property PersonaCalificaciones As ICollection(Of PersonaCalificacion) = New HashSet(Of PersonaCalificacion)
    Public Overridable Property PersonaCambiosUnidad As ICollection(Of PersonaCambioUnidad) = New HashSet(Of PersonaCambioUnidad)
    Public Overridable Property PersonaCapacitaciones As ICollection(Of PersonaCapacitacion) = New HashSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaExamenes As ICollection(Of PersonaExamen) = New HashSet(Of PersonaExamen)
    Public Overridable Property PersonaLicencias As ICollection(Of PersonaLicencia) = New HashSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicenciaConducirCategorias As ICollection(Of PersonaLicenciaConducirCategoria) = New HashSet(Of PersonaLicenciaConducirCategoria)
    Public Overridable Property PersonaSanciones As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)
    Public Overridable Property PersonaSancionesSolicitadas As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)

End Class
