USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDelete]    Script Date: 12/26/2022 6:30:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[examDelete] @Exam_ID int
as 
delete from Exams where Exam_ID=@Exam_ID
