USE [master]
GO
/****** Object:  Database [MEGAHACK]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE DATABASE [MEGAHACK]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MEGAHACK', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MEGAHACK.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MEGAHACK_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MEGAHACK_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [MEGAHACK] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MEGAHACK].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MEGAHACK] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MEGAHACK] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MEGAHACK] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MEGAHACK] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MEGAHACK] SET ARITHABORT OFF 
GO
ALTER DATABASE [MEGAHACK] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [MEGAHACK] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MEGAHACK] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MEGAHACK] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MEGAHACK] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MEGAHACK] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MEGAHACK] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MEGAHACK] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MEGAHACK] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MEGAHACK] SET  ENABLE_BROKER 
GO
ALTER DATABASE [MEGAHACK] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MEGAHACK] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MEGAHACK] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MEGAHACK] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MEGAHACK] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MEGAHACK] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [MEGAHACK] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MEGAHACK] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MEGAHACK] SET  MULTI_USER 
GO
ALTER DATABASE [MEGAHACK] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MEGAHACK] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MEGAHACK] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MEGAHACK] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MEGAHACK] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MEGAHACK] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [MEGAHACK] SET QUERY_STORE = OFF
GO
USE [MEGAHACK]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Assignments_orders]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Assignments_orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[date_order] [datetime] NOT NULL,
	[date_finish] [datetime] NULL,
	[technician_id] [int] NOT NULL,
	[subscriber_id] [int] NOT NULL,
	[service_id] [int] NOT NULL,
	[state_order] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Assignments_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Bonus_tabs]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bonus_tabs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[min_range] [int] NOT NULL,
	[max_range] [int] NOT NULL,
	[bonus] [int] NOT NULL,
 CONSTRAINT [PK_Bonus_tabs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[jobs_catalog]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[jobs_catalog](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[duration] [int] NOT NULL,
	[description] [nvarchar](100) NOT NULL,
	[points] [int] NOT NULL,
 CONSTRAINT [PK_jobs_catalog] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Quadrille]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Quadrille](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[quadrille_number] [int] NOT NULL,
 CONSTRAINT [PK_Quadrille] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subscriptor]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subscriptor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[last_name] [nvarchar](255) NOT NULL,
	[street] [nvarchar](255) NOT NULL,
	[street_number] [nvarchar](max) NOT NULL,
	[post_code] [int] NOT NULL,
	[zone] [nvarchar](250) NOT NULL,
	[phone] [bigint] NOT NULL,
 CONSTRAINT [PK_Subscriptor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Technicians]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Technicians](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employee_number] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[last_name] [nvarchar](255) NOT NULL,
	[phone] [bigint] NOT NULL,
	[quadrille_id] [int] NOT NULL,
 CONSTRAINT [PK_Technicians] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 30/09/2024 06:04:44 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](255) NOT NULL,
	[num_emp] [int] NOT NULL,
	[password] [nvarchar](255) NOT NULL,
	[role] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240926000024_InitialMigration', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240930035534_UniqueTecNum', N'8.0.8')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240930220257_AddUserTable', N'8.0.8')
GO
SET IDENTITY_INSERT [dbo].[Assignments_orders] ON 

INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (1, CAST(N'2024-09-30T00:22:00.000' AS DateTime), CAST(N'2024-10-02T18:11:00.000' AS DateTime), 1, 1, 1, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (2, CAST(N'2024-10-01T16:52:00.000' AS DateTime), CAST(N'2024-10-02T08:40:00.000' AS DateTime), 2, 2, 2, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (3, CAST(N'2024-10-01T21:39:00.000' AS DateTime), CAST(N'2024-10-02T20:03:00.000' AS DateTime), 2, 2, 2, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (4, CAST(N'2024-10-01T06:21:00.000' AS DateTime), CAST(N'2024-10-02T10:29:00.000' AS DateTime), 3, 3, 3, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (5, CAST(N'2024-09-30T23:05:00.000' AS DateTime), CAST(N'2024-10-01T04:16:00.000' AS DateTime), 4, 4, 4, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (6, CAST(N'2024-10-01T05:53:00.000' AS DateTime), CAST(N'2024-10-01T20:06:00.000' AS DateTime), 5, 5, 5, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (7, CAST(N'2024-09-30T00:28:00.000' AS DateTime), CAST(N'2024-10-02T20:29:00.000' AS DateTime), 6, 6, 6, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (8, CAST(N'2024-10-01T04:23:00.000' AS DateTime), CAST(N'2024-10-01T11:53:00.000' AS DateTime), 7, 7, 7, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (9, CAST(N'2024-09-30T15:17:00.000' AS DateTime), CAST(N'2024-10-02T10:07:00.000' AS DateTime), 8, 8, 8, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (10, CAST(N'2024-09-30T11:37:00.000' AS DateTime), CAST(N'2024-10-01T01:39:00.000' AS DateTime), 9, 9, 9, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (11, CAST(N'2024-09-30T16:57:00.000' AS DateTime), CAST(N'2024-10-01T03:05:00.000' AS DateTime), 10, 10, 10, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (12, CAST(N'2024-10-01T21:12:00.000' AS DateTime), CAST(N'2024-10-02T18:37:00.000' AS DateTime), 11, 11, 11, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (13, CAST(N'2024-10-01T23:39:00.000' AS DateTime), CAST(N'2024-10-01T11:37:00.000' AS DateTime), 12, 12, 12, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (14, CAST(N'2024-09-30T18:40:00.000' AS DateTime), CAST(N'2024-10-01T21:25:00.000' AS DateTime), 1, 1, 13, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (15, CAST(N'2024-10-01T20:35:00.000' AS DateTime), CAST(N'2024-10-01T14:44:00.000' AS DateTime), 2, 2, 14, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (16, CAST(N'2024-09-30T21:50:00.000' AS DateTime), CAST(N'2024-10-01T02:38:00.000' AS DateTime), 3, 3, 15, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (17, CAST(N'2024-10-01T16:14:00.000' AS DateTime), CAST(N'2024-10-02T08:08:00.000' AS DateTime), 4, 4, 16, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (18, CAST(N'2024-10-01T20:40:00.000' AS DateTime), CAST(N'2024-10-01T07:24:00.000' AS DateTime), 5, 5, 17, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (19, CAST(N'2024-10-01T05:17:00.000' AS DateTime), CAST(N'2024-10-01T09:03:00.000' AS DateTime), 6, 6, 5, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (20, CAST(N'2024-09-30T15:15:00.000' AS DateTime), CAST(N'2024-10-01T05:21:00.000' AS DateTime), 7, 7, 2, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (21, CAST(N'2024-09-30T22:30:00.000' AS DateTime), CAST(N'2024-10-02T17:34:00.000' AS DateTime), 8, 8, 1, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (22, CAST(N'2024-09-30T18:52:00.000' AS DateTime), NULL, 9, 9, 3, N'Pendiente')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (23, CAST(N'2024-10-01T17:02:00.000' AS DateTime), NULL, 10, 10, 4, N'En Progreso')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (24, CAST(N'2024-10-01T00:46:00.000' AS DateTime), CAST(N'2024-10-01T22:32:00.000' AS DateTime), 11, 11, 5, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (25, CAST(N'2024-10-01T02:44:00.000' AS DateTime), NULL, 12, 12, 6, N'Pendiente')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (26, CAST(N'2024-09-30T06:04:00.000' AS DateTime), NULL, 1, 1, 7, N'En Progreso')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (27, CAST(N'2024-10-01T07:43:00.000' AS DateTime), CAST(N'2024-10-02T12:52:00.000' AS DateTime), 2, 2, 8, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (28, CAST(N'2024-10-01T13:51:00.000' AS DateTime), NULL, 3, 3, 9, N'Pendiente')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (29, CAST(N'2024-10-01T01:23:00.000' AS DateTime), NULL, 4, 4, 10, N'En Progreso')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (30, CAST(N'2024-10-01T14:55:00.000' AS DateTime), CAST(N'2024-10-02T23:15:00.000' AS DateTime), 5, 5, 11, N'Completado')
INSERT [dbo].[Assignments_orders] ([id], [date_order], [date_finish], [technician_id], [subscriber_id], [service_id], [state_order]) VALUES (31, CAST(N'2024-10-01T10:40:00.000' AS DateTime), NULL, 6, 6, 12, N'Pendiente')
SET IDENTITY_INSERT [dbo].[Assignments_orders] OFF
GO
SET IDENTITY_INSERT [dbo].[Bonus_tabs] ON 

INSERT [dbo].[Bonus_tabs] ([Id], [min_range], [max_range], [bonus]) VALUES (1, 0, 80, 0)
INSERT [dbo].[Bonus_tabs] ([Id], [min_range], [max_range], [bonus]) VALUES (2, 81, 150, 300)
INSERT [dbo].[Bonus_tabs] ([Id], [min_range], [max_range], [bonus]) VALUES (3, 151, 210, 500)
INSERT [dbo].[Bonus_tabs] ([Id], [min_range], [max_range], [bonus]) VALUES (4, 211, 300, 800)
INSERT [dbo].[Bonus_tabs] ([Id], [min_range], [max_range], [bonus]) VALUES (5, 301, 400, 1000)
SET IDENTITY_INSERT [dbo].[Bonus_tabs] OFF
GO
SET IDENTITY_INSERT [dbo].[jobs_catalog] ON 

INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (1, N'Instalación de Línea Telefónica', 2, N'Instalación y activación de línea telefónica residencial.', 50)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (2, N'Reparación de Línea Telefónica', 1, N'Resolución de problemas en la línea telefónica.', 40)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (3, N'Cambio de Número Telefónico', 1, N'Cambio de número telefónico en la misma línea.', 30)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (4, N'Configuración de Teléfono Fijo', 1, N'Configuración de funciones en teléfono fijo.', 20)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (5, N'Instalación de Internet', 3, N'Instalación de modem y activación del servicio de internet.', 80)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (6, N'Mantenimiento de Internet', 1, N'Revisión y mantenimiento preventivo del equipo de internet.', 30)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (7, N'Configuración de Red Wi-Fi', 2, N'Configuración de la red Wi-Fi y dispositivos conectados.', 60)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (8, N'Cambio de Modem', 1, N'Cambio de equipo por actualización o mal funcionamiento.', 40)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (9, N'Soporte Técnico de Internet', 1, N'Asistencia remota o en sitio para problemas de internet.', 30)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (10, N'Instalación de TV Básica', 2, N'Instalación de decodificador y activación de canales básicos.', 50)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (11, N'Instalación de TV Premium', 3, N'Instalación de decodificador y activación de canales premium.', 80)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (12, N'Reparación de Señal de TV', 1, N'Resolución de problemas con la señal de televisión.', 40)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (13, N'Cambio de Decodificador', 1, N'Cambio de equipo por actualización o mal funcionamiento.', 40)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (14, N'Configuración de Canales', 1, N'Configuración y personalización de canales de TV.', 30)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (15, N'Paquete Triple Play', 4, N'Instalación de servicio de telefonía, internet y TV.', 120)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (16, N'Actualización de Servicios', 2, N'Actualización de servicios combinados de telefonía, internet y TV.', 70)
INSERT [dbo].[jobs_catalog] ([id], [name], [duration], [description], [points]) VALUES (17, N'Soporte Integral de Servicios', 2, N'Asistencia técnica para problemas en servicios combinados.', 50)
SET IDENTITY_INSERT [dbo].[jobs_catalog] OFF
GO
SET IDENTITY_INSERT [dbo].[Quadrille] ON 

INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (1, 1001)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (2, 1002)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (3, 1003)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (4, 1004)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (5, 1005)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (6, 1006)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (7, 1007)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (8, 1008)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (9, 1009)
INSERT [dbo].[Quadrille] ([Id], [quadrille_number]) VALUES (10, 1010)
SET IDENTITY_INSERT [dbo].[Quadrille] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscriptor] ON 

INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (1, 1, N'Juan', N'Garcia', N'Calle 1', N'1219', 12345, N'Zona Norte', 3919890119)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (2, 2, N'Maria', N'Hernandez', N'Calle 2', N'2468', 12346, N'Zona Sur', 3919890120)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (3, 3, N'Pedro', N'Lopez', N'Calle 3', N'3579', 12347, N'Zona Este', 3919890121)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (4, 4, N'Ana', N'Martinez', N'Calle 4', N'4680', 12348, N'Zona Oeste', 3919890122)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (5, 5, N'Luis', N'Gomez', N'Calle 5', N'5791', 12349, N'Zona Centro', 3919890123)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (6, 6, N'Laura', N'Rodriguez', N'Calle 6', N'6802', 12350, N'Zona Norte', 3919890124)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (7, 7, N'Carlos', N'Perez', N'Calle 7', N'7913', 12351, N'Zona Sur', 3919890125)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (8, 8, N'Elena', N'Ramirez', N'Calle 8', N'8024', 12352, N'Zona Este', 3919890126)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (9, 9, N'Miguel', N'Sanchez', N'Calle 9', N'9135', 12353, N'Zona Oeste', 3919890127)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (10, 10, N'Jose', N'Torres', N'Calle 10', N'1046', 12354, N'Zona Centro', 3919890128)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (11, 11, N'Adriana', N'Diaz', N'Calle 11', N'1157', 12355, N'Zona Norte', 3919890129)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (12, 12, N'Fernando', N'Gutierrez', N'Calle 12', N'1268', 12356, N'Zona Sur', 3919890130)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (13, 13, N'Sofia', N'Vazquez', N'Avenida Principal', N'2435', 12357, N'Zona Noreste', 3919890131)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (14, 14, N'Roberto', N'Fernandez', N'Boulevard Central', N'789', 12358, N'Zona Sureste', 3919890132)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (15, 15, N'Carmen', N'Ortega', N'Paseo de la Reforma', N'5012', 12359, N'Zona Noroeste', 3919890133)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (16, 16, N'Javier', N'Morales', N'Calzada de los Heroes', N'1670', 12360, N'Zona Suroeste', 3919890134)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (17, 17, N'Gabriela', N'Castillo', N'Circuito Interior', N'3845', 12361, N'Zona Metropolitana', 3919890135)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (18, 18, N'Alejandro', N'Ruiz', N'Avenida Insurgentes', N'9276', 12362, N'Zona Histórica', 3919890136)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (19, 19, N'Patricia', N'Mendoza', N'Calle del Bosque', N'4523', 12363, N'Zona Residencial', 3919890137)
INSERT [dbo].[Subscriptor] ([id], [number], [name], [last_name], [street], [street_number], [post_code], [zone], [phone]) VALUES (20, 20, N'Ricardo', N'Vargas', N'Avenida de las Flores', N'6789', 12364, N'Zona Comercial', 3919890138)
SET IDENTITY_INSERT [dbo].[Subscriptor] OFF
GO
SET IDENTITY_INSERT [dbo].[Technicians] ON 

INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (1, 10001, N'Luis', N'Gomez', 3310194098, 1)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (2, 10002, N'Laura', N'Rodriguez', 3310194099, 1)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (3, 10003, N'Carlos', N'Perez', 3310194100, 2)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (4, 10004, N'Elena', N'Ramirez', 3310194101, 2)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (5, 10005, N'Miguel', N'Sanchez', 3310194102, 3)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (6, 10006, N'Jose', N'Torres', 3310194103, 3)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (7, 10007, N'Adriana', N'Diaz', 3310194104, 4)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (8, 10008, N'Fernando', N'Gutierrez', 3310194105, 4)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (9, 10009, N'Sofia', N'Mendez', 3310194106, 5)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (10, 10010, N'Ricardo', N'Ortega', 3310194107, 5)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (11, 10011, N'Paola', N'Martinez', 3310194108, 6)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (12, 10012, N'David', N'Gonzalez', 3310194109, 6)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (13, 10013, N'Ana', N'Vargas', 3310194110, 7)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (14, 10014, N'Javier', N'Castro', 3310194111, 7)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (15, 10015, N'Mariana', N'Flores', 3310194112, 8)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (16, 10016, N'Gabriel', N'Rojas', 3310194113, 8)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (17, 10017, N'Valentina', N'Herrera', 3310194114, 9)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (18, 10018, N'Alejandro', N'Morales', 3310194115, 9)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (19, 10019, N'Isabella', N'Jimenez', 3310194116, 10)
INSERT [dbo].[Technicians] ([id], [employee_number], [name], [last_name], [phone], [quadrille_id]) VALUES (20, 10020, N'Daniel', N'Acosta', 3310194117, 10)
SET IDENTITY_INSERT [dbo].[Technicians] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (1, N'admin@megacable.com.mx', 1, N'$2a$11$Fp1/R8n7bCX5ViSJngaJ1eUsfp1YlDR1QIieylUyA3NvDendFzKMu', N'Admin')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (2, N'luis.gomez@megacable.com.mx', 10001, N'$2a$11$N.B2HG/vGAcm1mYcI8Z9cuIEdRTbi64HxoCGB1ZdhQ2xcgDO9KmHO', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (3, N'laura.rodriguez@megacable.com.mx', 10002, N'$2a$11$2jlORK7dYkr2u64ovSX5Vu05Y07ye28.a6139NVFLryFNVYAX6roG', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (4, N'carlos.perez@megacable.com.mx', 10003, N'$2a$11$ECDWQkX4Qf0bO2u/BExMueosjXqyatwKcTrCuofG2N.KKOzuoqPu2', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (5, N'elena.ramirez@megacable.com.mx', 10004, N'$2a$11$nXNA5OUm5SqR6bS3oTYh/OiaxGhioWUCoFc5uw.LGqNfIuHiAiflO', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (6, N'miguel.sanchez@megacable.com.mx', 10005, N'$2a$11$PKUvzyNr3qFL9fj41cS3ueo7VbNB48UH5nFdC4fYiNnug3UR.o/iK', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (7, N'jose.torres@megacable.com.mx', 10006, N'$2a$11$iWoqPnn4Olfu.yVPys9AaOgE6St3vEuW2hVPiLfmv7DRlTgL.Fwdy', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (8, N'adriana.diaz@megacable.com.mx', 10007, N'$2a$11$u3QEAGRnBvxWcYw.2UXZ7eP44TimqtWQeZkZsVxozyrVMmKnBwpSC', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (9, N'fernando.gutierrez@megacable.com.mx', 10008, N'$2a$11$Gs7EIl57QSooDuW6uoGBFOOrjHPGeq.nKM3f3PgLOZOCO7XKWHY7K', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (10, N'sofia.mendez@megacable.com.mx', 10009, N'$2a$11$YsvRFMVJXNYo3YzVoK1LveD8a2WuiHDFuzfYMbpIVCPF.AMux8hgm', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (11, N'ricardo.ortega@megacable.com.mx', 10010, N'$2a$11$HhyPvCYQGKTyD.m4T2y5r.aUzvOlGV6sU8GZz1wiNy02uqRYmLFiC', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (12, N'paola.martinez@megacable.com.mx', 10011, N'$2a$11$ISmoLkRGZDa3zgLPE310D.ovoSQLkD/JApFW7QdyvX.gKiDuVUeKC', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (13, N'david.gonzalez@megacable.com.mx', 10012, N'$2a$11$hauee9A3RC1eyfcUxnLMIOpcjQbA7S57j.k3yzqbTXT8U3cz1r34S', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (14, N'ana.vargas@megacable.com.mx', 10013, N'$2a$11$oFSb5yzfXBJCE/FdT6Y/gOVHE6t/fbhjUEz7GrqzdyrhD//2I9UDq', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (15, N'javier.castro@megacable.com.mx', 10014, N'$2a$11$xFwRhg2UVu4OH0jGO2Pf6euLLVLyXHRAHWl55bRvoKOxgqvTFXd46', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (16, N'mariana.flores@megacable.com.mx', 10015, N'$2a$11$5l/6WpayQKyRL4VxFObtxeXB/Gl..rdzbSJP3bMGLp6TuN71WYrSG', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (17, N'gabriel.rojas@megacable.com.mx', 10016, N'$2a$11$xrNfzM.6LgitLKQu0m8neeCVoZJjVWAUkWuvrF5895ZBrZIJDMmNq', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (18, N'valentina.herrera@megacable.com.mx', 10017, N'$2a$11$4.EE0ssZIRRnkwSoUGEI9eKjkkIEd1788y2.p4kz25jleqxbLLUpW', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (19, N'alejandro.morales@megacable.com.mx', 10018, N'$2a$11$Pq64MIhsApsodqoK2F0afOU88vZq/YW1c9SX8aA13OaMR3hh42slW', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (20, N'isabella.jimenez@megacable.com.mx', 10019, N'$2a$11$M5LgKql4wJRDsqA87anC.eUcYZ6StufmuhvK93lDU5Gh3ZjMsNuIi', N'Tecnico')
INSERT [dbo].[Users] ([Id], [email], [num_emp], [password], [role]) VALUES (21, N'daniel.acosta@megacable.com.mx', 10020, N'$2a$11$RiEVnqnkfJyqdsJwWJc39esCYrhjtEortz6AiErNra65fQlxx2DuO', N'Tecnico')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  Index [IX_Assignments_orders_service_id]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Assignments_orders_service_id] ON [dbo].[Assignments_orders]
(
	[service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Assignments_orders_state_order]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Assignments_orders_state_order] ON [dbo].[Assignments_orders]
(
	[state_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Assignments_orders_subscriber_id]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Assignments_orders_subscriber_id] ON [dbo].[Assignments_orders]
(
	[subscriber_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Assignments_orders_technician_id]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Assignments_orders_technician_id] ON [dbo].[Assignments_orders]
(
	[technician_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_jobs_catalog_name]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_jobs_catalog_name] ON [dbo].[jobs_catalog]
(
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_jobs_catalog_points]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_jobs_catalog_points] ON [dbo].[jobs_catalog]
(
	[points] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Quadrille_quadrille_number]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Quadrille_quadrille_number] ON [dbo].[Quadrille]
(
	[quadrille_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Subscriptor_last_name_name]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Subscriptor_last_name_name] ON [dbo].[Subscriptor]
(
	[last_name] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Subscriptor_post_code]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Subscriptor_post_code] ON [dbo].[Subscriptor]
(
	[post_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Subscriptor_zone]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Subscriptor_zone] ON [dbo].[Subscriptor]
(
	[zone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Technicians_employee_number]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Technicians_employee_number] ON [dbo].[Technicians]
(
	[employee_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Technicians_last_name_name]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Technicians_last_name_name] ON [dbo].[Technicians]
(
	[last_name] ASC,
	[name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Technicians_quadrille_id]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE NONCLUSTERED INDEX [IX_Technicians_quadrille_id] ON [dbo].[Technicians]
(
	[quadrille_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Users_email]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_email] ON [dbo].[Users]
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Users_num_emp]    Script Date: 30/09/2024 06:04:44 p. m. ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Users_num_emp] ON [dbo].[Users]
(
	[num_emp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Assignments_orders] ADD  DEFAULT (getdate()) FOR [date_order]
GO
ALTER TABLE [dbo].[Assignments_orders] ADD  DEFAULT (N'Pendiente') FOR [state_order]
GO
ALTER TABLE [dbo].[Technicians] ADD  DEFAULT ((0)) FOR [quadrille_id]
GO
ALTER TABLE [dbo].[Assignments_orders]  WITH CHECK ADD  CONSTRAINT [FK_Assignments_orders_jobs_catalog_service_id] FOREIGN KEY([service_id])
REFERENCES [dbo].[jobs_catalog] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Assignments_orders] CHECK CONSTRAINT [FK_Assignments_orders_jobs_catalog_service_id]
GO
ALTER TABLE [dbo].[Assignments_orders]  WITH CHECK ADD  CONSTRAINT [FK_Assignments_orders_Subscriptor_subscriber_id] FOREIGN KEY([subscriber_id])
REFERENCES [dbo].[Subscriptor] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Assignments_orders] CHECK CONSTRAINT [FK_Assignments_orders_Subscriptor_subscriber_id]
GO
ALTER TABLE [dbo].[Assignments_orders]  WITH CHECK ADD  CONSTRAINT [FK_Assignments_orders_Technicians_technician_id] FOREIGN KEY([technician_id])
REFERENCES [dbo].[Technicians] ([id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Assignments_orders] CHECK CONSTRAINT [FK_Assignments_orders_Technicians_technician_id]
GO
ALTER TABLE [dbo].[Technicians]  WITH CHECK ADD  CONSTRAINT [FK_Technicians_Quadrille_quadrille_id] FOREIGN KEY([quadrille_id])
REFERENCES [dbo].[Quadrille] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Technicians] CHECK CONSTRAINT [FK_Technicians_Quadrille_quadrille_id]
GO
USE [master]
GO
ALTER DATABASE [MEGAHACK] SET  READ_WRITE 
GO
