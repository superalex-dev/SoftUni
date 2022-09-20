CREATE TABLE Countries
(
Id INT NOT NULL  PRIMARY KEY,
[Name] nvarchar(30),
[Population] INT,
)

CREATE TABLE Towns
(
Id INT NOT NULL PRIMARY KEY,
[Name] nvarchar(30),
CountryId INT FOREIGN KEY REFERENCES Countries(Id) NOT NULL,
GPSLocation nvarchar(50)
)