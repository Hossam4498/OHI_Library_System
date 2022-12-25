create procedure bookDelete @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
delete from Books where Book_ID=@Book_ID
go