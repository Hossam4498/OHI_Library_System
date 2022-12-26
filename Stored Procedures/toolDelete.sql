USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDelete]    Script Date: 12/26/2022 6:25:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[toolDelete] @Tool_ID int
as 
delete from Tools where Tool_ID=@Tool_ID
