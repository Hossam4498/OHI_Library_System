USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookInsert]    Script Date: 12/26/2022 12:46:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[bookInsert] @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
insert into Books values (@Book_ID, @Book_Category, @Book_Name, @Author, @Copyright)
