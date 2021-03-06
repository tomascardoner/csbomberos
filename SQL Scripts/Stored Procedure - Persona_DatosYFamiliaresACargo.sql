USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Tomás A. Cardoner
-- Create date: 2018-09-18
-- Description:	Devuelve los datos de la Persona con sus familiares a cargo
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'usp_Persona_DatosYFamiliaresACargo') AND type in (N'P', N'PC'))
	 DROP PROCEDURE usp_Persona_DatosYFamiliaresACargo
GO

CREATE PROCEDURE usp_Persona_DatosYFamiliaresACargo
	@IDCuartel tinyint,
	@IDCargo tinyint,
	@IDJerarquia tinyint,
	@EstadoActivo bit,
	@IDPersonaBajaMotivo tinyint,
	@IDPersona int,
	@IOMAACargo bit
	AS

	BEGIN
		-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
		SET NOCOUNT ON;

		SELECT 'Lobos' AS Partido, 'Lobos' AS Ciudad, DAY(GETDATE()) AS FechaDia, FORMAT(GETDATE(), 'MMMM', 'es-es') AS FechaMes, YEAR(GETDATE()) AS FechaAnio, FORMAT(GETDATE(), 'yy') AS FechaAnioCorto, Cuartel.Nombre AS CuartelNombre, Cuartel.Descripcion AS CuartelDescripcion, Persona.IDPersona, Persona.MatriculaNumero, Persona.Genero, Persona.Apellido, Persona.Nombre, Persona.ApellidoNombre, Persona.Nombre + ' ' + Persona.Apellido AS NombreApellido, DocumentoTipo.Nombre AS DocumentoTipoNombre, Persona.DocumentoNumero, EstadoCivil.Nombre AS EstadoCivil, CONVERT(varchar(10), Persona.FechaNacimiento, 103) AS FechaNacimiento, CONVERT(varchar(10), Persona.FechaCasamiento, 103) AS FechaCasamiento, Persona.Profesion, Persona.Nacionalidad, Cargo.Nombre AS Cargo, CargoJerarquia.Nombre AS Jerarquia, (CASE ISNULL(PersonaAltaBaja.IDPersonaBajaMotivo, 0) WHEN 0 THEN 'Activo' ELSE PersonaBajaMotivo.Nombre END) AS Estado, dbo.udf_GetDomicilioCalleCompleto(Persona.DomicilioParticularCalle1, Persona.DomicilioParticularNumero, Persona.DomicilioParticularPiso, Persona.DomicilioParticularDepartamento, Persona.DomicilioParticularCalle2, Persona.DomicilioParticularCalle3) AS Domicilio, Localidad.Nombre AS LocalidadNombre, Persona.IOMANumeroAfiliado, CONVERT(varchar(10), PersonaAltaBaja.AltaFecha, 103) AS AltaFecha, Parentesco.Orden AS ParentescoOrden, Parentesco.Nombre AS ParentescoNombre, PF.Apellido AS FamiliarApellido, PF.Nombre AS FamiliarNombre, PF.ApellidoNombre AS FamiliarApellidoNombre, PF.Nombre + ' ' + PF.Apellido AS FamiliarNombreApellido, PF.Vive, dbo.udf_GetDomicilioCalleCompleto(PF.DomicilioCalle1, PF.DomicilioNumero, PF.DomicilioPiso, PF.DomicilioDepartamento, PF.DomicilioCalle2, PF.DomicilioCalle3) AS FamiliarDomicilio, CONVERT(varchar(10), PF.FechaNacimiento, 103) AS FamiliarFechaNacimiento, FamiliarDocumentoTipo.Nombre AS FamiliarDocumentoTipoNombre, PF.DocumentoNumero AS FamiliarDocumentoNumero, PF.Notas AS FamiliarNotas
			FROM ((((((((((((Persona INNER JOIN Cuartel ON Persona.IDCuartel = Cuartel.IDCuartel)
				LEFT JOIN DocumentoTipo ON Persona.IDDocumentoTipo = DocumentoTipo.IDDocumentoTipo)
				LEFT JOIN EstadoCivil ON Persona.IDEstadoCivil = EstadoCivil.IDEstadoCivil)
				LEFT JOIN PersonaAltaBaja ON Persona.IDPersona = PersonaAltaBaja.IDPersona)
				LEFT JOIN PersonaAscenso ON Persona.IDPersona = PersonaAscenso.IDPersona)
				LEFT JOIN Cargo ON PersonaAscenso.IDCargo = Cargo.IDCargo)
				LEFT JOIN CargoJerarquia ON PersonaAscenso.IDCargo = CargoJerarquia.IDCargo AND PersonaAscenso.IDJerarquia = CargoJerarquia.IDJerarquia)
				LEFT JOIN PersonaBajaMotivo ON PersonaAltaBaja.IDPersonaBajaMotivo = PersonaBajaMotivo.IDPersonaBajaMotivo)
				LEFT JOIN Provincia ON Persona.DomicilioParticularIDProvincia = Provincia.IDProvincia)
				LEFT JOIN Localidad ON Persona.DomicilioParticularIDProvincia = Localidad.IDProvincia AND Persona.DomicilioParticularIDLocalidad = Localidad.IDLocalidad)
				LEFT JOIN (SELECT * FROM PersonaFamiliar WHERE (@IOMAACargo = 0 AND PersonaFamiliar.ACargo = 1) OR (@IOMAACargo = 1 AND PersonaFamiliar.IOMAACargo = 1)) AS PF ON Persona.IDPersona = PF.IDPersona)
				LEFT JOIN Parentesco ON PF.IDParentesco = Parentesco.IDParentesco)
				LEFT JOIN DocumentoTipo AS FamiliarDocumentoTipo ON PF.IDDocumentoTipo = FamiliarDocumentoTipo.IDDocumentoTipo
			WHERE Persona.EsActivo = 1
				AND (PF.IDParentesco IS NULL OR PF.IDParentesco < 254)
				AND (PF.ACargo IS NULL OR (@IOMAACargo = 0 AND PF.ACargo = 1) OR (@IOMAACargo = 1 AND PF.IOMAACargo = 1))
				AND (@IDPersona IS NULL OR Persona.IDPersona = @IDPersona)
				AND (@IDCuartel IS NULL OR Persona.IDCuartel = @IDCuartel)
				AND (@IDCargo IS NULL OR (PersonaAscenso.IDCargo = @IDCargo AND (@IDJerarquia IS NULL OR PersonaAscenso.IDJerarquia = @IDJerarquia)))
				AND (PersonaAltaBaja.AltaFecha IS NULL OR PersonaAltaBaja.AltaFecha = dbo.udf_GetPersonaUltimaFechaAlta(Persona.IDPersona, GETDATE()))
				AND (PersonaAscenso.Fecha IS NULL OR PersonaAscenso.Fecha = dbo.udf_GetPersonaUltimaFechaAscenso(Persona.IDPersona, GETDATE()))
				AND (@EstadoActivo IS NULL OR (@EstadoActivo = 1 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NULL) OR (@EstadoActivo = 0 AND PersonaAltaBaja.IDPersonaBajaMotivo IS NOT NULL))
				AND (@IDPersonaBajaMotivo IS NULL OR PersonaAltaBaja.IDPersonaBajaMotivo = @IDPersonaBajaMotivo)
			ORDER BY Persona.IDPersona, PF.FechaNacimiento
	END
GO