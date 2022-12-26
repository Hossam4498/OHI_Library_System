USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookInsert]    Script Date: 12/26/2022 1:18:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[studentInsert] @Student_ID int, @Student_Name nvarchar(50), @Student_Phone nvarchar(11), @Student_Department nvarchar(50), @Student_Year nvarchar(4)
as 
insert into Students values (@Student_ID, @Student_Name, @Student_Phone, @Student_Department, @Student_Year)
