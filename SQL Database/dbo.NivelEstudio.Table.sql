USE [CSBomberos]
GO
INSERT [dbo].[NivelEstudio] ([IDNivelEstudio], [Nombre], [IncluyeSecundario], [Notas], [EsActivo], [IDUsuarioCreacion], [FechaHoraCreacion], [IDUsuarioModificacion], [FechaHoraModificacion]) VALUES (1, N'Primario Completo', 0, NULL, 1, 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime), 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime))
INSERT [dbo].[NivelEstudio] ([IDNivelEstudio], [Nombre], [IncluyeSecundario], [Notas], [EsActivo], [IDUsuarioCreacion], [FechaHoraCreacion], [IDUsuarioModificacion], [FechaHoraModificacion]) VALUES (2, N'Secundario Completo', 1, NULL, 1, 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime), 1, CAST(N'2018-04-03 21:23:00' AS SmallDateTime))
INSERT [dbo].[NivelEstudio] ([IDNivelEstudio], [Nombre], [IncluyeSecundario], [Notas], [EsActivo], [IDUsuarioCreacion], [FechaHoraCreacion], [IDUsuarioModificacion], [FechaHoraModificacion]) VALUES (3, N'Terciario Completo', 1, NULL, 1, 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime), 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime))
INSERT [dbo].[NivelEstudio] ([IDNivelEstudio], [Nombre], [IncluyeSecundario], [Notas], [EsActivo], [IDUsuarioCreacion], [FechaHoraCreacion], [IDUsuarioModificacion], [FechaHoraModificacion]) VALUES (4, N'Universitario Completo', 1, NULL, 1, 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime), 1, CAST(N'2018-03-10 18:23:00' AS SmallDateTime))