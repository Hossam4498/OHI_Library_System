USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[doctorsInsert]    Script Date: 12/26/2022 12:48:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doctorInsert] @Doctor_ID int, @Doctor_Name nvarchar(50), @Doctor_Phone nvarchar(11), @Doctor_Department nvarchar(50)
as 
insert into Doctors values (@Doctor_ID, @Doctor_Name, @Doctor_Phone, @Doctor_Department)
