USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookGetAll]    Script Date: 12/26/2022 12:50:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doctorGetAll] @Doctor_ID int, @Doctor_Name nvarchar(50), @Doctor_Phone nvarchar(11), @Doctor_Department nvarchar(50)
as 
select * from Doctors
