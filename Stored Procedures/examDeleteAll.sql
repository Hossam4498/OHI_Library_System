USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDeleteAll]    Script Date: 12/26/2022 6:29:22 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[examDeleteAll]
as 
delete from Exams
