if not exists(select 1 from [dbo].[User])
begin
	insert into dbo.[User](FirstName, LastName, NickName, Active, DateCreated)
	values
	('Jon', 'Doe', 'JD', 1, GETDATE()),
	('Mark', 'Miller', 'Mik', 1, GETDATE()),
	('Leo', 'Fer', 'Leo', 1, GETDATE()),
	('Maria', 'DB', 'MDB', 1, GETDATE()),
	('Totilio', 'Chill', 'Toti', 1, GETDATE()),
	('Melina', 'Gonzalez', 'Meli', 1, GETDATE());
end