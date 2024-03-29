USE CSBomberos
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author: Tom�s A. Cardoner
-- Creation date: 2022-07-16
-- Updates: 2023-01-24 se cambi� el nombre del sp y se agreg� la inserci�n de asistencia ausente al resto de las personas
-- Description:	Agrega a la asistencia de una academia, a las personas activas y que tengan licencia o sanci�n.
-- =============================================
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'AcademiaAgregarAsistenciaDePersonas') AND type in (N'P', N'PC'))
	 DROP PROCEDURE AcademiaAgregarAsistenciaDePersonas
GO

CREATE PROCEDURE AcademiaAgregarAsistenciaDePersonas
	@IDAcademia int,
	@IDUsuario smallint
	AS

BEGIN

	-- SET NOCOUNT ON added to prevent extra result sets from interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @IDAcademiaAsistenciaTipoLicencia tinyint = (SELECT NumeroEntero FROM Parametro WHERE IDParametro = 'ACADEMIA_ASISTENCIATIPO_LICENCIA_ID')
	DECLARE @IDAcademiaAsistenciaTipoSuspension tinyint = (SELECT NumeroEntero FROM Parametro WHERE IDParametro = 'ACADEMIA_ASISTENCIATIPO_SUSPENSION_ID')
	DECLARE @IDAcademiaAsistenciaTipoAusente tinyint = (SELECT NumeroEntero FROM Parametro WHERE IDParametro = 'ACADEMIA_ASISTENCIATIPO_AUSENTE_ID')

	DECLARE @IDAsistenciaMetodo tinyint = 4
	DECLARE @Fecha date
	DECLARE @IDCuartel tinyint
	DECLARE @Personas TABLE (IDPersona int PRIMARY KEY)

	SELECT @Fecha = Fecha, @IDCuartel = IDCuartel FROM Academia WHERE IDAcademia = @IDAcademia

	-- Obtengo las Personas activas al momento de la academia
	INSERT INTO @Personas
		SELECT p.IDPersona
			FROM Persona AS p
				INNER JOIN PersonaAltaBaja AS pab ON p.IDPersona = pab.IDPersona
				LEFT JOIN PersonaAscenso AS pa ON p.IDPersona = pa.IDPersona
				LEFT JOIN CargoJerarquia AS cj ON pa.IDCargo = cj.IDCargo AND pa.IDJerarquia = cj.IDJerarquia
			WHERE p.EsActivo = 1 AND p.IDCuartel = @IDCuartel
				AND pab.IDAltaBaja = dbo.PersonaObtenerIdUltimaAltaBaja(p.IDPersona, @Fecha)
				AND pab.Tipo = 'A'
				AND (pa.Fecha IS NULL OR pa.Fecha = dbo.PersonaObtenerFechaUltimoAscenso(p.IDPersona, GETDATE()))
				AND cj.JerarquiaInferior = 0

	-- Inserto las asistencias de las personas con Licencias
	INSERT INTO AcademiaAsistencia
		(IDAcademia, IDPersona, IDAcademiaAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDAcademia, p.IDPersona, @IDAcademiaAsistenciaTipoLicencia, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaLicencia AS pl
				INNER JOIN @Personas AS p ON pl.IDPersona = p.IDPersona
			WHERE pl.FechaDesde <= @Fecha
				AND ((pl.FechaInterrupcion IS NOT NULL AND pl.FechaInterrupcion >= @Fecha) OR (pl.FechaInterrupcion IS NULL AND pl.FechaHasta >= @Fecha))
				AND p.IDPersona NOT IN (SELECT IDPersona FROM AcademiaAsistencia WHERE IDAcademia = @IDAcademia)

	-- Inserto las asistencias de las personas con Licencias especiales
	INSERT INTO AcademiaAsistencia
		(IDAcademia, IDPersona, IDAcademiaAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDAcademia, p.IDPersona, @IDAcademiaAsistenciaTipoLicencia, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaLicenciaEspecial AS ple
				INNER JOIN @Personas AS p ON ple.IDPersona = p.IDPersona
			WHERE ple.FechaDesde <= @Fecha
				AND ple.FechaHasta >= @Fecha
				AND p.IDPersona NOT IN (SELECT IDPersona FROM AcademiaAsistencia WHERE IDAcademia = @IDAcademia)

	-- Inserto las asistencias de las personas con Sanciones
	INSERT INTO AcademiaAsistencia
		(IDAcademia, IDPersona, IDAcademiaAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDAcademia, p.IDPersona, @IDAcademiaAsistenciaTipoSuspension, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM PersonaSancion AS ps
				INNER JOIN @Personas AS p ON ps.IDPersona = p.IDPersona
				INNER JOIN SancionTipo AS st ON ps.ResolucionIDSancionTipo = st.IDSancionTipo
			WHERE ps.Estado = 'A'
				AND ps.NotificacionFechaEfectiva <= @Fecha
				AND (st.CantidadDias IS NOT NULL)
				AND DATEADD(day, st.CantidadDias, ps.NotificacionFechaEfectiva) >= @Fecha
				AND p.IDPersona NOT IN (SELECT IDPersona FROM AcademiaAsistencia WHERE IDAcademia = @IDAcademia)

	-- Inserto las asistencias del resto de las personas con Ausente
	INSERT INTO AcademiaAsistencia
		(IDAcademia, IDPersona, IDAcademiaAsistenciaTipo, IDAsistenciaMetodo, IDUsuarioCreacion, FechaHoraCreacion, IDUsuarioModificacion, FechaHoraModificacion)
		SELECT @IDAcademia, p.IDPersona, @IDAcademiaAsistenciaTipoAusente, @IDAsistenciaMetodo, @IDUsuario, GETDATE(), @IDUsuario, GETDATE()
			FROM @Personas AS p
			WHERE p.IDPersona NOT IN (SELECT IDPersona FROM AcademiaAsistencia WHERE IDAcademia = @IDAcademia)

END
GO