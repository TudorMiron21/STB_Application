USE [master]
GO
/****** Object:  Database [STB_app]    Script Date: 12/1/2022 2:08:23 PM ******/
CREATE DATABASE [STB_app]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'STB_app', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\STB_app.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'STB_app_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\STB_app_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [STB_app] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [STB_app].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [STB_app] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [STB_app] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [STB_app] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [STB_app] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [STB_app] SET ARITHABORT OFF 
GO
ALTER DATABASE [STB_app] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [STB_app] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [STB_app] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [STB_app] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [STB_app] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [STB_app] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [STB_app] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [STB_app] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [STB_app] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [STB_app] SET  DISABLE_BROKER 
GO
ALTER DATABASE [STB_app] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [STB_app] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [STB_app] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [STB_app] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [STB_app] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [STB_app] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [STB_app] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [STB_app] SET RECOVERY FULL 
GO
ALTER DATABASE [STB_app] SET  MULTI_USER 
GO
ALTER DATABASE [STB_app] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [STB_app] SET DB_CHAINING OFF 
GO
ALTER DATABASE [STB_app] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [STB_app] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [STB_app] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [STB_app] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'STB_app', N'ON'
GO
ALTER DATABASE [STB_app] SET QUERY_STORE = OFF
GO
USE [STB_app]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/1/2022 2:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[PersonType] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Person]    Script Date: 12/1/2022 2:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Person](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](16) NOT NULL,
	[SecondName] [nvarchar](16) NOT NULL,
	[UserName] [nvarchar](32) NOT NULL,
	[Passw] [nvarchar](32) NOT NULL,
	[CategoryId] [int] NULL,
	[Email] [nvarchar](32) NULL,
	[PhoneNumber] [nvarchar](16) NULL,
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Routes]    Script Date: 12/1/2022 2:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Routes](
	[RouteId] [int] IDENTITY(1,1) NOT NULL,
	[StationDepartureId] [int] NOT NULL,
	[StationArrivalId] [int] NOT NULL,
 CONSTRAINT [PK_Route] PRIMARY KEY CLUSTERED 
(
	[RouteId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stations]    Script Date: 12/1/2022 2:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stations](
	[StationId] [int] IDENTITY(1,1) NOT NULL,
	[StationName] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_Station] PRIMARY KEY CLUSTERED 
(
	[StationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubscriptionHistory]    Script Date: 12/1/2022 2:08:23 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubscriptionHistory](
	[SubscriptionId] [int] IDENTITY(1,1) NOT NULL,
	[PersonId] [int] NOT NULL,
	[DateStart] [date] NOT NULL,
	[DateFinish] [date] NOT NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_SubscriptionHistory] PRIMARY KEY CLUSTERED 
(
	[SubscriptionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [FK_Person] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [FK_Person]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [FK1_Route] FOREIGN KEY([StationDepartureId])
REFERENCES [dbo].[Stations] ([StationId])
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [FK1_Route]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [FK2_Route] FOREIGN KEY([StationArrivalId])
REFERENCES [dbo].[Stations] ([StationId])
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [FK2_Route]
GO
ALTER TABLE [dbo].[SubscriptionHistory]  WITH CHECK ADD  CONSTRAINT [FK_SubscriptionHistory] FOREIGN KEY([PersonId])
REFERENCES [dbo].[Person] ([PersonId])
GO
ALTER TABLE [dbo].[SubscriptionHistory] CHECK CONSTRAINT [FK_SubscriptionHistory]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [CHK_Password] CHECK  ((len([Passw])>=(5)))
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [CHK_Password]
GO
ALTER TABLE [dbo].[Person]  WITH CHECK ADD  CONSTRAINT [CHK_Persoana] CHECK  ((isnumeric([PhoneNumber])=(1) AND len([PhoneNumber])=(10)))
GO
ALTER TABLE [dbo].[Person] CHECK CONSTRAINT [CHK_Persoana]
GO
ALTER TABLE [dbo].[Routes]  WITH CHECK ADD  CONSTRAINT [CHK_Route] CHECK  (([StationDepartureId]<>[StationArrivalId]))
GO
ALTER TABLE [dbo].[Routes] CHECK CONSTRAINT [CHK_Route]
GO
ALTER TABLE [dbo].[SubscriptionHistory]  WITH CHECK ADD  CONSTRAINT [CHK_SubscriptionHistory] CHECK  (([DateFinish]>[DateStart]))
GO
ALTER TABLE [dbo].[SubscriptionHistory] CHECK CONSTRAINT [CHK_SubscriptionHistory]
GO


if OBJECT_ID('RefRouteSubscription', 'U') is not null
drop table RefRouteSubscription
go 
create table RefRouteSubscription
(
	RefId int identity(1,1),
	RouteId int not null,
	SubscriptionId int not null,

	constraint PK_Ref primary key (RefId),
	constraint FK1_ref foreign key (RouteId) references [dbo].[Routes](RouteId),
	constraint FK2_ref foreign key (SubscriptionId) references SubscriptionHistory(SubscriptionId)
)

if OBJECT_ID('TicketHistory', 'U') is not null
drop table TicketHistory
go 
create table TicketHistory
(
	TicketId int identity(100000,1),
	PersonId int not null,
	RouteId int not null,

	constraint PK_Ticket primary key (TicketId),
	constraint FK1_Ticket foreign key (PersonId) references Person(PersonId),
	constraint FK2_Ticket foreign key (RouteId) references Routes(RouteId)
)



USE [master]
GO
ALTER DATABASE [STB_app] SET  READ_WRITE 
GO


if OBJECT_ID('CardDetails', 'U') is not null
drop table CardDetails
go 
create table CardDetails(

	CardId int identity(1,1),
	PersoanaId int not null,
	NumarCard nvarchar(16)not null,
	DataExpirare nvarchar(8)not null,
	CVV nvarchar(3)not null,

	constraint CHK1_CardDetails check (isnumeric(NumarCard) = 1 and len(NumarCard) = 16),
	constraint CHK2_CardDetails check (isnumeric(CVV) = 1 and len(CVV) = 3),
	constraint PK_CardDetails primary key (CardId),
	constraint FK_CardDetails foreign key (PersoanaId) references Person(PersonId),

)

alter table Routes
drop FK1_Route

alter table Routes
drop FK2_Route

alter table Routes
drop CHK_Route

alter table Routes
drop column StationDepartureId


alter table Routes
drop column StationArrivalId


if OBJECT_ID('RefStationRoute', 'U') is not null
drop table RefStationRoute
go 
create table RefStationRoute(

	Id int identity(1,1),
	RouteId int not null,
	StationId int not null,

	constraint PK_RefStRo primary key (Id),
	constraint FK_Ref1 foreign key (RouteId) references Routes(RouteId),
	constraint FK_Ref2 foreign key (StationId) references Stations(StationId)

)

