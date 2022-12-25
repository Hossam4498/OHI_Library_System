create procedure bookUpdate @Book_ID int, @Book_Category nvarchar(50), @Book_Name nvarchar(50), @Author nvarchar(50), @Copyright nvarchar(4)
as 
update Books set Book_Category=@Book_Category, Book_Name=@Book_Name, Author=@Author, Copyright=@Copyright where Book_ID=@Book_ID
go