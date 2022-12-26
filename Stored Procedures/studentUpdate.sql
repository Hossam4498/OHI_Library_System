USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookUpdate]    Script Date: 12/26/2022 1:14:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[studentUpdate] @Student_ID int, @Student_Name nvarchar(50), @Student_Phone nvarchar(11), @Student_Department nvarchar(50), @Student_Year nvarchar(4)
as 
update Students set Student_Name=@Student_Name, Student_Phone=@Student_Phone, Student_Department=@Student_Department, Student_Year=@Student_Year where Student_ID=@Student_ID
