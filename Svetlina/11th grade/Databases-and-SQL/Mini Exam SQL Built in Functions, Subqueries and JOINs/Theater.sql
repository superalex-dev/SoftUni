USE Diablo

CREATE TABLE Actor
(
	Id INT NOT NULL  PRIMARY KEY,
	Email varchar(40) NOT NULL,
	Born datetime NOT NULL,
	Number varchar(10) NOT NULL,
)

CREATE TABLE Role
(
	Id INT NOT NULL PRIMARY KEY,
	Name varchar(60) NOT NULL,
	Play varchar(100) NOT NULL,
	Author varchar(160) NOT NULL
)


CREATE TABLE ActorRoles
(
	ActorId int NOT NULL,
	RoleId int NOT NULL,
	PRIMARY KEY (ActorId, RoleId),
	FOREIGN KEY (ActorId) REFERENCES Actor(Id),
	FOREIGN KEY (RoleId) REFERENCES Role(Id)
)