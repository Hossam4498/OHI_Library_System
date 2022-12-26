USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDelete]    Script Date: 12/26/2022 5:59:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[graduationProjectsDelete] @Project_ID int
as 
delete from Graduation_Projects where Project_ID=@Project_ID
