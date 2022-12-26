USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookGetAll]    Script Date: 12/26/2022 5:53:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[graduationProjectsGetAll] @Project_ID int, @Project_Name nvarchar(50), @Project_Department nvarchar(50), @Project_Year nvarchar(4), @Student_Name nvarchar(50)
as 
select * from Graduation_Projects
