USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[doctorUpdate]    Script Date: 12/26/2022 1:06:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doctorUpdate] @Doctor_ID int, @Doctor_Name nvarchar(50), @Doctor_Phone nvarchar(11), @Doctor_Department nvarchar(50)
as 
update Doctors set Doctor_Name=@Doctor_Name, Doctor_Phone=@Doctor_Phone, Doctor_Department=@Doctor_Department where Doctor_ID=@Doctor_ID
