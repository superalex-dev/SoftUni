CREATE DATABASE SocialMedia

Use SocialMedia

CREATE TABLE Profiles(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	BirthDate Date not null,
	Email varchar(50) not null,
	Password nvarchar(50) not null
);

CREATE TABLE Posts(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	Post nvarchar(100) not null,
	UserId INT FOREIGN KEY REFERENCES Profiles(Id) not null
);


CREATE TABLE Messages(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	SenderId INt FOREIGN KEY REFERENCES Profiles(Id) not null,
	ReceiverId INT FOREIGN KEY REFERENCES Profiles(Id) not null,
	Message nvarchar(200) not null
);