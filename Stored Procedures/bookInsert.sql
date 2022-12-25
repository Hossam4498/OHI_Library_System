create procedure bookInsert @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
insert into Books values (@Book_ID, @Book_Category, @Book_Name, @Author, @Copyright)
go