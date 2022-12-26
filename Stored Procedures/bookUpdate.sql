USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookUpdate]    Script Date: 12/26/2022 12:47:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[bookUpdate] @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
update Books set Book_Category=@Book_Category, Book_Name=@Book_Name, Author=@Author, Copyright=@Copyright where Book_ID=@Book_ID
