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
    Public Property Notas As String
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
    Public Overridable Property UnidadesCreados As ICollection(Of Unidad) = New HashSet(Of Unidad)
    Public Overridable Property UnidadesModificados As ICollection(Of Unidad) = New HashSet(Of Unidad)
    Public Overridable Property UnidadesTipoCreados As ICollection(Of UnidadTipo) = New HashSet(Of UnidadTipo)
    Public Overridable Property UnidadesTipoModificados As ICollection(Of UnidadTipo) = New HashSet(Of UnidadTipo)
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
    Public Overridable Property PenaAplicacionesCreadas As ICollection(Of PenaAplicacion) = New HashSet(Of PenaAplicacion)
    Public Overridable Property PenaAplicacionesModificadas As ICollection(Of PenaAplicacion) = New HashSet(Of PenaAplicacion)
    Public Overridable Property RubrosCreados As ICollection(Of Rubro) = New HashSet(Of Rubro)
    Public Overridable Property RubrosModificados As ICollection(Of Rubro) = New HashSet(Of Rubro)
    Public Overridable Property SubRubrosCreados As ICollection(Of SubRubro) = New HashSet(Of SubRubro)
    Public Overridable Property SubRubroModificados As ICollection(Of SubRubro) = New HashSet(Of SubRubro)
    Public Overridable Property UsuariosCreados As ICollection(Of Usuario) = New HashSet(Of Usuario)
    Public Overridable Property UsuarioCreacion As Usuario
    Public Overridable Property UsuariosModificados As ICollection(Of Usuario) = New HashSet(Of Usuario)
    Public Overridable Property UsuarioModificacion As Usuario
    Public Overridable Property UsuariosGruposCreados As ICollection(Of UsuarioGrupo) = New HashSet(Of UsuarioGrupo)
    Public Overridable Property UsuariosGruposModificados As ICollection(Of UsuarioGrupo) = New HashSet(Of UsuarioGrupo)
    Public Overridable Property CapacitacionNivelesCreados As ICollection(Of CapacitacionNivel) = New HashSet(Of CapacitacionNivel)
    Public Overridable Property CapacitacionNivelesModificados As ICollection(Of CapacitacionNivel) = New HashSet(Of CapacitacionNivel)
    Public Overridable Property CapacitacionTiposCreados As ICollection(Of CapacitacionTipo) = New HashSet(Of CapacitacionTipo)
    Public Overridable Property CapacitacionTiposModificados As ICollection(Of CapacitacionTipo) = New HashSet(Of CapacitacionTipo)
    Public Overridable Property CursosCreados As ICollection(Of Curso) = New HashSet(Of Curso)
    Public Overridable Property CursosModificados As ICollection(Of Curso) = New HashSet(Of Curso)
    Public Overridable Property InventariosCreados As ICollection(Of Inventario) = New HashSet(Of Inventario)
    Public Overridable Property InventariosModificados As ICollection(Of Inventario) = New HashSet(Of Inventario)
    Public Overridable Property LicenciaCausasCreadas As ICollection(Of LicenciaCausa) = New HashSet(Of LicenciaCausa)
    Public Overridable Property LicenciaCausasModificadas As ICollection(Of LicenciaCausa) = New HashSet(Of LicenciaCausa)
    Public Overridable Property LicenciaConducirCategoriasCreadas As ICollection(Of LicenciaConducirCategoria) = New HashSet(Of LicenciaConducirCategoria)
    Public Overridable Property LicenciaConducirCategoriasModificadas As ICollection(Of LicenciaConducirCategoria) = New HashSet(Of LicenciaConducirCategoria)
    Public Overridable Property PersonaBajaMotivosCreados As ICollection(Of PersonaBajaMotivo) = New HashSet(Of PersonaBajaMotivo)
    Public Overridable Property PersonaBajaMotivosModificados As ICollection(Of PersonaBajaMotivo) = New HashSet(Of PersonaBajaMotivo)
    Public Overridable Property PersonaCapacitacionesCreadas As ICollection(Of PersonaCapacitacion) = New HashSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaCapacitacionesModificadas As ICollection(Of PersonaCapacitacion) = New HashSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaExamenesCreados As ICollection(Of PersonaExamen) = New HashSet(Of PersonaExamen)
    Public Overridable Property PersonaExamenesModificados As ICollection(Of PersonaExamen) = New HashSet(Of PersonaExamen)
    Public Overridable Property PersonaLicenciasCreadas As ICollection(Of PersonaLicencia) = New HashSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicenciasModificadas As ICollection(Of PersonaLicencia) = New HashSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicenciaConducirCategoriasCreadas As ICollection(Of PersonaLicenciaConducirCategoria) = New HashSet(Of PersonaLicenciaConducirCategoria)
    Public Overridable Property PersonaSancionesCreadas As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)
    Public Overridable Property PersonaSancionesModificadas As ICollection(Of PersonaSancion) = New HashSet(Of PersonaSancion)
    Public Overridable Property SancionTiposCreados As ICollection(Of SancionTipo) = New HashSet(Of SancionTipo)
    Public Overridable Property SancionTiposModificados As ICollection(Of SancionTipo) = New HashSet(Of SancionTipo)
    Public Overridable Property UnidadUsosCreados As ICollection(Of UnidadUso) = New HashSet(Of UnidadUso)
    Public Overridable Property UnidadUsosModificados As ICollection(Of UnidadUso) = New HashSet(Of UnidadUso)
    Public Overridable Property NivelesEstudioCreados As ICollection(Of NivelEstudio) = New HashSet(Of NivelEstudio)
    Public Overridable Property NivelesEstudioModificados As ICollection(Of NivelEstudio) = New HashSet(Of NivelEstudio)
    Public Overridable Property AlarmasCreadas As ICollection(Of Alarma) = New HashSet(Of Alarma)
    Public Overridable Property AlarmasModificadas As ICollection(Of Alarma) = New HashSet(Of Alarma)
    Public Overridable Property UsuarioParametros As ICollection(Of UsuarioParametro) = New HashSet(Of UsuarioParametro)
    Public Overridable Property UnidadBajaMotivosCreados As ICollection(Of UnidadBajaMotivo) = New HashSet(Of UnidadBajaMotivo)
    Public Overridable Property UnidadBajaMotivosModificados As ICollection(Of UnidadBajaMotivo) = New HashSet(Of UnidadBajaMotivo)
    Public Overridable Property DocumentacionTiposCreados As ICollection(Of DocumentacionTipo) = New HashSet(Of DocumentacionTipo)
    Public Overridable Property DocumentacionTiposModificados As ICollection(Of DocumentacionTipo) = New HashSet(Of DocumentacionTipo)
    Public Overridable Property PersonaHorariosLaboralesCreados As ICollection(Of PersonaHorarioLaboral) = New HashSet(Of PersonaHorarioLaboral)
    Public Overridable Property PersonaHorariosLaboralesModificados As ICollection(Of PersonaHorarioLaboral) = New HashSet(Of PersonaHorarioLaboral)
    Public Overridable Property PersonaVacunasCreadas As ICollection(Of PersonaVacuna) = New HashSet(Of PersonaVacuna)
    Public Overridable Property PersonaVacunasModificadas As ICollection(Of PersonaVacuna) = New HashSet(Of PersonaVacuna)
    Public Overridable Property PersonaVehiculosCreados As ICollection(Of PersonaVehiculo) = New HashSet(Of PersonaVehiculo)
    Public Overridable Property PersonaVehiculosModificados As ICollection(Of PersonaVehiculo) = New HashSet(Of PersonaVehiculo)
    Public Overridable Property VacunaTiposCreados As ICollection(Of VacunaTipo) = New HashSet(Of VacunaTipo)
    Public Overridable Property VacunaTiposModificados As ICollection(Of VacunaTipo) = New HashSet(Of VacunaTipo)
    Public Overridable Property VehiculoCompaniasSeguroCreadas As ICollection(Of VehiculoCompaniaSeguro) = New HashSet(Of VehiculoCompaniaSeguro)
    Public Overridable Property VehiculoCompaniasSeguroModificadas As ICollection(Of VehiculoCompaniaSeguro) = New HashSet(Of VehiculoCompaniaSeguro)
    Public Overridable Property VehiculoMarcasCreadas As ICollection(Of VehiculoMarca) = New HashSet(Of VehiculoMarca)
    Public Overridable Property VehiculoMarcasModificadas As ICollection(Of VehiculoMarca) = New HashSet(Of VehiculoMarca)
    Public Overridable Property VehiculoTiposCreados As ICollection(Of VehiculoTipo) = New HashSet(Of VehiculoTipo)
    Public Overridable Property VehiculoTiposModificados As ICollection(Of VehiculoTipo) = New HashSet(Of VehiculoTipo)
    Public Overridable Property EstadosCivilesCreados As ICollection(Of EstadoCivil) = New HashSet(Of EstadoCivil)
    Public Overridable Property EstadosCivilesModificados As ICollection(Of EstadoCivil) = New HashSet(Of EstadoCivil)
    Public Overridable Property ComprasCreadas As ICollection(Of Compra) = New HashSet(Of Compra)
    Public Overridable Property ComprasModificadas As ICollection(Of Compra) = New HashSet(Of Compra)
    Public Overridable Property ProveedoresCreados As ICollection(Of Proveedor) = New HashSet(Of Proveedor)
    Public Overridable Property ProveedoresModificados As ICollection(Of Proveedor) = New HashSet(Of Proveedor)
    Public Overridable Property ResponsablesCreados As ICollection(Of Responsable) = New HashSet(Of Responsable)
    Public Overridable Property ResponsablesModificados As ICollection(Of Responsable) = New HashSet(Of Responsable)
    Public Overridable Property ResponsableTiposCreados As ICollection(Of ResponsableTipo) = New HashSet(Of ResponsableTipo)
    Public Overridable Property ResponsableTiposModificados As ICollection(Of ResponsableTipo) = New HashSet(Of ResponsableTipo)
    Public Overridable Property CajasCreadas As ICollection(Of Caja) = New HashSet(Of Caja)
    Public Overridable Property CajasModificadas As ICollection(Of Caja) = New HashSet(Of Caja)
    Public Overridable Property CajaArqueosCreados As ICollection(Of CajaArqueo) = New HashSet(Of CajaArqueo)
    Public Overridable Property CajaArqueosModificados As ICollection(Of CajaArqueo) = New HashSet(Of CajaArqueo)
    Public Overridable Property SiniestrosCreados As ICollection(Of Siniestro) = New HashSet(Of Siniestro)
    Public Overridable Property SiniestrosModificados As ICollection(Of Siniestro) = New HashSet(Of Siniestro)
    Public Overridable Property SiniestrosAsistenciasTipoCreados As ICollection(Of SiniestroAsistenciaTipo) = New HashSet(Of SiniestroAsistenciaTipo)
    Public Overridable Property SiniestrosAsistenciasTipoModificados As ICollection(Of SiniestroAsistenciaTipo) = New HashSet(Of SiniestroAsistenciaTipo)
    Public Overridable Property SiniestrosRubrosCreados As ICollection(Of SiniestroRubro) = New HashSet(Of SiniestroRubro)
    Public Overridable Property SiniestrosRubrosModificados As ICollection(Of SiniestroRubro) = New HashSet(Of SiniestroRubro)
    Public Overridable Property SiniestrosTiposCreados As ICollection(Of SiniestroTipo) = New HashSet(Of SiniestroTipo)
    Public Overridable Property SiniestrosTiposModificados As ICollection(Of SiniestroTipo) = New HashSet(Of SiniestroTipo)

End Class
