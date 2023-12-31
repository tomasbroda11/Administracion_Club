USE [master]
GO
/****** Object:  Database [db_club]    Script Date: 15/11/2023 09:59:38 ******/
CREATE DATABASE [db_club]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_club', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_club.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_club_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\db_club_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_club] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_club].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_club] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_club] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_club] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_club] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_club] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_club] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_club] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_club] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_club] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_club] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_club] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_club] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_club] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_club] SET  DISABLE_BROKER 
GO
ALTER DATABASE [db_club] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_club] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_club] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_club] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_club] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_club] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_club] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_club] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [db_club] SET  MULTI_USER 
GO
ALTER DATABASE [db_club] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_club] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_club] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_club] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_club] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_club] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [db_club] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_club] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_club]
GO
/****** Object:  Table [dbo].[actividades]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[actividades](
	[idActividad] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[costo] [float] NOT NULL,
 CONSTRAINT [PK_actividades] PRIMARY KEY CLUSTERED 
(
	[idActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cuotas]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cuotas](
	[idCuota] [int] IDENTITY(1,1) NOT NULL,
	[idSocio] [int] NULL,
	[mes] [int] NOT NULL,
	[anio] [int] NOT NULL,
	[monto] [decimal](10, 2) NOT NULL,
	[pagado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCuota] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[entrenamientos]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[entrenamientos](
	[idEntrenamiento] [int] IDENTITY(1,1) NOT NULL,
	[horaDesde] [time](7) NULL,
	[horaHasta] [time](7) NULL,
	[dia] [int] NULL,
	[idProfesor] [int] NULL,
	[idInstalacion] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[idEntrenamiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[instalaciones]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[instalaciones](
	[idInstalacion] [int] NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[idActividad] [int] NOT NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idInstalacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[personas]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[personas](
	[dni] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[rol] [varchar](50) NULL,
	[idActividad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[reservas]    Script Date: 15/11/2023 09:59:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[reservas](
	[idReservas] [int] NOT NULL,
	[estado] [varchar](50) NOT NULL,
	[idInstalacion] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[hora] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[idReservas] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (1, N'Natación', 5000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (2, N'Fútbol', 4000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (3, N'Tenis', 6000)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (4, N'Yoga', 300)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (5, N'Baloncesto', 4500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (6, N'Voleibol', 3500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (7, N'Hockey', 5500)
INSERT [dbo].[actividades] ([idActividad], [descripcion], [costo]) VALUES (8, N'Rugby', 2500)
GO
SET IDENTITY_INSERT [dbo].[cuotas] ON 

INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (1, 10101010, 2, 2023, CAST(5000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (2, 2277738, 5, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (3, 10101010, 4, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (5, 10101010, 6, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (6, 10101010, 12, 2022, CAST(1000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (7, 10101010, 11, 2022, CAST(900.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (8, 2277738, 6, 2023, CAST(2000.00 AS Decimal(10, 2)), 0)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (10, 2277738, 7, 2023, CAST(2000.00 AS Decimal(10, 2)), 1)
INSERT [dbo].[cuotas] ([idCuota], [idSocio], [mes], [anio], [monto], [pagado]) VALUES (11, 2277738, 8, 2023, CAST(2000.00 AS Decimal(10, 2)), 0)
SET IDENTITY_INSERT [dbo].[cuotas] OFF
GO
SET IDENTITY_INSERT [dbo].[entrenamientos] ON 

INSERT [dbo].[entrenamientos] ([idEntrenamiento], [horaDesde], [horaHasta], [dia], [idProfesor], [idInstalacion]) VALUES (1, CAST(N'18:00:00' AS Time), CAST(N'19:00:00' AS Time), 1, 21345532, 2)
INSERT [dbo].[entrenamientos] ([idEntrenamiento], [horaDesde], [horaHasta], [dia], [idProfesor], [idInstalacion]) VALUES (3, CAST(N'09:00:00' AS Time), CAST(N'10:00:00' AS Time), 4, 21345532, 2)
INSERT [dbo].[entrenamientos] ([idEntrenamiento], [horaDesde], [horaHasta], [dia], [idProfesor], [idInstalacion]) VALUES (4, CAST(N'08:00:00' AS Time), CAST(N'09:00:00' AS Time), 2, 21345532, 9)
SET IDENTITY_INSERT [dbo].[entrenamientos] OFF
GO
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (1, N'Piscina Olímpica', 1, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (2, N'Cancha de Fútbol 1', 2, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (3, N'Cancha de Tenis', 3, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (4, N'Sala de Yoga', 4, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (5, N'Cancha de Hockey', 7, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (6, N'Cancha de Baloncesto', 5, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (7, N'Cancha de Voleibol', 6, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (8, N'Cancha de Rugby', 8, 1)
INSERT [dbo].[instalaciones] ([idInstalacion], [descripcion], [idActividad], [activo]) VALUES (9, N'Cancha de Fútbol 2', 2, 1)
GO
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (11, N'tomas', N'broda', N'tomasbroda@gmail.com', N'asd', N'admin', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (2277738, N'Juliancito ', N'Bocha', N'julian@bochini.cai', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (3868035, N'Sigfrid', N'Hiley', N'shiley0@noaa.gov', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (10101010, N'Alejandro', N'Foresi', NULL, N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (14662575, N'Binny', N'Tullis', N'btullis4@answers.com', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (20202020, N'Robbert', N'Coulson', N'rcoulson3@reverbnation.com', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (21345532, N'Martin', N'Palermo', N'martin@palermo.com', N'asd', N'profesor', 2)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (30303030, N'Nom', N'asa', N'sdds', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (36337493, N'Gay', N'Cleatherow', N'gcleatherow6@ustream.tv', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (37893642, N'Melessa', N'Fidler', N'mfidler9@prweb.com', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (43590396, N'Guillema', N'Josiah', N'gjosiah7@accuweather.com', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (45728170, N'Pedrito', N'Gutierrez', N'pepi@guti.com', N'asd', N'user', NULL)
INSERT [dbo].[personas] ([dni], [nombre], [apellido], [email], [password], [rol], [idActividad]) VALUES (46351505, N'Jasun', N'Birden', N'jbirden5@tmall.com', N'asd', NULL, NULL)
GO
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (1, N'Completada', 1, 10101010, CAST(N'2023-10-10T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (2, N'Pendiente', 2, 10101010, CAST(N'2023-10-11T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (3, N'Cancelada', 3, 10101010, CAST(N'2023-10-12T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (4, N'Completada', 4, 10101010, CAST(N'2023-10-13T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (5, N'Pendiente', 4, 10101010, CAST(N'2023-11-11T10:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (6, N'Pendiente', 1, 10101010, CAST(N'2023-11-09T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (7, N'Pendiente', 1, 10101010, CAST(N'2023-11-11T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (8, N'Pendiente', 7, 10101010, CAST(N'2023-11-12T12:00:00.000' AS DateTime), CAST(N'12:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (9, N'Pendiente', 6, 10101010, CAST(N'2023-11-21T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (10, N'Pendiente', 8, 10101010, CAST(N'2023-11-17T08:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (11, N'Pendiente', 9, 10101010, CAST(N'2023-11-17T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (12, N'Pendiente', 5, 10101010, CAST(N'2023-11-14T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (13, N'Pendiente', 3, 10101010, CAST(N'2023-11-14T10:00:00.000' AS DateTime), CAST(N'10:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (14, N'Pendiente', 2, 10101010, CAST(N'2023-11-14T08:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (15, N'Pendiente', 1, 2277738, CAST(N'2023-11-15T08:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (16, N'Pendiente', 4, 3868035, CAST(N'2023-11-16T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (17, N'Pendiente', 7, 10101010, CAST(N'2023-12-17T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (26, N'Pendiente', 2, 14662575, CAST(N'2023-11-18T12:00:00.000' AS DateTime), CAST(N'12:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (27, N'Pendiente', 5, 20202020, CAST(N'2023-11-19T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (28, N'Pendiente', 8, 30303030, CAST(N'2023-11-20T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (29, N'Pendiente', 3, 36337493, CAST(N'2023-12-21T17:00:00.000' AS DateTime), CAST(N'17:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (30, N'Pendiente', 6, 37893642, CAST(N'2023-12-22T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (31, N'Pendiente', 9, 43590396, CAST(N'2023-12-23T20:00:00.000' AS DateTime), CAST(N'20:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (32, N'Pendiente', 1, 2277738, CAST(N'2023-11-24T21:00:00.000' AS DateTime), CAST(N'21:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (33, N'Completada', 2, 14662575, CAST(N'2023-09-10T14:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (34, N'Completada', 5, 20202020, CAST(N'2023-07-11T15:00:00.000' AS DateTime), CAST(N'15:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (35, N'Completada', 8, 30303030, CAST(N'2023-05-12T17:00:00.000' AS DateTime), CAST(N'17:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (36, N'Completada', 3, 36337493, CAST(N'2023-10-13T18:00:00.000' AS DateTime), CAST(N'18:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (37, N'Completada', 6, 37893642, CAST(N'2023-09-14T20:00:00.000' AS DateTime), CAST(N'20:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (38, N'Completada', 9, 43590396, CAST(N'2023-06-15T21:00:00.000' AS DateTime), CAST(N'21:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (39, N'Completada', 1, 2277738, CAST(N'2023-03-16T08:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (40, N'Completada', 4, 3868035, CAST(N'2023-07-17T09:00:00.000' AS DateTime), CAST(N'09:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (41, N'Completada', 7, 10101010, CAST(N'2023-06-18T11:00:00.000' AS DateTime), CAST(N'11:00:00' AS Time))
INSERT [dbo].[reservas] ([idReservas], [estado], [idInstalacion], [dni], [fecha], [hora]) VALUES (42, N'Completada', 2, 14662575, CAST(N'2023-04-19T12:00:00.000' AS DateTime), CAST(N'12:00:00' AS Time))
GO
/****** Object:  Index [IX_personas]    Script Date: 15/11/2023 09:59:45 ******/
CREATE NONCLUSTERED INDEX [IX_personas] ON [dbo].[personas]
(
	[idActividad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[instalaciones] ADD  DEFAULT ((1)) FOR [activo]
GO
ALTER TABLE [dbo].[cuotas]  WITH CHECK ADD FOREIGN KEY([idSocio])
REFERENCES [dbo].[personas] ([dni])
GO
ALTER TABLE [dbo].[entrenamientos]  WITH CHECK ADD FOREIGN KEY([idInstalacion])
REFERENCES [dbo].[instalaciones] ([idInstalacion])
GO
ALTER TABLE [dbo].[entrenamientos]  WITH CHECK ADD FOREIGN KEY([idProfesor])
REFERENCES [dbo].[personas] ([dni])
GO
ALTER TABLE [dbo].[instalaciones]  WITH CHECK ADD FOREIGN KEY([idActividad])
REFERENCES [dbo].[actividades] ([idActividad])
GO
ALTER TABLE [dbo].[personas]  WITH CHECK ADD  CONSTRAINT [FK_Personas_Actividades] FOREIGN KEY([idActividad])
REFERENCES [dbo].[actividades] ([idActividad])
GO
ALTER TABLE [dbo].[personas] CHECK CONSTRAINT [FK_Personas_Actividades]
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD FOREIGN KEY([dni])
REFERENCES [dbo].[personas] ([dni])
GO
ALTER TABLE [dbo].[reservas]  WITH CHECK ADD FOREIGN KEY([idInstalacion])
REFERENCES [dbo].[instalaciones] ([idInstalacion])
GO
USE [master]
GO
ALTER DATABASE [db_club] SET  READ_WRITE 
GO
