USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDelete]    Script Date: 12/26/2022 1:23:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[studentDelete] @Student_ID int
as 
delete from Students where Student_ID=@Student_ID
