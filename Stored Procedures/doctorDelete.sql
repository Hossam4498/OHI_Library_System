USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDelete]    Script Date: 12/26/2022 12:55:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doctorDelete] @Doctor_ID int
as 
delete from Doctors where Doctor_ID=@Doctor_ID
