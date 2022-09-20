USE BookLibrary
CREATE TABLE Book (
	Id int primary key identity(1,1),
	Title nchar(50),
	Description nvarchar(250),
	Author  nvarchar(50)
)