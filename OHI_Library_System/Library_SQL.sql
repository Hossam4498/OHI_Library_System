USE [master]
GO
/****** Object:  Database [Library]    Script Date: 12/25/2022 10:46:43 AM ******/
CREATE DATABASE [Library] ON  PRIMARY 
( NAME = N'Library', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Library.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Library_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Book_ID] [int] NOT NULL,
	[Book_Category] [nvarchar](50) NULL,
	[Book_Name] [nvarchar](50) NULL,
	[Author] [nvarchar](50) NULL,
	[Copyright] [nvarchar](4) NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Book_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow_A_Book]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_A_Book](
	[ID] [int] NOT NULL,
	[Book_ID] [int] NULL,
	[Book_Name] [nvarchar](50) NULL,
	[Start_Date] [nvarchar](50) NULL,
	[End_Date] [nvarchar](50) NULL,
	[Student_ID] [int] NULL,
	[Doctor_ID] [int] NULL,
 CONSTRAINT [PK_Borrow_A_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Borrow_A_Tool]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrow_A_Tool](
	[ID] [int] NOT NULL,
	[Tool_ID] [int] NULL,
	[Tool_Name] [nvarchar](50) NULL,
	[Student_ID] [int] NULL,
 CONSTRAINT [PK_Borrow_A_Tool] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctors]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctors](
	[Doctor_ID] [int] NOT NULL,
	[Doctor_Name] [nvarchar](50) NULL,
	[Doctor_Phone] [nvarchar](11) NULL,
	[Doctor_Department] [nvarchar](50) NULL,
 CONSTRAINT [PK_Doctors] PRIMARY KEY CLUSTERED 
(
	[Doctor_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exams]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exams](
	[Exam_ID] [int] NOT NULL,
	[Exam_Description] [nvarchar](50) NULL,
	[Doctor_ID] [int] NULL,
 CONSTRAINT [PK_Exams] PRIMARY KEY CLUSTERED 
(
	[Exam_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Graduation_Projects]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Graduation_Projects](
	[Project_ID] [int] NOT NULL,
	[Project_Name] [nvarchar](50) NULL,
	[Project_Department] [nvarchar](50) NULL,
	[Project_Year] [nvarchar](4) NULL,
	[Student_ID] [int] NULL,
 CONSTRAINT [PK_Graduation Projects] PRIMARY KEY CLUSTERED 
(
	[Project_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Librarian]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Librarian](
	[Librarian_ID] [int] NOT NULL,
	[Librarian_Name] [nvarchar](50) NULL,
	[Librarian_Email] [nvarchar](50) NULL,
	[Librarian_Password] [nvarchar](50) NULL,
 CONSTRAINT [PK_Librarian] PRIMARY KEY CLUSTERED 
(
	[Librarian_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Read_A_Book]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Read_A_Book](
	[ID] [int] NOT NULL,
	[Book_ID] [int] NULL,
	[Book_Category] [nvarchar](50) NULL,
	[Book_Name] [nvarchar](50) NULL,
	[Student_ID] [int] NULL,
	[Doctor_ID] [int] NULL,
 CONSTRAINT [PK_Read_A_Book] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Store]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Store](
	[Store_ID] [int] NOT NULL,
	[Store_Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Store] PRIMARY KEY CLUSTERED 
(
	[Store_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Students](
	[Student_ID] [int] NOT NULL,
	[Student_Name] [nvarchar](50) NULL,
	[Student_Phone] [nvarchar](11) NULL,
	[Student_Department] [nvarchar](50) NULL,
	[Student_Year] [nvarchar](4) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[Student_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tools]    Script Date: 12/25/2022 10:46:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tools](
	[Tool_ID] [int] NOT NULL,
	[Tool_Name] [nvarchar](50) NULL,
	[Tool_Description] [nvarchar](50) NULL,
 CONSTRAINT [PK_Tools] PRIMARY KEY CLUSTERED 
(
	[Tool_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Borrow_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_A_Book_Books] FOREIGN KEY([Book_ID])
REFERENCES [dbo].[Books] ([Book_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borrow_A_Book] CHECK CONSTRAINT [FK_Borrow_A_Book_Books]
GO
ALTER TABLE [dbo].[Borrow_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_A_Book_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([Doctor_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borrow_A_Book] CHECK CONSTRAINT [FK_Borrow_A_Book_Doctors]
GO
ALTER TABLE [dbo].[Borrow_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_A_Book_Students] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([Student_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borrow_A_Book] CHECK CONSTRAINT [FK_Borrow_A_Book_Students]
GO
ALTER TABLE [dbo].[Borrow_A_Tool]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_A_Tool_Students] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([Student_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borrow_A_Tool] CHECK CONSTRAINT [FK_Borrow_A_Tool_Students]
GO
ALTER TABLE [dbo].[Borrow_A_Tool]  WITH CHECK ADD  CONSTRAINT [FK_Borrow_A_Tool_Tools] FOREIGN KEY([Tool_ID])
REFERENCES [dbo].[Tools] ([Tool_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Borrow_A_Tool] CHECK CONSTRAINT [FK_Borrow_A_Tool_Tools]
GO
ALTER TABLE [dbo].[Exams]  WITH CHECK ADD  CONSTRAINT [FK_Exams_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([Doctor_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Exams] CHECK CONSTRAINT [FK_Exams_Doctors]
GO
ALTER TABLE [dbo].[Graduation_Projects]  WITH CHECK ADD  CONSTRAINT [FK_Graduation_Projects_Students] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([Student_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Graduation_Projects] CHECK CONSTRAINT [FK_Graduation_Projects_Students]
GO
ALTER TABLE [dbo].[Read_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Read_A_Book_Books] FOREIGN KEY([Book_ID])
REFERENCES [dbo].[Books] ([Book_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Read_A_Book] CHECK CONSTRAINT [FK_Read_A_Book_Books]
GO
ALTER TABLE [dbo].[Read_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Read_A_Book_Doctors] FOREIGN KEY([Doctor_ID])
REFERENCES [dbo].[Doctors] ([Doctor_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Read_A_Book] CHECK CONSTRAINT [FK_Read_A_Book_Doctors]
GO
ALTER TABLE [dbo].[Read_A_Book]  WITH CHECK ADD  CONSTRAINT [FK_Read_A_Book_Students] FOREIGN KEY([Student_ID])
REFERENCES [dbo].[Students] ([Student_ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Read_A_Book] CHECK CONSTRAINT [FK_Read_A_Book_Students]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
