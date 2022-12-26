USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookGetAll]    Script Date: 12/26/2022 6:23:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[toolGetAll] @Tool_ID int, @Tool_Name nvarchar(50), @Tool_Description nvarchar(50)
as 
select * from Tools