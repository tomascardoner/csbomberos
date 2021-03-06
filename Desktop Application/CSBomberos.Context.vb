﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class CSBomberosContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=CSBomberosContext")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub

    Public Overridable Property DocumentoTipo() As DbSet(Of DocumentoTipo)
    Public Overridable Property Localidad() As DbSet(Of Localidad)
    Public Overridable Property Log() As DbSet(Of Log)
    Public Overridable Property Parametro() As DbSet(Of Parametro)
    Public Overridable Property Provincia() As DbSet(Of Provincia)
    Public Overridable Property Reporte() As DbSet(Of Reporte)
    Public Overridable Property ReporteGrupo() As DbSet(Of ReporteGrupo)
    Public Overridable Property ReporteParametro() As DbSet(Of ReporteParametro)
    Public Overridable Property Usuario() As DbSet(Of Usuario)
    Public Overridable Property UsuarioGrupo() As DbSet(Of UsuarioGrupo)
    Public Overridable Property UsuarioGrupoPermiso() As DbSet(Of UsuarioGrupoPermiso)
    Public Overridable Property Cuartel() As DbSet(Of Cuartel)
    Public Overridable Property Parentesco() As DbSet(Of Parentesco)
    Public Overridable Property Persona() As DbSet(Of Persona)
    Public Overridable Property PersonaFamiliar() As DbSet(Of PersonaFamiliar)
    Public Overridable Property Area() As DbSet(Of Area)
    Public Overridable Property Cargo() As DbSet(Of Cargo)
    Public Overridable Property CargoJerarquia() As DbSet(Of CargoJerarquia)
    Public Overridable Property Elemento() As DbSet(Of Elemento)
    Public Overridable Property NivelEstudio() As DbSet(Of NivelEstudio)
    Public Overridable Property PersonaAccidente() As DbSet(Of PersonaAccidente)
    Public Overridable Property PersonaAltaBaja() As DbSet(Of PersonaAltaBaja)
    Public Overridable Property PersonaAscenso() As DbSet(Of PersonaAscenso)
    Public Overridable Property Ubicacion() As DbSet(Of Ubicacion)
    Public Overridable Property Unidad() As DbSet(Of Unidad)
    Public Overridable Property UnidadTipo() As DbSet(Of UnidadTipo)
    Public Overridable Property CombustibleTipo() As DbSet(Of CombustibleTipo)
    Public Overridable Property SubUbicacion() As DbSet(Of SubUbicacion)
    Public Overridable Property ModoAdquisicion() As DbSet(Of ModoAdquisicion)
    Public Overridable Property CalificacionConcepto() As DbSet(Of CalificacionConcepto)
    Public Overridable Property PersonaCalificacion() As DbSet(Of PersonaCalificacion)
    Public Overridable Property PenaAplicacion() As DbSet(Of PenaAplicacion)
    Public Overridable Property Rubro() As DbSet(Of Rubro)
    Public Overridable Property SubRubro() As DbSet(Of SubRubro)
    Public Overridable Property Inventario() As DbSet(Of Inventario)
    Public Overridable Property CapacitacionNivel() As DbSet(Of CapacitacionNivel)
    Public Overridable Property CapacitacionTipo() As DbSet(Of CapacitacionTipo)
    Public Overridable Property Curso() As DbSet(Of Curso)
    Public Overridable Property LicenciaCausa() As DbSet(Of LicenciaCausa)
    Public Overridable Property LicenciaConducirCategoria() As DbSet(Of LicenciaConducirCategoria)
    Public Overridable Property PersonaBajaMotivo() As DbSet(Of PersonaBajaMotivo)
    Public Overridable Property PersonaCapacitacion() As DbSet(Of PersonaCapacitacion)
    Public Overridable Property PersonaExamen() As DbSet(Of PersonaExamen)
    Public Overridable Property PersonaLicencia() As DbSet(Of PersonaLicencia)
    Public Overridable Property PersonaLicenciaConducirCategoria() As DbSet(Of PersonaLicenciaConducirCategoria)
    Public Overridable Property PersonaSancion() As DbSet(Of PersonaSancion)
    Public Overridable Property SancionTipo() As DbSet(Of SancionTipo)
    Public Overridable Property UnidadUso() As DbSet(Of UnidadUso)
    Public Overridable Property Alarma() As DbSet(Of Alarma)
    Public Overridable Property UsuarioParametro() As DbSet(Of UsuarioParametro)
    Public Overridable Property UnidadBajaMotivo() As DbSet(Of UnidadBajaMotivo)
    Public Overridable Property DocumentacionTipo() As DbSet(Of DocumentacionTipo)
    Public Overridable Property PersonaHorarioLaboral() As DbSet(Of PersonaHorarioLaboral)
    Public Overridable Property PersonaVacuna() As DbSet(Of PersonaVacuna)
    Public Overridable Property PersonaVehiculo() As DbSet(Of PersonaVehiculo)
    Public Overridable Property VacunaTipo() As DbSet(Of VacunaTipo)
    Public Overridable Property VehiculoCompaniaSeguro() As DbSet(Of VehiculoCompaniaSeguro)
    Public Overridable Property VehiculoMarca() As DbSet(Of VehiculoMarca)
    Public Overridable Property VehiculoTipo() As DbSet(Of VehiculoTipo)
    Public Overridable Property EstadoCivil() As DbSet(Of EstadoCivil)
    Public Overridable Property ReporteCampo() As DbSet(Of ReporteCampo)
    Public Overridable Property TipografiaEstilo() As DbSet(Of TipografiaEstilo)
    Public Overridable Property Partido() As DbSet(Of Partido)
    Public Overridable Property Compra() As DbSet(Of Compra)
    Public Overridable Property CompraDetalle() As DbSet(Of CompraDetalle)
    Public Overridable Property Proveedor() As DbSet(Of Proveedor)
    Public Overridable Property Responsable() As DbSet(Of Responsable)
    Public Overridable Property ResponsableTipo() As DbSet(Of ResponsableTipo)
    Public Overridable Property Modulo() As DbSet(Of Modulo)
    Public Overridable Property Caja() As DbSet(Of Caja)
    Public Overridable Property CajaArqueo() As DbSet(Of CajaArqueo)
    Public Overridable Property CajaArqueoDetalle() As DbSet(Of CajaArqueoDetalle)
    Public Overridable Property Siniestro() As DbSet(Of Siniestro)
    Public Overridable Property SiniestroAsistencia() As DbSet(Of SiniestroAsistencia)
    Public Overridable Property SiniestroAsistenciaTipo() As DbSet(Of SiniestroAsistenciaTipo)
    Public Overridable Property SiniestroAsistenciaTipoPuntaje() As DbSet(Of SiniestroAsistenciaTipoPuntaje)
    Public Overridable Property SiniestroRubro() As DbSet(Of SiniestroRubro)
    Public Overridable Property SiniestroTipo() As DbSet(Of SiniestroTipo)
    Public Overridable Property Academia() As DbSet(Of Academia)
    Public Overridable Property AcademiaAsistencia() As DbSet(Of AcademiaAsistencia)
    Public Overridable Property AcademiaAsistenciaTipo() As DbSet(Of AcademiaAsistenciaTipo)
    Public Overridable Property AcademiaTipo() As DbSet(Of AcademiaTipo)

    Public Overridable Function usp_Personas(estadoDesconocidoLeyenda As String, estadoActivoLeyenda As String) As ObjectResult(Of usp_Personas_Result)
        Dim estadoDesconocidoLeyendaParameter As ObjectParameter = If(estadoDesconocidoLeyenda IsNot Nothing, New ObjectParameter("EstadoDesconocidoLeyenda", estadoDesconocidoLeyenda), New ObjectParameter("EstadoDesconocidoLeyenda", GetType(String)))

        Dim estadoActivoLeyendaParameter As ObjectParameter = If(estadoActivoLeyenda IsNot Nothing, New ObjectParameter("EstadoActivoLeyenda", estadoActivoLeyenda), New ObjectParameter("EstadoActivoLeyenda", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of usp_Personas_Result)("usp_Personas", estadoDesconocidoLeyendaParameter, estadoActivoLeyendaParameter)
    End Function

End Class
