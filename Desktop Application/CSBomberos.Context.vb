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
    Public Overridable Property Automotor() As DbSet(Of Automotor)
    Public Overridable Property AutomotorTipo() As DbSet(Of AutomotorTipo)
    Public Overridable Property CombustibleTipo() As DbSet(Of CombustibleTipo)
    Public Overridable Property SubUbicacion() As DbSet(Of SubUbicacion)
    Public Overridable Property ModoAdquisicion() As DbSet(Of ModoAdquisicion)

End Class
