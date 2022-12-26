create procedure bookDelete @Book_ID int
as 
delete from Books where Book_ID=@Book_ID
go