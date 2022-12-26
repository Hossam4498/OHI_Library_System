USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookInsert]    Script Date: 12/26/2022 6:20:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[toolInsert] @Tool_ID int, @Tool_Name nvarchar(50), @Tool_Description nvarchar(50)
as 
insert into Tools values (@Tool_ID, @Tool_Name, @Tool_Description)
