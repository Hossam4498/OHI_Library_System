USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookGetAll]    Script Date: 12/26/2022 1:21:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[studentGetAll] @Student_ID int, @Student_Name nvarchar(50), @Student_Phone nvarchar(11), @Student_Department nvarchar(50), @Student_Year nvarchar(4)
as 
select * from Students
