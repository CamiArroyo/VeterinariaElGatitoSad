USE [master]
GO
/****** Object:  Database [PAV-3K2-2021-12]    Script Date: 27/9/2021 20:44:10 ******/
CREATE DATABASE [PAV-3K2-2021-12]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PAV-3K2-2021-12', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PAV-3K2-2021-12.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PAV-3K2-2021-12_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\DATA\PAV-3K2-2021-12_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [PAV-3K2-2021-12] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PAV-3K2-2021-12].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ARITHABORT OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET  ENABLE_BROKER 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET RECOVERY FULL 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET  MULTI_USER 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PAV-3K2-2021-12] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PAV-3K2-2021-12] SET QUERY_STORE = OFF
GO
USE [PAV-3K2-2021-12]
GO
/****** Object:  Table [dbo].[CALENDARIO_VAC]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CALENDARIO_VAC](
	[nro_historia_clinica] [int] NOT NULL,
	[nro_calendario_vac] [int] IDENTITY(1,1) NOT NULL,
	[fecha_inicio] [datetime] NULL,
	[observaciones] [varchar](250) NULL,
 CONSTRAINT [PK_CALENDARIO_VAC_1] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[nro_calendario_vac] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CONSULTAS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONSULTAS](
	[nro_historia_clinica] [int] NOT NULL,
	[id_consulta] [int] IDENTITY(1,1) NOT NULL,
	[fecha_entrada] [datetime] NULL,
	[fecha_salida] [datetime] NULL,
	[id_empleado] [int] NULL,
 CONSTRAINT [PK_CONSULTAS] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_consulta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLE_CALENDARIO_VAC]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLE_CALENDARIO_VAC](
	[nro_historia_clinica] [int] NOT NULL,
	[nro_calendario_vac] [int] NOT NULL,
	[nro_detalle_calendario] [int] IDENTITY(1,1) NOT NULL,
	[id_vacuna] [int] NULL,
	[fecha_prevista] [datetime] NULL,
	[fecha_real] [datetime] NULL,
	[dosis] [varchar](50) NULL,
	[id_empleado] [int] NULL,
 CONSTRAINT [PK_DETALLE_CALENDARIO_VAC] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[nro_calendario_vac] ASC,
	[nro_detalle_calendario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIAGNOSTICOS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIAGNOSTICOS](
	[id_diagnostico] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_DIAGNOSTICOS] PRIMARY KEY CLUSTERED 
(
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DIAGNxCONSULTA]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DIAGNxCONSULTA](
	[nro_historia_clinica] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_diagnostico] [int] NOT NULL,
 CONSTRAINT [PK_DIAGNxCONSULTA] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_consulta] ASC,
	[id_diagnostico] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DUEÑOS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DUEÑOS](
	[id_dueño] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[telefono] [varchar](50) NULL,
 CONSTRAINT [PK_DUEÑOS] PRIMARY KEY CLUSTERED 
(
	[id_dueño] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[id_empleado] [int] IDENTITY(0,1) NOT NULL,
	[nro_doc_emp] [char](8) NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[fecha_nacimiento] [datetime] NULL,
	[fecha_ingreso] [datetime] NULL,
	[matricula] [varchar](50) NULL,
	[usuario] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[estado] [varchar](50) NULL,
 CONSTRAINT [PK_EMPLEADOS_1] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESPECIES]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESPECIES](
	[id_especie] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](50) NULL,
	[peso_medio] [varchar](50) NULL,
	[altura_media] [varchar](50) NULL,
	[nota_cuidados] [varchar](50) NULL,
	[id_raza] [int] NULL,
 CONSTRAINT [PK_ESPECIES] PRIMARY KEY CLUSTERED 
(
	[id_especie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LABORATORIOS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LABORATORIOS](
	[id_laboratorio] [int] IDENTITY(1,1) NOT NULL,
	[razon_social] [nchar](10) NULL,
	[direccion] [nchar](10) NULL,
 CONSTRAINT [PK_LABORATORIOS] PRIMARY KEY CLUSTERED 
(
	[id_laboratorio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MASCOTAS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MASCOTAS](
	[nro_historia_clinica] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[fecha_nacimiento] [varchar](50) NULL,
	[id_especie] [int] NULL,
	[peso] [varchar](50) NULL,
	[altura] [varchar](50) NULL,
	[id_dueño] [int] NULL,
 CONSTRAINT [PK_MASCOTAS] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMENTOS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMENTOS](
	[id_medicamento] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](250) NULL,
	[id_laboratorio] [int] NULL,
	[fecha_ultima_compra] [date] NULL,
	[cantidad_en_stock] [int] NULL,
 CONSTRAINT [PK_MEDICAMENTOS] PRIMARY KEY CLUSTERED 
(
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICAMxCONSULTA]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICAMxCONSULTA](
	[nro_historia_clinica] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_medicamento] [int] NOT NULL,
	[dosis] [varchar](50) NULL,
	[periodicidad] [varchar](50) NULL,
 CONSTRAINT [PK_MEDICAMxCONSULTA] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_consulta] ASC,
	[id_medicamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RAZAS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RAZAS](
	[id_raza] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL,
	[peso_medio] [varchar](50) NULL,
	[altura_media] [varchar](50) NULL,
 CONSTRAINT [PK_RAZAS] PRIMARY KEY CLUSTERED 
(
	[id_raza] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINTOMAS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINTOMAS](
	[id_sintoma] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](250) NULL,
 CONSTRAINT [PK_SINTOMAS] PRIMARY KEY CLUSTERED 
(
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SINTOMAxCONSULTA]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SINTOMAxCONSULTA](
	[nro_historia_clinica] [int] NOT NULL,
	[id_consulta] [int] NOT NULL,
	[id_sintoma] [int] NOT NULL,
 CONSTRAINT [PK_SINTOMAxCONSULTA] PRIMARY KEY CLUSTERED 
(
	[nro_historia_clinica] ASC,
	[id_consulta] ASC,
	[id_sintoma] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VACUNAS]    Script Date: 27/9/2021 20:44:11 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VACUNAS](
	[id_vacuna] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NULL,
	[descripcion] [varchar](250) NULL,
	[id_laboratorio] [int] NULL,
 CONSTRAINT [PK_VACUNAS] PRIMARY KEY CLUSTERED 
(
	[id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[EMPLEADOS] ON 

INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (2, NULL, NULL, NULL, NULL, NULL, NULL, N'admin', N'admin', NULL, N'Activo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (5, N'41354147', N'NahuelxD', N'NahuelxDDDDD', CAST(N'2021-09-21T19:26:19.000' AS DateTime), CAST(N'2021-09-21T19:26:19.000' AS DateTime), N'VeterinarioPRO', N'Wolfrunner', N'', N'NahuelWolf@gmail.com', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (10, N'11111111', N'Holaaaa', N'Mundo', CAST(N'2021-09-22T15:59:04.000' AS DateTime), CAST(N'2021-09-22T15:59:04.000' AS DateTime), N'Mundo123', N'holaMundo', N'', N'holamundo@gmail.com', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (11, N'12345678', N'Usuario2', N'Usuario3', CAST(N'2021-09-22T16:00:03.000' AS DateTime), CAST(N'2021-09-22T16:00:03.000' AS DateTime), N'usuario11', N'Usuario11', N'', N'usuario11@gmail.com', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (12, N'12345678', N'usuario13', N'Usuario13', CAST(N'2021-09-22T16:01:02.000' AS DateTime), CAST(N'2021-09-22T16:01:02.000' AS DateTime), N'usuario13', N'usuario123', N'xd', N'xasddasdsa@gmdsa', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (13, N'12343   ', N'Usuario14', N'Usuario14', CAST(N'2021-09-22T16:02:11.000' AS DateTime), CAST(N'2021-09-22T16:02:11.000' AS DateTime), N'usuario14', N'Usuario14', N'asd', N'asd', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (14, N'12345678', N'asdd', N'asdd', CAST(N'2021-09-22T20:56:33.000' AS DateTime), CAST(N'2021-09-22T20:56:33.000' AS DateTime), N'asdd', N'asdda', N'asdd', N'asdd', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (15, N'12345678', N'Joel', N'Martinez', CAST(N'2021-09-22T20:58:28.000' AS DateTime), CAST(N'2021-09-22T20:58:28.000' AS DateTime), N'JoelxD123', N'Joelcito', N'hola', N'hola@hola', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (16, N'12345678', N'asdd', N'asddddd', CAST(N'2021-09-22T21:10:57.000' AS DateTime), CAST(N'2021-09-22T21:10:57.000' AS DateTime), N'dddddd', N'ddddddd', N'dddd', N'ddddddddd', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (17, N'12345678', N'Wolf', N'LlegoTarde', CAST(N'2021-09-22T21:37:33.000' AS DateTime), CAST(N'2021-09-22T21:37:33.000' AS DateTime), N'TardeBro', N'KsiLlegas', N'hola', N'AlproximoTP@Tevas.com', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (18, N'456789  ', N'Martin', N'Martincitus', CAST(N'2021-09-22T21:41:11.000' AS DateTime), CAST(N'2021-09-22T21:41:11.000' AS DateTime), N'Tincho', N'MartinTincho', N'holas', N'martin@martin.com', N'Inactivo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (19, N'54125847', N'Juan', N'Perez', CAST(N'2021-09-23T08:44:20.000' AS DateTime), CAST(N'2021-09-23T08:44:20.000' AS DateTime), N'33456971', N'JuanPerez', N'hola', N'JuanPerez@gmail.com', N'Activo')
INSERT [dbo].[EMPLEADOS] ([id_empleado], [nro_doc_emp], [nombre], [apellido], [fecha_nacimiento], [fecha_ingreso], [matricula], [usuario], [password], [email], [estado]) VALUES (20, N'12345678', N'Nombre1', N'Apellido1', CAST(N'2021-09-15T10:33:50.000' AS DateTime), CAST(N'2021-09-22T10:33:50.000' AS DateTime), N'asddsas', N'user1', N'nombre1', N'nuevoemail@gmail.com', N'Inactivo')
SET IDENTITY_INSERT [dbo].[EMPLEADOS] OFF
GO
/****** Object:  Index [IX_VACUNAS]    Script Date: 27/9/2021 20:44:14 ******/
CREATE NONCLUSTERED INDEX [IX_VACUNAS] ON [dbo].[VACUNAS]
(
	[id_vacuna] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CALENDARIO_VAC]  WITH CHECK ADD  CONSTRAINT [FK_CALENDARIO_VAC_MASCOTAS] FOREIGN KEY([nro_historia_clinica])
REFERENCES [dbo].[MASCOTAS] ([nro_historia_clinica])
GO
ALTER TABLE [dbo].[CALENDARIO_VAC] CHECK CONSTRAINT [FK_CALENDARIO_VAC_MASCOTAS]
GO
ALTER TABLE [dbo].[CONSULTAS]  WITH CHECK ADD  CONSTRAINT [FK_CONSULTAS_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[CONSULTAS] CHECK CONSTRAINT [FK_CONSULTAS_EMPLEADOS]
GO
ALTER TABLE [dbo].[CONSULTAS]  WITH CHECK ADD  CONSTRAINT [FK_CONSULTAS_MASCOTAS] FOREIGN KEY([nro_historia_clinica])
REFERENCES [dbo].[MASCOTAS] ([nro_historia_clinica])
GO
ALTER TABLE [dbo].[CONSULTAS] CHECK CONSTRAINT [FK_CONSULTAS_MASCOTAS]
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_DETALLE_CALENDARIO_VAC] FOREIGN KEY([nro_historia_clinica], [nro_calendario_vac])
REFERENCES [dbo].[CALENDARIO_VAC] ([nro_historia_clinica], [nro_calendario_vac])
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC] CHECK CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_DETALLE_CALENDARIO_VAC]
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_EMPLEADOS] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[EMPLEADOS] ([id_empleado])
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC] CHECK CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_EMPLEADOS]
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC]  WITH CHECK ADD  CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_VACUNAS] FOREIGN KEY([id_vacuna])
REFERENCES [dbo].[VACUNAS] ([id_vacuna])
GO
ALTER TABLE [dbo].[DETALLE_CALENDARIO_VAC] CHECK CONSTRAINT [FK_DETALLE_CALENDARIO_VAC_VACUNAS]
GO
ALTER TABLE [dbo].[DIAGNxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_DIAGNxCONSULTA_CONSULTA] FOREIGN KEY([nro_historia_clinica], [id_consulta])
REFERENCES [dbo].[CONSULTAS] ([nro_historia_clinica], [id_consulta])
GO
ALTER TABLE [dbo].[DIAGNxCONSULTA] CHECK CONSTRAINT [FK_DIAGNxCONSULTA_CONSULTA]
GO
ALTER TABLE [dbo].[DIAGNxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_DIAGNxCONSULTA_DIAGNOSTICOS] FOREIGN KEY([id_diagnostico])
REFERENCES [dbo].[DIAGNOSTICOS] ([id_diagnostico])
GO
ALTER TABLE [dbo].[DIAGNxCONSULTA] CHECK CONSTRAINT [FK_DIAGNxCONSULTA_DIAGNOSTICOS]
GO
ALTER TABLE [dbo].[ESPECIES]  WITH CHECK ADD  CONSTRAINT [FK_ESPECIES_RAZAS] FOREIGN KEY([id_raza])
REFERENCES [dbo].[RAZAS] ([id_raza])
GO
ALTER TABLE [dbo].[ESPECIES] CHECK CONSTRAINT [FK_ESPECIES_RAZAS]
GO
ALTER TABLE [dbo].[MASCOTAS]  WITH CHECK ADD  CONSTRAINT [FK_MASCOTAS_DUEÑOS] FOREIGN KEY([id_dueño])
REFERENCES [dbo].[DUEÑOS] ([id_dueño])
GO
ALTER TABLE [dbo].[MASCOTAS] CHECK CONSTRAINT [FK_MASCOTAS_DUEÑOS]
GO
ALTER TABLE [dbo].[MASCOTAS]  WITH CHECK ADD  CONSTRAINT [FK_MASCOTAS_ESPECIES] FOREIGN KEY([id_especie])
REFERENCES [dbo].[ESPECIES] ([id_especie])
GO
ALTER TABLE [dbo].[MASCOTAS] CHECK CONSTRAINT [FK_MASCOTAS_ESPECIES]
GO
ALTER TABLE [dbo].[MEDICAMENTOS]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMENTOS_LABORATORIOS] FOREIGN KEY([id_laboratorio])
REFERENCES [dbo].[LABORATORIOS] ([id_laboratorio])
GO
ALTER TABLE [dbo].[MEDICAMENTOS] CHECK CONSTRAINT [FK_MEDICAMENTOS_LABORATORIOS]
GO
ALTER TABLE [dbo].[MEDICAMxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMxCONSULTA_CONSULTA] FOREIGN KEY([nro_historia_clinica], [id_consulta])
REFERENCES [dbo].[CONSULTAS] ([nro_historia_clinica], [id_consulta])
GO
ALTER TABLE [dbo].[MEDICAMxCONSULTA] CHECK CONSTRAINT [FK_MEDICAMxCONSULTA_CONSULTA]
GO
ALTER TABLE [dbo].[MEDICAMxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_MEDICAMxCONSULTA_MEDICAMENTOS] FOREIGN KEY([id_medicamento])
REFERENCES [dbo].[MEDICAMENTOS] ([id_medicamento])
GO
ALTER TABLE [dbo].[MEDICAMxCONSULTA] CHECK CONSTRAINT [FK_MEDICAMxCONSULTA_MEDICAMENTOS]
GO
ALTER TABLE [dbo].[SINTOMAxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_SINTOMAxCONSULTA_CONSULTAS] FOREIGN KEY([nro_historia_clinica], [id_consulta])
REFERENCES [dbo].[CONSULTAS] ([nro_historia_clinica], [id_consulta])
GO
ALTER TABLE [dbo].[SINTOMAxCONSULTA] CHECK CONSTRAINT [FK_SINTOMAxCONSULTA_CONSULTAS]
GO
ALTER TABLE [dbo].[SINTOMAxCONSULTA]  WITH CHECK ADD  CONSTRAINT [FK_SINTOMAxCONSULTA_SINTOMAS] FOREIGN KEY([id_sintoma])
REFERENCES [dbo].[SINTOMAS] ([id_sintoma])
GO
ALTER TABLE [dbo].[SINTOMAxCONSULTA] CHECK CONSTRAINT [FK_SINTOMAxCONSULTA_SINTOMAS]
GO
ALTER TABLE [dbo].[VACUNAS]  WITH CHECK ADD  CONSTRAINT [FK_VACUNAS_LABORATORIOS] FOREIGN KEY([id_laboratorio])
REFERENCES [dbo].[LABORATORIOS] ([id_laboratorio])
GO
ALTER TABLE [dbo].[VACUNAS] CHECK CONSTRAINT [FK_VACUNAS_LABORATORIOS]
GO
USE [master]
GO
ALTER DATABASE [PAV-3K2-2021-12] SET  READ_WRITE 
GO
