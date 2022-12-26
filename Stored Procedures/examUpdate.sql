USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookUpdate]    Script Date: 12/26/2022 5:14:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[examsUpdate] @Exam_ID int, @Exam_Description nvarchar(50), @Doctor_ID int
as 
update Exams set Exam_Description=@Exam_Description, Doctor_ID=@Doctor_ID where Exam_ID=@Exam_ID
