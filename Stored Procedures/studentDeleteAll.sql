USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDeleteAll]    Script Date: 12/26/2022 1:22:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[studentDeleteAll]
as 
delete from Students
