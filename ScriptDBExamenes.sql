USE [master]
GO
/****** Object:  Database [Examenes]    Script Date: 09/09/2016 14:58:26 ******/
CREATE DATABASE [Examenes]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Examenes', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Examenes.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Examenes_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\LOG\Examenes_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Examenes] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Examenes].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Examenes] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Examenes] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Examenes] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Examenes] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Examenes] SET ARITHABORT OFF 
GO
ALTER DATABASE [Examenes] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Examenes] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Examenes] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Examenes] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Examenes] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Examenes] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Examenes] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Examenes] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Examenes] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Examenes] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Examenes] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Examenes] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Examenes] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Examenes] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Examenes] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Examenes] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Examenes] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Examenes] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Examenes] SET RECOVERY FULL 
GO
ALTER DATABASE [Examenes] SET  MULTI_USER 
GO
ALTER DATABASE [Examenes] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Examenes] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Examenes] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Examenes] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Examenes]
GO
/****** Object:  Table [dbo].[Asignaturas]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaturas](
	[ID_Asignatura] [nvarchar](100) NOT NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Asignaturas] PRIMARY KEY CLUSTERED 
(
	[ID_Asignatura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dificultad]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dificultad](
	[ID_Dificultad] [int] NOT NULL,
	[Descripcion] [nvarchar](20) NULL,
 CONSTRAINT [PK_Dificultad] PRIMARY KEY CLUSTERED 
(
	[ID_Dificultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ejercicio_Examen]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicio_Examen](
	[ID_EjercicioExamen] [int] IDENTITY(1,1) NOT NULL,
	[ID_Examen] [int] NULL,
	[ID_Ejercicio] [int] NULL,
 CONSTRAINT [PK_Ejercicio_Examen] PRIMARY KEY CLUSTERED 
(
	[ID_EjercicioExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Ejercicios]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ejercicios](
	[ID_Ejercicio] [int] IDENTITY(1,1) NOT NULL,
	[ID_Asignatura] [nvarchar](100) NULL,
	[ID_Tema] [int] NULL,
	[Enunciado] [nvarchar](max) NULL,
	[Valor] [float] NULL,
 CONSTRAINT [PK_Ejercicio] PRIMARY KEY CLUSTERED 
(
	[ID_Ejercicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Examenes]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Examenes](
	[ID_Examen] [int] IDENTITY(1,1) NOT NULL,
	[ID_asignatura] [nvarchar](100) NULL,
	[ID_Trimestre] [nvarchar](20) NULL,
	[ID_TipoExamen] [nvarchar](20) NULL,
	[ID_Dificultad] [int] NULL,
	[Nombre] [nvarchar](100) NULL,
	[Notas] [nvarchar](max) NULL,
	[Numero_Preguntas] [int] NULL,
	[Numero_Ejercicios] [int] NULL,
	[Numero_opciones] [int] NULL,
 CONSTRAINT [PK_Examen] PRIMARY KEY CLUSTERED 
(
	[ID_Examen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Preguntas]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas](
	[ID_Pregunta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Asignatura] [nvarchar](100) NULL,
	[ID_Tema] [int] NULL,
	[ID_Dificultad] [int] NULL,
	[Valor] [int] NULL,
 CONSTRAINT [PK_Pregunta] PRIMARY KEY CLUSTERED 
(
	[ID_Pregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Preguntas_Examen]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Preguntas_Examen](
	[ID_PreguntaExamen] [int] IDENTITY(1,1) NOT NULL,
	[ID_Examen] [int] NULL,
	[ID_Pregunta] [int] NULL,
 CONSTRAINT [PK_Preguntas_Examen] PRIMARY KEY CLUSTERED 
(
	[ID_PreguntaExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[ID_Respuesta] [int] IDENTITY(1,1) NOT NULL,
	[ID_Pregunta] [int] NULL,
	[Correcta] [bit] NULL,
 CONSTRAINT [PK_Respuesta] PRIMARY KEY CLUSTERED 
(
	[ID_Respuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Temas]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temas](
	[ID_Tema] [int] IDENTITY(1,1) NOT NULL,
	[ID_Asignatura] [nvarchar](100) NULL,
	[Descripcion] [nvarchar](max) NULL,
 CONSTRAINT [PK_Temas] PRIMARY KEY CLUSTERED 
(
	[ID_Tema] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Temas_Examen]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Temas_Examen](
	[ID_TemaExamen] [int] IDENTITY(1,1) NOT NULL,
	[ID_Examen] [int] NULL,
	[ID_Tema] [int] NULL,
 CONSTRAINT [PK_Temas_Examen] PRIMARY KEY CLUSTERED 
(
	[ID_TemaExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoExamen]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoExamen](
	[ID_TipoExamen] [nvarchar](20) NOT NULL,
	[Descripcion] [nchar](10) NULL,
 CONSTRAINT [PK_TipoExamen] PRIMARY KEY CLUSTERED 
(
	[ID_TipoExamen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Trimestre]    Script Date: 09/09/2016 14:58:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trimestre](
	[ID_Trimestre] [nvarchar](20) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Trimestre] PRIMARY KEY CLUSTERED 
(
	[ID_Trimestre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Preguntas] ADD  CONSTRAINT [DF_Preguntas_Valor]  DEFAULT ((1)) FOR [Valor]
GO
ALTER TABLE [dbo].[Ejercicio_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicio_Examen_Ejercicios] FOREIGN KEY([ID_Ejercicio])
REFERENCES [dbo].[Ejercicios] ([ID_Ejercicio])
GO
ALTER TABLE [dbo].[Ejercicio_Examen] CHECK CONSTRAINT [FK_Ejercicio_Examen_Ejercicios]
GO
ALTER TABLE [dbo].[Ejercicio_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicio_Examen_Examenes] FOREIGN KEY([ID_Examen])
REFERENCES [dbo].[Examenes] ([ID_Examen])
GO
ALTER TABLE [dbo].[Ejercicio_Examen] CHECK CONSTRAINT [FK_Ejercicio_Examen_Examenes]
GO
ALTER TABLE [dbo].[Ejercicios]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicios_Asignaturas] FOREIGN KEY([ID_Asignatura])
REFERENCES [dbo].[Asignaturas] ([ID_Asignatura])
GO
ALTER TABLE [dbo].[Ejercicios] CHECK CONSTRAINT [FK_Ejercicios_Asignaturas]
GO
ALTER TABLE [dbo].[Ejercicios]  WITH CHECK ADD  CONSTRAINT [FK_Ejercicios_Temas] FOREIGN KEY([ID_Tema])
REFERENCES [dbo].[Temas] ([ID_Tema])
GO
ALTER TABLE [dbo].[Ejercicios] CHECK CONSTRAINT [FK_Ejercicios_Temas]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_Asignaturas] FOREIGN KEY([ID_asignatura])
REFERENCES [dbo].[Asignaturas] ([ID_Asignatura])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_Asignaturas]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_Dificultad] FOREIGN KEY([ID_Dificultad])
REFERENCES [dbo].[Dificultad] ([ID_Dificultad])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_Dificultad]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_TipoExamen] FOREIGN KEY([ID_TipoExamen])
REFERENCES [dbo].[TipoExamen] ([ID_TipoExamen])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_TipoExamen]
GO
ALTER TABLE [dbo].[Examenes]  WITH CHECK ADD  CONSTRAINT [FK_Examenes_Trimestre] FOREIGN KEY([ID_Trimestre])
REFERENCES [dbo].[Trimestre] ([ID_Trimestre])
GO
ALTER TABLE [dbo].[Examenes] CHECK CONSTRAINT [FK_Examenes_Trimestre]
GO
ALTER TABLE [dbo].[Preguntas_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Preguntas_Examen_Examenes] FOREIGN KEY([ID_Examen])
REFERENCES [dbo].[Examenes] ([ID_Examen])
GO
ALTER TABLE [dbo].[Preguntas_Examen] CHECK CONSTRAINT [FK_Preguntas_Examen_Examenes]
GO
ALTER TABLE [dbo].[Preguntas_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Preguntas_Examen_Preguntas] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Preguntas] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[Preguntas_Examen] CHECK CONSTRAINT [FK_Preguntas_Examen_Preguntas]
GO
ALTER TABLE [dbo].[Respuestas]  WITH CHECK ADD  CONSTRAINT [FK_Respuesta_Pregunta] FOREIGN KEY([ID_Pregunta])
REFERENCES [dbo].[Preguntas] ([ID_Pregunta])
GO
ALTER TABLE [dbo].[Respuestas] CHECK CONSTRAINT [FK_Respuesta_Pregunta]
GO
ALTER TABLE [dbo].[Temas]  WITH CHECK ADD  CONSTRAINT [FK_Temas_Asignaturas] FOREIGN KEY([ID_Asignatura])
REFERENCES [dbo].[Asignaturas] ([ID_Asignatura])
GO
ALTER TABLE [dbo].[Temas] CHECK CONSTRAINT [FK_Temas_Asignaturas]
GO
ALTER TABLE [dbo].[Temas_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Temas_Examen_Examenes] FOREIGN KEY([ID_Examen])
REFERENCES [dbo].[Examenes] ([ID_Examen])
GO
ALTER TABLE [dbo].[Temas_Examen] CHECK CONSTRAINT [FK_Temas_Examen_Examenes]
GO
ALTER TABLE [dbo].[Temas_Examen]  WITH CHECK ADD  CONSTRAINT [FK_Temas_Examen_Temas] FOREIGN KEY([ID_Tema])
REFERENCES [dbo].[Temas] ([ID_Tema])
GO
ALTER TABLE [dbo].[Temas_Examen] CHECK CONSTRAINT [FK_Temas_Examen_Temas]
GO
USE [master]
GO
ALTER DATABASE [Examenes] SET  READ_WRITE 
GO
