USE [Library]
GO
/****** Object:  StoredProcedure [dbo].[bookDeleteAll]    Script Date: 12/26/2022 12:52:33 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[doctorDeleteAll]
as 
delete from Doctors
