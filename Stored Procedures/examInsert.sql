USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookInsert]    Script Date: 12/26/2022 6:26:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[examInsert] @Exam_ID int, @Exam_Description nvarchar(50), @Doctor_ID int
as 
insert into Exams values (@Exam_ID, @Exam_Description, @Doctor_ID)
