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

Partial Public Class Usuario
    Public Property IDUsuario As Short
    Public Property Nombre As String
    Public Property Descripcion As String
    Public Property Password As String
    Public Property Genero As String
    Public Property IDUsuarioGrupo As Byte
    Public Property IDCuartel As Nullable(Of Byte)
    Public Property EsActivo As Boolean
    Public Property IDUsuarioCreacion As Short
    Public Property FechaHoraCreacion As Date
    Public Property IDUsuarioModificacion As Short
    Public Property FechaHoraModificacion As Date

    Public Overridable Property Log As ICollection(Of Log) = New HashSet(Of Log)
    Public Overridable Property UsuarioGrupo As UsuarioGrupo
    Public Overridable Property PersonasCreadas As ICollection(Of Persona) = New HashSet(Of Persona)
    Public Overridable Property PersonasModificadas As ICollection(Of Persona) = New HashSet(Of Persona)
    Public Overridable Property PersonaFamiliaresCreados As ICollection(Of PersonaFamiliar) = New HashSet(Of PersonaFamiliar)
    Public Overridable Property PersonaFamiliaresModificados As ICollection(Of PersonaFamiliar) = New HashSet(Of PersonaFamiliar)
    Public Overridable Property ParentescosCreados As ICollection(Of Parentesco) = New HashSet(Of Parentesco)
    Public Overridable Property ParentescosModificados As ICollection(Of Parentesco) = New HashSet(Of Parentesco)
    Public Overridable Property CuartelesCreados As ICollection(Of Cuartel) = New HashSet(Of Cuartel)
    Public Overridable Property CuartelesModificados As ICollection(Of Cuartel) = New HashSet(Of Cuartel)
    Public Overridable Property ElementosCreados As ICollection(Of Elemento) = New HashSet(Of Elemento)
    Public Overridable Property ElementosModificados As ICollection(Of Elemento) = New HashSet(Of Elemento)
    Public Overridable Property PersonasAccidentesCreados As ICollection(Of PersonaAccidente) = New HashSet(Of PersonaAccidente)
    Public Overridable Property PersonasAccidentesModificados As ICollection(Of PersonaAccidente) = New HashSet(Of PersonaAccidente)
    Public Overridable Property PersonasAltasBajasCreados As ICollection(Of PersonaAltaBaja) = New HashSet(Of PersonaAltaBaja)
    Public Overridable Property PersonasAltasBajasModificados As ICollection(Of PersonaAltaBaja) = New HashSet(Of PersonaAltaBaja)
    Public Overridable Property PersonasAscensosCreados As ICollection(Of PersonaAscenso) = New HashSet(Of PersonaAscenso)
    Public Overridable Property PersonasAscensosModificados As ICollection(Of PersonaAscenso) = New HashSet(Of PersonaAscenso)
    Public Overridable Property AreasCreadas As ICollection(Of Area) = New HashSet(Of Area)
    Public Overridable Property AreasModificadas As ICollection(Of Area) = New HashSet(Of Area)
    Public Overridable Property AutomotoresCreados As ICollection(Of Automotor) = New HashSet(Of Automotor)
    Public Overridable Property AutomotoresModificados As ICollection(Of Automotor) = New HashSet(Of Automotor)
    Public Overridable Property AutomotoresTipoCreados As ICollection(Of AutomotorTipo) = New HashSet(Of AutomotorTipo)
    Public Overridable Property AutomotoresTipoModificados As ICollection(Of AutomotorTipo) = New HashSet(Of AutomotorTipo)
    Public Overridable Property CargosCreados As ICollection(Of Cargo) = New HashSet(Of Cargo)
    Public Overridable Property CargosModificados As ICollection(Of Cargo) = New HashSet(Of Cargo)
    Public Overridable Property CargosJerarquiasCreados As ICollection(Of CargoJerarquia) = New HashSet(Of CargoJerarquia)
    Public Overridable Property CargosJerarquiasModificados As ICollection(Of CargoJerarquia) = New HashSet(Of CargoJerarquia)
    Public Overridable Property CombustibleTiposCreados As ICollection(Of CombustibleTipo) = New HashSet(Of CombustibleTipo)
    Public Overridable Property CombustibleTiposModificados As ICollection(Of CombustibleTipo) = New HashSet(Of CombustibleTipo)
    Public Overridable Property SubUbicacionesCreadas As ICollection(Of SubUbicacion) = New HashSet(Of SubUbicacion)
    Public Overridable Property SubUbicacionesModificadas As ICollection(Of SubUbicacion) = New HashSet(Of SubUbicacion)
    Public Overridable Property UbicacionesCreadas As ICollection(Of Ubicacion) = New HashSet(Of Ubicacion)
    Public Overridable Property UbicacionesModificadas As ICollection(Of Ubicacion) = New HashSet(Of Ubicacion)
    Public Overridable Property Cuartel As Cuartel
    Public Overridable Property ModosAdquisicionCreados As ICollection(Of ModoAdquisicion) = New HashSet(Of ModoAdquisicion)
    Public Overridable Property ModosAdquisicionModificados As ICollection(Of ModoAdquisicion) = New HashSet(Of ModoAdquisicion)
    Public Overridable Property CalificacionConceptosCreados As ICollection(Of CalificacionConcepto) = New HashSet(Of CalificacionConcepto)
    Public Overridable Property CalificacionConceptosModificados As ICollection(Of CalificacionConcepto) = New HashSet(Of CalificacionConcepto)
    Public Overridable Property PersonaCalificacionesCreadas As ICollection(Of PersonaCalificacion) = New HashSet(Of PersonaCalificacion)
    Public Overridable Property PersonaCalificacionesModificadas As ICollection(Of PersonaCalificacion) = New HashSet(Of PersonaCalificacion)
    Public Overridable Property PenaAplicacion As ICollection(Of PenaAplicacion) = New HashSet(Of PenaAplicacion)
    Public Overridable Property PenaAplicacion1 As ICollection(Of PenaAplicacion) = New HashSet(Of PenaAplicacion)
    Public Overridable Property RubrosCreados As ICollection(Of Rubro) = New HashSet(Of Rubro)
    Public Overridable Property RubrosModificados As ICollection(Of Rubro) = New HashSet(Of Rubro)
    Public Overridable Property SubRubro As ICollection(Of SubRubro) = New HashSet(Of SubRubro)
    Public Overridable Property SubRubro1 As ICollection(Of SubRubro) = New HashSet(Of SubRubro)
    Public Overridable Property UsuariosCreados As ICollection(Of Usuario) = New HashSet(Of Usuario)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuariosModificados As ICollection(Of Usuario) = New HashSet(Of Usuario)
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property UsuariosGruposCreados As ICollection(Of UsuarioGrupo) = New HashSet(Of UsuarioGrupo)
    Public Overridable Property UsuariosGruposModificados As ICollection(Of UsuarioGrupo) = New HashSet(Of UsuarioGrupo)
    Public Overridable Property PersonaCambioUnidad As ICollection(Of PersonaCambioUnidad) = New HashSet(Of PersonaCambioUnidad)
    Public Overridable Property PersonaCambioUnidad1 As ICollection(Of PersonaCambioUnidad) = New HashSet(Of PersonaCambioUnidad)
    Public Overridable Property CapacitacionNivel As ICollection(Of CapacitacionNivel) = New HashSet(Of CapacitacionNivel)
    Public Overridable Property CapacitacionNivel1 As ICollection(Of CapacitacionNivel) = New HashSet(Of CapacitacionNivel)
    Public Overridable Property CapacitacionTipo As ICollection(Of CapacitacionTipo) = New HashSet(Of CapacitacionTipo)
    Public Overridable Property CapacitacionTipo1 As ICollection(Of CapacitacionTipo) = New HashSet(Of CapacitacionTipo)
    Public Overridable Property CursosCreados As ICollection(Of Curso) = New HashSet(Of Curso)
    Public Overridable Property CursosModificados As ICollection(Of Curso) = New HashSet(Of Curso)
    Public Overridable Property InventariosCreados As ICollection(Of Inventario) = New HashSet(Of Inventario)
    Public Overridable Property InventariosModificados As ICollection(Of Inventario) = New HashSet(Of Inventario)
    Public Overridable Property LicenciaCausa As ICollection(Of LicenciaCausa) = New HashSet(Of LicenciaCausa)
    Public Overridable Property LicenciaCausa1 As ICollection(Of LicenciaCausa) = New HashSet(Of LicenciaCausa)
    Public Overridable Property LicenciaConducirCategoria As ICollection(Of LicenciaConducirCategoria) = New HashSet(Of LicenciaConducirCategoria)
    Public Overridable Property LicenciaConducirCategoria1 As ICollection(Of LicenciaConducirCategoria) = New HashSet(Of LicenciaConducirCategoria)
    Public Overridable Property PersonaBajaMotivo As ICollection(Of PersonaBajaMotivo) = New HashSet(Of PersonaBajaMotivo)
    Public Overridable Property PersonaBajaMotivo1 As ICollection(Of PersonaBajaMotivo) = New HashSet(Of PersonaBajaMotivo)
    Public Overridable Property PersonaCapacitacion As ICollection(Of PersonaCapacitacion) = New HashSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaCapacitacion1 As ICollection(Of PersonaCapacitacion) = New HashSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaExamen As ICollection(Of PersonaExamen) = New HashSet(Of PersonaExamen)
    Public Overridable Property PersonaExamen1 As ICollection(Of PersonaExamen) = New HashSet(Of PersonaExamen)
    Public Overridable Property PersonaLicencia As ICollection(Of PersonaLicencia) = New HashSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicencia1 As ICollection(Of PersonaLicencia) = New HashSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicenciaConducirCategoria As ICollection(Of PersonaLicenciaConducirCategoria) = New HashSet(Of PersonaLicenciaConducirCategoria)
    Public Overridable Property PersonaSancion As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)
    Public Overridable Property PersonaSancion1 As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)
    Public Overridable Property SancionTiposCreados As ICollection(Of SancionTipo) = New HashSet(Of SancionTipo)
    Public Overridable Property SancionTiposModificados As ICollection(Of SancionTipo) = New HashSet(Of SancionTipo)
    Public Overridable Property AutomotorUsosCreados As ICollection(Of AutomotorUso) = New HashSet(Of AutomotorUso)
    Public Overridable Property AutomotorUsosModificados As ICollection(Of AutomotorUso) = New HashSet(Of AutomotorUso)
    Public Overridable Property NivelesEstudioCreados As ICollection(Of NivelEstudio) = New HashSet(Of NivelEstudio)
    Public Overridable Property NivelesEstudioModificados As ICollection(Of NivelEstudio) = New HashSet(Of NivelEstudio)

End Class
