CREATE TABLE Location
(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Country varchar(50),
Volcanoes INT
)
CREATE TABLE Volcanoes
(
Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
Name varchar(50),
LocationId INT FOREIGN KEY REFERENCES Location(Id),
Height INT
)