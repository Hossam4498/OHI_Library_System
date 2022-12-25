create procedure bookGetAll @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
select * from Books
go