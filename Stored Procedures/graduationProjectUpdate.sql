USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[graduationProjectsUpdate]    Script Date: 12/26/2022 5:29:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER procedure [dbo].[graduationProjectsUpdate] @Project_ID int, @Project_Name nvarchar(50), @Project_Department nvarchar(50), @Project_Year nvarchar(4), @Student_Name nvarchar(50)
as 
update Graduation_Projects set Project_Name=@Project_Name, Project_Department=@Project_Department, Project_Year=@Project_Year, Student_Name=@Student_Name where Project_ID=@Project_ID
