USE [EcologiaHumana]
GO
/****** Object:  Table [dbo].[T_Consejos]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Consejos](
	[IdConsejo] [int] IDENTITY(1,1) NOT NULL,
	[Consejo] [nvarchar](250) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Dimension] [int] NOT NULL,
 CONSTRAINT [PK_T_Consejos] PRIMARY KEY CLUSTERED 
(
	[IdConsejo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Perfiles]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Perfiles](
	[IdPerfil] [int] IDENTITY(1,1) NOT NULL,
	[NombreUsuario] [nvarchar](45) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[IdSede] [int] NOT NULL,
	[IdProfesion] [int] NULL,
 CONSTRAINT [PK_T_Perfiles] PRIMARY KEY CLUSTERED 
(
	[IdPerfil] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_PreguntasDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_PreguntasDimension](
	[IdPregunta] [int] IDENTITY(1,1) NOT NULL,
	[Pregunta] [nvarchar](220) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Estilo] [int] NOT NULL,
	[Dimension] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
 CONSTRAINT [PK_T_PreguntasDimension] PRIMARY KEY CLUSTERED 
(
	[IdPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Profesiones]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Profesiones](
	[IdProfesion] [int] IDENTITY(1,1) NOT NULL,
	[NombreProfesion] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_T_Profesiones] PRIMARY KEY CLUSTERED 
(
	[IdProfesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_ResultadosDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_ResultadosDimension](
	[IdResultado] [int] IDENTITY(1,1) NOT NULL,
	[TotalResultado] [float] NOT NULL,
	[Dimension] [int] NOT NULL,
	[IdUsuario] [int] NOT NULL,
	[Fecha] [datetime] NOT NULL,
 CONSTRAINT [PK_T_ResultadosDimension] PRIMARY KEY CLUSTERED 
(
	[IdResultado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Roles]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Roles](
	[IdRol] [int] NOT NULL,
	[NombreRol] [nvarchar](30) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Roles] PRIMARY KEY CLUSTERED 
(
	[IdRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Sedes]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Sedes](
	[IdSede] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_T_Sedes] PRIMARY KEY CLUSTERED 
(
	[IdSede] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Usuarios]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](45) NOT NULL,
	[Contrasena] [nvarchar](75) NOT NULL,
	[FechaCreacion] [datetime] NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdRol] [int] NULL,
 CONSTRAINT [PK_T_Usuarios_1] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[T_Consejos] ON 

INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (1, N'Revisa las llaves y tuberías para detectar fugas, y en caso de descubrir una repárala cuanto antes. Una fuga en un inodoro puede desperdiciar más de 200 galones de agua al día.', 1, 1)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (2, N'Cierra la llave mientras te lavas los dientes, las manos, o los platos, esta pequeña acción puede ahorrar hasta 30 litros de agua por día. ', 1, 1)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (5, N'Utiliza bombillas de bajo consumo. Las lámparas halógenas emplean hasta 10 veces más cantidad de electricidad que las bombillas led o las de bajo consumo. Además recuerda apagar todas las luces que no estés utilizando, esta simple acción pued', 1, 2)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (6, N'Si vas a comprar un nuevo electrodoméstico, ten en cuenta las necesidades de consumo de agua y energía del mismo. ', 1, 2)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (8, N'No utilices bolsas de plástico, ni productos de un solo uso. Además de contaminar, los plásticos no son biodegradables y perduran en el entorno. Las bolsas de plástico tardan unos 150 años en degradarse, mient', 1, 3)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (9, N'Compra productos locales, como los que se venden en la feria del agricultor. Cuanto más lejano sea el origen del producto, ma', 1, 3)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (10, N'No maltrates o juegues con nidos, cuevas madrigueras o el hogar de otras especies. En muchos ca', 1, 4)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (11, N'Practica el ecoturismo. Además de ser una experiencia divertida vas a reducir tu huella ecológica y a contribu', 1, 4)
INSERT [dbo].[T_Consejos] ([IdConsejo], [Consejo], [IdUsuario], [Dimension]) VALUES (13, N'Revisa las llaves y tuberías para detectar fugas, y en caso de descubrir una repárala cuanto antes. Una fuga en un inodoro puede desperdiciar más de 200 galones de agua al día.', 1, 3)
SET IDENTITY_INSERT [dbo].[T_Consejos] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Perfiles] ON 

INSERT [dbo].[T_Perfiles] ([IdPerfil], [NombreUsuario], [FechaNacimiento], [Sexo], [IdUsuario], [IdSede], [IdProfesion]) VALUES (2, N'Justin Calderon', CAST(N'2022-02-03T00:00:00.000' AS DateTime), N'H', 1, 1, 1)
SET IDENTITY_INSERT [dbo].[T_Perfiles] OFF
GO
SET IDENTITY_INSERT [dbo].[T_PreguntasDimension] ON 

INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (2, N'Cierro la llave del agua mientras me ducho', 1, 2, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (3, N'Cierro la llave del agua mientras me ducho', 1, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (4, N'aaaa', 2, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (5, N'aaaa', 3, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (6, N'aaaa', 4, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (7, N'aaaa', 5, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (8, N'aaaa', 1, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (9, N'aaaa', 1, 1, 1, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (10, N'aaaa', 1, 1, 2, 1)
INSERT [dbo].[T_PreguntasDimension] ([IdPregunta], [Pregunta], [Tipo], [Estilo], [Dimension], [IdUsuario]) VALUES (1010, N'aaaa', 1, 2, 3, 1)
SET IDENTITY_INSERT [dbo].[T_PreguntasDimension] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Profesiones] ON 

INSERT [dbo].[T_Profesiones] ([IdProfesion], [NombreProfesion]) VALUES (1, N'Ingeniero')
INSERT [dbo].[T_Profesiones] ([IdProfesion], [NombreProfesion]) VALUES (2, N'P')
SET IDENTITY_INSERT [dbo].[T_Profesiones] OFF
GO
SET IDENTITY_INSERT [dbo].[T_ResultadosDimension] ON 

INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (3, 542, 1, 1, CAST(N'2022-01-24T22:11:19.973' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (5, 1000, 2, 1, CAST(N'2022-01-24T22:20:53.880' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (1002, 0, 2, 1, CAST(N'2022-01-25T11:07:03.523' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (1003, 667, 1, 1, CAST(N'2022-01-25T16:44:43.903' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (1004, 1000, 3, 1, CAST(N'2022-01-25T16:50:23.100' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (1005, 333, 2, 1, CAST(N'2022-01-26T10:07:43.650' AS DateTime))
INSERT [dbo].[T_ResultadosDimension] ([IdResultado], [TotalResultado], [Dimension], [IdUsuario], [Fecha]) VALUES (1006, 1000, 3, 1, CAST(N'2022-01-26T10:07:56.230' AS DateTime))
SET IDENTITY_INSERT [dbo].[T_ResultadosDimension] OFF
GO
INSERT [dbo].[T_Roles] ([IdRol], [NombreRol], [Descripcion]) VALUES (1, N'Estudiantes', N'Estudiante')
INSERT [dbo].[T_Roles] ([IdRol], [NombreRol], [Descripcion]) VALUES (2, N'Funcionarios', N'Funcionario')
INSERT [dbo].[T_Roles] ([IdRol], [NombreRol], [Descripcion]) VALUES (3, N'Profesores', N'Profesor')
GO
SET IDENTITY_INSERT [dbo].[T_Sedes] ON 

INSERT [dbo].[T_Sedes] ([IdSede], [Descripcion]) VALUES (1, N'San José')
INSERT [dbo].[T_Sedes] ([IdSede], [Descripcion]) VALUES (2, N'H')
SET IDENTITY_INSERT [dbo].[T_Sedes] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Usuarios] ON 

INSERT [dbo].[T_Usuarios] ([IdUsuario], [Usuario], [Contrasena], [FechaCreacion], [Estado], [IdRol]) VALUES (1, N'juscalval@gmail.com', N'MQAyADMA', CAST(N'2021-11-23T15:31:27.667' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[T_Usuarios] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_T_Usuarios]    Script Date: 26/01/2022 11:49:25 ******/
ALTER TABLE [dbo].[T_Usuarios] ADD  CONSTRAINT [UQ_T_Usuarios] UNIQUE NONCLUSTERED 
(
	[Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T_Consejos]  WITH CHECK ADD  CONSTRAINT [FK_T_Consejos_T_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[T_Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[T_Consejos] CHECK CONSTRAINT [FK_T_Consejos_T_Usuarios]
GO
ALTER TABLE [dbo].[T_Perfiles]  WITH CHECK ADD  CONSTRAINT [FK_T_Perfiles_T_Profesiones] FOREIGN KEY([IdProfesion])
REFERENCES [dbo].[T_Profesiones] ([IdProfesion])
GO
ALTER TABLE [dbo].[T_Perfiles] CHECK CONSTRAINT [FK_T_Perfiles_T_Profesiones]
GO
ALTER TABLE [dbo].[T_Perfiles]  WITH CHECK ADD  CONSTRAINT [FK_T_Perfiles_T_Sedes] FOREIGN KEY([IdSede])
REFERENCES [dbo].[T_Sedes] ([IdSede])
GO
ALTER TABLE [dbo].[T_Perfiles] CHECK CONSTRAINT [FK_T_Perfiles_T_Sedes]
GO
ALTER TABLE [dbo].[T_Perfiles]  WITH CHECK ADD  CONSTRAINT [FK_T_Perfiles_T_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[T_Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[T_Perfiles] CHECK CONSTRAINT [FK_T_Perfiles_T_Usuarios]
GO
ALTER TABLE [dbo].[T_PreguntasDimension]  WITH CHECK ADD  CONSTRAINT [FK_T_PreguntasDimension_T_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[T_Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[T_PreguntasDimension] CHECK CONSTRAINT [FK_T_PreguntasDimension_T_Usuarios]
GO
ALTER TABLE [dbo].[T_ResultadosDimension]  WITH CHECK ADD  CONSTRAINT [FK_T_ResultadosDimension_T_Usuarios] FOREIGN KEY([IdUsuario])
REFERENCES [dbo].[T_Usuarios] ([IdUsuario])
GO
ALTER TABLE [dbo].[T_ResultadosDimension] CHECK CONSTRAINT [FK_T_ResultadosDimension_T_Usuarios]
GO
ALTER TABLE [dbo].[T_Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_T_Usuarios_T_Roles] FOREIGN KEY([IdRol])
REFERENCES [dbo].[T_Roles] ([IdRol])
GO
ALTER TABLE [dbo].[T_Usuarios] CHECK CONSTRAINT [FK_T_Usuarios_T_Roles]
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarConsejo]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ActualizarConsejo](	@IdConsejo int,	@Consejo nvarchar(250),	@Dimension int,	@IdUsuario int)asBEGIN

UPDATE [dbo].[T_Consejos]
SET
		 [Consejo] = @Consejo
		,[Dimension] = @Dimension
		,[IdUsuario] = @IdUsuarioWHERE		IdConsejo = @IdConsejoEND
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarPerfil]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ActualizarPerfil](	@NombreUsuario nvarchar(45),	@Sexo char(1),	@FechaNacimiento datetime,	@IdUsuario int,	@IdSede int,	@IdProfesion int)asBEGIN


UPDATE [dbo].[T_Perfiles]
SET [NombreUsuario] = @NombreUsuario,
	[Sexo] = @Sexo,
	[FechaNacimiento] = @FechaNacimiento,
	[IdSede] = @IdSede,
	[IdProfesion] = @IdProfesion
WHERE [IdUsuario] = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarPregunta]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ActualizarPregunta](	@IdPregunta int,	@Pregunta nvarchar(220),	@Tipo int,	@Estilo int,	@Dimension int,	@IdUsuario int)asBEGIN

UPDATE [dbo].[T_PreguntasDimension]
SET
		 [Pregunta] = @Pregunta
		,[Tipo] = @Tipo
		,[Estilo] = @Estilo
		,[Dimension] = @Dimension
		,[IdUsuario] = @IdUsuarioWHERE		IdPregunta = @IdPreguntaEND
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarUsuarioPerfil]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ActualizarUsuarioPerfil](	@Usuario nvarchar(45),	@Estado bit,	@NombreUsuario nvarchar(45),	@Sexo char(1),	@FechaNacimiento datetime,	@IdUsuario int,	@IdSede int,	@IdProfesion int,	@IdRol int)asBEGIN
	DECLARE @TranName varchar(50) = 'SP_ActualizarUsuarioPerfil'

	BEGIN TRANSACTION @TranName

	BEGIN TRY

			UPDATE [dbo].[T_Usuarios]
					SET [Usuario] = @Usuario
					   ,[Estado] = @Estado					   ,[IdRol] = @IdRol			WHERE [IdUsuario] = @IdUsuario			UPDATE [dbo].[T_Perfiles]
			SET [NombreUsuario] = @NombreUsuario,
				[Sexo] = @Sexo,
				[FechaNacimiento] = @FechaNacimiento,
				[IdSede] = @IdSede,
				[IdProfesion] = @IdProfesion
			WHERE [IdUsuario] = @IdUsuario


			COMMIT TRANSACTION @TranName
	
	END TRY
	BEGIN CATCH

	ROLLBACK TRANSACTION @TranName

	DECLARE @MSJ NVARCHAR (1000) = RIGHT(ERROR_MESSAGE(),1000)

		   RAISERROR ( @MSJ , -- MESSAGE TEXT.  
		   16, -- SEVERITY.  
		   1 -- STATE.  
		   ); 

	END CATCH


END
GO
/****** Object:  StoredProcedure [dbo].[SP_ActualizarUsuarioPerfilContrasena]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_ActualizarUsuarioPerfilContrasena](	@Usuario nvarchar(45),	@Contrasena nvarchar(75),	@Estado bit,	@NombreUsuario nvarchar(45),	@Sexo char(1),	@FechaNacimiento datetime,	@IdUsuario int,	@IdSede int,	@IdProfesion int,	@IdRol int)asBEGIN
	DECLARE @TranName varchar(50) = 'SP_ActualizarUsuarioPerfil'

	BEGIN TRANSACTION @TranName

	BEGIN TRY

			UPDATE [dbo].[T_Usuarios]
					SET [Usuario] = @Usuario
					   ,[Contrasena] = @Contrasena					   ,[Estado] = @Estado					   ,[IdRol] = @IdRol			WHERE [IdUsuario] = @IdUsuario			UPDATE [dbo].[T_Perfiles]
			SET [NombreUsuario] = @NombreUsuario,
				[Sexo] = @Sexo,
				[FechaNacimiento] = @FechaNacimiento,
				[IdSede] = @IdSede,
				[IdProfesion] = @IdProfesion
			WHERE [IdUsuario] = @IdUsuario


			COMMIT TRANSACTION @TranName
	
	END TRY
	BEGIN CATCH

	ROLLBACK TRANSACTION @TranName

	DECLARE @MSJ NVARCHAR (1000) = RIGHT(ERROR_MESSAGE(),1000)

		   RAISERROR ( @MSJ , -- MESSAGE TEXT.  
		   16, -- SEVERITY.  
		   1 -- STATE.  
		   ); 

	END CATCH


END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteConsejo]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DeleteConsejo](	@IdConsejo int)asBEGIN



  DELETE
  FROM [dbo].[T_Consejos]
  WHERE IdConsejo = @IdConsejo

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeletePregunta]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DeletePregunta](	@IdPregunta int)asBEGIN



  DELETE
  FROM [dbo].[T_PreguntasDimension]
  WHERE @IdPregunta = IdPregunta

END
GO
/****** Object:  StoredProcedure [dbo].[SP_DeleteUsuario]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_DeleteUsuario](	@IdUsuario int)asBEGIN

	DECLARE @TranName varchar(50) = 'SP_DeleteUsuario'

	BEGIN TRANSACTION @TranName

	BEGIN TRY

			  DELETE
			  FROM [dbo].[T_Perfiles]
			  WHERE IdUsuario = @IdUsuario

			  DELETE
			  FROM [dbo].[T_Usuarios]
			  WHERE IdUsuario = @IdUsuario


			COMMIT TRANSACTION @TranName
	
	END TRY
	BEGIN CATCH

	ROLLBACK TRANSACTION @TranName

	DECLARE @MSJ NVARCHAR (1000) = RIGHT(ERROR_MESSAGE(),1000)

		   RAISERROR ( @MSJ , -- MESSAGE TEXT.  
		   16, -- SEVERITY.  
		   1 -- STATE.  
		   ); 

	END CATCH


END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarConsejo]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarConsejo](	@Consejo nvarchar(250),	@Dimension int,	@IdUsuario int)asBEGIN

INSERT INTO [dbo].[T_Consejos]
           ([Consejo]
		   ,[IdUsuario]
           ,[Dimension])
     VALUES
           (@Consejo
		   ,@IdUsuario
           ,@Dimension)SELECT @@IDENTITY AS 'Identity';  END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarPerfil]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarPerfil](	@NombreUsuario nvarchar(45),	@Sexo char(1),	@FechaNacimiento datetime,	@IdUsuario int,	@IdSede int,	@IdProfesion int)asBEGIN

INSERT INTO [dbo].[T_Perfiles]
           ([NombreUsuario]
           ,[FechaNacimiento]
		   ,[Sexo]
           ,[IdUsuario]
           ,[IdSede]
		   ,[IdProfesion])
     VALUES
           (@NombreUsuario
           ,@FechaNacimiento
		   ,@Sexo
           ,@IdUsuario
           ,@IdSede		   ,@IdProfesion)END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarPregunta]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarPregunta](	@Pregunta nvarchar(220),	@Tipo int,	@Estilo int,	@Dimension int,	@IdUsuario int)asBEGIN

INSERT INTO [dbo].[T_PreguntasDimension]
           ([Pregunta]
           ,[Tipo]
           ,[Estilo]
           ,[Dimension]
           ,[IdUsuario])
     VALUES
           (@Pregunta
           ,@Tipo
		   ,@Estilo
           ,@Dimension
           ,@IdUsuario)SELECT @@IDENTITY AS 'Identity';  END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarResultadoDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarResultadoDimension](	@TotalResultado int,	@Dimension int,	@IdUsuario int)asBEGIN

INSERT INTO [dbo].[T_ResultadosDimension]
           ([TotalResultado]
           ,[Dimension]
           ,[IdUsuario]
		   ,[Fecha])
     VALUES
           (@TotalResultado
           ,@Dimension
           ,@IdUsuario		   ,GETDATE())SELECT @@IDENTITY AS 'Identity';  END
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarUsuario]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarUsuario](	@Usuario nvarchar(45),	@Contrasena nvarchar(75),	@Estado bit)asBEGIN	INSERT INTO [dbo].[T_Usuarios]
			   ([Usuario]
			   ,[Contrasena]
			   ,[FechaCreacion]
			   ,[Estado])			VALUES(			@Usuario,			@Contrasena,			GETDATE(),			@Estado)	SELECT @@IDENTITY AS 'Identity';  end
GO
/****** Object:  StoredProcedure [dbo].[SP_InsertarUsuarioPerfil]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_InsertarUsuarioPerfil](	@Usuario nvarchar(45),	@Contrasena nvarchar(75),	@Estado bit,	@NombreUsuario nvarchar(45),	@Sexo char(1),	@FechaNacimiento datetime,	@IdSede int,	@IdProfesion int)asBEGIN	DECLARE @TranName varchar(50) = 'SP_InsertarUsuarioPerfil'

	BEGIN TRANSACTION @TranName

	BEGIN TRY

			INSERT INTO [dbo].[T_Usuarios]
					   ([Usuario]
					   ,[Contrasena]
					   ,[FechaCreacion]
					   ,[Estado])					VALUES(					@Usuario,					@Contrasena,					GETDATE(),					@Estado)			SELECT @@IDENTITY AS 'Identity';  

			INSERT INTO [dbo].[T_Perfiles]
           ([NombreUsuario]
           ,[FechaNacimiento]
		   ,[Sexo]
           ,[IdUsuario]
           ,[IdSede]
		   ,[IdProfesion])
			VALUES
           (@NombreUsuario
           ,@FechaNacimiento
		   ,@Sexo
           ,@@IDENTITY
           ,@IdSede		   ,@IdProfesion)


			COMMIT TRANSACTION @TranName
	
	END TRY
	BEGIN CATCH

	ROLLBACK TRANSACTION @TranName

	DECLARE @MSJ NVARCHAR (1000) = RIGHT(ERROR_MESSAGE(),1000)

		   RAISERROR ( @MSJ , -- MESSAGE TEXT.  
		   16, -- SEVERITY.  
		   1 -- STATE.  
		   ); 

	END CATCHend
GO
/****** Object:  StoredProcedure [dbo].[SP_LoginUsuario]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_LoginUsuario]
(	@Usuario nvarchar(45),	@Contrasena nvarchar(75))
As
BEGIN
	SELECT us.[IdUsuario]
		  ,[Usuario]
		  ,[Contrasena]
		  ,[FechaCreacion]
		  ,[Estado]
		  ,per.[IdPerfil]
		  ,per.[NombreUsuario]
		  ,per.[FechaNacimiento]
		  ,per.[IdSede]
		  ,per.[IdProfesion]
		  ,[IdRol]
	  FROM [dbo].[T_Usuarios] us
	  LEFT JOIN T_Perfiles per ON per.IdUsuario = us.IdUsuario
	  WHERE Usuario = @Usuario
	  AND Contrasena = @Contrasena
	  AND Estado = 1
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectConsejo]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectConsejo](	@IdConsejo int)asBEGIN




SELECT [IdConsejo]
      ,[Consejo]
      ,[IdUsuario]
      ,[Dimension]
  FROM [dbo].[T_Consejos]
  WHERE @IdConsejo = IdConsejo

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectConsejos]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectConsejos]asBEGIN




SELECT [IdConsejo]
      ,[Consejo]
      ,[IdUsuario]
      ,[Dimension]
  FROM [dbo].[T_Consejos]
  ORDER BY IdConsejo ASC
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectConsejosDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectConsejosDimension](	@Dimension int)asBEGIN




SELECT [IdConsejo]
      ,[Consejo]
      ,[IdUsuario]
      ,[Dimension]
  FROM [dbo].[T_Consejos]
  WHERE @Dimension = Dimension

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectPerfil]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectPerfil](	@IdUsuario int)asBEGIN


SELECT [IdPerfil]
      ,[NombreUsuario]
      ,[FechaNacimiento]
      ,[Sexo]
      ,[IdUsuario]
      ,[IdSede]
      ,[IdProfesion]
  FROM [dbo].[T_Perfiles]
  WHERE IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectPregunta]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectPregunta](	@IdPregunta int)asBEGIN



SELECT [IdPregunta]
      ,[Pregunta]
      ,[Tipo]
      ,[Estilo]
      ,[Dimension]
      ,[IdUsuario]
  FROM [dbo].[T_PreguntasDimension]
  WHERE @IdPregunta = IdPregunta

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectPreguntasDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectPreguntasDimension](	@Dimension int)asBEGIN



SELECT [IdPregunta]
      ,[Pregunta]
      ,[Tipo]
      ,[Estilo]
      ,[Dimension]
      ,[IdUsuario]
  FROM [dbo].[T_PreguntasDimension]
  WHERE @Dimension = Dimension

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectPreguntasDimensionEstilo]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectPreguntasDimensionEstilo](	@Dimension int,	@Estilo int)asBEGIN



SELECT [IdPregunta]
      ,[Pregunta]
      ,[Tipo]
      ,[Estilo]
      ,[Dimension]
      ,[IdUsuario]
  FROM [dbo].[T_PreguntasDimension]
  WHERE @Dimension = Dimension
  AND Estilo = @Estilo

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectProfesiones]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectProfesiones]
As
BEGIN
	SELECT [IdProfesion]
		  ,[NombreProfesion]
	  FROM [dbo].[T_Profesiones]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectResultadosDimension]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectResultadosDimension](	@Dimension int,	@IdUsuario int)asBEGIN



SELECT TOP (5) [IdResultado]
      ,[TotalResultado]
      ,[Dimension]
      ,[IdUsuario]
      ,[Fecha]
  FROM [dbo].[T_ResultadosDimension]
  WHERE @Dimension = Dimension
  AND @IdUsuario = IdUsuario
  ORDER BY Fecha DESC

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectResultadosDimensionDia]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectResultadosDimensionDia](	@Dimension int,	@IdUsuario int)asBEGIN



SELECT [IdResultado]
      ,[TotalResultado]
      ,[Dimension]
      ,[IdUsuario]
      ,[Fecha]
  FROM [dbo].[T_ResultadosDimension]
  WHERE @Dimension = Dimension
  AND @IdUsuario = IdUsuario
  AND  FORMAT (Fecha, 'dd-MM-yyyy') = FORMAT (getdate(), 'dd-MM-yyyy')

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectResultadosReporte]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SP_SelectResultadosReporte]asBEGIN



SELECT 
	IdResultado,
	TotalResultado,
	Dimension,
	us.Usuario,
	FORMAT (Fecha, 'dd-MM-yyyy')
FROM [dbo].[T_ResultadosDimension] rd
INNER JOIN [dbo].[T_Usuarios] us ON us.IdUsuario = rd.IdUsuario
ORDER BY FECHA ASC

END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectRoles]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectRoles]
As
BEGIN
	SELECT [IdRol]
      ,[NombreRol]
  FROM [dbo].[T_Roles]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectSedes]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectSedes]
As
BEGIN
	SELECT [IdSede]
		  ,[Descripcion]
	  FROM [dbo].[T_Sedes]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectUsuario]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectUsuario]
(	@IdUsuario int)
As
BEGIN
	SELECT us.[IdUsuario]
		  ,[Usuario]
		  ,[Contrasena]
		  ,[FechaCreacion]
		  ,[Estado]
		  ,[Sexo]
		  ,per.[IdPerfil]
		  ,per.[NombreUsuario]
		  ,per.[FechaNacimiento]
		  ,per.[IdSede]
		  ,per.[IdProfesion]
		  ,[IdRol]
	  FROM [dbo].[T_Usuarios] us
	  LEFT JOIN T_Perfiles per ON per.IdUsuario = us.IdUsuario
	  WHERE us.IdUsuario = @IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectUsuarios]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectUsuarios]

As
BEGIN
	SELECT us.[IdUsuario]
		  ,[Usuario]
		  ,[Contrasena]
		  ,[FechaCreacion]
		  ,[Estado]
		  ,per.[IdPerfil]
		  ,per.[NombreUsuario]
		  ,per.[FechaNacimiento]
		  ,per.[IdSede]
		  ,per.[IdProfesion]
		  ,[IdRol]
	  FROM [dbo].[T_Usuarios] us
	  LEFT JOIN T_Perfiles per ON per.IdUsuario = us.IdUsuario
END
GO
/****** Object:  StoredProcedure [dbo].[SP_SelectUsuariosReporte]    Script Date: 26/01/2022 11:49:25 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_SelectUsuariosReporte]

As
BEGIN
	SELECT us.[IdUsuario]
		  ,[Usuario]
		  ,[Contrasena]
		  ,[FechaCreacion]
		  ,[Estado]
		  ,per.[IdPerfil]
		  ,per.[NombreUsuario]
		  ,per.[FechaNacimiento]
		  ,per.[IdSede]
		  ,per.[IdProfesion]
		  ,[IdRol]
		  ,sed.[Descripcion] Sede
		  ,pro.NombreProfesion Profesion
	  FROM [dbo].[T_Usuarios] us
	  LEFT JOIN T_Perfiles per ON per.IdUsuario = us.IdUsuario
	  INNER JOIN T_Sedes sed ON sed.IdSede = per.IdSede
	  INNER JOIN T_Profesiones pro ON pro.IdProfesion = per.IdProfesion
END
GO
