USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookInsert]    Script Date: 12/26/2022 5:34:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[graduationProjectsInsert] @Project_ID int, @Project_Name nvarchar(50), @Project_Department nvarchar(50), @Project_Year nvarchar(4), @Student_Name nvarchar(50)
as 
insert into Graduation_Projects values (@Project_ID, @Project_Name, @Project_Department, @Project_Year, @Student_Name)
