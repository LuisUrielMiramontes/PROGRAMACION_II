USE [master]
GO
/****** Object:  Database [BusinessCONVERSE_DB]    Script Date: 08/07/2021 08:58:17 a. m. ******/
CREATE DATABASE [BusinessCONVERSE_DB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BusinessCONVERSE_DB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BusinessCONVERSE_DB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BusinessCONVERSE_DB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\BusinessCONVERSE_DB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BusinessCONVERSE_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET  MULTI_USER 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET QUERY_STORE = OFF
GO
USE [BusinessCONVERSE_DB]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[idPersona] [int] NOT NULL,
	[nickname] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idCliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[color]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[color](
	[idColor] [int] IDENTITY(1,1) NOT NULL,
	[nombreColor] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idColor] PRIMARY KEY CLUSTERED 
(
	[idColor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[compra]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[fechaCompra] [date] NOT NULL,
	[precioTotalCompra] [money] NOT NULL,
	[cambioCompra] [money] NOT NULL,
	[ivaCompra] [money] NOT NULL,
	[idZapato] [int] NOT NULL,
	[idProveedor] [int] NOT NULL,
 CONSTRAINT [PK_idCompra] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_producto_compra]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_producto_compra](
	[idZapato] [int] NOT NULL,
	[idCompra] [int] NOT NULL,
	[precioCompra] [money] NOT NULL,
	[cantidadCompra] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_producto_venta]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_producto_venta](
	[idZapato] [int] NOT NULL,
	[idVenta] [int] NOT NULL,
	[precioVenta] [money] NOT NULL,
	[cantidadVenta] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_turno_puesto]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_turno_puesto](
	[idTurno] [int] NOT NULL,
	[idPuesto] [int] NOT NULL,
	[salario] [money] NOT NULL,
	[asistencia] [varchar](50) NOT NULL,
	[fechaHorario] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empleado]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[curp] [varchar](18) NOT NULL,
	[fechaNac] [date] NOT NULL,
	[estadoCivil] [varchar](11) NOT NULL,
	[idPersona] [int] NOT NULL,
	[idUsuario] [int] NOT NULL,
	[idPuesto] [int] NOT NULL,
 CONSTRAINT [PK_idEmpleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pago]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pago](
	[idPago] [int] IDENTITY(1,1) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NOT NULL,
	[salarioPagado] [money] NOT NULL,
	[estadoPago] [varchar](30) NOT NULL,
	[idEmpleado] [int] NOT NULL,
 CONSTRAINT [PK_idPago] PRIMARY KEY CLUSTERED 
(
	[idPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[persona]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[persona](
	[idPersona] [int] IDENTITY(1,1) NOT NULL,
	[nombres] [varchar](50) NOT NULL,
	[apPat] [varchar](30) NOT NULL,
	[apMat] [varchar](30) NULL,
	[sexo] [varchar](1) NOT NULL,
	[telefono] [varchar](10) NULL,
 CONSTRAINT [PK_idPersona] PRIMARY KEY CLUSTERED 
(
	[idPersona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[idZapato] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[imagen] [varchar](50) NOT NULL,
	[estilo] [varchar](30) NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [money] NOT NULL,
	[idColor] [int] NOT NULL,
 CONSTRAINT [PK_idZapato] PRIMARY KEY CLUSTERED 
(
	[idZapato] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[idProveedor] [int] IDENTITY(1,1) NOT NULL,
	[razonSocial] [varchar](50) NOT NULL,
	[telefonoProv] [varchar](10) NOT NULL,
	[emailProv] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idProveedor] PRIMARY KEY CLUSTERED 
(
	[idProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[puesto]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[puesto](
	[idPuesto] [int] IDENTITY(1,1) NOT NULL,
	[nombrePue] [varchar](50) NOT NULL,
	[salarioPue] [money] NOT NULL,
 CONSTRAINT [PK_idPuesto] PRIMARY KEY CLUSTERED 
(
	[idPuesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombreRol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_idRol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tallaH]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tallaH](
	[idTallaH] [int] IDENTITY(1,1) NOT NULL,
	[mx] [float] NOT NULL,
	[usa] [float] NOT NULL,
	[idZapato] [int] NOT NULL,
 CONSTRAINT [PK_idTallaH] PRIMARY KEY CLUSTERED 
(
	[idTallaH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tallaM]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tallaM](
	[idTallaM] [int] IDENTITY(1,1) NOT NULL,
	[mx] [float] NOT NULL,
	[usa] [float] NOT NULL,
	[idZapato] [int] NOT NULL,
 CONSTRAINT [PK_idTallaM] PRIMARY KEY CLUSTERED 
(
	[idTallaM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[turno]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[turno](
	[idTurno] [int] IDENTITY(1,1) NOT NULL,
	[nombreTurno] [varchar](50) NOT NULL,
	[horaEntrar] [date] NOT NULL,
	[horaSalir] [date] NOT NULL,
	[idPuesto] [int] NOT NULL,
 CONSTRAINT [PK_idTurno] PRIMARY KEY CLUSTERED 
(
	[idTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nombreUser] [varchar](20) NOT NULL,
	[emailUser] [varchar](50) NOT NULL,
	[passwordUser] [varchar](20) NOT NULL,
	[fechaUser] [date] NOT NULL,
	[idRol] [int] NULL,
 CONSTRAINT [PK_idUsuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 08/07/2021 08:58:18 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[idVenta] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [date] NOT NULL,
	[precioTotal] [money] NOT NULL,
	[cambio] [money] NOT NULL,
	[iva] [money] NOT NULL,
	[folio] [varchar](10) NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
 CONSTRAINT [PK_idVenta] PRIMARY KEY CLUSTERED 
(
	[idVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IDX_precioTotalCompra]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_precioTotalCompra] ON [dbo].[compra]
(
	[precioTotalCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_curp]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_curp] ON [dbo].[empleado]
(
	[curp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombres]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombres] ON [dbo].[persona]
(
	[nombres] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_nombre]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_nombre] ON [dbo].[producto]
(
	[nombre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_razonSocial]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_razonSocial] ON [dbo].[proveedor]
(
	[razonSocial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_mx]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_mx] ON [dbo].[tallaH]
(
	[mx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IDX_mx]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_mx] ON [dbo].[tallaM]
(
	[mx] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ_NombreUser]    Script Date: 08/07/2021 08:58:20 a. m. ******/
ALTER TABLE [dbo].[usuario] ADD  CONSTRAINT [UQ_NombreUser] UNIQUE NONCLUSTERED 
(
	[nombreUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IDX_folio]    Script Date: 08/07/2021 08:58:20 a. m. ******/
CREATE NONCLUSTERED INDEX [IDX_folio] ON [dbo].[venta]
(
	[folio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[cliente]  WITH CHECK ADD  CONSTRAINT [FK_idPersona_Cli] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([idPersona])
GO
ALTER TABLE [dbo].[cliente] CHECK CONSTRAINT [FK_idPersona_Cli]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_idProveedor_Compra] FOREIGN KEY([idProveedor])
REFERENCES [dbo].[proveedor] ([idProveedor])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_idProveedor_Compra]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [FK_idZapato_Compra] FOREIGN KEY([idZapato])
REFERENCES [dbo].[producto] ([idZapato])
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [FK_idZapato_Compra]
GO
ALTER TABLE [dbo].[detalle_producto_compra]  WITH CHECK ADD FOREIGN KEY([idCompra])
REFERENCES [dbo].[compra] ([idCompra])
GO
ALTER TABLE [dbo].[detalle_producto_compra]  WITH CHECK ADD FOREIGN KEY([idZapato])
REFERENCES [dbo].[producto] ([idZapato])
GO
ALTER TABLE [dbo].[detalle_producto_venta]  WITH CHECK ADD FOREIGN KEY([idVenta])
REFERENCES [dbo].[venta] ([idVenta])
GO
ALTER TABLE [dbo].[detalle_producto_venta]  WITH CHECK ADD FOREIGN KEY([idZapato])
REFERENCES [dbo].[producto] ([idZapato])
GO
ALTER TABLE [dbo].[detalle_turno_puesto]  WITH CHECK ADD FOREIGN KEY([idPuesto])
REFERENCES [dbo].[puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[detalle_turno_puesto]  WITH CHECK ADD FOREIGN KEY([idTurno])
REFERENCES [dbo].[turno] ([idTurno])
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_idPersona_Emp] FOREIGN KEY([idPersona])
REFERENCES [dbo].[persona] ([idPersona])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_idPersona_Emp]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_idPuesto_Emp] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_idPuesto_Emp]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [FK_idUsuario_Emp] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [FK_idUsuario_Emp]
GO
ALTER TABLE [dbo].[pago]  WITH CHECK ADD  CONSTRAINT [FK_idEmpleado_Pago] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[pago] CHECK CONSTRAINT [FK_idEmpleado_Pago]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_idColor_Prod] FOREIGN KEY([idColor])
REFERENCES [dbo].[color] ([idColor])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_idColor_Prod]
GO
ALTER TABLE [dbo].[tallaH]  WITH CHECK ADD  CONSTRAINT [FK_idZapato_tH] FOREIGN KEY([idZapato])
REFERENCES [dbo].[producto] ([idZapato])
GO
ALTER TABLE [dbo].[tallaH] CHECK CONSTRAINT [FK_idZapato_tH]
GO
ALTER TABLE [dbo].[tallaM]  WITH CHECK ADD  CONSTRAINT [FK_idZapato_tM] FOREIGN KEY([idZapato])
REFERENCES [dbo].[producto] ([idZapato])
GO
ALTER TABLE [dbo].[tallaM] CHECK CONSTRAINT [FK_idZapato_tM]
GO
ALTER TABLE [dbo].[turno]  WITH CHECK ADD  CONSTRAINT [FK_idPuesto_Turno] FOREIGN KEY([idPuesto])
REFERENCES [dbo].[puesto] ([idPuesto])
GO
ALTER TABLE [dbo].[turno] CHECK CONSTRAINT [FK_idPuesto_Turno]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_idRol_Usuario] FOREIGN KEY([idRol])
REFERENCES [dbo].[rol] ([idRol])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_idRol_Usuario]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_idCliente_Venta] FOREIGN KEY([idCliente])
REFERENCES [dbo].[cliente] ([idCliente])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_idCliente_Venta]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [FK_idEmpleado_Venta] FOREIGN KEY([idEmpleado])
REFERENCES [dbo].[empleado] ([idEmpleado])
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [FK_idEmpleado_Venta]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [CK_cambioCompra] CHECK  (([cambioCompra]>=(0)))
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [CK_cambioCompra]
GO
ALTER TABLE [dbo].[compra]  WITH CHECK ADD  CONSTRAINT [CK_precioTotalCompra] CHECK  (([precioTotalCompra]>(0)))
GO
ALTER TABLE [dbo].[compra] CHECK CONSTRAINT [CK_precioTotalCompra]
GO
ALTER TABLE [dbo].[detalle_producto_compra]  WITH CHECK ADD  CONSTRAINT [CK_cantidadCompra] CHECK  (([cantidadCompra]>(0)))
GO
ALTER TABLE [dbo].[detalle_producto_compra] CHECK CONSTRAINT [CK_cantidadCompra]
GO
ALTER TABLE [dbo].[detalle_producto_compra]  WITH CHECK ADD  CONSTRAINT [CK_precioCompra] CHECK  (([precioCompra]>(0)))
GO
ALTER TABLE [dbo].[detalle_producto_compra] CHECK CONSTRAINT [CK_precioCompra]
GO
ALTER TABLE [dbo].[detalle_producto_venta]  WITH CHECK ADD  CONSTRAINT [CK_cantidadVenta] CHECK  (([cantidadVenta]>(0)))
GO
ALTER TABLE [dbo].[detalle_producto_venta] CHECK CONSTRAINT [CK_cantidadVenta]
GO
ALTER TABLE [dbo].[detalle_producto_venta]  WITH CHECK ADD  CONSTRAINT [CK_precioVenta] CHECK  (([precioVenta]>(0)))
GO
ALTER TABLE [dbo].[detalle_producto_venta] CHECK CONSTRAINT [CK_precioVenta]
GO
ALTER TABLE [dbo].[detalle_turno_puesto]  WITH CHECK ADD  CONSTRAINT [CK_asistencia] CHECK  (([asistencia]='Asistió' OR [asistencia]='No asistió'))
GO
ALTER TABLE [dbo].[detalle_turno_puesto] CHECK CONSTRAINT [CK_asistencia]
GO
ALTER TABLE [dbo].[detalle_turno_puesto]  WITH CHECK ADD  CONSTRAINT [CK_salario] CHECK  (([salario]>(0)))
GO
ALTER TABLE [dbo].[detalle_turno_puesto] CHECK CONSTRAINT [CK_salario]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [CK_CURP] CHECK  (([CURP] like '[A-Z][A-Z][A-Z][A-Z][0-9][0-9][0-9][0-9][0-9][0-9][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][A-Z][0-9]'))
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [CK_CURP]
GO
ALTER TABLE [dbo].[empleado]  WITH CHECK ADD  CONSTRAINT [CK_estadoCivil] CHECK  (([estadoCivil]='Solter@' OR [estadoCivil]='Casad@' OR [estadoCivil]='Concubinad@' OR [estadoCivil]='Viud@' OR [estadoCivil]='Divorciad@'))
GO
ALTER TABLE [dbo].[empleado] CHECK CONSTRAINT [CK_estadoCivil]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_sexo] CHECK  (([sexo]='M' OR [sexo]='F'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_sexo]
GO
ALTER TABLE [dbo].[persona]  WITH CHECK ADD  CONSTRAINT [CK_telefono] CHECK  (([telefono] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[persona] CHECK CONSTRAINT [CK_telefono]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [CK_existencia] CHECK  (([stock]>=(0)))
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [CK_existencia]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [CK_precio] CHECK  (([precio]>(0)))
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [CK_precio]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv01] CHECK  (([emailProv] like '[a-z,0-9,_,-]%@[a-z,0-9,_,-]%.[a-z]%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv01]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv02] CHECK  ((NOT [emailProv] like '%[^a-z0-9@._-]%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv02]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv03] CHECK  ((NOT [emailProv] like '%@%@%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv03]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv04] CHECK  ((NOT [emailProv] like '%.@%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv04]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv05] CHECK  ((NOT [emailProv] like '%..%'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv05]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_emailProv06] CHECK  ((NOT [emailProv] like '%.'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_emailProv06]
GO
ALTER TABLE [dbo].[proveedor]  WITH CHECK ADD  CONSTRAINT [CK_telefonoProv] CHECK  (([telefonoProv] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[proveedor] CHECK CONSTRAINT [CK_telefonoProv]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser01] CHECK  (([emailUser] like '[a-z,0-9,_,-]%@[a-z,0-9,_,-]%.[a-z]%'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser01]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser02] CHECK  ((NOT [emailUser] like '%[^a-z0-9@._-]%'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser02]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser03] CHECK  ((NOT [emailUser] like '%@%@%'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser03]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser04] CHECK  ((NOT [emailUser] like '%.@%'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser04]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser05] CHECK  ((NOT [emailUser] like '%..%'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser05]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [CK_emailUser06] CHECK  ((NOT [emailUser] like '%.'))
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [CK_emailUser06]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [CK_cambio] CHECK  (([cambio]>=(0)))
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [CK_cambio]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [CK_folio] CHECK  (([folio] like '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'))
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [CK_folio]
GO
ALTER TABLE [dbo].[venta]  WITH CHECK ADD  CONSTRAINT [CK_precioTotal] CHECK  (([precioTotal]>(0)))
GO
ALTER TABLE [dbo].[venta] CHECK CONSTRAINT [CK_precioTotal]
GO
/****** Object:  StoredProcedure [dbo].[SP_RegistrarColor]    Script Date: 08/07/2021 08:58:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE PROC [dbo].[SP_RegistrarColor]
 @nombreColor VARCHAR(50)
 AS
 INSERT INTO color VALUES (@nombreColor)
GO
/****** Object:  StoredProcedure [dbo].[SP_ReporteVentas]    Script Date: 08/07/2021 08:58:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_ReporteVentas]
AS
SELECT venta.folio, venta.fecha, venta.precioTotal, detalle_producto_venta.cantidadVenta as CantidadDeProductos, producto.nombre,color.nombreColor as color ,producto.precio, tallaH.mx as TallaMXHombre, tallaH.usa as TallaUSAHombre, tallaM.mx as TallaMXMujer, tallaM.usa as TallaUSAMujer
FROM venta inner join detalle_producto_venta on venta.idVenta=detalle_producto_venta.idVenta 
			inner join producto on detalle_producto_venta.idZapato=producto.idZapato 
			inner join color on producto.idColor=color.idColor
			inner join tallaH on producto.idZapato=tallaH.idZapato 
			inner join tallaM on producto.idZapato=tallaM.idZapato 
GO
/****** Object:  StoredProcedure [dbo].[SP_SearchColor]    Script Date: 08/07/2021 08:58:20 a. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SP_SearchColor]
@Search_Color VARCHAR(50)
AS
SELECT color.idColor, color.idColor
FROM color WHERE color.nombreColor LIKE '%' + @Search_Color + '%'
GO
USE [master]
GO
ALTER DATABASE [BusinessCONVERSE_DB] SET  READ_WRITE 
GO
