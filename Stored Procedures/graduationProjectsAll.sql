USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDeleteAll]    Script Date: 12/26/2022 5:56:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[graduationProjectsDeleteAll]
as 
delete from Graduation_Projects
