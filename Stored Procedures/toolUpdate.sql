USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[examsUpdate]    Script Date: 12/26/2022 5:30:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[toolsUpdate] @Tool_ID int, @Tool_Name nvarchar(50), @Tool_Description nvarchar(50)
as 
update Tools set Tool_Name=@Tool_Name, Tool_Description=@Tool_Description where Tool_ID=@Tool_ID
