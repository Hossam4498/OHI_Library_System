USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookGetAll]    Script Date: 12/26/2022 6:28:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[examGetAll] @Exam_ID int, @Exam_Description nvarchar(50), @Doctor_ID int
as 
select * from Exams
